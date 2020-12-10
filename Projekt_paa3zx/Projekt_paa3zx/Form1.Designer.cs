namespace Projekt_paa3zx
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerkezdo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerveg = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exportgomb = new System.Windows.Forms.Button();
            this.ArfolyamChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelatlag = new System.Windows.Forms.Label();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.labelvaltozas = new System.Windows.Forms.Label();
            this.labelutolso = new System.Windows.Forms.Label();
            this.labelelso = new System.Windows.Forms.Label();
            this.textBoxtlag = new System.Windows.Forms.TextBox();
            this.textBoxmax = new System.Windows.Forms.TextBox();
            this.textBoxelso = new System.Windows.Forms.TextBox();
            this.textBoxmin = new System.Windows.Forms.TextBox();
            this.textBoxvaltozas = new System.Windows.Forms.TextBox();
            this.textBoxutolso = new System.Windows.Forms.TextBox();
            this.labelszamok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(165, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // dateTimePickerkezdo
            // 
            this.dateTimePickerkezdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerkezdo.Location = new System.Drawing.Point(12, 26);
            this.dateTimePickerkezdo.Name = "dateTimePickerkezdo";
            this.dateTimePickerkezdo.Size = new System.Drawing.Size(147, 22);
            this.dateTimePickerkezdo.TabIndex = 1;
            this.dateTimePickerkezdo.Value = new System.DateTime(2020, 10, 10, 13, 32, 0, 0);
            this.dateTimePickerkezdo.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dateTimePickerveg
            // 
            this.dateTimePickerveg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerveg.Location = new System.Drawing.Point(12, 76);
            this.dateTimePickerveg.Name = "dateTimePickerveg";
            this.dateTimePickerveg.Size = new System.Drawing.Size(147, 22);
            this.dateTimePickerveg.TabIndex = 2;
            this.dateTimePickerveg.Value = new System.DateTime(2020, 12, 1, 13, 32, 0, 0);
            this.dateTimePickerveg.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Exportgomb
            // 
            this.Exportgomb.Location = new System.Drawing.Point(13, 408);
            this.Exportgomb.Name = "Exportgomb";
            this.Exportgomb.Size = new System.Drawing.Size(95, 42);
            this.Exportgomb.TabIndex = 4;
            this.Exportgomb.Text = "Adatok exportálása";
            this.Exportgomb.UseVisualStyleBackColor = true;
            this.Exportgomb.Click += new System.EventHandler(this.Exportgomb_Click);
            // 
            // ArfolyamChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ArfolyamChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ArfolyamChart.Legends.Add(legend3);
            this.ArfolyamChart.Location = new System.Drawing.Point(643, -1);
            this.ArfolyamChart.Name = "ArfolyamChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ArfolyamChart.Series.Add(series3);
            this.ArfolyamChart.Size = new System.Drawing.Size(843, 319);
            this.ArfolyamChart.TabIndex = 5;
            this.ArfolyamChart.Text = "chart1";
            // 
            // labelatlag
            // 
            this.labelatlag.AutoSize = true;
            this.labelatlag.Location = new System.Drawing.Point(938, 350);
            this.labelatlag.Name = "labelatlag";
            this.labelatlag.Size = new System.Drawing.Size(39, 16);
            this.labelatlag.TabIndex = 6;
            this.labelatlag.Text = "Átlag";
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(938, 382);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(118, 16);
            this.labelmax.TabIndex = 7;
            this.labelmax.Text = "Legnagyobb érték";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(938, 421);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(143, 16);
            this.labelmin.TabIndex = 8;
            this.labelmin.Text = "Legalacsonyabb érték";
            // 
            // labelvaltozas
            // 
            this.labelvaltozas.AutoSize = true;
            this.labelvaltozas.Location = new System.Drawing.Point(938, 530);
            this.labelvaltozas.Name = "labelvaltozas";
            this.labelvaltozas.Size = new System.Drawing.Size(111, 16);
            this.labelvaltozas.TabIndex = 11;
            this.labelvaltozas.Text = "Időszaki változás";
            // 
            // labelutolso
            // 
            this.labelutolso.AutoSize = true;
            this.labelutolso.Location = new System.Drawing.Point(938, 491);
            this.labelutolso.Name = "labelutolso";
            this.labelutolso.Size = new System.Drawing.Size(111, 16);
            this.labelutolso.TabIndex = 10;
            this.labelutolso.Text = "Legrégebbi érték";
            // 
            // labelelso
            // 
            this.labelelso.AutoSize = true;
            this.labelelso.Location = new System.Drawing.Point(938, 459);
            this.labelelso.Name = "labelelso";
            this.labelelso.Size = new System.Drawing.Size(110, 16);
            this.labelelso.TabIndex = 9;
            this.labelelso.Text = "Legkorábbi érték";
            // 
            // textBoxtlag
            // 
            this.textBoxtlag.Location = new System.Drawing.Point(1085, 350);
            this.textBoxtlag.Name = "textBoxtlag";
            this.textBoxtlag.Size = new System.Drawing.Size(72, 22);
            this.textBoxtlag.TabIndex = 12;
            // 
            // textBoxmax
            // 
            this.textBoxmax.Location = new System.Drawing.Point(1085, 382);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.Size = new System.Drawing.Size(72, 22);
            this.textBoxmax.TabIndex = 13;
            // 
            // textBoxelso
            // 
            this.textBoxelso.Location = new System.Drawing.Point(1085, 459);
            this.textBoxelso.Name = "textBoxelso";
            this.textBoxelso.Size = new System.Drawing.Size(72, 22);
            this.textBoxelso.TabIndex = 15;
            // 
            // textBoxmin
            // 
            this.textBoxmin.Location = new System.Drawing.Point(1085, 421);
            this.textBoxmin.Name = "textBoxmin";
            this.textBoxmin.Size = new System.Drawing.Size(72, 22);
            this.textBoxmin.TabIndex = 14;
            // 
            // textBoxvaltozas
            // 
            this.textBoxvaltozas.Location = new System.Drawing.Point(1085, 530);
            this.textBoxvaltozas.Name = "textBoxvaltozas";
            this.textBoxvaltozas.Size = new System.Drawing.Size(72, 22);
            this.textBoxvaltozas.TabIndex = 17;
            // 
            // textBoxutolso
            // 
            this.textBoxutolso.Location = new System.Drawing.Point(1085, 491);
            this.textBoxutolso.Name = "textBoxutolso";
            this.textBoxutolso.Size = new System.Drawing.Size(72, 22);
            this.textBoxutolso.TabIndex = 16;
            // 
            // labelszamok
            // 
            this.labelszamok.AutoSize = true;
            this.labelszamok.Location = new System.Drawing.Point(938, 321);
            this.labelszamok.Name = "labelszamok";
            this.labelszamok.Size = new System.Drawing.Size(261, 16);
            this.labelszamok.TabIndex = 18;
            this.labelszamok.Text = "A kiválasztott időszakra vonatkozó adatok:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 589);
            this.Controls.Add(this.labelszamok);
            this.Controls.Add(this.textBoxvaltozas);
            this.Controls.Add(this.textBoxutolso);
            this.Controls.Add(this.textBoxelso);
            this.Controls.Add(this.textBoxmin);
            this.Controls.Add(this.textBoxmax);
            this.Controls.Add(this.textBoxtlag);
            this.Controls.Add(this.labelvaltozas);
            this.Controls.Add(this.labelutolso);
            this.Controls.Add(this.labelelso);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.labelatlag);
            this.Controls.Add(this.ArfolyamChart);
            this.Controls.Add(this.Exportgomb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerveg);
            this.Controls.Add(this.dateTimePickerkezdo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerkezdo;
        private System.Windows.Forms.DateTimePicker dateTimePickerveg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Exportgomb;
        private System.Windows.Forms.DataVisualization.Charting.Chart ArfolyamChart;
        private System.Windows.Forms.Label labelatlag;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label labelvaltozas;
        private System.Windows.Forms.Label labelutolso;
        private System.Windows.Forms.Label labelelso;
        private System.Windows.Forms.TextBox textBoxtlag;
        private System.Windows.Forms.TextBox textBoxmax;
        private System.Windows.Forms.TextBox textBoxelso;
        private System.Windows.Forms.TextBox textBoxmin;
        private System.Windows.Forms.TextBox textBoxvaltozas;
        private System.Windows.Forms.TextBox textBoxutolso;
        private System.Windows.Forms.Label labelszamok;
    }
}

