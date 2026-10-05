using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF5 RID: 23285
	[Token(Token = "0x2005AF5")]
	public class QCNormalGoodItem : QCBaseGoodItem, IHotfixable
	{
		// Token: 0x06021D6C RID: 138604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6C")]
		[Address(RVA = "0x1C451D0", Offset = "0x1C43DD0", VA = "0x181C451D0")]
		public void ApplyNormalData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D6D RID: 138605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6D")]
		[Address(RVA = "0x1C45CF0", Offset = "0x1C448F0", VA = "0x181C45CF0")]
		private void _ApplyNormalData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D6E RID: 138606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6E")]
		[Address(RVA = "0x1C45380", Offset = "0x1C43F80", VA = "0x181C45380")]
		public void ApplyProgressData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D6F RID: 138607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6F")]
		[Address(RVA = "0x1C458D0", Offset = "0x1C444D0", VA = "0x181C458D0")]
		private void _ApplyGachaData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub, string gachaPoolId)
		{
		}

		// Token: 0x06021D70 RID: 138608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D70")]
		[Address(RVA = "0x1C45ED0", Offset = "0x1C44AD0", VA = "0x181C45ED0")]
		private void _ApplyNormalGachaData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D71 RID: 138609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D71")]
		[Address(RVA = "0x1C459D0", Offset = "0x1C445D0", VA = "0x181C459D0")]
		private void _ApplyGachaPoolData(QCCommonObj obj, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D72 RID: 138610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D72")]
		[Address(RVA = "0x1C46120", Offset = "0x1C44D20", VA = "0x181C46120")]
		private void _SetGachaPart(bool showFesPart)
		{
		}

		// Token: 0x06021D73 RID: 138611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D73")]
		[Address(RVA = "0x1C45860", Offset = "0x1C44460", VA = "0x181C45860")]
		public void OpenItemDetail()
		{
		}

		// Token: 0x06021D74 RID: 138612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D74")]
		[Address(RVA = "0x1C456E0", Offset = "0x1C442E0", VA = "0x181C456E0")]
		public void OnOpenGachaPage()
		{
		}

		// Token: 0x06021D75 RID: 138613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D75")]
		[Address(RVA = "0x1C455A0", Offset = "0x1C441A0", VA = "0x181C455A0")]
		public void EnterDetailEvent()
		{
		}

		// Token: 0x06021D76 RID: 138614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D76")]
		[Address(RVA = "0x1C45640", Offset = "0x1C44240", VA = "0x181C45640")]
		public void OnClick()
		{
		}

		// Token: 0x06021D77 RID: 138615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D77")]
		[Address(RVA = "0x1C461B0", Offset = "0x1C44DB0", VA = "0x181C461B0")]
		public QCNormalGoodItem()
		{
		}

		// Token: 0x0402E56E RID: 189806
		[Token(Token = "0x402E56E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _commonPart;

		// Token: 0x0402E56F RID: 189807
		[Token(Token = "0x402E56F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _gachaPart;

		// Token: 0x0402E570 RID: 189808
		[Token(Token = "0x402E570")]
		[FieldOffset(Offset = "0xB8")]
		private QCCommonObj m_cacheObj;

		// Token: 0x0402E571 RID: 189809
		[Token(Token = "0x402E571")]
		[FieldOffset(Offset = "0xC0")]
		private string m_gachaPoolId;

		// Token: 0x0402E572 RID: 189810
		[Token(Token = "0x402E572")]
		[FieldOffset(Offset = "0xC8")]
		private ShopDetailPriceType m_cachePriceType;

		// Token: 0x0402E573 RID: 189811
		[Token(Token = "0x402E573")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyNormalData;

		// Token: 0x0402E574 RID: 189812
		[Token(Token = "0x402E574")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyNormalData;

		// Token: 0x0402E575 RID: 189813
		[Token(Token = "0x402E575")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyProgressData;

		// Token: 0x0402E576 RID: 189814
		[Token(Token = "0x402E576")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyGachaData;

		// Token: 0x0402E577 RID: 189815
		[Token(Token = "0x402E577")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyNormalGachaData;

		// Token: 0x0402E578 RID: 189816
		[Token(Token = "0x402E578")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyGachaPoolData;

		// Token: 0x0402E579 RID: 189817
		[Token(Token = "0x402E579")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetGachaPart;

		// Token: 0x0402E57A RID: 189818
		[Token(Token = "0x402E57A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenItemDetail;

		// Token: 0x0402E57B RID: 189819
		[Token(Token = "0x402E57B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnOpenGachaPage;

		// Token: 0x0402E57C RID: 189820
		[Token(Token = "0x402E57C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EnterDetailEvent;

		// Token: 0x0402E57D RID: 189821
		[Token(Token = "0x402E57D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E57E RID: 189822
		[Token(Token = "0x402E57E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
