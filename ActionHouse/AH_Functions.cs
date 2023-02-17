using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class AH_Functions
    {
        public int Fun_Choose(string choose)
        {
            int result;
            bool success = int.TryParse(choose, out result);

            if(success)
            {
                return result;
            }
            return 0;
        }

    }
}
