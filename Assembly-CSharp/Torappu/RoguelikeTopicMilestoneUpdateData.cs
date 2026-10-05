using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011E9 RID: 4585
	[Token(Token = "0x20011E9")]
	public class RoguelikeTopicMilestoneUpdateData
	{
		// Token: 0x06006FD7 RID: 28631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicMilestoneUpdateData()
		{
		}

		// Token: 0x0400627E RID: 25214
		[Token(Token = "0x400627E")]
		[FieldOffset(Offset = "0x10")]
		public long updateTime;

		// Token: 0x0400627F RID: 25215
		[Token(Token = "0x400627F")]
		[FieldOffset(Offset = "0x18")]
		public long endTime;

		// Token: 0x04006280 RID: 25216
		[Token(Token = "0x4006280")]
		[FieldOffset(Offset = "0x20")]
		public int maxBpLevel;

		// Token: 0x04006281 RID: 25217
		[Token(Token = "0x4006281")]
		[FieldOffset(Offset = "0x24")]
		public int maxBpCount;

		// Token: 0x04006282 RID: 25218
		[Token(Token = "0x4006282")]
		[FieldOffset(Offset = "0x28")]
		public int maxDisplayBpCount;
	}
}
