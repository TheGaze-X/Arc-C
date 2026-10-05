using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	internal class SecP521R1Field
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x51F5CE0", Offset = "0x51F48E0", VA = "0x1851F5CE0")]
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x51F5C00", Offset = "0x51F4800", VA = "0x1851F5C00")]
		public static void AddOne(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x51F5DF0", Offset = "0x51F49F0", VA = "0x1851F5DF0")]
		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x51F5E80", Offset = "0x51F4A80", VA = "0x1851F5E80")]
		public static void Half(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x51F6040", Offset = "0x51F4C40", VA = "0x1851F6040")]
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x51F6150", Offset = "0x51F4D50", VA = "0x1851F6150")]
		public static void Negate(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x51F62F0", Offset = "0x51F4EF0", VA = "0x1851F62F0")]
		public static void Reduce(uint[] xx, uint[] z)
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x51F6200", Offset = "0x51F4E00", VA = "0x1851F6200")]
		public static void Reduce23(uint[] z)
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x51F6590", Offset = "0x51F5190", VA = "0x1851F6590")]
		public static void Square(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x51F6410", Offset = "0x51F5010", VA = "0x1851F6410")]
		public static void SquareN(uint[] x, int n, uint[] z)
		{
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x51F6670", Offset = "0x51F5270", VA = "0x1851F6670")]
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x51F6710", Offset = "0x51F5310", VA = "0x1851F6710")]
		public static void Twice(uint[] x, uint[] z)
		{
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x51F5EF0", Offset = "0x51F4AF0", VA = "0x1851F5EF0")]
		protected static void ImplMultiply(uint[] x, uint[] y, uint[] zz)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x51F5FB0", Offset = "0x51F4BB0", VA = "0x1851F5FB0")]
		protected static void ImplSquare(uint[] x, uint[] zz)
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SecP521R1Field()
		{
		}

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] P;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		private const int P16 = 511;
	}
}
