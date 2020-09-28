using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinDatabaseOefening
{
    public partial class Bewerken : Form
    {
        public Bewerken()
        {
            InitializeComponent();
        }

        private void Bewerken_Load(object sender, EventArgs e)
        {
            using(JoinedDatabesaEntities ctr = new JoinedDatabesaEntities())
            {
                var query = ctr.Persoons.Select(x => x).ToList();
                cmbNaam.DisplayMember = "Voornaam";
                cmbNaam.ValueMember = "Id";
                cmbNaam.DataSource = query;
                

            }
        }
    }
}
