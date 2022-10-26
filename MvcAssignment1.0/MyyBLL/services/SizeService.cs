using MyyDAL.Repost;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyBLL.services
{
    public class SizeService
    {
        Isize _isize;
        public SizeService(Isize isize)
        {
            _isize = isize;
        }

        public void Addsize(Sizee size)
        {
            _isize.Addsize(size);
        }
        public void Editsize(Sizee size)
        {
            _isize.EditSize(size);
        }

        public void Removesize(int sizeId)
        {
            _isize.Removesize(sizeId);
        }

        public Sizee GetsizebyId(int sizeId)
        {
            return _isize.GetSizeById(sizeId);
        }

        public IEnumerable<Sizee> Getsizes()
        {
            return _isize.GetSizes();
        }
    }
}
