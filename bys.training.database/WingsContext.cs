using bys.training.database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bys.training.database
{
    public class WingsContext : DbContext
    {
        public WingsContext()
            : base("WingsDataBase")
        {
            Database.SetInitializer<WingsContext>(new CreateDatabaseIfNotExists<WingsContext>());
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserDeatil> UserDeatils { get; set; }
    }

    //public class bysofcontextInitializer : CreateDatabaseIfNotExists<WingsContext>
    //{
    //    /// <summary>
    //    /// 使用继承的基类的初始化方法
    //    /// </summary>
    //    /// <param name="context">当前数据库上下文</param>
    //    public override void InitializeDatabase(WingsContext context)
    //    {
    //        base.InitializeDatabase(context);
    //    }
    //}
}

