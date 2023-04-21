namespace CAJA
{
    partial class cajaC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cajaC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cmbox_opciones = new System.Windows.Forms.ComboBox();
            this.btn_realizar = new System.Windows.Forms.Button();
            this.txtBox_montocaja = new System.Windows.Forms.TextBox();
            this.txt_montocaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_tipo);
            this.panel1.Controls.Add(this.cmbox_opciones);
            this.panel1.Controls.Add(this.btn_realizar);
            this.panel1.Controls.Add(this.txtBox_montocaja);
            this.panel1.Controls.Add(this.txt_montocaja);
            this.panel1.Location = new System.Drawing.Point(28, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 283);
            this.panel1.TabIndex = 2;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(320, 65);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(41, 19);
            this.lbl_tipo.TabIndex = 6;
            this.lbl_tipo.Text = "Tipo";
            // 
            // cmbox_opciones
            // 
            this.cmbox_opciones.FormattingEnabled = true;
            this.cmbox_opciones.Location = new System.Drawing.Point(322, 96);
            this.cmbox_opciones.Margin = new System.Windows.Forms.Padding(2);
            this.cmbox_opciones.Name = "cmbox_opciones";
            this.cmbox_opciones.Size = new System.Drawing.Size(92, 21);
            this.cmbox_opciones.TabIndex = 5;
            this.cmbox_opciones.SelectedIndexChanged += new System.EventHandler(this.cmbox_opciones_SelectedIndexChanged);
            // 
            // btn_realizar
            // 
            this.btn_realizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_realizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_realizar.FlatAppearance.BorderSize = 0;
            this.btn_realizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_realizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btn_realizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_realizar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_realizar.Location = new System.Drawing.Point(206, 160);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(91, 30);
            this.btn_realizar.TabIndex = 4;
            this.btn_realizar.Text = "Realizar";
            this.btn_realizar.UseVisualStyleBackColor = false;
            this.btn_realizar.Click += new System.EventHandler(this.btn_realizar_Click);
            // 
            // txtBox_montocaja
            // 
            this.txtBox_montocaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_montocaja.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_montocaja.Location = new System.Drawing.Point(34, 96);
            this.txtBox_montocaja.Name = "txtBox_montocaja";
            this.txtBox_montocaja.Size = new System.Drawing.Size(198, 24);
            this.txtBox_montocaja.TabIndex = 2;
            this.txtBox_montocaja.TextChanged += new System.EventHandler(this.txtBox_montocaja_TextChanged);
            // 
            // txt_montocaja
            // 
            this.txt_montocaja.AutoSize = true;
            this.txt_montocaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montocaja.Location = new System.Drawing.Point(29, 65);
            this.txt_montocaja.Name = "txt_montocaja";
            this.txt_montocaja.Size = new System.Drawing.Size(57, 19);
            this.txt_montocaja.TabIndex = 0;
            this.txt_montocaja.Text = "Monto";
            this.txt_montocaja.Click += new System.EventHandler(this.txt_usuario_login_Click);
            // 
            // cajaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(6)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cajaC";
            this.Text = "cajaC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_realizar;
        private System.Windows.Forms.TextBox txtBox_montocaja;
        private System.Windows.Forms.Label txt_montocaja;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmbox_opciones;
    }
}