using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorProject.Model;
using VisitorProject.DAL;

namespace VisitorProject.BLL
{
    class ZoneTypeManager
    {

        ZoneTypeGateway zoneTypeGateway = new ZoneTypeGateway();
        public List<Zonetype> GetAllZone()
        {
            return zoneTypeGateway.GetAllZone();
        }

        internal string SaveZone(Zonetype zonetype)
        {
            int mess = zoneTypeGateway.SaveZone(zonetype);

            if (mess > 0)
            {
                return "Zone save Successfully";
            }
            else
            {
                return "Error!!! zone not saved";
            }

        }
    }
}
