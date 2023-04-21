namespace CAJA
{
    partial class cuadreC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuadreC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_diferencia_caja = new System.Windows.Forms.TextBox();
            this.txtBox_monto_caja = new System.Windows.Forms.TextBox();
            this.txtBox_monto_final = new System.Windows.Forms.TextBox();
            this.txtBox_hora_inicio = new System.Windows.Forms.TextBox();
            this.txtBox_monto_inicio = new System.Windows.Forms.TextBox();
            this.btx_realizar_cuadre = new System.Windows.Forms.Button();
            this.txt_diferencia = new System.Windows.Forms.Label();
            this.txt_monto_caja = new System.Windows.Forms.Label();
            this.btn_monto_final = new System.Windows.Forms.Button();
            this.txt_monto_final = new System.Windows.Forms.Label();
            this.btn_hora_inicio = new System.Windows.Forms.Button();
            this.txt_hora_inicio_dia = new System.Windows.Forms.Label();
            this.btn_monto_inicio = new System.Windows.Forms.Button();
            this.txt_inicio_dia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_diferencia_caja);
            this.panel1.Controls.Add(this.txtBox_monto_caja);
            this.panel1.Controls.Add(this.txtBox_monto_final);
            this.panel1.Controls.Add(this.txtBox_hora_inicio);
            this.panel1.Controls.Add(this.txtBox_monto_inicio);
            this.panel1.Controls.Add(this.btx_realizar_cuadre);
            this.panel1.Controls.Add(this.txt_diferencia);
            this.panel1.Controls.Add(this.txt_monto_caja);
            this.panel1.Controls.Add(this.btn_monto_final);
            this.panel1.Controls.Add(this.txt_monto_final);
            this.panel1.Controls.Add(this.btn_hora_inicio);
            this.panel1.Controls.Add(this.txt_hora_inicio_dia);
            this.panel1.Controls.Add(this.btn_monto_inicio);
            this.panel1.Controls.Add(this.txt_inicio_dia);
            this.panel1.Location = new System.Drawing.Point(44, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 372);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_diferencia_caja
            // 
            this.txt_diferencia_caja.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_diferencia_caja.Location = new System.Drawing.Point(631, 302);
            this.txt_diferencia_caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_diferencia_caja.Name = "txt_diferencia_caja";
            this.txt_diferencia_caja.ReadOnly = true;
            this.txt_diferencia_caja.Size = new System.Drawing.Size(261, 28);
            this.txt_diferencia_caja.TabIndex = 22;
            // 
            // txtBox_monto_caja
            // 
            this.txtBox_monto_caja.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_monto_caja.Location = new System.Drawing.Point(45, 302);
            this.txtBox_monto_caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_monto_caja.Name = "txtBox_monto_caja";
            this.txtBox_monto_caja.ReadOnly = true;
            this.txtBox_monto_caja.Size = new System.Drawing.Size(261, 28);
            this.txtBox_monto_caja.TabIndex = 21;
            // 
            // txtBox_monto_final
            // 
            this.txtBox_monto_final.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_monto_final.Location = new System.Drawing.Point(47, 187);
            this.txtBox_monto_final.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_monto_final.Name = "txtBox_monto_final";
            this.txtBox_monto_final.ReadOnly = true;
            this.txtBox_monto_final.Size = new System.Drawing.Size(261, 28);
            this.txtBox_monto_final.TabIndex = 20;
            // 
            // txtBox_hora_inicio
            // 
            this.txtBox_hora_inicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_hora_inicio.Location = new System.Drawing.Point(631, 70);
            this.txtBox_hora_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_hora_inicio.Name = "txtBox_hora_inicio";
            this.txtBox_hora_inicio.ReadOnly = true;
            this.txtBox_hora_inicio.Size = new System.Drawing.Size(261, 28);
            this.txtBox_hora_inicio.TabIndex = 19;
            // 
            // txtBox_monto_inicio
            // 
            this.txtBox_monto_inicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_monto_inicio.Location = new System.Drawing.Point(45, 74);
            this.txtBox_monto_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_monto_inicio.Name = "txtBox_monto_inicio";
            this.txtBox_monto_inicio.ReadOnly = true;
            this.txtBox_monto_inicio.Size = new System.Drawing.Size(261, 28);
            this.txtBox_monto_inicio.TabIndex = 18;
            // 
            // btx_realizar_cuadre
            // 
            this.btx_realizar_cuadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btx_realizar_cuadre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btx_realizar_cuadre.FlatAppearance.BorderSize = 0;
            this.btx_realizar_cuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btx_realizar_cuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btx_realizar_cuadre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btx_realizar_cuadre.Location = new System.Drawing.Point(505, 302);
            this.btx_realizar_cuadre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btx_realizar_cuadre.Name = "btx_realizar_cuadre";
            this.btx_realizar_cuadre.Size = new System.Drawing.Size(99, 30);
            this.btx_realizar_cuadre.TabIndex = 17;
            this.btx_realizar_cuadre.Text = "Cuadre";
            this.btx_realizar_cuadre.UseVisualStyleBackColor = false;
            // 
            // txt_diferencia
            // 
            this.txt_diferencia.AutoSize = true;
            this.txt_diferencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diferencia.Location = new System.Drawing.Point(776, 257);
            this.txt_diferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_diferencia.Name = "txt_diferencia";
            this.txt_diferencia.Size = new System.Drawing.Size(110, 23);
            this.txt_diferencia.TabIndex = 16;
            this.txt_diferencia.Text = "Diferencia";
            // 
            // txt_monto_caja
            // 
            this.txt_monto_caja.AutoSize = true;
            this.txt_monto_caja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_caja.Location = new System.Drawing.Point(40, 257);
            this.txt_monto_caja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_monto_caja.Name = "txt_monto_caja";
            this.txt_monto_caja.Size = new System.Drawing.Size(153, 23);
            this.txt_monto_caja.TabIndex = 13;
            this.txt_monto_caja.Text = "Monto en caja";
            // 
            // btn_monto_final
            // 
            this.btn_monto_final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_monto_final.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_monto_final.FlatAppearance.BorderSize = 0;
            this.btn_monto_final.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btn_monto_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monto_final.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_monto_final.Location = new System.Drawing.Point(317, 187);
            this.btn_monto_final.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_monto_final.Name = "btn_monto_final";
            this.btn_monto_final.Size = new System.Drawing.Size(31, 30);
            this.btn_monto_final.TabIndex = 12;
            this.btn_monto_final.UseVisualStyleBackColor = false;
            this.btn_monto_final.Click += new System.EventHandler(this.btn_monto_final_Click);
            // 
            // txt_monto_final
            // 
            this.txt_monto_final.AutoSize = true;
            this.txt_monto_final.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_final.Location = new System.Drawing.Point(40, 145);
            this.txt_monto_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_monto_final.Name = "txt_monto_final";
            this.txt_monto_final.Size = new System.Drawing.Size(193, 23);
            this.txt_monto_final.TabIndex = 10;
            this.txt_monto_final.Text = "Monto final del dia";
            // 
            // btn_hora_inicio
            // 
            this.btn_hora_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_hora_inicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_hora_inicio.FlatAppearance.BorderSize = 0;
            this.btn_hora_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btn_hora_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hora_inicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_hora_inicio.Location = new System.Drawing.Point(901, 70);
            this.btn_hora_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_hora_inicio.Name = "btn_hora_inicio";
            this.btn_hora_inicio.Size = new System.Drawing.Size(31, 30);
            this.btn_hora_inicio.TabIndex = 9;
            this.btn_hora_inicio.UseVisualStyleBackColor = false;
            this.btn_hora_inicio.Click += new System.EventHandler(this.btn_hora_inicio_Click);
            // 
            // txt_hora_inicio_dia
            // 
            this.txt_hora_inicio_dia.AutoSize = true;
            this.txt_hora_inicio_dia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora_inicio_dia.Location = new System.Drawing.Point(625, 27);
            this.txt_hora_inicio_dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_hora_inicio_dia.Name = "txt_hora_inicio_dia";
            this.txt_hora_inicio_dia.Size = new System.Drawing.Size(221, 23);
            this.txt_hora_inicio_dia.TabIndex = 5;
            this.txt_hora_inicio_dia.Text = "Hora de inicio del dia";
            // 
            // btn_monto_inicio
            // 
            this.btn_monto_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_monto_inicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_monto_inicio.FlatAppearance.BorderSize = 0;
            this.btn_monto_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btn_monto_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monto_inicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_monto_inicio.Location = new System.Drawing.Point(317, 74);
            this.btn_monto_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_monto_inicio.Name = "btn_monto_inicio";
            this.btn_monto_inicio.Size = new System.Drawing.Size(31, 30);
            this.btn_monto_inicio.TabIndex = 4;
            this.btn_monto_inicio.UseVisualStyleBackColor = false;
            this.btn_monto_inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_inicio_dia
            // 
            this.txt_inicio_dia.AutoSize = true;
            this.txt_inicio_dia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_dia.Location = new System.Drawing.Point(40, 27);
            this.txt_inicio_dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_inicio_dia.Name = "txt_inicio_dia";
            this.txt_inicio_dia.Size = new System.Drawing.Size(205, 23);
            this.txt_inicio_dia.TabIndex = 1;
            this.txt_inicio_dia.Text = "Monto inicio del dia";
            // 
            // cuadreC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(6)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cuadreC";
            this.Text = "cuadreC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_inicio_dia;
        private System.Windows.Forms.Button btn_monto_inicio;
        private System.Windows.Forms.Label txt_hora_inicio_dia;
        private System.Windows.Forms.Button btx_realizar_cuadre;
        private System.Windows.Forms.Label txt_diferencia;
        private System.Windows.Forms.Label txt_monto_caja;
        private System.Windows.Forms.Button btn_monto_final;
        private System.Windows.Forms.Label txt_monto_final;
        private System.Windows.Forms.Button btn_hora_inicio;
        private System.Windows.Forms.TextBox txtBox_monto_inicio;
        private System.Windows.Forms.TextBox txt_diferencia_caja;
        private System.Windows.Forms.TextBox txtBox_monto_caja;
        private System.Windows.Forms.TextBox txtBox_monto_final;
        private System.Windows.Forms.TextBox txtBox_hora_inicio;
    }
}