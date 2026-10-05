using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.LZW
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public sealed class LzwConstants
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private LzwConstants()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		public const int MAGIC = 8093;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		public const int MAX_BITS = 16;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		public const int BIT_MASK = 31;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		public const int EXTENDED_MASK = 32;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		public const int RESERVED_MASK = 96;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		public const int BLOCK_MODE_MASK = 128;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		public const int HDR_SIZE = 3;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		public const int INIT_BITS = 9;
	}
}
