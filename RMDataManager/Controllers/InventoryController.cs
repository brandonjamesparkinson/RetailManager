using RMDataManager.Library.DataAccess;
using RMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RMDataManager.Controllers
{
    //[Authorize]
    public class InventoryController : ApiController
    {
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();
            data.SaveInventoryRecord(item);
        }

        public List<InventoryModel> GetSalesReport()
        {
            InventoryData data = new InventoryData();
            return data.GetInventory();
        }
    }
}
