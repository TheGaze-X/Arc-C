using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public static class UnityExtensions
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x54F9C80", Offset = "0x54F8880", VA = "0x1854F9C80")]
		public static Vector2 AdvancedWorldToViewportPoint(this Camera camera, Vector3 position)
		{
			return default(Vector2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x54F9EC0", Offset = "0x54F8AC0", VA = "0x1854F9EC0")]
		public static float CalculateFarPlaneWorldSpaceLength(this Camera camera)
		{
			return 0f;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x54FA070", Offset = "0x54F8C70", VA = "0x1854FA070")]
		public static float GetAnimationTime(this Animation animation, string name)
		{
			return 0f;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x54FA170", Offset = "0x54F8D70", VA = "0x1854FA170")]
		public static void SetPositionZ(this Transform transform, float z)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x54FA110", Offset = "0x54F8D10", VA = "0x1854FA110")]
		public static void SetLocalPositionZ(this Transform transform, float z)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x54F9DA0", Offset = "0x54F89A0", VA = "0x1854F9DA0")]
		public static Matrix4x4 CalcLocalToWorldMatrixNoScale(this Transform transform)
		{
			return default(Matrix4x4);
		}
	}
}
