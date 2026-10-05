using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D46 RID: 15686
	[Token(Token = "0x2003D46")]
	public class TemplateShopSkinDetailState : PopupFloatState
	{
		// Token: 0x060186FD RID: 100093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186FD")]
		[Address(RVA = "0x10FA1F0", Offset = "0x10F8DF0", VA = "0x1810FA1F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186FE RID: 100094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186FE")]
		[Address(RVA = "0x10FA320", Offset = "0x10F8F20", VA = "0x1810FA320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186FF RID: 100095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186FF")]
		[Address(RVA = "0x10FA250", Offset = "0x10F8E50", VA = "0x1810FA250")]
		public void OnClick()
		{
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018700")]
		[Address(RVA = "0x10FA550", Offset = "0x10F9150", VA = "0x1810FA550")]
		public TemplateShopSkinDetailState()
		{
		}

		// Token: 0x06018703 RID: 100099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018703")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE56 RID: 122454
		[Token(Token = "0x401DE56")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0401DE57 RID: 122455
		[Token(Token = "0x401DE57")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateShopSkinDetailView _view;

		// Token: 0x0401DE58 RID: 122456
		[Token(Token = "0x401DE58")]
		[FieldOffset(Offset = "0x80")]
		private TemplateShopNormalDetailStateBean m_stateBean;

		// Token: 0x0401DE59 RID: 122457
		[Token(Token = "0x401DE59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE5A RID: 122458
		[Token(Token = "0x401DE5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE5B RID: 122459
		[Token(Token = "0x401DE5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401DE5C RID: 122460
		[Token(Token = "0x401DE5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
