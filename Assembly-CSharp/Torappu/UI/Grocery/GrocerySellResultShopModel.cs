using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D06 RID: 19718
	[Token(Token = "0x2004D06")]
	public class GrocerySellResultShopModel : IHotfixable, IComparable
	{
		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x0601D8D9 RID: 121049 RVA: 0x000ABE88 File Offset: 0x000AA088
		[Token(Token = "0x17004565")]
		public GrocerySellViewModel.InquireStatus inquireStatus
		{
			[Token(Token = "0x601D8D9")]
			[Address(RVA = "0x17186A0", Offset = "0x17172A0", VA = "0x1817186A0")]
			get
			{
				return GrocerySellViewModel.InquireStatus.UNKNOWN;
			}
		}

		// Token: 0x0601D8DA RID: 121050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8DA")]
		[Address(RVA = "0x17184D0", Offset = "0x17170D0", VA = "0x1817184D0")]
		public void UpdateSelectPrice(int selectPrice)
		{
		}

		// Token: 0x0601D8DB RID: 121051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8DB")]
		[Address(RVA = "0x1718390", Offset = "0x1716F90", VA = "0x181718390")]
		public void LoadCustomerInfo(int price, int[] customerCount)
		{
		}

		// Token: 0x0601D8DC RID: 121052 RVA: 0x000ABEA0 File Offset: 0x000AA0A0
		[Token(Token = "0x601D8DC")]
		[Address(RVA = "0x1718290", Offset = "0x1716E90", VA = "0x181718290", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601D8DD RID: 121053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8DD")]
		[Address(RVA = "0x17185F0", Offset = "0x17171F0", VA = "0x1817185F0")]
		public GrocerySellResultShopModel()
		{
		}

		// Token: 0x04027018 RID: 159768
		[Token(Token = "0x4027018")]
		[FieldOffset(Offset = "0x10")]
		public string shopId;

		// Token: 0x04027019 RID: 159769
		[Token(Token = "0x4027019")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0402701A RID: 159770
		[Token(Token = "0x402701A")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0402701B RID: 159771
		[Token(Token = "0x402701B")]
		[FieldOffset(Offset = "0x28")]
		public int price;

		// Token: 0x0402701C RID: 159772
		[Token(Token = "0x402701C")]
		[FieldOffset(Offset = "0x30")]
		public GrocerySellCustomerModel currCustomerInfo;

		// Token: 0x0402701D RID: 159773
		[Token(Token = "0x402701D")]
		[FieldOffset(Offset = "0x38")]
		private List<GrocerySellCustomerModel> m_customerInfoList;

		// Token: 0x0402701E RID: 159774
		[Token(Token = "0x402701E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inquireStatus;

		// Token: 0x0402701F RID: 159775
		[Token(Token = "0x402701F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateSelectPrice;

		// Token: 0x04027020 RID: 159776
		[Token(Token = "0x4027020")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCustomerInfo;

		// Token: 0x04027021 RID: 159777
		[Token(Token = "0x4027021")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04027022 RID: 159778
		[Token(Token = "0x4027022")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
