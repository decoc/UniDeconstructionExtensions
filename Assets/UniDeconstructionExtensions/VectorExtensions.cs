using UnityEngine;

namespace UniDeconstructionExtensions
{
    public static class VectorExtensions
    {
        public static void Deconstruct(this Vector2 value, out float x, out float y)
        {
            x = value.x;
            y = value.y;
        }

        public static void Deconstruct(this Vector3 value, out float x, out float y, out float z)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }

        public static void Deconstruct(this Vector4 value, out float x, out float y, out float z, out float w)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
        }

        public static void Deconstruct(this Vector2Int value, out int x, out int y)
        {
            x = value.x;
            y = value.y;
        }

        public static void Deconstruct(this Vector3Int value, out int x, out int y, out int z)
        {
            x = value.x;
            y = value.y;
            z = value.z;
        }
    }
}
