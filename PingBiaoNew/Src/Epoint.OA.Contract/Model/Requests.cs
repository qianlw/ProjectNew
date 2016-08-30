using System;
using System.Collections.Generic;
using Epoint.Framework.Contract;

namespace Epoint.OA.Contract
{
    public class StaffRequest : Request
    {
        public string Name { get; set; }
        public int BranchId { get; set; }
    }

    public class BranchRequest : Request
    {
        public string Name { get; set; }
    }
}
