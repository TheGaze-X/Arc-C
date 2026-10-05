using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class StoryReviewUnlockInfo
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006767")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReviewUnlockInfo()
		{
		}

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003980 RID: 14720
		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0x18")]
		public long uts;

		// Token: 0x04003981 RID: 14721
		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0x20")]
		public int rc;
	}
}
