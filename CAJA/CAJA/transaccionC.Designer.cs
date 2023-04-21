namespace CAJA
{
    partial class transaccionC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaccionC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_moneda_transaccion = new System.Windows.Forms.ComboBox();
            this.txtBox_monto_transaccion = new System.Windows.Forms.TextBox();
            this.CB_tipo_transaccion = new System.Windows.Forms.ComboBox();
            this.txtBox_numero_cuenta = new System.Windows.Forms.TextBox();
            this.txt_moneda_transaccion = new System.Windows.Forms.Label();
            this.txt_monto_transaccion = new System.Windows.Forms.Label();
            this.txt_tipo_transaccion = new System.Windows.Forms.Label();
            this.txt_numero_cuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CB_moneda_transaccion);
            this.panel1.Controls.Add(this.txtBox_monto_transaccion);
            this.panel1.Controls.Add(this.CB_tipo_transaccion);
            this.panel1.Controls.Add(this.txtBox_numero_cuenta);
            this.panel1.Controls.Add(this.txt_moneda_transaccion);
            this.panel1.Controls.Add(this.txt_monto_transaccion);
            this.panel1.Controls.Add(this.txt_tipo_transaccion);
            this.panel1.Controls.Add(this.txt_numero_cuenta);
            this.panel1.Location = new System.Drawing.Point(35, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 304);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Realizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_moneda_transaccion
            // 
            this.CB_moneda_transaccion.FormattingEnabled = true;
            this.CB_moneda_transaccion.Location = new System.Drawing.Point(271, 176);
            this.CB_moneda_transaccion.Name = "CB_moneda_transaccion";
            this.CB_moneda_transaccion.Size = new System.Drawing.Size(71, 21);
            this.CB_moneda_transaccion.TabIndex = 9;
            // 
            // txtBox_monto_transaccion
            // 
            this.txtBox_monto_transaccion.Location = new System.Drawing.Point(30, 177);
            this.txtBox_monto_transaccion.Name = "txtBox_monto_transaccion";
            this.txtBox_monto_transaccion.Size = new System.Drawing.Size(152, 20);
            this.txtBox_monto_transaccion.TabIndex = 8;
            this.txtBox_monto_transaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_monto_transaccion_KeyPress);
            // 
            // CB_tipo_transaccion
            // 
            this.CB_tipo_transaccion.FormattingEnabled = true;
            this.CB_tipo_transaccion.Location = new System.Drawing.Point(271, 66);
            this.CB_tipo_transaccion.Name = "CB_tipo_transaccion";
            this.CB_tipo_transaccion.Size = new System.Drawing.Size(157, 21);
            this.CB_tipo_transaccion.TabIndex = 7;
            // 
            // txtBox_numero_cuenta
            // 
            this.txtBox_numero_cuenta.Location = new System.Drawing.Point(30, 68);
            this.txtBox_numero_cuenta.Name = "txtBox_numero_cuenta";
            this.txtBox_numero_cuenta.Size = new System.Drawing.Size(152, 20);
            this.txtBox_numero_cuenta.TabIndex = 6;
            this.txtBox_numero_cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_numero_cuenta_KeyPress);
            // 
            // txt_moneda_transaccion
            // 
            this.txt_moneda_transaccion.AutoSize = true;
            this.txt_moneda_transaccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moneda_transaccion.Location = new System.Drawing.Point(267, 138);
            this.txt_moneda_transaccion.Name = "txt_moneda_transaccion";
            this.txt_moneda_transaccion.Size = new System.Drawing.Size(75, 19);
            this.txt_moneda_transaccion.TabIndex = 5;
            this.txt_moneda_transaccion.Text = "Moneda";
            // 
            // txt_monto_transaccion
            // 
            this.txt_monto_transaccion.AutoSize = true;
            this.txt_monto_transaccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_transaccion.Location = new System.Drawing.Point(26, 138);
            this.txt_monto_transaccion.Name = "txt_monto_transaccion";
            this.txt_monto_transaccion.Size = new System.Drawing.Size(57, 19);
            this.txt_monto_transaccion.TabIndex = 4;
            this.txt_monto_transaccion.Text = "Monto";
            // 
            // txt_tipo_transaccion
            // 
            this.txt_tipo_transaccion.AutoSize = true;
            this.txt_tipo_transaccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_transaccion.Location = new System.Drawing.Point(267, 35);
            this.txt_tipo_transaccion.Name = "txt_tipo_transaccion";
            this.txt_tipo_transaccion.Size = new System.Drawing.Size(161, 19);
            this.txt_tipo_transaccion.TabIndex = 3;
            this.txt_tipo_transaccion.Text = "Tipo de transaccion";
            // 
            // txt_numero_cuenta
            // 
            this.txt_numero_cuenta.AutoSize = true;
            this.txt_numero_cuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_cuenta.Location = new System.Drawing.Point(26, 35);
            this.txt_numero_cuenta.Name = "txt_numero_cuenta";
            this.txt_numero_cuenta.Size = new System.Drawing.Size(156, 19);
            this.txt_numero_cuenta.TabIndex = 2;
            this.txt_numero_cuenta.Text = "Numero de cuenta";
            // 
            // transaccionC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(6)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "transaccionC";
            this.Text = "transaccionC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_numero_cuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_moneda_transaccion;
        private System.Windows.Forms.TextBox txtBox_monto_transaccion;
        private System.Windows.Forms.ComboBox CB_tipo_transaccion;
        private System.Windows.Forms.TextBox txtBox_numero_cuenta;
        private System.Windows.Forms.Label txt_moneda_transaccion;
        private System.Windows.Forms.Label txt_monto_transaccion;
        private System.Windows.Forms.Label txt_tipo_transaccion;
    }
}