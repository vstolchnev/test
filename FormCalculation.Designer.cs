namespace EventsExample2019_643
{
  partial class FormCalculation
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
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.labelOperand = new System.Windows.Forms.Label();
      this.textBoxSecondArgument = new System.Windows.Forms.TextBox();
      this.textBoxFirstArgument = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 5;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.Controls.Add(this.labelOperand, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.textBoxSecondArgument, 2, 0);
      this.tableLayoutPanel.Controls.Add(this.textBoxFirstArgument, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.label1, 3, 0);
      this.tableLayoutPanel.Controls.Add(this.textBoxResult, 4, 0);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 1;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(406, 84);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // labelOperand
      // 
      this.labelOperand.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelOperand.Location = new System.Drawing.Point(125, 0);
      this.labelOperand.Name = "labelOperand";
      this.labelOperand.Size = new System.Drawing.Size(14, 84);
      this.labelOperand.TabIndex = 3;
      this.labelOperand.Text = "+";
      this.labelOperand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBoxSecondArgument
      // 
      this.textBoxSecondArgument.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxSecondArgument.Location = new System.Drawing.Point(145, 3);
      this.textBoxSecondArgument.Multiline = true;
      this.textBoxSecondArgument.Name = "textBoxSecondArgument";
      this.textBoxSecondArgument.ReadOnly = true;
      this.textBoxSecondArgument.Size = new System.Drawing.Size(116, 78);
      this.textBoxSecondArgument.TabIndex = 1;
      // 
      // textBoxFirstArgument
      // 
      this.textBoxFirstArgument.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxFirstArgument.Location = new System.Drawing.Point(3, 3);
      this.textBoxFirstArgument.Multiline = true;
      this.textBoxFirstArgument.Name = "textBoxFirstArgument";
      this.textBoxFirstArgument.ReadOnly = true;
      this.textBoxFirstArgument.Size = new System.Drawing.Size(116, 78);
      this.textBoxFirstArgument.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(267, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(14, 84);
      this.label1.TabIndex = 2;
      this.label1.Text = "=";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBoxResult
      // 
      this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxResult.Location = new System.Drawing.Point(287, 3);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ReadOnly = true;
      this.textBoxResult.Size = new System.Drawing.Size(116, 78);
      this.textBoxResult.TabIndex = 4;
      // 
      // FormCalculation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(406, 84);
      this.Controls.Add(this.tableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "FormCalculation";
      this.Text = "Сложение";
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.TextBox textBoxSecondArgument;
    private System.Windows.Forms.TextBox textBoxFirstArgument;
    private System.Windows.Forms.Label labelOperand;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxResult;
  }
}