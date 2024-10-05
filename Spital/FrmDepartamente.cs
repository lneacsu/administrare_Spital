using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Spital
{
    public partial class FrmDepartamente : Form
    {
        public FrmDepartamente()
        {
            InitializeComponent();
            BlindData();
            GetData();
            dgDepartamente.DataSource = Global.ds;
            dgDepartamente.DataMember = "Departamente";
        }
        public void BlindData()
        {
            listViewDepartamente.View = View.Details;
            listViewDepartamente.Columns.Add("Departament", 110);
            listViewDepartamente.Columns.Add("Nr. Pacienti", 100);        
            string sql = "select specializare, count(codPacient) as [Nr. Pacienti] from tMedici as A " +
                "inner join tPacienti as B on A.codMedic = B.codMedic " +
                "group by specializare ";
            Global.con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, Global.con);
            DataTable dc = new DataTable();
            ad.Fill(dc);
            for (int i = 0; i < dc.Rows.Count; i++)
            {
                DataRow d = dc.Rows[i];
                ListViewItem list = new ListViewItem(d["specializare"].ToString());               
                list.SubItems.Add(d["Nr. Pacienti"].ToString());
                listViewDepartamente.Items.Add(list);
            }
            Global.con.Close();
        }

        private void listViewDepartamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = null;
            if (listViewDepartamente.SelectedItems.Count > 0)
            {
                 text = listViewDepartamente.SelectedItems[0].Text;
                
            }
            DataView dv;
            DataTable dt = Global.ds.Tables["Pacienti"];
            dv = new DataView(dt, "Specializare = '"+text+"'", "codPacient asc", DataViewRowState.CurrentRows);
            decimal Total = 0;
            dgDepartamente.Visible = true; dgDepartamente.DataSource = dv;
            foreach (DataRowView r in dv)
            {
                if (r["Total Plata"] == DBNull.Value)
                    Total += 0;
                else
                    Total += decimal.Parse(r["Total Plata"].ToString());
            }
            dgDepartamente["CNP", dgDepartamente.Rows.Count - 1].Value ="Total Departament";
            dgDepartamente["codPacient", dgDepartamente.Rows.Count - 1].Value = "    =  ";
            dgDepartamente["Nume Pacient", dgDepartamente.Rows.Count-1].Value = Total;

        }

        public void GetData() {
            chartDepartamente.ChartAreas[0].BackColor = Color.Transparent;
            chartDepartamente.Legends[0].BackColor = Color.Transparent;
            string aa = "select specializare, count(codPacient) as [Nr. Pacienti] from tMedici as A " +
                "inner join tPacienti as B on A.codMedic = B.codMedic " +
                "group by specializare ";
            Series ser = chartDepartamente.Series["Series1"];                     
            SqlCommand cmd = new SqlCommand(aa, Global.con);
            Global.con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            
            while (r.Read())
            {          
                int index = chartDepartamente.Series["Series1"].Points.AddY(r["Nr. Pacienti"]);
                chartDepartamente.Series["Series1"].Points[index].Label = r["specializare"]+"="+r["Nr. Pacienti"].ToString();
                this.chartDepartamente.Series["Series1"].CustomProperties = "PieLabelStyle=Outside";
            }
            Global.con.Close();
        }


    }
}
