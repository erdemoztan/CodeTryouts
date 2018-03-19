using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCreateDB_Click(object sender, EventArgs e)
        {
            using (var diceContext = new DiceContext("name=DiceDBConnectionString"))
            {
                diceContext.Database.Initialize(true);
                //var deneme = new Reviewer();
                //deneme.BGGUserName = "aa";
                //deneme.Name = "deneme";
                //deneme.Surname = "deneme";
                //deneme.Id = Guid.NewGuid();
                //diceContext.Reviewers.Add(deneme);
                ////diceContext.SaveChanges();
                //diceContext.SaveChanges();
            }
            
        }
    }
}
