using System;

namespace BaseProj
{
    public static class ClassBase
    {
        public static RefObject GetRefObject()
        {
            return new RefObject();
        }

        public static RefObject? GetRefObject(int value)
        {
            return value > 0 ? new RefObject() : null;
        }
    }
}
