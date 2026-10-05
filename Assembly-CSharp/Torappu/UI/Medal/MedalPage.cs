using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200494F RID: 18767
	[Token(Token = "0x200494F")]
	public class MedalPage : StateEnginePage
	{
		// Token: 0x0601C47A RID: 115834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47A")]
		[Address(RVA = "0x15D5B40", Offset = "0x15D4740", VA = "0x1815D5B40", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601C47B RID: 115835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47B")]
		[Address(RVA = "0x15D5E50", Offset = "0x15D4A50", VA = "0x1815D5E50", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601C47C RID: 115836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47C")]
		[Address(RVA = "0x15D6F30", Offset = "0x15D5B30", VA = "0x1815D6F30")]
		private void _ReturnPage()
		{
		}

		// Token: 0x0601C47D RID: 115837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47D")]
		[Address(RVA = "0x15D6880", Offset = "0x15D5480", VA = "0x1815D6880")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0601C47E RID: 115838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47E")]
		[Address(RVA = "0x15D5840", Offset = "0x15D4440", VA = "0x1815D5840")]
		public static void OnAnimationStateSetStatic(State state, bool active, bool isList = false)
		{
		}

		// Token: 0x0601C47F RID: 115839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C47F")]
		[Address(RVA = "0x15D5EC0", Offset = "0x15D4AC0", VA = "0x1815D5EC0", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x0601C480 RID: 115840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C480")]
		[Address(RVA = "0x15D6A60", Offset = "0x15D5660", VA = "0x1815D6A60")]
		private void _OnRouteToState(Type stateType)
		{
		}

		// Token: 0x0601C481 RID: 115841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C481")]
		[Address(RVA = "0x15D73C0", Offset = "0x15D5FC0", VA = "0x1815D73C0")]
		private void _UpdateListTopBarStatus(bool enableTopBar, bool isBarList)
		{
		}

		// Token: 0x0601C482 RID: 115842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C482")]
		[Address(RVA = "0x15D5980", Offset = "0x15D4580", VA = "0x1815D5980")]
		public void OnChangeStateClick()
		{
		}

		// Token: 0x0601C483 RID: 115843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C483")]
		[Address(RVA = "0x15D6580", Offset = "0x15D5180", VA = "0x1815D6580")]
		private IEnumerator _JumpToMedalGroupPage()
		{
			return null;
		}

		// Token: 0x0601C484 RID: 115844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C484")]
		[Address(RVA = "0x15D64B0", Offset = "0x15D50B0", VA = "0x1815D64B0")]
		private IEnumerator _JumpToMedalBarListGroupPage(string groupId)
		{
			return null;
		}

		// Token: 0x0601C485 RID: 115845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C485")]
		[Address(RVA = "0x15D66E0", Offset = "0x15D52E0", VA = "0x1815D66E0")]
		private IEnumerator _JumpToMedalListItem(string medalId)
		{
			return null;
		}

		// Token: 0x0601C486 RID: 115846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C486")]
		[Address(RVA = "0x15D54D0", Offset = "0x15D40D0", VA = "0x1815D54D0")]
		public void JumpToMedalBarListGroup(string groupId)
		{
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C487")]
		[Address(RVA = "0x15D5720", Offset = "0x15D4320", VA = "0x1815D5720")]
		public void JumpToMedalListItem(string medalId)
		{
		}

		// Token: 0x0601C488 RID: 115848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C488")]
		[Address(RVA = "0x15D6CC0", Offset = "0x15D58C0", VA = "0x1815D6CC0")]
		private IEnumerator _ResetToBarList(string groupId)
		{
			return null;
		}

		// Token: 0x0601C489 RID: 115849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C489")]
		[Address(RVA = "0x15D6E60", Offset = "0x15D5A60", VA = "0x1815D6E60")]
		private IEnumerator _ResetToMedalList(string medalId)
		{
			return null;
		}

		// Token: 0x0601C48A RID: 115850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C48A")]
		[Address(RVA = "0x15D6610", Offset = "0x15D5210", VA = "0x1815D6610")]
		private IEnumerator _JumpToMedalGroupPage(string groupId)
		{
			return null;
		}

		// Token: 0x0601C48B RID: 115851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C48B")]
		[Address(RVA = "0x15D55F0", Offset = "0x15D41F0", VA = "0x1815D55F0")]
		public void JumpToMedalGroupList(string groupId)
		{
		}

		// Token: 0x0601C48C RID: 115852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C48C")]
		[Address(RVA = "0x15D6D90", Offset = "0x15D5990", VA = "0x1815D6D90")]
		private IEnumerator _ResetToGroupList(string groupId)
		{
			return null;
		}

		// Token: 0x0601C48D RID: 115853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C48D")]
		[Address(RVA = "0x15D6B90", Offset = "0x15D5790", VA = "0x1815D6B90")]
		private void _OnShowTypeFilterClicked(MedalBarListShowType showType)
		{
		}

		// Token: 0x0601C48E RID: 115854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C48E")]
		[Address(RVA = "0x15D67B0", Offset = "0x15D53B0", VA = "0x1815D67B0")]
		private void _OnHideExpiredToggleClicked()
		{
		}

		// Token: 0x0601C48F RID: 115855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C48F")]
		[Address(RVA = "0x15D53F0", Offset = "0x15D3FF0", VA = "0x1815D53F0")]
		public void ChangeMedalShowTypeAndRefreshViews(MedalBarListShowType showType, bool addFilterVersion = false)
		{
		}

		// Token: 0x0601C490 RID: 115856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C490")]
		[Address(RVA = "0x15D60B0", Offset = "0x15D4CB0", VA = "0x1815D60B0")]
		private void _ApplyMedalShowType(MedalListViewModel.ListFilter filter)
		{
		}

		// Token: 0x0601C491 RID: 115857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C491")]
		[Address(RVA = "0x15D63A0", Offset = "0x15D4FA0", VA = "0x1815D63A0")]
		private void _CloseDetailViewsIfNeeded()
		{
		}

		// Token: 0x0601C492 RID: 115858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C492")]
		[Address(RVA = "0x15D69B0", Offset = "0x15D55B0", VA = "0x1815D69B0")]
		private void _OnListFilterChanged()
		{
		}

		// Token: 0x0601C493 RID: 115859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C493")]
		[Address(RVA = "0x15D7310", Offset = "0x15D5F10", VA = "0x1815D7310")]
		private IEnumerator _ShowGlobalBlackLoading()
		{
			return null;
		}

		// Token: 0x0601C494 RID: 115860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C494")]
		[Address(RVA = "0x15D6C50", Offset = "0x15D5850", VA = "0x1815D6C50")]
		private void _ReleaseGlobalBlackLoading()
		{
		}

		// Token: 0x0601C495 RID: 115861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C495")]
		[Address(RVA = "0x15D75F0", Offset = "0x15D61F0", VA = "0x1815D75F0")]
		public MedalPage()
		{
		}

		// Token: 0x0601C498 RID: 115864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C498")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601C499 RID: 115865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C499")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601C49A RID: 115866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C49A")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x0402500B RID: 151563
		[Token(Token = "0x402500B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private MedalStateAnimationHolder _animationHolder;

		// Token: 0x0402500C RID: 151564
		[Token(Token = "0x402500C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0402500D RID: 151565
		[Token(Token = "0x402500D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private MedalListStateBean _listStateBean;

		// Token: 0x0402500E RID: 151566
		[Token(Token = "0x402500E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private MedalShowTypeFilterView _showTypeFilter;

		// Token: 0x0402500F RID: 151567
		[Token(Token = "0x402500F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("HideExpired")]
		private List<RectTransform> _hideExpireSwitchHolders;

		// Token: 0x04025010 RID: 151568
		[Token(Token = "0x4025010")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("HideExpired")]
		private MedalHideExpireSwitch _hideExpireSwitchPrefab;

		// Token: 0x04025011 RID: 151569
		[Token(Token = "0x4025011")]
		[FieldOffset(Offset = "0x120")]
		private List<MedalHideExpireSwitch> m_hideExpireSwitches;

		// Token: 0x04025012 RID: 151570
		[Token(Token = "0x4025012")]
		[FieldOffset(Offset = "0x128")]
		private UIPopupWindow.ReentrantFloatRef m_globalBlackMask;

		// Token: 0x04025013 RID: 151571
		[Token(Token = "0x4025013")]
		[FieldOffset(Offset = "0x130")]
		private StateEngine.OnStateChangeListener m_stateChangeListener;

		// Token: 0x04025014 RID: 151572
		[Token(Token = "0x4025014")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04025015 RID: 151573
		[Token(Token = "0x4025015")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025016 RID: 151574
		[Token(Token = "0x4025016")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x04025017 RID: 151575
		[Token(Token = "0x4025017")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04025018 RID: 151576
		[Token(Token = "0x4025018")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAnimationStateSetStatic;

		// Token: 0x04025019 RID: 151577
		[Token(Token = "0x4025019")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0402501A RID: 151578
		[Token(Token = "0x402501A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRouteToState;

		// Token: 0x0402501B RID: 151579
		[Token(Token = "0x402501B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateListTopBarStatus;

		// Token: 0x0402501C RID: 151580
		[Token(Token = "0x402501C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnChangeStateClick;

		// Token: 0x0402501D RID: 151581
		[Token(Token = "0x402501D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__JumpToMedalGroupPage;

		// Token: 0x0402501E RID: 151582
		[Token(Token = "0x402501E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JumpToMedalBarListGroupPage;

		// Token: 0x0402501F RID: 151583
		[Token(Token = "0x402501F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__JumpToMedalListItem;

		// Token: 0x04025020 RID: 151584
		[Token(Token = "0x4025020")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_JumpToMedalBarListGroup;

		// Token: 0x04025021 RID: 151585
		[Token(Token = "0x4025021")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_JumpToMedalListItem;

		// Token: 0x04025022 RID: 151586
		[Token(Token = "0x4025022")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetToBarList;

		// Token: 0x04025023 RID: 151587
		[Token(Token = "0x4025023")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetToMedalList;

		// Token: 0x04025024 RID: 151588
		[Token(Token = "0x4025024")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1__JumpToMedalGroupPage;

		// Token: 0x04025025 RID: 151589
		[Token(Token = "0x4025025")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_JumpToMedalGroupList;

		// Token: 0x04025026 RID: 151590
		[Token(Token = "0x4025026")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ResetToGroupList;

		// Token: 0x04025027 RID: 151591
		[Token(Token = "0x4025027")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnShowTypeFilterClicked;

		// Token: 0x04025028 RID: 151592
		[Token(Token = "0x4025028")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnHideExpiredToggleClicked;

		// Token: 0x04025029 RID: 151593
		[Token(Token = "0x4025029")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ChangeMedalShowTypeAndRefreshViews;

		// Token: 0x0402502A RID: 151594
		[Token(Token = "0x402502A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ApplyMedalShowType;

		// Token: 0x0402502B RID: 151595
		[Token(Token = "0x402502B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CloseDetailViewsIfNeeded;

		// Token: 0x0402502C RID: 151596
		[Token(Token = "0x402502C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnListFilterChanged;

		// Token: 0x0402502D RID: 151597
		[Token(Token = "0x402502D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ShowGlobalBlackLoading;

		// Token: 0x0402502E RID: 151598
		[Token(Token = "0x402502E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ReleaseGlobalBlackLoading;

		// Token: 0x0402502F RID: 151599
		[Token(Token = "0x402502F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004950 RID: 18768
		[Token(Token = "0x2004950")]
		public class Param
		{
			// Token: 0x0601C49B RID: 115867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C49B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04025030 RID: 151600
			[Token(Token = "0x4025030")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04025031 RID: 151601
			[Token(Token = "0x4025031")]
			[FieldOffset(Offset = "0x18")]
			public string medalId;
		}
	}
}
