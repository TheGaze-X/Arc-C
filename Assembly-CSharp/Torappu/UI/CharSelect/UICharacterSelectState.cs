using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005DF8 RID: 24056
	[Token(Token = "0x2005DF8")]
	public class UICharacterSelectState : UIPopupState
	{
		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x06022DB2 RID: 142770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005290")]
		protected UICharacterSelectState.IPlugin plugin
		{
			[Token(Token = "0x6022DB2")]
			[Address(RVA = "0x1D767F0", Offset = "0x1D753F0", VA = "0x181D767F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022DB3 RID: 142771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB3")]
		[Address(RVA = "0x1D73880", Offset = "0x1D72480", VA = "0x181D73880")]
		private void Awake()
		{
		}

		// Token: 0x06022DB4 RID: 142772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DB4")]
		[Address(RVA = "0x1D74890", Offset = "0x1D73490", VA = "0x181D74890", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022DB5 RID: 142773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB5")]
		[Address(RVA = "0x1D74B50", Offset = "0x1D73750", VA = "0x181D74B50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022DB6 RID: 142774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB6")]
		[Address(RVA = "0x1D74EE0", Offset = "0x1D73AE0", VA = "0x181D74EE0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06022DB7 RID: 142775 RVA: 0x000BF478 File Offset: 0x000BD678
		[Token(Token = "0x6022DB7")]
		[Address(RVA = "0x1D757F0", Offset = "0x1D743F0", VA = "0x181D757F0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06022DB8 RID: 142776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB8")]
		[Address(RVA = "0x1D75160", Offset = "0x1D73D60", VA = "0x181D75160", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022DB9 RID: 142777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB9")]
		[Address(RVA = "0x1D73950", Offset = "0x1D72550", VA = "0x181D73950", Slot = "22")]
		public override void DismissSelf()
		{
		}

		// Token: 0x06022DBA RID: 142778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBA")]
		[Address(RVA = "0x1D73DE0", Offset = "0x1D729E0", VA = "0x181D73DE0")]
		public void EventOnCardSelect(int chrInstId)
		{
		}

		// Token: 0x06022DBB RID: 142779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBB")]
		[Address(RVA = "0x1D74510", Offset = "0x1D73110", VA = "0x181D74510")]
		public void EventOnSkillSelect(string skillId)
		{
		}

		// Token: 0x06022DBC RID: 142780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBC")]
		[Address(RVA = "0x1D73B30", Offset = "0x1D72730", VA = "0x181D73B30")]
		public void EventOnBranchSelect(string equipId)
		{
		}

		// Token: 0x06022DBD RID: 142781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBD")]
		[Address(RVA = "0x1D75310", Offset = "0x1D73F10", VA = "0x181D75310")]
		public void ShowCharacterInfo()
		{
		}

		// Token: 0x06022DBE RID: 142782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBE")]
		[Address(RVA = "0x1D74650", Offset = "0x1D73250", VA = "0x181D74650")]
		public void EventOnSortTypeGroupClick(CharacterSortType sortType)
		{
		}

		// Token: 0x06022DBF RID: 142783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DBF")]
		[Address(RVA = "0x1D74770", Offset = "0x1D73370", VA = "0x181D74770")]
		public void EventOnStarMarkTopToggle()
		{
		}

		// Token: 0x06022DC0 RID: 142784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC0")]
		[Address(RVA = "0x1D740D0", Offset = "0x1D72CD0", VA = "0x181D740D0")]
		public void EventOnClearSquadBtnClick()
		{
		}

		// Token: 0x06022DC1 RID: 142785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC1")]
		[Address(RVA = "0x1D73C70", Offset = "0x1D72870", VA = "0x181D73C70")]
		public void EventOnCancelBtnClick()
		{
		}

		// Token: 0x06022DC2 RID: 142786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC2")]
		[Address(RVA = "0x1D73A50", Offset = "0x1D72650", VA = "0x181D73A50")]
		public void EventOnAttrTabClick(CharAttrTabType tabType)
		{
		}

		// Token: 0x06022DC3 RID: 142787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC3")]
		[Address(RVA = "0x1D74440", Offset = "0x1D73040", VA = "0x181D74440")]
		public void EventOnFilter(UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x06022DC4 RID: 142788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC4")]
		[Address(RVA = "0x1D74340", Offset = "0x1D72F40", VA = "0x181D74340")]
		public void EventOnFilterShow(bool isShow)
		{
		}

		// Token: 0x06022DC5 RID: 142789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC5")]
		[Address(RVA = "0x1D746E0", Offset = "0x1D732E0", VA = "0x181D746E0")]
		public void EventOnSort(CharacterSortType sortType)
		{
		}

		// Token: 0x06022DC6 RID: 142790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC6")]
		[Address(RVA = "0x1D764D0", Offset = "0x1D750D0", VA = "0x181D764D0")]
		private void _RefreshPanelSwitch()
		{
		}

		// Token: 0x06022DC7 RID: 142791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DC7")]
		[Address(RVA = "0x1D75F20", Offset = "0x1D74B20", VA = "0x181D75F20")]
		private AnimationSwitchTween _EnsureSortPanelSwithAnim()
		{
			return null;
		}

		// Token: 0x06022DC8 RID: 142792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC8")]
		[Address(RVA = "0x1D765F0", Offset = "0x1D751F0", VA = "0x181D765F0")]
		private void _TryUpdateFilterPanelShow(bool isFilterPanelShow)
		{
		}

		// Token: 0x06022DC9 RID: 142793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DC9")]
		[Address(RVA = "0x1D74230", Offset = "0x1D72E30", VA = "0x181D74230")]
		public void EventOnConfirmBtnClick()
		{
		}

		// Token: 0x06022DCA RID: 142794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DCA")]
		[Address(RVA = "0x1D754E0", Offset = "0x1D740E0", VA = "0x181D754E0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022DCB RID: 142795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DCB")]
		[Address(RVA = "0x1D75620", Offset = "0x1D74220", VA = "0x181D75620", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06022DCC RID: 142796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DCC")]
		[Address(RVA = "0x1D748F0", Offset = "0x1D734F0", VA = "0x181D748F0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022DCD RID: 142797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DCD")]
		[Address(RVA = "0x1D74A30", Offset = "0x1D73630", VA = "0x181D74A30", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06022DCE RID: 142798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DCE")]
		[Address(RVA = "0x1D76690", Offset = "0x1D75290", VA = "0x181D76690")]
		private IEnumerator _TweenAnimation(UIAnimationLocation anim, bool isInverse = false)
		{
			return null;
		}

		// Token: 0x06022DCF RID: 142799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DCF")]
		[Address(RVA = "0x1D75C90", Offset = "0x1D74890", VA = "0x181D75C90")]
		private void _ConfirmOutput()
		{
		}

		// Token: 0x06022DD0 RID: 142800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD0")]
		[Address(RVA = "0x1D75C10", Offset = "0x1D74810", VA = "0x181D75C10")]
		private void _Cancel()
		{
		}

		// Token: 0x06022DD1 RID: 142801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD1")]
		[Address(RVA = "0x1D76010", Offset = "0x1D74C10", VA = "0x181D76010")]
		private void _InitViews()
		{
		}

		// Token: 0x06022DD2 RID: 142802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD2")]
		[Address(RVA = "0x1D75860", Offset = "0x1D74460", VA = "0x181D75860")]
		private void _BindCardGroup()
		{
		}

		// Token: 0x06022DD3 RID: 142803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD3")]
		[Address(RVA = "0x1D75AA0", Offset = "0x1D746A0", VA = "0x181D75AA0")]
		private void _BindSortPanel()
		{
		}

		// Token: 0x06022DD4 RID: 142804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD4")]
		[Address(RVA = "0x1D76790", Offset = "0x1D75390", VA = "0x181D76790")]
		public UICharacterSelectState()
		{
		}

		// Token: 0x06022DD7 RID: 142807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022DD8 RID: 142808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DD8")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06022DD9 RID: 142809 RVA: 0x000BF490 File Offset: 0x000BD690
		[Token(Token = "0x6022DD9")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06022DDA RID: 142810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DDA")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06022DDB RID: 142811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DDB")]
		[Address(RVA = "0x1637780", Offset = "0x1636380", VA = "0x181637780")]
		private void <>xLuaBaseProxy_DismissSelf()
		{
		}

		// Token: 0x0403001A RID: 196634
		[Token(Token = "0x403001A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharSelectStateBean _stateBean;

		// Token: 0x0403001B RID: 196635
		[Token(Token = "0x403001B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403001C RID: 196636
		[Token(Token = "0x403001C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnClear;

		// Token: 0x0403001D RID: 196637
		[Token(Token = "0x403001D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _fadeInAnim;

		// Token: 0x0403001E RID: 196638
		[Token(Token = "0x403001E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CharSelectCardChangeListener _cardChangeListener;

		// Token: 0x0403001F RID: 196639
		[Token(Token = "0x403001F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CharSelectAttrController _attrController;

		// Token: 0x04030020 RID: 196640
		[Token(Token = "0x4030020")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CharSelectCardGroup _cardGroup;

		// Token: 0x04030021 RID: 196641
		[Token(Token = "0x4030021")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CharSelectCardListAdapter _cardListAdapter;

		// Token: 0x04030022 RID: 196642
		[Token(Token = "0x4030022")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICharacterSortFilterPanelBinder _sortFilterPanelBinder;

		// Token: 0x04030023 RID: 196643
		[Token(Token = "0x4030023")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UICharacterSortTypeGroupBinder _sortGroupBinder;

		// Token: 0x04030024 RID: 196644
		[Token(Token = "0x4030024")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharSelectAttrTabItem[] _tabItems;

		// Token: 0x04030025 RID: 196645
		[Token(Token = "0x4030025")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Nullable")]
		private UICharacterStarMarkTopItemBinder _starMarkTopSortBinder;

		// Token: 0x04030026 RID: 196646
		[Token(Token = "0x4030026")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _predefineCharTipsPanel;

		// Token: 0x04030027 RID: 196647
		[Token(Token = "0x4030027")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _fliterAnimLoc;

		// Token: 0x04030028 RID: 196648
		[Token(Token = "0x4030028")]
		[FieldOffset(Offset = "0xE0")]
		private UICharacterSelectState.ViewBusiness m_viewBusiness;

		// Token: 0x04030029 RID: 196649
		[Token(Token = "0x4030029")]
		[FieldOffset(Offset = "0xE8")]
		private UICharacterSelectState.AVGApplySortFilterCommandExecutor m_applySortFilterCmdExecutor;

		// Token: 0x0403002A RID: 196650
		[Token(Token = "0x403002A")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_filterSwitchAnim;

		// Token: 0x0403002B RID: 196651
		[Token(Token = "0x403002B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0403002C RID: 196652
		[Token(Token = "0x403002C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0403002D RID: 196653
		[Token(Token = "0x403002D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403002E RID: 196654
		[Token(Token = "0x403002E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403002F RID: 196655
		[Token(Token = "0x403002F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04030030 RID: 196656
		[Token(Token = "0x4030030")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04030031 RID: 196657
		[Token(Token = "0x4030031")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030032 RID: 196658
		[Token(Token = "0x4030032")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x04030033 RID: 196659
		[Token(Token = "0x4030033")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCardSelect;

		// Token: 0x04030034 RID: 196660
		[Token(Token = "0x4030034")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnSkillSelect;

		// Token: 0x04030035 RID: 196661
		[Token(Token = "0x4030035")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBranchSelect;

		// Token: 0x04030036 RID: 196662
		[Token(Token = "0x4030036")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCharacterInfo;

		// Token: 0x04030037 RID: 196663
		[Token(Token = "0x4030037")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnSortTypeGroupClick;

		// Token: 0x04030038 RID: 196664
		[Token(Token = "0x4030038")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnStarMarkTopToggle;

		// Token: 0x04030039 RID: 196665
		[Token(Token = "0x4030039")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnClearSquadBtnClick;

		// Token: 0x0403003A RID: 196666
		[Token(Token = "0x403003A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnCancelBtnClick;

		// Token: 0x0403003B RID: 196667
		[Token(Token = "0x403003B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnAttrTabClick;

		// Token: 0x0403003C RID: 196668
		[Token(Token = "0x403003C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnFilter;

		// Token: 0x0403003D RID: 196669
		[Token(Token = "0x403003D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnFilterShow;

		// Token: 0x0403003E RID: 196670
		[Token(Token = "0x403003E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnSort;

		// Token: 0x0403003F RID: 196671
		[Token(Token = "0x403003F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RefreshPanelSwitch;

		// Token: 0x04030040 RID: 196672
		[Token(Token = "0x4030040")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EnsureSortPanelSwithAnim;

		// Token: 0x04030041 RID: 196673
		[Token(Token = "0x4030041")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryUpdateFilterPanelShow;

		// Token: 0x04030042 RID: 196674
		[Token(Token = "0x4030042")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClick;

		// Token: 0x04030043 RID: 196675
		[Token(Token = "0x4030043")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04030044 RID: 196676
		[Token(Token = "0x4030044")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04030045 RID: 196677
		[Token(Token = "0x4030045")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04030046 RID: 196678
		[Token(Token = "0x4030046")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04030047 RID: 196679
		[Token(Token = "0x4030047")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TweenAnimation;

		// Token: 0x04030048 RID: 196680
		[Token(Token = "0x4030048")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ConfirmOutput;

		// Token: 0x04030049 RID: 196681
		[Token(Token = "0x4030049")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__Cancel;

		// Token: 0x0403004A RID: 196682
		[Token(Token = "0x403004A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__InitViews;

		// Token: 0x0403004B RID: 196683
		[Token(Token = "0x403004B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__BindCardGroup;

		// Token: 0x0403004C RID: 196684
		[Token(Token = "0x403004C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__BindSortPanel;

		// Token: 0x0403004D RID: 196685
		[Token(Token = "0x403004D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DF9 RID: 24057
		[Token(Token = "0x2005DF9")]
		public interface IPlugin : IHotfixable
		{
			// Token: 0x06022DDC RID: 142812
			[Token(Token = "0x6022DDC")]
			object GetContext();

			// Token: 0x06022DDD RID: 142813
			[Token(Token = "0x6022DDD")]
			CharSelectStateBean GetStateBean();

			// Token: 0x06022DDE RID: 142814
			[Token(Token = "0x6022DDE")]
			void OverrideSelectConfirmed(Action selfConfirm);

			// Token: 0x06022DDF RID: 142815
			[Token(Token = "0x6022DDF")]
			void OverrideSelectCanceled(Action selfCancel);

			// Token: 0x06022DE0 RID: 142816
			[Token(Token = "0x6022DE0")]
			void PostUpdateAttribute(CharAttrViewModel attrModel);

			// Token: 0x17005291 RID: 21137
			// (get) Token: 0x06022DE1 RID: 142817
			[Token(Token = "0x17005291")]
			string overrideNoCharText { [Token(Token = "0x6022DE1")] get; }

			// Token: 0x17005292 RID: 21138
			// (get) Token: 0x06022DE2 RID: 142818
			[Token(Token = "0x17005292")]
			CharSelectCardMaskPlugin cardMaskPrefab { [Token(Token = "0x6022DE2")] get; }

			// Token: 0x06022DE3 RID: 142819
			[Token(Token = "0x6022DE3")]
			void OverrideCharSelect(int instId, Action<int> selfCharSelect);

			// Token: 0x06022DE4 RID: 142820
			[Token(Token = "0x6022DE4")]
			void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect);

			// Token: 0x06022DE5 RID: 142821
			[Token(Token = "0x6022DE5")]
			void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect);

			// Token: 0x06022DE6 RID: 142822
			[Token(Token = "0x6022DE6")]
			void OverrideDismiss(Action selfDismiss);

			// Token: 0x17005293 RID: 21139
			// (get) Token: 0x06022DE7 RID: 142823
			[Token(Token = "0x17005293")]
			bool showCharInfoEntry { [Token(Token = "0x6022DE7")] get; }

			// Token: 0x06022DE8 RID: 142824
			[Token(Token = "0x6022DE8")]
			void OverrideCharListSort(List<CharacterCardViewModel> charList, CharacterSortType sortType, Action<List<CharacterCardViewModel>, CharacterSortType> selfCharListSort);

			// Token: 0x06022DE9 RID: 142825
			[Token(Token = "0x6022DE9")]
			string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill);

			// Token: 0x06022DEA RID: 142826
			[Token(Token = "0x6022DEA")]
			string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch);

			// Token: 0x06022DEB RID: 142827
			[Token(Token = "0x6022DEB")]
			void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds);

			// Token: 0x06022DEC RID: 142828
			[Token(Token = "0x6022DEC")]
			void OnInit(CharSelectStateBean stateBean, object context);

			// Token: 0x06022DED RID: 142829
			[Token(Token = "0x6022DED")]
			void OnExit();
		}

		// Token: 0x02005DFA RID: 24058
		[Token(Token = "0x2005DFA")]
		public abstract class Plugin<Context> : UICharacterSelectState.IPlugin, IHotfixable
		{
			// Token: 0x06022DEE RID: 142830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022DEE")]
			public virtual void OnInit(CharSelectStateBean stateBean, object context)
			{
			}

			// Token: 0x06022DEF RID: 142831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022DEF")]
			public virtual void OnExit()
			{
			}

			// Token: 0x17005294 RID: 21140
			// (get) Token: 0x06022DF0 RID: 142832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005294")]
			protected Context context
			{
				[Token(Token = "0x6022DF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022DF1 RID: 142833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022DF1")]
			public object GetContext()
			{
				return null;
			}

			// Token: 0x17005295 RID: 21141
			// (get) Token: 0x06022DF2 RID: 142834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005295")]
			protected CharSelectStateBean charSelectStateBean
			{
				[Token(Token = "0x6022DF2")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022DF3 RID: 142835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022DF3")]
			public CharSelectStateBean GetStateBean()
			{
				return null;
			}

			// Token: 0x06022DF4 RID: 142836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022DF4")]
			public virtual void PostUpdateAttribute(CharAttrViewModel attrModel)
			{
			}

			// Token: 0x06022DF5 RID: 142837
			[Token(Token = "0x6022DF5")]
			public abstract void OverrideCharSelect(int instId, Action<int> selfCharSelect);

			// Token: 0x06022DF6 RID: 142838
			[Token(Token = "0x6022DF6")]
			public abstract void OverrideSelectConfirmed(Action selfConfirm);

			// Token: 0x06022DF7 RID: 142839
			[Token(Token = "0x6022DF7")]
			public abstract void OverrideSelectCanceled(Action selfCancel);

			// Token: 0x17005296 RID: 21142
			// (get) Token: 0x06022DF8 RID: 142840
			[Token(Token = "0x17005296")]
			public abstract string overrideNoCharText { [Token(Token = "0x6022DF8")] get; }

			// Token: 0x17005297 RID: 21143
			// (get) Token: 0x06022DF9 RID: 142841
			[Token(Token = "0x17005297")]
			public abstract bool showCharInfoEntry { [Token(Token = "0x6022DF9")] get; }

			// Token: 0x06022DFA RID: 142842
			[Token(Token = "0x6022DFA")]
			public abstract void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect);

			// Token: 0x06022DFB RID: 142843
			[Token(Token = "0x6022DFB")]
			public abstract void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect);

			// Token: 0x17005298 RID: 21144
			// (get) Token: 0x06022DFC RID: 142844
			[Token(Token = "0x17005298")]
			public abstract CharSelectCardMaskPlugin cardMaskPrefab { [Token(Token = "0x6022DFC")] get; }

			// Token: 0x06022DFD RID: 142845
			[Token(Token = "0x6022DFD")]
			public abstract void OverrideDismiss(Action selfDismiss);

			// Token: 0x06022DFE RID: 142846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022DFE")]
			public virtual string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x06022DFF RID: 142847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022DFF")]
			public virtual string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x06022E00 RID: 142848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E00")]
			public virtual void OverrideCharListSort(List<CharacterCardViewModel> charList, CharacterSortType sortType, Action<List<CharacterCardViewModel>, CharacterSortType> selfCharListSort)
			{
			}

			// Token: 0x06022E01 RID: 142849
			[Token(Token = "0x6022E01")]
			public abstract void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds);

			// Token: 0x06022E02 RID: 142850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E02")]
			protected Plugin()
			{
			}

			// Token: 0x0403004E RID: 196686
			[Token(Token = "0x403004E")]
			[FieldOffset(Offset = "0x0")]
			private Context m_context;

			// Token: 0x0403004F RID: 196687
			[Token(Token = "0x403004F")]
			[FieldOffset(Offset = "0x0")]
			private CharSelectStateBean m_stateBean;

			// Token: 0x04030050 RID: 196688
			[Token(Token = "0x4030050")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04030051 RID: 196689
			[Token(Token = "0x4030051")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnExit;

			// Token: 0x04030052 RID: 196690
			[Token(Token = "0x4030052")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_context;

			// Token: 0x04030053 RID: 196691
			[Token(Token = "0x4030053")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetContext;

			// Token: 0x04030054 RID: 196692
			[Token(Token = "0x4030054")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_charSelectStateBean;

			// Token: 0x04030055 RID: 196693
			[Token(Token = "0x4030055")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetStateBean;

			// Token: 0x04030056 RID: 196694
			[Token(Token = "0x4030056")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_PostUpdateAttribute;

			// Token: 0x04030057 RID: 196695
			[Token(Token = "0x4030057")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x04030058 RID: 196696
			[Token(Token = "0x4030058")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x04030059 RID: 196697
			[Token(Token = "0x4030059")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideCharListSort;

			// Token: 0x0403005A RID: 196698
			[Token(Token = "0x403005A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005DFB RID: 24059
		[Token(Token = "0x2005DFB")]
		private abstract class ViewBusiness
		{
			// Token: 0x17005299 RID: 21145
			// (set) Token: 0x06022E03 RID: 142851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005299")]
			public UICharacterSelectState closure
			{
				[Token(Token = "0x6022E03")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x06022E04 RID: 142852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E04")]
			[Address(RVA = "0x1D76890", Offset = "0x1D75490", VA = "0x181D76890")]
			public void OnCardSelect(int chrInstId)
			{
			}

			// Token: 0x06022E05 RID: 142853
			[Token(Token = "0x6022E05")]
			protected abstract void OnCardSelected(int chrInstId, CharAttrViewModel attrModel, CardGroupViewModel cardGroupModel);

			// Token: 0x06022E06 RID: 142854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E06")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected ViewBusiness()
			{
			}

			// Token: 0x0403005B RID: 196699
			[Token(Token = "0x403005B")]
			[FieldOffset(Offset = "0x10")]
			protected UICharacterSelectState m_closure;
		}

		// Token: 0x02005DFC RID: 24060
		[Token(Token = "0x2005DFC")]
		private class SingleSelectBusiness : UICharacterSelectState.ViewBusiness
		{
			// Token: 0x06022E07 RID: 142855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E07")]
			[Address(RVA = "0x1D72640", Offset = "0x1D71240", VA = "0x181D72640", Slot = "4")]
			protected override void OnCardSelected(int chrInstId, CharAttrViewModel attrModel, CardGroupViewModel cardGroupModel)
			{
			}

			// Token: 0x06022E08 RID: 142856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E08")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SingleSelectBusiness()
			{
			}
		}

		// Token: 0x02005DFD RID: 24061
		[Token(Token = "0x2005DFD")]
		private class MultiSelectBusiness : UICharacterSelectState.ViewBusiness
		{
			// Token: 0x06022E09 RID: 142857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E09")]
			[Address(RVA = "0x1D71FF0", Offset = "0x1D70BF0", VA = "0x181D71FF0", Slot = "4")]
			protected override void OnCardSelected(int chrInstId, CharAttrViewModel attrModel, CardGroupViewModel cardGroupModel)
			{
			}

			// Token: 0x06022E0A RID: 142858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E0A")]
			[Address(RVA = "0x1D72370", Offset = "0x1D70F70", VA = "0x181D72370")]
			public MultiSelectBusiness()
			{
			}

			// Token: 0x0403005C RID: 196700
			[Token(Token = "0x403005C")]
			[FieldOffset(Offset = "0x18")]
			private List<int> m_excludeInstIds;
		}

		// Token: 0x02005DFE RID: 24062
		[Token(Token = "0x2005DFE")]
		private class OnlySkillSelectBusiness : UICharacterSelectState.ViewBusiness
		{
			// Token: 0x06022E0B RID: 142859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E0B")]
			[Address(RVA = "0x1D72400", Offset = "0x1D71000", VA = "0x181D72400", Slot = "4")]
			protected override void OnCardSelected(int chrInstId, CharAttrViewModel attrModel, CardGroupViewModel cardGroupModel)
			{
			}

			// Token: 0x06022E0C RID: 142860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E0C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OnlySkillSelectBusiness()
			{
			}
		}

		// Token: 0x02005DFF RID: 24063
		[Token(Token = "0x2005DFF")]
		private class AVGApplySortFilterCommandExecutor : ICommandExecutor, IHotfixable
		{
			// Token: 0x1700529A RID: 21146
			// (get) Token: 0x06022E0D RID: 142861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700529A")]
			public string command
			{
				[Token(Token = "0x6022E0D")]
				[Address(RVA = "0x1D5FCC0", Offset = "0x1D5E8C0", VA = "0x181D5FCC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022E0E RID: 142862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E0E")]
			[Address(RVA = "0x1D5FC40", Offset = "0x1D5E840", VA = "0x181D5FC40")]
			public AVGApplySortFilterCommandExecutor(CharSelectStateBean stateBean)
			{
			}

			// Token: 0x06022E0F RID: 142863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E0F")]
			[Address(RVA = "0x1D5F9F0", Offset = "0x1D5E5F0", VA = "0x181D5F9F0", Slot = "5")]
			public void Execute(Command command, Action<ICommandExecutor> finishCb)
			{
			}

			// Token: 0x06022E10 RID: 142864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E10")]
			[Address(RVA = "0x1D5FBE0", Offset = "0x1D5E7E0", VA = "0x181D5FBE0", Slot = "6")]
			public void RaiseSignal(Command command)
			{
			}

			// Token: 0x06022E11 RID: 142865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E11")]
			[Address(RVA = "0x1D5FB80", Offset = "0x1D5E780", VA = "0x181D5FB80", Slot = "7")]
			public void ForceEnd()
			{
			}

			// Token: 0x0403005D RID: 196701
			[Token(Token = "0x403005D")]
			[FieldOffset(Offset = "0x10")]
			private CharSelectStateBean m_stateBean;

			// Token: 0x0403005E RID: 196702
			[Token(Token = "0x403005E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_command;

			// Token: 0x0403005F RID: 196703
			[Token(Token = "0x403005F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030060 RID: 196704
			[Token(Token = "0x4030060")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04030061 RID: 196705
			[Token(Token = "0x4030061")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RaiseSignal;

			// Token: 0x04030062 RID: 196706
			[Token(Token = "0x4030062")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ForceEnd;
		}
	}
}
