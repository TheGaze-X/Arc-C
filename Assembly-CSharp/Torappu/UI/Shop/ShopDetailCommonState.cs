using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A9F RID: 23199
	[Token(Token = "0x2005A9F")]
	public class ShopDetailCommonState : PopupFloatState, IHotfixable, IShopDetailLayer
	{
		// Token: 0x06021BBB RID: 138171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BBB")]
		[Address(RVA = "0x1C20B90", Offset = "0x1C1F790", VA = "0x181C20B90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021BBC RID: 138172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BBC")]
		[Address(RVA = "0x1C20BF0", Offset = "0x1C1F7F0", VA = "0x181C20BF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021BBD RID: 138173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BBD")]
		[Address(RVA = "0x1C20CB0", Offset = "0x1C1F8B0", VA = "0x181C20CB0")]
		public ShopDetailCommonState()
		{
		}

		// Token: 0x06021BBE RID: 138174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BBE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E258 RID: 189016
		[Token(Token = "0x402E258")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopDetailCommonView _detailView;

		// Token: 0x0402E259 RID: 189017
		[Token(Token = "0x402E259")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E25A RID: 189018
		[Token(Token = "0x402E25A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E25B RID: 189019
		[Token(Token = "0x402E25B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
