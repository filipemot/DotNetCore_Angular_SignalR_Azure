
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR_DotNetCore.Hubs
{

    public static class Contador {
      public static int valor;
    }

    public class ContadorHub: Hub
    {
        public async Task GetContador()
        {
            await Clients.Caller.SendAsync("getContador", Contador.valor);
        }

        public async Task SomaContador()
        {
          Contador.valor++;
          await BroadCastContador();
        }

        public async Task BroadCastContador()
        {
            await Clients.All.SendAsync("broadcastContador", Contador.valor);
        }
    }
}