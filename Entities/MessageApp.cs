using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_sofka.Entities
{
    public class MessageApp
    {
        [Key]
        public int Id_MessageApp { get; set; }

        public string Name_Message { get; set; }

        public string Arrival_Message { get; set; }

        public string Goodbye_Message { get; set; }

        public int Id_Language { get; set; }
    }
}
