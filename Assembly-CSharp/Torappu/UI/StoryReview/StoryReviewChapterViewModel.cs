using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048FE RID: 18686
	[Token(Token = "0x20048FE")]
	public class StoryReviewChapterViewModel : IHotfixable
	{
		// Token: 0x0601C30A RID: 115466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C30A")]
		[Address(RVA = "0x15A30C0", Offset = "0x15A1CC0", VA = "0x1815A30C0")]
		public StoryReviewChapterViewModel()
		{
		}

		// Token: 0x04024D76 RID: 150902
		[Token(Token = "0x4024D76")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04024D77 RID: 150903
		[Token(Token = "0x4024D77")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04024D78 RID: 150904
		[Token(Token = "0x4024D78")]
		[FieldOffset(Offset = "0x20")]
		public StoryReviewEntryType entryType;

		// Token: 0x04024D79 RID: 150905
		[Token(Token = "0x4024D79")]
		[FieldOffset(Offset = "0x24")]
		public StoryReviewType actType;

		// Token: 0x04024D7A RID: 150906
		[Token(Token = "0x4024D7A")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x04024D7B RID: 150907
		[Token(Token = "0x4024D7B")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x04024D7C RID: 150908
		[Token(Token = "0x4024D7C")]
		[FieldOffset(Offset = "0x38")]
		public long remakeStartTime;

		// Token: 0x04024D7D RID: 150909
		[Token(Token = "0x4024D7D")]
		[FieldOffset(Offset = "0x40")]
		public long remakeEndTime;

		// Token: 0x04024D7E RID: 150910
		[Token(Token = "0x4024D7E")]
		[FieldOffset(Offset = "0x48")]
		public string storyEntryPicId;

		// Token: 0x04024D7F RID: 150911
		[Token(Token = "0x4024D7F")]
		[FieldOffset(Offset = "0x50")]
		public string storyPicId;

		// Token: 0x04024D80 RID: 150912
		[Token(Token = "0x4024D80")]
		[FieldOffset(Offset = "0x58")]
		public string storyMainColor;

		// Token: 0x04024D81 RID: 150913
		[Token(Token = "0x4024D81")]
		[FieldOffset(Offset = "0x60")]
		public StoryReviewCustomType customType;

		// Token: 0x04024D82 RID: 150914
		[Token(Token = "0x4024D82")]
		[FieldOffset(Offset = "0x68")]
		public string storyCompleteMedalId;

		// Token: 0x04024D83 RID: 150915
		[Token(Token = "0x4024D83")]
		[FieldOffset(Offset = "0x70")]
		public ItemBundle[] rewards;

		// Token: 0x04024D84 RID: 150916
		[Token(Token = "0x4024D84")]
		[FieldOffset(Offset = "0x78")]
		public List<StoryReviewViewModel> storyReviewList;

		// Token: 0x04024D85 RID: 150917
		[Token(Token = "0x4024D85")]
		[FieldOffset(Offset = "0x80")]
		public bool rewardGot;

		// Token: 0x04024D86 RID: 150918
		[Token(Token = "0x4024D86")]
		[FieldOffset(Offset = "0x84")]
		public int progress;

		// Token: 0x04024D87 RID: 150919
		[Token(Token = "0x4024D87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
