using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	internal abstract class Interleave
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x547B370", Offset = "0x5479F70", VA = "0x18547B370")]
		internal static uint Expand8to16(uint x)
		{
			return 0U;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x547B1B0", Offset = "0x5479DB0", VA = "0x18547B1B0")]
		internal static uint Expand16to32(uint x)
		{
			return 0U;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x547B1F0", Offset = "0x5479DF0", VA = "0x18547B1F0")]
		internal static ulong Expand32to64(uint x)
		{
			return 0UL;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x547B270", Offset = "0x5479E70", VA = "0x18547B270")]
		internal static void Expand64To128(ulong x, ulong[] z, int zOff)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x547B3A0", Offset = "0x5479FA0", VA = "0x18547B3A0")]
		internal static ulong Unshuffle(ulong x)
		{
			return 0UL;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Interleave()
		{
		}

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		private const ulong M32 = 1431655765UL;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		private const ulong M64 = 6148914691236517205UL;
	}
}
