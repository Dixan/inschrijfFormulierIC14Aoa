using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InschrijfFormIc14aoaCs
{
    public partial class Form1 : Form
    {
        //csInfoLeden inschrijvingEen = new csInfoLeden();
        //csInfoLeden inschrijvingTwee = new csInfoLeden();
        csInfoLeden[] obLeden = new csInfoLeden[100];
        int nr = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //inschrijvingEen.naam = tbNaamDkal.Text;
            obLeden[nr] = new csInfoLeden();
            //obLeden[1] = new csInfoLeden();

            obLeden[nr].naam = tbNaamDkal.Text;
            obLeden[nr].adres = tbAdresDkal.Text;
            obLeden[nr].woonplaats = tbWoonplaatsDkal.Text;

            nr++;

            tbNaamDkal.Clear();
            tbWoonplaatsDkal.Clear();
            tbAdresDkal.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rtbInschrijvingen.Clear();

            for (int m_nr = 0; m_nr < nr; m_nr++)
            {
                rtbInschrijvingen.AppendText(obLeden[m_nr].naam + " > " + 
                                             obLeden[m_nr].adres + " > " + 
                                             obLeden[m_nr].woonplaats + "\n");
            }
        }
    }
}
