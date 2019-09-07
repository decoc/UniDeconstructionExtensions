using UnityEngine;

namespace UniDeconstructionExtensions
{
    public static class QuaternionExtensions
    {
        public static void Deconstruct(this Quaternion value, out float x, out float y, out float z, out float w)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            w = value.w;
        }

        public static (float x, float y, float z, float w) ToTuple(this Quaternion value) => (value.x, value.y, value.z, value.w);
    }
}
