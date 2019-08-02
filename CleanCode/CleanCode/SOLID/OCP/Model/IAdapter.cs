using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.OCP.Model
{
    interface IAdapter
    {
        bool Request(string url);
    }
}
