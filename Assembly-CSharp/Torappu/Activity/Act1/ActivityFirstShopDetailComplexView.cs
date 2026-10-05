using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B43 RID: 31555
	[Token(Token = "0x2007B43")]
	public class ActivityFirstShopDetailComplexView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x0602C2C5 RID: 180933 RVA: 0x000DE558 File Offset: 0x000DC758
		[Token(Token = "0x1700677E")]
		public int ShopCount
		{
			[Token(Token = "0x602C2C5")]
			[Address(RVA = "0x2815520", Offset = "0x2814120", VA = "0x182815520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602C2C6 RID: 180934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2C6")]
		[Address(RVA = "0x2814CC0", Offset = "0x28138C0", VA = "0x182814CC0")]
		public void ApplyData(ActivityShopData viewModel)
		{
		}

		// Token: 0x0602C2C7 RID: 180935 RVA: 0x000DE570 File Offset: 0x000DC770
		[Token(Token = "0x602C2C7")]
		[Address(RVA = "0x28152F0", Offset = "0x2813EF0", VA = "0x1828152F0")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x0602C2C8 RID: 180936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2C8")]
		[Address(RVA = "0x28153B0", Offset = "0x2813FB0", VA = "0x1828153B0")]
		private void _RefreshClick()
		{
		}

		// Token: 0x0602C2C9 RID: 180937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2C9")]
		[Address(RVA = "0x2814BA0", Offset = "0x28137A0", VA = "0x182814BA0")]
		public void AddOne()
		{
		}

		// Token: 0x0602C2CA RID: 180938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2CA")]
		[Address(RVA = "0x2815210", Offset = "0x2813E10", VA = "0x182815210")]
		public void MinusOne()
		{
		}

		// Token: 0x0602C2CB RID: 180939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2CB")]
		[Address(RVA = "0x2814C10", Offset = "0x2813810", VA = "0x182814C10")]
		public void AddToMax()
		{
		}

		// Token: 0x0602C2CC RID: 180940 RVA: 0x000DE588 File Offset: 0x000DC788
		[Token(Token = "0x602C2CC")]
		[Address(RVA = "0x28150D0", Offset = "0x2813CD0", VA = "0x1828150D0")]
		public int GetMaxPrice(int price, int availCount)
		{
			return 0;
		}

		// Token: 0x0602C2CD RID: 180941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2CD")]
		[Address(RVA = "0x2815280", Offset = "0x2813E80", VA = "0x182815280")]
		public void MinusToOne()
		{
		}

		// Token: 0x0602C2CE RID: 180942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2CE")]
		[Address(RVA = "0x28154C0", Offset = "0x28140C0", VA = "0x1828154C0")]
		public ActivityFirstShopDetailComplexView()
		{
		}

		// Token: 0x04040084 RID: 262276
		[Token(Token = "0x4040084")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x04040085 RID: 262277
		[Token(Token = "0x4040085")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x04040086 RID: 262278
		[Token(Token = "0x4040086")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _shopItemTitle;

		// Token: 0x04040087 RID: 262279
		[Token(Token = "0x4040087")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _shopPerCount;

		// Token: 0x04040088 RID: 262280
		[Token(Token = "0x4040088")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x04040089 RID: 262281
		[Token(Token = "0x4040089")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0404008A RID: 262282
		[Token(Token = "0x404008A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0404008B RID: 262283
		[Token(Token = "0x404008B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _finalPriceIcon;

		// Token: 0x0404008C RID: 262284
		[Token(Token = "0x404008C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0404008D RID: 262285
		[Token(Token = "0x404008D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text _itemDetail;

		// Token: 0x0404008E RID: 262286
		[Token(Token = "0x404008E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Text _itemDetail_2;

		// Token: 0x0404008F RID: 262287
		[Token(Token = "0x404008F")]
		[FieldOffset(Offset = "0x70")]
		protected ActivityShopData m_cacheViewModel;

		// Token: 0x04040090 RID: 262288
		[Token(Token = "0x4040090")]
		[FieldOffset(Offset = "0x78")]
		private int m_shopBuyCount;

		// Token: 0x04040091 RID: 262289
		[Token(Token = "0x4040091")]
		[FieldOffset(Offset = "0x7C")]
		private int m_perPrice;

		// Token: 0x04040092 RID: 262290
		[Token(Token = "0x4040092")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ShopCount;

		// Token: 0x04040093 RID: 262291
		[Token(Token = "0x4040093")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04040094 RID: 262292
		[Token(Token = "0x4040094")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshNum;

		// Token: 0x04040095 RID: 262293
		[Token(Token = "0x4040095")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshClick;

		// Token: 0x04040096 RID: 262294
		[Token(Token = "0x4040096")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x04040097 RID: 262295
		[Token(Token = "0x4040097")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x04040098 RID: 262296
		[Token(Token = "0x4040098")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x04040099 RID: 262297
		[Token(Token = "0x4040099")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMaxPrice;

		// Token: 0x0404009A RID: 262298
		[Token(Token = "0x404009A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_MinusToOne;

		// Token: 0x0404009B RID: 262299
		[Token(Token = "0x404009B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
