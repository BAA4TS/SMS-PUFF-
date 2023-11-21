namespace SMS_PUFF
{
    partial class formulario_principal
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.exit_button_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_para_ir_al_send = new System.Windows.Forms.Button();
            this.panel_de_canvio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.exit_button_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_de_canvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.exit_button_panel);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(614, 28);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 28);
            this.panel1.TabIndex = 1;
            // 
            // button_minimizar
            // 
            this.button_minimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_minimizar.FlatAppearance.BorderSize = 0;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(0, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(44, 28);
            this.button_minimizar.TabIndex = 0;
            this.button_minimizar.Text = "-";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // exit_button_panel
            // 
            this.exit_button_panel.Controls.Add(this.exit_button);
            this.exit_button_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button_panel.Location = new System.Drawing.Point(570, 0);
            this.exit_button_panel.Name = "exit_button_panel";
            this.exit_button_panel.Size = new System.Drawing.Size(44, 28);
            this.exit_button_panel.TabIndex = 0;
            // 
            // exit_button
            // 
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(0, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(44, 28);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.boton_para_ir_al_send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 320);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SMS_PUFF.Properties.Resources.l;
            this.pictureBox1.Location = new System.Drawing.Point(108, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 219);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(141, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "One SMS valid per day";
            // 
            // boton_para_ir_al_send
            // 
            this.boton_para_ir_al_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_para_ir_al_send.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_para_ir_al_send.Location = new System.Drawing.Point(350, 246);
            this.boton_para_ir_al_send.Name = "boton_para_ir_al_send";
            this.boton_para_ir_al_send.Size = new System.Drawing.Size(116, 23);
            this.boton_para_ir_al_send.TabIndex = 4;
            this.boton_para_ir_al_send.Text = "Send";
            this.boton_para_ir_al_send.UseVisualStyleBackColor = true;
            this.boton_para_ir_al_send.Click += new System.EventHandler(this.boton_para_ir_al_send_Click);
            // 
            // panel_de_canvio
            // 
            this.panel_de_canvio.Controls.Add(this.panel2);
            this.panel_de_canvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_de_canvio.Location = new System.Drawing.Point(0, 28);
            this.panel_de_canvio.Name = "panel_de_canvio";
            this.panel_de_canvio.Size = new System.Drawing.Size(614, 358);
            this.panel_de_canvio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAA4TS       v 1.0.1";
            // 
            // formulario_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(614, 386);
            this.Controls.Add(this.panel_de_canvio);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulario_principal";
            this.Text = "SMS PUFF";
            this.panel_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.exit_button_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_de_canvio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel exit_button_panel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_para_ir_al_send;
        private System.Windows.Forms.Panel panel_de_canvio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

