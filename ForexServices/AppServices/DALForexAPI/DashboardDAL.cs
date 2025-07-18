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
using VALDForexAPI;

namespace DALForexAPI
{
    public class DashboardDAL : IDashboard
    {
        

        public DashboardRecruiterResponseInfo DashboardRecruiter(DashboardRecruiterInputInfo inputInfo)
        {
            var configFilePath = Configuration.GetConfigFilePath();
            var dbSourceKey = Configuration.GetDBSourceKey();
            var dbObjectOwner = Configuration.GetDBObjectOwner();           
            var spName = $"{dbObjectOwner}.spDashboardRecruiter";


            var responseinfo = new DashboardRecruiterResponseInfo();


            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AuthKey", inputInfo.AuthKey, DbType.String, direction: ParameterDirection.Input, size: 50);
            queryParameters.Add("@APPProcType", inputInfo.APPProcType, DbType.Int32);
            queryParameters.Add("@RoleID", inputInfo.RoleID, DbType.Int32);   //It was Usertype
            queryParameters.Add("@Proctype", inputInfo.ProcType, DbType.Int32);
            queryParameters.Add("@UserID", inputInfo.UserID, DbType.Int32);

            queryParameters.Add("@RecruiterID", inputInfo.RecruiterID, DbType.Int32);
            queryParameters.Add("@StartDate", inputInfo.DateRange.StartDate, DbType.String);
            queryParameters.Add("@EndDate", inputInfo.DateRange.EndDate, DbType.String);


            queryParameters.Add("@status", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            queryParameters.Add("@MSG", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);


            using var dataLibrary = new DataLib(dbSourceKey, configFilePath);
            using var connection = dataLibrary.GetConnection();

            try
            {
                using var multi = connection.QueryMultiple(spName, param: queryParameters, commandType: CommandType.StoredProcedure);

                //responseinfo.dashboardStatistics = multi.Read<DashboardStatistics>().FirstOrDefault();
                responseinfo.lstDashboardStatistics = multi.Read<DashboardStatistics>().ToList();
                responseinfo.lstDashboardJobPosting = multi.Read<DashboardJobPosting>().ToList();
                responseinfo.lstDashboardCallLog = multi.Read<DashboardCallLog>().ToList();
                responseinfo.lstDashboardGraph = multi.Read<DashboardGraph>().ToList();
                responseinfo.lstDashboardActivity = multi.Read<DashboardActivity>().ToList();
                responseinfo.lstRecruiter = multi.Read<ComboDeta>().ToList();

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
