﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLForexApi;
using IForexAPI;
using ForexINFOAPI;

namespace BLForexApi
{
    public class IPAddressBL : IIPAddress
    {
        public IPAddressBL() { }

        private IIPAddress GetDALObject()
        {
            return DALFactory.InsertIPAddressDAL();
        }
        public PropertyPageResponseInfo IPAddress(PropertyPageInputInfo InputInfo)
        {
            IIPAddress iIPAddress = null;

            try
            {
                iIPAddress = GetDALObject();
                return iIPAddress.IPAddress(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iIPAddress = null;
            }
        }
    }
}
