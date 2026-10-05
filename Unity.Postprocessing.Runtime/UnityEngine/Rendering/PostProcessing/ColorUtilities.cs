using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public static class ColorUtilities
	{
		// Token: 0x060001DC RID: 476 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x582EB10", Offset = "0x582D710", VA = "0x18582EB10")]
		public static float StandardIlluminantY(float x)
		{
			return 0f;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x582E710", Offset = "0x582D310", VA = "0x18582E710")]
		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x582E930", Offset = "0x582D530", VA = "0x18582E930")]
		public static Vector3 ComputeColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x582E8C0", Offset = "0x582D4C0", VA = "0x18582E8C0")]
		public static Vector3 ColorToLift(Vector4 color)
		{
			return default(Vector3);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x582E810", Offset = "0x582D410", VA = "0x18582E810")]
		public static Vector3 ColorToInverseGamma(Vector4 color)
		{
			return default(Vector3);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x582E7A0", Offset = "0x582D3A0", VA = "0x18582E7A0")]
		public static Vector3 ColorToGain(Vector4 color)
		{
			return default(Vector3);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x582EAB0", Offset = "0x582D6B0", VA = "0x18582EAB0")]
		public static float LogCToLinear(float x)
		{
			return 0f;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x582EA60", Offset = "0x582D660", VA = "0x18582EA60")]
		public static float LinearToLogC(float x)
		{
			return 0f;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x582EB40", Offset = "0x582D740", VA = "0x18582EB40")]
		public static uint ToHex(Color c)
		{
			return 0U;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x582EBD0", Offset = "0x582D7D0", VA = "0x18582EBD0")]
		public static Color ToRGBA(uint hex)
		{
			return default(Color);
		}

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		private const float logC_cut = 0.011361f;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		private const float logC_a = 5.555556f;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		private const float logC_b = 0.047996f;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		private const float logC_c = 0.244161f;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		private const float logC_d = 0.386036f;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		private const float logC_e = 5.301883f;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		private const float logC_f = 0.092819f;
	}
}
