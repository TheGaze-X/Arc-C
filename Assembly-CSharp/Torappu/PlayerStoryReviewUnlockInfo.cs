using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class PlayerStoryReviewUnlockInfo
	{
		// Token: 0x06006766 RID: 26470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006766")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerStoryReviewUnlockInfo()
		{
		}

		// Token: 0x0400397C RID: 14716
		[Token(Token = "0x400397C")]
		[FieldOffset(Offset = "0x10")]
		public long rts;

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x18")]
		public List<StoryReviewUnlockInfo> stories;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x20")]
		public List<string> trailRewards;
	}
}
