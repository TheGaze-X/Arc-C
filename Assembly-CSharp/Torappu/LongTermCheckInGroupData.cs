using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010DC RID: 4316
	[Token(Token = "0x20010DC")]
	public class LongTermCheckInGroupData : IComparable
	{
		// Token: 0x06006E7F RID: 28287 RVA: 0x00032130 File Offset: 0x00030330
		[Token(Token = "0x6006E7F")]
		[Address(RVA = "0x2106C50", Offset = "0x2105850", VA = "0x182106C50", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E80")]
		[Address(RVA = "0x2106D20", Offset = "0x2105920", VA = "0x182106D20")]
		public LongTermCheckInGroupData()
		{
		}

		// Token: 0x04005C75 RID: 23669
		[Token(Token = "0x4005C75")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005C76 RID: 23670
		[Token(Token = "0x4005C76")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005C77 RID: 23671
		[Token(Token = "0x4005C77")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005C78 RID: 23672
		[Token(Token = "0x4005C78")]
		[FieldOffset(Offset = "0x28")]
		public int level;

		// Token: 0x04005C79 RID: 23673
		[Token(Token = "0x4005C79")]
		[FieldOffset(Offset = "0x2C")]
		public int days;

		// Token: 0x04005C7A RID: 23674
		[Token(Token = "0x4005C7A")]
		[FieldOffset(Offset = "0x30")]
		public string bkgImgId;

		// Token: 0x04005C7B RID: 23675
		[Token(Token = "0x4005C7B")]
		[FieldOffset(Offset = "0x38")]
		public string titleImgId;

		// Token: 0x04005C7C RID: 23676
		[Token(Token = "0x4005C7C")]
		[FieldOffset(Offset = "0x40")]
		public string tipText;

		// Token: 0x04005C7D RID: 23677
		[Token(Token = "0x4005C7D")]
		[FieldOffset(Offset = "0x48")]
		public string bottomText;

		// Token: 0x04005C7E RID: 23678
		[Token(Token = "0x4005C7E")]
		[FieldOffset(Offset = "0x50")]
		public List<ItemBundle> rewardList;
	}
}
