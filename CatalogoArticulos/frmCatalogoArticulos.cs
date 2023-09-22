using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace CatalogoArticulos
{
    public partial class frmCatalogoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogoArticulos()
        {
            InitializeComponent();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void frmCatalogoArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");

            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";

            txtFiltro.Enabled = false;
            
        }


        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].UrlImagen);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns[6].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;


        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            

            if (dgvArticulos.CurrentRow != null)
            {
                Articulo art;
                art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo modificar = new frmAltaArticulo(art);
                modificar.ShowDialog();
                cargar();
            }


                
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null) 
                { 
                DataGridViewRow seleccionada = dgvArticulos.SelectedRows[0];

                string codigo = seleccionada.Cells["Codigo"].Value.ToString();
                string nombre = seleccionada.Cells["Nombre"].Value.ToString();
                string descripcion = seleccionada.Cells["Descripcion"].Value.ToString();
                string marca = seleccionada.Cells["Marca"].Value.ToString();
                string categoria = seleccionada.Cells["Categoria"].Value.ToString();
                string precio = seleccionada.Cells["Precio"].Value.ToString();
                string precioFormateado = string.Format("{0:N2}", Convert.ToDecimal(precio));
                

                string detalle = "Categoría: " + categoria + "\r\n" + "Marca: " + marca + "\r\n" + "Código: " + codigo + "\r\n" + "Nombre: " + nombre + "\r\n" + "Descripción: " + descripcion + "\r\n" + "Precio: $" + precioFormateado;

                lblDetalle.Text = detalle;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }
      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado;

            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que querés borrar este registro de la base de datos?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            txtFiltro.Text = "";

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }

            txtFiltro.Enabled = true;

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                
                lblDetalle.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool soloNumeros(string cadena)
        {
            if (decimal.TryParse(cadena, out _))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para filtrar");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para filtrar");
                return true;
            }
            if(cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debe ingresar un valor para el precio.");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Sólo números para filtrar por precio.");
                    return true;
                }
                
            }
            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                

                if (cboCampo.SelectedItem.ToString() == "Precio")
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar != 46)
                        e.Handled = true;
                    if (txtFiltro.Text.Contains(".") && e.KeyChar == '.')
                        e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        


    }
}
