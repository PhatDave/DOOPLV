using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Note
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
