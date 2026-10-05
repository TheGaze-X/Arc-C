using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ABA RID: 23226
	[Token(Token = "0x2005ABA")]
	public class ShopDetailProgressView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021C4F RID: 138319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C4F")]
		[Address(RVA = "0x1C3F2B0", Offset = "0x1C3DEB0", VA = "0x181C3F2B0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C50 RID: 138320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C50")]
		[Address(RVA = "0x1C3F7A0", Offset = "0x1C3E3A0", VA = "0x181C3F7A0")]
		public ShopDetailProgressView()
		{
		}

		// Token: 0x06021C51 RID: 138321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C51")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E366 RID: 189286
		[Token(Token = "0x402E366")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShopDetailProgressItem _unactiveItem;

		// Token: 0x0402E367 RID: 189287
		[Token(Token = "0x402E367")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ShopDetailProgressItem _acativeItem;

		// Token: 0x0402E368 RID: 189288
		[Token(Token = "0x402E368")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E369 RID: 189289
		[Token(Token = "0x402E369")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _itemDetailState;

		// Token: 0x0402E36A RID: 189290
		[Token(Token = "0x402E36A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E36B RID: 189291
		[Token(Token = "0x402E36B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
