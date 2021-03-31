
namespace WindowsForms3
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
            this.buttonNegrita = new System.Windows.Forms.Button();
            this.buttonSubrayado = new System.Windows.Forms.Button();
            this.buttonCursiva = new System.Windows.Forms.Button();
            this.buttonCentrado = new System.Windows.Forms.Button();
            this.labelTamaño = new System.Windows.Forms.Label();
            this.textTamaño = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNegrita
            // 
            this.buttonNegrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNegrita.Location = new System.Drawing.Point(84, 21);
            this.buttonNegrita.Name = "buttonNegrita";
            this.buttonNegrita.Size = new System.Drawing.Size(75, 26);
            this.buttonNegrita.TabIndex = 0;
            this.buttonNegrita.Text = "Negrita";
            this.buttonNegrita.UseVisualStyleBackColor = true;
            this.buttonNegrita.Click += new System.EventHandler(this.buttonNegrita_Click);
            // 
            // buttonSubrayado
            // 
            this.buttonSubrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubrayado.Location = new System.Drawing.Point(225, 21);
            this.buttonSubrayado.Name = "buttonSubrayado";
            this.buttonSubrayado.Size = new System.Drawing.Size(75, 27);
            this.buttonSubrayado.TabIndex = 1;
            this.buttonSubrayado.Text = "Subrayado";
            this.buttonSubrayado.UseVisualStyleBackColor = true;
            this.buttonSubrayado.Click += new System.EventHandler(this.buttonSubrayado_Click);
            // 
            // buttonCursiva
            // 
            this.buttonCursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCursiva.Location = new System.Drawing.Point(371, 22);
            this.buttonCursiva.Name = "buttonCursiva";
            this.buttonCursiva.Size = new System.Drawing.Size(75, 26);
            this.buttonCursiva.TabIndex = 2;
            this.buttonCursiva.Text = "Cursiva";
            this.buttonCursiva.UseVisualStyleBackColor = true;
            this.buttonCursiva.Click += new System.EventHandler(this.buttonCursiva_Click);
            // 
            // buttonCentrado
            // 
            this.buttonCentrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCentrado.Location = new System.Drawing.Point(527, 24);
            this.buttonCentrado.Name = "buttonCentrado";
            this.buttonCentrado.Size = new System.Drawing.Size(75, 24);
            this.buttonCentrado.TabIndex = 3;
            this.buttonCentrado.Text = "Centrado";
            this.buttonCentrado.UseVisualStyleBackColor = true;
            this.buttonCentrado.Click += new System.EventHandler(this.buttonCentrado_Click);
            // 
            // labelTamaño
            // 
            this.labelTamaño.AutoSize = true;
            this.labelTamaño.Location = new System.Drawing.Point(191, 75);
            this.labelTamaño.Name = "labelTamaño";
            this.labelTamaño.Size = new System.Drawing.Size(82, 13);
            this.labelTamaño.TabIndex = 4;
            this.labelTamaño.Text = "Tamaño Fuente";
            // 
            // textTamaño
            // 
            this.textTamaño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textTamaño.Location = new System.Drawing.Point(298, 72);
            this.textTamaño.MaxLength = 2;
            this.textTamaño.Name = "textTamaño";
            this.textTamaño.Size = new System.Drawing.Size(78, 20);
            this.textTamaño.TabIndex = 5;
            this.textTamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTamaño_KeyPress);
            this.textTamaño.Validated += new System.EventHandler(this.textTamaño_Validated);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 98);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(733, 293);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGuardar.Location = new System.Drawing.Point(219, 412);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(79, 24);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAbrir.Location = new System.Drawing.Point(413, 412);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(84, 24);
            this.buttonAbrir.TabIndex = 8;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(757, 447);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textTamaño);
            this.Controls.Add(this.labelTamaño);
            this.Controls.Add(this.buttonCentrado);
            this.Controls.Add(this.buttonCursiva);
            this.Controls.Add(this.buttonSubrayado);
            this.Controls.Add(this.buttonNegrita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNegrita;
        private System.Windows.Forms.Button buttonSubrayado;
        private System.Windows.Forms.Button buttonCursiva;
        private System.Windows.Forms.Button buttonCentrado;
        private System.Windows.Forms.Label labelTamaño;
        private System.Windows.Forms.TextBox textTamaño;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonAbrir;
    }
}

