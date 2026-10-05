using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B6B RID: 23403
	[Token(Token = "0x2005B6B")]
	public class ShopSocialItemObject : MonoBehaviour
	{
		// Token: 0x06021FA7 RID: 139175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FA7")]
		[Address(RVA = "0x1C75C30", Offset = "0x1C74830", VA = "0x181C75C30")]
		public void ApplySocialData(ShopCreditViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021FA8 RID: 139176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FA8")]
		[Address(RVA = "0x1C762B0", Offset = "0x1C74EB0", VA = "0x181C762B0")]
		public void OnClick()
		{
		}

		// Token: 0x06021FA9 RID: 139177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FA9")]
		[Address(RVA = "0x1C762C0", Offset = "0x1C74EC0", VA = "0x181C762C0")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x06021FAA RID: 139178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FAA")]
		[Address(RVA = "0x1C76410", Offset = "0x1C75010", VA = "0x181C76410")]
		public ShopSocialItemObject()
		{
		}

		// Token: 0x0402E910 RID: 190736
		[Token(Token = "0x402E910")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _cardName;

		// Token: 0x0402E911 RID: 190737
		[Token(Token = "0x402E911")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _offsetPart;

		// Token: 0x0402E912 RID: 190738
		[Token(Token = "0x402E912")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _offsetPercent;

		// Token: 0x0402E913 RID: 190739
		[Token(Token = "0x402E913")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _endTimePart;

		// Token: 0x0402E914 RID: 190740
		[Token(Token = "0x402E914")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _endTimeText;

		// Token: 0x0402E915 RID: 190741
		[Token(Token = "0x402E915")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E916 RID: 190742
		[Token(Token = "0x402E916")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E917 RID: 190743
		[Token(Token = "0x402E917")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E918 RID: 190744
		[Token(Token = "0x402E918")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E919 RID: 190745
		[Token(Token = "0x402E919")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _originPrice;

		// Token: 0x0402E91A RID: 190746
		[Token(Token = "0x402E91A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E91B RID: 190747
		[Token(Token = "0x402E91B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _offsetPricePart;

		// Token: 0x0402E91C RID: 190748
		[Token(Token = "0x402E91C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E91D RID: 190749
		[Token(Token = "0x402E91D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E91E RID: 190750
		[Token(Token = "0x402E91E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0402E91F RID: 190751
		[Token(Token = "0x402E91F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _soldOutObj;

		// Token: 0x0402E920 RID: 190752
		[Token(Token = "0x402E920")]
		[FieldOffset(Offset = "0x98")]
		private ShopCreditViewModel m_cacheObj;

		// Token: 0x0402E921 RID: 190753
		[Token(Token = "0x402E921")]
		[FieldOffset(Offset = "0xA0")]
		private ShopDetailPriceType m_cachePriceType;

		// Token: 0x0402E922 RID: 190754
		[Token(Token = "0x402E922")]
		[FieldOffset(Offset = "0xA8")]
		private UIItemCard m_itemCard;
	}
}
