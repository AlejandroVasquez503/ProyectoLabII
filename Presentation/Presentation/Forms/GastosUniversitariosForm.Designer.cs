namespace Presentation.Forms
{
    partial class GastosUniversitariosForm
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
            LabelRegistrarGastos = new Label();
            labelFecha = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            dtpFecha = new DateTimePicker();
            labelCategoria = new Label();
            labelDescripción = new Label();
            labelMonto = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            errorProviderGastos = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGastos).BeginInit();
            SuspendLayout();
            // 
            // LabelRegistrarGastos
            // 
            LabelRegistrarGastos.AutoSize = true;
            LabelRegistrarGastos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelRegistrarGastos.Location = new Point(402, 23);
            LabelRegistrarGastos.Name = "LabelRegistrarGastos";
            LabelRegistrarGastos.Size = new Size(293, 28);
            LabelRegistrarGastos.TabIndex = 0;
            LabelRegistrarGastos.Text = "Aqui puede Registrar los Gastos";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(27, 46);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(63, 28);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(labelCategoria);
            groupBox1.Controls.Add(labelDescripción);
            groupBox1.Controls.Add(labelMonto);
            groupBox1.Controls.Add(labelFecha);
            groupBox1.Location = new Point(138, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Matrícula", "", "Materiales", "", "Transporte", "", "Comida" });
            comboBox1.Location = new Point(269, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(322, 28);
            comboBox1.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(269, 157);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(322, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(269, 102);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(322, 27);
            txtMonto.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(269, 46);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(322, 27);
            dtpFecha.TabIndex = 3;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCategoria.Location = new Point(27, 212);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(188, 28);
            labelCategoria.TabIndex = 4;
            labelCategoria.Text = "Categoría de Gastos";
            // 
            // labelDescripción
            // 
            labelDescripción.AutoSize = true;
            labelDescripción.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescripción.Location = new Point(27, 157);
            labelDescripción.Name = "labelDescripción";
            labelDescripción.Size = new Size(112, 28);
            labelDescripción.TabIndex = 3;
            labelDescripción.Text = "Descripción";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMonto.Location = new Point(27, 101);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(67, 28);
            labelMonto.TabIndex = 2;
            labelMonto.Text = "Monto";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(225, 393);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 43);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(500, 393);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 43);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(761, 393);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 43);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(140, 466);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 199);
            dataGridView1.TabIndex = 6;
            // 
            // errorProviderGastos
            // 
            errorProviderGastos.ContainerControl = this;
            // 
            // GastosUniversitariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 687);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(groupBox1);
            Controls.Add(LabelRegistrarGastos);
            Name = "GastosUniversitariosForm";
            Text = "GastosUniversitarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelRegistrarGastos;
        private Label labelFecha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private Label labelCategoria;
        private Label labelDescripción;
        private Label labelMonto;
        private ComboBox comboBox1;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private ErrorProvider errorProviderGastos;
    }
}