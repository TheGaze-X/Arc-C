using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D69 RID: 15721
	[Token(Token = "0x2003D69")]
	public abstract class TemplateCommonShopGoodViewModel
	{
		// Token: 0x060187A9 RID: 100265
		[Token(Token = "0x60187A9")]
		public abstract bool GetBuyableFlag();

		// Token: 0x060187AA RID: 100266
		[Token(Token = "0x60187AA")]
		public abstract int GetRemainCount();

		// Token: 0x060187AB RID: 100267
		[Token(Token = "0x60187AB")]
		public abstract int GetAvailCount();

		// Token: 0x060187AC RID: 100268
		[Token(Token = "0x60187AC")]
		public abstract int GetPrice();

		// Token: 0x060187AD RID: 100269
		[Token(Token = "0x60187AD")]
		public abstract ItemBundle GetItem();

		// Token: 0x060187AE RID: 100270
		[Token(Token = "0x60187AE")]
		public abstract string GetDisplayName();

		// Token: 0x060187AF RID: 100271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187AF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TemplateCommonShopGoodViewModel()
		{
		}

		// Token: 0x0401DFD7 RID: 122839
		[Token(Token = "0x401DFD7")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0401DFD8 RID: 122840
		[Token(Token = "0x401DFD8")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0401DFD9 RID: 122841
		[Token(Token = "0x401DFD9")]
		[FieldOffset(Offset = "0x1C")]
		public TemplateShopData.GoodType goodType;
	}
}
