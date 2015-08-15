using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityServer.Web.Authentication.External;

namespace ADFSMFASimplePINCode
{
    class SimplePINAdapterPresentation : IAdapterPresentation, IAdapterPresentationForm
    {
        private string message;
        private bool isPermanentFailure;
        public string GetPageTitle(int lcid)
        {
            return "Simple PIN Authentication Provider";
        }

        public string GetFormHtml(int lcid)
        {
            string result = "";
            if (!String.IsNullOrEmpty(this.message))
            {
                result += "<p>" + message + "</p>";
            }
            if (!this.isPermanentFailure)
            {
                result += "<form method=\"post\" id=\"loginForm\" autocomplete=\"off\">";
                result += "PIN: <input id=\"pin\" name=\"pin\" type=\"password\" />";
                result += "<input id=\"context\" type=\"hidden\" name=\"Context\" value=\"%Context%\"/>";
                result += "<input id=\"authMethod\" type=\"hidden\" name=\"AuthMethod\" value=\"%AuthMethod%\"/>";
                result += "<input id=\"continueButton\" type=\"submit\" name=\"Continue\" value=\"Continue\" />";
                result += "</form>";
            }
            return result;
        }

        public string GetFormPreRenderHtml(int lcid)
        {
            return string.Empty;
        }
        public SimplePINAdapterPresentation()
        {
            this.message = string.Empty;
            this.isPermanentFailure = false;
        }
        public SimplePINAdapterPresentation(string message, bool isPermanentFailure)
        {
            this.message = message;
            this.isPermanentFailure = isPermanentFailure;
        }
    }
}
