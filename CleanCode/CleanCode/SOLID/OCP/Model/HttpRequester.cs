using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.OCP.Model
{
    class HttpRequester
    {
        private readonly IAdapter Adapter;

        public HttpRequester(IAdapter adapter)
        {
            Adapter = adapter;
        }

        public bool Fetch(string url)
        {
            return Adapter.Request(url);
        }
    }
}
