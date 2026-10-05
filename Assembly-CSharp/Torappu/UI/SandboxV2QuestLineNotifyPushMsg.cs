using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B3E RID: 15166
	[Token(Token = "0x2003B3E")]
	public class SandboxV2QuestLineNotifyPushMsg
	{
		// Token: 0x06017D55 RID: 97621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D55")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2QuestLineNotifyPushMsg()
		{
		}

		// Token: 0x0401CC8C RID: 117900
		[Token(Token = "0x401CC8C")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CC8D RID: 117901
		[Token(Token = "0x401CC8D")]
		[FieldOffset(Offset = "0x18")]
		public string questLineId;
	}
}
