namespace CommitJourney;
using System.Diagnostics;
using System.Text;
using System.Globalization;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void btnChoosePath_Click(object sender, EventArgs e)
    {
        using FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        folderDialog.Description = "选择 Git 仓库目录";

        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            txtRepoPath.Text = folderDialog.SelectedPath;
        }
    }
    
    private void btnExportLog_Click(object sender, EventArgs e)
    {
        try
        {
            string repoPath = txtRepoPath.Text;

            if (string.IsNullOrWhiteSpace(repoPath))
            {
                MessageBox.Show("请先选择 Git 仓库！",
                    "Commit Journey",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = "log --pretty=format:\"%h %ad | %s\" --date=short",
                WorkingDirectory = repoPath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8
            };

            using Process process = new Process();
            process.StartInfo = psi;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(error))
            {
                rtbOutput.AppendText($"[ERROR]\n{error}\n");
                return;
            }

            string outputPath = Path.Combine(repoPath, "git-log.txt");

            File.WriteAllText(outputPath, output, Encoding.UTF8);

            rtbOutput.AppendText($"[INFO] Git Log 导出成功！\n");
            rtbOutput.AppendText($"[INFO] 文件位置：{outputPath}\n\n");
        }
        catch (Exception ex)
        {
            rtbOutput.AppendText($"[EXCEPTION] {ex.Message}\n");
        }
    }

    private void btnExportCsv_Click(object sender, EventArgs e)
{
    try
    {
        string repoPath = txtRepoPath.Text;

        if (string.IsNullOrWhiteSpace(repoPath))
        {
            MessageBox.Show("请先选择 Git 仓库！",
                "Commit Journey",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = "log --date=short --pretty=format:%ad",
            WorkingDirectory = repoPath,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            StandardOutputEncoding = Encoding.UTF8
        };

        using Process process = new Process();
        process.StartInfo = psi;

        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();

        if (!string.IsNullOrWhiteSpace(error))
        {
            rtbOutput.AppendText($"[ERROR]\n{error}\n");
            return;
        }

        string[] lines = output
            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        var commitStats = lines
            .GroupBy(date => date)
            .Select(group => new
            {
                Date = group.Key,
                Commits = group.Count()
            })
            .OrderBy(item => item.Date);

        StringBuilder csvBuilder = new StringBuilder();

        csvBuilder.AppendLine("Date,Commits");

        foreach (var item in commitStats)
        {
            csvBuilder.AppendLine($"{item.Date},{item.Commits}");
        }

        string csvPath = Path.Combine(repoPath, "commits-per-day.csv");

        File.WriteAllText(csvPath, csvBuilder.ToString(), Encoding.UTF8);

        rtbOutput.AppendText($"[INFO] CSV 导出成功！\n");
        rtbOutput.AppendText($"[INFO] 文件位置：{csvPath}\n\n");
    }
    catch (Exception ex)
    {
        rtbOutput.AppendText($"[EXCEPTION] {ex.Message}\n");
    }
}
}