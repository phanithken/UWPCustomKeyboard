using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace UWPCustomKeyboard.keys
{
    public interface IKey
    {
        bool IsShift { get; set; }
        bool IsCaplock { get; set; }
        void Build(Size size, string label);
    }
}
