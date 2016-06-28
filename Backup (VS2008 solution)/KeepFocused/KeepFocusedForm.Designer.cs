namespace KeepFocused
{
    partial class KeepFocusedForm
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMoveHandle = new System.Windows.Forms.Label();
            this.lblPlayPause = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(37, 0);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 19);
            this.lblTimer.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(98, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 17);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "Ð";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMoveHandle
            // 
            this.lblMoveHandle.AutoSize = true;
            this.lblMoveHandle.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveHandle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoveHandle.Location = new System.Drawing.Point(1, 3);
            this.lblMoveHandle.Name = "lblMoveHandle";
            this.lblMoveHandle.Size = new System.Drawing.Size(10, 14);
            this.lblMoveHandle.TabIndex = 5;
            this.lblMoveHandle.Text = "I";
            this.lblMoveHandle.MouseLeave += new System.EventHandler(this.lblMoveHandler_MouseLeave);
            this.lblMoveHandle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMoveHandler_MouseDown);
            this.lblMoveHandle.MouseHover += new System.EventHandler(this.lblMoveHandler_MouseHover);
            // 
            // lblPlayPause
            // 
            this.lblPlayPause.AutoSize = true;
            this.lblPlayPause.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayPause.ForeColor = System.Drawing.Color.White;
            this.lblPlayPause.Image = global::KeepFocused.Properties.Resources.stop_Icon_White;
            this.lblPlayPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayPause.Location = new System.Drawing.Point(23, 2);
            this.lblPlayPause.Name = "lblPlayPause";
            this.lblPlayPause.Size = new System.Drawing.Size(13, 14);
            this.lblPlayPause.TabIndex = 4;
            this.lblPlayPause.Tag = "";
            this.lblPlayPause.Text = "u";
            this.lblPlayPause.Click += new System.EventHandler(this.lblPlayPause_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblInfo.Location = new System.Drawing.Point(87, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(14, 19);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "i";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // KeepFocusedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(120, 20);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblMoveHandle);
            this.Controls.Add(this.lblPlayPause);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeepFocusedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KeepFocusedForm_Load);
            this.Move += new System.EventHandler(this.KeepFocusedForm_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblPlayPause;
        private System.Windows.Forms.Label lblMoveHandle;
        private System.Windows.Forms.Label lblInfo;
    }
}

