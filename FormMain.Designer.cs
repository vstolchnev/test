namespace EventsExample2019_643
{
  partial class FormMain
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.numericUpDownFirstArgument = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownSecondArgument = new System.Windows.Forms.NumericUpDown();
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonCreatAddForm = new System.Windows.Forms.Button();
      this.buttonCreatSubstractForm = new System.Windows.Forms.Button();
      this.tableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstArgument)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondArgument)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 3;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
      this.tableLayoutPanel.Controls.Add(this.numericUpDownFirstArgument, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.numericUpDownSecondArgument, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.buttonCalculate, 2, 0);
      this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 2;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(480, 175);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // numericUpDownFirstArgument
      // 
      this.numericUpDownFirstArgument.Location = new System.Drawing.Point(3, 3);
      this.numericUpDownFirstArgument.Name = "numericUpDownFirstArgument";
      this.numericUpDownFirstArgument.Size = new System.Drawing.Size(120, 20);
      this.numericUpDownFirstArgument.TabIndex = 0;
      // 
      // numericUpDownSecondArgument
      // 
      this.numericUpDownSecondArgument.Location = new System.Drawing.Point(187, 3);
      this.numericUpDownSecondArgument.Name = "numericUpDownSecondArgument";
      this.numericUpDownSecondArgument.Size = new System.Drawing.Size(120, 20);
      this.numericUpDownSecondArgument.TabIndex = 1;
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonCalculate.Location = new System.Drawing.Point(371, 3);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(106, 23);
      this.buttonCalculate.TabIndex = 2;
      this.buttonCalculate.Text = "Вычислить";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 3);
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.buttonCreatSubstractForm, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonCreatAddForm, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 140);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // buttonCreatAddForm
      // 
      this.buttonCreatAddForm.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonCreatAddForm.Location = new System.Drawing.Point(3, 3);
      this.buttonCreatAddForm.Name = "buttonCreatAddForm";
      this.buttonCreatAddForm.Size = new System.Drawing.Size(112, 134);
      this.buttonCreatAddForm.TabIndex = 0;
      this.buttonCreatAddForm.Text = "+";
      this.buttonCreatAddForm.UseVisualStyleBackColor = true;
      this.buttonCreatAddForm.Click += new System.EventHandler(this.buttonCreatAddForm_Click);
      // 
      // buttonCreatSubstractForm
      // 
      this.buttonCreatSubstractForm.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonCreatSubstractForm.Location = new System.Drawing.Point(121, 3);
      this.buttonCreatSubstractForm.Name = "buttonCreatSubstractForm";
      this.buttonCreatSubstractForm.Size = new System.Drawing.Size(112, 134);
      this.buttonCreatSubstractForm.TabIndex = 1;
      this.buttonCreatSubstractForm.Text = "-";
      this.buttonCreatSubstractForm.UseVisualStyleBackColor = true;
      this.buttonCreatSubstractForm.Click += new System.EventHandler(this.buttonCreatSubstractForm_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 175);
      this.Controls.Add(this.tableLayoutPanel);
      this.Name = "FormMain";
      this.Text = "Демонстрация работы с событиями";
      this.tableLayoutPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstArgument)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondArgument)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.NumericUpDown numericUpDownFirstArgument;
    private System.Windows.Forms.NumericUpDown numericUpDownSecondArgument;
    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button buttonCreatAddForm;
    private System.Windows.Forms.Button buttonCreatSubstractForm;
  }
}

