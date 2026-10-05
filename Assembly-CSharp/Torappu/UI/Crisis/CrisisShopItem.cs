using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A0E RID: 23054
	[Token(Token = "0x2005A0E")]
	public class CrisisShopItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021968 RID: 137576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021968")]
		[Address(RVA = "0x1C073E0", Offset = "0x1C05FE0", VA = "0x181C073E0")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x06021969 RID: 137577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021969")]
		[Address(RVA = "0x1C06B60", Offset = "0x1C05760", VA = "0x181C06B60")]
		public void InitData(CrisisSeasonShopWrapped shopViewModel)
		{
		}

		// Token: 0x0602196A RID: 137578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196A")]
		[Address(RVA = "0x1C063F0", Offset = "0x1C04FF0", VA = "0x181C063F0")]
		public void InitData(CrisisLongTermShopWrapped shopViewModel)
		{
		}

		// Token: 0x0602196B RID: 137579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196B")]
		[Address(RVA = "0x1C07350", Offset = "0x1C05F50", VA = "0x181C07350")]
		public void OnClick()
		{
		}

		// Token: 0x0602196C RID: 137580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196C")]
		[Address(RVA = "0x1C07590", Offset = "0x1C06190", VA = "0x181C07590")]
		public CrisisShopItem()
		{
		}

		// Token: 0x0402DE69 RID: 188009
		[Token(Token = "0x402DE69")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0402DE6A RID: 188010
		[Token(Token = "0x402DE6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _displayName;

		// Token: 0x0402DE6B RID: 188011
		[Token(Token = "0x402DE6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402DE6C RID: 188012
		[Token(Token = "0x402DE6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402DE6D RID: 188013
		[Token(Token = "0x402DE6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _tagPart;

		// Token: 0x0402DE6E RID: 188014
		[Token(Token = "0x402DE6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _remasterPart;

		// Token: 0x0402DE6F RID: 188015
		[Token(Token = "0x402DE6F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _seasonPart;

		// Token: 0x0402DE70 RID: 188016
		[Token(Token = "0x402DE70")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0402DE71 RID: 188017
		[Token(Token = "0x402DE71")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _alreadyHavePart;

		// Token: 0x0402DE72 RID: 188018
		[Token(Token = "0x402DE72")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x0402DE73 RID: 188019
		[Token(Token = "0x402DE73")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402DE74 RID: 188020
		[Token(Token = "0x402DE74")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402DE75 RID: 188021
		[Token(Token = "0x402DE75")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0402DE76 RID: 188022
		[Token(Token = "0x402DE76")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite _normalBack;

		// Token: 0x0402DE77 RID: 188023
		[Token(Token = "0x402DE77")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Sprite _progressBack;

		// Token: 0x0402DE78 RID: 188024
		[Token(Token = "0x402DE78")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _allBack;

		// Token: 0x0402DE79 RID: 188025
		[Token(Token = "0x402DE79")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _inActPart;

		// Token: 0x0402DE7A RID: 188026
		[Token(Token = "0x402DE7A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _shopIcon;

		// Token: 0x0402DE7B RID: 188027
		[Token(Token = "0x402DE7B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Sprite _crisisV1Icon;

		// Token: 0x0402DE7C RID: 188028
		[Token(Token = "0x402DE7C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite _crisisV2Icon;

		// Token: 0x0402DE7D RID: 188029
		[Token(Token = "0x402DE7D")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public CrisisShopEvent clickEvent;

		// Token: 0x0402DE7E RID: 188030
		[Token(Token = "0x402DE7E")]
		[FieldOffset(Offset = "0xC0")]
		private UIItemCard m_itemCard;

		// Token: 0x0402DE7F RID: 188031
		[Token(Token = "0x402DE7F")]
		[FieldOffset(Offset = "0xC8")]
		private CrisisShopWrapped m_cacheViewModel;

		// Token: 0x0402DE80 RID: 188032
		[Token(Token = "0x402DE80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x0402DE81 RID: 188033
		[Token(Token = "0x402DE81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402DE82 RID: 188034
		[Token(Token = "0x402DE82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_InitData;

		// Token: 0x0402DE83 RID: 188035
		[Token(Token = "0x402DE83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402DE84 RID: 188036
		[Token(Token = "0x402DE84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
