using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyDAL.Repost
{
    public interface Icolor
    {
        void AddColor(Colour colour);

        void RemoveColor(int colourId);

        void EditColor(Colour colour);

        Colour GetColorById(int colourId);

        IEnumerable<Colour> GetColors();
    }
}
