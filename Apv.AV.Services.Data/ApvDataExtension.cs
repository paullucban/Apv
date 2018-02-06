using Apv.AV.Services.Data.Models.FC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apv.AV.Services.Data
{
    public static class ApvDataExtension
    {
        public static void EnsureSeedDataForContext(this ApvAppContext context)
        {
            bool _doSave  = false;
            if (!context.Versions.Any())
            {
                _doSave  = true;                
            // init seed data
                var versions = new List<AppVersion>()
                {
                    new AppVersion()
                    {
                        id = Guid.NewGuid().ToString(),
                        platform = "Android",
                        prevVersionCode = 1.0m,
                        newVersionCode = 2.0m,
                        forceUpgrade = true,
                        features = string.Empty,
                        downloadUrl ="www.google.com",
                        createdBy = "admin",
                        createdDt = DateTime.Now,
                        lastUpdatedBy = "admin",
                        lastUpdatedDt = DateTime.Now
                    },
                    new AppVersion()
                    {
                        id = Guid.NewGuid().ToString(),
                        platform = "iOS",
                        prevVersionCode = 1.0m,
                        newVersionCode = 2.0m,
                        forceUpgrade = true,
                        features = string.Empty,
                        downloadUrl ="www.google.com",
                        createdBy = "admin",
                        createdDt = DateTime.Now,
                        lastUpdatedBy = "admin",
                        lastUpdatedDt = DateTime.Now
                    }
                };
                context.Versions.AddRange(versions);            
            }
            
            if(!context.CarModelClasses.Any())
            {
                _doSave = true;
              var  carModelClasses = new List<CarModelClass>()
              {
                  new CarModelClass()
                  {
                    id=Guid.NewGuid().ToString(),
                    countryCode = "SG",
                    companyId = "1000",
                    modelClassId ="100000",
                    modelClassCode = "c117",
                    modelClassBrand ="Volkswagen",
                    modelClassLabel ="Golf R",
                    modelClassLabelLoc =string.Empty,
                    modelClassTypeLabel ="Hatchback",
                    modelClassTypeLabelLoc = string.Empty,
                    carModelClassImages = new 
                            List<CarModelClassImage>()
                                {new CarModelClassImage()
                                    {
                                        coverImage="car_golf_R.jpg",
                                        thumbnailImage = "car_golf_R.jpg",
                                        createdBy = "admin",
                                        createdDt = DateTime.Now,
                                        lastUpdatedBy = "admin",
                                        lastUpdatedDt = DateTime.Now                               
                                    }
                                },
                    order =1.0m,
                    published = true,
                    createdBy = "admin",
                    createdDt = DateTime.Now,
                    lastUpdatedBy = "admin",
                    lastUpdatedDt = DateTime.Now
                }, 
                new CarModelClass()
                    {
                      id=Guid.NewGuid().ToString(),
                      countryCode = "SG",
                      companyId = "1000",
                      modelClassId ="100001",
                      modelClassCode = "c118",
                      modelClassBrand ="Volkswagen",
                      modelClassLabel ="Golf R",
                      modelClassLabelLoc =string.Empty,
                      modelClassTypeLabel ="Hatchback",
                      modelClassTypeLabelLoc = string.Empty,
                      carModelClassImages = new 
                            List<CarModelClassImage>()
                                {new CarModelClassImage()
                                    {
                                        coverImage="car_golf_r.jpg",
                                        thumbnailImage = "car_golf_r.jpg",
                                        verticalImage="car_golf_r.jpg",
                                        onlineImage = "car_golf_r.jpg",
                                        createdBy = "admin",
                                        createdDt = DateTime.Now,
                                        lastUpdatedBy = "admin",
                                        lastUpdatedDt = DateTime.Now                               
                                    }
                                },
                    order =1.0m,
                    published = true,
                    createdBy = "admin",
                    createdDt = DateTime.Now,
                    lastUpdatedBy = "admin",
                    lastUpdatedDt = DateTime.Now
                    },
                    new CarModelClass()
                    {
                      id=Guid.NewGuid().ToString(),
                      countryCode = "AU",
                      companyId = "2000",
                      modelClassId ="200000",
                      modelClassCode = "c119",
                      modelClassBrand ="Volkswagen",
                      modelClassLabel ="Golf R",
                      modelClassLabelLoc =string.Empty,
                      modelClassTypeLabel ="Hatchback",
                      modelClassTypeLabelLoc = string.Empty,
                      carModelClassImages = new 
                            List<CarModelClassImage>()
                                {new CarModelClassImage()
                                    {
                                        coverImage="car_golf_r.jpg",
                                        thumbnailImage = "car_golf_r.jpg",
                                        verticalImage="car_golf_r.jpg",
                                        onlineImage = "car_golf_r.jpg",
                                        createdBy = "admin",
                                        createdDt = DateTime.Now,
                                        lastUpdatedBy = "admin",
                                        lastUpdatedDt = DateTime.Now                               
                                    }
                                },
                    order =1.0m,
                    published = true,
                    createdBy = "admin",
                    createdDt = DateTime.Now,
                    lastUpdatedBy = "admin",
                    lastUpdatedDt = DateTime.Now
                    },                    
                    new CarModelClass()
                    {
                      id=Guid.NewGuid().ToString(),
                      countryCode = "AU",
                      companyId = "2000",
                      modelClassId ="200001",
                      modelClassCode = "c120",
                      modelClassBrand ="Volkswagen",
                      modelClassLabel ="Golf R",
                      modelClassLabelLoc =string.Empty,
                      modelClassTypeLabel ="Hatchback",
                      modelClassTypeLabelLoc = string.Empty,
                      carModelClassImages = new 
                            List<CarModelClassImage>()
                                {new CarModelClassImage()
                                    {
                                        coverImage="car_golf_r.jpg",
                                        thumbnailImage = "car_golf_r.jpg",
                                        verticalImage="car_golf_r.jpg",
                                        onlineImage = "car_golf_r.jpg",
                                        createdBy = "admin",
                                        createdDt = DateTime.Now,
                                        lastUpdatedBy = "admin",
                                        lastUpdatedDt = DateTime.Now                               
                                    }
                                },
                    order =1.0m,
                    published = true,
                    createdBy = "admin",
                    createdDt = DateTime.Now,
                    lastUpdatedBy = "admin",
                    lastUpdatedDt = DateTime.Now
                    }
              };

            context.CarModelClasses.AddRange(carModelClasses);

            }

            if(_doSave)
                context.SaveChanges();

        }
    }
}
