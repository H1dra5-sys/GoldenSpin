namespace theGoldenSectionMethod {
  partial class GoldenSection {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.functionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.aBox = new System.Windows.Forms.TextBox();
      this.bBox = new System.Windows.Forms.TextBox();
      this.eArgBox = new System.Windows.Forms.TextBox();
      this.stepBox = new System.Windows.Forms.TextBox();
      this.functionBox = new System.Windows.Forms.TextBox();
      this.Answer = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // functionGraph
      // 
      chartArea2.Name = "ChartArea1";
      this.functionGraph.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.functionGraph.Legends.Add(legend2);
      this.functionGraph.Location = new System.Drawing.Point(570, 59);
      this.functionGraph.Name = "functionGraph";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.functionGraph.Series.Add(series2);
      this.functionGraph.Size = new System.Drawing.Size(350, 300);
      this.functionGraph.TabIndex = 1;
      this.functionGraph.Text = "functionGraph";
      // 
      // aBox
      // 
      this.aBox.Location = new System.Drawing.Point(184, 73);
      this.aBox.Name = "aBox";
      this.aBox.Size = new System.Drawing.Size(100, 20);
      this.aBox.TabIndex = 2;
      // 
      // bBox
      // 
      this.bBox.Location = new System.Drawing.Point(350, 73);
      this.bBox.Name = "bBox";
      this.bBox.Size = new System.Drawing.Size(100, 20);
      this.bBox.TabIndex = 3;
      // 
      // eArgBox
      // 
      this.eArgBox.Location = new System.Drawing.Point(217, 130);
      this.eArgBox.Name = "eArgBox";
      this.eArgBox.Size = new System.Drawing.Size(100, 20);
      this.eArgBox.TabIndex = 4;
      // 
      // stepBox
      // 
      this.stepBox.Location = new System.Drawing.Point(283, 194);
      this.stepBox.Name = "stepBox";
      this.stepBox.Size = new System.Drawing.Size(100, 20);
      this.stepBox.TabIndex = 5;
      // 
      // functionBox
      // 
      this.functionBox.Location = new System.Drawing.Point(111, 259);
      this.functionBox.Name = "functionBox";
      this.functionBox.Size = new System.Drawing.Size(100, 20);
      this.functionBox.TabIndex = 6;
      // 
      // Answer
      // 
      this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Answer.Location = new System.Drawing.Point(701, 382);
      this.Answer.Name = "Answer";
      this.Answer.Size = new System.Drawing.Size(100, 35);
      this.Answer.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(595, 382);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 35);
      this.label1.TabIndex = 8;
      this.label1.Text = "Ответ:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(8, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(170, 17);
      this.label2.TabIndex = 9;
      this.label2.Text = "Диапазон значений x от";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(308, 73);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(24, 17);
      this.label3.TabIndex = 10;
      this.label3.Text = "до";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(8, 131);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(203, 17);
      this.label4.TabIndex = 11;
      this.label4.Text = "Кол-во знаков после запятой";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 259);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(91, 17);
      this.label5.TabIndex = 12;
      this.label5.Text = "Функция f(x)";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(8, 195);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(269, 17);
      this.label6.TabIndex = 13;
      this.label6.Text = "Расстояние между точками на графике";
      // 
      // GoldenSection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1097, 450);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Answer);
      this.Controls.Add(this.functionBox);
      this.Controls.Add(this.stepBox);
      this.Controls.Add(this.eArgBox);
      this.Controls.Add(this.bBox);
      this.Controls.Add(this.aBox);
      this.Controls.Add(this.functionGraph);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "GoldenSection";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart functionGraph;
    private System.Windows.Forms.TextBox aBox;
    private System.Windows.Forms.TextBox bBox;
    private System.Windows.Forms.TextBox eArgBox;
    private System.Windows.Forms.TextBox stepBox;
    private System.Windows.Forms.TextBox functionBox;
    private System.Windows.Forms.Label Answer;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}

