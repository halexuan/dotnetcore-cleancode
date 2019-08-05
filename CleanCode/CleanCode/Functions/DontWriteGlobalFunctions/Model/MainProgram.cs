using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.DontWriteGlobalFunctions.Model
{
    class MainProgram
    {
        static void _Main()
        {
            var configuration = new Configuration(new Dictionary<string, string> {
                { "foo", "bar" }
            });
        }
    }
}
