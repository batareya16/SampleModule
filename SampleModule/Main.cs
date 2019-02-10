using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SampleModule
{
    public class Main
    {
        public string GetData(ref string config)
        {
            var configObj = Serializer.Deserialize<Configuration>(config);
            var dataItems = new List<Income>();
            dataItems.Add(new Income() { DateAndTime = DateTime.Now.AddDays(-1), Description = "Test Income", Summ = 200 });
            dataItems.Add(new Income() { DateAndTime = DateTime.Now, Description = "Test Income", Summ = 200 });
            dataItems.Add(new Income() { DateAndTime = DateTime.Now, Description = "Test Spending", Summ = -100, Place = "Place" });
            configObj.LastUpdate = DateTime.Now;
            config = Serializer.Serialize<Configuration>(configObj);
            return Serializer.Serialize<List<Income>>(dataItems);
        }
    }
}
