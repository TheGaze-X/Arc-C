using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C74 RID: 15476
	[Token(Token = "0x2003C74")]
	public class TuningChatNarrationView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060182BC RID: 99004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BC")]
		[Address(RVA = "0x10AA090", Offset = "0x10A8C90", VA = "0x1810AA090")]
		public void Render(TuningChatNarrationView.Options options)
		{
		}

		// Token: 0x060182BD RID: 99005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BD")]
		[Address(RVA = "0x10AA2B0", Offset = "0x10A8EB0", VA = "0x1810AA2B0")]
		public void UpdateData(TuningChatItemViewModel viewModel)
		{
		}

		// Token: 0x060182BE RID: 99006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BE")]
		[Address(RVA = "0x10AA200", Offset = "0x10A8E00", VA = "0x1810AA200")]
		public void UpdateCardData(TuningChatBagItemViewModel cardModel)
		{
		}

		// Token: 0x060182BF RID: 99007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182BF")]
		[Address(RVA = "0x10AA370", Offset = "0x10A8F70", VA = "0x1810AA370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060182C0 RID: 99008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C0")]
		[Address(RVA = "0x10AAB60", Offset = "0x10A9760", VA = "0x1810AAB60")]
		private void _RenderImpl(string content, TuningChatNarrationView.ShowType showType, bool isOpenBag, bool isFastMode = false)
		{
		}

		// Token: 0x060182C1 RID: 99009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C1")]
		[Address(RVA = "0x10AAD50", Offset = "0x10A9950", VA = "0x1810AAD50")]
		private void _RenderNormal(string content, TuningChatNarrationView.ShowType showType, bool isFastMode = false)
		{
		}

		// Token: 0x060182C2 RID: 99010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C2")]
		[Address(RVA = "0x10AA8F0", Offset = "0x10A94F0", VA = "0x1810AA8F0")]
		private void _RenderBackpack(string content, TuningChatNarrationView.ShowType showType, bool isOpenBag, bool isFastMode = false)
		{
		}

		// Token: 0x060182C3 RID: 99011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C3")]
		[Address(RVA = "0x10A9E00", Offset = "0x10A8A00", VA = "0x1810A9E00")]
		public void OnHandleSkip()
		{
		}

		// Token: 0x060182C4 RID: 99012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C4")]
		[Address(RVA = "0x10A9FA0", Offset = "0x10A8BA0", VA = "0x1810A9FA0")]
		public void OnNextNarration()
		{
		}

		// Token: 0x060182C5 RID: 99013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C5")]
		[Address(RVA = "0x10A9D60", Offset = "0x10A8960", VA = "0x1810A9D60")]
		public void OnHandleOpen()
		{
		}

		// Token: 0x060182C6 RID: 99014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C6")]
		[Address(RVA = "0x10A9EB0", Offset = "0x10A8AB0", VA = "0x1810A9EB0")]
		public void OnHandleSubmit()
		{
		}

		// Token: 0x060182C7 RID: 99015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C7")]
		[Address(RVA = "0x10A9CC0", Offset = "0x10A88C0", VA = "0x1810A9CC0")]
		public void OnHandleFinish()
		{
		}

		// Token: 0x060182C8 RID: 99016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182C8")]
		[Address(RVA = "0x10AAFC0", Offset = "0x10A9BC0", VA = "0x1810AAFC0")]
		public TuningChatNarrationView()
		{
		}

		// Token: 0x0401D680 RID: 120448
		[Token(Token = "0x401D680")]
		private const float CONTENT_FADE_DURATION = 0.5f;

		// Token: 0x0401D681 RID: 120449
		[Token(Token = "0x401D681")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _content;

		// Token: 0x0401D682 RID: 120450
		[Token(Token = "0x401D682")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _selectContent;

		// Token: 0x0401D683 RID: 120451
		[Token(Token = "0x401D683")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _contentAlphaHandler;

		// Token: 0x0401D684 RID: 120452
		[Token(Token = "0x401D684")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _selectContentAlphaHandler;

		// Token: 0x0401D685 RID: 120453
		[Token(Token = "0x401D685")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _emptyContent;

		// Token: 0x0401D686 RID: 120454
		[Token(Token = "0x401D686")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _selectEmptyContent;

		// Token: 0x0401D687 RID: 120455
		[Token(Token = "0x401D687")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _panelNormal;

		// Token: 0x0401D688 RID: 120456
		[Token(Token = "0x401D688")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _panelBackPack;

		// Token: 0x0401D689 RID: 120457
		[Token(Token = "0x401D689")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _btnSkip;

		// Token: 0x0401D68A RID: 120458
		[Token(Token = "0x401D68A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _btnNext;

		// Token: 0x0401D68B RID: 120459
		[Token(Token = "0x401D68B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _btnOpen;

		// Token: 0x0401D68C RID: 120460
		[Token(Token = "0x401D68C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _btnUnselect;

		// Token: 0x0401D68D RID: 120461
		[Token(Token = "0x401D68D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _btnSubmit;

		// Token: 0x0401D68E RID: 120462
		[Token(Token = "0x401D68E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _btnFinish;

		// Token: 0x0401D68F RID: 120463
		[Token(Token = "0x401D68F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TuningChatNarrationCardView _cardView;

		// Token: 0x0401D690 RID: 120464
		[Token(Token = "0x401D690")]
		[FieldOffset(Offset = "0x90")]
		private TuningChatItemViewModel m_cachedViewModel;

		// Token: 0x0401D691 RID: 120465
		[Token(Token = "0x401D691")]
		[FieldOffset(Offset = "0x98")]
		private TuningChatBagItemViewModel m_cachedCardViewModel;

		// Token: 0x0401D692 RID: 120466
		[Token(Token = "0x401D692")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D693 RID: 120467
		[Token(Token = "0x401D693")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0401D694 RID: 120468
		[Token(Token = "0x401D694")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_alreadySkip;

		// Token: 0x0401D695 RID: 120469
		[Token(Token = "0x401D695")]
		[FieldOffset(Offset = "0xB4")]
		private int m_cachedIndex;

		// Token: 0x0401D696 RID: 120470
		[Token(Token = "0x401D696")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedContent;

		// Token: 0x0401D697 RID: 120471
		[Token(Token = "0x401D697")]
		[FieldOffset(Offset = "0xC0")]
		private TuningChatNarrationView.ShowType m_showType;

		// Token: 0x0401D698 RID: 120472
		[Token(Token = "0x401D698")]
		[FieldOffset(Offset = "0xC8")]
		private TuningChatNarrationView.FadeTween m_contentSwitchTween;

		// Token: 0x0401D699 RID: 120473
		[Token(Token = "0x401D699")]
		[FieldOffset(Offset = "0xD0")]
		private TuningChatNarrationView.FadeTween m_selectContentSwitchTween;

		// Token: 0x0401D69A RID: 120474
		[Token(Token = "0x401D69A")]
		[FieldOffset(Offset = "0xD8")]
		private TuningChatNarrationView.FadeTween m_emptySwitchTween;

		// Token: 0x0401D69B RID: 120475
		[Token(Token = "0x401D69B")]
		[FieldOffset(Offset = "0xE0")]
		private TuningChatNarrationView.FadeTween m_selectEmptySwitchTween;

		// Token: 0x0401D69C RID: 120476
		[Token(Token = "0x401D69C")]
		[FieldOffset(Offset = "0xE8")]
		private TuningChatNarrationView.FadeTween m_normalSwitchTween;

		// Token: 0x0401D69D RID: 120477
		[Token(Token = "0x401D69D")]
		[FieldOffset(Offset = "0xF0")]
		private TuningChatNarrationView.FadeTween m_backpackSwitchTween;

		// Token: 0x0401D69E RID: 120478
		[Token(Token = "0x401D69E")]
		[FieldOffset(Offset = "0xF8")]
		private TuningChatNarrationView.FadeTween m_skipSwitchTween;

		// Token: 0x0401D69F RID: 120479
		[Token(Token = "0x401D69F")]
		[FieldOffset(Offset = "0x100")]
		private TuningChatNarrationView.FadeTween m_nextSwitchTween;

		// Token: 0x0401D6A0 RID: 120480
		[Token(Token = "0x401D6A0")]
		[FieldOffset(Offset = "0x108")]
		private TuningChatNarrationView.FadeTween m_openSwitchTween;

		// Token: 0x0401D6A1 RID: 120481
		[Token(Token = "0x401D6A1")]
		[FieldOffset(Offset = "0x110")]
		private TuningChatNarrationView.FadeTween m_unselectSwitchTween;

		// Token: 0x0401D6A2 RID: 120482
		[Token(Token = "0x401D6A2")]
		[FieldOffset(Offset = "0x118")]
		private TuningChatNarrationView.FadeTween m_submitSwitchTween;

		// Token: 0x0401D6A3 RID: 120483
		[Token(Token = "0x401D6A3")]
		[FieldOffset(Offset = "0x120")]
		private TuningChatNarrationView.FadeTween m_finishSwitchTween;

		// Token: 0x0401D6A4 RID: 120484
		[Token(Token = "0x401D6A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D6A5 RID: 120485
		[Token(Token = "0x401D6A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401D6A6 RID: 120486
		[Token(Token = "0x401D6A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCardData;

		// Token: 0x0401D6A7 RID: 120487
		[Token(Token = "0x401D6A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D6A8 RID: 120488
		[Token(Token = "0x401D6A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderImpl;

		// Token: 0x0401D6A9 RID: 120489
		[Token(Token = "0x401D6A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNormal;

		// Token: 0x0401D6AA RID: 120490
		[Token(Token = "0x401D6AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBackpack;

		// Token: 0x0401D6AB RID: 120491
		[Token(Token = "0x401D6AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnHandleSkip;

		// Token: 0x0401D6AC RID: 120492
		[Token(Token = "0x401D6AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnNextNarration;

		// Token: 0x0401D6AD RID: 120493
		[Token(Token = "0x401D6AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnHandleOpen;

		// Token: 0x0401D6AE RID: 120494
		[Token(Token = "0x401D6AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnHandleSubmit;

		// Token: 0x0401D6AF RID: 120495
		[Token(Token = "0x401D6AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnHandleFinish;

		// Token: 0x0401D6B0 RID: 120496
		[Token(Token = "0x401D6B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C75 RID: 15477
		[Token(Token = "0x2003C75")]
		[Flags]
		public enum ShowType
		{
			// Token: 0x0401D6B2 RID: 120498
			[Token(Token = "0x401D6B2")]
			SKIP = 1,
			// Token: 0x0401D6B3 RID: 120499
			[Token(Token = "0x401D6B3")]
			NEXT = 2,
			// Token: 0x0401D6B4 RID: 120500
			[Token(Token = "0x401D6B4")]
			OPEN = 4,
			// Token: 0x0401D6B5 RID: 120501
			[Token(Token = "0x401D6B5")]
			UNSELECTED = 8,
			// Token: 0x0401D6B6 RID: 120502
			[Token(Token = "0x401D6B6")]
			SUBMIT = 16,
			// Token: 0x0401D6B7 RID: 120503
			[Token(Token = "0x401D6B7")]
			FINISH = 32,
			// Token: 0x0401D6B8 RID: 120504
			[Token(Token = "0x401D6B8")]
			NORMAL = 39,
			// Token: 0x0401D6B9 RID: 120505
			[Token(Token = "0x401D6B9")]
			BACKPACK = 24
		}

		// Token: 0x02003C76 RID: 15478
		[Token(Token = "0x2003C76")]
		public struct Options
		{
			// Token: 0x0401D6BA RID: 120506
			[Token(Token = "0x401D6BA")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0401D6BB RID: 120507
			[Token(Token = "0x401D6BB")]
			[FieldOffset(Offset = "0x8")]
			public string content;

			// Token: 0x0401D6BC RID: 120508
			[Token(Token = "0x401D6BC")]
			[FieldOffset(Offset = "0x10")]
			public TuningChatNarrationView.ShowType showType;

			// Token: 0x0401D6BD RID: 120509
			[Token(Token = "0x401D6BD")]
			[FieldOffset(Offset = "0x14")]
			public bool reserveContent;

			// Token: 0x0401D6BE RID: 120510
			[Token(Token = "0x401D6BE")]
			[FieldOffset(Offset = "0x15")]
			public bool isFastMode;
		}

		// Token: 0x02003C77 RID: 15479
		[Token(Token = "0x2003C77")]
		private class FadeTween : UISwitchTween
		{
			// Token: 0x060182C9 RID: 99017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182C9")]
			[Address(RVA = "0x10A4B80", Offset = "0x10A3780", VA = "0x1810A4B80")]
			public FadeTween(CanvasGroup alphaHandler, float duration = 0.16f)
			{
			}

			// Token: 0x060182CA RID: 99018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60182CA")]
			[Address(RVA = "0x10A49B0", Offset = "0x10A35B0", VA = "0x1810A49B0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060182CB RID: 99019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60182CB")]
			[Address(RVA = "0x10A48E0", Offset = "0x10A34E0", VA = "0x1810A48E0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060182CC RID: 99020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182CC")]
			[Address(RVA = "0x10A4840", Offset = "0x10A3440", VA = "0x1810A4840", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060182CD RID: 99021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182CD")]
			[Address(RVA = "0x10A46A0", Offset = "0x10A32A0", VA = "0x1810A46A0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x060182CE RID: 99022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182CE")]
			[Address(RVA = "0x10A4740", Offset = "0x10A3340", VA = "0x1810A4740", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x060182CF RID: 99023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182CF")]
			[Address(RVA = "0x10A47C0", Offset = "0x10A33C0", VA = "0x1810A47C0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x060182D0 RID: 99024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D0")]
			[Address(RVA = "0x10A4A90", Offset = "0x10A3690", VA = "0x1810A4A90", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060182D1 RID: 99025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D1")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060182D2 RID: 99026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D2")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x060182D3 RID: 99027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D3")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x060182D4 RID: 99028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D4")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x060182D5 RID: 99029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182D5")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401D6BF RID: 120511
			[Token(Token = "0x401D6BF")]
			private const float TWEEN_DURATION = 0.16f;

			// Token: 0x0401D6C0 RID: 120512
			[Token(Token = "0x401D6C0")]
			[FieldOffset(Offset = "0x48")]
			private CanvasGroup m_alphaHandler;

			// Token: 0x0401D6C1 RID: 120513
			[Token(Token = "0x401D6C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D6C2 RID: 120514
			[Token(Token = "0x401D6C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401D6C3 RID: 120515
			[Token(Token = "0x401D6C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401D6C4 RID: 120516
			[Token(Token = "0x401D6C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401D6C5 RID: 120517
			[Token(Token = "0x401D6C5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0401D6C6 RID: 120518
			[Token(Token = "0x401D6C6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0401D6C7 RID: 120519
			[Token(Token = "0x401D6C7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0401D6C8 RID: 120520
			[Token(Token = "0x401D6C8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
