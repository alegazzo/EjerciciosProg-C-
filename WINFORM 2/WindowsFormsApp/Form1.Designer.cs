
namespace WindowsFormsApp
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPro = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(27, 39);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPro.Location = new System.Drawing.Point(12, 90);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(101, 20);
            this.labelPro.TabIndex = 1;
            this.labelPro.Text = "Programador";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(137, 41);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(284, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salida";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(137, 94);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 4;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonHombre.Checked = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(62, 38);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonHombre.TabIndex = 5;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(236, 38);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMujer.TabIndex = 6;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(470, 39);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(82, 22);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonMujer);
            this.groupBoxSexo.Controls.Add(this.radioButtonHombre);
            this.groupBoxSexo.Location = new System.Drawing.Point(53, 132);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(368, 72);
            this.groupBoxSexo.TabIndex = 9;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // textSalida
            // 
            this.textSalida.Location = new System.Drawing.Point(31, 241);
            this.textSalida.Multiline = true;
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(408, 102);
            this.textSalida.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(571, 369);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelPro);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPro;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.TextBox textSalida;
    }
}

