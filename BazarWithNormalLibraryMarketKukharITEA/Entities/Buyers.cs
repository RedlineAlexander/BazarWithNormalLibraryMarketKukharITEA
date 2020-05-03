using BazarWithNormalLibraryMarketKukharITEA.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Entities
{
    public class Buyers : ICommonEntity
    {
        [Key] public int BuyersId { get; set; }
        public string BuyersName { get; set; }
        public string BuyersGoodBuy { get; set; }
        public List<Consumers> Consumers { get; set; }
        public int Id { get; set; }
    }
}
