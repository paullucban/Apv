using System;

namespace Apv.AV.Test.Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            DBIntegrationTests dbt = new DBIntegrationTests();
            dbt.GetAllCarModels();
        }
    }
}
