using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoofuserplans.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Prepaid_Plan
    {
        public string getPlaninfo()
        {
            return $"the plan is {this.Plan_name} having {this.Datalimit_per}/GB perday";

        }
    }
}