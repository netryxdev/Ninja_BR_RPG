﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_kekkei_genkai")]
    public class KekkeiGenkai
    {
        public int id_kekkei_genkai { get; set; }
        public string nm_kekkei_genkai { get; set; }
        public int id_clan { get; set; }
        public string img_url_kekkei_genkai { get; set; }
    }
}
