
namespace Winform1
{
    partial class Formulario
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
            this.components = new System.ComponentModel.Container();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textDirec = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDirec = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.textRes = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Olive;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAceptar.Location = new System.Drawing.Point(136, 273);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 25);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelApellido.Location = new System.Drawing.Point(12, 28);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(59, 13);
            this.LabelApellido.TabIndex = 1;
            this.LabelApellido.Text = "APELLIDO";
            // 
            // textApellido
            // 
            this.textApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textApellido.Location = new System.Drawing.Point(84, 25);
            this.textApellido.MaxLength = 50;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(453, 20);
            this.textApellido.TabIndex = 2;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNombre.Location = new System.Drawing.Point(84, 51);
            this.textNombre.Name = "textNombre";
            this.textNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNombre.Size = new System.Drawing.Size(453, 20);
            this.textNombre.TabIndex = 3;
            this.textNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(84, 77);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(56, 20);
            this.textEdad.TabIndex = 4;
            this.textEdad.TextChanged += new System.EventHandler(this.textEdad_TextChanged);
            this.textEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdad_KeyPress);
            // 
            // textDirec
            // 
            this.textDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDirec.Location = new System.Drawing.Point(84, 103);
            this.textDirec.MaxLength = 60;
            this.textDirec.Name = "textDirec";
            this.textDirec.Size = new System.Drawing.Size(453, 20);
            this.textDirec.TabIndex = 5;
            this.textDirec.TextChanged += new System.EventHandler(this.textDirec_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 54);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(12, 80);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(37, 13);
            this.labelEdad.TabIndex = 7;
            this.labelEdad.Text = "EDAD";
            // 
            // labelDirec
            // 
            this.labelDirec.AutoSize = true;
            this.labelDirec.Location = new System.Drawing.Point(12, 106);
            this.labelDirec.Name = "labelDirec";
            this.labelDirec.Size = new System.Drawing.Size(66, 13);
            this.labelDirec.TabIndex = 8;
            this.labelDirec.Text = "DIRECCIÓN";
            // 
            // labelResul
            // 
            this.labelResul.AutoSize = true;
            this.labelResul.Location = new System.Drawing.Point(12, 137);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(73, 13);
            this.labelResul.TabIndex = 9;
            this.labelResul.Text = "RESULTADO";
            // 
            // textRes
            // 
            this.textRes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRes.Location = new System.Drawing.Point(15, 153);
            this.textRes.Multiline = true;
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(522, 114);
            this.textRes.TabIndex = 10;
            this.textRes.Leave += new System.EventHandler(this.textRes_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(546, 314);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.labelResul);
            this.Controls.Add(this.labelDirec);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textDirec);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.BtnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textDirec;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDirec;
        private System.Windows.Forms.Label labelResul;
        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

