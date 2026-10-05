using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B20 RID: 23328
	[Token(Token = "0x2005B20")]
	public class ShopQCConvertItemContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021E0E RID: 138766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E0E")]
		[Address(RVA = "0x1C63D60", Offset = "0x1C62960", VA = "0x181C63D60")]
		public void InitData(List<ShopQCViewModel> itemList)
		{
		}

		// Token: 0x06021E0F RID: 138767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E0F")]
		[Address(RVA = "0x1C63DF0", Offset = "0x1C629F0", VA = "0x181C63DF0")]
		public void InitResult(List<UIItemViewModel> itemList)
		{
		}

		// Token: 0x06021E10 RID: 138768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E10")]
		[Address(RVA = "0x1C63F30", Offset = "0x1C62B30", VA = "0x181C63F30")]
		public ShopQCConvertItemContainer()
		{
		}

		// Token: 0x0402E6A2 RID: 190114
		[Token(Token = "0x402E6A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _resultContainer;

		// Token: 0x0402E6A3 RID: 190115
		[Token(Token = "0x402E6A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopQCConvertResultObj _resultObj;

		// Token: 0x0402E6A4 RID: 190116
		[Token(Token = "0x402E6A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShopQCConvertListAdapter _listAdapter;

		// Token: 0x0402E6A5 RID: 190117
		[Token(Token = "0x402E6A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E6A6 RID: 190118
		[Token(Token = "0x402E6A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitResult;

		// Token: 0x0402E6A7 RID: 190119
		[Token(Token = "0x402E6A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
