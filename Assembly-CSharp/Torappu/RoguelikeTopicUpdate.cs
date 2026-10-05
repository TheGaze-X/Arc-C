using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011E7 RID: 4583
	[Token(Token = "0x20011E7")]
	public class RoguelikeTopicUpdate
	{
		// Token: 0x06006FD5 RID: 28629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicUpdate()
		{
		}

		// Token: 0x04006277 RID: 25207
		[Token(Token = "0x4006277")]
		[FieldOffset(Offset = "0x10")]
		public string updateId;

		// Token: 0x04006278 RID: 25208
		[Token(Token = "0x4006278")]
		[FieldOffset(Offset = "0x18")]
		public long topicUpdateTime;

		// Token: 0x04006279 RID: 25209
		[Token(Token = "0x4006279")]
		[FieldOffset(Offset = "0x20")]
		public long topicEndTime;
	}
}
