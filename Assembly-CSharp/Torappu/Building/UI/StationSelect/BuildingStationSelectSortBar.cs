using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C95 RID: 7317
	[Token(Token = "0x2001C95")]
	public class BuildingStationSelectSortBar : DataBinder<StationCharGroupProperty>
	{
		// Token: 0x0600B598 RID: 46488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B598")]
		[Address(RVA = "0x3311D80", Offset = "0x3310980", VA = "0x183311D80", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B599")]
		[Address(RVA = "0x3312920", Offset = "0x3311520", VA = "0x183312920")]
		private void _RefreshSort(StationOrderStruct orderStruct, bool roomTypeChanged)
		{
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59A")]
		[Address(RVA = "0x3312760", Offset = "0x3311360", VA = "0x183312760")]
		private void _RefreshSortItems(StationCharGroupViewModel viewModel)
		{
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59B")]
		[Address(RVA = "0x3312520", Offset = "0x3311120", VA = "0x183312520")]
		private void _RefreshFilter(StationOrderStruct orderStruct)
		{
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59C")]
		[Address(RVA = "0x3312170", Offset = "0x3310D70", VA = "0x183312170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59D")]
		[Address(RVA = "0x3311D00", Offset = "0x3310900", VA = "0x183311D00")]
		public void EventOnClickStationFilterBar()
		{
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59E")]
		[Address(RVA = "0x33124A0", Offset = "0x33110A0", VA = "0x1833124A0")]
		private void _OnSortClicked(CharSortType sortType)
		{
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B59F")]
		[Address(RVA = "0x3312400", Offset = "0x3311000", VA = "0x183312400")]
		private void _OnFilterItemClicked(BuildingData.CharStationFilterType filterType)
		{
		}

		// Token: 0x0600B5A0 RID: 46496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A0")]
		[Address(RVA = "0x3312AA0", Offset = "0x33116A0", VA = "0x183312AA0")]
		public BuildingStationSelectSortBar()
		{
		}

		// Token: 0x0400B218 RID: 45592
		[Token(Token = "0x400B218")]
		private const float STATION_PANEL_FILTER_DURATION_FADE = 0.2f;

		// Token: 0x0400B219 RID: 45593
		[Token(Token = "0x400B219")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingStationSelectSortItem[] _sortItems;

		// Token: 0x0400B21A RID: 45594
		[Token(Token = "0x400B21A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingStationSelectStationStatusFilterItem[] _filterItems;

		// Token: 0x0400B21B RID: 45595
		[Token(Token = "0x400B21B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Stationed Filter")]
		private TwoStateToggle _filterNoFilterArrowStatus;

		// Token: 0x0400B21C RID: 45596
		[Token(Token = "0x400B21C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Stationed Filter")]
		private TwoStateToggle _filterWithFilterArrowStatus;

		// Token: 0x0400B21D RID: 45597
		[Token(Token = "0x400B21D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Stationed Filter")]
		private TwoStateToggle _filterStatus;

		// Token: 0x0400B21E RID: 45598
		[Token(Token = "0x400B21E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Stationed Filter")]
		private Text _textFilterType;

		// Token: 0x0400B21F RID: 45599
		[Token(Token = "0x400B21F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Stationed Filter")]
		private CanvasGroup _canvasGroupFilterPanel;

		// Token: 0x0400B220 RID: 45600
		[Token(Token = "0x400B220")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<CharSortType> onSortClicked;

		// Token: 0x0400B221 RID: 45601
		[Token(Token = "0x400B221")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<bool> onFilterShowHideClicked;

		// Token: 0x0400B222 RID: 45602
		[Token(Token = "0x400B222")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<BuildingData.CharStationFilterType> onFilterItemClicked;

		// Token: 0x0400B223 RID: 45603
		[Token(Token = "0x400B223")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0400B224 RID: 45604
		[Token(Token = "0x400B224")]
		[FieldOffset(Offset = "0x74")]
		private CharSortType m_sortType;

		// Token: 0x0400B225 RID: 45605
		[Token(Token = "0x400B225")]
		[FieldOffset(Offset = "0x78")]
		private BuildingData.CharStationFilterType m_filterType;

		// Token: 0x0400B226 RID: 45606
		[Token(Token = "0x400B226")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isInverse;

		// Token: 0x0400B227 RID: 45607
		[Token(Token = "0x400B227")]
		[FieldOffset(Offset = "0x7D")]
		private bool m_isShowStationFilter;

		// Token: 0x0400B228 RID: 45608
		[Token(Token = "0x400B228")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_stationFilterSwitchTween;

		// Token: 0x0400B229 RID: 45609
		[Token(Token = "0x400B229")]
		[FieldOffset(Offset = "0x88")]
		private BuildingData.RoomType m_roomType;

		// Token: 0x0400B22A RID: 45610
		[Token(Token = "0x400B22A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B22B RID: 45611
		[Token(Token = "0x400B22B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshSort;

		// Token: 0x0400B22C RID: 45612
		[Token(Token = "0x400B22C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshSortItems;

		// Token: 0x0400B22D RID: 45613
		[Token(Token = "0x400B22D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshFilter;

		// Token: 0x0400B22E RID: 45614
		[Token(Token = "0x400B22E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B22F RID: 45615
		[Token(Token = "0x400B22F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickStationFilterBar;

		// Token: 0x0400B230 RID: 45616
		[Token(Token = "0x400B230")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSortClicked;

		// Token: 0x0400B231 RID: 45617
		[Token(Token = "0x400B231")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFilterItemClicked;

		// Token: 0x0400B232 RID: 45618
		[Token(Token = "0x400B232")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
