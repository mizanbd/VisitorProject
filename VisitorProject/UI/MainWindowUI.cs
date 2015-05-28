using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorProject.UI;

namespace VisitorProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        VisitorEntryUI visitorEntry = new VisitorEntryUI();
        ZoneTypeUI zoneType = new ZoneTypeUI();

       ZoneSpecificVisitorInformationReportUI zoneSpecificInformation =  new ZoneSpecificVisitorInformationReportUI();

       ZoneTypeWiseVisitorNumberReportUI zoneTypeWiseVisitorNumber = new ZoneTypeWiseVisitorNumberReportUI();

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void visitorEntrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorEntry.Show();
           

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoneSpecificVisitorInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoneSpecificInformation.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoneType.Show();

        }

        private void zoneTypeWiseVisitorNumberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoneTypeWiseVisitorNumber.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      
       

      



    }
}
