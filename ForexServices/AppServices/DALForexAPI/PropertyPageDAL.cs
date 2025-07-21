using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DBAccessLib;
using IForexAPI;
using ForexINFOAPI;

namespace DALForexAPI
{
    public class PropertyPageDAL : IPropertyPage
    {
       

        public PropertyPageResponseInfo PropertyPageData(PropertyPageInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"{dbObjectOwner}.spPropertyPageData";


            var responseinfo = new PropertyPageResponseInfo();


            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AuthKey", inputInfo.AuthKey, DbType.String, direction: ParameterDirection.Input, size: 50);
            queryParameters.Add("@APPProcType", inputInfo.APPProcType, DbType.Int32);
            queryParameters.Add("@Proctype", inputInfo.ProcType, DbType.Int32);
            

            queryParameters.Add("@Mode", inputInfo.Mode, DbType.String);
            queryParameters.Add("@City", inputInfo.City, DbType.String);
            queryParameters.Add("@location", inputInfo.location, DbType.String);
            //queryParameters.Add("@bhk", inputInfo.bhk, DbType.String);


            queryParameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            queryParameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: queryParameters, commandType: CommandType.StoredProcedure);

                responseinfo.lstPropertyDetails = multi.Read<PropertyDetails>().ToList();


                responseinfo.Status = queryParameters.Get<string>("@status");
                responseinfo.MSG = queryParameters.Get<string>("@MSG");

            }
            catch (Exception ex)
            {
                // Add logging here
                throw new Exception("Error executing DashboardRecruiter", ex);
            }

            return responseinfo;
        }

        
    }
}
