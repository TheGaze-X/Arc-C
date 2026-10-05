using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007258 RID: 29272
	[Token(Token = "0x2007258")]
	public class Act5D1ShopDetailNormalView : Act5D1ShopDetailView
	{
		// Token: 0x060297C2 RID: 169922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C2")]
		[Address(RVA = "0x24E9EF0", Offset = "0x24E8AF0", VA = "0x1824E9EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060297C3 RID: 169923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C3")]
		[Address(RVA = "0x24E9CD0", Offset = "0x24E88D0", VA = "0x1824E9CD0", Slot = "4")]
		public override void ApplyData(Act5D1ShopCommonViewModel data)
		{
		}

		// Token: 0x060297C4 RID: 169924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C4")]
		[Address(RVA = "0x24EA090", Offset = "0x24E8C90", VA = "0x1824EA090")]
		public Act5D1ShopDetailNormalView()
		{
		}

		// Token: 0x060297C5 RID: 169925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C5")]
		[Address(RVA = "0x24E8F90", Offset = "0x24E7B90", VA = "0x1824E8F90")]
		private void <>xLuaBaseProxy_ApplyData(Act5D1ShopCommonViewModel P0)
		{
		}

		// Token: 0x0403B462 RID: 242786
		[Token(Token = "0x403B462")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act5D1ShopDetailItemPileView _pileView;

		// Token: 0x0403B463 RID: 242787
		[Token(Token = "0x403B463")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403B464 RID: 242788
		[Token(Token = "0x403B464")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pilePart;

		// Token: 0x0403B465 RID: 242789
		[Token(Token = "0x403B465")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPart;

		// Token: 0x0403B466 RID: 242790
		[Token(Token = "0x403B466")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemDetailCount;

		// Token: 0x0403B467 RID: 242791
		[Token(Token = "0x403B467")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _scaleCount;

		// Token: 0x0403B468 RID: 242792
		[Token(Token = "0x403B468")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B469 RID: 242793
		[Token(Token = "0x403B469")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403B46A RID: 242794
		[Token(Token = "0x403B46A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B46B RID: 242795
		[Token(Token = "0x403B46B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B46C RID: 242796
		[Token(Token = "0x403B46C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
