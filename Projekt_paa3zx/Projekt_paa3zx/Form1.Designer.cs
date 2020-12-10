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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.labelValto1 = new System.Windows.Forms.Label();
            this.tbvalto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbszam = new System.Windows.Forms.TextBox();
            this.eredmeny = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // dateTimePickerkezdo
            // 
            this.dateTimePickerkezdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerkezdo.Location = new System.Drawing.Point(14, 26);
            this.dateTimePickerkezdo.Name = "dateTimePickerkezdo";
            this.dateTimePickerkezdo.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerkezdo.TabIndex = 1;
            this.dateTimePickerkezdo.Value = new System.DateTime(2020, 10, 10, 13, 32, 0, 0);
            this.dateTimePickerkezdo.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dateTimePickerveg
            // 
            this.dateTimePickerveg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerveg.Location = new System.Drawing.Point(14, 76);
            this.dateTimePickerveg.Name = "dateTimePickerveg";
            this.dateTimePickerveg.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerveg.TabIndex = 2;
            this.dateTimePickerveg.Value = new System.DateTime(2020, 12, 1, 13, 32, 0, 0);
            this.dateTimePickerveg.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Exportgomb
            // 
            this.Exportgomb.Location = new System.Drawing.Point(15, 408);
            this.Exportgomb.Name = "Exportgomb";
            this.Exportgomb.Size = new System.Drawing.Size(107, 42);
            this.Exportgomb.TabIndex = 4;
            this.Exportgomb.Text = "Adatok exportálása";
            this.Exportgomb.UseVisualStyleBackColor = true;
            this.Exportgomb.Click += new System.EventHandler(this.Exportgomb_Click);
            // 
            // ArfolyamChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ArfolyamChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ArfolyamChart.Legends.Add(legend1);
            this.ArfolyamChart.Location = new System.Drawing.Point(723, -1);
            this.ArfolyamChart.Name = "ArfolyamChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ArfolyamChart.Series.Add(series1);
            this.ArfolyamChart.Size = new System.Drawing.Size(794, 319);
            this.ArfolyamChart.TabIndex = 5;
            this.ArfolyamChart.Text = "chart1";
            // 
            // labelatlag
            // 
            this.labelatlag.AutoSize = true;
            this.labelatlag.Location = new System.Drawing.Point(1387, 351);
            this.labelatlag.Name = "labelatlag";
            this.labelatlag.Size = new System.Drawing.Size(44, 16);
            this.labelatlag.TabIndex = 6;
            this.labelatlag.Text = "Átlag";
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(1298, 380);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(134, 16);
            this.labelmax.TabIndex = 7;
            this.labelmax.Text = "Legnagyobb érték";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(1271, 408);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(163, 16);
            this.labelmin.TabIndex = 8;
            this.labelmin.Text = "Legalacsonyabb érték";
            // 
            // labelvaltozas
            // 
            this.labelvaltozas.AutoSize = true;
            this.labelvaltozas.Location = new System.Drawing.Point(1307, 520);
            this.labelvaltozas.Name = "labelvaltozas";
            this.labelvaltozas.Size = new System.Drawing.Size(128, 16);
            this.labelvaltozas.TabIndex = 11;
            this.labelvaltozas.Text = "Időszaki változás";
            // 
            // labelutolso
            // 
            this.labelutolso.AutoSize = true;
            this.labelutolso.Location = new System.Drawing.Point(1307, 492);
            this.labelutolso.Name = "labelutolso";
            this.labelutolso.Size = new System.Drawing.Size(127, 16);
            this.labelutolso.TabIndex = 10;
            this.labelutolso.Text = "Legrégebbi érték";
            // 
            // labelelso
            // 
            this.labelelso.AutoSize = true;
            this.labelelso.Location = new System.Drawing.Point(1307, 460);
            this.labelelso.Name = "labelelso";
            this.labelelso.Size = new System.Drawing.Size(126, 16);
            this.labelelso.TabIndex = 9;
            this.labelelso.Text = "Legkorábbi érték";
            // 
            // textBoxtlag
            // 
            this.textBoxtlag.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxtlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxtlag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxtlag.Location = new System.Drawing.Point(1437, 345);
            this.textBoxtlag.Name = "textBoxtlag";
            this.textBoxtlag.ReadOnly = true;
            this.textBoxtlag.Size = new System.Drawing.Size(80, 22);
            this.textBoxtlag.TabIndex = 12;
            // 
            // textBoxmax
            // 
            this.textBoxmax.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxmax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxmax.Location = new System.Drawing.Point(1437, 374);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.ReadOnly = true;
            this.textBoxmax.Size = new System.Drawing.Size(80, 22);
            this.textBoxmax.TabIndex = 13;
            // 
            // textBoxelso
            // 
            this.textBoxelso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxelso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxelso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxelso.Location = new System.Drawing.Point(1437, 454);
            this.textBoxelso.Name = "textBoxelso";
            this.textBoxelso.ReadOnly = true;
            this.textBoxelso.Size = new System.Drawing.Size(80, 22);
            this.textBoxelso.TabIndex = 15;
            // 
            // textBoxmin
            // 
            this.textBoxmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxmin.Location = new System.Drawing.Point(1437, 402);
            this.textBoxmin.Name = "textBoxmin";
            this.textBoxmin.ReadOnly = true;
            this.textBoxmin.Size = new System.Drawing.Size(80, 22);
            this.textBoxmin.TabIndex = 14;
            // 
            // textBoxvaltozas
            // 
            this.textBoxvaltozas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxvaltozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxvaltozas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxvaltozas.Location = new System.Drawing.Point(1437, 514);
            this.textBoxvaltozas.Name = "textBoxvaltozas";
            this.textBoxvaltozas.ReadOnly = true;
            this.textBoxvaltozas.Size = new System.Drawing.Size(80, 22);
            this.textBoxvaltozas.TabIndex = 17;
            // 
            // textBoxutolso
            // 
            this.textBoxutolso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxutolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxutolso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxutolso.Location = new System.Drawing.Point(1437, 486);
            this.textBoxutolso.Name = "textBoxutolso";
            this.textBoxutolso.ReadOnly = true;
            this.textBoxutolso.Size = new System.Drawing.Size(80, 22);
            this.textBoxutolso.TabIndex = 16;
            // 
            // labelszamok
            // 
            this.labelszamok.AutoSize = true;
            this.labelszamok.Location = new System.Drawing.Point(1214, 326);
            this.labelszamok.Name = "labelszamok";
            this.labelszamok.Size = new System.Drawing.Size(303, 16);
            this.labelszamok.TabIndex = 18;
            this.labelszamok.Text = "A kiválasztott időszakra vonatkozó adatok:";
            // 
            // labelValto1
            // 
            this.labelValto1.AutoSize = true;
            this.labelValto1.Location = new System.Drawing.Point(605, 326);
            this.labelValto1.Name = "labelValto1";
            this.labelValto1.Size = new System.Drawing.Size(44, 16);
            this.labelValto1.TabIndex = 19;
            this.labelValto1.Text = "Váltó";
            // 
            // tbvalto
            // 
            this.tbvalto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbvalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbvalto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbvalto.Location = new System.Drawing.Point(666, 374);
            this.tbvalto.Name = "tbvalto";
            this.tbvalto.ReadOnly = true;
            this.tbvalto.Size = new System.Drawing.Size(80, 22);
            this.tbvalto.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(605, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "(A váltó a jelenleg kijelölt időszak utolsó időpontját veszi alapul)";
            // 
            // tbszam
            // 
            this.tbszam.Location = new System.Drawing.Point(666, 408);
            this.tbszam.Name = "tbszam";
            this.tbszam.Size = new System.Drawing.Size(80, 22);
            this.tbszam.TabIndex = 22;
            this.tbszam.Text = "0";
            this.tbszam.TextChanged += new System.EventHandler(this.Tbszam_TextChanged);
            // 
            // eredmeny
            // 
            this.eredmeny.Location = new System.Drawing.Point(666, 454);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(80, 22);
            this.eredmeny.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1530, 589);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.tbszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbvalto);
            this.Controls.Add(this.labelValto1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Árfolyamelemző";
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
        private System.Windows.Forms.Label labelValto1;
        private System.Windows.Forms.TextBox tbvalto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbszam;
        private System.Windows.Forms.TextBox eredmeny;
    }
}

