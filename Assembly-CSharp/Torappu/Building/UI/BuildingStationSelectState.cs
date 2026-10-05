using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.UI.StationSelect;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001BAE RID: 7086
	[Token(Token = "0x2001BAE")]
	public class BuildingStationSelectState : UIPopupState, IBuildingSelectController
	{
		// Token: 0x0600B0AA RID: 45226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0AA")]
		[Address(RVA = "0x32A7370", Offset = "0x32A5F70", VA = "0x1832A7370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B0AB RID: 45227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0AB")]
		[Address(RVA = "0x32A8590", Offset = "0x32A7190", VA = "0x1832A8590")]
		private void Start()
		{
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x000437D0 File Offset: 0x000419D0
		[Token(Token = "0x600B0AC")]
		[Address(RVA = "0x32A87C0", Offset = "0x32A73C0", VA = "0x1832A87C0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0AD")]
		[Address(RVA = "0x32A81D0", Offset = "0x32A6DD0", VA = "0x1832A81D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0AE")]
		[Address(RVA = "0x32A7AE0", Offset = "0x32A66E0", VA = "0x1832A7AE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0AF")]
		[Address(RVA = "0x32A8160", Offset = "0x32A6D60", VA = "0x1832A8160", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B0")]
		[Address(RVA = "0x32A7200", Offset = "0x32A5E00", VA = "0x1832A7200")]
		public void EventOnShowFilterBar(bool isShow)
		{
		}

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B1")]
		[Address(RVA = "0x32A7120", Offset = "0x32A5D20", VA = "0x1832A7120")]
		public void EventOnFilter(UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B2")]
		[Address(RVA = "0x32A6F70", Offset = "0x32A5B70", VA = "0x1832A6F70")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B3")]
		[Address(RVA = "0x32A6F00", Offset = "0x32A5B00", VA = "0x1832A6F00")]
		public void EventOnClearClicked()
		{
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014F1")]
		protected BuildingStationSelectState.IPlugin plugin
		{
			[Token(Token = "0x600B0B4")]
			[Address(RVA = "0x32AA1C0", Offset = "0x32A8DC0", VA = "0x1832AA1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B5")]
		[Address(RVA = "0x32A9F00", Offset = "0x32A8B00", VA = "0x1832A9F00")]
		private void _TryUpdateFilterPanelShow(bool isFilterPanelShow)
		{
		}

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0B6")]
		[Address(RVA = "0x32A91A0", Offset = "0x32A7DA0", VA = "0x1832A91A0")]
		private AnimationSwitchTween _EnsureSortPanelSwitchAnim()
		{
			return null;
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B7")]
		[Address(RVA = "0x32A9D10", Offset = "0x32A8910", VA = "0x1832A9D10")]
		private void _OnSortPanelSwitch(bool isShow)
		{
		}

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B8")]
		[Address(RVA = "0x32A8830", Offset = "0x32A7430", VA = "0x1832A8830")]
		private void _BindSortFilter()
		{
		}

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0B9")]
		[Address(RVA = "0x32A9E40", Offset = "0x32A8A40", VA = "0x1832A9E40")]
		private void _RefreshPanelSwitch()
		{
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0BA")]
		[Address(RVA = "0x32A8D40", Offset = "0x32A7940", VA = "0x1832A8D40")]
		private void _DefaultEventOnConfirmClicked()
		{
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x000437E8 File Offset: 0x000419E8
		[Token(Token = "0x600B0BB")]
		[Address(RVA = "0x32A8960", Offset = "0x32A7560", VA = "0x1832A8960")]
		private BuildingStationSelectState.SelectDormLockCharResult _CheckWillDormLockCharMove(BuildingModel buildingModel, RoomSlotModel slotModel, List<BuildingCharModel> selectedChars)
		{
			return BuildingStationSelectState.SelectDormLockCharResult.NoLock;
		}

		// Token: 0x0600B0BC RID: 45244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0BC")]
		[Address(RVA = "0x32A98D0", Offset = "0x32A84D0", VA = "0x1832A98D0")]
		private void _OnJumpToSelectConfirmState(StationSelectConfirmStateBean selectConfirmBean)
		{
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0BD")]
		[Address(RVA = "0x32A9830", Offset = "0x32A8430", VA = "0x1832A9830")]
		private void _OnJumpBackFromSelectConfirmState(StationSelectConfirmStateBean selectConfirmBean)
		{
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0BE")]
		[Address(RVA = "0x32A9550", Offset = "0x32A8150", VA = "0x1832A9550")]
		private void _OnCharClicked(StationCharViewModel clickedChar)
		{
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x00043800 File Offset: 0x00041A00
		[Token(Token = "0x600B0BF")]
		[Address(RVA = "0x32A9290", Offset = "0x32A7E90", VA = "0x1832A9290")]
		private BuildingStationSelectState.SelectResultModel _GenSelectedCharForRequest()
		{
			return default(BuildingStationSelectState.SelectResultModel);
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C0")]
		[Address(RVA = "0x32A9C80", Offset = "0x32A8880", VA = "0x1832A9C80")]
		private void _OnSortItemClicked(CharSortType sortType)
		{
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C1")]
		[Address(RVA = "0x32A97A0", Offset = "0x32A83A0", VA = "0x1832A97A0")]
		private void _OnFilterShowHideClicked(bool isShow)
		{
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C2")]
		[Address(RVA = "0x32A9710", Offset = "0x32A8310", VA = "0x1832A9710")]
		private void _OnFilterItemClicked(BuildingData.CharStationFilterType stationFilterType)
		{
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C3")]
		[Address(RVA = "0x32A8330", Offset = "0x32A6F30", VA = "0x1832A8330", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C4")]
		[Address(RVA = "0x32A7880", Offset = "0x32A6480", VA = "0x1832A7880", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C5")]
		[Address(RVA = "0x32A8470", Offset = "0x32A7070", VA = "0x1832A8470", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C6")]
		[Address(RVA = "0x32A79C0", Offset = "0x32A65C0", VA = "0x1832A79C0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C7")]
		[Address(RVA = "0x32A9FA0", Offset = "0x32A8BA0", VA = "0x1832A9FA0")]
		private IEnumerator _TweenAnimation(UIAnimationLocation anim)
		{
			return null;
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C8")]
		[Address(RVA = "0x32A7760", Offset = "0x32A6360", VA = "0x1832A7760", Slot = "30")]
		public StationCharViewModel GetCharSelectMutuallyExclusiveInfo(int instId, StationSelectStateBean stationSelectBean)
		{
			return null;
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C9")]
		[Address(RVA = "0x32A73D0", Offset = "0x32A5FD0", VA = "0x1832A73D0")]
		public StationCharViewModel GetCharSelectMutuallyExclusiveInfo(int instId, StationSelectStateBean selectStateBean, StationCharGroupViewModel groupViewModel)
		{
			return null;
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0CA")]
		[Address(RVA = "0x32A7820", Offset = "0x32A6420", VA = "0x1832A7820", Slot = "29")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x00043818 File Offset: 0x00041A18
		[Token(Token = "0x600B0CB")]
		[Address(RVA = "0x32A6B40", Offset = "0x32A5740", VA = "0x1832A6B40", Slot = "31")]
		public bool CheckIfCharValid(int instId)
		{
			return default(bool);
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0CC")]
		[Address(RVA = "0x32AA080", Offset = "0x32A8C80", VA = "0x1832AA080")]
		public BuildingStationSelectState()
		{
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x00043830 File Offset: 0x00041A30
		[Token(Token = "0x600B0D0")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0D1")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0D2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0D3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400AB1B RID: 43803
		[Token(Token = "0x400AB1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400AB1C RID: 43804
		[Token(Token = "0x400AB1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingStationSelectCharList _charList;

		// Token: 0x0400AB1D RID: 43805
		[Token(Token = "0x400AB1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingStationSelectRoomInfoView _roomInfo;

		// Token: 0x0400AB1E RID: 43806
		[Token(Token = "0x400AB1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingStationSelectCharInfoView _charInfo;

		// Token: 0x0400AB1F RID: 43807
		[Token(Token = "0x400AB1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuildingStationSelectSortBar _sortBar;

		// Token: 0x0400AB20 RID: 43808
		[Token(Token = "0x400AB20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingStationSelectBuffList _buffList;

		// Token: 0x0400AB21 RID: 43809
		[Token(Token = "0x400AB21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildingStationSelectContentController _contentController;

		// Token: 0x0400AB22 RID: 43810
		[Token(Token = "0x400AB22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _btnClear;

		// Token: 0x0400AB23 RID: 43811
		[Token(Token = "0x400AB23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Effect")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0400AB24 RID: 43812
		[Token(Token = "0x400AB24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Effect")]
		private UIAnimationLocation _exitAnim;

		// Token: 0x0400AB25 RID: 43813
		[Token(Token = "0x400AB25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private BuildingStationSelectMaskPlugin _stationSelectionPluginPrefab;

		// Token: 0x0400AB26 RID: 43814
		[Token(Token = "0x400AB26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private BuildingStationCharacterSortFilterPanelBinder _sortFilterPanelBinder;

		// Token: 0x0400AB27 RID: 43815
		[Token(Token = "0x400AB27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _filterAnimLoc;

		// Token: 0x0400AB28 RID: 43816
		[Token(Token = "0x400AB28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("DormLock")]
		private GameObject _panelLockSelectInfo;

		// Token: 0x0400AB29 RID: 43817
		[Token(Token = "0x400AB29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("DormLock")]
		private TwoStateToggle _confirmBtnStateToggle;

		// Token: 0x0400AB2A RID: 43818
		[Token(Token = "0x400AB2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private StationSelectStateBean m_stateBean;

		// Token: 0x0400AB2B RID: 43819
		[Token(Token = "0x400AB2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AnimationSwitchTween m_filterSwitchAnim;

		// Token: 0x0400AB2C RID: 43820
		[Token(Token = "0x400AB2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400AB2D RID: 43821
		[Token(Token = "0x400AB2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private IntHashSet m_cachedConfirmPreQueueHash;

		// Token: 0x0400AB2E RID: 43822
		[Token(Token = "0x400AB2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AB2F RID: 43823
		[Token(Token = "0x400AB2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400AB30 RID: 43824
		[Token(Token = "0x400AB30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400AB31 RID: 43825
		[Token(Token = "0x400AB31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400AB32 RID: 43826
		[Token(Token = "0x400AB32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AB33 RID: 43827
		[Token(Token = "0x400AB33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AB34 RID: 43828
		[Token(Token = "0x400AB34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnShowFilterBar;

		// Token: 0x0400AB35 RID: 43829
		[Token(Token = "0x400AB35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnFilter;

		// Token: 0x0400AB36 RID: 43830
		[Token(Token = "0x400AB36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0400AB37 RID: 43831
		[Token(Token = "0x400AB37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnClearClicked;

		// Token: 0x0400AB38 RID: 43832
		[Token(Token = "0x400AB38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0400AB39 RID: 43833
		[Token(Token = "0x400AB39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryUpdateFilterPanelShow;

		// Token: 0x0400AB3A RID: 43834
		[Token(Token = "0x400AB3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnsureSortPanelSwitchAnim;

		// Token: 0x0400AB3B RID: 43835
		[Token(Token = "0x400AB3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSortPanelSwitch;

		// Token: 0x0400AB3C RID: 43836
		[Token(Token = "0x400AB3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__BindSortFilter;

		// Token: 0x0400AB3D RID: 43837
		[Token(Token = "0x400AB3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshPanelSwitch;

		// Token: 0x0400AB3E RID: 43838
		[Token(Token = "0x400AB3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DefaultEventOnConfirmClicked;

		// Token: 0x0400AB3F RID: 43839
		[Token(Token = "0x400AB3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckWillDormLockCharMove;

		// Token: 0x0400AB40 RID: 43840
		[Token(Token = "0x400AB40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnJumpToSelectConfirmState;

		// Token: 0x0400AB41 RID: 43841
		[Token(Token = "0x400AB41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromSelectConfirmState;

		// Token: 0x0400AB42 RID: 43842
		[Token(Token = "0x400AB42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCharClicked;

		// Token: 0x0400AB43 RID: 43843
		[Token(Token = "0x400AB43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GenSelectedCharForRequest;

		// Token: 0x0400AB44 RID: 43844
		[Token(Token = "0x400AB44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnSortItemClicked;

		// Token: 0x0400AB45 RID: 43845
		[Token(Token = "0x400AB45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnFilterShowHideClicked;

		// Token: 0x0400AB46 RID: 43846
		[Token(Token = "0x400AB46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnFilterItemClicked;

		// Token: 0x0400AB47 RID: 43847
		[Token(Token = "0x400AB47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0400AB48 RID: 43848
		[Token(Token = "0x400AB48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0400AB49 RID: 43849
		[Token(Token = "0x400AB49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0400AB4A RID: 43850
		[Token(Token = "0x400AB4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0400AB4B RID: 43851
		[Token(Token = "0x400AB4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TweenAnimation;

		// Token: 0x0400AB4C RID: 43852
		[Token(Token = "0x400AB4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetCharSelectMutuallyExclusiveInfo;

		// Token: 0x0400AB4D RID: 43853
		[Token(Token = "0x400AB4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix1_GetCharSelectMutuallyExclusiveInfo;

		// Token: 0x0400AB4E RID: 43854
		[Token(Token = "0x400AB4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0400AB4F RID: 43855
		[Token(Token = "0x400AB4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0400AB50 RID: 43856
		[Token(Token = "0x400AB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BAF RID: 7087
		[Token(Token = "0x2001BAF")]
		private enum SelectDormLockCharResult
		{
			// Token: 0x0400AB52 RID: 43858
			[Token(Token = "0x400AB52")]
			NoLock,
			// Token: 0x0400AB53 RID: 43859
			[Token(Token = "0x400AB53")]
			FromPreQueueToDormLock,
			// Token: 0x0400AB54 RID: 43860
			[Token(Token = "0x400AB54")]
			FromDormLockToStation
		}

		// Token: 0x02001BB0 RID: 7088
		[Token(Token = "0x2001BB0")]
		public interface IPlugin
		{
			// Token: 0x0600B0D4 RID: 45268
			[Token(Token = "0x600B0D4")]
			object GetContext();

			// Token: 0x0600B0D5 RID: 45269
			[Token(Token = "0x600B0D5")]
			StationSelectStateBean GetStateBean();

			// Token: 0x0600B0D6 RID: 45270
			[Token(Token = "0x600B0D6")]
			Dictionary<int, StationCharViewModel> LoadAllCharacters(RoomSlotModel targetRoom, [Optional] string currRoomTarget);

			// Token: 0x0600B0D7 RID: 45271
			[Token(Token = "0x600B0D7")]
			void OverrideSelectConfirmed(Action selfConfirm);

			// Token: 0x0600B0D8 RID: 45272
			[Token(Token = "0x600B0D8")]
			void OverrideSelectCanceled(Action selfCancel);

			// Token: 0x0600B0D9 RID: 45273
			[Token(Token = "0x600B0D9")]
			BuildingStationSelectState.SelectResultModel OverrideGenerateSelectedCharsForRequest(Func<BuildingStationSelectState.SelectResultModel> selfSelect);

			// Token: 0x170014F2 RID: 5362
			// (get) Token: 0x0600B0DA RID: 45274
			[Token(Token = "0x170014F2")]
			string overrideNoCharText { [Token(Token = "0x600B0DA")] get; }

			// Token: 0x170014F3 RID: 5363
			// (get) Token: 0x0600B0DB RID: 45275
			[Token(Token = "0x170014F3")]
			BuildingStationSelectMaskPlugin cardMaskPrefab { [Token(Token = "0x600B0DB")] get; }

			// Token: 0x0600B0DC RID: 45276
			[Token(Token = "0x600B0DC")]
			void OverrideCharSelect(StationCharViewModel selectChar, Action<StationCharViewModel> selfCharSelect);

			// Token: 0x0600B0DD RID: 45277
			[Token(Token = "0x600B0DD")]
			void OverrideDismiss(Action selfDismiss);

			// Token: 0x0600B0DE RID: 45278
			[Token(Token = "0x600B0DE")]
			void OnInit(StationSelectStateBean stateBean, object context);

			// Token: 0x0600B0DF RID: 45279
			[Token(Token = "0x600B0DF")]
			void OnExit();
		}

		// Token: 0x02001BB1 RID: 7089
		[Token(Token = "0x2001BB1")]
		public abstract class Plugin<Context> : BuildingStationSelectState.IPlugin
		{
			// Token: 0x0600B0E0 RID: 45280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0E0")]
			public virtual void OnInit(StationSelectStateBean stateBean, object context)
			{
			}

			// Token: 0x0600B0E1 RID: 45281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0E1")]
			public virtual void OnExit()
			{
			}

			// Token: 0x170014F4 RID: 5364
			// (get) Token: 0x0600B0E2 RID: 45282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014F4")]
			protected Context context
			{
				[Token(Token = "0x600B0E2")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B0E3 RID: 45283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B0E3")]
			public object GetContext()
			{
				return null;
			}

			// Token: 0x170014F5 RID: 5365
			// (get) Token: 0x0600B0E4 RID: 45284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014F5")]
			protected StationSelectStateBean stationSelectStateBean
			{
				[Token(Token = "0x600B0E4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B0E5 RID: 45285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B0E5")]
			public StationSelectStateBean GetStateBean()
			{
				return null;
			}

			// Token: 0x0600B0E6 RID: 45286
			[Token(Token = "0x600B0E6")]
			public abstract Dictionary<int, StationCharViewModel> LoadAllCharacters(RoomSlotModel targetRoom, [Optional] string currRoomTarget);

			// Token: 0x0600B0E7 RID: 45287
			[Token(Token = "0x600B0E7")]
			public abstract void OverrideCharSelect(StationCharViewModel selectChar, Action<StationCharViewModel> selfCharSelect);

			// Token: 0x0600B0E8 RID: 45288
			[Token(Token = "0x600B0E8")]
			public abstract void OverrideSelectConfirmed(Action selfConfirm);

			// Token: 0x0600B0E9 RID: 45289
			[Token(Token = "0x600B0E9")]
			public abstract void OverrideSelectCanceled(Action selfCancel);

			// Token: 0x0600B0EA RID: 45290
			[Token(Token = "0x600B0EA")]
			public abstract BuildingStationSelectState.SelectResultModel OverrideGenerateSelectedCharsForRequest(Func<BuildingStationSelectState.SelectResultModel> selfSelect);

			// Token: 0x170014F6 RID: 5366
			// (get) Token: 0x0600B0EB RID: 45291
			[Token(Token = "0x170014F6")]
			public abstract string overrideNoCharText { [Token(Token = "0x600B0EB")] get; }

			// Token: 0x170014F7 RID: 5367
			// (get) Token: 0x0600B0EC RID: 45292
			[Token(Token = "0x170014F7")]
			public abstract bool showCharInfoEntry { [Token(Token = "0x600B0EC")] get; }

			// Token: 0x170014F8 RID: 5368
			// (get) Token: 0x0600B0ED RID: 45293
			[Token(Token = "0x170014F8")]
			public abstract BuildingStationSelectMaskPlugin cardMaskPrefab { [Token(Token = "0x600B0ED")] get; }

			// Token: 0x0600B0EE RID: 45294
			[Token(Token = "0x600B0EE")]
			public abstract void OverrideDismiss(Action selfDismiss);

			// Token: 0x0600B0EF RID: 45295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0EF")]
			protected Plugin()
			{
			}

			// Token: 0x0400AB55 RID: 43861
			[Token(Token = "0x400AB55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Context m_context;

			// Token: 0x0400AB56 RID: 43862
			[Token(Token = "0x400AB56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private StationSelectStateBean m_stateBean;
		}

		// Token: 0x02001BB2 RID: 7090
		[Token(Token = "0x2001BB2")]
		public class StationSelectPlugin : BuildingStationSelectState.Plugin<BuildingStationSelectState>
		{
			// Token: 0x170014F9 RID: 5369
			// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014F9")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x600B0F0")]
				[Address(RVA = "0x32CF800", Offset = "0x32CE400", VA = "0x1832CF800", Slot = "23")]
				get
				{
					return null;
				}
			}

			// Token: 0x170014FA RID: 5370
			// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x00043848 File Offset: 0x00041A48
			[Token(Token = "0x170014FA")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x600B0F1")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170014FB RID: 5371
			// (get) Token: 0x0600B0F2 RID: 45298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014FB")]
			public override BuildingStationSelectMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x600B0F2")]
				[Address(RVA = "0x32CF7B0", Offset = "0x32CE3B0", VA = "0x1832CF7B0", Slot = "25")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B0F3 RID: 45299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B0F3")]
			[Address(RVA = "0x32CE240", Offset = "0x32CCE40", VA = "0x1832CE240", Slot = "18")]
			public override Dictionary<int, StationCharViewModel> LoadAllCharacters(RoomSlotModel targetRoom, [Optional] string currRoomTarget)
			{
				return null;
			}

			// Token: 0x0600B0F4 RID: 45300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0F4")]
			[Address(RVA = "0x32CEB90", Offset = "0x32CD790", VA = "0x1832CEB90", Slot = "19")]
			public override void OverrideCharSelect(StationCharViewModel selectChar, Action<StationCharViewModel> selfCharSelect)
			{
			}

			// Token: 0x0600B0F5 RID: 45301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0F5")]
			[Address(RVA = "0x32CDAF0", Offset = "0x32CC6F0", VA = "0x1832CDAF0", Slot = "26")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0600B0F6 RID: 45302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0F6")]
			[Address(RVA = "0x32CDAF0", Offset = "0x32CC6F0", VA = "0x1832CDAF0", Slot = "21")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x0600B0F7 RID: 45303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0F7")]
			[Address(RVA = "0x32CDAF0", Offset = "0x32CC6F0", VA = "0x1832CDAF0", Slot = "20")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0600B0F8 RID: 45304 RVA: 0x00043860 File Offset: 0x00041A60
			[Token(Token = "0x600B0F8")]
			[Address(RVA = "0x32CEDE0", Offset = "0x32CD9E0", VA = "0x1832CEDE0", Slot = "22")]
			public override BuildingStationSelectState.SelectResultModel OverrideGenerateSelectedCharsForRequest(Func<BuildingStationSelectState.SelectResultModel> selfSelect)
			{
				return default(BuildingStationSelectState.SelectResultModel);
			}

			// Token: 0x0600B0F9 RID: 45305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0F9")]
			[Address(RVA = "0x32CF010", Offset = "0x32CDC10", VA = "0x1832CF010")]
			private void _UpdateSelectedChars(List<BuildingCharModel> selectedChars)
			{
			}

			// Token: 0x0600B0FA RID: 45306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0FA")]
			[Address(RVA = "0x32CF690", Offset = "0x32CE290", VA = "0x1832CF690")]
			public StationSelectPlugin()
			{
			}

			// Token: 0x0400AB57 RID: 43863
			[Token(Token = "0x400AB57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<BuildingCharModel> m_cachedSelectedChars;

			// Token: 0x0400AB58 RID: 43864
			[Token(Token = "0x400AB58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HashSet<string> m_charAlreadySelectedMap;

			// Token: 0x0400AB59 RID: 43865
			[Token(Token = "0x400AB59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IntHashSet m_inPrequeChars;
		}

		// Token: 0x02001BB3 RID: 7091
		[Token(Token = "0x2001BB3")]
		public class PreQueueSelectPlugin : BuildingStationSelectState.Plugin<BuildingStationSelectState>
		{
			// Token: 0x170014FC RID: 5372
			// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014FC")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x600B0FB")]
				[Address(RVA = "0x32CE1A0", Offset = "0x32CCDA0", VA = "0x1832CE1A0", Slot = "23")]
				get
				{
					return null;
				}
			}

			// Token: 0x170014FD RID: 5373
			// (get) Token: 0x0600B0FC RID: 45308 RVA: 0x00043878 File Offset: 0x00041A78
			[Token(Token = "0x170014FD")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x600B0FC")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170014FE RID: 5374
			// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014FE")]
			public override BuildingStationSelectMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x600B0FD")]
				[Address(RVA = "0x32CE150", Offset = "0x32CCD50", VA = "0x1832CE150", Slot = "25")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B0FE RID: 45310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B0FE")]
			[Address(RVA = "0x32CD010", Offset = "0x32CBC10", VA = "0x1832CD010", Slot = "18")]
			public override Dictionary<int, StationCharViewModel> LoadAllCharacters(RoomSlotModel targetRoom, [Optional] string currRoomTarget)
			{
				return null;
			}

			// Token: 0x0600B0FF RID: 45311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B0FF")]
			[Address(RVA = "0x32CD8A0", Offset = "0x32CC4A0", VA = "0x1832CD8A0", Slot = "19")]
			public override void OverrideCharSelect(StationCharViewModel selectChar, Action<StationCharViewModel> selfCharSelect)
			{
			}

			// Token: 0x0600B100 RID: 45312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B100")]
			[Address(RVA = "0x32CDAF0", Offset = "0x32CC6F0", VA = "0x1832CDAF0", Slot = "26")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0600B101 RID: 45313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B101")]
			[Address(RVA = "0x32CDAF0", Offset = "0x32CC6F0", VA = "0x1832CDAF0", Slot = "21")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x0600B102 RID: 45314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B102")]
			[Address(RVA = "0x32CDBA0", Offset = "0x32CC7A0", VA = "0x1832CDBA0", Slot = "20")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0600B103 RID: 45315 RVA: 0x00043890 File Offset: 0x00041A90
			[Token(Token = "0x600B103")]
			[Address(RVA = "0x32CDE30", Offset = "0x32CCA30", VA = "0x1832CDE30")]
			private bool _CheckWillDormLockCharMove(List<BuildingCharModel> selectedChars)
			{
				return default(bool);
			}

			// Token: 0x0600B104 RID: 45316 RVA: 0x000438A8 File Offset: 0x00041AA8
			[Token(Token = "0x600B104")]
			[Address(RVA = "0x32CDB20", Offset = "0x32CC720", VA = "0x1832CDB20", Slot = "22")]
			public override BuildingStationSelectState.SelectResultModel OverrideGenerateSelectedCharsForRequest(Func<BuildingStationSelectState.SelectResultModel> selfSelect)
			{
				return default(BuildingStationSelectState.SelectResultModel);
			}

			// Token: 0x0600B105 RID: 45317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B105")]
			[Address(RVA = "0x32CE0C0", Offset = "0x32CCCC0", VA = "0x1832CE0C0")]
			public PreQueueSelectPlugin()
			{
			}

			// Token: 0x0400AB5A RID: 43866
			[Token(Token = "0x400AB5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IntHashSet m_inPrequeChars;
		}

		// Token: 0x02001BB5 RID: 7093
		[Token(Token = "0x2001BB5")]
		public struct SelectResultModel
		{
			// Token: 0x0400AB60 RID: 43872
			[Token(Token = "0x400AB60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<BuildingCharModel> selectedChars;

			// Token: 0x0400AB61 RID: 43873
			[Token(Token = "0x400AB61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BuildingCharModel singleModeSelectedChar;
		}
	}
}
