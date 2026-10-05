using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B06 RID: 23302
	[Token(Token = "0x2005B06")]
	public class QCShopHighView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DB5 RID: 138677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB5")]
		[Address(RVA = "0x1C59370", Offset = "0x1C57F70", VA = "0x181C59370")]
		public void OnEnter(ShopPage shopPage)
		{
		}

		// Token: 0x06021DB6 RID: 138678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB6")]
		[Address(RVA = "0x1C59290", Offset = "0x1C57E90", VA = "0x181C59290")]
		public void ApplyData(GetHighGoodListResponse response)
		{
		}

		// Token: 0x06021DB7 RID: 138679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB7")]
		[Address(RVA = "0x1C59AE0", Offset = "0x1C586E0", VA = "0x181C59AE0")]
		private void _LEGACY_ApplyData(GetHighGoodListResponse response)
		{
		}

		// Token: 0x06021DB8 RID: 138680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB8")]
		[Address(RVA = "0x1C59650", Offset = "0x1C58250", VA = "0x181C59650")]
		private void _ApplyDataImpl(GetHighGoodListResponse response)
		{
		}

		// Token: 0x06021DB9 RID: 138681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB9")]
		[Address(RVA = "0x1C59D60", Offset = "0x1C58960", VA = "0x181C59D60")]
		private void _TryOpenItemDetail()
		{
		}

		// Token: 0x06021DBA RID: 138682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DBA")]
		[Address(RVA = "0x1C59E50", Offset = "0x1C58A50", VA = "0x181C59E50")]
		public QCShopHighView()
		{
		}

		// Token: 0x0402E602 RID: 189954
		[Token(Token = "0x402E602")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private QCShopHighViewModel _viewModel;

		// Token: 0x0402E603 RID: 189955
		[Token(Token = "0x402E603")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _objTransform;

		// Token: 0x0402E604 RID: 189956
		[Token(Token = "0x402E604")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QCNormalGoodItem _highObj;

		// Token: 0x0402E605 RID: 189957
		[Token(Token = "0x402E605")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private QCNormalGoodItem _progressObj;

		// Token: 0x0402E606 RID: 189958
		[Token(Token = "0x402E606")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, QCNormalGoodItem> m_itemViews;

		// Token: 0x0402E607 RID: 189959
		[Token(Token = "0x402E607")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<GameObject> m_sharedHashSet;

		// Token: 0x0402E608 RID: 189960
		[Token(Token = "0x402E608")]
		[FieldOffset(Offset = "0x48")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E609 RID: 189961
		[Token(Token = "0x402E609")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E60A RID: 189962
		[Token(Token = "0x402E60A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E60B RID: 189963
		[Token(Token = "0x402E60B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LEGACY_ApplyData;

		// Token: 0x0402E60C RID: 189964
		[Token(Token = "0x402E60C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyDataImpl;

		// Token: 0x0402E60D RID: 189965
		[Token(Token = "0x402E60D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryOpenItemDetail;

		// Token: 0x0402E60E RID: 189966
		[Token(Token = "0x402E60E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
