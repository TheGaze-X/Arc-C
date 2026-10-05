using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005403 RID: 21507
	[Token(Token = "0x2005403")]
	public class RoguelikeRewardTrapView : RoguelikeRewardItem
	{
		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x0601FA3D RID: 129597 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA3E RID: 129598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A21")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601FA3D")]
			[Address(RVA = "0x1964ED0", Offset = "0x1963AD0", VA = "0x181964ED0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601FA3E")]
			[Address(RVA = "0x1964F90", Offset = "0x1963B90", VA = "0x181964F90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x0601FA3F RID: 129599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A22")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA3F")]
			[Address(RVA = "0x1964F30", Offset = "0x1963B30", VA = "0x181964F30", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA40 RID: 129600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA40")]
		[Address(RVA = "0x1964640", Offset = "0x1963240", VA = "0x181964640", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA41 RID: 129601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA41")]
		[Address(RVA = "0x19645D0", Offset = "0x19631D0", VA = "0x1819645D0")]
		public void OnCancelClick()
		{
		}

		// Token: 0x0601FA42 RID: 129602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA42")]
		[Address(RVA = "0x19647E0", Offset = "0x19633E0", VA = "0x1819647E0")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601FA43 RID: 129603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA43")]
		[Address(RVA = "0x19648B0", Offset = "0x19634B0", VA = "0x1819648B0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA44 RID: 129604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA44")]
		[Address(RVA = "0x1964D60", Offset = "0x1963960", VA = "0x181964D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FA45 RID: 129605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA45")]
		[Address(RVA = "0x1964E70", Offset = "0x1963A70", VA = "0x181964E70")]
		public RoguelikeRewardTrapView()
		{
		}

		// Token: 0x0402AA39 RID: 174649
		[Token(Token = "0x402AA39")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _trapBg;

		// Token: 0x0402AA3A RID: 174650
		[Token(Token = "0x402AA3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _trapIcon;

		// Token: 0x0402AA3B RID: 174651
		[Token(Token = "0x402AA3B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _trapName;

		// Token: 0x0402AA3C RID: 174652
		[Token(Token = "0x402AA3C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402AA3D RID: 174653
		[Token(Token = "0x402AA3D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelReplaceText;

		// Token: 0x0402AA3E RID: 174654
		[Token(Token = "0x402AA3E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelReplaceCheck;

		// Token: 0x0402AA3F RID: 174655
		[Token(Token = "0x402AA3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasReplaceCheck;

		// Token: 0x0402AA40 RID: 174656
		[Token(Token = "0x402AA40")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _btnName;

		// Token: 0x0402AA41 RID: 174657
		[Token(Token = "0x402AA41")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402AA42 RID: 174658
		[Token(Token = "0x402AA42")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeRewardTrapView.RoguelikeRewardTrapSwitch m_switchTween;

		// Token: 0x0402AA43 RID: 174659
		[Token(Token = "0x402AA43")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0402AA44 RID: 174660
		[Token(Token = "0x402AA44")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402AA45 RID: 174661
		[Token(Token = "0x402AA45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402AA46 RID: 174662
		[Token(Token = "0x402AA46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402AA47 RID: 174663
		[Token(Token = "0x402AA47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402AA48 RID: 174664
		[Token(Token = "0x402AA48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402AA49 RID: 174665
		[Token(Token = "0x402AA49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0402AA4A RID: 174666
		[Token(Token = "0x402AA4A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402AA4B RID: 174667
		[Token(Token = "0x402AA4B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AA4C RID: 174668
		[Token(Token = "0x402AA4C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AA4D RID: 174669
		[Token(Token = "0x402AA4D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005404 RID: 21508
		[Token(Token = "0x2005404")]
		private class RoguelikeRewardTrapSwitch : UISwitchTween
		{
			// Token: 0x0601FA46 RID: 129606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA46")]
			[Address(RVA = "0x1964220", Offset = "0x1962E20", VA = "0x181964220", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601FA47 RID: 129607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA47")]
			[Address(RVA = "0x1963F60", Offset = "0x1962B60", VA = "0x181963F60", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601FA48 RID: 129608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA48")]
			[Address(RVA = "0x1964460", Offset = "0x1963060", VA = "0x181964460", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601FA49 RID: 129609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA49")]
			[Address(RVA = "0x1964550", Offset = "0x1963150", VA = "0x181964550")]
			public RoguelikeRewardTrapSwitch(RoguelikeRewardTrapView closure)
			{
			}

			// Token: 0x0601FA4B RID: 129611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA4B")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402AA4E RID: 174670
			[Token(Token = "0x402AA4E")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeRewardTrapView m_closure;

			// Token: 0x0402AA4F RID: 174671
			[Token(Token = "0x402AA4F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402AA50 RID: 174672
			[Token(Token = "0x402AA50")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402AA51 RID: 174673
			[Token(Token = "0x402AA51")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402AA52 RID: 174674
			[Token(Token = "0x402AA52")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
