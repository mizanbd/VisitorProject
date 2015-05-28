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
using VisitorProject.Model;
using VisitorProject.BLL;

namespace VisitorProject.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }
        List<Zonetype >  zonetypelist = new List<Zonetype>();
        VisitorEntryManager visitorEntryManager = new VisitorEntryManager();
      
        private void VisitorEntry_Load(object sender, EventArgs e)
        {
            Zonetype zonetype = new Zonetype();
            zonetypelist = visitorEntryManager.GetAllZone();

            foreach (Zonetype zone in zonetypelist)
            {

                viewCheckedListBox.Items.Add(zone.typename);
            }
        }

        private void viewCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
