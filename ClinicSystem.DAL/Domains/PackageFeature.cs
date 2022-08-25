﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.DAL.Domains {
    public partial class PackageFeature:BaseModel {
        [Required]
        public string EnDescription { get; set; }
        [Required]
        public string ArDescription { get; set; }
        [ForeignKey(nameof(Package))]
        public Nullable<int> PackageId { get; set; }
        public virtual Package Package { get; set; }
    }
}
