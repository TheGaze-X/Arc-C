using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D4 RID: 17364
	[Token(Token = "0x20043D4")]
	public class SandboxV2ExpeditionRequest
	{
		// Token: 0x0601A97F RID: 108927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A97F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ExpeditionRequest()
		{
		}

		// Token: 0x04021E67 RID: 138855
		[Token(Token = "0x4021E67")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E68 RID: 138856
		[Token(Token = "0x4021E68")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021E69 RID: 138857
		[Token(Token = "0x4021E69")]
		[FieldOffset(Offset = "0x20")]
		public string eventId;

		// Token: 0x04021E6A RID: 138858
		[Token(Token = "0x4021E6A")]
		[FieldOffset(Offset = "0x28")]
		public string choiceId;

		// Token: 0x04021E6B RID: 138859
		[Token(Token = "0x4021E6B")]
		[FieldOffset(Offset = "0x30")]
		public List<int> charList;
	}
}
