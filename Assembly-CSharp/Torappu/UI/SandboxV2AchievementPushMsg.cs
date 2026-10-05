using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B4E RID: 15182
	[Token(Token = "0x2003B4E")]
	public class SandboxV2AchievementPushMsg
	{
		// Token: 0x06017D74 RID: 97652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D74")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AchievementPushMsg()
		{
		}

		// Token: 0x0401CCB2 RID: 117938
		[Token(Token = "0x401CCB2")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CCB3 RID: 117939
		[Token(Token = "0x401CCB3")]
		[FieldOffset(Offset = "0x18")]
		public string achievementId;
	}
}
