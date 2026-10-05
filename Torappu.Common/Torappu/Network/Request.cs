using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	public struct Request
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000085C4 File Offset: 0x000067C4
		[Token(Token = "0x17000155")]
		public bool isGameService
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x19233C0", Offset = "0x1921FC0", VA = "0x1819233C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x0")]
		public string serviceCode;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x8")]
		public IMsgBundle body;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x10")]
		public string overrideUrl;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x18")]
		public bool isRetry;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> header;
	}
}
