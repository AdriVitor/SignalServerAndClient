using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<DateHub>("/datehub");

app.Run();
public class DateHub : Hub{
    public async IAsyncEnumerable<DateTime> StreamingDate(){
        while(true){
            await Task.Delay(1000);
            yield return DateTime.Now;
        }
    }
}


