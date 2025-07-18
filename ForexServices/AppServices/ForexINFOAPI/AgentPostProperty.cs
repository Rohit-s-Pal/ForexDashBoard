using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    class AgentPostProperty
    {
    }

    public class AgentPostPropertyInputInfo : BaseInputInfo
    {

    }

    public class AgentPostPropertyResponseInfo : BaseResponseInfo
    {

        public List<PropTemplate> lstPropTemplate { get; set; }

    }

    public class PropTemplate
    {
        public int? ID { get; set; }
        public string? Title { get; set; }
        public string? Location { get; set; }
        public string? CreaOn { get; set; }
    }
}
