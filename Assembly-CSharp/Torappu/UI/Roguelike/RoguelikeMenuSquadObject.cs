using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005308 RID: 21256
	[Token(Token = "0x2005308")]
	public class RoguelikeMenuSquadObject : RoguelikeMenuObject<RoguelikeMenuSquadViewModel>
	{
		// Token: 0x0601F5B2 RID: 128434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B2")]
		[Address(RVA = "0x1915780", Offset = "0x1914380", VA = "0x181915780", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x0601F5B3 RID: 128435 RVA: 0x000B1A08 File Offset: 0x000AFC08
		[Token(Token = "0x1700498A")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F5B3")]
			[Address(RVA = "0x1916B60", Offset = "0x1915760", VA = "0x181916B60", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F5B4 RID: 128436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B4")]
		[Address(RVA = "0x1916390", Offset = "0x1914F90", VA = "0x181916390")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B5")]
		[Address(RVA = "0x1916260", Offset = "0x1914E60", VA = "0x181916260")]
		private void _RenderForbiddenStatus(bool forbidden, bool fastMode)
		{
		}

		// Token: 0x0601F5B6 RID: 128438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B6")]
		[Address(RVA = "0x1916700", Offset = "0x1915300", VA = "0x181916700")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x0601F5B7 RID: 128439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B7")]
		[Address(RVA = "0x1916470", Offset = "0x1915070", VA = "0x181916470")]
		private void _Render(bool fastMode)
		{
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B8")]
		[Address(RVA = "0x1915D90", Offset = "0x1914990", VA = "0x181915D90", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B9")]
		[Address(RVA = "0x1915F10", Offset = "0x1914B10", VA = "0x181915F10", Slot = "16")]
		public override void Render(RoguelikeMenuSquadViewModel viewModel)
		{
		}

		// Token: 0x0601F5BA RID: 128442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5BA")]
		[Address(RVA = "0x1915B10", Offset = "0x1914710", VA = "0x181915B10", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F5BB RID: 128443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5BB")]
		[Address(RVA = "0x19160C0", Offset = "0x1914CC0", VA = "0x1819160C0")]
		private void _OnSquadClicked()
		{
		}

		// Token: 0x0601F5BC RID: 128444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5BC")]
		[Address(RVA = "0x1916AD0", Offset = "0x19156D0", VA = "0x181916AD0")]
		public RoguelikeMenuSquadObject()
		{
		}

		// Token: 0x0601F5C0 RID: 128448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C0")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F5C1 RID: 128449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C1")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0601F5C2 RID: 128450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C2")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402A22D RID: 172589
		[Token(Token = "0x402A22D")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402A22E RID: 172590
		[Token(Token = "0x402A22E")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402A22F RID: 172591
		[Token(Token = "0x402A22F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402A230 RID: 172592
		[Token(Token = "0x402A230")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A231 RID: 172593
		[Token(Token = "0x402A231")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RoguelikeMenuSquadSlotView> _squadSlots;

		// Token: 0x0402A232 RID: 172594
		[Token(Token = "0x402A232")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _upgradeColor;

		// Token: 0x0402A233 RID: 172595
		[Token(Token = "0x402A233")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animStatusForbidden;

		// Token: 0x0402A234 RID: 172596
		[Token(Token = "0x402A234")]
		[FieldOffset(Offset = "0x58")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402A235 RID: 172597
		[Token(Token = "0x402A235")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402A236 RID: 172598
		[Token(Token = "0x402A236")]
		[FieldOffset(Offset = "0x68")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402A237 RID: 172599
		[Token(Token = "0x402A237")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeMenuSquadViewModel m_cachedModel;

		// Token: 0x0402A238 RID: 172600
		[Token(Token = "0x402A238")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeMenuSquadObjectStatus m_cachedStatus;

		// Token: 0x0402A239 RID: 172601
		[Token(Token = "0x402A239")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_cachedStateShow;

		// Token: 0x0402A23A RID: 172602
		[Token(Token = "0x402A23A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A23B RID: 172603
		[Token(Token = "0x402A23B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A23C RID: 172604
		[Token(Token = "0x402A23C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402A23D RID: 172605
		[Token(Token = "0x402A23D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderForbiddenStatus;

		// Token: 0x0402A23E RID: 172606
		[Token(Token = "0x402A23E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402A23F RID: 172607
		[Token(Token = "0x402A23F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402A240 RID: 172608
		[Token(Token = "0x402A240")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A241 RID: 172609
		[Token(Token = "0x402A241")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A242 RID: 172610
		[Token(Token = "0x402A242")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A243 RID: 172611
		[Token(Token = "0x402A243")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSquadClicked;

		// Token: 0x0402A244 RID: 172612
		[Token(Token = "0x402A244")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
