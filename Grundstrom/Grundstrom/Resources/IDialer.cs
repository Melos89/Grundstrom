using System;
using System.Collections.Generic;
using System.Text;

namespace Grundstrom.Resources
{
public interface IDial
    {
        void Dial(string number);
    }
public interface IDialer
    {

        bool Dial(string number);
    }
}
