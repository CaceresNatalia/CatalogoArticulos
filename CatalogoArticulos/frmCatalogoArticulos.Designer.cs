
namespace CatalogoArticulos
{
    partial class frmCatalogoArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.grbFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.grbBotones.SuspendLayout();
            this.grbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvArticulos.Location = new System.Drawing.Point(49, 178);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(670, 285);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.Transparent;
            this.pbxArticulo.Location = new System.Drawing.Point(753, 178);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(384, 285);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(142, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifcar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifcar.Location = new System.Drawing.Point(15, 24);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(102, 36);
            this.btnModifcar.TabIndex = 3;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Lavender;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDetalle.Location = new System.Drawing.Point(49, 530);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(102, 36);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // grbBotones
            // 
            this.grbBotones.BackColor = System.Drawing.Color.AliceBlue;
            this.grbBotones.Controls.Add(this.btnEliminar);
            this.grbBotones.Controls.Add(this.btnModifcar);
            this.grbBotones.Controls.Add(this.btnAgregar);
            this.grbBotones.Location = new System.Drawing.Point(564, 506);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(384, 80);
            this.grbBotones.TabIndex = 5;
            this.grbBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(269, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 36);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(173, 487);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(0, 18);
            this.lblDetalle.TabIndex = 6;
            // 
            // grbFiltro
            // 
            this.grbFiltro.BackColor = System.Drawing.Color.AliceBlue;
            this.grbFiltro.Controls.Add(this.txtFiltro);
            this.grbFiltro.Controls.Add(this.cboCriterio);
            this.grbFiltro.Controls.Add(this.cboCampo);
            this.grbFiltro.Controls.Add(this.btnFiltro);
            this.grbFiltro.Controls.Add(this.lblCriterio);
            this.grbFiltro.Controls.Add(this.lblCampo);
            this.grbFiltro.Location = new System.Drawing.Point(113, 44);
            this.grbFiltro.Name = "grbFiltro";
            this.grbFiltro.Size = new System.Drawing.Size(961, 100);
            this.grbFiltro.TabIndex = 7;
            this.grbFiltro.TabStop = false;
            this.grbFiltro.Text = "Búsqueda avanzada:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.AccessibleDescription = "";
            this.txtFiltro.Location = new System.Drawing.Point(641, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(154, 25);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(451, 42);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(151, 26);
            this.cboCriterio.TabIndex = 4;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(141, 42);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(161, 26);
            this.cboCampo.TabIndex = 3;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Lavender;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltro.Location = new System.Drawing.Point(834, 40);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(89, 31);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(341, 46);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(71, 18);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(38, 46);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(64, 18);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Lavender;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Location = new System.Drawing.Point(1035, 530);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmCatalogoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1187, 616);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grbFiltro);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.grbBotones);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Clarendon Lt BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCatalogoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Artículos";
            this.Load += new System.EventHandler(this.frmCatalogoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.grbBotones.ResumeLayout(false);
            this.grbFiltro.ResumeLayout(false);
            this.grbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.GroupBox grbBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.GroupBox grbFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCerrar;
    }
}

