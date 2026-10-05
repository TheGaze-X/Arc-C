using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011FA RID: 4602
	[Token(Token = "0x20011FA")]
	public class RoguelikeTopicChallengeTask
	{
		// Token: 0x06006FE9 RID: 28649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicChallengeTask()
		{
		}

		// Token: 0x040062F6 RID: 25334
		[Token(Token = "0x40062F6")]
		[FieldOffset(Offset = "0x10")]
		public string taskId;

		// Token: 0x040062F7 RID: 25335
		[Token(Token = "0x40062F7")]
		[FieldOffset(Offset = "0x18")]
		public string taskDes;

		// Token: 0x040062F8 RID: 25336
		[Token(Token = "0x40062F8")]
		[FieldOffset(Offset = "0x20")]
		public string completionClass;

		// Token: 0x040062F9 RID: 25337
		[Token(Token = "0x40062F9")]
		[FieldOffset(Offset = "0x28")]
		public string[] completionParams;
	}
}
