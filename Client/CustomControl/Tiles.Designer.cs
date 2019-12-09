namespace Client.CustomControl
{
    partial class Tiles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TilesName = new System.Windows.Forms.Label();
            this.TilesAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TilesAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TilesName
            // 
            this.TilesName.AutoSize = true;
            this.TilesName.BackColor = System.Drawing.Color.Transparent;
            this.TilesName.Font = new System.Drawing.Font("PartnerCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilesName.Location = new System.Drawing.Point(26, 109);
            this.TilesName.Name = "TilesName";
            this.TilesName.Size = new System.Drawing.Size(94, 25);
            this.TilesName.TabIndex = 0;
            this.TilesName.Text = "Username";
            this.TilesName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseDown);
            this.TilesName.MouseEnter += new System.EventHandler(this.Tiles_MouseEnter);
            this.TilesName.MouseLeave += new System.EventHandler(this.Tiles_MouseLeave);
            this.TilesName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseUp);
            // 
            // TilesAvatar
            // 
            this.TilesAvatar.BackColor = System.Drawing.Color.Transparent;
            this.TilesAvatar.Location = new System.Drawing.Point(33, 24);
            this.TilesAvatar.Name = "TilesAvatar";
            this.TilesAvatar.Size = new System.Drawing.Size(79, 72);
            this.TilesAvatar.TabIndex = 1;
            this.TilesAvatar.TabStop = false;
            this.TilesAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseDown);
            this.TilesAvatar.MouseEnter += new System.EventHandler(this.Tiles_MouseEnter);
            this.TilesAvatar.MouseLeave += new System.EventHandler(this.Tiles_MouseLeave);
            this.TilesAvatar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseUp);
            // 
            // Tiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.TilesAvatar);
            this.Controls.Add(this.TilesName);
            this.Name = "Tiles";
            this.Size = new System.Drawing.Size(147, 147);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Tiles_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Tiles_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.TilesAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TilesName;
        public System.Windows.Forms.PictureBox TilesAvatar;
    }
}
