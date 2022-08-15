namespace TempalteContoler
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabFormName = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClick = new WinformForTesting.RJButton();
            this.EditSearch = new WinformForTesting.RJControls.RJTextBox();
            this.LabResult = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.PanelTitle.Controls.Add(this.LabFormName);
            this.PanelTitle.Controls.Add(this.PBIcon);
            this.PanelTitle.Controls.Add(this.BtnClose);
            this.PanelTitle.Controls.Add(this.BtnSize);
            this.PanelTitle.Controls.Add(this.BtnMinimize);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(800, 32);
            this.PanelTitle.TabIndex = 2;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            this.PanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseMove);
            this.PanelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseUp);
            // 
            // LabFormName
            // 
            this.LabFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabFormName.AutoSize = true;
            this.LabFormName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabFormName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabFormName.Location = new System.Drawing.Point(360, 9);
            this.LabFormName.Name = "LabFormName";
            this.LabFormName.Size = new System.Drawing.Size(119, 17);
            this.LabFormName.TabIndex = 6;
            this.LabFormName.Text = "Application Name";
            // 
            // PBIcon
            // 
            this.PBIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBIcon.Image = ((System.Drawing.Image)(resources.GetObject("PBIcon.Image")));
            this.PBIcon.Location = new System.Drawing.Point(337, 6);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(21, 23);
            this.PBIcon.TabIndex = 2;
            this.PBIcon.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Location = new System.Drawing.Point(7, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(12, 12);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Tag = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnTitleForm_Click);
            // 
            // BtnSize
            // 
            this.BtnSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSize.BackgroundImage")));
            this.BtnSize.FlatAppearance.BorderSize = 0;
            this.BtnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSize.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSize.Location = new System.Drawing.Point(23, 11);
            this.BtnSize.Name = "BtnSize";
            this.BtnSize.Size = new System.Drawing.Size(12, 12);
            this.BtnSize.TabIndex = 4;
            this.BtnSize.Tag = "Size";
            this.BtnSize.UseVisualStyleBackColor = true;
            this.BtnSize.Click += new System.EventHandler(this.BtnTitleForm_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.BackgroundImage")));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.Location = new System.Drawing.Point(40, 11);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(12, 12);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Tag = "Minimize";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnTitleForm_Click);
            // 
            // BtnClick
            // 
            this.BtnClick.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnClick.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtnClick.BorderColer = System.Drawing.Color.Black;
            this.BtnClick.BorderRadius = 12;
            this.BtnClick.BorderSize = 0;
            this.BtnClick.FlatAppearance.BorderSize = 0;
            this.BtnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClick.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnClick.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClick.Location = new System.Drawing.Point(213, 38);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(76, 32);
            this.BtnClick.TabIndex = 3;
            this.BtnClick.Text = "Click";
            this.BtnClick.TextColor = System.Drawing.SystemColors.Control;
            this.BtnClick.UseVisualStyleBackColor = false;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // EditSearch
            // 
            this.EditSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.EditSearch.BorderColor = System.Drawing.Color.DimGray;
            this.EditSearch.BorderColorFouce = System.Drawing.Color.RoyalBlue;
            this.EditSearch.BorderRadius = 12;
            this.EditSearch.BorderSize = 1;
            this.EditSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditSearch.Location = new System.Drawing.Point(7, 38);
            this.EditSearch.Multiline = false;
            this.EditSearch.Name = "EditSearch";
            this.EditSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EditSearch.PasswordChar = false;
            this.EditSearch.PlaceHoderText = "Search";
            this.EditSearch.PlaceHolderColer = System.Drawing.Color.DarkGray;
            this.EditSearch.ReadOnly = false;
            this.EditSearch.Size = new System.Drawing.Size(200, 32);
            this.EditSearch.TabIndex = 4;
            this.EditSearch.Texts = "";
            this.EditSearch.UnderlinedStyle = false;
            // 
            // LabResult
            // 
            this.LabResult.AutoSize = true;
            this.LabResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabResult.Location = new System.Drawing.Point(12, 73);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(0, 17);
            this.LabResult.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabResult);
            this.Controls.Add(this.EditSearch);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelTitle;
        private Label LabFormName;
        private PictureBox PBIcon;
        private Button BtnClose;
        private Button BtnSize;
        private Button BtnMinimize;
        private WinformForTesting.RJButton BtnClick;
        private WinformForTesting.RJControls.RJTextBox EditSearch;
        private Label LabResult;
    }
}