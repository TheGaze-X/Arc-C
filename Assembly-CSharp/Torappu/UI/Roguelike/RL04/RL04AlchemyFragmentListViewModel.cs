using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005663 RID: 22115
	[Token(Token = "0x2005663")]
	public class RL04AlchemyFragmentListViewModel : IHotfixable
	{
		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06020713 RID: 132883 RVA: 0x000B5EF0 File Offset: 0x000B40F0
		[Token(Token = "0x17004C02")]
		public RL04AlchemyFragmentListViewModel.FragmentStorageStatus status
		{
			[Token(Token = "0x6020713")]
			[Address(RVA = "0x1A95800", Offset = "0x1A94400", VA = "0x181A95800")]
			get
			{
				return RL04AlchemyFragmentListViewModel.FragmentStorageStatus.EMPTY;
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06020714 RID: 132884 RVA: 0x000B5F08 File Offset: 0x000B4108
		[Token(Token = "0x17004C03")]
		public int enterSequenceNum
		{
			[Token(Token = "0x6020714")]
			[Address(RVA = "0x1A956E0", Offset = "0x1A942E0", VA = "0x181A956E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06020715 RID: 132885 RVA: 0x000B5F20 File Offset: 0x000B4120
		[Token(Token = "0x17004C04")]
		public int listRefreshSequenceNum
		{
			[Token(Token = "0x6020715")]
			[Address(RVA = "0x1A95740", Offset = "0x1A94340", VA = "0x181A95740")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06020716 RID: 132886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C05")]
		public List<string> selectedFragmentInstIdList
		{
			[Token(Token = "0x6020716")]
			[Address(RVA = "0x1A957A0", Offset = "0x1A943A0", VA = "0x181A957A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06020717 RID: 132887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C06")]
		public List<IRL04AlchemyFragmentListItemViewModel> wholeItemViewModels
		{
			[Token(Token = "0x6020717")]
			[Address(RVA = "0x1A958C0", Offset = "0x1A944C0", VA = "0x181A958C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020718 RID: 132888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020718")]
		[Address(RVA = "0x1A94340", Offset = "0x1A92F40", VA = "0x181A94340")]
		public void LoadData(string topicId, int iSequenceNum, int maxCanSelectFragmentCount)
		{
		}

		// Token: 0x06020719 RID: 132889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020719")]
		[Address(RVA = "0x1A943F0", Offset = "0x1A92FF0", VA = "0x181A943F0")]
		public void RefreshData()
		{
		}

		// Token: 0x0602071A RID: 132890 RVA: 0x000B5F38 File Offset: 0x000B4138
		[Token(Token = "0x602071A")]
		[Address(RVA = "0x1A94670", Offset = "0x1A93270", VA = "0x181A94670")]
		public bool TryRefreshFragmentItemSelectState(string fragmentInstId, bool select)
		{
			return default(bool);
		}

		// Token: 0x0602071B RID: 132891 RVA: 0x000B5F50 File Offset: 0x000B4150
		[Token(Token = "0x602071B")]
		[Address(RVA = "0x1A94270", Offset = "0x1A92E70", VA = "0x181A94270")]
		public bool CheckIfFragmentIsSelected(string fragmentInstId)
		{
			return default(bool);
		}

		// Token: 0x0602071C RID: 132892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602071C")]
		[Address(RVA = "0x1A94580", Offset = "0x1A93180", VA = "0x181A94580")]
		public RL04AlchemyFragmentItemViewModel TryGetFragmentItemViewModel(string fragmentInstId)
		{
			return null;
		}

		// Token: 0x0602071D RID: 132893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602071D")]
		[Address(RVA = "0x1A948D0", Offset = "0x1A934D0", VA = "0x181A948D0")]
		private void _GeneListViewModel(Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.InventoryFragment> fragmentMap, RoguelikeFragmentModuleData fragmentData, RoguelikeTopicDetail detailData)
		{
		}

		// Token: 0x0602071E RID: 132894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602071E")]
		[Address(RVA = "0x1A94E70", Offset = "0x1A93A70", VA = "0x181A94E70")]
		private void _TryAddItemViewToWholeItemViewModels(ListDict<string, RL04AlchemyFragmentListItemNormalViewModel> itemNormalViewModels, Dictionary<string, RoguelikeFragmentTypeData> fragmentTypeData, ref List<IRL04AlchemyFragmentListItemViewModel> iWholeItemViewModels)
		{
		}

		// Token: 0x0602071F RID: 132895 RVA: 0x000B5F68 File Offset: 0x000B4168
		[Token(Token = "0x602071F")]
		[Address(RVA = "0x1A95360", Offset = "0x1A93F60", VA = "0x181A95360")]
		private bool _TrySelectFragmentItem(RL04AlchemyFragmentItemViewModel fragmentItemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020720 RID: 132896 RVA: 0x000B5F80 File Offset: 0x000B4180
		[Token(Token = "0x6020720")]
		[Address(RVA = "0x1A95470", Offset = "0x1A94070", VA = "0x181A95470")]
		private bool _TryUnselectFragmentItem(RL04AlchemyFragmentItemViewModel fragmentItemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020721 RID: 132897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020721")]
		[Address(RVA = "0x1A95590", Offset = "0x1A94190", VA = "0x181A95590")]
		public RL04AlchemyFragmentListViewModel()
		{
		}

		// Token: 0x0402BEF1 RID: 179953
		[Token(Token = "0x402BEF1")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicid;

		// Token: 0x0402BEF2 RID: 179954
		[Token(Token = "0x402BEF2")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSequenceNum;

		// Token: 0x0402BEF3 RID: 179955
		[Token(Token = "0x402BEF3")]
		[FieldOffset(Offset = "0x1C")]
		private int m_listRefreshSequenceNum;

		// Token: 0x0402BEF4 RID: 179956
		[Token(Token = "0x402BEF4")]
		[FieldOffset(Offset = "0x20")]
		private int m_maxCanSelectFragmentCount;

		// Token: 0x0402BEF5 RID: 179957
		[Token(Token = "0x402BEF5")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_selectedFragmentInstIdList;

		// Token: 0x0402BEF6 RID: 179958
		[Token(Token = "0x402BEF6")]
		[FieldOffset(Offset = "0x30")]
		private List<IRL04AlchemyFragmentListItemViewModel> m_wholeItemViewModels;

		// Token: 0x0402BEF7 RID: 179959
		[Token(Token = "0x402BEF7")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, RL04AlchemyFragmentListItemNormalViewModel> m_normalItemViewModels;

		// Token: 0x0402BEF8 RID: 179960
		[Token(Token = "0x402BEF8")]
		private const int ONE_ROW_ITEM_MAX_COUNT = 5;

		// Token: 0x0402BEF9 RID: 179961
		[Token(Token = "0x402BEF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x0402BEFA RID: 179962
		[Token(Token = "0x402BEFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x0402BEFB RID: 179963
		[Token(Token = "0x402BEFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_listRefreshSequenceNum;

		// Token: 0x0402BEFC RID: 179964
		[Token(Token = "0x402BEFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedFragmentInstIdList;

		// Token: 0x0402BEFD RID: 179965
		[Token(Token = "0x402BEFD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_wholeItemViewModels;

		// Token: 0x0402BEFE RID: 179966
		[Token(Token = "0x402BEFE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BEFF RID: 179967
		[Token(Token = "0x402BEFF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402BF00 RID: 179968
		[Token(Token = "0x402BF00")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryRefreshFragmentItemSelectState;

		// Token: 0x0402BF01 RID: 179969
		[Token(Token = "0x402BF01")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfFragmentIsSelected;

		// Token: 0x0402BF02 RID: 179970
		[Token(Token = "0x402BF02")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetFragmentItemViewModel;

		// Token: 0x0402BF03 RID: 179971
		[Token(Token = "0x402BF03")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GeneListViewModel;

		// Token: 0x0402BF04 RID: 179972
		[Token(Token = "0x402BF04")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryAddItemViewToWholeItemViewModels;

		// Token: 0x0402BF05 RID: 179973
		[Token(Token = "0x402BF05")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TrySelectFragmentItem;

		// Token: 0x0402BF06 RID: 179974
		[Token(Token = "0x402BF06")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryUnselectFragmentItem;

		// Token: 0x0402BF07 RID: 179975
		[Token(Token = "0x402BF07")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005664 RID: 22116
		[Token(Token = "0x2005664")]
		public enum FragmentStorageStatus
		{
			// Token: 0x0402BF09 RID: 179977
			[Token(Token = "0x402BF09")]
			EMPTY,
			// Token: 0x0402BF0A RID: 179978
			[Token(Token = "0x402BF0A")]
			HAS_FRAGMENTS
		}
	}
}
