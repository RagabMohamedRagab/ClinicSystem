﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.DAL.Domains {
    public partial class ClinicImage : BaseModel {
        public Nullable<int> ClinicID { get; set; }
        public virtual Clinic Clinic { get; set; }
        public string Image { get; set; }
        [MaxLength(200)]
        public string Notes { get; set; }
    }
}


