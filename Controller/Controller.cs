using ClientApi;
using Newtonsoft.Json.Linq;

namespace ControllerNamespace
{
    /**
     * Clasa controller detine acces direct care toate functionalitatile aplicatiei,
     * prin urmare este singura clasa care comunica cu interfata si dirijeaza functionalitatile
     * claselor proiectate pentru backend.
     */
    public class Controller
    {
        private ClientAPI clientAPI = null;

        public Controller()
        {
            clientAPI = ClientAPI.GetInstance();
        }

    }
}
