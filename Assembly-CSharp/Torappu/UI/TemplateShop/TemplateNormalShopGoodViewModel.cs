using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6B RID: 15723
	[Token(Token = "0x2003D6B")]
	[Serializable]
	public class TemplateNormalShopGoodViewModel : TemplateCommonShopGoodViewModel
	{
		// Token: 0x060187B8 RID: 100280 RVA: 0x0009A890 File Offset: 0x00098A90
		[Token(Token = "0x60187B8")]
		[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80", Slot = "6")]
		public override int GetAvailCount()
		{
			return 0;
		}

		// Token: 0x060187B9 RID: 100281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187B9")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "9")]
		public override string GetDisplayName()
		{
			return null;
		}

		// Token: 0x060187BA RID: 100282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187BA")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "8")]
		public override ItemBundle GetItem()
		{
			return null;
		}

		// Token: 0x060187BB RID: 100283 RVA: 0x0009A8A8 File Offset: 0x00098AA8
		[Token(Token = "0x60187BB")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "7")]
		public override int GetPrice()
		{
			return 0;
		}

		// Token: 0x060187BC RID: 100284 RVA: 0x0009A8C0 File Offset: 0x00098AC0
		[Token(Token = "0x60187BC")]
		[Address(RVA = "0x10EA710", Offset = "0x10E9310", VA = "0x1810EA710", Slot = "5")]
		public override int GetRemainCount()
		{
			return 0;
		}

		// Token: 0x060187BD RID: 100285 RVA: 0x0009A8D8 File Offset: 0x00098AD8
		[Token(Token = "0x60187BD")]
		[Address(RVA = "0x10EA6A0", Offset = "0x10E92A0", VA = "0x1810EA6A0", Slot = "4")]
		public override bool GetBuyableFlag()
		{
			return default(bool);
		}

		// Token: 0x060187BE RID: 100286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187BE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateNormalShopGoodViewModel()
		{
		}

		// Token: 0x0401DFDD RID: 122845
		[Token(Token = "0x401DFDD")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;

		// Token: 0x0401DFDE RID: 122846
		[Token(Token = "0x401DFDE")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle item;

		// Token: 0x0401DFDF RID: 122847
		[Token(Token = "0x401DFDF")]
		[FieldOffset(Offset = "0x30")]
		public string progressGoodId;

		// Token: 0x0401DFE0 RID: 122848
		[Token(Token = "0x401DFE0")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x0401DFE1 RID: 122849
		[Token(Token = "0x401DFE1")]
		[FieldOffset(Offset = "0x3C")]
		public int availCount;

		// Token: 0x0401DFE2 RID: 122850
		[Token(Token = "0x401DFE2")]
		[FieldOffset(Offset = "0x40")]
		public int buyCount;
	}
}
