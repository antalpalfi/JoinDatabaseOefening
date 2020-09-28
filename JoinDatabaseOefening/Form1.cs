using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinDatabaseOefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chekedBoxBadgeId.Items.Insert(0, "Parking");
            chekedBoxBadgeId.Items.Insert(1, "Gebouw");
            chekedBoxBadgeId.Items.Insert(2, "Kantoor");

            //using (JoinedDatabesaEntities ctx = new JoinedDatabesaEntities())
            //{
            //    var query = ctx.Persoons.Select(x => x);
            //    BindingList<Persoon> listItems = new BindingList<Persoon>();
            //    cmbNaam.DisplayMember = "Voornaam";
            //    cmbNaam.ValueMember = "Id";

            //    foreach (var item in query)
            //    {
            //        Persoon persoon = new Persoon()
            //        {
            //            Id = item.Id,
            //            Voornaam = item.Voornaam
            //        };
            //        listItems.Add(persoon);
            //    }
            //    cmbNaam.DataSource = listItems;
            //}
        }


        private void btnToevoeg_Click(object sender, EventArgs e)
        {
            using(JoinedDatabesaEntities ctx = new JoinedDatabesaEntities())
            {
                ctx.Persoons.Add(new Persoon() { Voornaam = txtVoornaam.Text, Achternaam = txtAchternaam.Text, Leeftijd = Convert.ToInt32(numLeeftijd.Value)});
                ctx.SaveChanges();
                allesTerug();
            }
        }
        public  void allesTerug()
        {
            txtAchternaam.Text = "";
            txtVoornaam.Text = "";
            numLeeftijd.Value = 0;
        }

        private void cmbNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            Bewerken addBewerken = new Bewerken();
            if (addBewerken.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
