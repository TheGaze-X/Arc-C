using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004907 RID: 18695
	[Token(Token = "0x2004907")]
	public class StoryReviewChapter
	{
		// Token: 0x0601C324 RID: 115492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C324")]
		[Address(RVA = "0x15B2D50", Offset = "0x15B1950", VA = "0x1815B2D50")]
		public StoryReviewViewModel GetStoryReviewModel(string storyId)
		{
			return null;
		}

		// Token: 0x0601C325 RID: 115493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C325")]
		[Address(RVA = "0x15B30B0", Offset = "0x15B1CB0", VA = "0x1815B30B0")]
		public void RefreshAvailableViewModelList()
		{
		}

		// Token: 0x0601C326 RID: 115494 RVA: 0x000A7868 File Offset: 0x000A5A68
		[Token(Token = "0x601C326")]
		[Address(RVA = "0x15B2B60", Offset = "0x15B1760", VA = "0x1815B2B60")]
		public bool CheckActivityOutOfTime()
		{
			return default(bool);
		}

		// Token: 0x0601C327 RID: 115495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C327")]
		[Address(RVA = "0x15B2E80", Offset = "0x15B1A80", VA = "0x1815B2E80")]
		public void OnActivityReviewDetailDataRefresh()
		{
		}

		// Token: 0x0601C328 RID: 115496 RVA: 0x000A7880 File Offset: 0x000A5A80
		[Token(Token = "0x601C328")]
		[Address(RVA = "0x15B3280", Offset = "0x15B1E80", VA = "0x1815B3280")]
		private bool _CheckPrevDependenceUnlocked(string dependId)
		{
			return default(bool);
		}

		// Token: 0x0601C329 RID: 115497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C329")]
		[Address(RVA = "0x15B34C0", Offset = "0x15B20C0", VA = "0x1815B34C0")]
		private void _RefreshPlayerData(StoryReviewChapterViewModel chapter, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C32A")]
		[Address(RVA = "0x15B33B0", Offset = "0x15B1FB0", VA = "0x1815B33B0")]
		private void _GenStoryReviewViewModel(ref StoryReviewViewModel viewModel, PlayerStoryReviewUnlockInfo unlockInfo)
		{
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C32B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReviewChapter()
		{
		}

		// Token: 0x04024DB7 RID: 150967
		[Token(Token = "0x4024DB7")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewChapterViewModel chapterModel;

		// Token: 0x04024DB8 RID: 150968
		[Token(Token = "0x4024DB8")]
		[FieldOffset(Offset = "0x18")]
		public List<StoryReviewViewModel> availableModelList;
	}
}
