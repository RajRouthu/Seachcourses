using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seachcourses
{
    public class BaseContext <TbContext> : DbContext where TbContext: DbContext
    {

        static BaseContext()
        {

            Database.SetInitializer<TbContext>(null);

        }
        protected BaseContext()
            :base("name=Connetionstring")
        {

        }
    }
}