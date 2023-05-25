namespace Presentacion
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaArt = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanz = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAgMarca = new System.Windows.Forms.Button();
            this.btnAgCat = new System.Windows.Forms.Button();
            this.lblNombreSelec = new System.Windows.Forms.Label();
            this.lblDescSelec = new System.Windows.Forms.Label();
            this.lblMarcaSelec = new System.Windows.Forms.Label();
            this.lblPrecioSelec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaArt
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvListaArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArt.Location = new System.Drawing.Point(28, 81);
            this.dgvListaArt.MultiSelect = false;
            this.dgvListaArt.Name = "dgvListaArt";
            this.dgvListaArt.RowHeadersWidth = 62;
            this.dgvListaArt.RowTemplate.Height = 28;
            this.dgvListaArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArt.Size = new System.Drawing.Size(992, 273);
            this.dgvListaArt.TabIndex = 0;
            this.dgvListaArt.SelectionChanged += new System.EventHandler(this.dgvListaArt_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(1060, 13);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(298, 404);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(28, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 46);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(230, 370);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 46);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(440, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(28, 14);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(275, 22);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Búsqueda por marca o categoría:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(32, 40);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(218, 28);
            this.txtFiltroRapido.TabIndex = 4;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Campo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criterio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtro:";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(87, 40);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(157, 28);
            this.cmbCampo.TabIndex = 6;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(361, 40);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(183, 28);
            this.cmbCriterio.TabIndex = 7;
            // 
            // txtFiltroAvanz
            // 
            this.txtFiltroAvanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanz.Location = new System.Drawing.Point(643, 38);
            this.txtFiltroAvanz.Name = "txtFiltroAvanz";
            this.txtFiltroAvanz.Size = new System.Drawing.Size(184, 28);
            this.txtFiltroAvanz.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(861, 35);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(97, 36);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAgMarca
            // 
            this.btnAgMarca.Location = new System.Drawing.Point(32, 562);
            this.btnAgMarca.Name = "btnAgMarca";
            this.btnAgMarca.Size = new System.Drawing.Size(143, 46);
            this.btnAgMarca.TabIndex = 10;
            this.btnAgMarca.Text = "Agregar Marca";
            this.btnAgMarca.UseVisualStyleBackColor = true;
            this.btnAgMarca.Click += new System.EventHandler(this.btnAgMarca_Click);
            // 
            // btnAgCat
            // 
            this.btnAgCat.Location = new System.Drawing.Point(230, 562);
            this.btnAgCat.Name = "btnAgCat";
            this.btnAgCat.Size = new System.Drawing.Size(143, 46);
            this.btnAgCat.TabIndex = 10;
            this.btnAgCat.Text = "Agregar Categ";
            this.btnAgCat.UseVisualStyleBackColor = true;
            this.btnAgCat.Click += new System.EventHandler(this.btnAgCat_Click);
            // 
            // lblNombreSelec
            // 
            this.lblNombreSelec.AutoSize = true;
            this.lblNombreSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSelec.Location = new System.Drawing.Point(1091, 468);
            this.lblNombreSelec.Name = "lblNombreSelec";
            this.lblNombreSelec.Size = new System.Drawing.Size(87, 25);
            this.lblNombreSelec.TabIndex = 11;
            this.lblNombreSelec.Text = "Nombre:";
            // 
            // lblDescSelec
            // 
            this.lblDescSelec.AutoSize = true;
            this.lblDescSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSelec.Location = new System.Drawing.Point(1091, 506);
            this.lblDescSelec.Name = "lblDescSelec";
            this.lblDescSelec.Size = new System.Drawing.Size(120, 25);
            this.lblDescSelec.TabIndex = 11;
            this.lblDescSelec.Text = "Descripción:";
            // 
            // lblMarcaSelec
            // 
            this.lblMarcaSelec.AutoSize = true;
            this.lblMarcaSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaSelec.Location = new System.Drawing.Point(1091, 544);
            this.lblMarcaSelec.Name = "lblMarcaSelec";
            this.lblMarcaSelec.Size = new System.Drawing.Size(73, 25);
            this.lblMarcaSelec.TabIndex = 11;
            this.lblMarcaSelec.Text = "Marca:";
            // 
            // lblPrecioSelec
            // 
            this.lblPrecioSelec.AutoSize = true;
            this.lblPrecioSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSelec.Location = new System.Drawing.Point(1091, 581);
            this.lblPrecioSelec.Name = "lblPrecioSelec";
            this.lblPrecioSelec.Size = new System.Drawing.Size(73, 25);
            this.lblPrecioSelec.TabIndex = 11;
            this.lblPrecioSelec.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1091, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Características:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCriterio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroAvanz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Avanzado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1478, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecioSelec);
            this.Controls.Add(this.lblMarcaSelec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescSelec);
            this.Controls.Add(this.lblNombreSelec);
            this.Controls.Add(this.btnAgCat);
            this.Controls.Add(this.btnAgMarca);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvListaArt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 704);
            this.MinimumSize = new System.Drawing.Size(1500, 704);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoProductos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaArt;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanz;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAgMarca;
        private System.Windows.Forms.Button btnAgCat;
        private System.Windows.Forms.Label lblNombreSelec;
        private System.Windows.Forms.Label lblDescSelec;
        private System.Windows.Forms.Label lblMarcaSelec;
        private System.Windows.Forms.Label lblPrecioSelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

