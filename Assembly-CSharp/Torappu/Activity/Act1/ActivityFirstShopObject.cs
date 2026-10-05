using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B45 RID: 31557
	[Token(Token = "0x2007B45")]
	public class ActivityFirstShopObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C2D1 RID: 180945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D1")]
		[Address(RVA = "0x2815D70", Offset = "0x2814970", VA = "0x182815D70")]
		public void OnClick()
		{
		}

		// Token: 0x0602C2D2 RID: 180946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D2")]
		[Address(RVA = "0x2815E70", Offset = "0x2814A70", VA = "0x182815E70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C2D3 RID: 180947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D3")]
		[Address(RVA = "0x28158E0", Offset = "0x28144E0", VA = "0x1828158E0")]
		public void InitData(ActivityShopData shopData)
		{
		}

		// Token: 0x0602C2D4 RID: 180948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D4")]
		[Address(RVA = "0x2816000", Offset = "0x2814C00", VA = "0x182816000")]
		public ActivityFirstShopObject()
		{
		}

		// Token: 0x040400A5 RID: 262309
		[Token(Token = "0x40400A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shopName;

		// Token: 0x040400A6 RID: 262310
		[Token(Token = "0x40400A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _priceCount;

		// Token: 0x040400A7 RID: 262311
		[Token(Token = "0x40400A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040400A8 RID: 262312
		[Token(Token = "0x40400A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x040400A9 RID: 262313
		[Token(Token = "0x40400A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x040400AA RID: 262314
		[Token(Token = "0x40400AA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _soldOutCanvas;

		// Token: 0x040400AB RID: 262315
		[Token(Token = "0x40400AB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x040400AC RID: 262316
		[Token(Token = "0x40400AC")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIActShopEvent sendEvent;

		// Token: 0x040400AD RID: 262317
		[Token(Token = "0x40400AD")]
		[FieldOffset(Offset = "0x58")]
		private ActivityShopData m_cacheShopData;

		// Token: 0x040400AE RID: 262318
		[Token(Token = "0x40400AE")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemObj;

		// Token: 0x040400AF RID: 262319
		[Token(Token = "0x40400AF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040400B0 RID: 262320
		[Token(Token = "0x40400B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040400B1 RID: 262321
		[Token(Token = "0x40400B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040400B2 RID: 262322
		[Token(Token = "0x40400B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040400B3 RID: 262323
		[Token(Token = "0x40400B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
