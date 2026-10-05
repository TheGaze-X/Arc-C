using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043E2 RID: 17378
	[Token(Token = "0x20043E2")]
	public class SandboxV2SetSquadRequest
	{
		// Token: 0x0601A98C RID: 108940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A98C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2SetSquadRequest()
		{
		}

		// Token: 0x04021E83 RID: 138883
		[Token(Token = "0x4021E83")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E84 RID: 138884
		[Token(Token = "0x4021E84")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x04021E85 RID: 138885
		[Token(Token = "0x4021E85")]
		[FieldOffset(Offset = "0x20")]
		public List<RequestSquadSlot> slots;

		// Token: 0x04021E86 RID: 138886
		[Token(Token = "0x4021E86")]
		[FieldOffset(Offset = "0x28")]
		public List<string> tools;
	}
}
