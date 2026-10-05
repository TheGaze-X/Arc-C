using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D95 RID: 7573
	[Token(Token = "0x2001D95")]
	public class BuildingManufactFormulaSortFilterState : PopupFloatState
	{
		// Token: 0x0600BAB7 RID: 47799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAB7")]
		[Address(RVA = "0x336C0F0", Offset = "0x336ACF0", VA = "0x18336C0F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB8")]
		[Address(RVA = "0x336C150", Offset = "0x336AD50", VA = "0x18336C150", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB9")]
		[Address(RVA = "0x336C5B0", Offset = "0x336B1B0", VA = "0x18336C5B0")]
		private void _RefreshSorts()
		{
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABA")]
		[Address(RVA = "0x336C4C0", Offset = "0x336B0C0", VA = "0x18336C4C0")]
		private void _RefreshFilters()
		{
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABB")]
		[Address(RVA = "0x336C060", Offset = "0x336AC60", VA = "0x18336C060")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABC")]
		[Address(RVA = "0x336BFE0", Offset = "0x336ABE0", VA = "0x18336BFE0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABD")]
		[Address(RVA = "0x336C400", Offset = "0x336B000", VA = "0x18336C400")]
		private void _OnSortTypeClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABE")]
		[Address(RVA = "0x336C350", Offset = "0x336AF50", VA = "0x18336C350")]
		private void _OnFilterTypeClicked(FormulaFilterType filterType)
		{
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABF")]
		[Address(RVA = "0x336C6B0", Offset = "0x336B2B0", VA = "0x18336C6B0")]
		public BuildingManufactFormulaSortFilterState()
		{
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400BA06 RID: 47622
		[Token(Token = "0x400BA06")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingManufactFormulaFilterItem[] _filterItems;

		// Token: 0x0400BA07 RID: 47623
		[Token(Token = "0x400BA07")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingManufactFormulaSortItem[] _sortItems;

		// Token: 0x0400BA08 RID: 47624
		[Token(Token = "0x400BA08")]
		[FieldOffset(Offset = "0x80")]
		private MFormulaSortFilterStateBean m_stateBean;

		// Token: 0x0400BA09 RID: 47625
		[Token(Token = "0x400BA09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400BA0A RID: 47626
		[Token(Token = "0x400BA0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BA0B RID: 47627
		[Token(Token = "0x400BA0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshSorts;

		// Token: 0x0400BA0C RID: 47628
		[Token(Token = "0x400BA0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshFilters;

		// Token: 0x0400BA0D RID: 47629
		[Token(Token = "0x400BA0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0400BA0E RID: 47630
		[Token(Token = "0x400BA0E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0400BA0F RID: 47631
		[Token(Token = "0x400BA0F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSortTypeClicked;

		// Token: 0x0400BA10 RID: 47632
		[Token(Token = "0x400BA10")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFilterTypeClicked;

		// Token: 0x0400BA11 RID: 47633
		[Token(Token = "0x400BA11")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
