using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B44 RID: 31556
	[Token(Token = "0x2007B44")]
	public class ActivityFirstShopDetailSingleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C2CF RID: 180943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2CF")]
		[Address(RVA = "0x2815580", Offset = "0x2814180", VA = "0x182815580")]
		public void ApplyData(ActivityShopData viewModel)
		{
		}

		// Token: 0x0602C2D0 RID: 180944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D0")]
		[Address(RVA = "0x2815880", Offset = "0x2814480", VA = "0x182815880")]
		public ActivityFirstShopDetailSingleView()
		{
		}

		// Token: 0x0404009C RID: 262300
		[Token(Token = "0x404009C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x0404009D RID: 262301
		[Token(Token = "0x404009D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemDetailCount;

		// Token: 0x0404009E RID: 262302
		[Token(Token = "0x404009E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0404009F RID: 262303
		[Token(Token = "0x404009F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Text _itemDetail;

		// Token: 0x040400A0 RID: 262304
		[Token(Token = "0x40400A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Text _itemDetail_2;

		// Token: 0x040400A1 RID: 262305
		[Token(Token = "0x40400A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x040400A2 RID: 262306
		[Token(Token = "0x40400A2")]
		[FieldOffset(Offset = "0x48")]
		protected ActivityShopData m_cacheViewModel;

		// Token: 0x040400A3 RID: 262307
		[Token(Token = "0x40400A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040400A4 RID: 262308
		[Token(Token = "0x40400A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
