namespace AlgorithmsApplication.Modules
{
    partial class DisplayDataControl
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
            this.tabInformation = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.tabInfor = new System.Windows.Forms.TabPage();
            this.tabInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.tabLog);
            this.tabInformation.Controls.Add(this.tabInfor);
            this.tabInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInformation.Location = new System.Drawing.Point(0, 0);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.SelectedIndex = 0;
            this.tabInformation.Size = new System.Drawing.Size(413, 423);
            this.tabInformation.TabIndex = 0;
            this.tabInformation.Tag = "";
            // 
            // tabLog
            // 
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(405, 397);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // tabInfor
            // 
            this.tabInfor.Location = new System.Drawing.Point(4, 22);
            this.tabInfor.Name = "tabInfor";
            this.tabInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfor.Size = new System.Drawing.Size(405, 397);
            this.tabInfor.TabIndex = 1;
            this.tabInfor.Text = "Infor";
            this.tabInfor.UseVisualStyleBackColor = true;
            // 
            // DisplayDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabInformation);
            this.Name = "DisplayDataControl";
            this.Size = new System.Drawing.Size(413, 423);
            this.tabInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInformation;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabInfor;

    }
}
