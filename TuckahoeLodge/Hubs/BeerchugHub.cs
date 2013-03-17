using TuckahoeLodge.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;

namespace TuckahoeLodge.Hubs
{
    public class BeerchugHub : Hub
    {
        private static readonly List<Beerchug> Beerchugs = new List<Beerchug>();

        public static List<Beerchug> GetBeerchugs()
        {
            throw new NotImplementedException();
        }
    }
}