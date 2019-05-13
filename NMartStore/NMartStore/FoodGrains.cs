using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMartStore
{
    public class FoodGrains : Category
    {
        public override double GSTPercentage
        {
            get
            {
                return 0;
            }
        }
    }
}
