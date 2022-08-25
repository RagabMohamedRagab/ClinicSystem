﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.DAL.Domains {
    public partial class Service:BaseModel {
        public Service()
        {
            ServiceImages=new HashSet<ServiceImage>();
        }
        [Required]
        public string EnName { get; set; }
        [Required]
        public string ArName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Notes { get; set; }
      
        public virtual ICollection<ClinicService> ClinicServices { get; set; }
        public virtual ICollection<ServiceImage> ServiceImages { get; set; }
    }
}
