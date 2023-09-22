using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.IO;
using System.Configuration;

namespace CatalogoArticulos
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                }

                

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImagen = txtImagen.Text;
                if(txtPrecio.Text != "")
                    articulo.Precio = decimal.Parse(txtPrecio.Text);

                bool camposVacios = false;

                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "")
                    camposVacios = true;

                                    
               if (camposVacios)
                   MessageBox.Show("Por favor rellene los campos vacíos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else { 
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                    }
                    else 
                    { 

                     negocio.agregar(articulo);
                     MessageBox.Show("Agregado exitosamente");
                     Close();
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pcbImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
    }

        
    }

