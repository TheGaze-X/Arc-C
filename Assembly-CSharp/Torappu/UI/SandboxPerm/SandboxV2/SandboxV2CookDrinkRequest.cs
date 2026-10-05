using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043C5 RID: 17349
	[Token(Token = "0x20043C5")]
	public class SandboxV2CookDrinkRequest
	{
		// Token: 0x0601A970 RID: 108912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A970")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2CookDrinkRequest()
		{
		}

		// Token: 0x04021E42 RID: 138818
		[Token(Token = "0x4021E42")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E43 RID: 138819
		[Token(Token = "0x4021E43")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2CookDrinkItem> material;

		// Token: 0x04021E44 RID: 138820
		[Token(Token = "0x4021E44")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2CookDrinkItem> food;
	}
}
