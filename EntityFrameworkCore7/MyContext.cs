using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore7
{
    using System;
    using System.Xml;
    using Microsoft.EntityFrameworkCore;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.HasDbFunction(
                 typeof(MyContext).GetMethod(nameof(GetMyEntitiesList),
                 new[] { typeof(Guid), typeof(string), typeof(int), typeof(int?), typeof(bool?), typeof(Guid?) })
            );
        }

        public IQueryable<MyEntity> GetMyEntitiesList(Guid a, string b, int c, int? d, bool? e, Guid? f)
                => FromExpression(() => GetMyEntitiesList(a, b, c, d, e, f));
    }
}
