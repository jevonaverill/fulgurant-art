namespace FulgurantArt
{
    partial class ArtDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.lblArtDetail = new System.Windows.Forms.Label();
            this.pbArtDetail = new System.Windows.Forms.PictureBox();
            this.listViewSimilarArt = new System.Windows.Forms.ListView();
            this.imageListSimilarArt = new System.Windows.Forms.ImageList(this.components);
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.lblPictureName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtDetail
            // 
            this.lblArtDetail.AutoSize = true;
            this.lblArtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtDetail.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblArtDetail.Location = new System.Drawing.Point(12, 9);
            this.lblArtDetail.Name = "lblArtDetail";
            this.lblArtDetail.Size = new System.Drawing.Size(100, 25);
            this.lblArtDetail.TabIndex = 2;
            this.lblArtDetail.Text = "Art Detail";
            // 
            // pbArtDetail
            // 
            this.pbArtDetail.Location = new System.Drawing.Point(17, 80);
            this.pbArtDetail.Name = "pbArtDetail";
            this.pbArtDetail.Size = new System.Drawing.Size(257, 205);
            this.pbArtDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArtDetail.TabIndex = 3;
            this.pbArtDetail.TabStop = false;
            // 
            // listViewSimilarArt
            // 
            this.listViewSimilarArt.LargeImageList = this.imageListSimilarArt;
            this.listViewSimilarArt.Location = new System.Drawing.Point(304, 27);
            this.listViewSimilarArt.Name = "listViewSimilarArt";
            this.listViewSimilarArt.Size = new System.Drawing.Size(357, 360);
            this.listViewSimilarArt.TabIndex = 7;
            this.listViewSimilarArt.UseCompatibleStateImageBehavior = false;
            this.listViewSimilarArt.DoubleClick += new System.EventHandler(this.listViewSimilarArt_DoubleClick);
            // 
            // imageListSimilarArt
            // 
            this.imageListSimilarArt.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSimilarArt.ImageSize = new System.Drawing.Size(48, 48);
            this.imageListSimilarArt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.LinkColor = System.Drawing.Color.Chocolate;
            this.linkBack.Location = new System.Drawing.Point(622, 464);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 16);
            this.linkBack.TabIndex = 8;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // lblPictureName
            // 
            this.lblPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPictureName.Location = new System.Drawing.Point(12, 297);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(262, 25);
            this.lblPictureName.TabIndex = 10;
            this.lblPictureName.Text = "Picture Name";
            this.lblPictureName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArtDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(673, 489);
            this.ControlBox = false;
            this.Controls.Add(this.lblPictureName);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.listViewSimilarArt);
            this.Controls.Add(this.pbArtDetail);
            this.Controls.Add(this.lblArtDetail);
            this.Name = "ArtDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbArtDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtDetail;
        private System.Windows.Forms.PictureBox pbArtDetail;
        private System.Windows.Forms.ListView listViewSimilarArt;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.ImageList imageListSimilarArt;
        private System.Windows.Forms.Label lblPictureName;
    }
}