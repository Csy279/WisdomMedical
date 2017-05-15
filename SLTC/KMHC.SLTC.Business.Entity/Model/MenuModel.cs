﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMHC.SLTC.Business.Entity.Model
{
    public partial class MenuModel
    {
        public int MenuID { get; set; }
        public int RoleID { get; set; }
        public string MenuName { get; set; }
        public int OrderSeq { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }

        public List<MenuFunction> Functions { get; set; }
    }
}
