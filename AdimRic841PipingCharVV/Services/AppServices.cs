using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc.Html;
using AdimRic841PipingCharVV.Models;
using WebGrease.Css.Extensions;

namespace AdimRic841PipingCharVV.Services
{
    public class AppServices
    {
        private readonly DataCmDb _db;

        public AppServices() : this(new DataCmDb())
        {
        } //Default constructor

        public AppServices(DataCmDb db)
        {
            _db = db;
        }

        public IList<FunctionalLocationModel> GetFunctionalLocationModels()
        {
            return _db.FunctionalLocations.OrderBy(x => x.LocationId).ToList();
        }

        public IList<FunctionalLocationWithDwgDataModel> GetCmWithDwgData()
        {
            IList<FunctionalLocationWithDwgDataModel> dwgCmMergeData = new List<FunctionalLocationWithDwgDataModel>();
            IList<FunctionalLocationModel> cmDataList = GetFunctionalLocationModels();
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();
            foreach (var cmWithDwg in cmDataList)
            {
                string apiPipeClass = "";
                string refineryPipeClass = "";
                string material = "";
          
                foreach (var dwgList in dwgDataList)
                {            
                    if (cmWithDwg.LocationId == dwgList.LocationId)
                    {
                        apiPipeClass = dwgList.ApiPipeClass;
                        refineryPipeClass = dwgList.RefineryPipeClass;
                        material = dwgList.PipingMaterial;
                    }
                }
                dwgCmMergeData.Add(new FunctionalLocationWithDwgDataModel()
                {
                    LocationId = cmWithDwg.LocationId,
                    Unit = cmWithDwg.Unit,
                    BusinesssArea = cmWithDwg.BusinesssArea,

                    ApiPipeClass = cmWithDwg.ApiPipeClass,
                    DwgApiPipeClass = apiPipeClass,

                    RefineryPipeClass = cmWithDwg.RefineryPipeClass,
                    DwgRefineryPipeClass = refineryPipeClass,

                    PipingMaterial = cmWithDwg.PipingMaterial,
                    DwgPipingMaterial = material    
                });
            }

            return dwgCmMergeData;
        }



        public IList<FunctionalLocationWithDwgDataModel> ValidateApiPipeClass()
        {
            IList<FunctionalLocationWithDwgDataModel> dwgCmMergeData = new List<FunctionalLocationWithDwgDataModel>();
            IList<FunctionalLocationModel> cmDataList = GetFunctionalLocationModels();
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();

            foreach (var cmWithDwg in cmDataList)
            {
                string apiPipeClass = "";
                string refineryPipeClass = "";
                string material = "";

                foreach (var dwgList in dwgDataList)
                {
                    if (cmWithDwg.LocationId == dwgList.LocationId)
                    {
                        apiPipeClass = dwgList.ApiPipeClass;
                        refineryPipeClass = dwgList.RefineryPipeClass;
                        material = dwgList.PipingMaterial;
                    }
                }
                dwgCmMergeData.Add(new FunctionalLocationWithDwgDataModel()
                {
                    LocationId = cmWithDwg.LocationId,
                    Unit = cmWithDwg.Unit,
                    BusinesssArea = cmWithDwg.BusinesssArea,

                    ApiPipeClass = cmWithDwg.ApiPipeClass,
                    DwgApiPipeClass = apiPipeClass,

                    RefineryPipeClass = cmWithDwg.RefineryPipeClass,
                    DwgRefineryPipeClass = refineryPipeClass,

                    PipingMaterial = cmWithDwg.PipingMaterial,
                    DwgPipingMaterial = material,
                    IsValidateApi = true
                });
            }

            return dwgCmMergeData;
        }

