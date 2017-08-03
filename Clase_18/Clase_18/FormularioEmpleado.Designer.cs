namespace Clase_18
{
    partial class FormularioEmpleado
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
            this.rtxtEmpleado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtEmpleado
            // 
            this.rtxtEmpleado.Location = new System.Drawing.Point(12, 12);
            this.rtxtEmpleado.Name = "rtxtEmpleado";
            this.rtxtEmpleado.Size = new System.Drawing.Size(399, 322);
            this.rtxtEmpleado.TabIndex = 0;
            this.rtxtEmpleado.Text = "";
            this.rtxtEmpleado.TextChanged += new System.EventHandler(this.rtxttEmpleado_TextChanged);
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 346);
            this.Controls.Add(this.rtxtEmpleado);
            this.Name = "FormularioEmpleado";
            this.Text = "FormularioEmpleado";
            this.Load += new System.EventHandler(this.FormularioEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtEmpleado;
    }
}