namespace SMS_PUFF
{
    partial class send_sms
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
            this.top = new System.Windows.Forms.Panel();
            this.texto_conutry_code = new System.Windows.Forms.Label();
            this.countrycode_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.top.Controls.Add(this.button1);
            this.top.Controls.Add(this.number_box);
            this.top.Controls.Add(this.label1);
            this.top.Controls.Add(this.countrycode_box);
            this.top.Controls.Add(this.texto_conutry_code);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(614, 40);
            this.top.TabIndex = 0;
            // 
            // texto_conutry_code
            // 
            this.texto_conutry_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.texto_conutry_code.AutoSize = true;
            this.texto_conutry_code.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_conutry_code.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texto_conutry_code.Location = new System.Drawing.Point(12, 9);
            this.texto_conutry_code.Name = "texto_conutry_code";
            this.texto_conutry_code.Size = new System.Drawing.Size(109, 20);
            this.texto_conutry_code.TabIndex = 0;
            this.texto_conutry_code.Text = "Country Codes";
            // 
            // countrycode_box
            // 
            this.countrycode_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countrycode_box.Location = new System.Drawing.Point(127, 11);
            this.countrycode_box.Name = "countrycode_box";
            this.countrycode_box.Size = new System.Drawing.Size(100, 20);
            this.countrycode_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // number_box
            // 
            this.number_box.Location = new System.Drawing.Point(302, 12);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(190, 20);
            this.number_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(514, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.Lime;
            this.console.Location = new System.Drawing.Point(12, 46);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(590, 300);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // send_sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(614, 358);
            this.Controls.Add(this.console);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "send_sms";
            this.Text = "send_sms";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.TextBox countrycode_box;
        private System.Windows.Forms.Label texto_conutry_code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox number_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox console;
    }
}