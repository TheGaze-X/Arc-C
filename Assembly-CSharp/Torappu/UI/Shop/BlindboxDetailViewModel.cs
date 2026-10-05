using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A8C RID: 23180
	[Token(Token = "0x2005A8C")]
	public class BlindboxDetailViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B67 RID: 138087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B67")]
		[Address(RVA = "0x1C16CE0", Offset = "0x1C158E0", VA = "0x181C16CE0")]
		public BlindboxDetailViewModel()
		{
		}

		// Token: 0x0402E19E RID: 188830
		[Token(Token = "0x402E19E")]
		[FieldOffset(Offset = "0x70")]
		public string gachaVoucherId;

		// Token: 0x0402E19F RID: 188831
		[Token(Token = "0x402E19F")]
		[FieldOffset(Offset = "0x78")]
		public string gachaVoucherName;

		// Token: 0x0402E1A0 RID: 188832
		[Token(Token = "0x402E1A0")]
		[FieldOffset(Offset = "0x80")]
		public string gachaVoucherDesc;

		// Token: 0x0402E1A1 RID: 188833
		[Token(Token = "0x402E1A1")]
		[FieldOffset(Offset = "0x88")]
		public string gachaVoucherRuleDetail;

		// Token: 0x0402E1A2 RID: 188834
		[Token(Token = "0x402E1A2")]
		[FieldOffset(Offset = "0x90")]
		public List<SkinGachaItemSkinViewModel> gachaSkins;

		// Token: 0x0402E1A3 RID: 188835
		[Token(Token = "0x402E1A3")]
		[FieldOffset(Offset = "0x98")]
		public string selectionVoucherId;

		// Token: 0x0402E1A4 RID: 188836
		[Token(Token = "0x402E1A4")]
		[FieldOffset(Offset = "0xA0")]
		public string selectionVoucherName;

		// Token: 0x0402E1A5 RID: 188837
		[Token(Token = "0x402E1A5")]
		[FieldOffset(Offset = "0xA8")]
		public string selectionVoucherDesc;

		// Token: 0x0402E1A6 RID: 188838
		[Token(Token = "0x402E1A6")]
		[FieldOffset(Offset = "0xB0")]
		public string selectionVoucherRuleDetail;

		// Token: 0x0402E1A7 RID: 188839
		[Token(Token = "0x402E1A7")]
		[FieldOffset(Offset = "0xB8")]
		public List<ItemBundle> selectionSkins;

		// Token: 0x0402E1A8 RID: 188840
		[Token(Token = "0x402E1A8")]
		[FieldOffset(Offset = "0xC0")]
		public bool showSelectionVoucherPart;

		// Token: 0x0402E1A9 RID: 188841
		[Token(Token = "0x402E1A9")]
		[FieldOffset(Offset = "0xC8")]
		public List<BlindboxDetailViewModel.BlindboxDescriptionModel> itemDescriptionList;

		// Token: 0x0402E1AA RID: 188842
		[Token(Token = "0x402E1AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A8D RID: 23181
		[Token(Token = "0x2005A8D")]
		public class BlindboxDescriptionModel
		{
			// Token: 0x06021B68 RID: 138088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B68")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BlindboxDescriptionModel()
			{
			}

			// Token: 0x0402E1AB RID: 188843
			[Token(Token = "0x402E1AB")]
			[FieldOffset(Offset = "0x10")]
			public string itemName;

			// Token: 0x0402E1AC RID: 188844
			[Token(Token = "0x402E1AC")]
			[FieldOffset(Offset = "0x18")]
			public string itemDescription;
		}
	}
}
