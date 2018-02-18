namespace FulgurantArt
{
    partial class BrowseForm
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
            this.lblFulgurantArtGetFulgent = new System.Windows.Forms.Label();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.listViewArt = new System.Windows.Forms.ListView();
            this.imageListArt = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblFulgurantArtGetFulgent
            // 
            this.lblFulgurantArtGetFulgent.AutoSize = true;
            this.lblFulgurantArtGetFulgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulgurantArtGetFulgent.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFulgurantArtGetFulgent.Location = new System.Drawing.Point(5, 9);
            this.lblFulgurantArtGetFulgent.Name = "lblFulgurantArtGetFulgent";
            this.lblFulgurantArtGetFulgent.Size = new System.Drawing.Size(267, 25);
            this.lblFulgurantArtGetFulgent.TabIndex = 4;
            this.lblFulgurantArtGetFulgent.Text = "Fulgurant Art - Get Fulgent";
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.LinkColor = System.Drawing.Color.Chocolate;
            this.linkBack.Location = new System.Drawing.Point(564, 305);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 16);
            this.linkBack.TabIndex = 5;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // listViewArt
            // 
            this.listViewArt.LargeImageList = this.imageListArt;
            this.listViewArt.Location = new System.Drawing.Point(10, 37);
            this.listViewArt.Name = "listViewArt";
            this.listViewArt.Size = new System.Drawing.Size(593, 265);
            this.listViewArt.TabIndex = 6;
            this.listViewArt.UseCompatibleStateImageBehavior = false;
            this.listViewArt.DoubleClick += new System.EventHandler(this.listViewArt_DoubleClick);
            // 
            // imageListArt
            // 
            this.imageListArt.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListArt.ImageSize = new System.Drawing.Size(48, 48);
            this.imageListArt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(615, 330);
            this.ControlBox = false;
            this.Controls.Add(this.listViewArt);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.lblFulgurantArtGetFulgent);
            this.Name = "BrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFulgurantArtGetFulgent;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.ListView listViewArt;
        private System.Windows.Forms.ImageList imageListArt;
    }
}