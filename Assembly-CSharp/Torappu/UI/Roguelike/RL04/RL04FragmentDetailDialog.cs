using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C1 RID: 22209
	[Token(Token = "0x20056C1")]
	public class RL04FragmentDetailDialog : UICompDialog<RL04FragmentDetailDialog.Options>, IHotfixable
	{
		// Token: 0x06020925 RID: 133413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020925")]
		[Address(RVA = "0x1AABC20", Offset = "0x1AAA820", VA = "0x181AABC20", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06020926 RID: 133414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020926")]
		[Address(RVA = "0x1AABC90", Offset = "0x1AAA890", VA = "0x181AABC90", Slot = "18")]
		protected override void OnRender(RL04FragmentDetailDialog.Options input)
		{
		}

		// Token: 0x06020927 RID: 133415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020927")]
		[Address(RVA = "0x1AABAC0", Offset = "0x1AAA6C0", VA = "0x181AABAC0")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06020928 RID: 133416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020928")]
		[Address(RVA = "0x1AAC5A0", Offset = "0x1AAB1A0", VA = "0x181AAC5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020929 RID: 133417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020929")]
		[Address(RVA = "0x1AAC050", Offset = "0x1AAAC50", VA = "0x181AAC050")]
		private void _EventOnNextBtnClicked()
		{
		}

		// Token: 0x0602092A RID: 133418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092A")]
		[Address(RVA = "0x1AAC160", Offset = "0x1AAAD60", VA = "0x181AAC160")]
		private void _EventOnPrevBtnClicked()
		{
		}

		// Token: 0x0602092B RID: 133419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092B")]
		[Address(RVA = "0x1AAC270", Offset = "0x1AAAE70", VA = "0x181AAC270")]
		private void _EventOnUseBtnClicked()
		{
		}

		// Token: 0x0602092C RID: 133420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092C")]
		[Address(RVA = "0x1AACF90", Offset = "0x1AABB90", VA = "0x181AACF90")]
		private void _OnUseInspiration(string instId)
		{
		}

		// Token: 0x0602092D RID: 133421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092D")]
		[Address(RVA = "0x1AACD80", Offset = "0x1AAB980", VA = "0x181AACD80")]
		private void _OnUseInspirationProceed(RL04UseInspirationResponse response)
		{
		}

		// Token: 0x0602092E RID: 133422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092E")]
		[Address(RVA = "0x1AABD60", Offset = "0x1AAA960", VA = "0x181AABD60")]
		private void _EventOnDropBtnClicked()
		{
		}

		// Token: 0x0602092F RID: 133423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602092F")]
		[Address(RVA = "0x1AACBB0", Offset = "0x1AAB7B0", VA = "0x181AACBB0")]
		private void _OnDropFragmentProceed(RL04LoseFragmentResponse response)
		{
		}

		// Token: 0x06020930 RID: 133424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020930")]
		[Address(RVA = "0x1AAC9B0", Offset = "0x1AAB5B0", VA = "0x181AAC9B0")]
		private void _NotifyDungeonUpdate()
		{
		}

		// Token: 0x06020931 RID: 133425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020931")]
		[Address(RVA = "0x1AAD1B0", Offset = "0x1AABDB0", VA = "0x181AAD1B0")]
		public RL04FragmentDetailDialog()
		{
		}

		// Token: 0x06020932 RID: 133426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020932")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402C225 RID: 180773
		[Token(Token = "0x402C225")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL04FragmentDetailView _detailView;

		// Token: 0x0402C226 RID: 180774
		[Token(Token = "0x402C226")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _panelBackRt;

		// Token: 0x0402C227 RID: 180775
		[Token(Token = "0x402C227")]
		[FieldOffset(Offset = "0x80")]
		private RL04FragmentDetailProperty m_property;

		// Token: 0x0402C228 RID: 180776
		[Token(Token = "0x402C228")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402C229 RID: 180777
		[Token(Token = "0x402C229")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C22A RID: 180778
		[Token(Token = "0x402C22A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C22B RID: 180779
		[Token(Token = "0x402C22B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C22C RID: 180780
		[Token(Token = "0x402C22C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402C22D RID: 180781
		[Token(Token = "0x402C22D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C22E RID: 180782
		[Token(Token = "0x402C22E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnNextBtnClicked;

		// Token: 0x0402C22F RID: 180783
		[Token(Token = "0x402C22F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnPrevBtnClicked;

		// Token: 0x0402C230 RID: 180784
		[Token(Token = "0x402C230")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnUseBtnClicked;

		// Token: 0x0402C231 RID: 180785
		[Token(Token = "0x402C231")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUseInspiration;

		// Token: 0x0402C232 RID: 180786
		[Token(Token = "0x402C232")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUseInspirationProceed;

		// Token: 0x0402C233 RID: 180787
		[Token(Token = "0x402C233")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnDropBtnClicked;

		// Token: 0x0402C234 RID: 180788
		[Token(Token = "0x402C234")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDropFragmentProceed;

		// Token: 0x0402C235 RID: 180789
		[Token(Token = "0x402C235")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NotifyDungeonUpdate;

		// Token: 0x0402C236 RID: 180790
		[Token(Token = "0x402C236")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056C2 RID: 22210
		[Token(Token = "0x20056C2")]
		public class Options
		{
			// Token: 0x06020933 RID: 133427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020933")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402C237 RID: 180791
			[Token(Token = "0x402C237")]
			[FieldOffset(Offset = "0x10")]
			public List<RL04FragmentItemViewModel> fragmentList;

			// Token: 0x0402C238 RID: 180792
			[Token(Token = "0x402C238")]
			[FieldOffset(Offset = "0x18")]
			public int selectIndex;

			// Token: 0x0402C239 RID: 180793
			[Token(Token = "0x402C239")]
			[FieldOffset(Offset = "0x1C")]
			public RoguelikeFragmentDialogMode mode;

			// Token: 0x0402C23A RID: 180794
			[Token(Token = "0x402C23A")]
			[FieldOffset(Offset = "0x20")]
			public FragmentBagStatus status;

			// Token: 0x0402C23B RID: 180795
			[Token(Token = "0x402C23B")]
			[FieldOffset(Offset = "0x24")]
			public int totalWeight;

			// Token: 0x0402C23C RID: 180796
			[Token(Token = "0x402C23C")]
			[FieldOffset(Offset = "0x28")]
			public int limitWeight;

			// Token: 0x0402C23D RID: 180797
			[Token(Token = "0x402C23D")]
			[FieldOffset(Offset = "0x2C")]
			public int overWeight;

			// Token: 0x0402C23E RID: 180798
			[Token(Token = "0x402C23E")]
			[FieldOffset(Offset = "0x30")]
			public float weightProgress;

			// Token: 0x0402C23F RID: 180799
			[Token(Token = "0x402C23F")]
			[FieldOffset(Offset = "0x34")]
			public float limitWeightScale;

			// Token: 0x0402C240 RID: 180800
			[Token(Token = "0x402C240")]
			[FieldOffset(Offset = "0x38")]
			public float overWeightScale;
		}
	}
}
