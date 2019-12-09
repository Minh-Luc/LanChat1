namespace Client
{
    partial class LoginForm
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.txbserverip = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(50, 71);
            this.txbName.MinimumSize = new System.Drawing.Size(211, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(211, 30);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Firebrick;
            this.ptbClose.BackgroundImage = global::Client.Properties.Resources.close_white_108x108;
            this.ptbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbClose.Location = new System.Drawing.Point(293, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(24, 24);
            this.ptbClose.TabIndex = 3;
            this.ptbClose.TabStop = false;
            this.ptbClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.ptbClose.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // txbserverip
            // 
            this.txbserverip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbserverip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbserverip.Location = new System.Drawing.Point(50, 161);
            this.txbserverip.MinimumSize = new System.Drawing.Size(211, 30);
            this.txbserverip.Name = "txbserverip";
            this.txbserverip.Size = new System.Drawing.Size(211, 30);
            this.txbserverip.TabIndex = 1;
            this.txbserverip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(100, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Username";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserver.ForeColor = System.Drawing.Color.White;
            this.lblserver.Location = new System.Drawing.Point(108, 119);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(94, 30);
            this.lblserver.TabIndex = 0;
            this.lblserver.Text = "Server IP";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(318, 277);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbserverip);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.TextBox txbserverip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblserver;
    }
}

