using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public sealed class JZlib
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x54650B0", Offset = "0x5463CB0", VA = "0x1854650B0")]
		public static string version()
		{
			return null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JZlib()
		{
		}

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		private const string _version = "1.0.7";

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		public const int Z_NO_COMPRESSION = 0;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		public const int Z_BEST_SPEED = 1;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		public const int Z_BEST_COMPRESSION = 9;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		public const int Z_DEFAULT_COMPRESSION = -1;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		public const int Z_FILTERED = 1;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		public const int Z_HUFFMAN_ONLY = 2;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		public const int Z_DEFAULT_STRATEGY = 0;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		public const int Z_NO_FLUSH = 0;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		public const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		public const int Z_SYNC_FLUSH = 2;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		public const int Z_FULL_FLUSH = 3;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		public const int Z_FINISH = 4;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		public const int Z_OK = 0;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		public const int Z_STREAM_END = 1;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		public const int Z_NEED_DICT = 2;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		public const int Z_ERRNO = -1;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		public const int Z_STREAM_ERROR = -2;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		public const int Z_DATA_ERROR = -3;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		public const int Z_MEM_ERROR = -4;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		public const int Z_BUF_ERROR = -5;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		public const int Z_VERSION_ERROR = -6;
	}
}
