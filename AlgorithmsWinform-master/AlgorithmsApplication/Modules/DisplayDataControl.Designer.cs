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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.tabInformation.SuspendLayout();
            this.tabLog.SuspendLayout();
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
            this.tabLog.Controls.Add(this.Btn1);
            this.tabLog.Controls.Add(this.Txt1);
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
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(0, 35);
            this.Txt1.Multiline = true;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(399, 356);
            this.Txt1.TabIndex = 0;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(-1, 6);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Show Log";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // DisplayDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabInformation);
            this.Name = "DisplayDataControl";
            this.Size = new System.Drawing.Size(413, 423);
            this.tabInformation.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInformation;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabInfor;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn1;

    }
}
