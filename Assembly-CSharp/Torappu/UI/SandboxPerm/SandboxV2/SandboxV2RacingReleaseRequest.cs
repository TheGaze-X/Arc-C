using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043B7 RID: 17335
	[Token(Token = "0x20043B7")]
	public class SandboxV2RacingReleaseRequest
	{
		// Token: 0x0601A962 RID: 108898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A962")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacingReleaseRequest()
		{
		}

		// Token: 0x04021E2F RID: 138799
		[Token(Token = "0x4021E2F")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E30 RID: 138800
		[Token(Token = "0x4021E30")]
		[FieldOffset(Offset = "0x18")]
		public List<string> instIds;

		// Token: 0x04021E31 RID: 138801
		[Token(Token = "0x4021E31")]
		[FieldOffset(Offset = "0x20")]
		public bool tmp;
	}
}
