using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D6E RID: 15726
	[Token(Token = "0x2003D6E")]
	public class TemplateShopRarityViewModel
	{
		// Token: 0x060187C6 RID: 100294 RVA: 0x0009A938 File Offset: 0x00098B38
		[Token(Token = "0x60187C6")]
		[Address(RVA = "0x10F8750", Offset = "0x10F7350", VA = "0x1810F8750")]
		public bool IsGoodAllSoldout()
		{
			return default(bool);
		}

		// Token: 0x060187C7 RID: 100295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187C7")]
		[Address(RVA = "0x10F8830", Offset = "0x10F7430", VA = "0x1810F8830")]
		public TemplateShopRarityViewModel()
		{
		}

		// Token: 0x0401DFF0 RID: 122864
		[Token(Token = "0x401DFF0")]
		[FieldOffset(Offset = "0x10")]
		public int slotId;

		// Token: 0x0401DFF1 RID: 122865
		[Token(Token = "0x401DFF1")]
		[FieldOffset(Offset = "0x18")]
		public string bkgId;

		// Token: 0x0401DFF2 RID: 122866
		[Token(Token = "0x401DFF2")]
		[FieldOffset(Offset = "0x20")]
		public List<TemplateCommonShopGoodViewModel> goodList;
	}
}
