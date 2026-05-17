namespace CommitJourney;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnChoosePath = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        txtRepoPath = new System.Windows.Forms.TextBox();
        btnExportLog = new System.Windows.Forms.Button();
        btnExportCsv = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        rtbOutput = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnChoosePath
        // 
        btnChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnChoosePath.Location = new System.Drawing.Point(589, 13);
        btnChoosePath.Name = "btnChoosePath";
        btnChoosePath.Size = new System.Drawing.Size(199, 43);
        btnChoosePath.TabIndex = 0;
        btnChoosePath.Text = "选择仓库...(&C)";
        btnChoosePath.UseVisualStyleBackColor = true;
        btnChoosePath.Click += btnChoosePath_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(163, 50);
        label1.TabIndex = 1;
        label1.Text = "Repo path:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtRepoPath
        // 
        txtRepoPath.Location = new System.Drawing.Point(155, 16);
        txtRepoPath.Name = "txtRepoPath";
        txtRepoPath.ReadOnly = true;
        txtRepoPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
        txtRepoPath.Size = new System.Drawing.Size(428, 38);
        txtRepoPath.TabIndex = 2;
        // 
        // btnExportLog
        // 
        btnExportLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnExportLog.Location = new System.Drawing.Point(12, 84);
        btnExportLog.Name = "btnExportLog";
        btnExportLog.Size = new System.Drawing.Size(338, 89);
        btnExportLog.TabIndex = 3;
        btnExportLog.Text = "导出 Git Log";
        btnExportLog.UseVisualStyleBackColor = true;
        btnExportLog.Click += btnExportLog_Click;
        // 
        // btnExportCsv
        // 
        btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnExportCsv.Location = new System.Drawing.Point(450, 84);
        btnExportCsv.Name = "btnExportCsv";
        btnExportCsv.Size = new System.Drawing.Size(338, 89);
        btnExportCsv.TabIndex = 4;
        btnExportCsv.Text = "导出每日统计 CSV";
        btnExportCsv.UseVisualStyleBackColor = true;
        btnExportCsv.Click += btnExportCsv_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 196);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(163, 37);
        label2.TabIndex = 5;
        label2.Text = "输出情况：";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // rtbOutput
        // 
        rtbOutput.Location = new System.Drawing.Point(12, 236);
        rtbOutput.Multiline = true;
        rtbOutput.Name = "rtbOutput";
        rtbOutput.ReadOnly = true;
        rtbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        rtbOutput.Size = new System.Drawing.Size(776, 255);
        rtbOutput.TabIndex = 6;
        // 
        // label3
        // 
        label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label3.Location = new System.Drawing.Point(312, 494);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(476, 38);
        label3.TabIndex = 7;
        label3.Text = "© 2026 Mcenahle. Licensed under MIT.";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 541);
        Controls.Add(label3);
        Controls.Add(rtbOutput);
        Controls.Add(label2);
        Controls.Add(btnExportCsv);
        Controls.Add(btnExportLog);
        Controls.Add(txtRepoPath);
        Controls.Add(label1);
        Controls.Add(btnChoosePath);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        ShowIcon = false;
        Text = "CommitJourney - v0.1.1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox rtbOutput;

    private System.Windows.Forms.Button btnExportCsv;

    private System.Windows.Forms.Button btnExportLog;

    private System.Windows.Forms.TextBox txtRepoPath;

    private System.Windows.Forms.Button btnChoosePath;
    private System.Windows.Forms.Label label1;

    #endregion
}