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

namespace Spital
{
    public partial class FrmVizualizareMedici : Form
    {
        public FrmVizualizareMedici()
        {
            InitializeComponent();          
            ComboFill();
        }
        private void ComboFill() {
            cbCategorii.Items.Add("departament");
            cbCategorii.Items.Add("cod");
            cbCategorii.Items.Add("nume");
        }
         
        private void tbCautareMedic_TextChanged(object sender, EventArgs e)
        {
            lbVizMedici.Items.Clear();
            String cb = cbCategorii.Text;
                switch (cb) {
                    case "cod": {
                        foreach (Medic m in Global.listMedic) {
                            if (m.cod.Equals(tbCautareMedic.Text)) {
                                ListViewItem list = new ListViewItem(m.cod);
                                list.SubItems.Add(m.nume);
                                list.SubItems.Add(m.prenume);
                                list.SubItems.Add(m.departament);
                                lbVizMedici.Items.Add(list);
                            }
                        }
                          
                            break;
                        }
                case "nume": {
                        foreach (Medic m in Global.listMedic)
                        {
                            if (m.nume.Equals(tbCautareMedic.Text))
                            {
                                ListViewItem list = new ListViewItem(m.cod);
                                list.SubItems.Add(m.nume);
                                list.SubItems.Add(m.prenume);
                                list.SubItems.Add(m.departament);
                                lbVizMedici.Items.Add(list);
                            }
                        }

                        break;
                    }
                case "departament": {
                         foreach (Medic m in Global.listMedic) {
                            if (m.departament.Equals(tbCautareMedic.Text)) {
                                ListViewItem list = new ListViewItem(m.cod);
                                list.SubItems.Add(m.nume);
                                list.SubItems.Add(m.prenume);
                                list.SubItems.Add(m.departament);
                                lbVizMedici.Items.Add(list);
                            }
                        }
                          
                            break;
                    }
            
                    
            }
        }

        private void FrmVizualizareMedici_Load(object sender, EventArgs e)
        {
            lbVizMedici.View = View.Details;
            lbVizMedici.Columns.Add("CodMedic", 65);
            lbVizMedici.Columns.Add("Nume", 100);
            lbVizMedici.Columns.Add("Prenume", 100);
            lbVizMedici.Columns.Add("Specializare", 100);

            foreach (Medic medic in Global.listMedic) {
                ListViewItem list = new ListViewItem(medic.cod);
                list.SubItems.Add(medic.nume);
                list.SubItems.Add(medic.prenume);
                list.SubItems.Add(medic.departament);
                lbVizMedici.Items.Add(list);
            }

        }
    }
}
