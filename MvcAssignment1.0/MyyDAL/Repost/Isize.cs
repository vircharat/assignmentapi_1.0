using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyDAL.Repost
{
    public interface Isize
    {
        void Addsize(Sizee sizee);

        void Removesize(int sizeId);

        void EditSize(Sizee sizee);

        Sizee GetSizeById(int sizeId);

        IEnumerable<Sizee> GetSizes();
    }
}
