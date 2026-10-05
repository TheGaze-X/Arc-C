using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AA0 RID: 23200
	[Token(Token = "0x2005AA0")]
	public class ShopDetailCommonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021BBF RID: 138175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BBF")]
		[Address(RVA = "0x1C20D10", Offset = "0x1C1F910", VA = "0x181C20D10", Slot = "4")]
		public virtual void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021BC0 RID: 138176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC0")]
		[Address(RVA = "0x1C21D30", Offset = "0x1C20930", VA = "0x181C21D30", Slot = "5")]
		public virtual void OnClick()
		{
		}

		// Token: 0x06021BC1 RID: 138177 RVA: 0x000BB2C0 File Offset: 0x000B94C0
		[Token(Token = "0x6021BC1")]
		[Address(RVA = "0x1C21950", Offset = "0x1C20550", VA = "0x181C21950")]
		public static int GetMaxPrice(ShopDetailPriceType itemType, int price, int maxCount)
		{
			return 0;
		}

		// Token: 0x06021BC2 RID: 138178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC2")]
		[Address(RVA = "0x1C21FE0", Offset = "0x1C20BE0", VA = "0x181C21FE0")]
		public ShopDetailCommonView()
		{
		}

		// Token: 0x0402E25C RID: 189020
		[Token(Token = "0x402E25C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("offset")]
		protected GameObject _offsetPart;

		// Token: 0x0402E25D RID: 189021
		[Token(Token = "0x402E25D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("offset")]
		protected Text _offsetText;

		// Token: 0x0402E25E RID: 189022
		[Token(Token = "0x402E25E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("originPrice")]
		protected GameObject _originPricePart;

		// Token: 0x0402E25F RID: 189023
		[Token(Token = "0x402E25F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("originPrice")]
		protected Text _originPrice;

		// Token: 0x0402E260 RID: 189024
		[Token(Token = "0x402E260")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("originPrice")]
		protected Image _originIcon;

		// Token: 0x0402E261 RID: 189025
		[Token(Token = "0x402E261")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("currentPrice")]
		protected Text _currentPrice;

		// Token: 0x0402E262 RID: 189026
		[Token(Token = "0x402E262")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("currentPrice")]
		protected Image _currentPriceIcon;

		// Token: 0x0402E263 RID: 189027
		[Token(Token = "0x402E263")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemDetail;

		// Token: 0x0402E264 RID: 189028
		[Token(Token = "0x402E264")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemDetail_2;

		// Token: 0x0402E265 RID: 189029
		[Token(Token = "0x402E265")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemName;

		// Token: 0x0402E266 RID: 189030
		[Token(Token = "0x402E266")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("timeLimit")]
		protected GameObject _timeLimitGameObject;

		// Token: 0x0402E267 RID: 189031
		[Token(Token = "0x402E267")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("timeLimit")]
		protected Text _timeLimitText;

		// Token: 0x0402E268 RID: 189032
		[Token(Token = "0x402E268")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Image _itemButton;

		// Token: 0x0402E269 RID: 189033
		[Token(Token = "0x402E269")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Text _itemButtonText;

		// Token: 0x0402E26A RID: 189034
		[Token(Token = "0x402E26A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Image _itemButtonIcon;

		// Token: 0x0402E26B RID: 189035
		[Token(Token = "0x402E26B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected UnityEvent _disMissEvent;

		// Token: 0x0402E26C RID: 189036
		[Token(Token = "0x402E26C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Text _alreadyHaveCount;

		// Token: 0x0402E26D RID: 189037
		[Token(Token = "0x402E26D")]
		[FieldOffset(Offset = "0xA0")]
		protected DetailCommonViewModel m_cacheViewModel;

		// Token: 0x0402E26E RID: 189038
		[Token(Token = "0x402E26E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E26F RID: 189039
		[Token(Token = "0x402E26F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E270 RID: 189040
		[Token(Token = "0x402E270")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMaxPrice;

		// Token: 0x0402E271 RID: 189041
		[Token(Token = "0x402E271")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
