using System;
using Apv.AV.Services.Data;
using Apv.AV.Services.Data.FC;
using Apv.AV.Services.Data.Models.FC;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Apv.AV.Test.Debugger
{
    public class DBIntegrationTests : IDisposable
    {

        private ApvAppContext context;

        public DBIntegrationTests()
        {
            context = TestConfig.getDbContext();
            //PrepareTestData();
        }

        private void PrepareTestData()
        {
            var lst = new List<CarModel>()
            {
                new CarModel()
                {
                    id = Guid.NewGuid().ToString(),
                    carModelId = "c117",
                    carModelClass = context.CarModelClasses.Where(cMc=>cMc.modelClassId=="100000").FirstOrDefault(),

                    modelLabel ="Golf R",
                    createdBy ="admin",
                    createdDt = DateTime.Now,
                    lastUpdatedBy = "admin",
                    lastUpdatedDt = DateTime.Now
                }
            };

            context.CarModels.AddRange((lst));
            context.SaveChanges();
        }

        public void GetAllCarModels()
        {
            ApvFCRepository service = new ApvFCRepository(context);
            var carModels = service.getCarModels(string.Empty, string.Empty, string.Empty, string.Empty);
            Console.Write(carModels.Count().ToString());


        }


        public void Dispose()
        {
            if(context!=null)
            {
                context.Dispose();
                context = null;
            }
        }

    }
}
