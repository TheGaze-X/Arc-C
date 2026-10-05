using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AAF RID: 23215
	[Token(Token = "0x2005AAF")]
	public class ShopDetailMonthlySubView : ShopDetailCommonView
	{
		// Token: 0x06021C2F RID: 138287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C2F")]
		[Address(RVA = "0x1C3CED0", Offset = "0x1C3BAD0", VA = "0x181C3CED0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C30 RID: 138288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C30")]
		[Address(RVA = "0x1C3D5D0", Offset = "0x1C3C1D0", VA = "0x181C3D5D0", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021C31 RID: 138289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C31")]
		[Address(RVA = "0x1C3D8A0", Offset = "0x1C3C4A0", VA = "0x181C3D8A0")]
		public ShopDetailMonthlySubView()
		{
		}

		// Token: 0x06021C32 RID: 138290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C32")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x06021C33 RID: 138291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C33")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402E322 RID: 189218
		[Token(Token = "0x402E322")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0402E323 RID: 189219
		[Token(Token = "0x402E323")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _itemText;

		// Token: 0x0402E324 RID: 189220
		[Token(Token = "0x402E324")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0402E325 RID: 189221
		[Token(Token = "0x402E325")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E326 RID: 189222
		[Token(Token = "0x402E326")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E327 RID: 189223
		[Token(Token = "0x402E327")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
