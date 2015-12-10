namespace AutoSync
{
    partial class Main
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.Button_Sync = new System.Windows.Forms.Button();
      this.Label_SourcePath = new System.Windows.Forms.Label();
      this.Label_TargetPath = new System.Windows.Forms.Label();
      this.TextBox_SourcePath = new System.Windows.Forms.TextBox();
      this.TextBox_TargetPath = new System.Windows.Forms.TextBox();
      this.Button_SourcePath = new System.Windows.Forms.Button();
      this.Button_TargetPath = new System.Windows.Forms.Button();
      this.Label_Delay = new System.Windows.Forms.Label();
      this.ComboBox_Delay = new System.Windows.Forms.ComboBox();
      this.Label_DelayMinute = new System.Windows.Forms.Label();
      this.Timer_AutoSync = new System.Windows.Forms.Timer(this.components);
      this.FolderBrowserDialog_Path = new System.Windows.Forms.FolderBrowserDialog();
      this.TextBox_Extension = new System.Windows.Forms.TextBox();
      this.Label_Extension = new System.Windows.Forms.Label();
      this.TextBox_Log = new System.Windows.Forms.TextBox();
      this.NotifyIconNarrow = new System.Windows.Forms.NotifyIcon(this.components);
      this.SuspendLayout();
      // 
      // Button_Sync
      // 
      this.Button_Sync.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Button_Sync.Location = new System.Drawing.Point(16, 234);
      this.Button_Sync.Name = "Button_Sync";
      this.Button_Sync.Size = new System.Drawing.Size(433, 38);
      this.Button_Sync.TabIndex = 5;
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
      this.Label_SourcePath.TabIndex = 0;
      this.Label_SourcePath.Text = "來源資料夾：";
      // 
      // Label_TargetPath
      // 
      this.Label_TargetPath.AutoSize = true;
      this.Label_TargetPath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_TargetPath.Location = new System.Drawing.Point(12, 51);
      this.Label_TargetPath.Name = "Label_TargetPath";
      this.Label_TargetPath.Size = new System.Drawing.Size(124, 24);
      this.Label_TargetPath.TabIndex = 0;
      this.Label_TargetPath.Text = "目標資料夾：";
      // 
      // TextBox_SourcePath
      // 
      this.TextBox_SourcePath.Enabled = false;
      this.TextBox_SourcePath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.TextBox_SourcePath.Location = new System.Drawing.Point(142, 19);
      this.TextBox_SourcePath.Name = "TextBox_SourcePath";
      this.TextBox_SourcePath.Size = new System.Drawing.Size(254, 25);
      this.TextBox_SourcePath.TabIndex = 0;
      // 
      // TextBox_TargetPath
      // 
      this.TextBox_TargetPath.Enabled = false;
      this.TextBox_TargetPath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.TextBox_TargetPath.Location = new System.Drawing.Point(142, 50);
      this.TextBox_TargetPath.Name = "TextBox_TargetPath";
      this.TextBox_TargetPath.Size = new System.Drawing.Size(254, 25);
      this.TextBox_TargetPath.TabIndex = 0;
      // 
      // Button_SourcePath
      // 
      this.Button_SourcePath.Location = new System.Drawing.Point(401, 18);
      this.Button_SourcePath.Name = "Button_SourcePath";
      this.Button_SourcePath.Size = new System.Drawing.Size(49, 23);
      this.Button_SourcePath.TabIndex = 1;
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
      this.Button_TargetPath.TabIndex = 2;
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
      this.Label_Delay.TabIndex = 0;
      this.Label_Delay.Text = "延遲時間：";
      // 
      // ComboBox_Delay
      // 
      this.ComboBox_Delay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboBox_Delay.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.ComboBox_Delay.FormattingEnabled = true;
      this.ComboBox_Delay.Items.AddRange(new object[] {
            "0",
            "10",
            "30",
            "60",
            "120"});
      this.ComboBox_Delay.Location = new System.Drawing.Point(142, 112);
      this.ComboBox_Delay.Name = "ComboBox_Delay";
      this.ComboBox_Delay.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.ComboBox_Delay.Size = new System.Drawing.Size(254, 21);
      this.ComboBox_Delay.TabIndex = 4;
      // 
      // Label_DelayMinute
      // 
      this.Label_DelayMinute.AutoSize = true;
      this.Label_DelayMinute.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_DelayMinute.Location = new System.Drawing.Point(402, 109);
      this.Label_DelayMinute.Name = "Label_DelayMinute";
      this.Label_DelayMinute.Size = new System.Drawing.Size(48, 24);
      this.Label_DelayMinute.TabIndex = 9;
      this.Label_DelayMinute.Text = "分鐘";
      // 
      // Timer_AutoSync
      // 
      this.Timer_AutoSync.Interval = 3600000;
      this.Timer_AutoSync.Tick += new System.EventHandler(this.Timer_AutoSync_Tick);
      // 
      // TextBox_Extension
      // 
      this.TextBox_Extension.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.TextBox_Extension.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.TextBox_Extension.Location = new System.Drawing.Point(142, 81);
      this.TextBox_Extension.Name = "TextBox_Extension";
      this.TextBox_Extension.Size = new System.Drawing.Size(254, 25);
      this.TextBox_Extension.TabIndex = 3;
      this.TextBox_Extension.Text = ".jpg,.png,.bmp";
      this.TextBox_Extension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Label_Extension
      // 
      this.Label_Extension.AutoSize = true;
      this.Label_Extension.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Label_Extension.Location = new System.Drawing.Point(12, 82);
      this.Label_Extension.Name = "Label_Extension";
      this.Label_Extension.Size = new System.Drawing.Size(124, 24);
      this.Label_Extension.TabIndex = 0;
      this.Label_Extension.Text = "指定附檔名：";
      // 
      // TextBox_Log
      // 
      this.TextBox_Log.Location = new System.Drawing.Point(16, 140);
      this.TextBox_Log.Multiline = true;
      this.TextBox_Log.Name = "TextBox_Log";
      this.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TextBox_Log.Size = new System.Drawing.Size(433, 88);
      this.TextBox_Log.TabIndex = 0;
      // 
      // NotifyIconNarrow
      // 
      this.NotifyIconNarrow.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconNarrow.Icon")));
      this.NotifyIconNarrow.Text = "檔案自動同步";
      this.NotifyIconNarrow.Visible = true;
      this.NotifyIconNarrow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconNarrow_MouseDoubleClick);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(464, 284);
      this.Controls.Add(this.TextBox_Log);
      this.Controls.Add(this.Label_Extension);
      this.Controls.Add(this.TextBox_Extension);
      this.Controls.Add(this.Label_DelayMinute);
      this.Controls.Add(this.ComboBox_Delay);
      this.Controls.Add(this.Label_Delay);
      this.Controls.Add(this.Button_TargetPath);
      this.Controls.Add(this.Button_SourcePath);
      this.Controls.Add(this.TextBox_TargetPath);
      this.Controls.Add(this.TextBox_SourcePath);
      this.Controls.Add(this.Label_TargetPath);
      this.Controls.Add(this.Label_SourcePath);
      this.Controls.Add(this.Button_Sync);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.Text = "檔案自動同步";
      this.Load += new System.EventHandler(this.Main_Load);
      this.Resize += new System.EventHandler(this.Main_Resize);
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
    private System.Windows.Forms.ComboBox ComboBox_Delay;
    private System.Windows.Forms.Label Label_DelayMinute;
    private System.Windows.Forms.Timer Timer_AutoSync;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog_Path;
    private System.Windows.Forms.TextBox TextBox_Extension;
    private System.Windows.Forms.Label Label_Extension;
    private System.Windows.Forms.TextBox TextBox_Log;
    private System.Windows.Forms.NotifyIcon NotifyIconNarrow;
  }
}

