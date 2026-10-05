using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A8F RID: 23183
	[Token(Token = "0x2005A8F")]
	public class ShopDetailFurnGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021B6D RID: 138093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6D")]
		[Address(RVA = "0x1C23BA0", Offset = "0x1C227A0", VA = "0x181C23BA0")]
		private void _InitPriceObj(FurnGroupViewModel viewModel)
		{
		}

		// Token: 0x06021B6E RID: 138094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6E")]
		[Address(RVA = "0x1C221B0", Offset = "0x1C20DB0", VA = "0x181C221B0")]
		public void ApplyData(FurnGroupViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021B6F RID: 138095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B6F")]
		[Address(RVA = "0x1C237C0", Offset = "0x1C223C0", VA = "0x181C237C0")]
		private void _ApplyImgInfo(FurnGroupViewModel viewModel)
		{
		}

		// Token: 0x06021B70 RID: 138096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B70")]
		[Address(RVA = "0x1C22C10", Offset = "0x1C21810", VA = "0x181C22C10")]
		public void ApplyPriceState()
		{
		}

		// Token: 0x06021B71 RID: 138097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B71")]
		[Address(RVA = "0x1C23740", Offset = "0x1C22340", VA = "0x181C23740")]
		public void TurnCoinFurn()
		{
		}

		// Token: 0x06021B72 RID: 138098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B72")]
		[Address(RVA = "0x1C236B0", Offset = "0x1C222B0", VA = "0x181C236B0")]
		public void TurnCoinDiam()
		{
		}

		// Token: 0x06021B73 RID: 138099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B73")]
		[Address(RVA = "0x1C23410", Offset = "0x1C22010", VA = "0x181C23410")]
		public void DismissSelf()
		{
		}

		// Token: 0x06021B74 RID: 138100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B74")]
		[Address(RVA = "0x1C23480", Offset = "0x1C22080", VA = "0x181C23480")]
		public void OnClick()
		{
		}

		// Token: 0x06021B75 RID: 138101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B75")]
		[Address(RVA = "0x1C23CA0", Offset = "0x1C228A0", VA = "0x181C23CA0")]
		public ShopDetailFurnGroupView()
		{
		}

		// Token: 0x0402E1B1 RID: 188849
		[Token(Token = "0x402E1B1")]
		private const float PAUSE_DURATION_WHEN_ACTION = 2f;

		// Token: 0x0402E1B2 RID: 188850
		[Token(Token = "0x402E1B2")]
		private const float SWITCH_PAGE_PERIOD = 6f;

		// Token: 0x0402E1B3 RID: 188851
		[Token(Token = "0x402E1B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemName;

		// Token: 0x0402E1B4 RID: 188852
		[Token(Token = "0x402E1B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("timeLimit")]
		protected GameObject _timeLimitGameObject;

		// Token: 0x0402E1B5 RID: 188853
		[Token(Token = "0x402E1B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("timeLimit")]
		protected Text _timeLimitText;

		// Token: 0x0402E1B6 RID: 188854
		[Token(Token = "0x402E1B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Image _itemButton;

		// Token: 0x0402E1B7 RID: 188855
		[Token(Token = "0x402E1B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Text _itemButtonText;

		// Token: 0x0402E1B8 RID: 188856
		[Token(Token = "0x402E1B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image _itemButtonIcon;

		// Token: 0x0402E1B9 RID: 188857
		[Token(Token = "0x402E1B9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected UnityEvent _disMissEvent;

		// Token: 0x0402E1BA RID: 188858
		[Token(Token = "0x402E1BA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Text _atmosCount;

		// Token: 0x0402E1BB RID: 188859
		[Token(Token = "0x402E1BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ShopFurnDetailGroupText _groupText;

		// Token: 0x0402E1BC RID: 188860
		[Token(Token = "0x402E1BC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ShopFurnDetailFurnInfo _furnInfo;

		// Token: 0x0402E1BD RID: 188861
		[Token(Token = "0x402E1BD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _textContainer;

		// Token: 0x0402E1BE RID: 188862
		[Token(Token = "0x402E1BE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402E1BF RID: 188863
		[Token(Token = "0x402E1BF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _groupPicContainer;

		// Token: 0x0402E1C0 RID: 188864
		[Token(Token = "0x402E1C0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ShopDetailGroupPicView _groupPicViewPrefab;

		// Token: 0x0402E1C1 RID: 188865
		[Token(Token = "0x402E1C1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _groupPicCellSize;

		// Token: 0x0402E1C2 RID: 188866
		[Token(Token = "0x402E1C2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ThreeStateToggle _coinPart;

		// Token: 0x0402E1C3 RID: 188867
		[Token(Token = "0x402E1C3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ThreeStateToggle _diamPart;

		// Token: 0x0402E1C4 RID: 188868
		[Token(Token = "0x402E1C4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E1C5 RID: 188869
		[Token(Token = "0x402E1C5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image[] _whiteFurniIcons;

		// Token: 0x0402E1C6 RID: 188870
		[Token(Token = "0x402E1C6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image[] _whiteDiamondIcons;

		// Token: 0x0402E1C7 RID: 188871
		[Token(Token = "0x402E1C7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0402E1C8 RID: 188872
		[Token(Token = "0x402E1C8")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _currentGroupCount;

		// Token: 0x0402E1C9 RID: 188873
		[Token(Token = "0x402E1C9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image _currentGroupColor;

		// Token: 0x0402E1CA RID: 188874
		[Token(Token = "0x402E1CA")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _bothPricePart;

		// Token: 0x0402E1CB RID: 188875
		[Token(Token = "0x402E1CB")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _diamPricePart;

		// Token: 0x0402E1CC RID: 188876
		[Token(Token = "0x402E1CC")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _coinPricePart;

		// Token: 0x0402E1CD RID: 188877
		[Token(Token = "0x402E1CD")]
		[FieldOffset(Offset = "0xE8")]
		private FurnGroupViewModel m_cacheViewModel;

		// Token: 0x0402E1CE RID: 188878
		[Token(Token = "0x402E1CE")]
		[FieldOffset(Offset = "0xF0")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E1CF RID: 188879
		[Token(Token = "0x402E1CF")]
		[FieldOffset(Offset = "0xF8")]
		private ShopDetailFurnGroupView.SelectClass m_selectPriceFlag;

		// Token: 0x0402E1D0 RID: 188880
		[Token(Token = "0x402E1D0")]
		[FieldOffset(Offset = "0x100")]
		private ShopDetailGroupPicView m_groupPicView;

		// Token: 0x0402E1D1 RID: 188881
		[Token(Token = "0x402E1D1")]
		[FieldOffset(Offset = "0x108")]
		private List<Sprite> m_groupSprites;

		// Token: 0x0402E1D2 RID: 188882
		[Token(Token = "0x402E1D2")]
		[FieldOffset(Offset = "0x110")]
		private List<ShopFurnDetailFurnInfo> m_furnInfoList;

		// Token: 0x0402E1D3 RID: 188883
		[Token(Token = "0x402E1D3")]
		[FieldOffset(Offset = "0x118")]
		private List<ShopFurnDetailGroupText> m_furnTextList;

		// Token: 0x0402E1D4 RID: 188884
		[Token(Token = "0x402E1D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPriceObj;

		// Token: 0x0402E1D5 RID: 188885
		[Token(Token = "0x402E1D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E1D6 RID: 188886
		[Token(Token = "0x402E1D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyImgInfo;

		// Token: 0x0402E1D7 RID: 188887
		[Token(Token = "0x402E1D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyPriceState;

		// Token: 0x0402E1D8 RID: 188888
		[Token(Token = "0x402E1D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TurnCoinFurn;

		// Token: 0x0402E1D9 RID: 188889
		[Token(Token = "0x402E1D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TurnCoinDiam;

		// Token: 0x0402E1DA RID: 188890
		[Token(Token = "0x402E1DA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x0402E1DB RID: 188891
		[Token(Token = "0x402E1DB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E1DC RID: 188892
		[Token(Token = "0x402E1DC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A90 RID: 23184
		[Token(Token = "0x2005A90")]
		public enum SelectClass
		{
			// Token: 0x0402E1DE RID: 188894
			[Token(Token = "0x402E1DE")]
			COIN,
			// Token: 0x0402E1DF RID: 188895
			[Token(Token = "0x402E1DF")]
			DIAMOND
		}
	}
}
