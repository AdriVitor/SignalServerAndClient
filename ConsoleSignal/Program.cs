using Microsoft.AspNetCore.SignalR.Client;


class Program
{
    public static async Task Main(string[] args)
    {
        HubConnection connection;
        const string url = "https://localhost:7294/datehub";

        connection = new HubConnectionBuilder()
        .WithUrl(url)
        .Build();

        await connection.StartAsync();
        
        await foreach (var date in connection.StreamAsync<DateTime>("StreamingDate"))
        {
            Console.WriteLine(date);
        }
    }
}