using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	internal sealed class Adler32
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x543CDF0", Offset = "0x543B9F0", VA = "0x18543CDF0")]
		internal long adler32(long adler, byte[] buf, int index, int len)
		{
			return 0L;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Adler32()
		{
		}

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		private const int BASE = 65521;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		private const int NMAX = 5552;
	}
}
