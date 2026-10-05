using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200530E RID: 21262
	[Token(Token = "0x200530E")]
	public class RoguelikeMenuTrapObject : RoguelikeMenuObject<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x0601F600 RID: 128512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F600")]
		[Address(RVA = "0x1919940", Offset = "0x1918540", VA = "0x181919940", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x0601F601 RID: 128513 RVA: 0x000B1B10 File Offset: 0x000AFD10
		[Token(Token = "0x1700498E")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F601")]
			[Address(RVA = "0x191A0B0", Offset = "0x1918CB0", VA = "0x18191A0B0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F602 RID: 128514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F602")]
		[Address(RVA = "0x1919A50", Offset = "0x1918650", VA = "0x181919A50", Slot = "16")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F603 RID: 128515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F603")]
		[Address(RVA = "0x1919B70", Offset = "0x1918770", VA = "0x181919B70")]
		private void _RefreshTrap(string itemId, bool isInit)
		{
		}

		// Token: 0x0601F604 RID: 128516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F604")]
		[Address(RVA = "0x1919F90", Offset = "0x1918B90", VA = "0x181919F90")]
		private void _RenderTrap(string itemId)
		{
		}

		// Token: 0x0601F605 RID: 128517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F605")]
		[Address(RVA = "0x191A040", Offset = "0x1918C40", VA = "0x18191A040")]
		public RoguelikeMenuTrapObject()
		{
		}

		// Token: 0x0601F606 RID: 128518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F606")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402A298 RID: 172696
		[Token(Token = "0x402A298")]
		private const float SHOW_ANIM_DURATION = 0.32f;

		// Token: 0x0402A299 RID: 172697
		[Token(Token = "0x402A299")]
		private const int IMAGE_ICON_ORIG_Y = 10;

		// Token: 0x0402A29A RID: 172698
		[Token(Token = "0x402A29A")]
		private const int IMAGE_ICON_DOWN_Y = -17;

		// Token: 0x0402A29B RID: 172699
		[Token(Token = "0x402A29B")]
		private const int IMAGE_ICON_UP_Y = 20;

		// Token: 0x0402A29C RID: 172700
		[Token(Token = "0x402A29C")]
		private const float IMAGE_ICON_ALPHA = 0.2f;

		// Token: 0x0402A29D RID: 172701
		[Token(Token = "0x402A29D")]
		private const float SWITCH_ANIM_DURATION = 0.2f;

		// Token: 0x0402A29E RID: 172702
		[Token(Token = "0x402A29E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A29F RID: 172703
		[Token(Token = "0x402A29F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402A2A0 RID: 172704
		[Token(Token = "0x402A2A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402A2A1 RID: 172705
		[Token(Token = "0x402A2A1")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeTrapViewModel m_cachedModel;

		// Token: 0x0402A2A2 RID: 172706
		[Token(Token = "0x402A2A2")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedItemId;

		// Token: 0x0402A2A3 RID: 172707
		[Token(Token = "0x402A2A3")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeMenuTrapObject.ShowSwitchTween m_showSwitchTween;

		// Token: 0x0402A2A4 RID: 172708
		[Token(Token = "0x402A2A4")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_refreshTween;

		// Token: 0x0402A2A5 RID: 172709
		[Token(Token = "0x402A2A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A2A6 RID: 172710
		[Token(Token = "0x402A2A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2A7 RID: 172711
		[Token(Token = "0x402A2A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2A8 RID: 172712
		[Token(Token = "0x402A2A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshTrap;

		// Token: 0x0402A2A9 RID: 172713
		[Token(Token = "0x402A2A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTrap;

		// Token: 0x0402A2AA RID: 172714
		[Token(Token = "0x402A2AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200530F RID: 21263
		[Token(Token = "0x200530F")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601F607 RID: 128519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F607")]
			[Address(RVA = "0x191F7A0", Offset = "0x191E3A0", VA = "0x18191F7A0")]
			public ShowSwitchTween(RoguelikeMenuTrapObject closure)
			{
			}

			// Token: 0x0601F608 RID: 128520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F608")]
			[Address(RVA = "0x191F400", Offset = "0x191E000", VA = "0x18191F400", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F609 RID: 128521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F609")]
			[Address(RVA = "0x191F560", Offset = "0x191E160", VA = "0x18191F560", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F60A RID: 128522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60A")]
			[Address(RVA = "0x191F2E0", Offset = "0x191DEE0", VA = "0x18191F2E0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F60B RID: 128523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60B")]
			[Address(RVA = "0x191F370", Offset = "0x191DF70", VA = "0x18191F370", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F60C RID: 128524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60C")]
			[Address(RVA = "0x191F6C0", Offset = "0x191E2C0", VA = "0x18191F6C0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F60D RID: 128525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60D")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F60E RID: 128526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60E")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F60F RID: 128527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F60F")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A2AB RID: 172715
			[Token(Token = "0x402A2AB")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeMenuTrapObject m_closure;

			// Token: 0x0402A2AC RID: 172716
			[Token(Token = "0x402A2AC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A2AD RID: 172717
			[Token(Token = "0x402A2AD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A2AE RID: 172718
			[Token(Token = "0x402A2AE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A2AF RID: 172719
			[Token(Token = "0x402A2AF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402A2B0 RID: 172720
			[Token(Token = "0x402A2B0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402A2B1 RID: 172721
			[Token(Token = "0x402A2B1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
