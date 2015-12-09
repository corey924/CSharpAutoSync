namespace AutoSync
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.Button_Sync = new System.Windows.Forms.Button();
      this.Label_SourcePath = new System.Windows.Forms.Label();
      this.Label_TargetPath = new System.Windows.Forms.Label();
      this.TextBox_SourcePath = new System.Windows.Forms.TextBox();
      this.TextBox_TargetPath = new System.Windows.Forms.TextBox();
      this.Button_SourcePath = new System.Windows.Forms.Button();
      this.Button_TargetPath = new System.Windows.Forms.Button();
      this.Label_Delay = new System.Windows.Forms.Label();
      this.comboBox_Delay = new System.Windows.Forms.ComboBox();
      this.label_DelayMinute = new System.Windows.Forms.Label();
      this.Timer_AutoSync = new System.Windows.Forms.Timer(this.components);
      this.FolderBrowserDialog_Path = new System.Windows.Forms.FolderBrowserDialog();
      this.textBoxExtension = new System.Windows.Forms.TextBox();
      this.labelExtension = new System.Windows.Forms.Label();
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Button_Sync
      // 
      this.Button_Sync.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Button_Sync.Location = new System.Drawing.Point(16, 234);
      this.Button_Sync.Name = "Button_Sync";
      this.Button_Sync.Size = new System.Drawing.Size(433, 38);
      this.Button_Sync.TabIndex = 0;
      this.Button_Sync.Text = "開始自動同步";
      this.Button_Sync.UseVisualStyleBackColor = true;
      this.Button_Sync.Click += new System.EventHandler(this.ButtonSync_Click);
      // 
      // Label_SourcePath
      // 
      this.Label_SourcePath.AutoSize = true;
      this.Label_SourcePath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_SourcePath.Location = new System.Drawing.Point(12, 20);
      this.Label_SourcePath.Name = "Label_SourcePath";
      this.Label_SourcePath.Size = new System.Drawing.Size(124, 24);
      this.Label_SourcePath.TabIndex = 1;
      this.Label_SourcePath.Text = "來源資料夾：";
      // 
      // Label_TargetPath
      // 
      this.Label_TargetPath.AutoSize = true;
      this.Label_TargetPath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_TargetPath.Location = new System.Drawing.Point(12, 51);
      this.Label_TargetPath.Name = "Label_TargetPath";
      this.Label_TargetPath.Size = new System.Drawing.Size(124, 24);
      this.Label_TargetPath.TabIndex = 2;
      this.Label_TargetPath.Text = "目標資料夾：";
      // 
      // TextBox_SourcePath
      // 
      this.TextBox_SourcePath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.TextBox_SourcePath.Location = new System.Drawing.Point(142, 19);
      this.TextBox_SourcePath.Name = "TextBox_SourcePath";
      this.TextBox_SourcePath.Size = new System.Drawing.Size(254, 25);
      this.TextBox_SourcePath.TabIndex = 3;
      // 
      // TextBox_TargetPath
      // 
      this.TextBox_TargetPath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.TextBox_TargetPath.Location = new System.Drawing.Point(142, 50);
      this.TextBox_TargetPath.Name = "TextBox_TargetPath";
      this.TextBox_TargetPath.Size = new System.Drawing.Size(254, 25);
      this.TextBox_TargetPath.TabIndex = 4;
      // 
      // Button_SourcePath
      // 
      this.Button_SourcePath.Location = new System.Drawing.Point(401, 18);
      this.Button_SourcePath.Name = "Button_SourcePath";
      this.Button_SourcePath.Size = new System.Drawing.Size(49, 23);
      this.Button_SourcePath.TabIndex = 5;
      this.Button_SourcePath.Text = "瀏覽";
      this.Button_SourcePath.UseVisualStyleBackColor = true;
      this.Button_SourcePath.Click += new System.EventHandler(this.Button_SourcePath_Click);
      // 
      // Button_TargetPath
      // 
      this.Button_TargetPath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Button_TargetPath.Location = new System.Drawing.Point(401, 49);
      this.Button_TargetPath.Name = "Button_TargetPath";
      this.Button_TargetPath.Size = new System.Drawing.Size(49, 23);
      this.Button_TargetPath.TabIndex = 6;
      this.Button_TargetPath.Text = "瀏覽";
      this.Button_TargetPath.UseVisualStyleBackColor = true;
      this.Button_TargetPath.Click += new System.EventHandler(this.Button_TargetPath_Click);
      // 
      // Label_Delay
      // 
      this.Label_Delay.AutoSize = true;
      this.Label_Delay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_Delay.Location = new System.Drawing.Point(31, 112);
      this.Label_Delay.Name = "Label_Delay";
      this.Label_Delay.Size = new System.Drawing.Size(105, 24);
      this.Label_Delay.TabIndex = 7;
      this.Label_Delay.Text = "延遲時間：";
      // 
      // comboBox_Delay
      // 
      this.comboBox_Delay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_Delay.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.comboBox_Delay.FormattingEnabled = true;
      this.comboBox_Delay.Items.AddRange(new object[] {
            "0",
            "10",
            "30",
            "60",
            "120"});
      this.comboBox_Delay.Location = new System.Drawing.Point(142, 112);
      this.comboBox_Delay.Name = "comboBox_Delay";
      this.comboBox_Delay.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.comboBox_Delay.Size = new System.Drawing.Size(254, 21);
      this.comboBox_Delay.TabIndex = 8;
      // 
      // label_DelayMinute
      // 
      this.label_DelayMinute.AutoSize = true;
      this.label_DelayMinute.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label_DelayMinute.Location = new System.Drawing.Point(402, 109);
      this.label_DelayMinute.Name = "label_DelayMinute";
      this.label_DelayMinute.Size = new System.Drawing.Size(48, 24);
      this.label_DelayMinute.TabIndex = 9;
      this.label_DelayMinute.Text = "分鐘";
      // 
      // Timer_AutoSync
      // 
      this.Timer_AutoSync.Interval = 600000;
      this.Timer_AutoSync.Tick += new System.EventHandler(this.Timer_AutoSync_Tick);
      // 
      // textBoxExtension
      // 
      this.textBoxExtension.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.textBoxExtension.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.textBoxExtension.Location = new System.Drawing.Point(142, 81);
      this.textBoxExtension.Name = "textBoxExtension";
      this.textBoxExtension.Size = new System.Drawing.Size(254, 25);
      this.textBoxExtension.TabIndex = 10;
      this.textBoxExtension.Text = ".jpg,.png,.bmp";
      this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // labelExtension
      // 
      this.labelExtension.AutoSize = true;
      this.labelExtension.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.labelExtension.Location = new System.Drawing.Point(12, 82);
      this.labelExtension.Name = "labelExtension";
      this.labelExtension.Size = new System.Drawing.Size(124, 24);
      this.labelExtension.TabIndex = 11;
      this.labelExtension.Text = "指定附檔名：";
      // 
      // textBoxLog
      // 
      this.textBoxLog.Location = new System.Drawing.Point(16, 140);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxLog.Size = new System.Drawing.Size(433, 88);
      this.textBoxLog.TabIndex = 12;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(464, 284);
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.labelExtension);
      this.Controls.Add(this.textBoxExtension);
      this.Controls.Add(this.label_DelayMinute);
      this.Controls.Add(this.comboBox_Delay);
      this.Controls.Add(this.Label_Delay);
      this.Controls.Add(this.Button_TargetPath);
      this.Controls.Add(this.Button_SourcePath);
      this.Controls.Add(this.TextBox_TargetPath);
      this.Controls.Add(this.TextBox_SourcePath);
      this.Controls.Add(this.Label_TargetPath);
      this.Controls.Add(this.Label_SourcePath);
      this.Controls.Add(this.Button_Sync);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMain";
      this.Text = "檔案自動同步";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Sync;
        private System.Windows.Forms.Label Label_SourcePath;
        private System.Windows.Forms.Label Label_TargetPath;
        private System.Windows.Forms.TextBox TextBox_SourcePath;
        private System.Windows.Forms.TextBox TextBox_TargetPath;
        private System.Windows.Forms.Button Button_SourcePath;
        private System.Windows.Forms.Button Button_TargetPath;
    private System.Windows.Forms.Label Label_Delay;
    private System.Windows.Forms.ComboBox comboBox_Delay;
    private System.Windows.Forms.Label label_DelayMinute;
    private System.Windows.Forms.Timer Timer_AutoSync;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog_Path;
    private System.Windows.Forms.TextBox textBoxExtension;
    private System.Windows.Forms.Label labelExtension;
    private System.Windows.Forms.TextBox textBoxLog;
  }
}

