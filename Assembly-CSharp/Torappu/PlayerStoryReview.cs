using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA6 RID: 2726
	[Token(Token = "0x2000AA6")]
	public class PlayerStoryReview
	{
		// Token: 0x06006765 RID: 26469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006765")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerStoryReview()
		{
		}

		// Token: 0x0400397A RID: 14714
		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerStoryReviewUnlockInfo> groups;

		// Token: 0x0400397B RID: 14715
		[Token(Token = "0x400397B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> tags;
	}
}
