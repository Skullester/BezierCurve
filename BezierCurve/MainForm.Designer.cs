namespace BezierCurve
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            trackBar1 = new TrackBar();
            labelParameter = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelFirstPoint = new Label();
            labelSecondPoint = new Label();
            labelThirdPoint = new Label();
            textBoxFirstPoint = new TextBox();
            textBoxSecondPoint = new TextBox();
            textBoxThirdPoint = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBoxFourthPoint = new TextBox();
            button2 = new Button();
            labelFifthPoint = new Label();
            textBoxFifthPoint = new TextBox();
            label2 = new Label();
            labelSixPoint = new Label();
            labelSevenPoint = new Label();
            textBoxSixth = new TextBox();
            textBoxSeventh = new TextBox();
            label3 = new Label();
            textBoxEighthPoint = new TextBox();
            labelNinthPoint = new Label();
            label4TenthPoint = new Label();
            textBoxNinthPoint = new TextBox();
            textBoxTenthPoint = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(12, 493);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(885, 45);
            trackBar1.TabIndex = 0;
            // 
            // labelParameter
            // 
            labelParameter.AutoSize = true;
            labelParameter.Font = new Font("Segoe UI", 15F);
            labelParameter.Location = new Point(12, 541);
            labelParameter.Name = "labelParameter";
            labelParameter.Size = new Size(39, 28);
            labelParameter.TabIndex = 1;
            labelParameter.Text = "t: 0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(24, -2);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.LightGray;
            series1.LabelBackColor = Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.Red;
            series1.MarkerColor = Color.Gray;
            series1.MarkerImageTransparentColor = Color.FromArgb(128, 255, 255);
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = Color.Transparent;
            series2.MarkerColor = Color.Transparent;
            series2.MarkerSize = 2;
            series2.Name = "Series3";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = Color.FromArgb(128, 255, 128);
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 6;
            series3.MarkerColor = Color.MediumSeaGreen;
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series4";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = Color.DodgerBlue;
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 5;
            series4.MarkerColor = Color.DarkBlue;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series6";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = Color.FromArgb(255, 128, 255);
            series5.Legend = "Legend1";
            series5.MarkerColor = Color.DarkViolet;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series7";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = Color.FromArgb(255, 255, 128);
            series6.Legend = "Legend1";
            series6.MarkerColor = Color.FromArgb(255, 128, 0);
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series8";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = Color.FromArgb(128, 255, 255);
            series7.Legend = "Legend1";
            series7.MarkerColor = Color.FromArgb(64, 64, 64);
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Series9";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = Color.DarkSlateBlue;
            series8.Legend = "Legend1";
            series8.MarkerColor = Color.Fuchsia;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Series10";
            series8.ShadowColor = Color.Khaki;
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = Color.FromArgb(0, 192, 0);
            series9.Legend = "Legend1";
            series9.MarkerColor = Color.DarkOliveGreen;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Series11";
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = Color.FromArgb(192, 0, 192);
            series10.Legend = "Legend1";
            series10.MarkerColor = Color.MediumSpringGreen;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "Series12";
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Color = Color.Maroon;
            series11.Legend = "Legend1";
            series11.Name = "Series5";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Series.Add(series4);
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Series.Add(series7);
            chart1.Series.Add(series8);
            chart1.Series.Add(series9);
            chart1.Series.Add(series10);
            chart1.Series.Add(series11);
            chart1.Size = new Size(742, 477);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // labelFirstPoint
            // 
            labelFirstPoint.AutoSize = true;
            labelFirstPoint.Font = new Font("Segoe UI", 14F);
            labelFirstPoint.Location = new Point(814, 21);
            labelFirstPoint.Name = "labelFirstPoint";
            labelFirstPoint.Size = new Size(135, 25);
            labelFirstPoint.TabIndex = 3;
            labelFirstPoint.Text = "Первая точка:";
            // 
            // labelSecondPoint
            // 
            labelSecondPoint.AutoSize = true;
            labelSecondPoint.Font = new Font("Segoe UI", 14F);
            labelSecondPoint.Location = new Point(814, 55);
            labelSecondPoint.Name = "labelSecondPoint";
            labelSecondPoint.Size = new Size(131, 25);
            labelSecondPoint.TabIndex = 4;
            labelSecondPoint.Text = "Вторая точка:";
            // 
            // labelThirdPoint
            // 
            labelThirdPoint.AutoSize = true;
            labelThirdPoint.Font = new Font("Segoe UI", 14F);
            labelThirdPoint.Location = new Point(816, 95);
            labelThirdPoint.Name = "labelThirdPoint";
            labelThirdPoint.Size = new Size(129, 25);
            labelThirdPoint.TabIndex = 5;
            labelThirdPoint.Text = "Третья точка:";
            // 
            // textBoxFirstPoint
            // 
            textBoxFirstPoint.Font = new Font("Segoe UI", 15F);
            textBoxFirstPoint.Location = new Point(955, 12);
            textBoxFirstPoint.Name = "textBoxFirstPoint";
            textBoxFirstPoint.PlaceholderText = "0;0";
            textBoxFirstPoint.Size = new Size(100, 34);
            textBoxFirstPoint.TabIndex = 6;
            textBoxFirstPoint.Text = "-2;0";
            // 
            // textBoxSecondPoint
            // 
            textBoxSecondPoint.Font = new Font("Segoe UI", 15F);
            textBoxSecondPoint.Location = new Point(955, 55);
            textBoxSecondPoint.Name = "textBoxSecondPoint";
            textBoxSecondPoint.PlaceholderText = "7;8";
            textBoxSecondPoint.Size = new Size(100, 34);
            textBoxSecondPoint.TabIndex = 7;
            textBoxSecondPoint.Text = "-4;4";
            // 
            // textBoxThirdPoint
            // 
            textBoxThirdPoint.Font = new Font("Segoe UI", 15F);
            textBoxThirdPoint.Location = new Point(955, 95);
            textBoxThirdPoint.Name = "textBoxThirdPoint";
            textBoxThirdPoint.PlaceholderText = "3;4";
            textBoxThirdPoint.Size = new Size(100, 34);
            textBoxThirdPoint.TabIndex = 8;
            textBoxThirdPoint.Text = "5;4";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(826, 192);
            button1.Name = "button1";
            button1.Size = new Size(129, 44);
            button1.TabIndex = 9;
            button1.Text = "Построить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BuildGraph;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(814, 146);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 10;
            label1.Text = "Четвертая точка:";
            // 
            // textBoxFourthPoint
            // 
            textBoxFourthPoint.Font = new Font("Segoe UI", 15F);
            textBoxFourthPoint.Location = new Point(984, 140);
            textBoxFourthPoint.Name = "textBoxFourthPoint";
            textBoxFourthPoint.PlaceholderText = "3;4";
            textBoxFourthPoint.Size = new Size(100, 34);
            textBoxFourthPoint.TabIndex = 11;
            textBoxFourthPoint.Text = "14;0";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(826, 255);
            button2.Name = "button2";
            button2.Size = new Size(182, 53);
            button2.TabIndex = 12;
            button2.Text = "Перезапустить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Restart;
            // 
            // labelFifthPoint
            // 
            labelFifthPoint.AutoSize = true;
            labelFifthPoint.Font = new Font("Segoe UI", 14F);
            labelFifthPoint.Location = new Point(1104, 21);
            labelFifthPoint.Name = "labelFifthPoint";
            labelFifthPoint.Size = new Size(122, 25);
            labelFifthPoint.TabIndex = 13;
            labelFifthPoint.Text = "Пятая точка:";
            // 
            // textBoxFifthPoint
            // 
            textBoxFifthPoint.Font = new Font("Segoe UI", 15F);
            textBoxFifthPoint.Location = new Point(1232, 15);
            textBoxFifthPoint.Name = "textBoxFifthPoint";
            textBoxFifthPoint.PlaceholderText = "3;4";
            textBoxFifthPoint.Size = new Size(100, 34);
            textBoxFifthPoint.TabIndex = 14;
            textBoxFifthPoint.Text = "20;3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(816, 335);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 16;
            label2.Text = "Количество точек:";
            // 
            // labelSixPoint
            // 
            labelSixPoint.AutoSize = true;
            labelSixPoint.Font = new Font("Segoe UI", 14F);
            labelSixPoint.Location = new Point(1103, 61);
            labelSixPoint.Name = "labelSixPoint";
            labelSixPoint.Size = new Size(135, 25);
            labelSixPoint.TabIndex = 17;
            labelSixPoint.Text = "Шестая точка:";
            // 
            // labelSevenPoint
            // 
            labelSevenPoint.AutoSize = true;
            labelSevenPoint.Font = new Font("Segoe UI", 14F);
            labelSevenPoint.Location = new Point(1104, 104);
            labelSevenPoint.Name = "labelSevenPoint";
            labelSevenPoint.Size = new Size(145, 25);
            labelSevenPoint.TabIndex = 18;
            labelSevenPoint.Text = "Седьмая точка:";
            // 
            // textBoxSixth
            // 
            textBoxSixth.Font = new Font("Segoe UI", 15F);
            textBoxSixth.Location = new Point(1244, 58);
            textBoxSixth.Name = "textBoxSixth";
            textBoxSixth.PlaceholderText = "3;4";
            textBoxSixth.Size = new Size(100, 34);
            textBoxSixth.TabIndex = 19;
            textBoxSixth.Text = "6;3";
            // 
            // textBoxSeventh
            // 
            textBoxSeventh.Font = new Font("Segoe UI", 15F);
            textBoxSeventh.Location = new Point(1267, 95);
            textBoxSeventh.Name = "textBoxSeventh";
            textBoxSeventh.PlaceholderText = "3;4";
            textBoxSeventh.Size = new Size(100, 34);
            textBoxSeventh.TabIndex = 20;
            textBoxSeventh.Text = "4;7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(1104, 149);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 21;
            label3.Text = "Восьмая точка:";
            // 
            // textBoxEighthPoint
            // 
            textBoxEighthPoint.Font = new Font("Segoe UI", 15F);
            textBoxEighthPoint.Location = new Point(1255, 143);
            textBoxEighthPoint.Name = "textBoxEighthPoint";
            textBoxEighthPoint.PlaceholderText = "3;4";
            textBoxEighthPoint.Size = new Size(100, 34);
            textBoxEighthPoint.TabIndex = 22;
            textBoxEighthPoint.Text = "6;9";
            // 
            // labelNinthPoint
            // 
            labelNinthPoint.AutoSize = true;
            labelNinthPoint.Font = new Font("Segoe UI", 14F);
            labelNinthPoint.Location = new Point(1105, 192);
            labelNinthPoint.Name = "labelNinthPoint";
            labelNinthPoint.Size = new Size(141, 25);
            labelNinthPoint.TabIndex = 23;
            labelNinthPoint.Text = "Девятая точка:";
            // 
            // label4TenthPoint
            // 
            label4TenthPoint.AutoSize = true;
            label4TenthPoint.Font = new Font("Segoe UI", 14F);
            label4TenthPoint.Location = new Point(1105, 235);
            label4TenthPoint.Name = "label4TenthPoint";
            label4TenthPoint.Size = new Size(140, 25);
            label4TenthPoint.TabIndex = 24;
            label4TenthPoint.Text = "Десятая точка:";
            // 
            // textBoxNinthPoint
            // 
            textBoxNinthPoint.Font = new Font("Segoe UI", 15F);
            textBoxNinthPoint.Location = new Point(1252, 186);
            textBoxNinthPoint.Name = "textBoxNinthPoint";
            textBoxNinthPoint.PlaceholderText = "3;4";
            textBoxNinthPoint.Size = new Size(100, 34);
            textBoxNinthPoint.TabIndex = 25;
            textBoxNinthPoint.Text = "2;9";
            // 
            // textBoxTenthPoint
            // 
            textBoxTenthPoint.Font = new Font("Segoe UI", 15F);
            textBoxTenthPoint.Location = new Point(1252, 229);
            textBoxTenthPoint.Name = "textBoxTenthPoint";
            textBoxTenthPoint.PlaceholderText = "3;4";
            textBoxTenthPoint.Size = new Size(100, 34);
            textBoxTenthPoint.TabIndex = 26;
            textBoxTenthPoint.Text = "12;3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 15F);
            numericUpDown1.Location = new Point(835, 363);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 34);
            numericUpDown1.TabIndex = 27;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 652);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxTenthPoint);
            Controls.Add(textBoxNinthPoint);
            Controls.Add(label4TenthPoint);
            Controls.Add(labelNinthPoint);
            Controls.Add(textBoxEighthPoint);
            Controls.Add(label3);
            Controls.Add(textBoxSeventh);
            Controls.Add(textBoxSixth);
            Controls.Add(labelSevenPoint);
            Controls.Add(labelSixPoint);
            Controls.Add(label2);
            Controls.Add(textBoxFifthPoint);
            Controls.Add(labelFifthPoint);
            Controls.Add(button2);
            Controls.Add(textBoxFourthPoint);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxThirdPoint);
            Controls.Add(textBoxSecondPoint);
            Controls.Add(textBoxFirstPoint);
            Controls.Add(labelThirdPoint);
            Controls.Add(labelSecondPoint);
            Controls.Add(labelFirstPoint);
            Controls.Add(chart1);
            Controls.Add(labelParameter);
            Controls.Add(trackBar1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label labelParameter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label labelFirstPoint;
        private Label labelSecondPoint;
        private Label labelThirdPoint;
        private TextBox textBoxFirstPoint;
        private TextBox textBoxSecondPoint;
        private TextBox textBoxThirdPoint;
        private Button button1;
        private Label label1;
        private TextBox textBoxFourthPoint;
        private Button button2;
        private Label labelFifthPoint;
        private TextBox textBoxFifthPoint;
        private Label label2;
        private Label labelSixPoint;
        private Label labelSevenPoint;
        private TextBox textBoxSixth;
        private TextBox textBoxSeventh;
        private Label label3;
        private TextBox textBoxEighthPoint;
        private Label labelNinthPoint;
        private Label label4TenthPoint;
        private TextBox textBoxNinthPoint;
        private TextBox textBoxTenthPoint;
        private NumericUpDown numericUpDown1;
    }
}
