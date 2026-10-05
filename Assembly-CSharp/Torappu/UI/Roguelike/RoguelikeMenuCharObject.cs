using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052FA RID: 21242
	[Token(Token = "0x20052FA")]
	public class RoguelikeMenuCharObject : RoguelikeMenuObject<RoguelikeMenuCharViewModel>
	{
		// Token: 0x0601F548 RID: 128328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F548")]
		[Address(RVA = "0x190F820", Offset = "0x190E420", VA = "0x18190F820", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x0601F549 RID: 128329 RVA: 0x000B1888 File Offset: 0x000AFA88
		[Token(Token = "0x17004983")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F549")]
			[Address(RVA = "0x1910FB0", Offset = "0x190FBB0", VA = "0x181910FB0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F54A RID: 128330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54A")]
		[Address(RVA = "0x1910700", Offset = "0x190F300", VA = "0x181910700")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F54B RID: 128331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54B")]
		[Address(RVA = "0x1910650", Offset = "0x190F250", VA = "0x181910650")]
		private void _RenderPanelBack(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F54C RID: 128332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54C")]
		[Address(RVA = "0x19107E0", Offset = "0x190F3E0", VA = "0x1819107E0")]
		private void _RenderValid(bool valid, bool fastMode)
		{
		}

		// Token: 0x0601F54D RID: 128333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54D")]
		[Address(RVA = "0x1910520", Offset = "0x190F120", VA = "0x181910520")]
		private void _RenderForbidden(bool forbidden, bool fastMode)
		{
		}

		// Token: 0x0601F54E RID: 128334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54E")]
		[Address(RVA = "0x1910B50", Offset = "0x190F750", VA = "0x181910B50")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x0601F54F RID: 128335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F54F")]
		[Address(RVA = "0x19108C0", Offset = "0x190F4C0", VA = "0x1819108C0")]
		private void _Render(bool fastMode)
		{
		}

		// Token: 0x0601F550 RID: 128336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F550")]
		[Address(RVA = "0x1910140", Offset = "0x190ED40", VA = "0x181910140", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F551 RID: 128337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F551")]
		[Address(RVA = "0x190FFC0", Offset = "0x190EBC0", VA = "0x18190FFC0", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F552 RID: 128338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F552")]
		[Address(RVA = "0x1910210", Offset = "0x190EE10", VA = "0x181910210", Slot = "16")]
		public override void Render(RoguelikeMenuCharViewModel viewModel)
		{
		}

		// Token: 0x0601F553 RID: 128339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F553")]
		[Address(RVA = "0x190FD10", Offset = "0x190E910", VA = "0x18190FD10", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F554 RID: 128340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F554")]
		[Address(RVA = "0x19103A0", Offset = "0x190EFA0", VA = "0x1819103A0")]
		private void _OnCharRepoClicked()
		{
		}

		// Token: 0x0601F555 RID: 128341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F555")]
		[Address(RVA = "0x1910F20", Offset = "0x190FB20", VA = "0x181910F20")]
		public RoguelikeMenuCharObject()
		{
		}

		// Token: 0x0601F55B RID: 128347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F55B")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F55C RID: 128348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F55C")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0601F55D RID: 128349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F55D")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0601F55E RID: 128350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F55E")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402A17F RID: 172415
		[Token(Token = "0x402A17F")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402A180 RID: 172416
		[Token(Token = "0x402A180")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402A181 RID: 172417
		[Token(Token = "0x402A181")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402A182 RID: 172418
		[Token(Token = "0x402A182")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A183 RID: 172419
		[Token(Token = "0x402A183")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlBack;

		// Token: 0x0402A184 RID: 172420
		[Token(Token = "0x402A184")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCharCount;

		// Token: 0x0402A185 RID: 172421
		[Token(Token = "0x402A185")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animStatusHide;

		// Token: 0x0402A186 RID: 172422
		[Token(Token = "0x402A186")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animStatusForbidden;

		// Token: 0x0402A187 RID: 172423
		[Token(Token = "0x402A187")]
		[FieldOffset(Offset = "0x60")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402A188 RID: 172424
		[Token(Token = "0x402A188")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402A189 RID: 172425
		[Token(Token = "0x402A189")]
		[FieldOffset(Offset = "0x70")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402A18A RID: 172426
		[Token(Token = "0x402A18A")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeMenuCharViewModel m_cachedModel;

		// Token: 0x0402A18B RID: 172427
		[Token(Token = "0x402A18B")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeMenuCharObjectStatus m_cachedStatus;

		// Token: 0x0402A18C RID: 172428
		[Token(Token = "0x402A18C")]
		[FieldOffset(Offset = "0x84")]
		private bool m_cachedStateShow;

		// Token: 0x0402A18D RID: 172429
		[Token(Token = "0x402A18D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A18E RID: 172430
		[Token(Token = "0x402A18E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A18F RID: 172431
		[Token(Token = "0x402A18F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402A190 RID: 172432
		[Token(Token = "0x402A190")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPanelBack;

		// Token: 0x0402A191 RID: 172433
		[Token(Token = "0x402A191")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderValid;

		// Token: 0x0402A192 RID: 172434
		[Token(Token = "0x402A192")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderForbidden;

		// Token: 0x0402A193 RID: 172435
		[Token(Token = "0x402A193")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402A194 RID: 172436
		[Token(Token = "0x402A194")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402A195 RID: 172437
		[Token(Token = "0x402A195")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A196 RID: 172438
		[Token(Token = "0x402A196")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A197 RID: 172439
		[Token(Token = "0x402A197")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A198 RID: 172440
		[Token(Token = "0x402A198")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A199 RID: 172441
		[Token(Token = "0x402A199")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCharRepoClicked;

		// Token: 0x0402A19A RID: 172442
		[Token(Token = "0x402A19A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
