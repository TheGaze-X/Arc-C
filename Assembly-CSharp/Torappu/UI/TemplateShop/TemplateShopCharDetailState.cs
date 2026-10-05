using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D3D RID: 15677
	[Token(Token = "0x2003D3D")]
	public class TemplateShopCharDetailState : PopupFloatState
	{
		// Token: 0x060186BE RID: 100030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186BE")]
		[Address(RVA = "0x10EBDF0", Offset = "0x10EA9F0", VA = "0x1810EBDF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186BF RID: 100031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186BF")]
		[Address(RVA = "0x10EBF20", Offset = "0x10EAB20", VA = "0x1810EBF20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186C0 RID: 100032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C0")]
		[Address(RVA = "0x10EBE50", Offset = "0x10EAA50", VA = "0x1810EBE50")]
		public void OnClick()
		{
		}

		// Token: 0x060186C1 RID: 100033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C1")]
		[Address(RVA = "0x10EC190", Offset = "0x10EAD90", VA = "0x1810EC190")]
		public TemplateShopCharDetailState()
		{
		}

		// Token: 0x060186C4 RID: 100036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE0F RID: 122383
		[Token(Token = "0x401DE0F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0401DE10 RID: 122384
		[Token(Token = "0x401DE10")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateShopCharDetailView _view;

		// Token: 0x0401DE11 RID: 122385
		[Token(Token = "0x401DE11")]
		[FieldOffset(Offset = "0x80")]
		private TemplateShopNormalDetailStateBean m_stateBean;

		// Token: 0x0401DE12 RID: 122386
		[Token(Token = "0x401DE12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE13 RID: 122387
		[Token(Token = "0x401DE13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE14 RID: 122388
		[Token(Token = "0x401DE14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401DE15 RID: 122389
		[Token(Token = "0x401DE15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
