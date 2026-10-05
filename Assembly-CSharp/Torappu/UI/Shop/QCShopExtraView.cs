using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B01 RID: 23297
	[Token(Token = "0x2005B01")]
	public class QCShopExtraView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DA3 RID: 138659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA3")]
		[Address(RVA = "0x1C4AC60", Offset = "0x1C49860", VA = "0x181C4AC60")]
		public void OnEnter(ShopPage page)
		{
		}

		// Token: 0x06021DA4 RID: 138660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA4")]
		[Address(RVA = "0x1C4B020", Offset = "0x1C49C20", VA = "0x181C4B020")]
		private void _ApplyData(GetExtraGoodListResponse response)
		{
		}

		// Token: 0x06021DA5 RID: 138661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA5")]
		[Address(RVA = "0x1C4B100", Offset = "0x1C49D00", VA = "0x181C4B100")]
		private void _RenderShopList()
		{
		}

		// Token: 0x06021DA6 RID: 138662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA6")]
		[Address(RVA = "0x1C4B520", Offset = "0x1C4A120", VA = "0x181C4B520")]
		private void _TryOpenItemDetail()
		{
		}

		// Token: 0x06021DA7 RID: 138663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA7")]
		[Address(RVA = "0x1C4AFB0", Offset = "0x1C49BB0", VA = "0x181C4AFB0")]
		private void Update()
		{
		}

		// Token: 0x06021DA8 RID: 138664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA8")]
		[Address(RVA = "0x1C4B660", Offset = "0x1C4A260", VA = "0x181C4B660")]
		public QCShopExtraView()
		{
		}

		// Token: 0x0402E5E4 RID: 189924
		[Token(Token = "0x402E5E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private QCShopExtraViewModel _viewModel;

		// Token: 0x0402E5E5 RID: 189925
		[Token(Token = "0x402E5E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _objTransform;

		// Token: 0x0402E5E6 RID: 189926
		[Token(Token = "0x402E5E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QCShopExtraGoodItem _extraObj;

		// Token: 0x0402E5E7 RID: 189927
		[Token(Token = "0x402E5E7")]
		[FieldOffset(Offset = "0x30")]
		private CountDownTask m_countDownTask;

		// Token: 0x0402E5E8 RID: 189928
		[Token(Token = "0x402E5E8")]
		[FieldOffset(Offset = "0x38")]
		private DateTime m_timeLimit;

		// Token: 0x0402E5E9 RID: 189929
		[Token(Token = "0x402E5E9")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<GameObject> m_sharedHashSet;

		// Token: 0x0402E5EA RID: 189930
		[Token(Token = "0x402E5EA")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, QCShopExtraGoodItem> m_itemList;

		// Token: 0x0402E5EB RID: 189931
		[Token(Token = "0x402E5EB")]
		[FieldOffset(Offset = "0x50")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E5EC RID: 189932
		[Token(Token = "0x402E5EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E5ED RID: 189933
		[Token(Token = "0x402E5ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0402E5EE RID: 189934
		[Token(Token = "0x402E5EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderShopList;

		// Token: 0x0402E5EF RID: 189935
		[Token(Token = "0x402E5EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryOpenItemDetail;

		// Token: 0x0402E5F0 RID: 189936
		[Token(Token = "0x402E5F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402E5F1 RID: 189937
		[Token(Token = "0x402E5F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
