namespace FulgurantArt
{
    partial class AddArtForm
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
            this.lblAddNewArt = new System.Windows.Forms.Label();
            this.listViewArt = new System.Windows.Forms.ListView();
            this.imageListArt = new System.Windows.Forms.ImageList(this.components);
            this.btnAddNewArt = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnSubmitArt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblAddNewArt
            // 
            this.lblAddNewArt.AutoSize = true;
            this.lblAddNewArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewArt.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAddNewArt.Location = new System.Drawing.Point(12, 9);
            this.lblAddNewArt.Name = "lblAddNewArt";
            this.lblAddNewArt.Size = new System.Drawing.Size(131, 25);
            this.lblAddNewArt.TabIndex = 0;
            this.lblAddNewArt.Text = "Add New Art";
            // 
            // listViewArt
            // 
            this.listViewArt.LargeImageList = this.imageListArt;
            this.listViewArt.Location = new System.Drawing.Point(13, 38);
            this.listViewArt.Name = "listViewArt";
            this.listViewArt.Size = new System.Drawing.Size(327, 158);
            this.listViewArt.TabIndex = 2;
            this.listViewArt.UseCompatibleStateImageBehavior = false;
            this.listViewArt.Click += new System.EventHandler(this.listViewArt_Click);
            // 
            // imageListArt
            // 
            this.imageListArt.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListArt.ImageSize = new System.Drawing.Size(48, 48);
            this.imageListArt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAddNewArt
            // 
            this.btnAddNewArt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddNewArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewArt.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAddNewArt.Location = new System.Drawing.Point(13, 203);
            this.btnAddNewArt.Name = "btnAddNewArt";
            this.btnAddNewArt.Size = new System.Drawing.Size(130, 31);
            this.btnAddNewArt.TabIndex = 2;
            this.btnAddNewArt.Text = "Add New Art";
            this.btnAddNewArt.UseVisualStyleBackColor = false;
            this.btnAddNewArt.Click += new System.EventHandler(this.btnAddNewArt_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.LightSalmon;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(150, 204);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(190, 28);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.LinkColor = System.Drawing.Color.Chocolate;
            this.linkBack.Location = new System.Drawing.Point(302, 328);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 16);
            this.linkBack.TabIndex = 4;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // txtArt
            // 
            this.txtArt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtArt.Location = new System.Drawing.Point(13, 241);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(327, 29);
            this.txtArt.TabIndex = 5;
            this.txtArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArt.Visible = false;
            this.txtArt.TextChanged += new System.EventHandler(this.txtArt_TextChanged);
            // 
            // btnSubmitArt
            // 
            this.btnSubmitArt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSubmitArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitArt.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSubmitArt.Location = new System.Drawing.Point(13, 276);
            this.btnSubmitArt.Name = "btnSubmitArt";
            this.btnSubmitArt.Size = new System.Drawing.Size(328, 45);
            this.btnSubmitArt.TabIndex = 6;
            this.btnSubmitArt.Text = "Submit Art";
            this.btnSubmitArt.UseVisualStyleBackColor = false;
            this.btnSubmitArt.Visible = false;
            this.btnSubmitArt.Click += new System.EventHandler(this.btnSubmitArt_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AddArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmitArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnAddNewArt);
            this.Controls.Add(this.listViewArt);
            this.Controls.Add(this.lblAddNewArt);
            this.Name = "AddArtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddArtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewArt;
        private System.Windows.Forms.ListView listViewArt;
        private System.Windows.Forms.Button btnAddNewArt;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ImageList imageListArt;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnSubmitArt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}