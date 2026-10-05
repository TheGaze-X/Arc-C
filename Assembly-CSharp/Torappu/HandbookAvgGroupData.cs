using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001097 RID: 4247
	[Token(Token = "0x2001097")]
	public class HandbookAvgGroupData
	{
		// Token: 0x06006E21 RID: 28193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookAvgGroupData()
		{
		}

		// Token: 0x04005A9D RID: 23197
		[Token(Token = "0x4005A9D")]
		[FieldOffset(Offset = "0x10")]
		public string storySetId;

		// Token: 0x04005A9E RID: 23198
		[Token(Token = "0x4005A9E")]
		[FieldOffset(Offset = "0x18")]
		public string storySetName;

		// Token: 0x04005A9F RID: 23199
		[Token(Token = "0x4005A9F")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04005AA0 RID: 23200
		[Token(Token = "0x4005AA0")]
		[FieldOffset(Offset = "0x28")]
		public long storyGetTime;

		// Token: 0x04005AA1 RID: 23201
		[Token(Token = "0x4005AA1")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemBundle> rewardItem;

		// Token: 0x04005AA2 RID: 23202
		[Token(Token = "0x4005AA2")]
		[FieldOffset(Offset = "0x38")]
		public List<HandbookUnlockParam> unlockParam;

		// Token: 0x04005AA3 RID: 23203
		[Token(Token = "0x4005AA3")]
		[FieldOffset(Offset = "0x40")]
		public List<HandbookAvgData> avgList;

		// Token: 0x04005AA4 RID: 23204
		[Token(Token = "0x4005AA4")]
		[FieldOffset(Offset = "0x48")]
		public string charId;
	}
}
