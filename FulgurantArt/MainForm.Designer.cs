namespace FulgurantArt
{
    partial class MainForm
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
            this.btnAddArt = new System.Windows.Forms.Button();
            this.btnCheckCategory = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFulgurantArt = new System.Windows.Forms.Label();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAddArt
            // 
            this.btnAddArt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArt.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAddArt.Location = new System.Drawing.Point(80, 79);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(156, 34);
            this.btnAddArt.TabIndex = 0;
            this.btnAddArt.Text = "Add Art";
            this.btnAddArt.UseVisualStyleBackColor = false;
            this.btnAddArt.Click += new System.EventHandler(this.btnAddArt_Click);
            // 
            // btnCheckCategory
            // 
            this.btnCheckCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCheckCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCategory.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnCheckCategory.Location = new System.Drawing.Point(80, 119);
            this.btnCheckCategory.Name = "btnCheckCategory";
            this.btnCheckCategory.Size = new System.Drawing.Size(156, 34);
            this.btnCheckCategory.TabIndex = 1;
            this.btnCheckCategory.Text = "Check Category";
            this.btnCheckCategory.UseVisualStyleBackColor = false;
            this.btnCheckCategory.Click += new System.EventHandler(this.btnCheckCategory_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnBrowse.Location = new System.Drawing.Point(80, 158);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(156, 34);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFulgurantArt
            // 
            this.lblFulgurantArt.AutoSize = true;
            this.lblFulgurantArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulgurantArt.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFulgurantArt.Location = new System.Drawing.Point(94, 48);
            this.lblFulgurantArt.Name = "lblFulgurantArt";
            this.lblFulgurantArt.Size = new System.Drawing.Size(130, 25);
            this.lblFulgurantArt.TabIndex = 3;
            this.lblFulgurantArt.Text = "FulgurantArt";
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkExit.LinkColor = System.Drawing.Color.Chocolate;
            this.linkExit.Location = new System.Drawing.Point(141, 215);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(35, 20);
            this.linkExit.TabIndex = 4;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(312, 244);
            this.ControlBox = false;
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.lblFulgurantArt);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCheckCategory);
            this.Controls.Add(this.btnAddArt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FulgurantArt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArt;
        private System.Windows.Forms.Button btnCheckCategory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFulgurantArt;
        private System.Windows.Forms.LinkLabel linkExit;
    }
}

