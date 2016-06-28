namespace KeepFocused
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWhat = new System.Windows.Forms.Label();
            this.lblSessionDataFile = new System.Windows.Forms.Label();
            this.txtSessionDataFileName = new System.Windows.Forms.TextBox();
            this.lblBrowse = new System.Windows.Forms.Button();
            this.btnViewDataFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(6, 29);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(540, 94);
            this.txtTask.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(413, 162);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(484, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhat.Location = new System.Drawing.Point(3, 13);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(189, 13);
            this.lblWhat.TabIndex = 3;
            this.lblWhat.Text = "&What you will do in this session:";
            // 
            // lblSessionDataFile
            // 
            this.lblSessionDataFile.AutoSize = true;
            this.lblSessionDataFile.Location = new System.Drawing.Point(3, 138);
            this.lblSessionDataFile.Name = "lblSessionDataFile";
            this.lblSessionDataFile.Size = new System.Drawing.Size(120, 13);
            this.lblSessionDataFile.TabIndex = 4;
            this.lblSessionDataFile.Text = "Session Data File Name";
            // 
            // txtSessionDataFileName
            // 
            this.txtSessionDataFileName.Location = new System.Drawing.Point(141, 135);
            this.txtSessionDataFileName.Name = "txtSessionDataFileName";
            this.txtSessionDataFileName.ReadOnly = true;
            this.txtSessionDataFileName.Size = new System.Drawing.Size(295, 20);
            this.txtSessionDataFileName.TabIndex = 5;
            // 
            // lblBrowse
            // 
            this.lblBrowse.Location = new System.Drawing.Point(441, 133);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(22, 23);
            this.lblBrowse.TabIndex = 6;
            this.lblBrowse.Text = "...";
            this.lblBrowse.UseVisualStyleBackColor = true;
            // 
            // btnViewDataFile
            // 
            this.btnViewDataFile.Location = new System.Drawing.Point(6, 162);
            this.btnViewDataFile.Name = "btnViewDataFile";
            this.btnViewDataFile.Size = new System.Drawing.Size(138, 23);
            this.btnViewDataFile.TabIndex = 7;
            this.btnViewDataFile.Text = "&View Session Data File";
            this.btnViewDataFile.UseVisualStyleBackColor = true;
            this.btnViewDataFile.Click += new System.EventHandler(this.btnViewDataFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Change File Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(150, 162);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // Task
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(554, 195);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnViewDataFile);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.txtSessionDataFileName);
            this.Controls.Add(this.lblSessionDataFile);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Keep Focused Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.Label lblSessionDataFile;
        private System.Windows.Forms.TextBox txtSessionDataFileName;
        private System.Windows.Forms.Button lblBrowse;
        private System.Windows.Forms.Button btnViewDataFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOptions;
    }
}
