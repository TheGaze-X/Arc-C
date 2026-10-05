using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004576 RID: 17782
	[Token(Token = "0x2004576")]
	public class RoguelikeTopicTaskInfo
	{
		// Token: 0x0601B145 RID: 110917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B145")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicTaskInfo()
		{
		}

		// Token: 0x04022D12 RID: 142610
		[Token(Token = "0x4022D12")]
		[FieldOffset(Offset = "0x10")]
		public string taskId;

		// Token: 0x04022D13 RID: 142611
		[Token(Token = "0x4022D13")]
		[FieldOffset(Offset = "0x18")]
		public string taskDesc;

		// Token: 0x04022D14 RID: 142612
		[Token(Token = "0x4022D14")]
		[FieldOffset(Offset = "0x20")]
		public int currProgress;

		// Token: 0x04022D15 RID: 142613
		[Token(Token = "0x4022D15")]
		[FieldOffset(Offset = "0x24")]
		public int totalProgress;
	}
}
