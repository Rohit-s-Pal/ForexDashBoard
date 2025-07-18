using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLPropertyApi;
using IPropertyAPI;
using PropertyINFOAPI;

namespace BLPropertyAPI
{
    public class AgentPostPropertyBL : IAgentPostProperty
    {
        public AgentPostPropertyBL() { }

        private IAgentPostProperty GetDALObject()
        {
            return DALFactory.GetTemplateData();
        }

        public AgentPostPropertyResponseInfo PropertyTemplateData(AgentPostPropertyInputInfo inputInfo)
        {
            IAgentPostProperty iAgentPostProperty = null;

            try
            {
                iAgentPostProperty = GetDALObject();
                return iAgentPostProperty.PropertyTemplateData(inputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iAgentPostProperty = null;
            }
        }
    }
}
