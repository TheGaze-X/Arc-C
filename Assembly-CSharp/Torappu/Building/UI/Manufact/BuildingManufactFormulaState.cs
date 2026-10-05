using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D96 RID: 7574
	[Token(Token = "0x2001D96")]
	public class BuildingManufactFormulaState : PopupFloatState
	{
		// Token: 0x0600BAC1 RID: 47809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAC1")]
		[Address(RVA = "0x336C840", Offset = "0x336B440", VA = "0x18336C840", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC2")]
		[Address(RVA = "0x336D080", Offset = "0x336BC80", VA = "0x18336D080")]
		private void Start()
		{
		}

		// Token: 0x0600BAC3 RID: 47811 RVA: 0x00045DB0 File Offset: 0x00043FB0
		[Token(Token = "0x600BAC3")]
		[Address(RVA = "0x336D4C0", Offset = "0x336C0C0", VA = "0x18336D4C0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAC4")]
		[Address(RVA = "0x336CDC0", Offset = "0x336B9C0", VA = "0x18336CDC0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAC5")]
		[Address(RVA = "0x336CF20", Offset = "0x336BB20", VA = "0x18336CF20", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600BAC6 RID: 47814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC6")]
		[Address(RVA = "0x336C8A0", Offset = "0x336B4A0", VA = "0x18336C8A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC7")]
		[Address(RVA = "0x336CCA0", Offset = "0x336B8A0", VA = "0x18336CCA0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC8")]
		[Address(RVA = "0x336C7A0", Offset = "0x336B3A0", VA = "0x18336C7A0")]
		public void EventOnFilterBtnClicked()
		{
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC9")]
		[Address(RVA = "0x336D880", Offset = "0x336C480", VA = "0x18336D880")]
		private void _OnJumpToSortFilterState(MFormulaSortFilterStateBean filterBean)
		{
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACA")]
		[Address(RVA = "0x336D780", Offset = "0x336C380", VA = "0x18336D780")]
		private void _OnJumpBackFromSortFilterState(MFormulaSortFilterStateBean filterBean)
		{
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACB")]
		[Address(RVA = "0x336D650", Offset = "0x336C250", VA = "0x18336D650")]
		private void _OnItemTypeClicked(BuildingData.FormulaItemType formulaType)
		{
		}

		// Token: 0x0600BACC RID: 47820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACC")]
		[Address(RVA = "0x336D930", Offset = "0x336C530", VA = "0x18336D930")]
		private void _OnSortItemClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600BACD RID: 47821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACD")]
		[Address(RVA = "0x336D530", Offset = "0x336C130", VA = "0x18336D530")]
		private void _OnFormulaClicked(MFormulaViewModel selectedFormula)
		{
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACE")]
		[Address(RVA = "0x336DB20", Offset = "0x336C720", VA = "0x18336DB20")]
		public BuildingManufactFormulaState()
		{
		}

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x00045DC8 File Offset: 0x00043FC8
		[Token(Token = "0x600BAD2")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAD3")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAD4")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAD5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAD6")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400BA12 RID: 47634
		[Token(Token = "0x400BA12")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400BA13 RID: 47635
		[Token(Token = "0x400BA13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingManufactFormulaSortBar _sortBar;

		// Token: 0x0400BA14 RID: 47636
		[Token(Token = "0x400BA14")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuildingManufactFormulaList _itemList;

		// Token: 0x0400BA15 RID: 47637
		[Token(Token = "0x400BA15")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingManufactFormulaCategoryTab[] _itemTabs;

		// Token: 0x0400BA16 RID: 47638
		[Token(Token = "0x400BA16")]
		[FieldOffset(Offset = "0x90")]
		private MFormulaStateBean m_stateBean;

		// Token: 0x0400BA17 RID: 47639
		[Token(Token = "0x400BA17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400BA18 RID: 47640
		[Token(Token = "0x400BA18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BA19 RID: 47641
		[Token(Token = "0x400BA19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400BA1A RID: 47642
		[Token(Token = "0x400BA1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0400BA1B RID: 47643
		[Token(Token = "0x400BA1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400BA1C RID: 47644
		[Token(Token = "0x400BA1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BA1D RID: 47645
		[Token(Token = "0x400BA1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400BA1E RID: 47646
		[Token(Token = "0x400BA1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnFilterBtnClicked;

		// Token: 0x0400BA1F RID: 47647
		[Token(Token = "0x400BA1F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToSortFilterState;

		// Token: 0x0400BA20 RID: 47648
		[Token(Token = "0x400BA20")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromSortFilterState;

		// Token: 0x0400BA21 RID: 47649
		[Token(Token = "0x400BA21")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnItemTypeClicked;

		// Token: 0x0400BA22 RID: 47650
		[Token(Token = "0x400BA22")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSortItemClicked;

		// Token: 0x0400BA23 RID: 47651
		[Token(Token = "0x400BA23")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnFormulaClicked;

		// Token: 0x0400BA24 RID: 47652
		[Token(Token = "0x400BA24")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
