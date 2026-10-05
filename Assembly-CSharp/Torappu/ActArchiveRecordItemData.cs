using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C43 RID: 3139
	[Token(Token = "0x2000C43")]
	public class ActArchiveRecordItemData
	{
		// Token: 0x06006923 RID: 26915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006923")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveRecordItemData()
		{
		}

		// Token: 0x04004009 RID: 16393
		[Token(Token = "0x4004009")]
		[FieldOffset(Offset = "0x10")]
		public string storyId;

		// Token: 0x0400400A RID: 16394
		[Token(Token = "0x400400A")]
		[FieldOffset(Offset = "0x18")]
		public int innerSortId;

		// Token: 0x0400400B RID: 16395
		[Token(Token = "0x400400B")]
		[FieldOffset(Offset = "0x20")]
		public string chatDesc;

		// Token: 0x0400400C RID: 16396
		[Token(Token = "0x400400C")]
		[FieldOffset(Offset = "0x28")]
		public string unlockDesc;

		// Token: 0x0400400D RID: 16397
		[Token(Token = "0x400400D")]
		[FieldOffset(Offset = "0x30")]
		public string textId;

		// Token: 0x0400400E RID: 16398
		[Token(Token = "0x400400E")]
		[FieldOffset(Offset = "0x38")]
		public int unlockFloor;
	}
}
