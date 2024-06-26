﻿namespace PostManClone.UI;

partial class Dashboard
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
        statusStrip = new StatusStrip();
        apiStatus = new ToolStripStatusLabel();
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        apiClick = new Button();
        resultsText = new TextBox();
        resultsLabel = new Label();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.White;
        statusStrip.ImageScalingSize = new Size(24, 24);
        statusStrip.Items.AddRange(new ToolStripItem[] { apiStatus });
        statusStrip.Location = new Point(0, 866);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1004, 32);
        statusStrip.TabIndex = 0;
        statusStrip.Text = "API Status";
        // 
        // apiStatus
        // 
        apiStatus.Name = "apiStatus";
        apiStatus.Size = new Size(60, 25);
        apiStatus.Text = "Ready";
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(0, 0);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(372, 70);
        formHeader.TabIndex = 1;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        apiLabel.Location = new Point(19, 81);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(90, 32);
        apiLabel.TabIndex = 2;
        apiLabel.Text = "API Url:";
        // 
        // apiText
        // 
        apiText.Location = new Point(25, 116);
        apiText.Name = "apiText";
        apiText.Size = new Size(862, 55);
        apiText.TabIndex = 3;
        // 
        // apiClick
        // 
        apiClick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        apiClick.Location = new Point(890, 116);
        apiClick.Name = "apiClick";
        apiClick.Size = new Size(72, 55);
        apiClick.TabIndex = 4;
        apiClick.Text = "Go";
        apiClick.UseVisualStyleBackColor = true;
        apiClick.Click += apiClick_Click;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Location = new Point(25, 265);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(937, 545);
        resultsText.TabIndex = 5;
        // 
        // resultsLabel
        // 
        resultsLabel.AutoSize = true;
        resultsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        resultsLabel.Location = new Point(19, 230);
        resultsLabel.Name = "resultsLabel";
        resultsLabel.Size = new Size(88, 32);
        resultsLabel.TabIndex = 6;
        resultsLabel.Text = "Results";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1004, 898);
        Controls.Add(resultsLabel);
        Controls.Add(resultsText);
        Controls.Add(apiClick);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Controls.Add(statusStrip);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(6);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Postman Clone App By Nuthan";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip;
    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button apiClick;
    private TextBox resultsText;
    private Label resultsLabel;
    private ToolStripStatusLabel apiStatus;
}
