using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043C7 RID: 17351
	[Token(Token = "0x20043C7")]
	public class SandboxV2CookFoodRequest
	{
		// Token: 0x0601A972 RID: 108914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A972")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2CookFoodRequest()
		{
		}

		// Token: 0x04021E46 RID: 138822
		[Token(Token = "0x4021E46")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E47 RID: 138823
		[Token(Token = "0x4021E47")]
		[FieldOffset(Offset = "0x18")]
		public List<string> main;

		// Token: 0x04021E48 RID: 138824
		[Token(Token = "0x4021E48")]
		[FieldOffset(Offset = "0x20")]
		public List<string> sub;

		// Token: 0x04021E49 RID: 138825
		[Token(Token = "0x4021E49")]
		[FieldOffset(Offset = "0x28")]
		public int count;
	}
}
