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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMagas = new System.Windows.Forms.Label();
            this.labelAlacsony = new System.Windows.Forms.Label();
            this.labelKiug = new System.Windows.Forms.Label();
            this.labelKiugro = new System.Windows.Forms.Label();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.labelIdo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 885);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // dateTimePickerkezdo
            // 
            this.dateTimePickerkezdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerkezdo.Location = new System.Drawing.Point(9, 96);
            this.dateTimePickerkezdo.Name = "dateTimePickerkezdo";
            this.dateTimePickerkezdo.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerkezdo.TabIndex = 1;
            this.dateTimePickerkezdo.Value = new System.DateTime(2020, 1, 10, 13, 32, 0, 0);
            this.dateTimePickerkezdo.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dateTimePickerveg
            // 
            this.dateTimePickerveg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerveg.Location = new System.Drawing.Point(9, 189);
            this.dateTimePickerveg.Name = "dateTimePickerveg";
            this.dateTimePickerveg.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerveg.TabIndex = 2;
            this.dateTimePickerveg.Value = new System.DateTime(2020, 12, 1, 13, 32, 0, 0);
            this.dateTimePickerveg.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Exportgomb
            // 
            this.Exportgomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exportgomb.Location = new System.Drawing.Point(15, 815);
            this.Exportgomb.Name = "Exportgomb";
            this.Exportgomb.Size = new System.Drawing.Size(107, 42);
            this.Exportgomb.TabIndex = 4;
            this.Exportgomb.Text = "Adatok exportálása";
            this.Exportgomb.UseVisualStyleBackColor = true;
            this.Exportgomb.Click += new System.EventHandler(this.Exportgomb_Click);
            // 
            // ArfolyamChart
            // 
            this.ArfolyamChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArfolyamChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.Name = "ChartArea1";
            this.ArfolyamChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ArfolyamChart.Legends.Add(legend1);
            this.ArfolyamChart.Location = new System.Drawing.Point(570, -1);
            this.ArfolyamChart.Name = "ArfolyamChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ArfolyamChart.Series.Add(series1);
            this.ArfolyamChart.Size = new System.Drawing.Size(1222, 319);
            this.ArfolyamChart.TabIndex = 5;
            this.ArfolyamChart.Text = "chart1";
            // 
            // labelatlag
            // 
            this.labelatlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelatlag.AutoSize = true;
            this.labelatlag.Location = new System.Drawing.Point(1649, 646);
            this.labelatlag.Name = "labelatlag";
            this.labelatlag.Size = new System.Drawing.Size(44, 16);
            this.labelatlag.TabIndex = 6;
            this.labelatlag.Text = "Átlag";
            // 
            // labelmax
            // 
            this.labelmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(1560, 675);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(134, 16);
            this.labelmax.TabIndex = 7;
            this.labelmax.Text = "Legnagyobb érték";
            // 
            // labelmin
            // 
            this.labelmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(1533, 703);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(163, 16);
            this.labelmin.TabIndex = 8;
            this.labelmin.Text = "Legalacsonyabb érték";
            // 
            // labelvaltozas
            // 
            this.labelvaltozas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelvaltozas.AutoSize = true;
            this.labelvaltozas.Location = new System.Drawing.Point(1569, 815);
            this.labelvaltozas.Name = "labelvaltozas";
            this.labelvaltozas.Size = new System.Drawing.Size(128, 16);
            this.labelvaltozas.TabIndex = 11;
            this.labelvaltozas.Text = "Időszaki változás";
            // 
            // labelutolso
            // 
            this.labelutolso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelutolso.AutoSize = true;
            this.labelutolso.Location = new System.Drawing.Point(1569, 787);
            this.labelutolso.Name = "labelutolso";
            this.labelutolso.Size = new System.Drawing.Size(127, 16);
            this.labelutolso.TabIndex = 10;
            this.labelutolso.Text = "Legrégebbi érték";
            // 
            // labelelso
            // 
            this.labelelso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelelso.AutoSize = true;
            this.labelelso.Location = new System.Drawing.Point(1569, 755);
            this.labelelso.Name = "labelelso";
            this.labelelso.Size = new System.Drawing.Size(126, 16);
            this.labelelso.TabIndex = 9;
            this.labelelso.Text = "Legkorábbi érték";
            // 
            // textBoxtlag
            // 
            this.textBoxtlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtlag.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxtlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxtlag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxtlag.Location = new System.Drawing.Point(1699, 640);
            this.textBoxtlag.Name = "textBoxtlag";
            this.textBoxtlag.ReadOnly = true;
            this.textBoxtlag.Size = new System.Drawing.Size(80, 22);
            this.textBoxtlag.TabIndex = 12;
            // 
            // textBoxmax
            // 
            this.textBoxmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxmax.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxmax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxmax.Location = new System.Drawing.Point(1699, 669);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.ReadOnly = true;
            this.textBoxmax.Size = new System.Drawing.Size(80, 22);
            this.textBoxmax.TabIndex = 13;
            // 
            // textBoxelso
            // 
            this.textBoxelso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxelso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxelso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxelso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxelso.Location = new System.Drawing.Point(1699, 749);
            this.textBoxelso.Name = "textBoxelso";
            this.textBoxelso.ReadOnly = true;
            this.textBoxelso.Size = new System.Drawing.Size(80, 22);
            this.textBoxelso.TabIndex = 15;
            // 
            // textBoxmin
            // 
            this.textBoxmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxmin.Location = new System.Drawing.Point(1699, 697);
            this.textBoxmin.Name = "textBoxmin";
            this.textBoxmin.ReadOnly = true;
            this.textBoxmin.Size = new System.Drawing.Size(80, 22);
            this.textBoxmin.TabIndex = 14;
            // 
            // textBoxvaltozas
            // 
            this.textBoxvaltozas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxvaltozas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxvaltozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxvaltozas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxvaltozas.Location = new System.Drawing.Point(1699, 809);
            this.textBoxvaltozas.Name = "textBoxvaltozas";
            this.textBoxvaltozas.ReadOnly = true;
            this.textBoxvaltozas.Size = new System.Drawing.Size(80, 22);
            this.textBoxvaltozas.TabIndex = 17;
            // 
            // textBoxutolso
            // 
            this.textBoxutolso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxutolso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxutolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxutolso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxutolso.Location = new System.Drawing.Point(1699, 781);
            this.textBoxutolso.Name = "textBoxutolso";
            this.textBoxutolso.ReadOnly = true;
            this.textBoxutolso.Size = new System.Drawing.Size(80, 22);
            this.textBoxutolso.TabIndex = 16;
            // 
            // labelszamok
            // 
            this.labelszamok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelszamok.AutoSize = true;
            this.labelszamok.Location = new System.Drawing.Point(1489, 616);
            this.labelszamok.Name = "labelszamok";
            this.labelszamok.Size = new System.Drawing.Size(303, 16);
            this.labelszamok.TabIndex = 18;
            this.labelszamok.Text = "A kiválasztott időszakra vonatkozó adatok:";
            // 
            // labelValto1
            // 
            this.labelValto1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValto1.AutoSize = true;
            this.labelValto1.Location = new System.Drawing.Point(1113, 621);
            this.labelValto1.Name = "labelValto1";
            this.labelValto1.Size = new System.Drawing.Size(44, 16);
            this.labelValto1.TabIndex = 19;
            this.labelValto1.Text = "Váltó";
            // 
            // tbvalto
            // 
            this.tbvalto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbvalto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbvalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbvalto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbvalto.Location = new System.Drawing.Point(1174, 669);
            this.tbvalto.Name = "tbvalto";
            this.tbvalto.ReadOnly = true;
            this.tbvalto.Size = new System.Drawing.Size(80, 22);
            this.tbvalto.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1113, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "(A váltó a jelenleg kijelölt időszak utolsó időpontját veszi alapul)";
            // 
            // tbszam
            // 
            this.tbszam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbszam.Location = new System.Drawing.Point(1174, 703);
            this.tbszam.Name = "tbszam";
            this.tbszam.Size = new System.Drawing.Size(80, 22);
            this.tbszam.TabIndex = 22;
            this.tbszam.Text = "0";
            this.tbszam.TextChanged += new System.EventHandler(this.Tbszam_TextChanged);
            // 
            // eredmeny
            // 
            this.eredmeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eredmeny.Location = new System.Drawing.Point(1174, 749);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.ReadOnly = true;
            this.eredmeny.Size = new System.Drawing.Size(80, 22);
            this.eredmeny.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.Timer6_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(531, 373);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(283, 511);
            this.dataGridView2.TabIndex = 24;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(820, 373);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(287, 511);
            this.dataGridView3.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(820, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kezdő dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Záró dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pénznem";
            // 
            // labelMagas
            // 
            this.labelMagas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMagas.AutoSize = true;
            this.labelMagas.Location = new System.Drawing.Point(570, 349);
            this.labelMagas.Name = "labelMagas";
            this.labelMagas.Size = new System.Drawing.Size(55, 16);
            this.labelMagas.TabIndex = 31;
            this.labelMagas.Text = "Magas";
            // 
            // labelAlacsony
            // 
            this.labelAlacsony.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlacsony.AutoSize = true;
            this.labelAlacsony.Location = new System.Drawing.Point(817, 349);
            this.labelAlacsony.Name = "labelAlacsony";
            this.labelAlacsony.Size = new System.Drawing.Size(72, 16);
            this.labelAlacsony.TabIndex = 32;
            this.labelAlacsony.Text = "Alacsony";
            // 
            // labelKiug
            // 
            this.labelKiug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKiug.AutoSize = true;
            this.labelKiug.Location = new System.Drawing.Point(567, 302);
            this.labelKiug.Name = "labelKiug";
            this.labelKiug.Size = new System.Drawing.Size(108, 16);
            this.labelKiug.TabIndex = 33;
            this.labelKiug.Text = "Kiugró értékek";
            // 
            // labelKiugro
            // 
            this.labelKiugro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKiugro.AutoSize = true;
            this.labelKiugro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKiugro.Location = new System.Drawing.Point(570, 321);
            this.labelKiugro.Name = "labelKiugro";
            this.labelKiugro.Size = new System.Drawing.Size(296, 16);
            this.labelKiugro.TabIndex = 34;
            this.labelKiugro.Text = "(Kijelölt időszakban 5%-ot meghaladó eltérések)";
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.Timer7_Tick);
            // 
            // labelIdo
            // 
            this.labelIdo.AutoSize = true;
            this.labelIdo.Location = new System.Drawing.Point(5, -1);
            this.labelIdo.Name = "labelIdo";
            this.labelIdo.Size = new System.Drawing.Size(30, 16);
            this.labelIdo.TabIndex = 35;
            this.labelIdo.Text = "Ido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1792, 884);
            this.Controls.Add(this.labelIdo);
            this.Controls.Add(this.labelKiugro);
            this.Controls.Add(this.labelKiug);
            this.Controls.Add(this.labelAlacsony);
            this.Controls.Add(this.labelMagas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMagas;
        private System.Windows.Forms.Label labelAlacsony;
        private System.Windows.Forms.Label labelKiug;
        private System.Windows.Forms.Label labelKiugro;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Label labelIdo;
    }
}

