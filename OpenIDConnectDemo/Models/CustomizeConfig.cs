using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenIDConnectSDK;

namespace OpenIDConnectDemo.Models
{
    public class CustomizeConfig :Config
    {
        public override string getCallbackUrl()
        {
            return "http://localhost:37514/home/callback";
        }

        public override string getClientName()
        {
            return "EdaoStd";
        }

        public override string getCredentials()
        {
            return "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCANELcdE0uzTQ431SkuyN4RCQ0z0TCecSUhXQ0sOy9FITTnlzUs8Uja8K0dKp3Exxfegxf5USDtn1RA/22hMwYJ+3ovxHw5jxaQ0Vp8dXBTh08bCFXhvyHfjDC/8B4KAGkSkCyR3f4meFXQefa2GWTxqnf8LMJCnZTrGIFkwaB/wIDAQAB";
        }
    }
}