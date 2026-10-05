using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.StoryReview;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B2B RID: 31531
	[Token(Token = "0x2007B2B")]
	public class Act10D5StoryViewModel
	{
		// Token: 0x0602C248 RID: 180808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C248")]
		[Address(RVA = "0x280D8F0", Offset = "0x280C4F0", VA = "0x18280D8F0")]
		public void LoadData(PlayerStoryReview playerData, string activityId)
		{
		}

		// Token: 0x0602C249 RID: 180809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C249")]
		[Address(RVA = "0x280D7C0", Offset = "0x280C3C0", VA = "0x18280D7C0")]
		public StoryReviewViewModel GetStoryReviewModel(string storyId)
		{
			return null;
		}

		// Token: 0x0602C24A RID: 180810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C24A")]
		[Address(RVA = "0x280DE50", Offset = "0x280CA50", VA = "0x18280DE50")]
		public void RefreshAvailableViewModelList()
		{
		}

		// Token: 0x0602C24B RID: 180811 RVA: 0x000DE360 File Offset: 0x000DC560
		[Token(Token = "0x602C24B")]
		[Address(RVA = "0x280E130", Offset = "0x280CD30", VA = "0x18280E130")]
		private bool _CheckPrevDependenceUnlocked(string dependId)
		{
			return default(bool);
		}

		// Token: 0x0602C24C RID: 180812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C24C")]
		[Address(RVA = "0x280E960", Offset = "0x280D560", VA = "0x18280E960")]
		private void _RefreshPlayerData(StoryReviewChapterViewModel chapter, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x0602C24D RID: 180813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C24D")]
		[Address(RVA = "0x280E200", Offset = "0x280CE00", VA = "0x18280E200")]
		private void _GenStoryReviewViewModel(ref StoryReviewViewModel viewModel, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x0602C24E RID: 180814 RVA: 0x000DE378 File Offset: 0x000DC578
		[Token(Token = "0x602C24E")]
		[Address(RVA = "0x280E020", Offset = "0x280CC20", VA = "0x18280E020")]
		private bool _ChapterShow(long startShow, long endShow)
		{
			return default(bool);
		}

		// Token: 0x0602C24F RID: 180815 RVA: 0x000DE390 File Offset: 0x000DC590
		[Token(Token = "0x602C24F")]
		[Address(RVA = "0x280E160", Offset = "0x280CD60", VA = "0x18280E160")]
		private bool _GenRewardsStatus(string chapterId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0602C250 RID: 180816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C250")]
		[Address(RVA = "0x280E310", Offset = "0x280CF10", VA = "0x18280E310")]
		private List<StoryReviewViewModel> _GenViewModels(List<StoryReviewInfoClientData> infoClientDatas, PlayerStoryReview review)
		{
			return null;
		}

		// Token: 0x0602C251 RID: 180817 RVA: 0x000DE3A8 File Offset: 0x000DC5A8
		[Token(Token = "0x602C251")]
		[Address(RVA = "0x280E830", Offset = "0x280D430", VA = "0x18280E830")]
		private bool _GetStoryReviewUnlocked(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0602C252 RID: 180818 RVA: 0x000DE3C0 File Offset: 0x000DC5C0
		[Token(Token = "0x602C252")]
		[Address(RVA = "0x280E6D0", Offset = "0x280D2D0", VA = "0x18280E6D0")]
		private bool _GetStoryReviewRead(string chapterId, string storyId, PlayerStoryReview review)
		{
			return default(bool);
		}

		// Token: 0x0602C253 RID: 180819 RVA: 0x000DE3D8 File Offset: 0x000DC5D8
		[Token(Token = "0x602C253")]
		[Address(RVA = "0x280E620", Offset = "0x280D220", VA = "0x18280E620")]
		private int _GetProgress(PlayerStoryReview review, string chapterId)
		{
			return 0;
		}

		// Token: 0x0602C254 RID: 180820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C254")]
		[Address(RVA = "0x280DC20", Offset = "0x280C820", VA = "0x18280DC20")]
		public void OnActivityReviewDetailDataRefresh()
		{
		}

		// Token: 0x0602C255 RID: 180821 RVA: 0x000DE3F0 File Offset: 0x000DC5F0
		[Token(Token = "0x602C255")]
		[Address(RVA = "0x280D5D0", Offset = "0x280C1D0", VA = "0x18280D5D0")]
		public bool CheckActivityOutOfTime()
		{
			return default(bool);
		}

		// Token: 0x0602C256 RID: 180822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C256")]
		[Address(RVA = "0x280EAF0", Offset = "0x280D6F0", VA = "0x18280EAF0")]
		public Act10D5StoryViewModel()
		{
		}

		// Token: 0x0403FFCE RID: 262094
		[Token(Token = "0x403FFCE")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewChapterViewModel chapterModel;

		// Token: 0x0403FFCF RID: 262095
		[Token(Token = "0x403FFCF")]
		[FieldOffset(Offset = "0x18")]
		public List<StoryReviewViewModel> availableModelList;
	}
}
