
namespace Simulation_Lab_1
{
    partial class Simulation1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberInterval = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numberStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numberWeight = new System.Windows.Forms.NumericUpDown();
            this.numberSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.numberHeight = new System.Windows.Forms.NumericUpDown();
            this.numberAngle = new System.Windows.Forms.NumericUpDown();
            this.numberSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Controls.Add(this.numberInterval);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numberStep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numberWeight);
            this.panel1.Controls.Add(this.numberSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.numberHeight);
            this.panel1.Controls.Add(this.numberAngle);
            this.panel1.Controls.Add(this.numberSpeed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 838);
            this.panel1.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNumber,
            this.timeStep,
            this.distance,
            this.maxHeight,
            this.speedEnd,
            this.clmnHeight,
            this.clmnAngle,
            this.clmnSpeed,
            this.clmnSize,
            this.clmnWeight});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(15, 83);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1358, 165);
            this.dataGrid.TabIndex = 12;
            // 
            // lineNumber
            // 
            this.lineNumber.HeaderText = "Line Name";
            this.lineNumber.MinimumWidth = 6;
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.ReadOnly = true;
            this.lineNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // timeStep
            // 
            this.timeStep.HeaderText = "Time Step";
            this.timeStep.MinimumWidth = 6;
            this.timeStep.Name = "timeStep";
            this.timeStep.ReadOnly = true;
            this.timeStep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // distance
            // 
            this.distance.HeaderText = "Distance";
            this.distance.MaxInputLength = 5;
            this.distance.MinimumWidth = 6;
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            this.distance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // maxHeight
            // 
            this.maxHeight.HeaderText = "Max Height";
            this.maxHeight.MaxInputLength = 5;
            this.maxHeight.MinimumWidth = 6;
            this.maxHeight.Name = "maxHeight";
            this.maxHeight.ReadOnly = true;
            this.maxHeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // speedEnd
            // 
            this.speedEnd.HeaderText = "End Speed";
            this.speedEnd.MaxInputLength = 5;
            this.speedEnd.MinimumWidth = 6;
            this.speedEnd.Name = "speedEnd";
            this.speedEnd.ReadOnly = true;
            this.speedEnd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnHeight
            // 
            this.clmnHeight.HeaderText = "Height";
            this.clmnHeight.MinimumWidth = 6;
            this.clmnHeight.Name = "clmnHeight";
            this.clmnHeight.ReadOnly = true;
            this.clmnHeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnAngle
            // 
            this.clmnAngle.HeaderText = "Angle";
            this.clmnAngle.MinimumWidth = 6;
            this.clmnAngle.Name = "clmnAngle";
            this.clmnAngle.ReadOnly = true;
            this.clmnAngle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnSpeed
            // 
            this.clmnSpeed.HeaderText = "Speed";
            this.clmnSpeed.MinimumWidth = 6;
            this.clmnSpeed.Name = "clmnSpeed";
            this.clmnSpeed.ReadOnly = true;
            this.clmnSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnSize
            // 
            this.clmnSize.HeaderText = "Size";
            this.clmnSize.MinimumWidth = 6;
            this.clmnSize.Name = "clmnSize";
            this.clmnSize.ReadOnly = true;
            this.clmnSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnWeight
            // 
            this.clmnWeight.HeaderText = "Weight";
            this.clmnWeight.MinimumWidth = 6;
            this.clmnWeight.Name = "clmnWeight";
            this.clmnWeight.ReadOnly = true;
            this.clmnWeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numberInterval
            // 
            this.numberInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberInterval.Location = new System.Drawing.Point(1163, 37);
            this.numberInterval.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberInterval.Name = "numberInterval";
            this.numberInterval.Size = new System.Drawing.Size(54, 22);
            this.numberInterval.TabIndex = 11;
            this.numberInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1063, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Timer Interval";
            // 
            // numberStep
            // 
            this.numberStep.DecimalPlaces = 6;
            this.numberStep.Location = new System.Drawing.Point(921, 37);
            this.numberStep.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.numberStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numberStep.Name = "numberStep";
            this.numberStep.Size = new System.Drawing.Size(79, 22);
            this.numberStep.TabIndex = 9;
            this.numberStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(878, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Step";
            // 
            // numberWeight
            // 
            this.numberWeight.DecimalPlaces = 2;
            this.numberWeight.Location = new System.Drawing.Point(744, 37);
            this.numberWeight.Name = "numberWeight";
            this.numberWeight.Size = new System.Drawing.Size(66, 22);
            this.numberWeight.TabIndex = 7;
            this.numberWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberSize
            // 
            this.numberSize.DecimalPlaces = 2;
            this.numberSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numberSize.Location = new System.Drawing.Point(571, 37);
            this.numberSize.Name = "numberSize";
            this.numberSize.Size = new System.Drawing.Size(66, 22);
            this.numberSize.TabIndex = 6;
            this.numberSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Size";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(1265, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numberHeight
            // 
            this.numberHeight.Location = new System.Drawing.Point(67, 37);
            this.numberHeight.Name = "numberHeight";
            this.numberHeight.Size = new System.Drawing.Size(55, 22);
            this.numberHeight.TabIndex = 1;
            // 
            // numberAngle
            // 
            this.numberAngle.Location = new System.Drawing.Point(228, 37);
            this.numberAngle.Name = "numberAngle";
            this.numberAngle.Size = new System.Drawing.Size(55, 22);
            this.numberAngle.TabIndex = 2;
            this.numberAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // numberSpeed
            // 
            this.numberSpeed.Location = new System.Drawing.Point(406, 37);
            this.numberSpeed.Name = "numberSpeed";
            this.numberSpeed.Size = new System.Drawing.Size(55, 22);
            this.numberSpeed.TabIndex = 3;
            this.numberSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 254);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Yellow;
            series1.Legend = "Legend";
            series1.MarkerBorderColor = System.Drawing.SystemColors.Window;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "ExpLine1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend";
            series2.MarkerColor = System.Drawing.Color.Lime;
            series2.Name = "ExpLine2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend";
            series3.MarkerColor = System.Drawing.Color.Yellow;
            series3.Name = "ExpLine3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend";
            series4.MarkerColor = System.Drawing.Color.Blue;
            series4.Name = "ExpLine4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend";
            series5.MarkerColor = System.Drawing.Color.Fuchsia;
            series5.Name = "ExpLine5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1392, 581);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Simulation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 838);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Simulation1";
            this.ShowIcon = false;
            this.Text = "Simulation 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numberHeight;
        private System.Windows.Forms.NumericUpDown numberAngle;
        private System.Windows.Forms.NumericUpDown numberSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numberWeight;
        private System.Windows.Forms.NumericUpDown numberSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWeight;
    }
}

