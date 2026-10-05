using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ABC RID: 23228
	[Token(Token = "0x2005ABC")]
	public class ShopDetailSkinView : ShopDetailCommonView
	{
		// Token: 0x06021C53 RID: 138323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C53")]
		[Address(RVA = "0x1C3F860", Offset = "0x1C3E460", VA = "0x181C3F860", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C54 RID: 138324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C54")]
		[Address(RVA = "0x1C3FB60", Offset = "0x1C3E760", VA = "0x181C3FB60")]
		public ShopDetailSkinView()
		{
		}

		// Token: 0x06021C55 RID: 138325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C55")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E36D RID: 189293
		[Token(Token = "0x402E36D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x0402E36E RID: 189294
		[Token(Token = "0x402E36E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _skinName;

		// Token: 0x0402E36F RID: 189295
		[Token(Token = "0x402E36F")]
		[FieldOffset(Offset = "0xB8")]
		private UICharacterIllust m_illust;

		// Token: 0x0402E370 RID: 189296
		[Token(Token = "0x402E370")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E371 RID: 189297
		[Token(Token = "0x402E371")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E372 RID: 189298
		[Token(Token = "0x402E372")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
