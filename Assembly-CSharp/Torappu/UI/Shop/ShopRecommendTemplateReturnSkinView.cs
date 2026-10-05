using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B35 RID: 23349
	[Token(Token = "0x2005B35")]
	public class ShopRecommendTemplateReturnSkinView : ShopRecommendTemplateView<ShopRecommendTemplateReturnSkinViewModel>
	{
		// Token: 0x06021E6F RID: 138863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E6F")]
		[Address(RVA = "0x1C6C1B0", Offset = "0x1C6ADB0", VA = "0x181C6C1B0", Slot = "6")]
		public override void Render(ShopRecommendTemplateReturnSkinViewModel viewModel)
		{
		}

		// Token: 0x06021E70 RID: 138864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E70")]
		[Address(RVA = "0x1C6C5B0", Offset = "0x1C6B1B0", VA = "0x181C6C5B0")]
		public ShopRecommendTemplateReturnSkinView()
		{
		}

		// Token: 0x0402E772 RID: 190322
		[Token(Token = "0x402E772")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _startMonth;

		// Token: 0x0402E773 RID: 190323
		[Token(Token = "0x402E773")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _startDay;

		// Token: 0x0402E774 RID: 190324
		[Token(Token = "0x402E774")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _startTime;

		// Token: 0x0402E775 RID: 190325
		[Token(Token = "0x402E775")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _endMonth;

		// Token: 0x0402E776 RID: 190326
		[Token(Token = "0x402E776")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _endDay;

		// Token: 0x0402E777 RID: 190327
		[Token(Token = "0x402E777")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0402E778 RID: 190328
		[Token(Token = "0x402E778")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E779 RID: 190329
		[Token(Token = "0x402E779")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
