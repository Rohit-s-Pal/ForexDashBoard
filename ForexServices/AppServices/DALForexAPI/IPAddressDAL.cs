using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
//using DBAccessLib;
using IForexAPI;
using ForexINFOAPI;

namespace DALForexAPI
{
    public class IPAddressDAL : IIPAddress
    {
        public PropertyPageResponseInfo IPAddress(PropertyPageInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"{dbObjectOwner}.spIPAddress";

            var responseinfo = new PropertyPageResponseInfo();

            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AuthKey", inputInfo.AuthKey, DbType.String, direction: ParameterDirection.Input, size: 50);
            queryParameters.Add("@APPProcType", inputInfo.APPProcType, DbType.Int32);
            queryParameters.Add("@Proctype", inputInfo.ProcType, DbType.Int32);


            queryParameters.Add("@IPAddress", inputInfo.IPAddress, DbType.String);



            queryParameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            queryParameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: queryParameters, commandType: CommandType.StoredProcedure);

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
