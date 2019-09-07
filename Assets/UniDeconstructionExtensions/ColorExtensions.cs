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

        public static (float r, float g, float b, float a) ToTuple(this Color value) => (value.r, value.g, value.b, value.a);

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

        public static (float r, float g, float b, float a) ToTuple(this Color32 value) => (value.r, value.g, value.b, value.a);
    }
}