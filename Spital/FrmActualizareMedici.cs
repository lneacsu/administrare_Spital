using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Spital
{
    public partial class FrmActualizareMedici : Form
    {
        public FrmActualizareMedici()
        {
            InitializeComponent();
            dgMedici.DataSource = Global.ds;
            dgMedici.DataMember = "Medici";
            dgMedici.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238,239,255);
            dgMedici.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20,25,72);
            dgMedici.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgMedici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            string cod = null;
            DialogResult result1 = MessageBox.Show("Sunteti autorizat sa schimbati date despre medici?", "Important Question",
             MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                cod = Interaction.InputBox("Introduceti codul de securitate");
               if (cod == "1234")
                {
                     SqlCommandBuilder cb = new SqlCommandBuilder(Global.daMedici);
                      DataTable dtChange = Global.ds.Tables["Medici"].GetChanges();

                      if (dtChange != null)
                      {
                          Global.daMedici.Update(dtChange);
                          Global.ds.Tables["Medici"].AcceptChanges();
                          MessageBox.Show("Comanda Efectuata!");
                      }          
                }
                else MessageBox.Show("Cod gresit!Nu aveti acces");
            }         
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Medici"].RejectChanges();
        }
        private void tbCautare_TextChanged(object sender, EventArgs e)
        {
            Global.con.Open();
            DataView dv = Global.ds.Tables["Medici"].DefaultView;
            dv.RowFilter = string.Format("codMedic LIKE '%{0}%'", tbCautare.Text);
            dgMedici.DataSource = dv;
            Global.con.Close();          
        }

    }
}
    

