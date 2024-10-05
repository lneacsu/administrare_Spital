using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace Spital
{
    public partial class FrmStatistici : Form
    {
        public FrmStatistici()
        {
            
            InitializeComponent();
            DataCB();
            GetChartTypes();
            chart1.ChartAreas[0].BackColor = Color.Transparent;

        }
        public void DataCB() {
           cbObtiune.Items.Add("Sex");
           cbObtiune.Items.Add("Boala");
           cbObtiune.Items.Add("Pacienti pe departament");
           cbObtiune.Items.Add("Medici pe departament");
           cbObtiune.Items.Add("Luna Internare");
        }
        public void GetData() {
               switch(cbObtiune.Text)
            {
               case "Sex":
                   {
                       string sex = "select sex,count(codPacient) as [Nr. Pacienti]  from tPacienti group by sex";
                       SqlCommand cmd = new SqlCommand(sex, Global.con);
                       Global.con.Open();
                       SqlDataReader rdr = cmd.ExecuteReader();
                      while (rdr.Read())
                       {
                         int index = chart1.Series["Series1"].Points.AddY(rdr["Nr. Pacienti"]);
                         chart1.Series["Series1"].Points[index].Label = rdr["sex"] + "=" + rdr["Nr. Pacienti"].ToString();
                         this.chart1.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
                       }
                       Global.con.Close();
                       break;
                    }
               case "Boala":
                  {
                      string Boala = "select numeBoala,count(codPacient) as [Nr. Pacienti] from tPacienti as A inner join tBoli as B on A.codBoala=B.codBoala group by numeBoala";
                      SqlCommand cmd = new SqlCommand(Boala, Global.con);
                      Global.con.Open();
                      SqlDataReader rdr = cmd.ExecuteReader();
                      while (rdr.Read())
                       {
                          int index = chart1.Series["Series1"].Points.AddY(rdr["Nr. Pacienti"]);
                          chart1.Series["Series1"].Points[index].Label = rdr["numeBoala"] + "=" + rdr["Nr. Pacienti"].ToString();
                          this.chart1.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
                       }
                     Global.con.Close();
                     break;
                }
               case "Pacienti pe departament":
                {
                 string aa = "select specializare, count(codPacient) as [Nr. Pacienti] from tMedici as A " +
                  "inner join tPacienti as B on A.codMedic = B.codMedic " +
                 "group by specializare ";
                  SqlCommand cmd = new SqlCommand(aa, Global.con);
                  Global.con.Open();
                  SqlDataReader rdr = cmd.ExecuteReader();
                   while (rdr.Read())
                      {
                         int index = chart1.Series["Series1"].Points.AddY(rdr["Nr. Pacienti"]);
                         chart1.Series["Series1"].Points[index].Label = rdr["specializare"] + "=" + rdr["Nr. Pacienti"].ToString();
                         this.chart1.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
                      }
                      Global.con.Close();
                      break;
                  }
                case "Medici pe departament":
                  {
                      string medici = "select specializare,count(codMedic) as [Nr. Medici] from tMedici group by specializare";
                      SqlCommand cmd = new SqlCommand(medici, Global.con);
                      Global.con.Open();
                     SqlDataReader rdr = cmd.ExecuteReader();
                      while (rdr.Read())
                       {
                          int index = chart1.Series["Series1"].Points.AddY(rdr["Nr. Medici"]);
                          chart1.Series["Series1"].Points[index].Label = rdr["specializare"] + "=" + rdr["Nr. Medici"].ToString();
                          this.chart1.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
                       }
                      Global.con.Close();
                      break;
                    }
                case "Luna Internare":
                 {
                    string r = null;
                   string luna = "select month(dataInternare) as Luna,count(codPacient) as [Nr. Pacienti] from tPacienti group by month(dataInternare)";
                    SqlCommand cmd = new SqlCommand(luna, Global.con);
                    Global.con.Open();
                      SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            switch (rdr["Luna"].ToString()) {
                                case "1": r = "Ianuarie"; break;
                                case "2": r = "Februarie"; break;
                                case "3": r = "Martie"; break;
                                case "4": r = "Aprilie"; break;
                                case "5": r = "Mai"; break;
                                case "6": r = "Iunie"; break;
                                case "7": r = "Iulie"; break;
                                case "8": r = "August"; break;
                                case "9": r = "Septembrie"; break;
                                case "10": r = "Octombrie"; break;
                                case "11": r = "Noiembrie"; break;
                                case "12": r = "Decembrie"; break;
                           }
                            int index = chart1.Series["Series1"].Points.AddY(rdr["Nr. Pacienti"]);
                            chart1.Series["Series1"].Points[index].Label = r + "=" + rdr["Nr. Pacienti"].ToString();
                            this.chart1.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
                        }
                        Global.con.Close();
                        break;
                    }

            }
        }
        public void GetChartTypes() {
            string text = null;
            foreach (int t in Enum.GetValues(typeof(SeriesChartType)))
            {
                text = Enum.GetName(typeof(SeriesChartType), t);
                cbDiagrama.Items.Add(text);
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
        
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            GetData();
        }

        private void cbDiagrama_SelectedIndexChanged(object sender, EventArgs e)
        {          
            chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbDiagrama.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
