using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE6 RID: 16102
	[Token(Token = "0x2003EE6")]
	public class SkinSelectPriceViewObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F9E RID: 102302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F9E")]
		[Address(RVA = "0x119F420", Offset = "0x119E020", VA = "0x18119F420")]
		public void Render(ShopSkinItemViewModel skinShopViewModel)
		{
		}

		// Token: 0x06018F9F RID: 102303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F9F")]
		[Address(RVA = "0x119F780", Offset = "0x119E380", VA = "0x18119F780")]
		public SkinSelectPriceViewObj()
		{
		}

		// Token: 0x0401ED9C RID: 126364
		[Token(Token = "0x401ED9C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _price;

		// Token: 0x0401ED9D RID: 126365
		[Token(Token = "0x401ED9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _originPrice;

		// Token: 0x0401ED9E RID: 126366
		[Token(Token = "0x401ED9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _originPricePart;

		// Token: 0x0401ED9F RID: 126367
		[Token(Token = "0x401ED9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0401EDA0 RID: 126368
		[Token(Token = "0x401EDA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EDA1 RID: 126369
		[Token(Token = "0x401EDA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
