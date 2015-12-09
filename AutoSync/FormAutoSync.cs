using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace AutoSync
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
      ComboBox_Delay.SelectedIndex = 0;
    }

    private void ButtonSync_Click(object sender, EventArgs e)
    {
      if (Directory.Exists(TextBox_SourcePath.Text) || Directory.Exists(TextBox_TargetPath.Text))
      {
        int timerInterval = 1;
        if (Convert.ToInt16(ComboBox_Delay.SelectedItem) != 0) timerInterval = Convert.ToInt16(ComboBox_Delay.SelectedItem) * 1000 * 60;
        Timer_AutoSync.Interval = timerInterval;
        ButtonSyncStatus();
      }
      else
      {
        Timer_AutoSync.Enabled = false;
        MessageBox.Show("請選擇正確目錄路徑。", "設定");
      }
    }

    private void Button_SourcePath_Click(object sender, EventArgs e)
    {
      if (FolderBrowserDialog_Path.ShowDialog() == DialogResult.OK)
      {
        TextBox_SourcePath.Text = FolderBrowserDialog_Path.SelectedPath;
      }
    }

    private void Button_TargetPath_Click(object sender, EventArgs e)
    {
      if (FolderBrowserDialog_Path.ShowDialog() == DialogResult.OK)
      {
        TextBox_TargetPath.Text = FolderBrowserDialog_Path.SelectedPath;
      }
    }

    private void DirectoryCopy(string sourceDirName, string destDirName, string extensionDirName, bool copySubDirs)
    {
      try
      {
        //來源路徑
        DirectoryInfo dir = new DirectoryInfo(sourceDirName);

        //來源路徑如果有問題
        if (!dir.Exists)
        {
          throw new DirectoryNotFoundException(
              "Source directory does not exist or could not be found: "
              + sourceDirName);
        }

        DirectoryInfo[] dirs = dir.GetDirectories();

        //路徑目錄
        if (!Directory.Exists(destDirName)) Directory.CreateDirectory(destDirName);

        //參數載入
        int countFile = 0;
        FileInfo[] sourceFiles = dir.GetFiles();
        DirectoryInfo Targetdir = new DirectoryInfo(destDirName);
        FileInfo[] targetFiles = Targetdir.GetFiles();
        List<FileInfo> targetFileList = new List<FileInfo>();
        List<string> extensionList = new List<string>();
        extensionList.AddRange(extensionDirName.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));

        foreach (FileInfo target in targetFiles) targetFileList.Add(target);
        foreach (FileInfo source in sourceFiles)
        {
          //副檔名篩選
          if (extensionList.Contains(source.Extension.ToLower()))
          {
            if (targetFileList.Any(o => o.Name == source.Name && o.LastWriteTime == source.LastWriteTime)) continue;
            string temppath = Path.Combine(destDirName, source.Name);
            source.CopyTo(temppath, true);
            countFile++;
          }
        }

        InputLog("已成功同步 " + countFile + " 個檔案。");

        //遞迴
        if (copySubDirs)
        {
          foreach (DirectoryInfo subdir in dirs)
          {
            string temppath = Path.Combine(destDirName, subdir.Name);
            DirectoryCopy(subdir.FullName, temppath, extensionDirName, copySubDirs);
          }
        }
      }
      catch(Exception ex)
      {
        ButtonSyncStatus();
        MessageBox.Show(ex.Message, "警告");
      }
    }

    private void ButtonSyncStatus()
    {
      if (Timer_AutoSync.Enabled)
      {
        Timer_AutoSync.Enabled = false;

        //TextBox_SourcePath.Enabled = true;
        Button_SourcePath.Enabled = true;
        //TextBox_TargetPath.Enabled = true;
        Button_TargetPath.Enabled = true;
        TextBox_Extension.Enabled = true;
        ComboBox_Delay.Enabled = true;

        Button_Sync.Text = "開始自動同步";
        InputLog("停止同步待命。");
      }
      else
      {
        string Message = "本程序即將在 " + Convert.ToInt16(ComboBox_Delay.SelectedItem) + " 分鐘後開始自動同步。";
        if (ComboBox_Delay.SelectedIndex <= 0) Message = "是否僅執行一次同步？";

        DialogResult ResultSync = MessageBox.Show(Message, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (ResultSync == DialogResult.Yes)
        {
          Timer_AutoSync.Enabled = true;

          //TextBox_SourcePath.Enabled = false;
          Button_SourcePath.Enabled = false;
          //TextBox_TargetPath.Enabled = false;
          Button_TargetPath.Enabled = false;
          TextBox_Extension.Enabled = false;
          ComboBox_Delay.Enabled = false;

          Button_Sync.Text = "停止自動同步";
          InputLog("自動同步待命...");
        }
      }
    }

    private void InputLog(string message)
    {
      TextBox_Log.Text += "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + message + Environment.NewLine;
      TextBox_Log.ScrollToCaret();
    }

    private void Timer_AutoSync_Tick(object sender, EventArgs e)
    {
      DirectoryCopy(TextBox_SourcePath.Text, TextBox_TargetPath.Text, TextBox_Extension.Text, true);
      if (ComboBox_Delay.SelectedIndex == 0) ButtonSyncStatus();
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    private void Main_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.ShowInTaskbar = false;
        this.NotifyIconNarrow.Visible = true;
      }
    }

    private void NotifyIconNarrow_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        this.ShowInTaskbar = true;
      }
    }
  }
}
