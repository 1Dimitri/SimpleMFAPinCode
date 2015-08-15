using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityServer.Web.Authentication.External;

namespace ADFSMFASimplePINCode 
{
    class SimplePINAuthenticationMetadata : IAuthenticationAdapterMetadata
    {
          public string AdminName
        {
            get { return "Simple PIN Code Authentication Provider"; }
        }

        public string[] AuthenticationMethods
        {
            get { return new string[] { "http://schemas.microsoft.com/ws/2012/12/authmethod/otp" }; }
        }

        public int[] AvailableLcids
        {
            get { return new int[] { 1033 }; }
        }

        public Dictionary<int, string> Descriptions
        {
            get
            {
                Dictionary<int, string> result = new Dictionary<int, string>();
                result.Add(1033, "Simple PIN Code Authentication Provider");
                return result;
            }
        }

        public Dictionary<int, string> FriendlyNames
        {
            get
            {
                Dictionary<int, string> result = new Dictionary<int, string>();
                result.Add(1033, "Simple PIN Code Authentication Provider");
                return result;
            }
        }

        public string[] IdentityClaims
        {
            get { return new string[] { "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn" }; }
        }

        public bool RequiresIdentity
        {
            get { return true; }
        }
        public SimplePINAuthenticationMetadata()
        {

        }
    }
}
