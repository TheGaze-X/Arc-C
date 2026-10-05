using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.StoryReview;

namespace Torappu.Activity
{
	// Token: 0x02006D9D RID: 28061
	[Token(Token = "0x2006D9D")]
	public class ActCommonMiniStoryViewModel
	{
		// Token: 0x06027F78 RID: 163704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F78")]
		[Address(RVA = "0x2330950", Offset = "0x232F550", VA = "0x182330950")]
		public void LoadData(PlayerStoryReview playerData, string activityId)
		{
		}

		// Token: 0x06027F79 RID: 163705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F79")]
		[Address(RVA = "0x2330820", Offset = "0x232F420", VA = "0x182330820")]
		public StoryReviewViewModel GetStoryReviewModel(string storyId)
		{
			return null;
		}

		// Token: 0x06027F7A RID: 163706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F7A")]
		[Address(RVA = "0x2330EC0", Offset = "0x232FAC0", VA = "0x182330EC0")]
		public void RefreshAvailableViewModelList()
		{
		}

		// Token: 0x06027F7B RID: 163707 RVA: 0x000D02D8 File Offset: 0x000CE4D8
		[Token(Token = "0x6027F7B")]
		[Address(RVA = "0x23311A0", Offset = "0x232FDA0", VA = "0x1823311A0")]
		private bool _CheckPrevDependenceUnlocked(string dependId)
		{
			return default(bool);
		}

		// Token: 0x06027F7C RID: 163708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F7C")]
		[Address(RVA = "0x23319D0", Offset = "0x23305D0", VA = "0x1823319D0")]
		private void _RefreshPlayerData(StoryReviewChapterViewModel chapter, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x06027F7D RID: 163709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F7D")]
		[Address(RVA = "0x2331270", Offset = "0x232FE70", VA = "0x182331270")]
		private void _GenStoryReviewViewModel(ref StoryReviewViewModel viewModel, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x06027F7E RID: 163710 RVA: 0x000D02F0 File Offset: 0x000CE4F0
		[Token(Token = "0x6027F7E")]
		[Address(RVA = "0x2331090", Offset = "0x232FC90", VA = "0x182331090")]
		private bool _ChapterShow(long startShow, long endShow)
		{
			return default(bool);
		}

		// Token: 0x06027F7F RID: 163711 RVA: 0x000D0308 File Offset: 0x000CE508
		[Token(Token = "0x6027F7F")]
		[Address(RVA = "0x23311D0", Offset = "0x232FDD0", VA = "0x1823311D0")]
		private bool _GenRewardsStatus(string chapterId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x06027F80 RID: 163712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F80")]
		[Address(RVA = "0x2331380", Offset = "0x232FF80", VA = "0x182331380")]
		private List<StoryReviewViewModel> _GenViewModels(List<StoryReviewInfoClientData> infoClientDatas, PlayerStoryReview review)
		{
			return null;
		}

		// Token: 0x06027F81 RID: 163713 RVA: 0x000D0320 File Offset: 0x000CE520
		[Token(Token = "0x6027F81")]
		[Address(RVA = "0x23318A0", Offset = "0x23304A0", VA = "0x1823318A0")]
		private bool _GetStoryReviewUnlocked(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x06027F82 RID: 163714 RVA: 0x000D0338 File Offset: 0x000CE538
		[Token(Token = "0x6027F82")]
		[Address(RVA = "0x2331740", Offset = "0x2330340", VA = "0x182331740")]
		private bool _GetStoryReviewRead(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x06027F83 RID: 163715 RVA: 0x000D0350 File Offset: 0x000CE550
		[Token(Token = "0x6027F83")]
		[Address(RVA = "0x2331690", Offset = "0x2330290", VA = "0x182331690")]
		private int _GetProgress(PlayerStoryReview review, string chapterId)
		{
			return 0;
		}

		// Token: 0x06027F84 RID: 163716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F84")]
		[Address(RVA = "0x2330C90", Offset = "0x232F890", VA = "0x182330C90")]
		public void OnActivityReviewDetailDataRefresh()
		{
		}

		// Token: 0x06027F85 RID: 163717 RVA: 0x000D0368 File Offset: 0x000CE568
		[Token(Token = "0x6027F85")]
		[Address(RVA = "0x2330630", Offset = "0x232F230", VA = "0x182330630")]
		public bool CheckActivityOutOfTime()
		{
			return default(bool);
		}

		// Token: 0x06027F86 RID: 163718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F86")]
		[Address(RVA = "0x2331B60", Offset = "0x2330760", VA = "0x182331B60")]
		public ActCommonMiniStoryViewModel()
		{
		}

		// Token: 0x04038A54 RID: 232020
		[Token(Token = "0x4038A54")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewChapterViewModel chapterModel;

		// Token: 0x04038A55 RID: 232021
		[Token(Token = "0x4038A55")]
		[FieldOffset(Offset = "0x18")]
		public List<StoryReviewViewModel> availableModelList;

		// Token: 0x04038A56 RID: 232022
		[Token(Token = "0x4038A56")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
