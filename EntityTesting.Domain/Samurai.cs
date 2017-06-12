using System.Collections.Generic;

namespace EntityTesting.Domain
{
    public class Samurai
    {
        public Samurai() { Quotes=new List<Quote>};

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int BattleId { get; set; }//a samurai can only be in one battlefield for now because many-to-many relationships are complicated in EF Core
    }
}
