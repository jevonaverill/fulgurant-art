namespace FulgurantArt
{
    partial class CheckCategoryForm
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
            this.lblCheckCategory = new System.Windows.Forms.Label();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.btnCheckCategoryOrBrowseArt = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckCategory
            // 
            this.lblCheckCategory.AutoSize = true;
            this.lblCheckCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckCategory.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCheckCategory.Location = new System.Drawing.Point(66, 27);
            this.lblCheckCategory.Name = "lblCheckCategory";
            this.lblCheckCategory.Size = new System.Drawing.Size(166, 25);
            this.lblCheckCategory.TabIndex = 1;
            this.lblCheckCategory.Text = "Check Category";
            // 
            // pbArt
            // 
            this.pbArt.Location = new System.Drawing.Point(54, 57);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(183, 135);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 2;
            this.pbArt.TabStop = false;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.LinkColor = System.Drawing.Color.Chocolate;
            this.linkBack.Location = new System.Drawing.Point(233, 291);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 16);
            this.linkBack.TabIndex = 5;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // btnCheckCategoryOrBrowseArt
            // 
            this.btnCheckCategoryOrBrowseArt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCheckCategoryOrBrowseArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCategoryOrBrowseArt.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnCheckCategoryOrBrowseArt.Location = new System.Drawing.Point(78, 198);
            this.btnCheckCategoryOrBrowseArt.Name = "btnCheckCategoryOrBrowseArt";
            this.btnCheckCategoryOrBrowseArt.Size = new System.Drawing.Size(130, 31);
            this.btnCheckCategoryOrBrowseArt.TabIndex = 6;
            this.btnCheckCategoryOrBrowseArt.Text = "Browse Art";
            this.btnCheckCategoryOrBrowseArt.UseVisualStyleBackColor = false;
            this.btnCheckCategoryOrBrowseArt.Click += new System.EventHandler(this.btnCheckCategoryOrBrowseArt_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(90, 231);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Category:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCategory.Location = new System.Drawing.Point(78, 258);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(130, 25);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCheckCategoryOrBrowseArt);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.lblCheckCategory);
            this.Name = "CheckCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckCategory;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.Button btnCheckCategoryOrBrowseArt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblCategory;
    }
}