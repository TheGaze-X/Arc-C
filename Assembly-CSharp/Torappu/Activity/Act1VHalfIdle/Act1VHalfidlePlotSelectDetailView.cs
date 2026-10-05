using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007766 RID: 30566
	[Token(Token = "0x2007766")]
	public class Act1VHalfidlePlotSelectDetailView : DataBinder<Act1VHalfidlePlotSelectProperty>
	{
		// Token: 0x0602AED0 RID: 175824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED0")]
		[Address(RVA = "0x26BA160", Offset = "0x26B8D60", VA = "0x1826BA160")]
		private void _InitIfNot(Act1VHalfidlePlotSelectViewModel viewModel)
		{
		}

		// Token: 0x0602AED1 RID: 175825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED1")]
		[Address(RVA = "0x26B9E70", Offset = "0x26B8A70", VA = "0x1826B9E70", Slot = "7")]
		public override void OnValueChanged(Act1VHalfidlePlotSelectProperty property)
		{
		}

		// Token: 0x0602AED2 RID: 175826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED2")]
		[Address(RVA = "0x26BA4C0", Offset = "0x26B90C0", VA = "0x1826BA4C0")]
		private void _RenderBaseInfo(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AED3 RID: 175827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED3")]
		[Address(RVA = "0x26BA740", Offset = "0x26B9340", VA = "0x1826BA740")]
		private void _RenderEnemyInfo(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AED4 RID: 175828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED4")]
		[Address(RVA = "0x26BA800", Offset = "0x26B9400", VA = "0x1826BA800")]
		private void _RenderMaterial(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AED5 RID: 175829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED5")]
		[Address(RVA = "0x26BA950", Offset = "0x26B9550", VA = "0x1826BA950")]
		private void _RenderReciptInfo(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AED6 RID: 175830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED6")]
		[Address(RVA = "0x26BA3D0", Offset = "0x26B8FD0", VA = "0x1826BA3D0")]
		private void _OnEnemyDetailClicked(List<EnemyHandBookEverViewModel> enemyHandbookViewModel)
		{
		}

		// Token: 0x0602AED7 RID: 175831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED7")]
		[Address(RVA = "0x26B9DD0", Offset = "0x26B89D0", VA = "0x1826B9DD0")]
		public void EventOnDeriveClick()
		{
		}

		// Token: 0x0602AED8 RID: 175832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AED8")]
		[Address(RVA = "0x26BABC0", Offset = "0x26B97C0", VA = "0x1826BABC0")]
		public Act1VHalfidlePlotSelectDetailView()
		{
		}

		// Token: 0x0403DED4 RID: 253652
		[Token(Token = "0x403DED4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DED5 RID: 253653
		[Token(Token = "0x403DED5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalObj;

		// Token: 0x0403DED6 RID: 253654
		[Token(Token = "0x403DED6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _contentEmptyPart;

		// Token: 0x0403DED7 RID: 253655
		[Token(Token = "0x403DED7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _contentPart;

		// Token: 0x0403DED8 RID: 253656
		[Token(Token = "0x403DED8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _plotImg;

		// Token: 0x0403DED9 RID: 253657
		[Token(Token = "0x403DED9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _rarityIcon;

		// Token: 0x0403DEDA RID: 253658
		[Token(Token = "0x403DEDA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0403DEDB RID: 253659
		[Token(Token = "0x403DEDB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x0403DEDC RID: 253660
		[Token(Token = "0x403DEDC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _plotName;

		// Token: 0x0403DEDD RID: 253661
		[Token(Token = "0x403DEDD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _description;

		// Token: 0x0403DEDE RID: 253662
		[Token(Token = "0x403DEDE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _contentContainer;

		// Token: 0x0403DEDF RID: 253663
		[Token(Token = "0x403DEDF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdlePlotEnemyInfoView _enemyInfoView;

		// Token: 0x0403DEE0 RID: 253664
		[Token(Token = "0x403DEE0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlProductionList;

		// Token: 0x0403DEE1 RID: 253665
		[Token(Token = "0x403DEE1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlEmptyProductionList;

		// Token: 0x0403DEE2 RID: 253666
		[Token(Token = "0x403DEE2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _productionList;

		// Token: 0x0403DEE3 RID: 253667
		[Token(Token = "0x403DEE3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SimpleLayoutContent _deriveContent;

		// Token: 0x0403DEE4 RID: 253668
		[Token(Token = "0x403DEE4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _emptyDerive;

		// Token: 0x0403DEE5 RID: 253669
		[Token(Token = "0x403DEE5")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x0403DEE6 RID: 253670
		[Token(Token = "0x403DEE6")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0403DEE7 RID: 253671
		[Token(Token = "0x403DEE7")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DEE8 RID: 253672
		[Token(Token = "0x403DEE8")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DEE9 RID: 253673
		[Token(Token = "0x403DEE9")]
		[FieldOffset(Offset = "0xD8")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0403DEEA RID: 253674
		[Token(Token = "0x403DEEA")]
		[FieldOffset(Offset = "0xE0")]
		private Act1VHalfidlePlotSelectDetailView.Act1VHalfidleMaterialAdapter m_materialAdapter;

		// Token: 0x0403DEEB RID: 253675
		[Token(Token = "0x403DEEB")]
		[FieldOffset(Offset = "0xE8")]
		private Act1VHalfidlePlotSelectDetailView.Act1VHalfidlePlotDeriveAdapter m_deriveAdapter;

		// Token: 0x0403DEEC RID: 253676
		[Token(Token = "0x403DEEC")]
		[FieldOffset(Offset = "0xF0")]
		private List<Act1VHalfidlePlotViewModel> m_cachedDerivedPlotList;

		// Token: 0x0403DEED RID: 253677
		[Token(Token = "0x403DEED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DEEE RID: 253678
		[Token(Token = "0x403DEEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403DEEF RID: 253679
		[Token(Token = "0x403DEEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBaseInfo;

		// Token: 0x0403DEF0 RID: 253680
		[Token(Token = "0x403DEF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEnemyInfo;

		// Token: 0x0403DEF1 RID: 253681
		[Token(Token = "0x403DEF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMaterial;

		// Token: 0x0403DEF2 RID: 253682
		[Token(Token = "0x403DEF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderReciptInfo;

		// Token: 0x0403DEF3 RID: 253683
		[Token(Token = "0x403DEF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnEnemyDetailClicked;

		// Token: 0x0403DEF4 RID: 253684
		[Token(Token = "0x403DEF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDeriveClick;

		// Token: 0x0403DEF5 RID: 253685
		[Token(Token = "0x403DEF5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007767 RID: 30567
		[Token(Token = "0x2007767")]
		private class Act1VHalfidleMaterialAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170064A8 RID: 25768
			// (get) Token: 0x0602AED9 RID: 175833 RVA: 0x000DA6D0 File Offset: 0x000D88D0
			[Token(Token = "0x170064A8")]
			public override int count
			{
				[Token(Token = "0x602AED9")]
				[Address(RVA = "0x26B79C0", Offset = "0x26B65C0", VA = "0x1826B79C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AEDA RID: 175834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AEDA")]
			[Address(RVA = "0x26B77C0", Offset = "0x26B63C0", VA = "0x1826B77C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602AEDB RID: 175835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEDB")]
			[Address(RVA = "0x26B7960", Offset = "0x26B6560", VA = "0x1826B7960")]
			public Act1VHalfidleMaterialAdapter()
			{
			}

			// Token: 0x0403DEF6 RID: 253686
			[Token(Token = "0x403DEF6")]
			[FieldOffset(Offset = "0x20")]
			public List<Act1VHalfIdlePlotData.ItemDropData> dataList;

			// Token: 0x0403DEF7 RID: 253687
			[Token(Token = "0x403DEF7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403DEF8 RID: 253688
			[Token(Token = "0x403DEF8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403DEF9 RID: 253689
			[Token(Token = "0x403DEF9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007768 RID: 30568
		[Token(Token = "0x2007768")]
		private class Act1VHalfidlePlotDeriveAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170064A9 RID: 25769
			// (get) Token: 0x0602AEDC RID: 175836 RVA: 0x000DA6E8 File Offset: 0x000D88E8
			[Token(Token = "0x170064A9")]
			public override int count
			{
				[Token(Token = "0x602AEDC")]
				[Address(RVA = "0x26B91F0", Offset = "0x26B7DF0", VA = "0x1826B91F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AEDD RID: 175837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AEDD")]
			[Address(RVA = "0x26B8ED0", Offset = "0x26B7AD0", VA = "0x1826B8ED0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602AEDE RID: 175838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEDE")]
			[Address(RVA = "0x26B9190", Offset = "0x26B7D90", VA = "0x1826B9190")]
			public Act1VHalfidlePlotDeriveAdapter()
			{
			}

			// Token: 0x0403DEFA RID: 253690
			[Token(Token = "0x403DEFA")]
			[FieldOffset(Offset = "0x20")]
			public List<Act1VHalfidlePlotViewModel> dataList;

			// Token: 0x0403DEFB RID: 253691
			[Token(Token = "0x403DEFB")]
			[FieldOffset(Offset = "0x28")]
			public string origPlotId;

			// Token: 0x0403DEFC RID: 253692
			[Token(Token = "0x403DEFC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403DEFD RID: 253693
			[Token(Token = "0x403DEFD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403DEFE RID: 253694
			[Token(Token = "0x403DEFE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
