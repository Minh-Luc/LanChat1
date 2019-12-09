namespace Client
{
    partial class PrivateChat
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
            this.pnlPrivate = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblPrivate = new System.Windows.Forms.Label();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.pnChat = new System.Windows.Forms.Panel();
            this.ptbxGame = new System.Windows.Forms.PictureBox();
            this.ptbxClose = new System.Windows.Forms.PictureBox();
            this.ptbxMinimize = new System.Windows.Forms.PictureBox();
            this.ptbxSticker = new System.Windows.Forms.PictureBox();
            this.ptbxFile = new System.Windows.Forms.PictureBox();
            this.ptbxImage = new System.Windows.Forms.PictureBox();
            this.pnlPrivate.SuspendLayout();
            this.pnChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxSticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrivate
            // 
            this.pnlPrivate.BackColor = System.Drawing.Color.Firebrick;
            this.pnlPrivate.Controls.Add(this.btnSettings);
            this.pnlPrivate.Controls.Add(this.btnInfo);
            this.pnlPrivate.Controls.Add(this.lblPrivate);
            this.pnlPrivate.Location = new System.Drawing.Point(1, 1);
            this.pnlPrivate.Name = "pnlPrivate";
            this.pnlPrivate.Size = new System.Drawing.Size(221, 494);
            this.pnlPrivate.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 142);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(221, 47);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(0, 88);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(221, 47);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivate.ForeColor = System.Drawing.Color.White;
            this.lblPrivate.Location = new System.Drawing.Point(12, 12);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(194, 26);
            this.lblPrivate.TabIndex = 0;
            this.lblPrivate.Text = "LANCHAT[Private]";
            // 
            // txbMessage
            // 
            this.txbMessage.BackColor = System.Drawing.Color.White;
            this.txbMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbMessage.Location = new System.Drawing.Point(228, 456);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(466, 39);
            this.txbMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Firebrick;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(697, 456);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 39);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.BackColor = System.Drawing.Color.Firebrick;
            this.rtbxMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbxMessage.Location = new System.Drawing.Point(229, 30);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(523, 384);
            this.rtbxMessage.TabIndex = 3;
            this.rtbxMessage.Text = "";
            this.rtbxMessage.TextChanged += new System.EventHandler(this.rtbxMessage_TextChanged);
            // 
            // pnChat
            // 
            this.pnChat.BackColor = System.Drawing.Color.Firebrick;
            this.pnChat.Controls.Add(this.ptbxClose);
            this.pnChat.Controls.Add(this.ptbxMinimize);
            this.pnChat.Location = new System.Drawing.Point(228, 1);
            this.pnChat.Name = "pnChat";
            this.pnChat.Size = new System.Drawing.Size(522, 23);
            this.pnChat.TabIndex = 9;
            // 
            // ptbxGame
            // 
            this.ptbxGame.BackgroundImage = global::Client.Properties.Resources.game;
            this.ptbxGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxGame.Location = new System.Drawing.Point(351, 420);
            this.ptbxGame.Name = "ptbxGame";
            this.ptbxGame.Size = new System.Drawing.Size(34, 30);
            this.ptbxGame.TabIndex = 10;
            this.ptbxGame.TabStop = false;
            // 
            // ptbxClose
            // 
            this.ptbxClose.BackColor = System.Drawing.Color.Silver;
            this.ptbxClose.BackgroundImage = global::Client.Properties.Resources.close;
            this.ptbxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxClose.Location = new System.Drawing.Point(498, 0);
            this.ptbxClose.Name = "ptbxClose";
            this.ptbxClose.Size = new System.Drawing.Size(24, 24);
            this.ptbxClose.TabIndex = 4;
            this.ptbxClose.TabStop = false;
            // 
            // ptbxMinimize
            // 
            this.ptbxMinimize.BackColor = System.Drawing.Color.Silver;
            this.ptbxMinimize.BackgroundImage = global::Client.Properties.Resources.minimize;
            this.ptbxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxMinimize.Location = new System.Drawing.Point(474, 0);
            this.ptbxMinimize.Name = "ptbxMinimize";
            this.ptbxMinimize.Size = new System.Drawing.Size(24, 24);
            this.ptbxMinimize.TabIndex = 5;
            this.ptbxMinimize.TabStop = false;
            // 
            // ptbxSticker
            // 
            this.ptbxSticker.BackgroundImage = global::Client.Properties.Resources.sticker;
            this.ptbxSticker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxSticker.Location = new System.Drawing.Point(310, 420);
            this.ptbxSticker.Name = "ptbxSticker";
            this.ptbxSticker.Size = new System.Drawing.Size(34, 30);
            this.ptbxSticker.TabIndex = 8;
            this.ptbxSticker.TabStop = false;
            // 
            // ptbxFile
            // 
            this.ptbxFile.BackgroundImage = global::Client.Properties.Resources.file;
            this.ptbxFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxFile.Location = new System.Drawing.Point(269, 420);
            this.ptbxFile.Name = "ptbxFile";
            this.ptbxFile.Size = new System.Drawing.Size(34, 30);
            this.ptbxFile.TabIndex = 7;
            this.ptbxFile.TabStop = false;
            // 
            // ptbxImage
            // 
            this.ptbxImage.BackgroundImage = global::Client.Properties.Resources.image;
            this.ptbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxImage.Location = new System.Drawing.Point(229, 420);
            this.ptbxImage.Name = "ptbxImage";
            this.ptbxImage.Size = new System.Drawing.Size(34, 30);
            this.ptbxImage.TabIndex = 6;
            this.ptbxImage.TabStop = false;
            // 
            // PrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 503);
            this.Controls.Add(this.ptbxGame);
            this.Controls.Add(this.pnChat);
            this.Controls.Add(this.ptbxSticker);
            this.Controls.Add(this.ptbxFile);
            this.Controls.Add(this.ptbxImage);
            this.Controls.Add(this.rtbxMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.pnlPrivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrivateChat";
            this.Text = "PrivateChat";
            this.Load += new System.EventHandler(this.PrivateChat_Load);
            this.pnlPrivate.ResumeLayout(false);
            this.pnlPrivate.PerformLayout();
            this.pnChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxSticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrivate;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPrivate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox ptbxClose;
        private System.Windows.Forms.PictureBox ptbxMinimize;
        private System.Windows.Forms.PictureBox ptbxImage;
        private System.Windows.Forms.PictureBox ptbxFile;
        private System.Windows.Forms.PictureBox ptbxSticker;
        private System.Windows.Forms.Panel pnChat;
        private System.Windows.Forms.PictureBox ptbxGame;
    }
}