        public IList<FunctionalLocationWithDwgDataModel> ValidateRefineryPipeClass()
        {
            IList<FunctionalLocationWithDwgDataModel> dwgCmMergeData = new List<FunctionalLocationWithDwgDataModel>();
            IList<FunctionalLocationModel> cmDataList = GetFunctionalLocationModels();
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();

            foreach (var cmWithDwg in cmDataList)
            {
                string apiPipeClass = "";
                string refineryPipeClass = "";
                string material = "";

                foreach (var dwgList in dwgDataList)
                {
                    if (cmWithDwg.LocationId == dwgList.LocationId)
                    {
                        apiPipeClass = dwgList.ApiPipeClass;
                        refineryPipeClass = dwgList.RefineryPipeClass;
                        material = dwgList.PipingMaterial;
                    }
                }
                dwgCmMergeData.Add(new FunctionalLocationWithDwgDataModel()
                {
                    LocationId = cmWithDwg.LocationId,
                    Unit = cmWithDwg.Unit,
                    BusinesssArea = cmWithDwg.BusinesssArea,

                    ApiPipeClass = cmWithDwg.ApiPipeClass,
                    DwgApiPipeClass = apiPipeClass,

                    RefineryPipeClass = cmWithDwg.RefineryPipeClass,
                    DwgRefineryPipeClass = refineryPipeClass,

                    PipingMaterial = cmWithDwg.PipingMaterial,
                    DwgPipingMaterial = material,
                    IsValidateRefineryPipeClass = true
                });
            }

            return dwgCmMergeData;
        }

        public IList<FunctionalLocationWithDwgDataModel> ValidateMaterialPipeClass()
        {
            IList<FunctionalLocationWithDwgDataModel> dwgCmMergeData = new List<FunctionalLocationWithDwgDataModel>();
            IList<FunctionalLocationModel> cmDataList = GetFunctionalLocationModels();
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();

            foreach (var cmWithDwg in cmDataList)
            {
                string apiPipeClass = "";
                string refineryPipeClass = "";
                string material = "";

                foreach (var dwgList in dwgDataList)
                {
                    if (cmWithDwg.LocationId == dwgList.LocationId)
                    {
                        apiPipeClass = dwgList.ApiPipeClass;
                        refineryPipeClass = dwgList.RefineryPipeClass;
                        material = dwgList.PipingMaterial;
                    }
                }
                dwgCmMergeData.Add(new FunctionalLocationWithDwgDataModel()
                {
                    LocationId = cmWithDwg.LocationId,
                    Unit = cmWithDwg.Unit,
                    BusinesssArea = cmWithDwg.BusinesssArea,

                    ApiPipeClass = cmWithDwg.ApiPipeClass,
                    DwgApiPipeClass = apiPipeClass,

                    RefineryPipeClass = cmWithDwg.RefineryPipeClass,
                    DwgRefineryPipeClass = refineryPipeClass,

                    PipingMaterial = cmWithDwg.PipingMaterial,
                    DwgPipingMaterial = material,
                    IsValidatePipingMaterial = true
                });
            }

            return dwgCmMergeData;
        }


        public void UpdateDbApiPipeClass()
        {
            //PipingCharacteristicFrmDwgModel pipingCharacteristic = new PipingCharacteristicFrmDwgModel()
            //{
            //    LocationId = "0101-001-001",
            //    ApiPipeClass = "4",
            //    RefineryPipeClass = "TT1",
            //    PipingMaterial = "Tuan"
            //};

            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();
            foreach (var pipingCharacteristic in dwgDataList)
            {
                var dbMod = from api in _db.FunctionalLocations
                            where api.LocationId == pipingCharacteristic.LocationId
                            select api;
                dbMod.First().ApiPipeClass = pipingCharacteristic.ApiPipeClass;
                _db.SaveChanges();
            }
           

        }

        public void UpdateDbRefineryPipeClass()
        {
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();
            foreach (var pipingCharacteristic in dwgDataList)
            {
                var dbMod = from api in _db.FunctionalLocations
                            where api.LocationId == pipingCharacteristic.LocationId
                            select api;
                dbMod.First().RefineryPipeClass = pipingCharacteristic.RefineryPipeClass;
                _db.SaveChanges();
            }


        }

