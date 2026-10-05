using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	public sealed class Adler
	{
		// Token: 0x060029F3 RID: 10739 RVA: 0x00011D30 File Offset: 0x0000FF30
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x53B63D0", Offset = "0x53B4FD0", VA = "0x1853B63D0")]
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			return 0U;
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Adler()
		{
		}

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint BASE;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int NMAX;
	}
}
