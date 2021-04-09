namespace CurRate
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAwareness = new System.Windows.Forms.Label();
            this.labelFireExtinguishingRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentFiresAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.stopGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.fightersNumber = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelFireFreq = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentFiresAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFireFreq);
            this.panel1.Controls.Add(this.labelAwareness);
            this.panel1.Controls.Add(this.labelFireExtinguishingRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.currentFiresAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stopGameBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.startGameBtn);
            this.panel1.Controls.Add(this.fightersNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelAwareness
            // 
            this.labelAwareness.AutoSize = true;
            this.labelAwareness.Location = new System.Drawing.Point(443, 64);
            this.labelAwareness.Name = "labelAwareness";
            this.labelAwareness.Size = new System.Drawing.Size(13, 13);
            this.labelAwareness.TabIndex = 22;
            this.labelAwareness.Text = "_";
            // 
            // labelFireExtinguishingRate
            // 
            this.labelFireExtinguishingRate.AutoSize = true;
            this.labelFireExtinguishingRate.Location = new System.Drawing.Point(356, 51);
            this.labelFireExtinguishingRate.Name = "labelFireExtinguishingRate";
            this.labelFireExtinguishingRate.Size = new System.Drawing.Size(13, 13);
            this.labelFireExtinguishingRate.TabIndex = 21;
            this.labelFireExtinguishingRate.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Осведомлённость населения о правилах ПБ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Скорость тушения пожаров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Количество текущих пожаров:";
            // 
            // currentFiresAmount
            // 
            this.currentFiresAmount.DecimalPlaces = 2;
            this.currentFiresAmount.Location = new System.Drawing.Point(367, 21);
            this.currentFiresAmount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.currentFiresAmount.Name = "currentFiresAmount";
            this.currentFiresAmount.Size = new System.Drawing.Size(59, 20);
            this.currentFiresAmount.TabIndex = 17;
            this.currentFiresAmount.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Частота пожаров:";
            // 
            // stopGameBtn
            // 
            this.stopGameBtn.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopGameBtn.Location = new System.Drawing.Point(477, 6);
            this.stopGameBtn.Name = "stopGameBtn";
            this.stopGameBtn.Size = new System.Drawing.Size(134, 88);
            this.stopGameBtn.TabIndex = 14;
            this.stopGameBtn.Text = "STOP";
            this.stopGameBtn.UseVisualStyleBackColor = true;
            this.stopGameBtn.Click += new System.EventHandler(this.stopGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Штат пожарных:";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameBtn.Location = new System.Drawing.Point(617, 6);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(134, 88);
            this.startGameBtn.TabIndex = 6;
            this.startGameBtn.Text = "START";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // fightersNumber
            // 
            this.fightersNumber.DecimalPlaces = 2;
            this.fightersNumber.Location = new System.Drawing.Point(122, 19);
            this.fightersNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fightersNumber.Name = "fightersNumber";
            this.fightersNumber.Size = new System.Drawing.Size(59, 20);
            this.fightersNumber.TabIndex = 1;
            this.fightersNumber.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 50D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "СУММАРНАЯ ПЛОЩАДЬ ТЕКУЩИХ ПОЖАРОВ (м^2)";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelFireFreq
            // 
            this.labelFireFreq.AutoSize = true;
            this.labelFireFreq.Location = new System.Drawing.Point(119, 51);
            this.labelFireFreq.Name = "labelFireFreq";
            this.labelFireFreq.Size = new System.Drawing.Size(13, 13);
            this.labelFireFreq.TabIndex = 23;
            this.labelFireFreq.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentFiresAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown fightersNumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown currentFiresAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopGameBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAwareness;
        private System.Windows.Forms.Label labelFireExtinguishingRate;
        private System.Windows.Forms.Label labelFireFreq;
    }
}

