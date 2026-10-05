using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A83 RID: 31363
	[Token(Token = "0x2007A83")]
	public class CharmRepositoryState : PopupFadeState
	{
		// Token: 0x0602BEE6 RID: 179942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEE6")]
		[Address(RVA = "0x27E5E40", Offset = "0x27E4A40", VA = "0x1827E5E40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BEE7 RID: 179943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEE7")]
		[Address(RVA = "0x27E5F70", Offset = "0x27E4B70", VA = "0x1827E5F70", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BEE8 RID: 179944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEE8")]
		[Address(RVA = "0x27E73D0", Offset = "0x27E5FD0", VA = "0x1827E73D0")]
		private void _UpdateView()
		{
		}

		// Token: 0x0602BEE9 RID: 179945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEE9")]
		[Address(RVA = "0x27E6DF0", Offset = "0x27E59F0", VA = "0x1827E6DF0")]
		private void _PlayRecycleBtnLoop()
		{
		}

		// Token: 0x0602BEEA RID: 179946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEEA")]
		[Address(RVA = "0x27E6E90", Offset = "0x27E5A90", VA = "0x1827E6E90")]
		private void _RefreshCharmList()
		{
		}

		// Token: 0x0602BEEB RID: 179947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEEB")]
		[Address(RVA = "0x27E6700", Offset = "0x27E5300", VA = "0x1827E6700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BEEC RID: 179948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEEC")]
		[Address(RVA = "0x27E6090", Offset = "0x27E4C90", VA = "0x1827E6090")]
		private void _CheckNewUnlock()
		{
		}

		// Token: 0x0602BEED RID: 179949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEED")]
		[Address(RVA = "0x27E6640", Offset = "0x27E5240", VA = "0x1827E6640")]
		private void _HandleSortTypeChanged(string stateId)
		{
		}

		// Token: 0x0602BEEE RID: 179950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEEE")]
		[Address(RVA = "0x27E65C0", Offset = "0x27E51C0", VA = "0x1827E65C0")]
		private void _HandleFilterTypeChanged(string stateID)
		{
		}

		// Token: 0x0602BEEF RID: 179951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEEF")]
		[Address(RVA = "0x27E6470", Offset = "0x27E5070", VA = "0x1827E6470")]
		private void _HandleCharmSelectChanged(CharmCard card)
		{
		}

		// Token: 0x0602BEF0 RID: 179952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF0")]
		[Address(RVA = "0x27E71B0", Offset = "0x27E5DB0", VA = "0x1827E71B0")]
		private void _UpdateSelectView()
		{
		}

		// Token: 0x0602BEF1 RID: 179953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BEF1")]
		[Address(RVA = "0x27E5DE0", Offset = "0x27E49E0", VA = "0x1827E5DE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BEF2 RID: 179954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF2")]
		[Address(RVA = "0x27E5D50", Offset = "0x27E4950", VA = "0x1827E5D50")]
		public void EventOnUpdateDetail()
		{
		}

		// Token: 0x0602BEF3 RID: 179955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF3")]
		[Address(RVA = "0x27E5C50", Offset = "0x27E4850", VA = "0x1827E5C50")]
		public void EventOnEnterCharmSquad()
		{
		}

		// Token: 0x0602BEF4 RID: 179956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF4")]
		[Address(RVA = "0x27E5CC0", Offset = "0x27E48C0", VA = "0x1827E5CC0")]
		public void EventOnEnterRecycle()
		{
		}

		// Token: 0x0602BEF5 RID: 179957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BEF5")]
		[Address(RVA = "0x27E6310", Offset = "0x27E4F10", VA = "0x1827E6310")]
		private string _GetTheActivityOpenedMe()
		{
			return null;
		}

		// Token: 0x0602BEF6 RID: 179958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF6")]
		[Address(RVA = "0x27E7490", Offset = "0x27E6090", VA = "0x1827E7490")]
		public CharmRepositoryState()
		{
		}

		// Token: 0x0602BEF8 RID: 179960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BEF9 RID: 179961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEF9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FA1B RID: 260635
		[Token(Token = "0x403FA1B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FA1C RID: 260636
		[Token(Token = "0x403FA1C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _introduce;

		// Token: 0x0403FA1D RID: 260637
		[Token(Token = "0x403FA1D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _ownedNumLabel;

		// Token: 0x0403FA1E RID: 260638
		[Token(Token = "0x403FA1E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _totalNumLabel;

		// Token: 0x0403FA1F RID: 260639
		[Token(Token = "0x403FA1F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CharmDetailView _detailView;

		// Token: 0x0403FA20 RID: 260640
		[Token(Token = "0x403FA20")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CharmSquadSimpleView _charmSquad;

		// Token: 0x0403FA21 RID: 260641
		[Token(Token = "0x403FA21")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MultiStateToggleGroup _sortToggles;

		// Token: 0x0403FA22 RID: 260642
		[Token(Token = "0x403FA22")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private MultiStateToggleGroup _filterToggles;

		// Token: 0x0403FA23 RID: 260643
		[Token(Token = "0x403FA23")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CharmListAdapter _charmList;

		// Token: 0x0403FA24 RID: 260644
		[Token(Token = "0x403FA24")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _getAllFlag;

		// Token: 0x0403FA25 RID: 260645
		[Token(Token = "0x403FA25")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _guidebookSubSignal;

		// Token: 0x0403FA26 RID: 260646
		[Token(Token = "0x403FA26")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("RecycleStat")]
		private GameObject _recycleStat;

		// Token: 0x0403FA27 RID: 260647
		[Token(Token = "0x403FA27")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("RecycleStat")]
		private Text _recycleTotalCoin;

		// Token: 0x0403FA28 RID: 260648
		[Token(Token = "0x403FA28")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("RecycleStat")]
		private Text _recycleCnt;

		// Token: 0x0403FA29 RID: 260649
		[Token(Token = "0x403FA29")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403FA2A RID: 260650
		[Token(Token = "0x403FA2A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AnimationWrapper _leftAnim;

		// Token: 0x0403FA2B RID: 260651
		[Token(Token = "0x403FA2B")]
		private const string ANIM_ENTRY = "repo_entry";

		// Token: 0x0403FA2C RID: 260652
		[Token(Token = "0x403FA2C")]
		private const string ANIM_RECYCLE_BTN_LOOP = "repo_recycle_btn_loop";

		// Token: 0x0403FA2D RID: 260653
		[Token(Token = "0x403FA2D")]
		private const string ANIM_INTRO_TO_DETAIL = "repo_intro_detail";

		// Token: 0x0403FA2E RID: 260654
		[Token(Token = "0x403FA2E")]
		private const string ANIM_DETAIL_TO_INTRO = "repo_detail_intro";

		// Token: 0x0403FA2F RID: 260655
		[Token(Token = "0x403FA2F")]
		private const string ANIM_DETAIL_SWITCH = "repo_detail_switch";

		// Token: 0x0403FA30 RID: 260656
		[Token(Token = "0x403FA30")]
		[FieldOffset(Offset = "0xF0")]
		private List<CharmModel> m_charmModels;

		// Token: 0x0403FA31 RID: 260657
		[Token(Token = "0x403FA31")]
		[FieldOffset(Offset = "0xF8")]
		private List<CharmModel> m_showList;

		// Token: 0x0403FA32 RID: 260658
		[Token(Token = "0x403FA32")]
		[FieldOffset(Offset = "0x100")]
		private Comparison<CharmModel> m_sortFunc;

		// Token: 0x0403FA33 RID: 260659
		[Token(Token = "0x403FA33")]
		[FieldOffset(Offset = "0x108")]
		private CharmRepositoryState.CharmFilterType m_filterType;

		// Token: 0x0403FA34 RID: 260660
		[Token(Token = "0x403FA34")]
		[FieldOffset(Offset = "0x110")]
		private CharmModel m_selectedCharm;

		// Token: 0x0403FA35 RID: 260661
		[Token(Token = "0x403FA35")]
		[FieldOffset(Offset = "0x118")]
		private string m_activityID;

		// Token: 0x0403FA36 RID: 260662
		[Token(Token = "0x403FA36")]
		[FieldOffset(Offset = "0x120")]
		private int m_recycleCnt;

		// Token: 0x0403FA37 RID: 260663
		[Token(Token = "0x403FA37")]
		[FieldOffset(Offset = "0x124")]
		private bool m_updated;

		// Token: 0x0403FA38 RID: 260664
		[Token(Token = "0x403FA38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FA39 RID: 260665
		[Token(Token = "0x403FA39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FA3A RID: 260666
		[Token(Token = "0x403FA3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0403FA3B RID: 260667
		[Token(Token = "0x403FA3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayRecycleBtnLoop;

		// Token: 0x0403FA3C RID: 260668
		[Token(Token = "0x403FA3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshCharmList;

		// Token: 0x0403FA3D RID: 260669
		[Token(Token = "0x403FA3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FA3E RID: 260670
		[Token(Token = "0x403FA3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckNewUnlock;

		// Token: 0x0403FA3F RID: 260671
		[Token(Token = "0x403FA3F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleSortTypeChanged;

		// Token: 0x0403FA40 RID: 260672
		[Token(Token = "0x403FA40")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleFilterTypeChanged;

		// Token: 0x0403FA41 RID: 260673
		[Token(Token = "0x403FA41")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleCharmSelectChanged;

		// Token: 0x0403FA42 RID: 260674
		[Token(Token = "0x403FA42")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateSelectView;

		// Token: 0x0403FA43 RID: 260675
		[Token(Token = "0x403FA43")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FA44 RID: 260676
		[Token(Token = "0x403FA44")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnUpdateDetail;

		// Token: 0x0403FA45 RID: 260677
		[Token(Token = "0x403FA45")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnEnterCharmSquad;

		// Token: 0x0403FA46 RID: 260678
		[Token(Token = "0x403FA46")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnEnterRecycle;

		// Token: 0x0403FA47 RID: 260679
		[Token(Token = "0x403FA47")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetTheActivityOpenedMe;

		// Token: 0x0403FA48 RID: 260680
		[Token(Token = "0x403FA48")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A84 RID: 31364
		[Token(Token = "0x2007A84")]
		public static class SortStateID
		{
			// Token: 0x0602BEFA RID: 179962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BEFA")]
			[Address(RVA = "0x27EB710", Offset = "0x27EA310", VA = "0x1827EB710")]
			public static Comparison<CharmModel> ToSortFunc(string stateID)
			{
				return null;
			}

			// Token: 0x0602BEFB RID: 179963 RVA: 0x000DDB50 File Offset: 0x000DBD50
			[Token(Token = "0x602BEFB")]
			[Address(RVA = "0x27EB8F0", Offset = "0x27EA4F0", VA = "0x1827EB8F0")]
			private static int _SortByAscendingType(CharmModel charm1, CharmModel charm2)
			{
				return 0;
			}

			// Token: 0x0602BEFC RID: 179964 RVA: 0x000DDB68 File Offset: 0x000DBD68
			[Token(Token = "0x602BEFC")]
			[Address(RVA = "0x27EB940", Offset = "0x27EA540", VA = "0x1827EB940")]
			private static int _SortByDescendingType(CharmModel charm1, CharmModel charm2)
			{
				return 0;
			}

			// Token: 0x0602BEFD RID: 179965 RVA: 0x000DDB80 File Offset: 0x000DBD80
			[Token(Token = "0x602BEFD")]
			[Address(RVA = "0x27EB890", Offset = "0x27EA490", VA = "0x1827EB890")]
			private static int _SortByAscendingRarity(CharmModel charm1, CharmModel charm2)
			{
				return 0;
			}

			// Token: 0x0602BEFE RID: 179966 RVA: 0x000DDB98 File Offset: 0x000DBD98
			[Token(Token = "0x602BEFE")]
			[Address(RVA = "0x27EB6A0", Offset = "0x27EA2A0", VA = "0x1827EB6A0")]
			public static int SortByDescendingRarity(CharmModel charm1, CharmModel charm2)
			{
				return 0;
			}

			// Token: 0x0403FA49 RID: 260681
			[Token(Token = "0x403FA49")]
			private const string TYPE_ASCENDING = "type_ascending";

			// Token: 0x0403FA4A RID: 260682
			[Token(Token = "0x403FA4A")]
			private const string TYPE_DESCENDING = "type_descending";

			// Token: 0x0403FA4B RID: 260683
			[Token(Token = "0x403FA4B")]
			private const string RARITY_ASCENDING = "rarity_ascending";

			// Token: 0x0403FA4C RID: 260684
			[Token(Token = "0x403FA4C")]
			private const string RARITY_DESCENDING = "rarity_descending";
		}

		// Token: 0x02007A85 RID: 31365
		[Token(Token = "0x2007A85")]
		private static class FilterStateID
		{
			// Token: 0x0602BEFF RID: 179967 RVA: 0x000DDBB0 File Offset: 0x000DBDB0
			[Token(Token = "0x602BEFF")]
			[Address(RVA = "0x27EB600", Offset = "0x27EA200", VA = "0x1827EB600")]
			public static CharmRepositoryState.CharmFilterType ToFilterType(string stateID)
			{
				return CharmRepositoryState.CharmFilterType.NONE;
			}

			// Token: 0x0403FA4D RID: 260685
			[Token(Token = "0x403FA4D")]
			private const string ALL = "all";

			// Token: 0x0403FA4E RID: 260686
			[Token(Token = "0x403FA4E")]
			private const string OWNED = "owned";

			// Token: 0x0403FA4F RID: 260687
			[Token(Token = "0x403FA4F")]
			private const string NOT_OWNED = "not_owned";
		}

		// Token: 0x02007A86 RID: 31366
		[Token(Token = "0x2007A86")]
		private enum CharmFilterType
		{
			// Token: 0x0403FA51 RID: 260689
			[Token(Token = "0x403FA51")]
			NONE,
			// Token: 0x0403FA52 RID: 260690
			[Token(Token = "0x403FA52")]
			OWNED,
			// Token: 0x0403FA53 RID: 260691
			[Token(Token = "0x403FA53")]
			NOT_OWN,
			// Token: 0x0403FA54 RID: 260692
			[Token(Token = "0x403FA54")]
			ALL
		}
	}
}
