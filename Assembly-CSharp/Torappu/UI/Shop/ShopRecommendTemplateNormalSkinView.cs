using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B33 RID: 23347
	[Token(Token = "0x2005B33")]
	public class ShopRecommendTemplateNormalSkinView : ShopRecommendTemplateView<ShopRecommendTemplateNormalSkinViewModel>
	{
		// Token: 0x06021E62 RID: 138850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E62")]
		[Address(RVA = "0x1C6B390", Offset = "0x1C69F90", VA = "0x181C6B390", Slot = "6")]
		public override void Render(ShopRecommendTemplateNormalSkinViewModel viewModel)
		{
		}

		// Token: 0x06021E63 RID: 138851 RVA: 0x000BBB00 File Offset: 0x000B9D00
		[Token(Token = "0x6021E63")]
		[Address(RVA = "0x1C6BD30", Offset = "0x1C6A930", VA = "0x181C6BD30")]
		private bool _CheckIsShort(string content)
		{
			return default(bool);
		}

		// Token: 0x06021E64 RID: 138852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E64")]
		[Address(RVA = "0x1C6BF20", Offset = "0x1C6AB20", VA = "0x181C6BF20")]
		public ShopRecommendTemplateNormalSkinView()
		{
		}

		// Token: 0x0402E74A RID: 190282
		[Token(Token = "0x402E74A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _brandIcon;

		// Token: 0x0402E74B RID: 190283
		[Token(Token = "0x402E74B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _seriesName;

		// Token: 0x0402E74C RID: 190284
		[Token(Token = "0x402E74C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _startMonth;

		// Token: 0x0402E74D RID: 190285
		[Token(Token = "0x402E74D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _startDay;

		// Token: 0x0402E74E RID: 190286
		[Token(Token = "0x402E74E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _startTime;

		// Token: 0x0402E74F RID: 190287
		[Token(Token = "0x402E74F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _endMonth;

		// Token: 0x0402E750 RID: 190288
		[Token(Token = "0x402E750")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _endDay;

		// Token: 0x0402E751 RID: 190289
		[Token(Token = "0x402E751")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0402E752 RID: 190290
		[Token(Token = "0x402E752")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _skinNames;

		// Token: 0x0402E753 RID: 190291
		[Token(Token = "0x402E753")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _skinNamesShort;

		// Token: 0x0402E754 RID: 190292
		[Token(Token = "0x402E754")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _brandBack;

		// Token: 0x0402E755 RID: 190293
		[Token(Token = "0x402E755")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _btnBack;

		// Token: 0x0402E756 RID: 190294
		[Token(Token = "0x402E756")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _goText;

		// Token: 0x0402E757 RID: 190295
		[Token(Token = "0x402E757")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelShort;

		// Token: 0x0402E758 RID: 190296
		[Token(Token = "0x402E758")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelExpand;

		// Token: 0x0402E759 RID: 190297
		[Token(Token = "0x402E759")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _saleDesc;

		// Token: 0x0402E75A RID: 190298
		[Token(Token = "0x402E75A")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E75B RID: 190299
		[Token(Token = "0x402E75B")]
		[FieldOffset(Offset = "0xA8")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402E75C RID: 190300
		[Token(Token = "0x402E75C")]
		[FieldOffset(Offset = "0xB0")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402E75D RID: 190301
		[Token(Token = "0x402E75D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E75E RID: 190302
		[Token(Token = "0x402E75E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckIsShort;

		// Token: 0x0402E75F RID: 190303
		[Token(Token = "0x402E75F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
