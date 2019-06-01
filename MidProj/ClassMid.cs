using System;
using BaseProj;

namespace MidProj
{
    public static class ClassMid
    {
        public static RefObject GetRefObject(int value)
        {
            return value > 0 ? ClassBase.GetRefObject() : null;
        }
    }
}
