using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CF1 RID: 7409
	[Token(Token = "0x2001CF1")]
	public class BuildingShopFormulaState : PopupFloatState
	{
		// Token: 0x0600B703 RID: 46851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B703")]
		[Address(RVA = "0x3340CD0", Offset = "0x333F8D0", VA = "0x183340CD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B704")]
		[Address(RVA = "0x33412C0", Offset = "0x333FEC0", VA = "0x1833412C0")]
		private void Start()
		{
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x00045168 File Offset: 0x00043368
		[Token(Token = "0x600B705")]
		[Address(RVA = "0x3341700", Offset = "0x3340300", VA = "0x183341700", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B706")]
		[Address(RVA = "0x3341000", Offset = "0x333FC00", VA = "0x183341000", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B707")]
		[Address(RVA = "0x3341160", Offset = "0x333FD60", VA = "0x183341160", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B708")]
		[Address(RVA = "0x3340D30", Offset = "0x333F930", VA = "0x183340D30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B709")]
		[Address(RVA = "0x3340C30", Offset = "0x333F830", VA = "0x183340C30")]
		public void EventOnFilterBtnClicked()
		{
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70A")]
		[Address(RVA = "0x3341AC0", Offset = "0x33406C0", VA = "0x183341AC0")]
		private void _OnJumpToSortFilterState(SFormulaSortFilterStateBean filterBean)
		{
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70B")]
		[Address(RVA = "0x33419C0", Offset = "0x33405C0", VA = "0x1833419C0")]
		private void _OnJumpBackFromSortFilterState(SFormulaSortFilterStateBean filterBean)
		{
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70C")]
		[Address(RVA = "0x3341890", Offset = "0x3340490", VA = "0x183341890")]
		private void _OnItemTypeClicked(BuildingData.FormulaItemType formulaType)
		{
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70D")]
		[Address(RVA = "0x3341B70", Offset = "0x3340770", VA = "0x183341B70")]
		private void _OnSortItemClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70E")]
		[Address(RVA = "0x3341770", Offset = "0x3340370", VA = "0x183341770")]
		private void _OnFormulaClicked(SFormulaViewModel selectedFormula)
		{
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70F")]
		[Address(RVA = "0x3341D60", Offset = "0x3340960", VA = "0x183341D60")]
		public BuildingShopFormulaState()
		{
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x00045180 File Offset: 0x00043380
		[Token(Token = "0x600B713")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B714")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B715")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B716")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400B4D6 RID: 46294
		[Token(Token = "0x400B4D6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400B4D7 RID: 46295
		[Token(Token = "0x400B4D7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingShopFormulaSortBar _sortBar;

		// Token: 0x0400B4D8 RID: 46296
		[Token(Token = "0x400B4D8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuildingShopFormulaList _itemList;

		// Token: 0x0400B4D9 RID: 46297
		[Token(Token = "0x400B4D9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingShopFormulaCategoryTab[] _itemTabs;

		// Token: 0x0400B4DA RID: 46298
		[Token(Token = "0x400B4DA")]
		[FieldOffset(Offset = "0x90")]
		private SFormulaStateBean m_stateBean;

		// Token: 0x0400B4DB RID: 46299
		[Token(Token = "0x400B4DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B4DC RID: 46300
		[Token(Token = "0x400B4DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400B4DD RID: 46301
		[Token(Token = "0x400B4DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400B4DE RID: 46302
		[Token(Token = "0x400B4DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0400B4DF RID: 46303
		[Token(Token = "0x400B4DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400B4E0 RID: 46304
		[Token(Token = "0x400B4E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B4E1 RID: 46305
		[Token(Token = "0x400B4E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnFilterBtnClicked;

		// Token: 0x0400B4E2 RID: 46306
		[Token(Token = "0x400B4E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToSortFilterState;

		// Token: 0x0400B4E3 RID: 46307
		[Token(Token = "0x400B4E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromSortFilterState;

		// Token: 0x0400B4E4 RID: 46308
		[Token(Token = "0x400B4E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnItemTypeClicked;

		// Token: 0x0400B4E5 RID: 46309
		[Token(Token = "0x400B4E5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSortItemClicked;

		// Token: 0x0400B4E6 RID: 46310
		[Token(Token = "0x400B4E6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnFormulaClicked;

		// Token: 0x0400B4E7 RID: 46311
		[Token(Token = "0x400B4E7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
