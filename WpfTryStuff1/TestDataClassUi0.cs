using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTryStuff1
{
    public static class TestDataClassUi0
    {
        private static ICollection<string> sr_AllData;

        public static ICollection<string> AllData
        {
            get { return sr_AllData; }
        }

        static TestDataClassUi0()
        {
            initData();
        }

        private static void initData()
        {
            sr_AllData = new List<string>();
            sr_AllData.Add("A");
        }
    }
}
