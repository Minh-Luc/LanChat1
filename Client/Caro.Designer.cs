namespace Client
{
    partial class Caro
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
            this.pnlBanco = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.pgsCooldown = new System.Windows.Forms.ProgressBar();
            this.pcbxCaroimage = new System.Windows.Forms.PictureBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerChess = new System.Windows.Forms.Label();
            this.ptcbxPlayerChess = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCaroimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbxPlayerChess)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanco
            // 
            this.pnlBanco.Location = new System.Drawing.Point(1, 1);
            this.pnlBanco.Name = "pnlBanco";
            this.pnlBanco.Size = new System.Drawing.Size(450, 450);
            this.pnlBanco.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pcbxCaroimage);
            this.panel1.Location = new System.Drawing.Point(460, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 240);
            this.panel1.TabIndex = 1;
            // 
            // btnNewgame
            // 
            this.btnNewgame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewgame.Font = new System.Drawing.Font("Mistral", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewgame.Location = new System.Drawing.Point(459, 247);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(241, 41);
            this.btnNewgame.TabIndex = 2;
            this.btnNewgame.Text = "New Game";
            this.btnNewgame.UseVisualStyleBackColor = true;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // pgsCooldown
            // 
            this.pgsCooldown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgsCooldown.Location = new System.Drawing.Point(460, 294);
            this.pgsCooldown.Name = "pgsCooldown";
            this.pgsCooldown.Size = new System.Drawing.Size(240, 23);
            this.pgsCooldown.TabIndex = 3;
            // 
            // pcbxCaroimage
            // 
            this.pcbxCaroimage.BackgroundImage = global::Client.Properties.Resources.caro;
            this.pcbxCaroimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxCaroimage.Location = new System.Drawing.Point(4, 3);
            this.pcbxCaroimage.Name = "pcbxCaroimage";
            this.pcbxCaroimage.Size = new System.Drawing.Size(233, 233);
            this.pcbxCaroimage.TabIndex = 0;
            this.pcbxCaroimage.TabStop = false;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(460, 323);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(240, 20);
            this.txbPlayerName.TabIndex = 4;
            // 
            // lblPlayerChess
            // 
            this.lblPlayerChess.AutoSize = true;
            this.lblPlayerChess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChess.Location = new System.Drawing.Point(456, 388);
            this.lblPlayerChess.Name = "lblPlayerChess";
            this.lblPlayerChess.Size = new System.Drawing.Size(88, 13);
            this.lblPlayerChess.TabIndex = 5;
            this.lblPlayerChess.Text = "Player Chess :";
            // 
            // ptcbxPlayerChess
            // 
            this.ptcbxPlayerChess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcbxPlayerChess.Location = new System.Drawing.Point(594, 349);
            this.ptcbxPlayerChess.Name = "ptcbxPlayerChess";
            this.ptcbxPlayerChess.Size = new System.Drawing.Size(102, 102);
            this.ptcbxPlayerChess.TabIndex = 6;
            this.ptcbxPlayerChess.TabStop = false;
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 454);
            this.Controls.Add(this.ptcbxPlayerChess);
            this.Controls.Add(this.lblPlayerChess);
            this.Controls.Add(this.txbPlayerName);
            this.Controls.Add(this.pgsCooldown);
            this.Controls.Add(this.btnNewgame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBanco);
            this.Name = "Caro";
            this.Text = "Caro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCaroimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbxPlayerChess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbxCaroimage;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.ProgressBar pgsCooldown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Label lblPlayerChess;
        private System.Windows.Forms.PictureBox ptcbxPlayerChess;
    }
}