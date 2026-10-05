using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	public static class ZlibConstants
	{
		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		public const int WindowBitsMax = 15;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		public const int WindowBitsDefault = 15;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		public const int Z_OK = 0;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		public const int Z_STREAM_END = 1;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		public const int Z_NEED_DICT = 2;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		public const int Z_STREAM_ERROR = -2;

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		public const int Z_DATA_ERROR = -3;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		public const int Z_BUF_ERROR = -5;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		public const int WorkingBufferSizeDefault = 16384;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		public const int WorkingBufferSizeMin = 1024;
	}
}
