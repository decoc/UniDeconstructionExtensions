using UnityEngine;

namespace UniDeconstructionExtensions
{
    public static class RectExtensions
    {
        public static void Deconstruction(this Rect value, out Vector2 position, out Vector2 size)
        {
            position = value.position;
            size = value.size;
        }

        public static void Deconstruction(this Rect value, out float x, out float y, float width, float height)
        {
            x = value.x;
            y = value.y;
            width = value.width;
            height = value.height;
        }
    }
}
