using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.ISP.Model
{
    interface IEmployee : IFeedable, IWorkable
    {
    }
}
