namespace Presentation.Forms
{
    partial class CategoriaForm
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
            components = new System.ComponentModel.Container();
            CategoriaLabel = new Label();
            comboBoxCategoria = new ComboBox();
            buttonAdd = new Button();
            errorProviderCategoria = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderCategoria).BeginInit();
            SuspendLayout();
            // 
            // CategoriaLabel
            // 
            CategoriaLabel.AutoSize = true;
            CategoriaLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriaLabel.Location = new Point(98, 9);
            CategoriaLabel.Name = "CategoriaLabel";
            CategoriaLabel.Size = new Size(227, 31);
            CategoriaLabel.TabIndex = 0;
            CategoriaLabel.Text = "Escoja una categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Matrícula", "", "Materiales", "", "Transporte", "", "Comida" });
            comboBoxCategoria.Location = new Point(98, 71);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(217, 28);
            comboBoxCategoria.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(148, 123);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(107, 42);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Guardar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // errorProviderCategoria
            // 
            errorProviderCategoria.ContainerControl = this;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 202);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxCategoria);
            Controls.Add(CategoriaLabel);
            Name = "CategoriaForm";
            Text = "CategoriaGastos";
            ((System.ComponentModel.ISupportInitialize)errorProviderCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoriaLabel;
        private ComboBox comboBoxCategoria;
        private Button buttonAdd;
        private ErrorProvider errorProviderCategoria;
    }
}