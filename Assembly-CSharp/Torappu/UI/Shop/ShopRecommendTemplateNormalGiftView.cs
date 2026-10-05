using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B31 RID: 23345
	[Token(Token = "0x2005B31")]
	public class ShopRecommendTemplateNormalGiftView : ShopRecommendTemplateView<ShopRecommendTemplateNormalGiftViewModel>
	{
		// Token: 0x06021E55 RID: 138837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E55")]
		[Address(RVA = "0x1C6A2F0", Offset = "0x1C68EF0", VA = "0x181C6A2F0", Slot = "6")]
		public override void Render(ShopRecommendTemplateNormalGiftViewModel viewModel)
		{
		}

		// Token: 0x06021E56 RID: 138838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E56")]
		[Address(RVA = "0x1C6AA10", Offset = "0x1C69610", VA = "0x181C6AA10")]
		private Sprite _LoadLogo(string logoId)
		{
			return null;
		}

		// Token: 0x06021E57 RID: 138839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E57")]
		[Address(RVA = "0x1C6AC10", Offset = "0x1C69810", VA = "0x181C6AC10")]
		public ShopRecommendTemplateNormalGiftView()
		{
		}

		// Token: 0x0402E727 RID: 190247
		[Token(Token = "0x402E727")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _logo;

		// Token: 0x0402E728 RID: 190248
		[Token(Token = "0x402E728")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402E729 RID: 190249
		[Token(Token = "0x402E729")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _startMonth;

		// Token: 0x0402E72A RID: 190250
		[Token(Token = "0x402E72A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _startDay;

		// Token: 0x0402E72B RID: 190251
		[Token(Token = "0x402E72B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _startTime;

		// Token: 0x0402E72C RID: 190252
		[Token(Token = "0x402E72C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _endMonth;

		// Token: 0x0402E72D RID: 190253
		[Token(Token = "0x402E72D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _endDay;

		// Token: 0x0402E72E RID: 190254
		[Token(Token = "0x402E72E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0402E72F RID: 190255
		[Token(Token = "0x402E72F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E730 RID: 190256
		[Token(Token = "0x402E730")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _triangle;

		// Token: 0x0402E731 RID: 190257
		[Token(Token = "0x402E731")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _bg;

		// Token: 0x0402E732 RID: 190258
		[Token(Token = "0x402E732")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelMark;

		// Token: 0x0402E733 RID: 190259
		[Token(Token = "0x402E733")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _availCount;

		// Token: 0x0402E734 RID: 190260
		[Token(Token = "0x402E734")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E735 RID: 190261
		[Token(Token = "0x402E735")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E736 RID: 190262
		[Token(Token = "0x402E736")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadLogo;

		// Token: 0x0402E737 RID: 190263
		[Token(Token = "0x402E737")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
