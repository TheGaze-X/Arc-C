using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	internal abstract class Mod
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x547B880", Offset = "0x547A480", VA = "0x18547B880")]
		public static void Invert(uint[] p, uint[] x, uint[] z)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x547BFC0", Offset = "0x547ABC0", VA = "0x18547BFC0")]
		public static uint[] Random(uint[] p)
		{
			return null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x547B450", Offset = "0x547A050", VA = "0x18547B450")]
		public static void Add(uint[] p, uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x547C190", Offset = "0x547AD90", VA = "0x18547C190")]
		public static void Subtract(uint[] p, uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x547B570", Offset = "0x547A170", VA = "0x18547B570")]
		private static void InversionResult(uint[] p, int ac, uint[] a, uint[] z)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x547B620", Offset = "0x547A220", VA = "0x18547B620")]
		private static void InversionStep(uint[] p, uint[] u, int uLen, uint[] x, ref int xc)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x547B550", Offset = "0x547A150", VA = "0x18547B550")]
		private static int GetTrailingZeroes(uint x)
		{
			return 0;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Mod()
		{
		}

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SecureRandom RandomSource;
	}
}
