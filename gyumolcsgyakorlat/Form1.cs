using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gyumolcsgyakorlat
{
    public partial class Form1 : Form
    {
        adatbazis Adatbazis = new adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gyumolcsokbetoltese();
        }

        private void gyumolcsokbetoltese()
        {
            gyumolcsok.Items.Clear();
            foreach (gyumolcs item in Adatbazis.getAllGyumolcs())
            {
                gyumolcsok.Items.Add(item);
            }
        }
    }
}
