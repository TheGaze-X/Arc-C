using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004914 RID: 18708
	[Token(Token = "0x2004914")]
	public class StoryReviewProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C34F RID: 115535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C34F")]
		[Address(RVA = "0x15B4C30", Offset = "0x15B3830", VA = "0x1815B4C30")]
		public void RenderProgress(int progress, int total, ItemBundle[] rewards)
		{
		}

		// Token: 0x0601C350 RID: 115536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C350")]
		[Address(RVA = "0x15B4B30", Offset = "0x15B3730", VA = "0x1815B4B30")]
		public void OnRewardInfoClicked()
		{
		}

		// Token: 0x0601C351 RID: 115537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C351")]
		[Address(RVA = "0x15B4EA0", Offset = "0x15B3AA0", VA = "0x1815B4EA0")]
		public StoryReviewProgressItemView()
		{
		}

		// Token: 0x04024E22 RID: 151074
		[Token(Token = "0x4024E22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04024E23 RID: 151075
		[Token(Token = "0x4024E23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04024E24 RID: 151076
		[Token(Token = "0x4024E24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _rewardInfoBtn;

		// Token: 0x04024E25 RID: 151077
		[Token(Token = "0x4024E25")]
		[FieldOffset(Offset = "0x30")]
		private List<ItemBundle> m_cachedRewards;

		// Token: 0x04024E26 RID: 151078
		[Token(Token = "0x4024E26")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024E27 RID: 151079
		[Token(Token = "0x4024E27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderProgress;

		// Token: 0x04024E28 RID: 151080
		[Token(Token = "0x4024E28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRewardInfoClicked;

		// Token: 0x04024E29 RID: 151081
		[Token(Token = "0x4024E29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
