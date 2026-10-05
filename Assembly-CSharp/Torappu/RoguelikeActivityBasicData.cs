using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001155 RID: 4437
	[Token(Token = "0x2001155")]
	public class RoguelikeActivityBasicData
	{
		// Token: 0x06006F2F RID: 28463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeActivityBasicData()
		{
		}

		// Token: 0x04005F0F RID: 24335
		[Token(Token = "0x4005F0F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005F10 RID: 24336
		[Token(Token = "0x4005F10")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeActivityType type;

		// Token: 0x04005F11 RID: 24337
		[Token(Token = "0x4005F11")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x04005F12 RID: 24338
		[Token(Token = "0x4005F12")]
		[FieldOffset(Offset = "0x28")]
		public long endTime;

		// Token: 0x04005F13 RID: 24339
		[Token(Token = "0x4005F13")]
		[FieldOffset(Offset = "0x30")]
		public bool isPresentSeedMode;

		// Token: 0x04005F14 RID: 24340
		[Token(Token = "0x4005F14")]
		[FieldOffset(Offset = "0x31")]
		public bool isUnlockBadge;

		// Token: 0x04005F15 RID: 24341
		[Token(Token = "0x4005F15")]
		[FieldOffset(Offset = "0x34")]
		public RoguelikeTopicMode validMode;
	}
}
