using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASMProjectSMS.Models
{
    public class MyDBContext  : DbContext
    {
        public MyDBContext() : base("name = SMSProjectConnectionString")
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}