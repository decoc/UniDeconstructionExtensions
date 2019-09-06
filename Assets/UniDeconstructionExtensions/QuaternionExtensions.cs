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
    }
}
