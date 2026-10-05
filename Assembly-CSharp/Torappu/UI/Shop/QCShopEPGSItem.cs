using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFC RID: 23292
	[Token(Token = "0x2005AFC")]
	public class QCShopEPGSItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D90 RID: 138640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D90")]
		[Address(RVA = "0x1C49430", Offset = "0x1C48030", VA = "0x181C49430")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x06021D91 RID: 138641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D91")]
		[Address(RVA = "0x1C48FA0", Offset = "0x1C47BA0", VA = "0x181C48FA0")]
		public void Render(EPGSViewModel viewModel)
		{
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x06021D92 RID: 138642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F35")]
		public EPGSViewModel cacheViewModel
		{
			[Token(Token = "0x6021D92")]
			[Address(RVA = "0x1C49650", Offset = "0x1C48250", VA = "0x181C49650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021D93 RID: 138643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D93")]
		[Address(RVA = "0x1C493D0", Offset = "0x1C47FD0", VA = "0x181C493D0")]
		public void TryOpenDetail()
		{
		}

		// Token: 0x06021D94 RID: 138644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D94")]
		[Address(RVA = "0x1C48EF0", Offset = "0x1C47AF0", VA = "0x181C48EF0")]
		public void OnClick()
		{
		}

		// Token: 0x06021D95 RID: 138645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D95")]
		[Address(RVA = "0x1C495E0", Offset = "0x1C481E0", VA = "0x181C495E0")]
		public QCShopEPGSItem()
		{
		}

		// Token: 0x0402E5BA RID: 189882
		[Token(Token = "0x402E5BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0402E5BB RID: 189883
		[Token(Token = "0x402E5BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _cardName;

		// Token: 0x0402E5BC RID: 189884
		[Token(Token = "0x402E5BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E5BD RID: 189885
		[Token(Token = "0x402E5BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E5BE RID: 189886
		[Token(Token = "0x402E5BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E5BF RID: 189887
		[Token(Token = "0x402E5BF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E5C0 RID: 189888
		[Token(Token = "0x402E5C0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E5C1 RID: 189889
		[Token(Token = "0x402E5C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E5C2 RID: 189890
		[Token(Token = "0x402E5C2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0402E5C3 RID: 189891
		[Token(Token = "0x402E5C3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _soldOutObj;

		// Token: 0x0402E5C4 RID: 189892
		[Token(Token = "0x402E5C4")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x0402E5C5 RID: 189893
		[Token(Token = "0x402E5C5")]
		[FieldOffset(Offset = "0x70")]
		private EPGSViewModel m_cacheViewModel;

		// Token: 0x0402E5C6 RID: 189894
		[Token(Token = "0x402E5C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x0402E5C7 RID: 189895
		[Token(Token = "0x402E5C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E5C8 RID: 189896
		[Token(Token = "0x402E5C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cacheViewModel;

		// Token: 0x0402E5C9 RID: 189897
		[Token(Token = "0x402E5C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryOpenDetail;

		// Token: 0x0402E5CA RID: 189898
		[Token(Token = "0x402E5CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E5CB RID: 189899
		[Token(Token = "0x402E5CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
