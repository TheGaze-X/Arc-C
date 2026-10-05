using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048FB RID: 18683
	[Token(Token = "0x20048FB")]
	public class StoryReviewGroupViewModel : IHotfixable
	{
		// Token: 0x0601C2FB RID: 115451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2FB")]
		[Address(RVA = "0x15A4A80", Offset = "0x15A3680", VA = "0x1815A4A80")]
		public StoryReviewChapterViewModel FindReviewChapter(string chapterId)
		{
			return null;
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2FC")]
		[Address(RVA = "0x15A4CD0", Offset = "0x15A38D0", VA = "0x1815A4CD0")]
		public List<StoryReviewChapterViewModel> LoadDataByEntry(StoryReviewEntryType entry)
		{
			return null;
		}

		// Token: 0x0601C2FD RID: 115453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2FD")]
		[Address(RVA = "0x15A4EE0", Offset = "0x15A3AE0", VA = "0x1815A4EE0")]
		public void LoadData(PlayerStoryReview playerReview)
		{
		}

		// Token: 0x0601C2FE RID: 115454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2FE")]
		[Address(RVA = "0x15A4B90", Offset = "0x15A3790", VA = "0x1815A4B90")]
		public List<string> GetActiveActIdList()
		{
			return null;
		}

		// Token: 0x0601C2FF RID: 115455 RVA: 0x000A77C0 File Offset: 0x000A59C0
		[Token(Token = "0x601C2FF")]
		[Address(RVA = "0x15A5420", Offset = "0x15A4020", VA = "0x1815A5420")]
		private bool _ChapterShow(long startShow, long endShow)
		{
			return default(bool);
		}

		// Token: 0x0601C300 RID: 115456 RVA: 0x000A77D8 File Offset: 0x000A59D8
		[Token(Token = "0x601C300")]
		[Address(RVA = "0x15A5590", Offset = "0x15A4190", VA = "0x1815A5590")]
		private bool _GenRewardsStatus(string chapterId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0601C301 RID: 115457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C301")]
		[Address(RVA = "0x15A5690", Offset = "0x15A4290", VA = "0x1815A5690")]
		private List<StoryReviewViewModel> _GenViewModels(List<StoryReviewInfoClientData> infoClientDatas, PlayerStoryReview review)
		{
			return null;
		}

		// Token: 0x0601C302 RID: 115458 RVA: 0x000A77F0 File Offset: 0x000A59F0
		[Token(Token = "0x601C302")]
		[Address(RVA = "0x15A5CA0", Offset = "0x15A48A0", VA = "0x1815A5CA0")]
		private bool _GetStoryReviewUnlocked(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0601C303 RID: 115459 RVA: 0x000A7808 File Offset: 0x000A5A08
		[Token(Token = "0x601C303")]
		[Address(RVA = "0x15A5AF0", Offset = "0x15A46F0", VA = "0x1815A5AF0")]
		private bool _GetStoryReviewRead(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0601C304 RID: 115460 RVA: 0x000A7820 File Offset: 0x000A5A20
		[Token(Token = "0x601C304")]
		[Address(RVA = "0x15A59E0", Offset = "0x15A45E0", VA = "0x1815A59E0")]
		private int _GetProgress(PlayerStoryReview review, string chapterId)
		{
			return 0;
		}

		// Token: 0x0601C305 RID: 115461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C305")]
		[Address(RVA = "0x15A5380", Offset = "0x15A3F80", VA = "0x1815A5380")]
		public void OnStoryReviewPlayerStatusChanged()
		{
		}

		// Token: 0x0601C306 RID: 115462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C306")]
		[Address(RVA = "0x15A5E30", Offset = "0x15A4A30", VA = "0x1815A5E30")]
		public StoryReviewGroupViewModel()
		{
		}

		// Token: 0x04024D55 RID: 150869
		[Token(Token = "0x4024D55")]
		[FieldOffset(Offset = "0x10")]
		public List<StoryReviewChapterViewModel> storyReviewChapterList;

		// Token: 0x04024D56 RID: 150870
		[Token(Token = "0x4024D56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindReviewChapter;

		// Token: 0x04024D57 RID: 150871
		[Token(Token = "0x4024D57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataByEntry;

		// Token: 0x04024D58 RID: 150872
		[Token(Token = "0x4024D58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024D59 RID: 150873
		[Token(Token = "0x4024D59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetActiveActIdList;

		// Token: 0x04024D5A RID: 150874
		[Token(Token = "0x4024D5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ChapterShow;

		// Token: 0x04024D5B RID: 150875
		[Token(Token = "0x4024D5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenRewardsStatus;

		// Token: 0x04024D5C RID: 150876
		[Token(Token = "0x4024D5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenViewModels;

		// Token: 0x04024D5D RID: 150877
		[Token(Token = "0x4024D5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetStoryReviewUnlocked;

		// Token: 0x04024D5E RID: 150878
		[Token(Token = "0x4024D5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetStoryReviewRead;

		// Token: 0x04024D5F RID: 150879
		[Token(Token = "0x4024D5F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetProgress;

		// Token: 0x04024D60 RID: 150880
		[Token(Token = "0x4024D60")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnStoryReviewPlayerStatusChanged;

		// Token: 0x04024D61 RID: 150881
		[Token(Token = "0x4024D61")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
