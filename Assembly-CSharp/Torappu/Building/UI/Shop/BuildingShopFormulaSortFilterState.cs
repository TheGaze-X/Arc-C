using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CF0 RID: 7408
	[Token(Token = "0x2001CF0")]
	public class BuildingShopFormulaSortFilterState : PopupFloatState
	{
		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6F9")]
		[Address(RVA = "0x3340540", Offset = "0x333F140", VA = "0x183340540", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FA")]
		[Address(RVA = "0x33405A0", Offset = "0x333F1A0", VA = "0x1833405A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FB")]
		[Address(RVA = "0x3340A00", Offset = "0x333F600", VA = "0x183340A00")]
		private void _RefreshSorts()
		{
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FC")]
		[Address(RVA = "0x3340910", Offset = "0x333F510", VA = "0x183340910")]
		private void _RefreshFilters()
		{
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FD")]
		[Address(RVA = "0x33404B0", Offset = "0x333F0B0", VA = "0x1833404B0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FE")]
		[Address(RVA = "0x3340430", Offset = "0x333F030", VA = "0x183340430")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FF")]
		[Address(RVA = "0x3340850", Offset = "0x333F450", VA = "0x183340850")]
		private void _OnSortTypeClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B700")]
		[Address(RVA = "0x33407A0", Offset = "0x333F3A0", VA = "0x1833407A0")]
		private void _OnFilterTypeClicked(FormulaFilterType filterType)
		{
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B701")]
		[Address(RVA = "0x3340B00", Offset = "0x333F700", VA = "0x183340B00")]
		public BuildingShopFormulaSortFilterState()
		{
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B702")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400B4CA RID: 46282
		[Token(Token = "0x400B4CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingShopFormulaFilterItem[] _filterItems;

		// Token: 0x0400B4CB RID: 46283
		[Token(Token = "0x400B4CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingShopFormulaSortItem[] _sortItems;

		// Token: 0x0400B4CC RID: 46284
		[Token(Token = "0x400B4CC")]
		[FieldOffset(Offset = "0x80")]
		private SFormulaSortFilterStateBean m_stateBean;

		// Token: 0x0400B4CD RID: 46285
		[Token(Token = "0x400B4CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B4CE RID: 46286
		[Token(Token = "0x400B4CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B4CF RID: 46287
		[Token(Token = "0x400B4CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshSorts;

		// Token: 0x0400B4D0 RID: 46288
		[Token(Token = "0x400B4D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshFilters;

		// Token: 0x0400B4D1 RID: 46289
		[Token(Token = "0x400B4D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0400B4D2 RID: 46290
		[Token(Token = "0x400B4D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0400B4D3 RID: 46291
		[Token(Token = "0x400B4D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSortTypeClicked;

		// Token: 0x0400B4D4 RID: 46292
		[Token(Token = "0x400B4D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFilterTypeClicked;

		// Token: 0x0400B4D5 RID: 46293
		[Token(Token = "0x400B4D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
