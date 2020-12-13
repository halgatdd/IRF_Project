using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Projekt_paa3zx.MNBServiceReference;

namespace Projekt_paa3zx
{
    public partial class Form1 : Form
    {
        BindingList<Adatok> Rates = new BindingList<Adatok>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            dateTimePickerkezdo.MaxDate = DateTime.Today.AddDays(-1);
            dateTimePickerkezdo.MinDate = DateTime.Today.AddYears(-1);
            dateTimePickerveg.MaxDate = DateTime.Today.AddDays(-1);
            dateTimePickerveg.MinDate = DateTime.Today.AddYears(-1);

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = true;
            timer7.Start();

            timer1.Interval = 2000;
            timer2.Interval = 4000;
            timer3.Interval = 6000;
            timer4.Interval = 8000;
            timer5.Interval = 10000;
            timer6.Interval = 12000;

            GetCurrencies();
            RefreshData();
        }



        void RefreshData()
        {
            Rates.Clear();
            comboBox1.DataSource = Currencies;
            dataGridView1.DataSource = Rates;           
            ArfolyamChart.DataSource = Rates;
            ExchangeData();

            //chart
            var series = ArfolyamChart.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;
            series.IsVisibleInLegend = false ;


            var chartArea = ArfolyamChart.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }
        //arfolyamok meghivasa
        void ExchangeData()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = (comboBox1.SelectedItem).ToString(),
                startDate = (dateTimePickerkezdo.Value).ToString(),
                endDate = (dateTimePickerveg.Value).ToString()
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;


            var xml = new XmlDocument();
            xml.LoadXml(result);


            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new Adatok();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;

            }
           

        }

        //penznem meghivas
        private void GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);


            foreach (XmlElement element in xml.DocumentElement.FirstChild)
            {
                var currencyName = element.InnerText;
                Currencies.Add(currencyName);
            }
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
            Timerek();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
            Timerek();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
            Timerek();
        }

        //export
        private void Exportgomb_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();


            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.FileName = "exchange_data_export";
            sfd.AddExtension = true;



            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {

                foreach (var r in Rates)
                {

                    sw.Write(r.Date);
                    sw.Write(";");
                    sw.Write(r.Currency);
                    sw.Write(";");
                    sw.Write(r.Value);
                    sw.WriteLine();
                }
            }
        }
        //szamolas
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && Convert.ToInt32(e.Value) != 0)
            {
                tbszam.ReadOnly = false;
                ArfolyamChart.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;
                labelKiug.Visible = true;
                labelKiugro.Visible = true;
                labelMagas.Visible = true;
                labelAlacsony.Visible = true;

                decimal osszegzes = (from elem in Rates select elem.Value).Sum();
                decimal db = dataGridView1.Rows.Count;
                decimal atlag = osszegzes / db;
                textBoxtlag.Text = String.Format("{0:N2}", atlag);

                decimal max = (from elem in Rates select elem.Value).Max();
                textBoxmax.Text = max.ToString();
                decimal min = (from elem in Rates select elem.Value).Min();
                textBoxmin.Text = min.ToString();


                decimal elso = (from elem in Rates select elem.Value).First();
                decimal uccso = (from elem in Rates select elem.Value).Last();
                textBoxelso.Text = elso.ToString();
                textBoxutolso.Text = uccso.ToString();


                decimal valtozas = ((elso / uccso) - 1) * 100;
                textBoxvaltozas.Text = String.Format("{0:N2}", valtozas) + " %";

                tbvalto.Text = elso.ToString();


                //szinezes
                int ertek = Convert.ToInt32(e.Value);
                if (ertek < atlag)
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                if (ertek > atlag)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (valtozas>0)
                {
                    textBoxvaltozas.BackColor = Color.Red;
                }
                if (valtozas < 0)
                {
                    textBoxvaltozas.BackColor = Color.LightGreen;
                }

                //kiugro ertekek vizsgalata
                double szorzo = 1.05;
                decimal kiugromagas = atlag * Convert.ToDecimal(szorzo);
                decimal kiugroalacsony = atlag / Convert.ToDecimal(szorzo);
                textBox1.Text = kiugromagas.ToString();
                textBox2.Text = kiugroalacsony.ToString();

                var masik = (from elem in Rates
                             where
                             elem.Value > kiugromagas
                             select elem).ToList();
                var harmadik = (from elem in Rates
                                where
                                 elem.Value < kiugroalacsony
                                select elem).ToList();
                dataGridView2.DataSource = masik;
                dataGridView3.DataSource = harmadik;
                if (dataGridView2.Rows.Count ==0)
                {
                    dataGridView2.Visible = false;
                }
                if (dataGridView3.Rows.Count == 0)
                {
                    dataGridView3.Visible = false;
                }
                if (dateTimePickerkezdo.Value >= dateTimePickerveg.Value)
                {
                    ArfolyamChart.Visible = false;
                }
            }


            //hibakezeles
            if (e.ColumnIndex == 2 && Convert.ToInt32(e.Value) == 0)
            {

                textBoxtlag.Text = "nincs adat";
                textBoxmax.Text = "nincs adat";
                textBoxmin.Text = "nincs adat";
                textBoxelso.Text = "nincs adat";
                textBoxutolso.Text = "nincs adat";
                textBoxvaltozas.Text = "nincs adat";
                tbvalto.Text = "nincs adat";
                tbszam.ReadOnly = true;
                ArfolyamChart.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                labelKiug.Visible = false;
                labelKiugro.Visible = false;
                labelMagas.Visible = false;
                labelAlacsony.Visible = false;
            }

        }
        //valtas
        private void Tbszam_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbszam.Text))
            {
                return;
            }

            if (tbszam.Text != null)
            {
                decimal szam = Convert.ToDecimal(tbszam.Text);
                decimal elso = Convert.ToDecimal(tbvalto.Text);
                decimal valtas = elso * szam;
                eredmeny.Text = valtas.ToString();
                
            }

        }
        //timerek fv-e
        private void Timerek()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();

            labelatlag.Visible = false;
            textBoxtlag.Visible = false;
            labelmax.Visible = false;
            textBoxmax.Visible = false;
            labelmin.Visible = false;
            textBoxmin.Visible = false;
            labelelso.Visible = false;
            textBoxelso.Visible = false;
            labelutolso.Visible = false;
            textBoxutolso.Visible = false;
            labelvaltozas.Visible = false;
            textBoxvaltozas.Visible = false;

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelatlag.Visible = true;
            textBoxtlag.Visible = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            labelmax.Visible = true;
            textBoxmax.Visible = true;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            labelmin.Visible = true;
            textBoxmin.Visible = true;
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            labelelso.Visible = true;
            textBoxelso.Visible = true;

        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            labelutolso.Visible = true;
            textBoxutolso.Visible = true;
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            labelvaltozas.Visible = true;
            textBoxvaltozas.Visible = true;
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
            labelIdo.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
        }
    }
}
