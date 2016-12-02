using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Trello.Models
{
    public class Card
    {
        public int ID { get; set; }
        public int SortOrder { get; set; }
        public string Title { get; set; }
    }

    public class TrelloDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}