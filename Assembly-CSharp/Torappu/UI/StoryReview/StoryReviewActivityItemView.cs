using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200490D RID: 18701
	[Token(Token = "0x200490D")]
	public class StoryReviewActivityItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C339 RID: 115513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C339")]
		[Address(RVA = "0x15B2560", Offset = "0x15B1160", VA = "0x1815B2560")]
		public void ApplyData(StoryReviewChapterViewModel chapterModel)
		{
		}

		// Token: 0x0601C33A RID: 115514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C33A")]
		[Address(RVA = "0x15B2A20", Offset = "0x15B1620", VA = "0x1815B2A20")]
		public void EventOnChapterClicked()
		{
		}

		// Token: 0x0601C33B RID: 115515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C33B")]
		[Address(RVA = "0x15B2A90", Offset = "0x15B1690", VA = "0x1815B2A90")]
		public void EventOnRewardsGainClicked()
		{
		}

		// Token: 0x0601C33C RID: 115516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C33C")]
		[Address(RVA = "0x15B2B00", Offset = "0x15B1700", VA = "0x1815B2B00")]
		public StoryReviewActivityItemView()
		{
		}

		// Token: 0x04024DE2 RID: 151010
		[Token(Token = "0x4024DE2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _storyImage;

		// Token: 0x04024DE3 RID: 151011
		[Token(Token = "0x4024DE3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StoryReviewProgressItemView _progressItem;

		// Token: 0x04024DE4 RID: 151012
		[Token(Token = "0x4024DE4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _canGetRewards;

		// Token: 0x04024DE5 RID: 151013
		[Token(Token = "0x4024DE5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completed;

		// Token: 0x04024DE6 RID: 151014
		[Token(Token = "0x4024DE6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _completedIcon;

		// Token: 0x04024DE7 RID: 151015
		[Token(Token = "0x4024DE7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _medalContainer;

		// Token: 0x04024DE8 RID: 151016
		[Token(Token = "0x4024DE8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _replicateMarkContainer;

		// Token: 0x04024DE9 RID: 151017
		[Token(Token = "0x4024DE9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _replicateItemPrefab;

		// Token: 0x04024DEA RID: 151018
		[Token(Token = "0x4024DEA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _medalIcon;

		// Token: 0x04024DEB RID: 151019
		[Token(Token = "0x4024DEB")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04024DEC RID: 151020
		[Token(Token = "0x4024DEC")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onGainClicked;

		// Token: 0x04024DED RID: 151021
		[Token(Token = "0x4024DED")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedStoryReviewId;

		// Token: 0x04024DEE RID: 151022
		[Token(Token = "0x4024DEE")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_replicateItem;

		// Token: 0x04024DEF RID: 151023
		[Token(Token = "0x4024DEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04024DF0 RID: 151024
		[Token(Token = "0x4024DF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnChapterClicked;

		// Token: 0x04024DF1 RID: 151025
		[Token(Token = "0x4024DF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRewardsGainClicked;

		// Token: 0x04024DF2 RID: 151026
		[Token(Token = "0x4024DF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
