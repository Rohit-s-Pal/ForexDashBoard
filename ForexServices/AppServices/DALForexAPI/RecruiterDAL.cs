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
using VALDForexAPI;

namespace DALForexAPI
{
    public class RecruiterDAL : IRecruiter
    {
        
        public LoginResponseInfo ValidRecruiterLogin(LoginInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"[NSS].{dbObjectOwner}.spRecruiterLogin";

            var response = new LoginResponseInfo();
            

            var parameters = new DynamicParameters();
            parameters.Add("@EmailID", inputInfo.EmailID, DbType.String, size: 275);
            parameters.Add("@Password", inputInfo.Password, DbType.String, size: 275);
            parameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);
           

            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: parameters, commandType: CommandType.StoredProcedure);

                response.loginUser = multi.Read<LoginUser>().ToList();
                response.menulist = multi.Read<MenuList>().ToList();
                response.contaction = multi.Read<ContAction>().ToList();
                
                response.Status = parameters.Get<string>("@status");
                response.MSG = parameters.Get<string>("@MSG");

                }
            catch (Exception ex)
            {
                // Add logging here
                throw new Exception("Error executing ValidRecruiterLogin", ex);
            }

            return response;
        }

        public LoginResponseInfo ValidRecruiterReLogin(LoginInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();
            var spName = $"[NSS].{dbObjectOwner}.spRecruiterReLogin";

            var response = new LoginResponseInfo();
            
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", inputInfo.UserID, DbType.String, size: 275);
           
            parameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: parameters, commandType: CommandType.StoredProcedure);

                response.loginUser = multi.Read<LoginUser>().ToList();
                response.menulist = multi.Read<MenuList>().ToList();
                response.contaction = multi.Read<ContAction>().ToList();
                
                response.Status = parameters.Get<string>("@status");
                response.MSG = parameters.Get<string>("@MSG");

            }
            catch (Exception ex)
            {
                // Add logging here
                throw new Exception("Error executing ValidRecruiterReLogin", ex);
            }

            return response;
        }

        public LoginResponseInfo ValidRecruiterLogin1(LoginInputInfo InputInfo)
        {
            DataLib dataLibrary = null;
            LoginResponseInfo loginResponseInfo = null;
            var queryParameters = new DynamicParameters();

            string spName = string.Empty;

            try
            {
                loginResponseInfo = new LoginResponseInfo();

                var ConfigFilePath = Configuration.GetConfigFilePath();
                var DBSourceKey = Configuration.GetDBSourceKey();
                var DBObjectOwner = Configuration.GetDBObjectOwner();
                dataLibrary = new DataLib(DBSourceKey, ConfigFilePath);

                queryParameters.Add("@EmailID", InputInfo.EmailID, DbType.String, direction: ParameterDirection.Input, size: 275);
                queryParameters.Add("@Password", InputInfo.Password, DbType.String, direction: ParameterDirection.Input, size: 275);

                queryParameters.Add("@Status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
                queryParameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);

                spName = "[NSS]" + "." + DBObjectOwner + ".spRecruiterLogin";

                using (var multi = dataLibrary.GetConnection().QueryMultiple(spName, param: queryParameters, commandType: CommandType.StoredProcedure))
                {
                    loginResponseInfo.loginUser = multi.Read<LoginUser>().ToList();

                    loginResponseInfo.Status = queryParameters.Get<string>("@Status");
                    loginResponseInfo.MSG = queryParameters.Get<string>("@MSG");
                    
                }


            }
            catch
            {
                throw;
            }
            finally
            {
                if (dataLibrary != null)
                {
                    dataLibrary.Close();
                    dataLibrary.Dispose();
                }
            }
            return loginResponseInfo;
        }

      
    }
}
