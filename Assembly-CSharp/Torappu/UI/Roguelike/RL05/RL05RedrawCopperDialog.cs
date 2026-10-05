using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005590 RID: 21904
	[Token(Token = "0x2005590")]
	public class RL05RedrawCopperDialog : UICompDialog<RoguelikeDrawCopperViewModel>
	{
		// Token: 0x060202C8 RID: 131784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C8")]
		[Address(RVA = "0x1A56610", Offset = "0x1A55210", VA = "0x181A56610", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060202C9 RID: 131785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C9")]
		[Address(RVA = "0x1A56830", Offset = "0x1A55430", VA = "0x181A56830", Slot = "18")]
		protected override void OnRender(RoguelikeDrawCopperViewModel input)
		{
		}

		// Token: 0x060202CA RID: 131786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202CA")]
		[Address(RVA = "0x1A56950", Offset = "0x1A55550", VA = "0x181A56950")]
		private void _OnCopperExchangeDetailClicked()
		{
		}

		// Token: 0x060202CB RID: 131787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202CB")]
		[Address(RVA = "0x1A56B60", Offset = "0x1A55760", VA = "0x181A56B60")]
		public RL05RedrawCopperDialog()
		{
		}

		// Token: 0x060202CD RID: 131789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202CD")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402B7A1 RID: 178081
		[Token(Token = "0x402B7A1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL05RedrawCopperView _viewPrefab;

		// Token: 0x0402B7A2 RID: 178082
		[Token(Token = "0x402B7A2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402B7A3 RID: 178083
		[Token(Token = "0x402B7A3")]
		[FieldOffset(Offset = "0x80")]
		private RL05RedrawCopperView m_view;

		// Token: 0x0402B7A4 RID: 178084
		[Token(Token = "0x402B7A4")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeDrawCopperViewModel m_cachedModel;

		// Token: 0x0402B7A5 RID: 178085
		[Token(Token = "0x402B7A5")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402B7A6 RID: 178086
		[Token(Token = "0x402B7A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402B7A7 RID: 178087
		[Token(Token = "0x402B7A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402B7A8 RID: 178088
		[Token(Token = "0x402B7A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnCopperExchangeDetailClicked;

		// Token: 0x0402B7A9 RID: 178089
		[Token(Token = "0x402B7A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
