using System;

namespace BaseProj
{
    public class RefObject
    {
        public string? Value { get; set; } = "Hello, World!";

        public override string ToString() => Value ?? string.Empty;
    }
}
