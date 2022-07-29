// using System.Runtime.CompilerServices;
// using Microsoft.AspNetCore.SignalR;

// public class DateHub : Hub{
//     public async IAsyncEnumerable<DateTime> StreamingDate([EnumeratorCancellation] CancellationToken cancellationToken){
//         while(true){
//             yield return DateTime.Now;
//             await Task.Delay(1000, cancellationToken);
//         }
//     }
// }