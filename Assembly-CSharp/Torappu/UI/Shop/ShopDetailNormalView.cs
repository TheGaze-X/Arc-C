using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AB1 RID: 23217
	[Token(Token = "0x2005AB1")]
	public class ShopDetailNormalView : ShopDetailCommonView
	{
		// Token: 0x06021C35 RID: 138293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C35")]
		[Address(RVA = "0x1C3D960", Offset = "0x1C3C560", VA = "0x181C3D960", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C36 RID: 138294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C36")]
		[Address(RVA = "0x1C3DB20", Offset = "0x1C3C720", VA = "0x181C3DB20")]
		public ShopDetailNormalView()
		{
		}

		// Token: 0x06021C37 RID: 138295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C37")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E329 RID: 189225
		[Token(Token = "0x402E329")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0402E32A RID: 189226
		[Token(Token = "0x402E32A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _itemDetailCount;

		// Token: 0x0402E32B RID: 189227
		[Token(Token = "0x402E32B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E32C RID: 189228
		[Token(Token = "0x402E32C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
