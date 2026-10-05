using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B00 RID: 23296
	[Token(Token = "0x2005B00")]
	public class QCShopExtraGoodItem : QCBaseGoodItem, IHotfixable
	{
		// Token: 0x06021D9E RID: 138654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D9E")]
		[Address(RVA = "0x1C49E60", Offset = "0x1C48A60", VA = "0x181C49E60")]
		public void ApplyNormalData(QCShopExtraObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D9F RID: 138655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D9F")]
		[Address(RVA = "0x1C4A0A0", Offset = "0x1C48CA0", VA = "0x181C4A0A0", Slot = "4")]
		protected override void SetSoldOutObj(bool isSoldOut)
		{
		}

		// Token: 0x06021DA0 RID: 138656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA0")]
		[Address(RVA = "0x1C4A030", Offset = "0x1C48C30", VA = "0x181C4A030")]
		public void OpenItemDetail()
		{
		}

		// Token: 0x06021DA1 RID: 138657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA1")]
		[Address(RVA = "0x1C4A470", Offset = "0x1C49070", VA = "0x181C4A470")]
		public QCShopExtraGoodItem()
		{
		}

		// Token: 0x06021DA2 RID: 138658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DA2")]
		[Address(RVA = "0x1C44CF0", Offset = "0x1C438F0", VA = "0x181C44CF0")]
		private void <>xLuaBaseProxy_SetSoldOutObj(bool P0)
		{
		}

		// Token: 0x0402E5DB RID: 189915
		[Token(Token = "0x402E5DB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _newObj;

		// Token: 0x0402E5DC RID: 189916
		[Token(Token = "0x402E5DC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _replenishTimePart;

		// Token: 0x0402E5DD RID: 189917
		[Token(Token = "0x402E5DD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _replenishTimeText;

		// Token: 0x0402E5DE RID: 189918
		[Token(Token = "0x402E5DE")]
		[FieldOffset(Offset = "0xC0")]
		private QCShopExtraObj m_cacheObj;

		// Token: 0x0402E5DF RID: 189919
		[Token(Token = "0x402E5DF")]
		[FieldOffset(Offset = "0xC8")]
		private ShopDetailPriceType m_cachePriceType;

		// Token: 0x0402E5E0 RID: 189920
		[Token(Token = "0x402E5E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyNormalData;

		// Token: 0x0402E5E1 RID: 189921
		[Token(Token = "0x402E5E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSoldOutObj;

		// Token: 0x0402E5E2 RID: 189922
		[Token(Token = "0x402E5E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenItemDetail;

		// Token: 0x0402E5E3 RID: 189923
		[Token(Token = "0x402E5E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
