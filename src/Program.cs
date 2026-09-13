// Build: 5f5f21099e6c4dc5c041234ad3cc9c15
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
