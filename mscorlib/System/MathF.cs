using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public static class MathF
	{
		// Token: 0x060008D0 RID: 2256 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4CDBB90", Offset = "0x4CDA790", VA = "0x184CDBB90")]
		[MethodImpl(256)]
		public static float Abs(float x)
		{
			return 0f;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x4CDBCC0", Offset = "0x4CDA8C0", VA = "0x184CDBCC0")]
		[Intrinsic]
		public static float Round(float x)
		{
			return 0f;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x4CDBE40", Offset = "0x4CDAA40", VA = "0x184CDBE40")]
		[MethodImpl(256)]
		public static int Sign(float x)
		{
			return 0;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x4CDBBF0", Offset = "0x4CDA7F0", VA = "0x184CDBBF0")]
		private static float CopySign(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060008D4 RID: 2260
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x4CDBCB0", Offset = "0x4CDA8B0", VA = "0x184CDBCB0")]
		[MethodImpl(4096)]
		public static extern float Floor(float x);

		// Token: 0x060008D5 RID: 2261
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x4CDBCA0", Offset = "0x4CDA8A0", VA = "0x184CDBCA0")]
		[MethodImpl(4096)]
		private static extern float FMod(float x, float y);

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x0")]
		private static float[] roundPower10Single;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x8")]
		private static float singleRoundLimit;
	}
}
