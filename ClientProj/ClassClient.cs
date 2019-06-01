using System;
using BaseProj;
using MidProj;

namespace ClientProj
{
    public static class ClassClient
    {
        public static void Test()
        {
            RefObject baseRef = ClassBase.GetRefObject();
            Console.WriteLine(baseRef.ToString());

            RefObject? baseRefNullable = ClassBase.GetRefObject(0);
            Console.WriteLine(baseRefNullable?.ToString());

            RefObject? midRef = ClassMid.GetRefObject(0);
            Console.WriteLine(midRef.ToString());
        }
    }
}
