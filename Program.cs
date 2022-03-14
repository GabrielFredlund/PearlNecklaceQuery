using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackPearl;

int totalNecklaceCount = 1000;
var r = new Random();
List<PearlList> necklaces = new List<PearlList>();

/*

necklaces = db.Necklaces;

if (necklaces.Count() == 0)
{
    // Skapa slump här och inserta
    // Eller töm db och slumpa nya
}
*/

// Skapa testhalsband
for (int i = 0; i < totalNecklaceCount; i++)
{
    // Slumpa mellan 10 och 50 pärlor per halsband
    var necklace = PearlList.Factory.CreateRandomList(r.Next(10, 50));
    necklaces.Add(necklace);
}

Console.WriteLine($"Skapade {totalNecklaceCount} halsband.");

// Räkna pärlor
int totalPearls = 0;

foreach(var n in necklaces)
{
    totalPearls += n.Count();
}

Console.WriteLine($"Totalt slumpades {totalPearls} pärlor.");

// Hitta dyraste
var mostExpensive = necklaces.OrderByDescending(price => price.totalPrice).First();

Console.WriteLine($"Halsband {necklaces.IndexOf(mostExpensive)} är dyrast med ett pris på {mostExpensive.totalPrice} SEK.");