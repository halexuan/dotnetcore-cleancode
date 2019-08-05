using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.DontWriteGlobalFunctions.Model
{
    class Configuration
    {
        private Dictionary<string, string> _configuration;

        public Configuration(Dictionary<string, string> configuration)
        {
            _configuration = configuration;
        }

        public string Get(string key)
        {
            return (_configuration[key] != null) ? _configuration[key] : null;
        }
    }
}
