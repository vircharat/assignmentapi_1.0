using Microsoft.EntityFrameworkCore;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyyDAL.Repost
{
    public class ColorRepost : Icolor
    {

        DBContext _dbContext;
        public ColorRepost(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void AddColor(Colour Colore)
        {
            _dbContext.color_tbl.Add(Colore);
            _dbContext.SaveChanges();
        }



        public void EditColor(Colour Colore)
        {
            _dbContext.Entry(Colore).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Colour GetColorById(int colorId)
        {
            return _dbContext.color_tbl.Find(colorId);
        }

        public IEnumerable<Colour> GetColors()
        {
            return _dbContext.color_tbl.ToList();
        }

        public void RemoveColor(int colorId)
        {
            var Colore = _dbContext.color_tbl.Find(colorId);
            _dbContext.color_tbl.Remove(Colore);
            _dbContext.SaveChanges();
        }
    }
}
