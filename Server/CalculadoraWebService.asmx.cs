using System.Web.Services;

namespace Server
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class CalculadoraWebService : WebService
    {
        [WebMethod]
        public int Somar(int x, int y)
        {
            return x + y;
        }

    }
}
