using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lecture12DataAuthentication.Models
{
    public class Db :DbContext
    {
        public DbSet<Signup> signups
        {
            get; set;
        }
    }
}