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

namespace Kunc_Test_DB_20220503
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            faktury = sqlRepozitar.GetFaktura();
            RefreshGUI();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<Faktura> faktury;
        SqlRepozitar sqlRepozitar = new SqlRepozitar();

        private void RefreshGUI()
        {
            listView1.Items.Clear();
            foreach (Faktura faktura in faktury)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { faktura.cislo.ToString(), faktura.datum.ToString("dd.MM.yyyy"), faktura.odberatel, faktura.nazev, faktura.pocet.ToString(), faktura.cena.ToString() });
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
