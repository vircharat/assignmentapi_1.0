using Microsoft.EntityFrameworkCore;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyyDAL.Repost
{
    public class SizeRepost : Isize
    {
        DBContext _dbContext;
        public SizeRepost(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void Addsize(Sizee sizee)
        {
            _dbContext.sizee_tbl.Add(sizee);
            _dbContext.SaveChanges();
        }



        public void EditSize(Sizee sizee)
        {
            _dbContext.Entry(sizee).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Sizee GetSizeById(int sizeId)
        {
            return _dbContext.sizee_tbl.Find(sizeId);
        }

        public IEnumerable<Sizee> GetSizes()
        {
            return _dbContext.sizee_tbl.ToList();
        }

        public void Removesize(int sizeId)
        {
            var sizee = _dbContext.sizee_tbl.Find(sizeId);
            _dbContext.sizee_tbl.Remove(sizee);
            _dbContext.SaveChanges();
        }
    }
}
