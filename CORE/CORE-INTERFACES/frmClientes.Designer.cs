namespace CORE_INTERFACES
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgbClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEditar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton4 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.tpFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbTipoDocumento = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BorderRadius = 20;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombre.DefaultText = "";
            this.tbNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombre.Location = new System.Drawing.Point(23, 249);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.SelectedText = "";
            this.tbNombre.Size = new System.Drawing.Size(227, 34);
            this.tbNombre.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(93, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label6.Location = new System.Drawing.Point(303, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tipo Documento";
            // 
            // dgbClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgbClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbClientes.ColumnHeadersHeight = 4;
            this.dgbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgbClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbClientes.Location = new System.Drawing.Point(76, 465);
            this.dgbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgbClientes.Name = "dgbClientes";
            this.dgbClientes.RowHeadersVisible = false;
            this.dgbClientes.RowHeadersWidth = 51;
            this.dgbClientes.RowTemplate.Height = 24;
            this.dgbClientes.Size = new System.Drawing.Size(819, 222);
            this.dgbClientes.TabIndex = 59;
            this.dgbClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgbClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgbClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgbClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgbClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgbClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgbClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgbClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgbClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgbClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgbClientes.ThemeStyle.HeaderStyle.Height = 4;
            this.dgbClientes.ThemeStyle.ReadOnly = false;
            this.dgbClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgbClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgbClientes.ThemeStyle.RowsStyle.Height = 24;
            this.dgbClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(600, 402);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 41);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnEditar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(419, 402);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 41);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // guna2GradientTileButton4
            // 
            this.guna2GradientTileButton4.BorderRadius = 20;
            this.guna2GradientTileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.guna2GradientTileButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.guna2GradientTileButton4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton4.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientTileButton4.Location = new System.Drawing.Point(587, 126);
            this.guna2GradientTileButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientTileButton4.Name = "guna2GradientTileButton4";
            this.guna2GradientTileButton4.Size = new System.Drawing.Size(112, 41);
            this.guna2GradientTileButton4.TabIndex = 56;
            this.guna2GradientTileButton4.Text = "Buscar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 20;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnRegistrar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(237, 402);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 41);
            this.btnRegistrar.TabIndex = 55;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(795, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.BorderRadius = 20;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.Location = new System.Drawing.Point(735, 132);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "";
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(160, 34);
            this.tbID.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(443, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(571, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Documento";
            // 
            // tbDocumento
            // 
            this.tbDocumento.BorderRadius = 20;
            this.tbDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDocumento.DefaultText = "";
            this.tbDocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDocumento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDocumento.Location = new System.Drawing.Point(527, 249);
            this.tbDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.PasswordChar = '\0';
            this.tbDocumento.PlaceholderText = "";
            this.tbDocumento.SelectedText = "";
            this.tbDocumento.Size = new System.Drawing.Size(204, 34);
            this.tbDocumento.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(795, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.BorderRadius = 20;
            this.tbCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCorreo.DefaultText = "";
            this.tbCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCorreo.Location = new System.Drawing.Point(744, 249);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.PasswordChar = '\0';
            this.tbCorreo.PlaceholderText = "";
            this.tbCorreo.SelectedText = "";
            this.tbCorreo.Size = new System.Drawing.Size(200, 34);
            this.tbCorreo.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label8.Location = new System.Drawing.Point(529, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BorderRadius = 20;
            this.tbTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelefono.DefaultText = "";
            this.tbTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelefono.Location = new System.Drawing.Point(23, 340);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.PasswordChar = '\0';
            this.tbTelefono.PlaceholderText = "";
            this.tbTelefono.SelectedText = "";
            this.tbTelefono.Size = new System.Drawing.Size(227, 34);
            this.tbTelefono.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(93, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 70;
            this.label9.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(339, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Dirección";
            // 
            // tbDireccion
            // 
            this.tbDireccion.BorderRadius = 20;
            this.tbDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDireccion.DefaultText = "";
            this.tbDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDireccion.Location = new System.Drawing.Point(276, 340);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.PasswordChar = '\0';
            this.tbDireccion.PlaceholderText = "";
            this.tbDireccion.SelectedText = "";
            this.tbDireccion.Size = new System.Drawing.Size(227, 34);
            this.tbDireccion.TabIndex = 68;
            // 
            // tpFechaNacimiento
            // 
            this.tpFechaNacimiento.Checked = true;
            this.tpFechaNacimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.tpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpFechaNacimiento.Location = new System.Drawing.Point(744, 324);
            this.tpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpFechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpFechaNacimiento.Name = "tpFechaNacimiento";
            this.tpFechaNacimiento.Size = new System.Drawing.Size(200, 36);
            this.tpFechaNacimiento.TabIndex = 74;
            this.tpFechaNacimiento.Value = new System.DateTime(2023, 4, 19, 1, 13, 49, 736);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoDocumento.BorderRadius = 20;
            this.cbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoDocumento.ItemHeight = 30;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(276, 249);
            this.cbTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(227, 36);
            this.cbTipoDocumento.TabIndex = 75;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 687);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.tpFechaNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgbClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.guna2GradientTileButton4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgbClientes;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEliminar;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEditar;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton4;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnRegistrar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbDocumento;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbCorreo;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox tbDireccion;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpFechaNacimiento;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoDocumento;
    }
}