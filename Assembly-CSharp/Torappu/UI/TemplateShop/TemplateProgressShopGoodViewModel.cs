using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6A RID: 15722
	[Token(Token = "0x2003D6A")]
	public class TemplateProgressShopGoodViewModel : TemplateCommonShopGoodViewModel
	{
		// Token: 0x060187B0 RID: 100272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187B0")]
		[Address(RVA = "0x10EA780", Offset = "0x10E9380", VA = "0x1810EA780")]
		public TemplateShopData.ProgessGoodItem GetGoodItem()
		{
			return null;
		}

		// Token: 0x060187B1 RID: 100273 RVA: 0x0009A830 File Offset: 0x00098A30
		[Token(Token = "0x60187B1")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
		public override int GetAvailCount()
		{
			return 0;
		}

		// Token: 0x060187B2 RID: 100274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187B2")]
		[Address(RVA = "0x10EA720", Offset = "0x10E9320", VA = "0x1810EA720", Slot = "9")]
		public override string GetDisplayName()
		{
			return null;
		}

		// Token: 0x060187B3 RID: 100275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187B3")]
		[Address(RVA = "0x10EA850", Offset = "0x10E9450", VA = "0x1810EA850", Slot = "8")]
		public override ItemBundle GetItem()
		{
			return null;
		}

		// Token: 0x060187B4 RID: 100276 RVA: 0x0009A848 File Offset: 0x00098A48
		[Token(Token = "0x60187B4")]
		[Address(RVA = "0x10EA870", Offset = "0x10E9470", VA = "0x1810EA870", Slot = "7")]
		public override int GetPrice()
		{
			return 0;
		}

		// Token: 0x060187B5 RID: 100277 RVA: 0x0009A860 File Offset: 0x00098A60
		[Token(Token = "0x60187B5")]
		[Address(RVA = "0x10EA8A0", Offset = "0x10E94A0", VA = "0x1810EA8A0", Slot = "5")]
		public override int GetRemainCount()
		{
			return 0;
		}

		// Token: 0x060187B6 RID: 100278 RVA: 0x0009A878 File Offset: 0x00098A78
		[Token(Token = "0x60187B6")]
		[Address(RVA = "0x10EA6A0", Offset = "0x10E92A0", VA = "0x1810EA6A0", Slot = "4")]
		public override bool GetBuyableFlag()
		{
			return default(bool);
		}

		// Token: 0x060187B7 RID: 100279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateProgressShopGoodViewModel()
		{
		}

		// Token: 0x0401DFDA RID: 122842
		[Token(Token = "0x401DFDA")]
		[FieldOffset(Offset = "0x20")]
		public string progressGoodId;

		// Token: 0x0401DFDB RID: 122843
		[Token(Token = "0x401DFDB")]
		[FieldOffset(Offset = "0x28")]
		public List<TemplateShopData.ProgessGoodItem> progressItemList;

		// Token: 0x0401DFDC RID: 122844
		[Token(Token = "0x401DFDC")]
		[FieldOffset(Offset = "0x30")]
		public PlayerGoodProgressData playerProgressInfo;
	}
}
