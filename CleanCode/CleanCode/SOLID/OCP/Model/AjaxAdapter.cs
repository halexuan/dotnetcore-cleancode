using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.OCP.Model
{
    class AjaxAdapter : IAdapter
    {
        public bool Request(string url)
        {
            // request and return promisse
            return true;
        }
    }
}
