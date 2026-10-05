using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F6 RID: 21494
	[Token(Token = "0x20053F6")]
	public class RoguelikeRewardRedCapsuleView : RoguelikeRewardItem
	{
		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x0601F9FE RID: 129534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9FF RID: 129535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A13")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9FE")]
			[Address(RVA = "0x195D2B0", Offset = "0x195BEB0", VA = "0x18195D2B0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F9FF")]
			[Address(RVA = "0x195D370", Offset = "0x195BF70", VA = "0x18195D370", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x0601FA00 RID: 129536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A14")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA00")]
			[Address(RVA = "0x195D310", Offset = "0x195BF10", VA = "0x18195D310", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA01 RID: 129537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA01")]
		[Address(RVA = "0x195CCC0", Offset = "0x195B8C0", VA = "0x18195CCC0", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA02 RID: 129538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA02")]
		[Address(RVA = "0x195CC50", Offset = "0x195B850", VA = "0x18195CC50")]
		public void OnCancelClick()
		{
		}

		// Token: 0x0601FA03 RID: 129539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA03")]
		[Address(RVA = "0x195CE60", Offset = "0x195BA60", VA = "0x18195CE60")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601FA04 RID: 129540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA04")]
		[Address(RVA = "0x195CF30", Offset = "0x195BB30", VA = "0x18195CF30", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA05 RID: 129541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA05")]
		[Address(RVA = "0x195D140", Offset = "0x195BD40", VA = "0x18195D140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FA06 RID: 129542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA06")]
		[Address(RVA = "0x195D250", Offset = "0x195BE50", VA = "0x18195D250")]
		public RoguelikeRewardRedCapsuleView()
		{
		}

		// Token: 0x0402A9B0 RID: 174512
		[Token(Token = "0x402A9B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _capsuleBg;

		// Token: 0x0402A9B1 RID: 174513
		[Token(Token = "0x402A9B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelReplaceText;

		// Token: 0x0402A9B2 RID: 174514
		[Token(Token = "0x402A9B2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelReplaceCheck;

		// Token: 0x0402A9B3 RID: 174515
		[Token(Token = "0x402A9B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasReplaceCheck;

		// Token: 0x0402A9B4 RID: 174516
		[Token(Token = "0x402A9B4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A9B5 RID: 174517
		[Token(Token = "0x402A9B5")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeRewardRedCapsuleView.RoguelikeRewardRedCapsuleSwitch m_switchTween;

		// Token: 0x0402A9B6 RID: 174518
		[Token(Token = "0x402A9B6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402A9B7 RID: 174519
		[Token(Token = "0x402A9B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A9B8 RID: 174520
		[Token(Token = "0x402A9B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A9B9 RID: 174521
		[Token(Token = "0x402A9B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A9BA RID: 174522
		[Token(Token = "0x402A9BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A9BB RID: 174523
		[Token(Token = "0x402A9BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0402A9BC RID: 174524
		[Token(Token = "0x402A9BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402A9BD RID: 174525
		[Token(Token = "0x402A9BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A9BE RID: 174526
		[Token(Token = "0x402A9BE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A9BF RID: 174527
		[Token(Token = "0x402A9BF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053F7 RID: 21495
		[Token(Token = "0x20053F7")]
		private class RoguelikeRewardRedCapsuleSwitch : UISwitchTween
		{
			// Token: 0x0601FA07 RID: 129543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA07")]
			[Address(RVA = "0x195C8E0", Offset = "0x195B4E0", VA = "0x18195C8E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601FA08 RID: 129544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FA08")]
			[Address(RVA = "0x195C630", Offset = "0x195B230", VA = "0x18195C630", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601FA09 RID: 129545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA09")]
			[Address(RVA = "0x195CB10", Offset = "0x195B710", VA = "0x18195CB10", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601FA0A RID: 129546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA0A")]
			[Address(RVA = "0x195CBD0", Offset = "0x195B7D0", VA = "0x18195CBD0")]
			public RoguelikeRewardRedCapsuleSwitch(RoguelikeRewardRedCapsuleView closure)
			{
			}

			// Token: 0x0601FA0C RID: 129548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA0C")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A9C0 RID: 174528
			[Token(Token = "0x402A9C0")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeRewardRedCapsuleView m_closure;

			// Token: 0x0402A9C1 RID: 174529
			[Token(Token = "0x402A9C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A9C2 RID: 174530
			[Token(Token = "0x402A9C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A9C3 RID: 174531
			[Token(Token = "0x402A9C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402A9C4 RID: 174532
			[Token(Token = "0x402A9C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
