using System;

namespace ImGuiUtil
{
	public static class VectorExtensions
	{
		public static System.Numerics.Vector2 ToSystemVector(this UnityEngine.Vector2 v) => new System.Numerics.Vector2(v.x, v.y);
		public static System.Numerics.Vector3 ToSystemVector(this UnityEngine.Vector3 v) => new System.Numerics.Vector3(v.x, v.y, v.z);
		public static System.Numerics.Vector4 ToSystemVector(this UnityEngine.Vector4 v) => new System.Numerics.Vector4(v.x, v.y, v.z, v.w);

		public static UnityEngine.Vector2 ToUnityVector(this System.Numerics.Vector2 v) => new UnityEngine.Vector2(v.X, v.Y);
		public static UnityEngine.Vector3 ToUnityVector(this System.Numerics.Vector3 v) => new UnityEngine.Vector3(v.X, v.Y, v.Z);
		public static UnityEngine.Vector4 ToUnityVector(this System.Numerics.Vector4 v) => new UnityEngine.Vector4(v.X, v.Y, v.Z, v.W);
	}
}
