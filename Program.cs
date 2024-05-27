using System;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace DiscordSmackTalkingBot
{
    class Program
    {
        private readonly DiscordSocketClient client;
        private const string token = "850ead54a3799c07ce23ed49d72bd64295aba032e61b9d3715fc91287e7572a0";

        public Program()
        {
            this.client = new DiscordSocketClient();
            // client.MessageReceived +=
        }

        public async Task StartBotAsync()
        {
            await this.client.StartAsync();
            await Task.Delay(-1);
        }


        private async Task MessageHandler(SocketMessage message)
        {
            // if (message.)
            return;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
