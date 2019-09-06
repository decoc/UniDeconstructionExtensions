using UnityEngine;

namespace UniDeconstructionExtensions
{
    public static class ColorExtensions
    {
        public static void Deconstruct(this Color value, out float r, out float g, out float b)
        {
            r = value.r;
            g = value.g;
            b = value.b;
        }

        public static void Deconstruct(this Color value, out float r, out float g, out float b, out float a)
        {
            r = value.r;
            g = value.g;
            b = value.b;
            a = value.a;
        }

        public static void Deconstruct(this Color32 value, out float r, out float g, out float b)
        {
            r = value.r;
            g = value.g;
            b = value.b;
        }

        public static void Deconstruct(this Color32 value, out float r, out float g, out float b, out float a)
        {
            r = value.r;
            g = value.g;
            b = value.b;
            a = value.a;
        }
    }
}