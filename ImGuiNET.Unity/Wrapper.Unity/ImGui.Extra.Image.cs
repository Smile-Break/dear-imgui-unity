using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using ImGuiNET.Unity;

namespace ImGuiNET
{
    using System.Numerics;
    using ImGuiUtil;

	// ImGui extra functionality related with Images
	public static partial class ImGuiUn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Image(Texture tex)
        {
            ImGui.Image((IntPtr)GetTextureId(tex), new Vector2(tex.width, tex.height));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Image(Texture tex, Vector2 size)
        {
            ImGui.Image((IntPtr)GetTextureId(tex), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Image(Sprite sprite)
        {
            SpriteInfo info = GetSpriteInfo(sprite);
            ImGui.Image((IntPtr)GetTextureId(info.texture), info.size.ToSystemVector(), info.uv0.ToSystemVector(), info.uv1.ToSystemVector());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Image(Sprite sprite, Vector2 size)
        {
            SpriteInfo info = GetSpriteInfo(sprite);
            ImGui.Image((IntPtr)GetTextureId(info.texture), size, info.uv0.ToSystemVector(), info.uv1.ToSystemVector());
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageButton(Texture tex)
        {
            ImGui.ImageButton((IntPtr)GetTextureId(tex), new Vector2(tex.width, tex.height));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageButton(Texture tex, Vector2 size)
        {
            ImGui.ImageButton((IntPtr)GetTextureId(tex), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageButton(Sprite sprite)
        {
            SpriteInfo info = GetSpriteInfo(sprite);
            ImGui.ImageButton((IntPtr)GetTextureId(info.texture), info.size.ToSystemVector(), info.uv0.ToSystemVector(), info.uv1.ToSystemVector());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageButton(Sprite sprite, Vector2 size)
        {
            SpriteInfo info = GetSpriteInfo(sprite);
            ImGui.ImageButton((IntPtr)GetTextureId(info.texture), size, info.uv0.ToSystemVector(), info.uv1.ToSystemVector());
        }
    }
}
