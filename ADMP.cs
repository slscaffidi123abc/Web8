using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Data
{
    public class ADMP
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ADMIN_ID { get; set; }
    }
}
