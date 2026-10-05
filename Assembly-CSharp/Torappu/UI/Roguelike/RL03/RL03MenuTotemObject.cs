using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200582F RID: 22575
	[Token(Token = "0x200582F")]
	public class RL03MenuTotemObject : RoguelikeMenuObject<RL03MenuTotemViewModel>
	{
		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06020FE7 RID: 135143 RVA: 0x000B8158 File Offset: 0x000B6358
		[Token(Token = "0x17004D70")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020FE7")]
			[Address(RVA = "0x1B4AA00", Offset = "0x1B49600", VA = "0x181B4AA00", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020FE8 RID: 135144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FE8")]
		[Address(RVA = "0x1B48F20", Offset = "0x1B47B20", VA = "0x181B48F20", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020FE9 RID: 135145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FE9")]
		[Address(RVA = "0x1B499B0", Offset = "0x1B485B0", VA = "0x181B499B0", Slot = "16")]
		public override void Render(RL03MenuTotemViewModel viewModel)
		{
		}

		// Token: 0x06020FEA RID: 135146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FEA")]
		[Address(RVA = "0x1B49560", Offset = "0x1B48160", VA = "0x181B49560", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x06020FEB RID: 135147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FEB")]
		[Address(RVA = "0x1B49800", Offset = "0x1B48400", VA = "0x181B49800", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020FEC RID: 135148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FEC")]
		[Address(RVA = "0x1B4A4E0", Offset = "0x1B490E0", VA = "0x181B4A4E0")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x06020FED RID: 135149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FED")]
		[Address(RVA = "0x1B4A140", Offset = "0x1B48D40", VA = "0x181B4A140")]
		private void _Render(bool fastMode)
		{
		}

		// Token: 0x06020FEE RID: 135150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FEE")]
		[Address(RVA = "0x1B4A3D0", Offset = "0x1B48FD0", VA = "0x181B4A3D0")]
		private void _TryToShowCanUseAnim()
		{
		}

		// Token: 0x06020FEF RID: 135151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FEF")]
		[Address(RVA = "0x1B4A060", Offset = "0x1B48C60", VA = "0x181B4A060")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x06020FF0 RID: 135152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF0")]
		[Address(RVA = "0x1B49FB0", Offset = "0x1B48BB0", VA = "0x181B49FB0")]
		private void _RenderPanelBack(bool show, bool fastMode)
		{
		}

		// Token: 0x06020FF1 RID: 135153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF1")]
		[Address(RVA = "0x1B49EF0", Offset = "0x1B48AF0", VA = "0x181B49EF0")]
		private void _RenderForbidden(bool forbidden, bool fastMode)
		{
		}

		// Token: 0x06020FF2 RID: 135154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF2")]
		[Address(RVA = "0x1B49E40", Offset = "0x1B48A40", VA = "0x181B49E40")]
		private void _RenderCanUsePart(bool show, bool fastMode)
		{
		}

		// Token: 0x06020FF3 RID: 135155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF3")]
		[Address(RVA = "0x1B49AF0", Offset = "0x1B486F0", VA = "0x181B49AF0")]
		private void _EventOnShowUseAnim(object arg)
		{
		}

		// Token: 0x06020FF4 RID: 135156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF4")]
		[Address(RVA = "0x1B49C90", Offset = "0x1B48890", VA = "0x181B49C90")]
		private void _OnTotemClick()
		{
		}

		// Token: 0x06020FF5 RID: 135157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FF5")]
		[Address(RVA = "0x1B4A970", Offset = "0x1B49570", VA = "0x181B4A970")]
		public RL03MenuTotemObject()
		{
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FFB")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FFC")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x06020FFD RID: 135165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FFD")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402CDD2 RID: 183762
		[Token(Token = "0x402CDD2")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402CDD3 RID: 183763
		[Token(Token = "0x402CDD3")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402CDD4 RID: 183764
		[Token(Token = "0x402CDD4")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402CDD5 RID: 183765
		[Token(Token = "0x402CDD5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Type[] STATES_SHOW_CAN_USE;

		// Token: 0x0402CDD6 RID: 183766
		[Token(Token = "0x402CDD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402CDD7 RID: 183767
		[Token(Token = "0x402CDD7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelCanUse;

		// Token: 0x0402CDD8 RID: 183768
		[Token(Token = "0x402CDD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelHaveDivination;

		// Token: 0x0402CDD9 RID: 183769
		[Token(Token = "0x402CDD9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBack;

		// Token: 0x0402CDDA RID: 183770
		[Token(Token = "0x402CDDA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animCanUse;

		// Token: 0x0402CDDB RID: 183771
		[Token(Token = "0x402CDDB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animStatusForbidden;

		// Token: 0x0402CDDC RID: 183772
		[Token(Token = "0x402CDDC")]
		[FieldOffset(Offset = "0x68")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402CDDD RID: 183773
		[Token(Token = "0x402CDDD")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_forbiddenTween;

		// Token: 0x0402CDDE RID: 183774
		[Token(Token = "0x402CDDE")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402CDDF RID: 183775
		[Token(Token = "0x402CDDF")]
		[FieldOffset(Offset = "0x80")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402CDE0 RID: 183776
		[Token(Token = "0x402CDE0")]
		[FieldOffset(Offset = "0x88")]
		private RL03MenuTotemViewModel m_cachedModel;

		// Token: 0x0402CDE1 RID: 183777
		[Token(Token = "0x402CDE1")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeMenuTotemObjectStatus m_cachedStatus;

		// Token: 0x0402CDE2 RID: 183778
		[Token(Token = "0x402CDE2")]
		[FieldOffset(Offset = "0x94")]
		private bool m_cachedStateShow;

		// Token: 0x0402CDE3 RID: 183779
		[Token(Token = "0x402CDE3")]
		[FieldOffset(Offset = "0x95")]
		private bool m_isInShowUsePartState;

		// Token: 0x0402CDE4 RID: 183780
		[Token(Token = "0x402CDE4")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_useTween;

		// Token: 0x0402CDE5 RID: 183781
		[Token(Token = "0x402CDE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402CDE6 RID: 183782
		[Token(Token = "0x402CDE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CDE7 RID: 183783
		[Token(Token = "0x402CDE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CDE8 RID: 183784
		[Token(Token = "0x402CDE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402CDE9 RID: 183785
		[Token(Token = "0x402CDE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402CDEA RID: 183786
		[Token(Token = "0x402CDEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402CDEB RID: 183787
		[Token(Token = "0x402CDEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402CDEC RID: 183788
		[Token(Token = "0x402CDEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryToShowCanUseAnim;

		// Token: 0x0402CDED RID: 183789
		[Token(Token = "0x402CDED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402CDEE RID: 183790
		[Token(Token = "0x402CDEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderPanelBack;

		// Token: 0x0402CDEF RID: 183791
		[Token(Token = "0x402CDEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderForbidden;

		// Token: 0x0402CDF0 RID: 183792
		[Token(Token = "0x402CDF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderCanUsePart;

		// Token: 0x0402CDF1 RID: 183793
		[Token(Token = "0x402CDF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnShowUseAnim;

		// Token: 0x0402CDF2 RID: 183794
		[Token(Token = "0x402CDF2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnTotemClick;

		// Token: 0x0402CDF3 RID: 183795
		[Token(Token = "0x402CDF3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
