using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200530A RID: 21258
	[Token(Token = "0x200530A")]
	public class RoguelikeMenuTaskObject : RoguelikeMenuObject<RoguelikeMenuTaskViewModel>
	{
		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x0601F5C8 RID: 128456 RVA: 0x000B1A80 File Offset: 0x000AFC80
		[Token(Token = "0x1700498D")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F5C8")]
			[Address(RVA = "0x1918FF0", Offset = "0x1917BF0", VA = "0x181918FF0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F5C9 RID: 128457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C9")]
		[Address(RVA = "0x1917430", Offset = "0x1916030", VA = "0x181917430", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F5CA RID: 128458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CA")]
		[Address(RVA = "0x1918680", Offset = "0x1917280", VA = "0x181918680")]
		private void _RenderShow(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F5CB RID: 128459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CB")]
		[Address(RVA = "0x1918490", Offset = "0x1917090", VA = "0x181918490")]
		private void _RenderProgress(int currValue, bool fastMode)
		{
		}

		// Token: 0x0601F5CC RID: 128460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CC")]
		[Address(RVA = "0x1918250", Offset = "0x1916E50", VA = "0x181918250")]
		private void _RenderComplete(bool completed, bool fastMode)
		{
		}

		// Token: 0x0601F5CD RID: 128461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CD")]
		[Address(RVA = "0x1918760", Offset = "0x1917360", VA = "0x181918760")]
		private void _RenderValid(bool valid, bool fastMode)
		{
		}

		// Token: 0x0601F5CE RID: 128462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CE")]
		[Address(RVA = "0x19183B0", Offset = "0x1916FB0", VA = "0x1819183B0")]
		private void _RenderOuterLight(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F5CF RID: 128463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5CF")]
		[Address(RVA = "0x1918B00", Offset = "0x1917700", VA = "0x181918B00")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x0601F5D0 RID: 128464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D0")]
		[Address(RVA = "0x1918840", Offset = "0x1917440", VA = "0x181918840")]
		private void _Render(bool fastMode)
		{
		}

		// Token: 0x0601F5D1 RID: 128465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D1")]
		[Address(RVA = "0x1917D30", Offset = "0x1916930", VA = "0x181917D30", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F5D2 RID: 128466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D2")]
		[Address(RVA = "0x1917EC0", Offset = "0x1916AC0", VA = "0x181917EC0", Slot = "16")]
		public override void Render(RoguelikeMenuTaskViewModel viewModel)
		{
		}

		// Token: 0x0601F5D3 RID: 128467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D3")]
		[Address(RVA = "0x1917C30", Offset = "0x1916830", VA = "0x181917C30", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F5D4 RID: 128468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D4")]
		[Address(RVA = "0x1918080", Offset = "0x1916C80", VA = "0x181918080")]
		private void _OnReceiveTaskRewardClicked()
		{
		}

		// Token: 0x0601F5D5 RID: 128469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5D5")]
		[Address(RVA = "0x1918F60", Offset = "0x1917B60", VA = "0x181918F60")]
		public RoguelikeMenuTaskObject()
		{
		}

		// Token: 0x0601F5DC RID: 128476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5DC")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F5DD RID: 128477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5DD")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0601F5DE RID: 128478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5DE")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402A252 RID: 172626
		[Token(Token = "0x402A252")]
		private const float PROGRESS_CHANGE_TWEEN_DURATION = 0.16f;

		// Token: 0x0402A253 RID: 172627
		[Token(Token = "0x402A253")]
		private const int PROGRESS_MASK_BAR_WIDTH = 120;

		// Token: 0x0402A254 RID: 172628
		[Token(Token = "0x402A254")]
		private const int PROGRESS_MASK_BAR_HEIGHT = 4;

		// Token: 0x0402A255 RID: 172629
		[Token(Token = "0x402A255")]
		private const float CANVAS_ALPHA_INVALID = 0.4f;

		// Token: 0x0402A256 RID: 172630
		[Token(Token = "0x402A256")]
		private const float OUTER_LIGHT_ALPHA_BREATH_DOWN = 0.4f;

		// Token: 0x0402A257 RID: 172631
		[Token(Token = "0x402A257")]
		private const float OUTER_LIGHT_ALPHA_BREATH_UP = 1f;

		// Token: 0x0402A258 RID: 172632
		[Token(Token = "0x402A258")]
		private const float OUTER_LIGHT_LOOP_DURATION = 2f;

		// Token: 0x0402A259 RID: 172633
		[Token(Token = "0x402A259")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402A25A RID: 172634
		[Token(Token = "0x402A25A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type[] STATE_CAN_RECEIVE_TASK_REWARD;

		// Token: 0x0402A25B RID: 172635
		[Token(Token = "0x402A25B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A25C RID: 172636
		[Token(Token = "0x402A25C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402A25D RID: 172637
		[Token(Token = "0x402A25D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0402A25E RID: 172638
		[Token(Token = "0x402A25E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _lineProgress;

		// Token: 0x0402A25F RID: 172639
		[Token(Token = "0x402A25F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _lightProgress;

		// Token: 0x0402A260 RID: 172640
		[Token(Token = "0x402A260")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _iconTask;

		// Token: 0x0402A261 RID: 172641
		[Token(Token = "0x402A261")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _iconTaskComplete;

		// Token: 0x0402A262 RID: 172642
		[Token(Token = "0x402A262")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0402A263 RID: 172643
		[Token(Token = "0x402A263")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasValid;

		// Token: 0x0402A264 RID: 172644
		[Token(Token = "0x402A264")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasOuterLight;

		// Token: 0x0402A265 RID: 172645
		[Token(Token = "0x402A265")]
		[FieldOffset(Offset = "0x80")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0402A266 RID: 172646
		[Token(Token = "0x402A266")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeMenuTaskObject.CompleteSwitchTween m_completeSwitchTween;

		// Token: 0x0402A267 RID: 172647
		[Token(Token = "0x402A267")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeMenuTaskObject.ValidSwitchTween m_validSwitchTween;

		// Token: 0x0402A268 RID: 172648
		[Token(Token = "0x402A268")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeMenuTaskObject.OuterLightShowTween m_outerLightShowTween;

		// Token: 0x0402A269 RID: 172649
		[Token(Token = "0x402A269")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_progressTween;

		// Token: 0x0402A26A RID: 172650
		[Token(Token = "0x402A26A")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeStatusBarTextTweener m_progressTextTweener;

		// Token: 0x0402A26B RID: 172651
		[Token(Token = "0x402A26B")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402A26C RID: 172652
		[Token(Token = "0x402A26C")]
		[FieldOffset(Offset = "0xB8")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402A26D RID: 172653
		[Token(Token = "0x402A26D")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeMenuTaskViewModel m_cachedModel;

		// Token: 0x0402A26E RID: 172654
		[Token(Token = "0x402A26E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedStateShow;

		// Token: 0x0402A26F RID: 172655
		[Token(Token = "0x402A26F")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_cachedStateValid;

		// Token: 0x0402A270 RID: 172656
		[Token(Token = "0x402A270")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A271 RID: 172657
		[Token(Token = "0x402A271")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A272 RID: 172658
		[Token(Token = "0x402A272")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderShow;

		// Token: 0x0402A273 RID: 172659
		[Token(Token = "0x402A273")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderProgress;

		// Token: 0x0402A274 RID: 172660
		[Token(Token = "0x402A274")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderComplete;

		// Token: 0x0402A275 RID: 172661
		[Token(Token = "0x402A275")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderValid;

		// Token: 0x0402A276 RID: 172662
		[Token(Token = "0x402A276")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderOuterLight;

		// Token: 0x0402A277 RID: 172663
		[Token(Token = "0x402A277")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402A278 RID: 172664
		[Token(Token = "0x402A278")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402A279 RID: 172665
		[Token(Token = "0x402A279")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A27A RID: 172666
		[Token(Token = "0x402A27A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A27B RID: 172667
		[Token(Token = "0x402A27B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A27C RID: 172668
		[Token(Token = "0x402A27C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnReceiveTaskRewardClicked;

		// Token: 0x0402A27D RID: 172669
		[Token(Token = "0x402A27D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200530B RID: 21259
		[Token(Token = "0x200530B")]
		private class CompleteSwitchTween : UISwitchTween
		{
			// Token: 0x0601F5DF RID: 128479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5DF")]
			[Address(RVA = "0x190B710", Offset = "0x190A310", VA = "0x18190B710")]
			public CompleteSwitchTween(RoguelikeMenuTaskObject closure)
			{
			}

			// Token: 0x0601F5E0 RID: 128480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5E0")]
			[Address(RVA = "0x190B1C0", Offset = "0x1909DC0", VA = "0x18190B1C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F5E1 RID: 128481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5E1")]
			[Address(RVA = "0x190B3A0", Offset = "0x1909FA0", VA = "0x18190B3A0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F5E2 RID: 128482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E2")]
			[Address(RVA = "0x190AF40", Offset = "0x1909B40", VA = "0x18190AF40", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F5E3 RID: 128483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E3")]
			[Address(RVA = "0x190B110", Offset = "0x1909D10", VA = "0x18190B110", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F5E4 RID: 128484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E4")]
			[Address(RVA = "0x190AFF0", Offset = "0x1909BF0", VA = "0x18190AFF0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601F5E5 RID: 128485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E5")]
			[Address(RVA = "0x190B080", Offset = "0x1909C80", VA = "0x18190B080", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601F5E6 RID: 128486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E6")]
			[Address(RVA = "0x190B580", Offset = "0x190A180", VA = "0x18190B580", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F5E7 RID: 128487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E7")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F5E8 RID: 128488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E8")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F5E9 RID: 128489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5E9")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601F5EA RID: 128490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5EA")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601F5EB RID: 128491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5EB")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A27E RID: 172670
			[Token(Token = "0x402A27E")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeMenuTaskObject m_closure;

			// Token: 0x0402A27F RID: 172671
			[Token(Token = "0x402A27F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A280 RID: 172672
			[Token(Token = "0x402A280")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A281 RID: 172673
			[Token(Token = "0x402A281")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A282 RID: 172674
			[Token(Token = "0x402A282")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402A283 RID: 172675
			[Token(Token = "0x402A283")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402A284 RID: 172676
			[Token(Token = "0x402A284")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402A285 RID: 172677
			[Token(Token = "0x402A285")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402A286 RID: 172678
			[Token(Token = "0x402A286")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x0200530C RID: 21260
		[Token(Token = "0x200530C")]
		private class ValidSwitchTween : UISwitchTween
		{
			// Token: 0x0601F5EC RID: 128492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5EC")]
			[Address(RVA = "0x1920BB0", Offset = "0x191F7B0", VA = "0x181920BB0")]
			public ValidSwitchTween(RoguelikeMenuTaskObject closure)
			{
			}

			// Token: 0x0601F5ED RID: 128493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5ED")]
			[Address(RVA = "0x1920910", Offset = "0x191F510", VA = "0x181920910", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F5EE RID: 128494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5EE")]
			[Address(RVA = "0x1920A10", Offset = "0x191F610", VA = "0x181920A10", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F5EF RID: 128495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5EF")]
			[Address(RVA = "0x1920B10", Offset = "0x191F710", VA = "0x181920B10", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F5F0 RID: 128496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F0")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A287 RID: 172679
			[Token(Token = "0x402A287")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeMenuTaskObject m_closure;

			// Token: 0x0402A288 RID: 172680
			[Token(Token = "0x402A288")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A289 RID: 172681
			[Token(Token = "0x402A289")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A28A RID: 172682
			[Token(Token = "0x402A28A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A28B RID: 172683
			[Token(Token = "0x402A28B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x0200530D RID: 21261
		[Token(Token = "0x200530D")]
		private class OuterLightShowTween : UISwitchTween
		{
			// Token: 0x0601F5F1 RID: 128497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F1")]
			[Address(RVA = "0x190E970", Offset = "0x190D570", VA = "0x18190E970")]
			public OuterLightShowTween(RoguelikeMenuTaskObject closure)
			{
			}

			// Token: 0x0601F5F2 RID: 128498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5F2")]
			[Address(RVA = "0x190E490", Offset = "0x190D090", VA = "0x18190E490", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F5F3 RID: 128499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5F3")]
			[Address(RVA = "0x190E590", Offset = "0x190D190", VA = "0x18190E590", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F5F4 RID: 128500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F4")]
			[Address(RVA = "0x190E390", Offset = "0x190CF90", VA = "0x18190E390", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601F5F5 RID: 128501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F5")]
			[Address(RVA = "0x190E290", Offset = "0x190CE90", VA = "0x18190E290", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F5F6 RID: 128502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F6")]
			[Address(RVA = "0x190E400", Offset = "0x190D000", VA = "0x18190E400", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F5F7 RID: 128503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F7")]
			[Address(RVA = "0x190E320", Offset = "0x190CF20", VA = "0x18190E320", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601F5F8 RID: 128504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F8")]
			[Address(RVA = "0x190E690", Offset = "0x190D290", VA = "0x18190E690", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F5F9 RID: 128505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5F9")]
			[Address(RVA = "0x190E7E0", Offset = "0x190D3E0", VA = "0x18190E7E0")]
			private void _PlayLoopTween()
			{
			}

			// Token: 0x0601F5FA RID: 128506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FA")]
			[Address(RVA = "0x190E760", Offset = "0x190D360", VA = "0x18190E760")]
			private void _ClearLoopTween()
			{
			}

			// Token: 0x0601F5FB RID: 128507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FB")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601F5FC RID: 128508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FC")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F5FD RID: 128509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FD")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F5FE RID: 128510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FE")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601F5FF RID: 128511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5FF")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A28C RID: 172684
			[Token(Token = "0x402A28C")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeMenuTaskObject m_closure;

			// Token: 0x0402A28D RID: 172685
			[Token(Token = "0x402A28D")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_loopTween;

			// Token: 0x0402A28E RID: 172686
			[Token(Token = "0x402A28E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A28F RID: 172687
			[Token(Token = "0x402A28F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A290 RID: 172688
			[Token(Token = "0x402A290")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A291 RID: 172689
			[Token(Token = "0x402A291")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402A292 RID: 172690
			[Token(Token = "0x402A292")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402A293 RID: 172691
			[Token(Token = "0x402A293")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402A294 RID: 172692
			[Token(Token = "0x402A294")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402A295 RID: 172693
			[Token(Token = "0x402A295")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402A296 RID: 172694
			[Token(Token = "0x402A296")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__PlayLoopTween;

			// Token: 0x0402A297 RID: 172695
			[Token(Token = "0x402A297")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__ClearLoopTween;
		}
	}
}
