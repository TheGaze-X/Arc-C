using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001137 RID: 4407
	[Token(Token = "0x2001137")]
	[Serializable]
	public class RetroTrailRewardItem
	{
		// Token: 0x06006F0D RID: 28429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroTrailRewardItem()
		{
		}

		// Token: 0x04005E70 RID: 24176
		[Token(Token = "0x4005E70")]
		[FieldOffset(Offset = "0x10")]
		public string trailRewardId;

		// Token: 0x04005E71 RID: 24177
		[Token(Token = "0x4005E71")]
		[FieldOffset(Offset = "0x18")]
		public int starCount;

		// Token: 0x04005E72 RID: 24178
		[Token(Token = "0x4005E72")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;
	}
}
