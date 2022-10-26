using Microsoft.EntityFrameworkCore;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace MyyDAL.Repost
{
    public class DBContext: DbContext
    {
        public DbSet<Colour> color_tbl { get; set; }


        

        public DbSet<Product> product_tbl { get; set; }

        public DbSet<Article> article_tbl { get; set; }

        public DbSet<Sizee> sizee_tbl { get; set; }
        public DbSet<createcredit> createcredit_tbl { get; set; }



        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {



        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2179;Initial Catalog=MyDbforAssignment3.0;Integrated Security=True;");
        }
    }

}
