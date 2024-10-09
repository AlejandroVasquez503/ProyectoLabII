namespace Presentation.Forms
{
    partial class MainForm
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
            Welcome = new Label();
            IngresarUsuario = new Label();
            GroupBoxUsuarios = new GroupBox();
            textBoxApellido = new TextBox();
            textBoxContraseña = new TextBox();
            textBoxCarnet = new TextBox();
            textBoxNombre = new TextBox();
            Contraseña = new Label();
            Carnet = new Label();
            Apellido = new Label();
            Nombre = new Label();
            buttonAdd = new Button();
            UsuariosDataGridView = new DataGridView();
            errorProviderUsuario = new ErrorProvider(components);
            GroupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsuariosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsuario).BeginInit();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcome.Location = new Point(489, 20);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(143, 31);
            Welcome.TabIndex = 0;
            Welcome.Text = "Bienvenid@";
            // 
            // IngresarUsuario
            // 
            IngresarUsuario.AutoSize = true;
            IngresarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            IngresarUsuario.Location = new Point(435, 89);
            IngresarUsuario.Name = "IngresarUsuario";
            IngresarUsuario.Size = new Size(252, 28);
            IngresarUsuario.TabIndex = 1;
            IngresarUsuario.Text = "Porfavor ingrese un usuario";
            // 
            // GroupBoxUsuarios
            // 
            GroupBoxUsuarios.Controls.Add(textBoxApellido);
            GroupBoxUsuarios.Controls.Add(textBoxContraseña);
            GroupBoxUsuarios.Controls.Add(textBoxCarnet);
            GroupBoxUsuarios.Controls.Add(textBoxNombre);
            GroupBoxUsuarios.Controls.Add(Contraseña);
            GroupBoxUsuarios.Controls.Add(Carnet);
            GroupBoxUsuarios.Controls.Add(Apellido);
            GroupBoxUsuarios.Controls.Add(Nombre);
            GroupBoxUsuarios.Location = new Point(243, 135);
            GroupBoxUsuarios.Name = "GroupBoxUsuarios";
            GroupBoxUsuarios.Size = new Size(683, 272);
            GroupBoxUsuarios.TabIndex = 2;
            GroupBoxUsuarios.TabStop = false;
            GroupBoxUsuarios.Text = "Formulario";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(362, 85);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(258, 27);
            textBoxApellido.TabIndex = 11;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(362, 198);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(258, 27);
            textBoxContraseña.TabIndex = 10;
            // 
            // textBoxCarnet
            // 
            textBoxCarnet.Location = new Point(15, 198);
            textBoxCarnet.Name = "textBoxCarnet";
            textBoxCarnet.Size = new Size(258, 27);
            textBoxCarnet.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(15, 85);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(258, 27);
            textBoxNombre.TabIndex = 7;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(362, 148);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(106, 25);
            Contraseña.TabIndex = 6;
            Contraseña.Text = "Contraseña";
            // 
            // Carnet
            // 
            Carnet.AutoSize = true;
            Carnet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Carnet.Location = new Point(15, 148);
            Carnet.Name = "Carnet";
            Carnet.Size = new Size(67, 25);
            Carnet.TabIndex = 5;
            Carnet.Text = "Carnet";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apellido.Location = new Point(362, 41);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(82, 25);
            Apellido.TabIndex = 4;
            Apellido.Text = "Apellido";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(15, 41);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(81, 25);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(513, 427);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 45);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // UsuariosDataGridView
            // 
            UsuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsuariosDataGridView.Location = new Point(228, 490);
            UsuariosDataGridView.Name = "UsuariosDataGridView";
            UsuariosDataGridView.RowHeadersWidth = 51;
            UsuariosDataGridView.Size = new Size(698, 188);
            UsuariosDataGridView.TabIndex = 4;
            // 
            // errorProviderUsuario
            // 
            errorProviderUsuario.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 697);
            Controls.Add(UsuariosDataGridView);
            Controls.Add(buttonAdd);
            Controls.Add(GroupBoxUsuarios);
            Controls.Add(IngresarUsuario);
            Controls.Add(Welcome);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "MainForm";
            GroupBoxUsuarios.ResumeLayout(false);
            GroupBoxUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsuariosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private Label IngresarUsuario;
        private GroupBox GroupBoxUsuarios;
        private TextBox textBoxApellido;
        private TextBox textBoxContraseña;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private Label Contraseña;
        private Label Carnet;
        private Label Apellido;
        private Label Nombre;
        private Button buttonAdd;
        private DataGridView UsuariosDataGridView;
        private ErrorProvider errorProviderUsuario;
    }
}