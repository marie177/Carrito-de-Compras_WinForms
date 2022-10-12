namespace TPWinForm_Gottig_Ramirez
{
    partial class frmAgregarArt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArt));
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbVistaPrevia = new System.Windows.Forms.GroupBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.tbxImagenUrl = new System.Windows.Forms.TextBox();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodIncorrecto = new System.Windows.Forms.Label();
            this.lblNombreInvalido = new System.Windows.Forms.Label();
            this.lblPrecioInvalido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbVistaPrevia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregar.Location = new System.Drawing.Point(348, 29);
            this.lblTituloAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(149, 25);
            this.lblTituloAgregar.TabIndex = 0;
            this.lblTituloAgregar.Text = "Artículo nuevo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(54, 88);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 14);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCodigo.Location = new System.Drawing.Point(115, 85);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(83, 22);
            this.tbxCodigo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(206, 88);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(268, 85);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(194, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(28, 125);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(77, 14);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descripción: ";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(115, 122);
            this.tbxDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(347, 78);
            this.tbxDesc.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(54, 215);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 14);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca: ";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DisplayMember = "Descripcion";
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(115, 212);
            this.cbxMarcas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(170, 22);
            this.cbxMarcas.TabIndex = 3;
            this.cbxMarcas.ValueMember = "ID";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(40, 251);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 14);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DisplayMember = "Descripcion";
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(115, 248);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(170, 22);
            this.cbxCategoria.TabIndex = 4;
            this.cbxCategoria.ValueMember = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gpbVistaPrevia
            // 
            this.gpbVistaPrevia.Controls.Add(this.pictureBox1);
            this.gpbVistaPrevia.Location = new System.Drawing.Point(496, 78);
            this.gpbVistaPrevia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbVistaPrevia.Name = "gpbVistaPrevia";
            this.gpbVistaPrevia.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbVistaPrevia.Size = new System.Drawing.Size(321, 241);
            this.gpbVistaPrevia.TabIndex = 13;
            this.gpbVistaPrevia.TabStop = false;
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.BackColor = System.Drawing.SystemColors.Control;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.Location = new System.Drawing.Point(599, 322);
            this.lblVistaPrevia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(110, 14);
            this.lblVistaPrevia.TabIndex = 12;
            this.lblVistaPrevia.Text = "Vista Previa Imagen";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(51, 285);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(48, 14);
            this.lblImagen.TabIndex = 14;
            this.lblImagen.Text = "Imagen:";
            // 
            // tbxImagenUrl
            // 
            this.tbxImagenUrl.Location = new System.Drawing.Point(115, 282);
            this.tbxImagenUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxImagenUrl.Name = "tbxImagenUrl";
            this.tbxImagenUrl.Size = new System.Drawing.Size(303, 22);
            this.tbxImagenUrl.TabIndex = 5;
            this.tbxImagenUrl.Leave += new System.EventHandler(this.tbxImagenUrl_Leave);
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarImg.Image")));
            this.btnCargarImg.Location = new System.Drawing.Point(426, 282);
            this.btnCargarImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(37, 22);
            this.btnCargarImg.TabIndex = 6;
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(57, 318);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(44, 14);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPrecio.Location = new System.Drawing.Point(115, 313);
            this.tbxPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPrecio.MaxLength = 7;
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(83, 22);
            this.tbxPrecio.TabIndex = 7;
            this.tbxPrecio.Tag = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(318, 363);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(115, 363);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 44);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCodIncorrecto
            // 
            this.lblCodIncorrecto.AutoSize = true;
            this.lblCodIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblCodIncorrecto.Location = new System.Drawing.Point(112, 65);
            this.lblCodIncorrecto.Name = "lblCodIncorrecto";
            this.lblCodIncorrecto.Size = new System.Drawing.Size(95, 14);
            this.lblCodIncorrecto.TabIndex = 18;
            this.lblCodIncorrecto.Text = "* Código inválido";
            this.lblCodIncorrecto.Visible = false;
            // 
            // lblNombreInvalido
            // 
            this.lblNombreInvalido.AutoSize = true;
            this.lblNombreInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblNombreInvalido.Location = new System.Drawing.Point(271, 64);
            this.lblNombreInvalido.Name = "lblNombreInvalido";
            this.lblNombreInvalido.Size = new System.Drawing.Size(102, 14);
            this.lblNombreInvalido.TabIndex = 19;
            this.lblNombreInvalido.Text = "* Nombre Inválido";
            this.lblNombreInvalido.Visible = false;
            // 
            // lblPrecioInvalido
            // 
            this.lblPrecioInvalido.AutoSize = true;
            this.lblPrecioInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioInvalido.Location = new System.Drawing.Point(205, 316);
            this.lblPrecioInvalido.Name = "lblPrecioInvalido";
            this.lblPrecioInvalido.Size = new System.Drawing.Size(93, 14);
            this.lblPrecioInvalido.TabIndex = 20;
            this.lblPrecioInvalido.Text = "* Precio Inválido";
            this.lblPrecioInvalido.Visible = false;
            // 
            // frmAgregarArt
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(890, 425);
            this.Controls.Add(this.lblPrecioInvalido);
            this.Controls.Add(this.lblNombreInvalido);
            this.Controls.Add(this.lblCodIncorrecto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.tbxImagenUrl);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.gpbVistaPrevia);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTituloAgregar);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmAgregarArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregarArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbVistaPrevia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbVistaPrevia;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox tbxImagenUrl;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCodIncorrecto;
        private System.Windows.Forms.Label lblNombreInvalido;
        private System.Windows.Forms.Label lblPrecioInvalido;
    }
}