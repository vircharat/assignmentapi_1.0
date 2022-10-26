using MyyDAL.Repost;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyBLL.services
{
    public class ColorService
    {
        Icolor _icolor;
        public ColorService(Icolor icolor)
        {
            _icolor = icolor;
        }

        public void Addcolor(Colour color)
        {
            _icolor.AddColor(color);
        }
        public void Editcolor(Colour color)
        {
            _icolor.EditColor(color);
        }

        public void Removecolor(int colorId)
        {
            _icolor.RemoveColor(colorId);
        }

        public Colour GetcolorbyId(int colorId)
        {
            return _icolor.GetColorById(colorId);
        }

        public IEnumerable<Colour> Getcolors()
        {
            return _icolor.GetColors();
        }
    }
}
