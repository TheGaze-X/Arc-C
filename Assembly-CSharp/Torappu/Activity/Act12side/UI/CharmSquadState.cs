using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A8D RID: 31373
	[Token(Token = "0x2007A8D")]
	public class CharmSquadState : PopupFadeState
	{
		// Token: 0x0602BF0F RID: 179983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF0F")]
		[Address(RVA = "0x27E8B20", Offset = "0x27E7720", VA = "0x1827E8B20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF10 RID: 179984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF10")]
		[Address(RVA = "0x27E8B80", Offset = "0x27E7780", VA = "0x1827E8B80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BF11 RID: 179985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF11")]
		[Address(RVA = "0x27E9E00", Offset = "0x27E8A00", VA = "0x1827E9E00")]
		private void _RaiseSignalCharmRepoRouted()
		{
		}

		// Token: 0x0602BF12 RID: 179986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF12")]
		[Address(RVA = "0x27E9E60", Offset = "0x27E8A60", VA = "0x1827E9E60")]
		private void _Refresh()
		{
		}

		// Token: 0x0602BF13 RID: 179987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF13")]
		[Address(RVA = "0x27EA390", Offset = "0x27E8F90", VA = "0x1827EA390")]
		private void _UpdateSelectStatus(bool resort)
		{
		}

		// Token: 0x0602BF14 RID: 179988 RVA: 0x000DDBC8 File Offset: 0x000DBDC8
		[Token(Token = "0x602BF14")]
		[Address(RVA = "0x27E8CA0", Offset = "0x27E78A0", VA = "0x1827E8CA0")]
		private int _GetCharmIdxByType(string charmType)
		{
			return 0;
		}

		// Token: 0x0602BF15 RID: 179989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF15")]
		[Address(RVA = "0x27E9600", Offset = "0x27E8200", VA = "0x1827E9600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF16 RID: 179990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF16")]
		[Address(RVA = "0x27E8AC0", Offset = "0x27E76C0", VA = "0x1827E8AC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF17 RID: 179991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF17")]
		[Address(RVA = "0x27E9550", Offset = "0x27E8150", VA = "0x1827E9550")]
		private void _HandleSortTypeChanged(string stateId)
		{
		}

		// Token: 0x0602BF18 RID: 179992 RVA: 0x000DDBE0 File Offset: 0x000DBDE0
		[Token(Token = "0x602BF18")]
		[Address(RVA = "0x27EA2B0", Offset = "0x27E8EB0", VA = "0x1827EA2B0")]
		private int _Sort(CharmModel c1, CharmModel c2)
		{
			return 0;
		}

		// Token: 0x0602BF19 RID: 179993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF19")]
		[Address(RVA = "0x27E9240", Offset = "0x27E7E40", VA = "0x1827E9240")]
		private void _HandleSelectChanged(CharmCard card)
		{
		}

		// Token: 0x0602BF1A RID: 179994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1A")]
		[Address(RVA = "0x27E9DA0", Offset = "0x27E89A0", VA = "0x1827E9DA0")]
		private void _RaiseAVGSignal()
		{
		}

		// Token: 0x0602BF1B RID: 179995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1B")]
		[Address(RVA = "0x27EA1B0", Offset = "0x27E8DB0", VA = "0x1827EA1B0")]
		private void _RemoveSelect(int idx)
		{
		}

		// Token: 0x0602BF1C RID: 179996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1C")]
		[Address(RVA = "0x27E8DD0", Offset = "0x27E79D0", VA = "0x1827E8DD0")]
		private void _HandleBack()
		{
		}

		// Token: 0x0602BF1D RID: 179997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1D")]
		[Address(RVA = "0x27E8BE0", Offset = "0x27E77E0", VA = "0x1827E8BE0")]
		private void _DoBack()
		{
		}

		// Token: 0x0602BF1E RID: 179998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1E")]
		[Address(RVA = "0x27E8680", Offset = "0x27E7280", VA = "0x1827E8680")]
		public void EventOnSave()
		{
		}

		// Token: 0x0602BF1F RID: 179999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF1F")]
		[Address(RVA = "0x27E8510", Offset = "0x27E7110", VA = "0x1827E8510")]
		public void EventOnClear()
		{
		}

		// Token: 0x0602BF20 RID: 180000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF20")]
		[Address(RVA = "0x27EA630", Offset = "0x27E9230", VA = "0x1827EA630")]
		public CharmSquadState()
		{
		}

		// Token: 0x0602BF21 RID: 180001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF21")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BF22 RID: 180002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF22")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FA6C RID: 260716
		[Token(Token = "0x403FA6C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FA6D RID: 260717
		[Token(Token = "0x403FA6D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _holdRoot;

		// Token: 0x0403FA6E RID: 260718
		[Token(Token = "0x403FA6E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CharmHole _holePrefab;

		// Token: 0x0403FA6F RID: 260719
		[Token(Token = "0x403FA6F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MultiStateToggleGroup _sortToggles;

		// Token: 0x0403FA70 RID: 260720
		[Token(Token = "0x403FA70")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CharmListAdapter _charmList;

		// Token: 0x0403FA71 RID: 260721
		[Token(Token = "0x403FA71")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _saveBtn;

		// Token: 0x0403FA72 RID: 260722
		[Token(Token = "0x403FA72")]
		private const int CHARM_SQUAD_HOLE_NUM = 5;

		// Token: 0x0403FA73 RID: 260723
		[Token(Token = "0x403FA73")]
		[FieldOffset(Offset = "0xA0")]
		private CharmHole[] m_holes;

		// Token: 0x0403FA74 RID: 260724
		[Token(Token = "0x403FA74")]
		[FieldOffset(Offset = "0xA8")]
		private List<CharmModel> m_charms;

		// Token: 0x0403FA75 RID: 260725
		[Token(Token = "0x403FA75")]
		[FieldOffset(Offset = "0xB0")]
		private List<CharmModel> m_showList;

		// Token: 0x0403FA76 RID: 260726
		[Token(Token = "0x403FA76")]
		[FieldOffset(Offset = "0xB8")]
		private List<CharmModel> m_seleted;

		// Token: 0x0403FA77 RID: 260727
		[Token(Token = "0x403FA77")]
		[FieldOffset(Offset = "0x0")]
		private static string s_preSort;

		// Token: 0x0403FA78 RID: 260728
		[Token(Token = "0x403FA78")]
		[FieldOffset(Offset = "0xC0")]
		private Comparison<CharmModel> m_sortFunc;

		// Token: 0x0403FA79 RID: 260729
		[Token(Token = "0x403FA79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FA7A RID: 260730
		[Token(Token = "0x403FA7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FA7B RID: 260731
		[Token(Token = "0x403FA7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RaiseSignalCharmRepoRouted;

		// Token: 0x0403FA7C RID: 260732
		[Token(Token = "0x403FA7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403FA7D RID: 260733
		[Token(Token = "0x403FA7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateSelectStatus;

		// Token: 0x0403FA7E RID: 260734
		[Token(Token = "0x403FA7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetCharmIdxByType;

		// Token: 0x0403FA7F RID: 260735
		[Token(Token = "0x403FA7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FA80 RID: 260736
		[Token(Token = "0x403FA80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FA81 RID: 260737
		[Token(Token = "0x403FA81")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleSortTypeChanged;

		// Token: 0x0403FA82 RID: 260738
		[Token(Token = "0x403FA82")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Sort;

		// Token: 0x0403FA83 RID: 260739
		[Token(Token = "0x403FA83")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleSelectChanged;

		// Token: 0x0403FA84 RID: 260740
		[Token(Token = "0x403FA84")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RaiseAVGSignal;

		// Token: 0x0403FA85 RID: 260741
		[Token(Token = "0x403FA85")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RemoveSelect;

		// Token: 0x0403FA86 RID: 260742
		[Token(Token = "0x403FA86")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleBack;

		// Token: 0x0403FA87 RID: 260743
		[Token(Token = "0x403FA87")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoBack;

		// Token: 0x0403FA88 RID: 260744
		[Token(Token = "0x403FA88")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnSave;

		// Token: 0x0403FA89 RID: 260745
		[Token(Token = "0x403FA89")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnClear;

		// Token: 0x0403FA8A RID: 260746
		[Token(Token = "0x403FA8A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
