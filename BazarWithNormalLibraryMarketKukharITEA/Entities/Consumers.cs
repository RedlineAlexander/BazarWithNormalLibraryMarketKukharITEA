using BazarWithNormalLibraryMarketKukharITEA.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Entities
{
    public class Consumers : ICommonEntity
    {
        [Key] public int ConsumersId { get; set; }

        public string ConsumerName { get; set; }
        public string ConsumerGood { get; set; }
        public string ConsumerPavilyon { get; set; }
        public int Id { get; set; }
    }
}
