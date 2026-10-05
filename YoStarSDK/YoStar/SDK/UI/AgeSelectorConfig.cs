using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.UI
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public class AgeSelectorConfig
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x5C3EFD0", Offset = "0x5C3DBD0", VA = "0x185C3EFD0")]
		public AgeSelectorConfig()
		{
		}

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x10")]
		public bool isPay;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x11")]
		public bool isCallback;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> eventParam;
	}
}
