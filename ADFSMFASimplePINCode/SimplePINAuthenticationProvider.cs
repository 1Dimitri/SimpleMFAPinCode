using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityServer.Web.Authentication.External;

namespace ADFSMFASimplePINCode
{
    class SimplePINAuthenticationProvider : IAuthenticationAdapter
    {
        public IAdapterPresentation BeginAuthentication(System.Security.Claims.Claim identityClaim, System.Net.HttpListenerRequest request, IAuthenticationContext context)
        {
            return new SimplePINAdapterPresentation();
        }

        public bool IsAvailableForUser(System.Security.Claims.Claim identityClaim, IAuthenticationContext context)
        {
            return true;
        }

        public IAuthenticationAdapterMetadata Metadata
        {
            get { return new SimplePINAuthenticationMetadata(); }
        }

        public void OnAuthenticationPipelineLoad(IAuthenticationMethodConfigData configData)
        {
            // Do nothing
        }

        public void OnAuthenticationPipelineUnload()
        {
            // Do nothing
        }

        public IAdapterPresentation OnError(System.Net.HttpListenerRequest request, ExternalAuthenticationException ex)
        {
            return new SimplePINAdapterPresentation(ex.Message, true);
        }

        public IAdapterPresentation TryEndAuthentication(IAuthenticationContext context, IProofData proofData, System.Net.HttpListenerRequest request, out System.Security.Claims.Claim[] claims)
        {
                  claims = null;
            IAdapterPresentation result = null;
            string pin = proofData.Properties["pin"].ToString();
            if (pin == "98765")
            {
                System.Security.Claims.Claim claim = new System.Security.Claims.Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod", "http://schemas.microsoft.com/ws/2012/12/authmethod/otp");
                claims = new System.Security.Claims.Claim[] { claim };
            }
            else
            {
                result = new SimplePINAdapterPresentation("Authentication failed.", false);
            }
            return result;
        }

    }
}
