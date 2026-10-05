using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057BA RID: 22458
	[Token(Token = "0x20057BA")]
	public class RL01MenuCapsuleObject : RoguelikeMenuObject<RL01CapsuleViewModel>
	{
		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06020D92 RID: 134546 RVA: 0x000B78D0 File Offset: 0x000B5AD0
		[Token(Token = "0x17004D08")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020D92")]
			[Address(RVA = "0x1B1C0A0", Offset = "0x1B1ACA0", VA = "0x181B1C0A0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020D93 RID: 134547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D93")]
		[Address(RVA = "0x1B1BA50", Offset = "0x1B1A650", VA = "0x181B1BA50", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020D94 RID: 134548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D94")]
		[Address(RVA = "0x1B1BC80", Offset = "0x1B1A880", VA = "0x181B1BC80", Slot = "16")]
		public override void Render(RL01CapsuleViewModel viewModel)
		{
		}

		// Token: 0x06020D95 RID: 134549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D95")]
		[Address(RVA = "0x1B1C010", Offset = "0x1B1AC10", VA = "0x181B1C010")]
		public RL01MenuCapsuleObject()
		{
		}

		// Token: 0x06020D97 RID: 134551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D97")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402CA1E RID: 182814
		[Token(Token = "0x402CA1E")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402CA1F RID: 182815
		[Token(Token = "0x402CA1F")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402CA20 RID: 182816
		[Token(Token = "0x402CA20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasActive;

		// Token: 0x0402CA21 RID: 182817
		[Token(Token = "0x402CA21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402CA22 RID: 182818
		[Token(Token = "0x402CA22")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402CA23 RID: 182819
		[Token(Token = "0x402CA23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imageMask;

		// Token: 0x0402CA24 RID: 182820
		[Token(Token = "0x402CA24")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imageLight;

		// Token: 0x0402CA25 RID: 182821
		[Token(Token = "0x402CA25")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402CA26 RID: 182822
		[Token(Token = "0x402CA26")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeCapsuleViewModel m_cachedModel;

		// Token: 0x0402CA27 RID: 182823
		[Token(Token = "0x402CA27")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedItemId;

		// Token: 0x0402CA28 RID: 182824
		[Token(Token = "0x402CA28")]
		[FieldOffset(Offset = "0x68")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402CA29 RID: 182825
		[Token(Token = "0x402CA29")]
		[FieldOffset(Offset = "0x70")]
		private RL01MenuCapsuleObject.ActiveShowSwitchTween m_activeShowSwitchTween;

		// Token: 0x0402CA2A RID: 182826
		[Token(Token = "0x402CA2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402CA2B RID: 182827
		[Token(Token = "0x402CA2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CA2C RID: 182828
		[Token(Token = "0x402CA2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CA2D RID: 182829
		[Token(Token = "0x402CA2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057BB RID: 22459
		[Token(Token = "0x20057BB")]
		protected class ActiveShowSwitchTween : UISwitchTween
		{
			// Token: 0x06020D98 RID: 134552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D98")]
			[Address(RVA = "0x1B184F0", Offset = "0x1B170F0", VA = "0x181B184F0")]
			public ActiveShowSwitchTween(RL01MenuCapsuleObject closure)
			{
			}

			// Token: 0x06020D99 RID: 134553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D99")]
			[Address(RVA = "0x1B18040", Offset = "0x1B16C40", VA = "0x181B18040", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06020D9A RID: 134554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D9A")]
			[Address(RVA = "0x1B18120", Offset = "0x1B16D20", VA = "0x181B18120", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06020D9B RID: 134555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D9B")]
			[Address(RVA = "0x1B17F40", Offset = "0x1B16B40", VA = "0x181B17F40", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06020D9C RID: 134556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D9C")]
			[Address(RVA = "0x1B17E40", Offset = "0x1B16A40", VA = "0x181B17E40", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06020D9D RID: 134557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D9D")]
			[Address(RVA = "0x1B17FB0", Offset = "0x1B16BB0", VA = "0x181B17FB0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06020D9E RID: 134558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D9E")]
			[Address(RVA = "0x1B17ED0", Offset = "0x1B16AD0", VA = "0x181B17ED0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06020D9F RID: 134559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D9F")]
			[Address(RVA = "0x1B18200", Offset = "0x1B16E00", VA = "0x181B18200", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06020DA0 RID: 134560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA0")]
			[Address(RVA = "0x1B18360", Offset = "0x1B16F60", VA = "0x181B18360")]
			private void _PlayLoopTween()
			{
			}

			// Token: 0x06020DA1 RID: 134561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA1")]
			[Address(RVA = "0x1B182E0", Offset = "0x1B16EE0", VA = "0x181B182E0")]
			private void _ClearLoopTween()
			{
			}

			// Token: 0x06020DA2 RID: 134562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA2")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06020DA3 RID: 134563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA3")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06020DA4 RID: 134564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA4")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06020DA5 RID: 134565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA5")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x06020DA6 RID: 134566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020DA6")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402CA2E RID: 182830
			[Token(Token = "0x402CA2E")]
			private const float ANIM_DURATION = 0.3f;

			// Token: 0x0402CA2F RID: 182831
			[Token(Token = "0x402CA2F")]
			private const float LOOP_DURATION = 2f;

			// Token: 0x0402CA30 RID: 182832
			[Token(Token = "0x402CA30")]
			private const float ALPHA_BREATH_UP = 1f;

			// Token: 0x0402CA31 RID: 182833
			[Token(Token = "0x402CA31")]
			private const float ALPHA_BREATH_DOWN = 0.5f;

			// Token: 0x0402CA32 RID: 182834
			[Token(Token = "0x402CA32")]
			[FieldOffset(Offset = "0x48")]
			private RL01MenuCapsuleObject m_closure;

			// Token: 0x0402CA33 RID: 182835
			[Token(Token = "0x402CA33")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_loopTween;

			// Token: 0x0402CA34 RID: 182836
			[Token(Token = "0x402CA34")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CA35 RID: 182837
			[Token(Token = "0x402CA35")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402CA36 RID: 182838
			[Token(Token = "0x402CA36")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402CA37 RID: 182839
			[Token(Token = "0x402CA37")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402CA38 RID: 182840
			[Token(Token = "0x402CA38")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402CA39 RID: 182841
			[Token(Token = "0x402CA39")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402CA3A RID: 182842
			[Token(Token = "0x402CA3A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402CA3B RID: 182843
			[Token(Token = "0x402CA3B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402CA3C RID: 182844
			[Token(Token = "0x402CA3C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__PlayLoopTween;

			// Token: 0x0402CA3D RID: 182845
			[Token(Token = "0x402CA3D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__ClearLoopTween;
		}
	}
}
