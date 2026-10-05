using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	internal static class Marvin
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x4CDB590", Offset = "0x4CDA190", VA = "0x184CDB590")]
		[MethodImpl(256)]
		public static int ComputeHash32(System.ReadOnlySpan<byte> data, ulong seed)
		{
			return 0;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x4CDB630", Offset = "0x4CDA230", VA = "0x184CDB630")]
		public static int ComputeHash32(ref byte data, int count, ulong seed)
		{
			return 0;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x4CDB4F0", Offset = "0x4CDA0F0", VA = "0x184CDB4F0")]
		[MethodImpl(256)]
		private static void Block(ref uint rp0, ref uint rp1)
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		[MethodImpl(256)]
		private static uint _rotl(uint value, int shift)
		{
			return 0U;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x1700009B")]
		public static ulong DefaultSeed
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x4CDBB40", Offset = "0x4CDA740", VA = "0x184CDBB40")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x4CDBAF0", Offset = "0x4CDA6F0", VA = "0x184CDBAF0")]
		private static ulong GenerateSeed()
		{
			return 0UL;
		}
	}
}
