using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using WebApplication1.Models;

using MySql.Data.MySqlClient;

namespace WebApplication1.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ORMDBManager:DbContext
    {
        public DbSet<StudentEntity> studentsEntities { get; set; }

        public ORMDBManager():base("MyConString")
        {

        }
    }
}