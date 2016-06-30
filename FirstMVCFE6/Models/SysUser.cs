using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCFE6.Models
{
    public class SysUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<SysRole> SysUserRoles { get; set; }
    }
}