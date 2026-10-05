using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069B4 RID: 27060
	[Token(Token = "0x20069B4")]
	public class StageZoneSeasonGroupPanel : StageZoneGroupPanel
	{
		// Token: 0x06026BA0 RID: 158624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA0")]
		[Address(RVA = "0x21CC960", Offset = "0x21CB560", VA = "0x1821CC960", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026BA1 RID: 158625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA1")]
		[Address(RVA = "0x21CC630", Offset = "0x21CB230", VA = "0x1821CC630", Slot = "9")]
		protected override void OnDataUpdated(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x06026BA2 RID: 158626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA2")]
		[Address(RVA = "0x21CD910", Offset = "0x21CC510", VA = "0x1821CD910")]
		private void _RebuildEntryViews(SeasonZoneGroupViewModel groupModel)
		{
		}

		// Token: 0x06026BA3 RID: 158627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA3")]
		[Address(RVA = "0x21CD3A0", Offset = "0x21CBFA0", VA = "0x1821CD3A0")]
		private void _DoFocus(int focusIndex)
		{
		}

		// Token: 0x06026BA4 RID: 158628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA4")]
		[Address(RVA = "0x21CD4B0", Offset = "0x21CC0B0", VA = "0x1821CD4B0")]
		private void _FocusToItem(int focusIndex)
		{
		}

		// Token: 0x06026BA5 RID: 158629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA5")]
		[Address(RVA = "0x21CDB80", Offset = "0x21CC780", VA = "0x1821CDB80")]
		private void _TryConsumeTrack(SeasonZoneGroupViewModel groupModel)
		{
		}

		// Token: 0x06026BA6 RID: 158630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA6")]
		[Address(RVA = "0x21CCD80", Offset = "0x21CB980", VA = "0x1821CCD80")]
		private void _AddRecalRuneEntry(StageZoneSeasonEntryViewModel viewModel, StageZoneSeasonAdapter adapter)
		{
		}

		// Token: 0x06026BA7 RID: 158631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA7")]
		[Address(RVA = "0x21CCA60", Offset = "0x21CB660", VA = "0x1821CCA60")]
		private void _AddCrisisV2Entry(StageZoneSeasonEntryViewModel viewModel, StageZoneSeasonAdapter adapter)
		{
		}

		// Token: 0x06026BA8 RID: 158632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA8")]
		[Address(RVA = "0x21CD080", Offset = "0x21CBC80", VA = "0x1821CD080")]
		private void _AddVecBreakEntry(StageZoneSeasonEntryViewModel viewModel, StageZoneSeasonAdapter adapter)
		{
		}

		// Token: 0x06026BA9 RID: 158633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BA9")]
		[Address(RVA = "0x21CDD60", Offset = "0x21CC960", VA = "0x1821CDD60")]
		public StageZoneSeasonGroupPanel()
		{
		}

		// Token: 0x06026BAB RID: 158635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BAB")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026BAC RID: 158636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BAC")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30")]
		private void <>xLuaBaseProxy_OnDataUpdated(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x04036ADF RID: 223967
		[Token(Token = "0x4036ADF")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x04036AE0 RID: 223968
		[Token(Token = "0x4036AE0")]
		private const string PREFAB_NAME_CRISIS_V2 = "panel_crisis_v2";

		// Token: 0x04036AE1 RID: 223969
		[Token(Token = "0x4036AE1")]
		private const string PREFAB_NAME_VEC_BREAK = "panel_vec_break";

		// Token: 0x04036AE2 RID: 223970
		[Token(Token = "0x4036AE2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _layout;

		// Token: 0x04036AE3 RID: 223971
		[Token(Token = "0x4036AE3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04036AE4 RID: 223972
		[Token(Token = "0x4036AE4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x04036AE5 RID: 223973
		[Token(Token = "0x4036AE5")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04036AE6 RID: 223974
		[Token(Token = "0x4036AE6")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04036AE7 RID: 223975
		[Token(Token = "0x4036AE7")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04036AE8 RID: 223976
		[Token(Token = "0x4036AE8")]
		[FieldOffset(Offset = "0xA0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04036AE9 RID: 223977
		[Token(Token = "0x4036AE9")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cachedFocusTween;

		// Token: 0x04036AEA RID: 223978
		[Token(Token = "0x4036AEA")]
		[FieldOffset(Offset = "0xB0")]
		private StageZoneSeasonAdapter m_adapter;

		// Token: 0x04036AEB RID: 223979
		[Token(Token = "0x4036AEB")]
		[FieldOffset(Offset = "0xB8")]
		private int m_focusIndex;

		// Token: 0x04036AEC RID: 223980
		[Token(Token = "0x4036AEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036AED RID: 223981
		[Token(Token = "0x4036AED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04036AEE RID: 223982
		[Token(Token = "0x4036AEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RebuildEntryViews;

		// Token: 0x04036AEF RID: 223983
		[Token(Token = "0x4036AEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoFocus;

		// Token: 0x04036AF0 RID: 223984
		[Token(Token = "0x4036AF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FocusToItem;

		// Token: 0x04036AF1 RID: 223985
		[Token(Token = "0x4036AF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryConsumeTrack;

		// Token: 0x04036AF2 RID: 223986
		[Token(Token = "0x4036AF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddRecalRuneEntry;

		// Token: 0x04036AF3 RID: 223987
		[Token(Token = "0x4036AF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddCrisisV2Entry;

		// Token: 0x04036AF4 RID: 223988
		[Token(Token = "0x4036AF4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddVecBreakEntry;

		// Token: 0x04036AF5 RID: 223989
		[Token(Token = "0x4036AF5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069B5 RID: 27061
		[Token(Token = "0x20069B5")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06026BAD RID: 158637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BAD")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			public OnPostLayoutAction(StageZoneSeasonGroupPanel closure, int focusIdx)
			{
			}

			// Token: 0x06026BAE RID: 158638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BAE")]
			[Address(RVA = "0x21BA780", Offset = "0x21B9380", VA = "0x1821BA780", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04036AF6 RID: 223990
			[Token(Token = "0x4036AF6")]
			[FieldOffset(Offset = "0x10")]
			private StageZoneSeasonGroupPanel m_closure;

			// Token: 0x04036AF7 RID: 223991
			[Token(Token = "0x4036AF7")]
			[FieldOffset(Offset = "0x18")]
			private int m_focusIdx;
		}
	}
}
