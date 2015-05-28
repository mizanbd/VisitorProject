using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorProject.Model;
using VisitorProject.BLL;
using System.Configuration;
using System.Data.SqlClient;

namespace VisitorProject.UI
{
    public partial class ZoneTypeUI : Form
    {
        public ZoneTypeUI()
        {
            InitializeComponent();
        }

        ZoneTypeManager zoneManager = new ZoneTypeManager();
        
        Zonetype  zonetype = new Zonetype();

        private void saveButton_Click(object sender, EventArgs e)
        {
            String name = typeNameTextBox.Text;

            zonetype.typename = name;

            String mess = zoneManager.SaveZone(zonetype);
            MessageBox.Show(mess);
            typeNameTextBox.Text = String.Empty;
            LoadZoneData();

        }

        List<Zonetype> zonetypeList = new List<Zonetype>();
        private void ZoneTypeUI_Load(object sender, EventArgs e)
        {

          LoadZoneData();

        }

        public void LoadZoneData()
        {
            zonetypeList.Clear();
            zonetypeList = zoneManager.GetAllZone();
            zoneTypeListView.Items.Clear();

            foreach (Zonetype zone in zonetypeList)
            {
                ListViewItem item = new ListViewItem(zone.typename);
                // item.SubItems.Add(zone.typename);
                zoneTypeListView.Items.Add(item);
            }
        }

    

      
    }
}
