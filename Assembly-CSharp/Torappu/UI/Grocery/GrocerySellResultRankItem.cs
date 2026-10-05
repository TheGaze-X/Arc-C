using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D10 RID: 19728
	[Token(Token = "0x2004D10")]
	public class GrocerySellResultRankItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x0601D8FE RID: 121086 RVA: 0x000ABF78 File Offset: 0x000AA178
		[Token(Token = "0x1700456B")]
		public int cachedRank
		{
			[Token(Token = "0x601D8FE")]
			[Address(RVA = "0x1718220", Offset = "0x1716E20", VA = "0x181718220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D8FF RID: 121087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8FF")]
		[Address(RVA = "0x1717A70", Offset = "0x1716670", VA = "0x181717A70")]
		public void Render(GrocerySellResultStateSellViewModel.SellInfo model, int rank)
		{
		}

		// Token: 0x0601D900 RID: 121088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D900")]
		[Address(RVA = "0x17181A0", Offset = "0x1716DA0", VA = "0x1817181A0")]
		public GrocerySellResultRankItem()
		{
		}

		// Token: 0x0402707C RID: 159868
		[Token(Token = "0x402707C")]
		private const string PLAYER_SHOP_ICON_ANIM = "grocery_sell_result_rank_item_loop";

		// Token: 0x0402707D RID: 159869
		[Token(Token = "0x402707D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color PLAYER_COLOR;

		// Token: 0x0402707E RID: 159870
		[Token(Token = "0x402707E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color NPC_COLOR;

		// Token: 0x0402707F RID: 159871
		[Token(Token = "0x402707F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _shopIconPlayer;

		// Token: 0x04027080 RID: 159872
		[Token(Token = "0x4027080")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _shopIconNpc;

		// Token: 0x04027081 RID: 159873
		[Token(Token = "0x4027081")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _sellPriceText;

		// Token: 0x04027082 RID: 159874
		[Token(Token = "0x4027082")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _sellNumText;

		// Token: 0x04027083 RID: 159875
		[Token(Token = "0x4027083")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _sellIncomeText;

		// Token: 0x04027084 RID: 159876
		[Token(Token = "0x4027084")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _prizeIncomeText;

		// Token: 0x04027085 RID: 159877
		[Token(Token = "0x4027085")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _rankText;

		// Token: 0x04027086 RID: 159878
		[Token(Token = "0x4027086")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _sellIncomeBkg;

		// Token: 0x04027087 RID: 159879
		[Token(Token = "0x4027087")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _prizeIcon;

		// Token: 0x04027088 RID: 159880
		[Token(Token = "0x4027088")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _playerSoldOutObject;

		// Token: 0x04027089 RID: 159881
		[Token(Token = "0x4027089")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _shopIconToggle;

		// Token: 0x0402708A RID: 159882
		[Token(Token = "0x402708A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _priceTextToggle;

		// Token: 0x0402708B RID: 159883
		[Token(Token = "0x402708B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _sellTextToggle;

		// Token: 0x0402708C RID: 159884
		[Token(Token = "0x402708C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _incomeTextToggle;

		// Token: 0x0402708D RID: 159885
		[Token(Token = "0x402708D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _prizeTextToggle;

		// Token: 0x0402708E RID: 159886
		[Token(Token = "0x402708E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Shop Empty Style")]
		private TwoStateToggle _rankIconToggle;

		// Token: 0x0402708F RID: 159887
		[Token(Token = "0x402708F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04027090 RID: 159888
		[Token(Token = "0x4027090")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027091 RID: 159889
		[Token(Token = "0x4027091")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_tween;

		// Token: 0x04027092 RID: 159890
		[Token(Token = "0x4027092")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedRank;

		// Token: 0x04027093 RID: 159891
		[Token(Token = "0x4027093")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cachedRank;

		// Token: 0x04027094 RID: 159892
		[Token(Token = "0x4027094")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027095 RID: 159893
		[Token(Token = "0x4027095")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
