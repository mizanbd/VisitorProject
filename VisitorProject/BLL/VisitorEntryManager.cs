using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorProject.Model;
using VisitorProject.DAL;


namespace VisitorProject.BLL
{
   public  class VisitorEntryManager
    {

       ZoneTypeGateway zoneTypeGateway = new ZoneTypeGateway();

        public List<Zonetype> GetAllZone()
        {
            return zoneTypeGateway.GetAllZone();


        }
    }
}
