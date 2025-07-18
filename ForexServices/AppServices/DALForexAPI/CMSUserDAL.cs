using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;
using Dapper;
using DBAccessLib;
using IForexAPI;

namespace DALForexAPI
{
    public  class CMSUserDAL : ICMSUser
    {
        public LoginResponseInfo ValidUserLogin(LoginInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"[CMS].{dbObjectOwner}.spValidUserLogin";

            var response = new LoginResponseInfo();


            var parameters = new DynamicParameters();
            parameters.Add("@MobiNumb", inputInfo.MobiNumb, DbType.String, size: 275);
            parameters.Add("@Password", inputInfo.Password, DbType.String, size: 275);
            parameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: parameters, commandType: CommandType.StoredProcedure);

                response.loginUser = multi.Read<LoginUser>().ToList();
                //response.menulist = multi.Read<MenuList>().ToList();
                //response.contaction = multi.Read<ContAction>().ToList();

                response.Status = parameters.Get<string>("@status");
                response.MSG = parameters.Get<string>("@MSG");

            }
            catch (Exception ex)
            {
                // Add logging here
                throw new Exception("Error executing ValidUserLogin", ex);
            }

            return response;
        }



        public LoginResponseInfo ValidUserReLogin(LoginInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"[CMS].{dbObjectOwner}.spValidUserReLogin";

            var response = new LoginResponseInfo();


            var parameters = new DynamicParameters();
            parameters.Add("@UserID", inputInfo.UserID, DbType.String, size: 275);
           
            parameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: parameters, commandType: CommandType.StoredProcedure);

                response.loginUser = multi.Read<LoginUser>().ToList();
                //response.menulist = multi.Read<MenuList>().ToList();
                //response.contaction = multi.Read<ContAction>().ToList();

                response.Status = parameters.Get<string>("@status");
                response.MSG = parameters.Get<string>("@MSG");

            }
            catch (Exception ex)
            {
                // Add logging here
                throw new Exception("Error executing ValidUserReLogin", ex);
            }

            return response;
        }
    }
}
