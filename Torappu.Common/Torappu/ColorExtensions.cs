using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public static class ColorExtensions
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x54DB1E0", Offset = "0x54D9DE0", VA = "0x1854DB1E0")]
		public static byte LinearToGamma(this byte self)
		{
			return 0;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x54DB320", Offset = "0x54D9F20", VA = "0x1854DB320")]
		public static Color32 Multiply(this Color32 c1, Color32 c2)
		{
			return default(Color32);
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] s_LinearToGammaLut;
	}
}