        public void UpdateDbPipingMaterial()
        {
            IList<PipingCharacteristicFrmDwgModel> dwgDataList = GetDwgData();
            foreach (var pipingCharacteristic in dwgDataList)
            {
                var dbMod = from api in _db.FunctionalLocations
                            where api.LocationId == pipingCharacteristic.LocationId
                            select api;
                dbMod.First().PipingMaterial = pipingCharacteristic.PipingMaterial;
                _db.SaveChanges();
            }

        }

        public void ResetMaterialField()
        {
            
            foreach (var material in _db.FunctionalLocations)
            {
                material.PipingMaterial = "-";

            }
            _db.SaveChanges();

        }

        //get file input from C:\App_Data\DataFile
        public IList<PipingCharacteristicFrmDwgModel> GetDwgData()
        {
            List<PipingCharacteristicFrmDwgModel> pipingCharacteristicList = new List<PipingCharacteristicFrmDwgModel>();
            string fileName = HostingEnvironment.MapPath("/App_Data/DataFile/0101.txt");
            //string fileName = VirtualPathUtility.ToAbsolute(string.Format(@"~/App_Data/DataFile/0101.txt"));//to C:
            //string fileName = VirtualPathUtility.ToAbsolute(string.Format(@"/site/wwwroot/App_Data/DataFile/0101.txt"));//to C:
            //fileName = Server.MapPath("~/App_Data/DataFile/0101.txt");
            //string fileName = VirtualPathUtility.ToAppRelative(string.Format(@"~/App_Data/DataFile/0101.txt"));
            //string fileName = "~/App_Data/DataFile/0101.txt";//should be changed on user's input file

            try
            {
                char[] splitCharArray = { '\t' };
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fileName))
                //using (System.IO.StreamReader sr = new System.IO.StreamReader("TuanData/DwgVsCm/0102.txt"))
                {
                    
                    while (sr.Peek() >= 0)
                    {
                        string[] readLineToArray = sr.ReadLine().Split(splitCharArray);
                        
                        //for (int i = 0; i < readLineToArray.Length; i++)
                        //{
                            string apiPipeClass = "";
                            if (readLineToArray[50] == "X") apiPipeClass = "1";
                            else if (readLineToArray[52] == "X") apiPipeClass = "2";
                            else if (readLineToArray[54] == "X") apiPipeClass = "3";

                            pipingCharacteristicList.Add(new PipingCharacteristicFrmDwgModel()
                            {
                                LocationId = readLineToArray[2],               
                                RefineryPipeClass = (readLineToArray[34].Replace("/",", ")).Replace("\"",""),
                                PipingMaterial = readLineToArray[32],
                                ApiPipeClass = apiPipeClass
                            });
                        //}
                        
                    }//while

                }//using
            }//try
            catch (Exception ex)
            {               
             
            }
          return pipingCharacteristicList;
        }//btnGetData_Click

   

        // In column position from title block txt dump
        enum ColumnPos
        {
            //Column index without Blanks. To include blanks column => *2
            // 1,5,7,16,17,18,25 (represent 1 of 3)
            DwgFileName,
            LocationID, // 1st Posistion * 2 = actual column
            Revision,
            SheetNo,
            DwgDescription,
            System, // 5th Position
            Plant, // 6th Position
            Division, // 7th
            LastSaveDate,
            LastEditDftrCai,
            PlantDup,
            DisciplineCode,
            FileName,
            LineName,
            From,
            To,
            Material, // 16th
            PipeClass, // 17th
            Service, // 18th
            Pwht,
            _150RatingHeader,
            _150RatingCheckbox,
            _300RatingHeader,
            _300RatingCheckbox,
            StmTraceCheckbox,
            ApiPipeClass, // 25th. Any mark 'X' will be the class
            ApiPipeClass2,
            ApiPipeClass3, // 27th
            InsulatedCheckbox,
            Iso570Complete,
            Scale,
            DftrCreated, // 31st

            /*
       LocationID,
       RefineryPipeClass,
       PlantUnit,
       ApiPipeClass,
       System
       DwgFileName*/

        } //Enum
    }

}