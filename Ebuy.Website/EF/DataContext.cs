using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ebuy.Website.Models;

namespace Ebuy.Website.EF
{
    public class EbuyDataContext : DbContext
    {
        public DbSet<Auction> Actions { get; set; }
    }
}