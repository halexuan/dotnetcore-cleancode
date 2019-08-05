using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Functions.DontUseSingletonPattern.Model
{
    class DBConnecton
    {
        public DBConnecton(IOptions<DBConnectionOption> options)
        {
        }
    }
}
