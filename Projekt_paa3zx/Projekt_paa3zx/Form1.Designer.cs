﻿namespace Projekt_paa3zx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePickerkezdo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerveg = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exportgomb = new System.Windows.Forms.Button();
            this.labelatlag = new System.Windows.Forms.Label();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.labelvaltozas = new System.Windows.Forms.Label();
            this.labelutolso = new System.Windows.Forms.Label();
            this.labelelso = new System.Windows.Forms.Label();
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
            this.ArfolyamChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxvaltozas = new Projekt_paa3zx.Tbs();
            this.textBoxutolso = new Projekt_paa3zx.Tbs();
            this.textBoxelso = new Projekt_paa3zx.Tbs();
            this.textBoxmin = new Projekt_paa3zx.Tbs();
            this.textBoxmax = new Projekt_paa3zx.Tbs();
            this.textBoxtlag = new Projekt_paa3zx.Tbs();
            this.dataGridView3 = new Projekt_paa3zx.DGV();
            this.dataGridView2 = new Projekt_paa3zx.DGV();
            this.dataGridView1 = new Projekt_paa3zx.DGV();
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Exportgomb.Location = new System.Drawing.Point(15, 992);
            this.Exportgomb.Name = "Exportgomb";
            this.Exportgomb.Size = new System.Drawing.Size(107, 42);
            this.Exportgomb.TabIndex = 4;
            this.Exportgomb.Text = "Adatok exportálása";
            this.Exportgomb.UseVisualStyleBackColor = true;
            this.Exportgomb.Click += new System.EventHandler(this.Exportgomb_Click);
            // 
            // labelatlag
            // 
            this.labelatlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelatlag.AutoSize = true;
            this.labelatlag.Location = new System.Drawing.Point(1614, 821);
            this.labelatlag.Name = "labelatlag";
            this.labelatlag.Size = new System.Drawing.Size(44, 16);
            this.labelatlag.TabIndex = 6;
            this.labelatlag.Text = "Átlag";
            // 
            // labelmax
            // 
            this.labelmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(1525, 850);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(134, 16);
            this.labelmax.TabIndex = 7;
            this.labelmax.Text = "Legnagyobb érték";
            // 
            // labelmin
            // 
            this.labelmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(1498, 878);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(163, 16);
            this.labelmin.TabIndex = 8;
            this.labelmin.Text = "Legalacsonyabb érték";
            // 
            // labelvaltozas
            // 
            this.labelvaltozas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelvaltozas.AutoSize = true;
            this.labelvaltozas.Location = new System.Drawing.Point(1534, 990);
            this.labelvaltozas.Name = "labelvaltozas";
            this.labelvaltozas.Size = new System.Drawing.Size(128, 16);
            this.labelvaltozas.TabIndex = 11;
            this.labelvaltozas.Text = "Időszaki változás";
            // 
            // labelutolso
            // 
            this.labelutolso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelutolso.AutoSize = true;
            this.labelutolso.Location = new System.Drawing.Point(1534, 962);
            this.labelutolso.Name = "labelutolso";
            this.labelutolso.Size = new System.Drawing.Size(127, 16);
            this.labelutolso.TabIndex = 10;
            this.labelutolso.Text = "Legrégebbi érték";
            // 
            // labelelso
            // 
            this.labelelso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelelso.AutoSize = true;
            this.labelelso.Location = new System.Drawing.Point(1534, 930);
            this.labelelso.Name = "labelelso";
            this.labelelso.Size = new System.Drawing.Size(126, 16);
            this.labelelso.TabIndex = 9;
            this.labelelso.Text = "Legkorábbi érték";
            // 
            // labelszamok
            // 
            this.labelszamok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelszamok.AutoSize = true;
            this.labelszamok.Location = new System.Drawing.Point(1454, 791);
            this.labelszamok.Name = "labelszamok";
            this.labelszamok.Size = new System.Drawing.Size(303, 16);
            this.labelszamok.TabIndex = 18;
            this.labelszamok.Text = "A kiválasztott időszakra vonatkozó adatok:";
            // 
            // labelValto1
            // 
            this.labelValto1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValto1.AutoSize = true;
            this.labelValto1.Location = new System.Drawing.Point(1092, 797);
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
            this.tbvalto.Location = new System.Drawing.Point(1153, 844);
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
            this.label1.Location = new System.Drawing.Point(1092, 813);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "(Jelenlegi kijelölt időszak utolsó időpontját veszi alapul)";
            // 
            // tbszam
            // 
            this.tbszam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbszam.Location = new System.Drawing.Point(1153, 879);
            this.tbszam.Name = "tbszam";
            this.tbszam.Size = new System.Drawing.Size(80, 22);
            this.tbszam.TabIndex = 22;
            this.tbszam.Text = "0";
            this.tbszam.TextChanged += new System.EventHandler(this.Tbszam_TextChanged);
            // 
            // eredmeny
            // 
            this.eredmeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eredmeny.Location = new System.Drawing.Point(1153, 925);
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
            this.labelMagas.Location = new System.Drawing.Point(506, 368);
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
            this.labelAlacsony.Location = new System.Drawing.Point(814, 368);
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
            this.labelKiug.Location = new System.Drawing.Point(564, 321);
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
            this.labelKiugro.Location = new System.Drawing.Point(567, 340);
            this.labelKiugro.Name = "labelKiugro";
            this.labelKiugro.Size = new System.Drawing.Size(367, 16);
            this.labelKiugro.TabIndex = 34;
            this.labelKiugro.Text = "(Kijelölt időszakban átlagtól vett 5%-ot meghaladó eltérések)";
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.Timer7_Tick);
            // 
            // labelIdo
            // 
            this.labelIdo.AutoSize = true;
            this.labelIdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdo.Location = new System.Drawing.Point(5, -1);
            this.labelIdo.Name = "labelIdo";
            this.labelIdo.Size = new System.Drawing.Size(30, 16);
            this.labelIdo.TabIndex = 35;
            this.labelIdo.Text = "Ido";
            // 
            // ArfolyamChart
            // 
            this.ArfolyamChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ArfolyamChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ArfolyamChart.Legends.Add(legend1);
            this.ArfolyamChart.Location = new System.Drawing.Point(570, 13);
            this.ArfolyamChart.Name = "ArfolyamChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ArfolyamChart.Series.Add(series1);
            this.ArfolyamChart.Size = new System.Drawing.Size(1222, 300);
            this.ArfolyamChart.TabIndex = 37;
            this.ArfolyamChart.Text = "chart1";
            // 
            // textBoxvaltozas
            // 
            this.textBoxvaltozas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxvaltozas.BackColor = System.Drawing.Color.White;
            this.textBoxvaltozas.ForeColor = System.Drawing.Color.Black;
            this.textBoxvaltozas.Location = new System.Drawing.Point(1668, 987);
            this.textBoxvaltozas.Name = "textBoxvaltozas";
            this.textBoxvaltozas.ReadOnly = true;
            this.textBoxvaltozas.Size = new System.Drawing.Size(100, 22);
            this.textBoxvaltozas.TabIndex = 46;
            // 
            // textBoxutolso
            // 
            this.textBoxutolso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxutolso.BackColor = System.Drawing.Color.Black;
            this.textBoxutolso.ForeColor = System.Drawing.Color.White;
            this.textBoxutolso.Location = new System.Drawing.Point(1668, 956);
            this.textBoxutolso.Name = "textBoxutolso";
            this.textBoxutolso.ReadOnly = true;
            this.textBoxutolso.Size = new System.Drawing.Size(100, 22);
            this.textBoxutolso.TabIndex = 45;
            // 
            // textBoxelso
            // 
            this.textBoxelso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxelso.BackColor = System.Drawing.Color.Black;
            this.textBoxelso.ForeColor = System.Drawing.Color.White;
            this.textBoxelso.Location = new System.Drawing.Point(1668, 927);
            this.textBoxelso.Name = "textBoxelso";
            this.textBoxelso.ReadOnly = true;
            this.textBoxelso.Size = new System.Drawing.Size(100, 22);
            this.textBoxelso.TabIndex = 44;
            // 
            // textBoxmin
            // 
            this.textBoxmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxmin.BackColor = System.Drawing.Color.Black;
            this.textBoxmin.ForeColor = System.Drawing.Color.White;
            this.textBoxmin.Location = new System.Drawing.Point(1668, 875);
            this.textBoxmin.Name = "textBoxmin";
            this.textBoxmin.ReadOnly = true;
            this.textBoxmin.Size = new System.Drawing.Size(100, 22);
            this.textBoxmin.TabIndex = 43;
            // 
            // textBoxmax
            // 
            this.textBoxmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxmax.BackColor = System.Drawing.Color.Black;
            this.textBoxmax.ForeColor = System.Drawing.Color.White;
            this.textBoxmax.Location = new System.Drawing.Point(1668, 847);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.ReadOnly = true;
            this.textBoxmax.Size = new System.Drawing.Size(100, 22);
            this.textBoxmax.TabIndex = 42;
            // 
            // textBoxtlag
            // 
            this.textBoxtlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtlag.BackColor = System.Drawing.Color.Black;
            this.textBoxtlag.ForeColor = System.Drawing.Color.White;
            this.textBoxtlag.Location = new System.Drawing.Point(1668, 821);
            this.textBoxtlag.Name = "textBoxtlag";
            this.textBoxtlag.ReadOnly = true;
            this.textBoxtlag.Size = new System.Drawing.Size(100, 22);
            this.textBoxtlag.TabIndex = 41;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(804, 386);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(292, 663);
            this.dataGridView3.TabIndex = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(506, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(292, 663);
            this.dataGridView2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(344, 1062);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1792, 1061);
            this.Controls.Add(this.textBoxvaltozas);
            this.Controls.Add(this.textBoxutolso);
            this.Controls.Add(this.textBoxelso);
            this.Controls.Add(this.textBoxmin);
            this.Controls.Add(this.textBoxmax);
            this.Controls.Add(this.textBoxtlag);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ArfolyamChart);
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
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.tbszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbvalto);
            this.Controls.Add(this.labelValto1);
            this.Controls.Add(this.labelszamok);
            this.Controls.Add(this.labelvaltozas);
            this.Controls.Add(this.labelutolso);
            this.Controls.Add(this.labelelso);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.labelatlag);
            this.Controls.Add(this.Exportgomb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerveg);
            this.Controls.Add(this.dateTimePickerkezdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Árfolyamelemző";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ArfolyamChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerkezdo;
        private System.Windows.Forms.DateTimePicker dateTimePickerveg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Exportgomb;
        private System.Windows.Forms.Label labelatlag;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label labelvaltozas;
        private System.Windows.Forms.Label labelutolso;
        private System.Windows.Forms.Label labelelso;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ArfolyamChart;
        private DGV dataGridView1;
        private DGV dataGridView2;
        private DGV dataGridView3;
        private Tbs textBoxtlag;
        private Tbs textBoxmax;
        private Tbs textBoxmin;
        private Tbs textBoxelso;
        private Tbs textBoxutolso;
        private Tbs textBoxvaltozas;
    }
}

