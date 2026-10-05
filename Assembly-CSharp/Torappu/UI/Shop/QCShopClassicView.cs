using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF6 RID: 23286
	[Token(Token = "0x2005AF6")]
	public class QCShopClassicView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D78 RID: 138616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D78")]
		[Address(RVA = "0x1C46CD0", Offset = "0x1C458D0", VA = "0x181C46CD0")]
		public void OnEnter(ShopPage shopPage)
		{
		}

		// Token: 0x06021D79 RID: 138617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D79")]
		[Address(RVA = "0x1C47040", Offset = "0x1C45C40", VA = "0x181C47040")]
		private void _ApplyData(GetClassicGoodListResponse response)
		{
		}

		// Token: 0x06021D7A RID: 138618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D7A")]
		[Address(RVA = "0x1C474D0", Offset = "0x1C460D0", VA = "0x181C474D0")]
		private void _TryOpenItemDetail()
		{
		}

		// Token: 0x06021D7B RID: 138619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D7B")]
		[Address(RVA = "0x1C47650", Offset = "0x1C46250", VA = "0x181C47650")]
		public QCShopClassicView()
		{
		}

		// Token: 0x0402E57F RID: 189823
		[Token(Token = "0x402E57F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private QCShopClassicViewModel _viewModel;

		// Token: 0x0402E580 RID: 189824
		[Token(Token = "0x402E580")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _objTransform;

		// Token: 0x0402E581 RID: 189825
		[Token(Token = "0x402E581")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QCNormalGoodItem _highObj;

		// Token: 0x0402E582 RID: 189826
		[Token(Token = "0x402E582")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private QCNormalGoodItem _progressObj;

		// Token: 0x0402E583 RID: 189827
		[Token(Token = "0x402E583")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, QCNormalGoodItem> m_itemViews;

		// Token: 0x0402E584 RID: 189828
		[Token(Token = "0x402E584")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<GameObject> m_sharedHashSet;

		// Token: 0x0402E585 RID: 189829
		[Token(Token = "0x402E585")]
		[FieldOffset(Offset = "0x48")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E586 RID: 189830
		[Token(Token = "0x402E586")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E587 RID: 189831
		[Token(Token = "0x402E587")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0402E588 RID: 189832
		[Token(Token = "0x402E588")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryOpenItemDetail;

		// Token: 0x0402E589 RID: 189833
		[Token(Token = "0x402E589")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
