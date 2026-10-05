using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B40 RID: 15168
	[Token(Token = "0x2003B40")]
	public class SandboxV2QuestFinishPushMsg
	{
		// Token: 0x06017D59 RID: 97625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D59")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2QuestFinishPushMsg()
		{
		}

		// Token: 0x0401CC91 RID: 117905
		[Token(Token = "0x401CC91")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CC92 RID: 117906
		[Token(Token = "0x401CC92")]
		[FieldOffset(Offset = "0x18")]
		public string questId;
	}
}
