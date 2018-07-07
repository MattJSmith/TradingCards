using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingCards.Models
{
    interface ICard
    {
        string CardName { get; set; }
        string CardDescription { get; set; }
    }
}
