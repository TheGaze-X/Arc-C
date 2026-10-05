using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006747 RID: 26439
	[Token(Token = "0x2006747")]
	public class HalfIdleUIBattleEquipListView : UICustomAdapterLayout<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>
	{
		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x06025F1E RID: 155422 RVA: 0x000C9858 File Offset: 0x000C7A58
		[Token(Token = "0x170059D2")]
		public Act1VHalfIdleEquipType type
		{
			[Token(Token = "0x6025F1E")]
			[Address(RVA = "0x20F2BE0", Offset = "0x20F17E0", VA = "0x1820F2BE0")]
			get
			{
				return Act1VHalfIdleEquipType.WEAPON;
			}
		}

		// Token: 0x06025F1F RID: 155423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F1F")]
		[Address(RVA = "0x20F2630", Offset = "0x20F1230", VA = "0x1820F2630")]
		public void Render(List<HalfIdleUIBattleEquipItemViewModel> equipItemViewModelList, int currEquipNum, int maxEquipNum, string actId, bool isInitList)
		{
		}

		// Token: 0x06025F20 RID: 155424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F20")]
		[Address(RVA = "0x20F2840", Offset = "0x20F1440", VA = "0x1820F2840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025F21 RID: 155425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F21")]
		[Address(RVA = "0x20F2B60", Offset = "0x20F1760", VA = "0x1820F2B60")]
		public HalfIdleUIBattleEquipListView()
		{
		}

		// Token: 0x040355C5 RID: 218565
		[Token(Token = "0x40355C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Equip Bag")]
		private HalfIdleUIBattleEquipItemView _equipItemPrefab;

		// Token: 0x040355C6 RID: 218566
		[Token(Token = "0x40355C6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Equip Bag")]
		private Vector2 _gridSize;

		// Token: 0x040355C7 RID: 218567
		[Token(Token = "0x40355C7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Equip Bag")]
		private Vector2 _spacing;

		// Token: 0x040355C8 RID: 218568
		[Token(Token = "0x40355C8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Equip Bag")]
		private Rect _padding;

		// Token: 0x040355C9 RID: 218569
		[Token(Token = "0x40355C9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act1VHalfIdleEquipType _type;

		// Token: 0x040355CA RID: 218570
		[Token(Token = "0x40355CA")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _transitionMoveDur;

		// Token: 0x040355CB RID: 218571
		[Token(Token = "0x40355CB")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedMaxEquipNum;

		// Token: 0x040355CC RID: 218572
		[Token(Token = "0x40355CC")]
		[FieldOffset(Offset = "0xAC")]
		private int m_cachedCurrEquipNum;

		// Token: 0x040355CD RID: 218573
		[Token(Token = "0x40355CD")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedActId;

		// Token: 0x040355CE RID: 218574
		[Token(Token = "0x40355CE")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedIsInitList;

		// Token: 0x040355CF RID: 218575
		[Token(Token = "0x40355CF")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_inited;

		// Token: 0x040355D0 RID: 218576
		[Token(Token = "0x40355D0")]
		[FieldOffset(Offset = "0xC0")]
		private HalfIdleUIBattleEquipListView.EquipItemLayouter m_layouter;

		// Token: 0x040355D1 RID: 218577
		[Token(Token = "0x40355D1")]
		[FieldOffset(Offset = "0xC8")]
		private HalfIdleUIBattleEquipListView.EquipItemAdapter m_adapter;

		// Token: 0x040355D2 RID: 218578
		[Token(Token = "0x40355D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040355D3 RID: 218579
		[Token(Token = "0x40355D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040355D4 RID: 218580
		[Token(Token = "0x40355D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040355D5 RID: 218581
		[Token(Token = "0x40355D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006748 RID: 26440
		[Token(Token = "0x2006748")]
		private class EquipItemAdapter : UICustomAdapterLayout<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>.Adapter
		{
			// Token: 0x06025F22 RID: 155426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F22")]
			[Address(RVA = "0x20EFFA0", Offset = "0x20EEBA0", VA = "0x1820EFFA0")]
			public void SetDataSource(List<HalfIdleUIBattleEquipItemViewModel> dataSource, int num)
			{
			}

			// Token: 0x06025F23 RID: 155427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F23")]
			[Address(RVA = "0x20F02C0", Offset = "0x20EEEC0", VA = "0x1820F02C0")]
			public EquipItemAdapter(HalfIdleUIBattleEquipListView closure)
			{
			}

			// Token: 0x06025F24 RID: 155428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F24")]
			[Address(RVA = "0x20EFD80", Offset = "0x20EE980", VA = "0x1820EFD80", Slot = "6")]
			public override HalfIdleUIBattleEquipItemView CreateInst(HalfIdleUIBattleEquipItemViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06025F25 RID: 155429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F25")]
			[Address(RVA = "0x20F00C0", Offset = "0x20EECC0", VA = "0x1820F00C0", Slot = "7")]
			public override void UpdateView(HalfIdleUIBattleEquipItemView view, HalfIdleUIBattleEquipItemViewModel data)
			{
			}

			// Token: 0x06025F26 RID: 155430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F26")]
			[Address(RVA = "0x20EFF00", Offset = "0x20EEB00", VA = "0x1820EFF00", Slot = "5")]
			public override string GetId(HalfIdleUIBattleEquipItemViewModel data)
			{
				return null;
			}

			// Token: 0x06025F27 RID: 155431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F27")]
			[Address(RVA = "0x20EFE60", Offset = "0x20EEA60", VA = "0x1820EFE60", Slot = "4")]
			public override IList<HalfIdleUIBattleEquipItemViewModel> GetData()
			{
				return null;
			}

			// Token: 0x040355D6 RID: 218582
			[Token(Token = "0x40355D6")]
			[FieldOffset(Offset = "0x20")]
			private HalfIdleUIBattleEquipListView m_closure;

			// Token: 0x040355D7 RID: 218583
			[Token(Token = "0x40355D7")]
			[FieldOffset(Offset = "0x28")]
			private List<HalfIdleUIBattleEquipItemViewModel> m_cachedEquipItemViewModelList;

			// Token: 0x040355D8 RID: 218584
			[Token(Token = "0x40355D8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetDataSource;

			// Token: 0x040355D9 RID: 218585
			[Token(Token = "0x40355D9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040355DA RID: 218586
			[Token(Token = "0x40355DA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x040355DB RID: 218587
			[Token(Token = "0x40355DB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x040355DC RID: 218588
			[Token(Token = "0x40355DC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x040355DD RID: 218589
			[Token(Token = "0x40355DD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x02006749 RID: 26441
		[Token(Token = "0x2006749")]
		private class EquipItemLayouter : UICustomGridLayouter<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>
		{
			// Token: 0x06025F28 RID: 155432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F28")]
			[Address(RVA = "0x20F1190", Offset = "0x20EFD90", VA = "0x1820F1190")]
			public EquipItemLayouter(HalfIdleUIBattleEquipListView closure)
			{
			}

			// Token: 0x06025F29 RID: 155433 RVA: 0x000C9870 File Offset: 0x000C7A70
			[Token(Token = "0x6025F29")]
			[Address(RVA = "0x20F03A0", Offset = "0x20EEFA0", VA = "0x1820F03A0", Slot = "6")]
			protected override GridPosition DataToOffset(HalfIdleUIBattleEquipItemViewModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x06025F2A RID: 155434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F2A")]
			[Address(RVA = "0x20F0430", Offset = "0x20EF030", VA = "0x1820F0430", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x06025F2B RID: 155435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F2B")]
			[Address(RVA = "0x20F05B0", Offset = "0x20EF1B0", VA = "0x1820F05B0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06025F2C RID: 155436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F2C")]
			[Address(RVA = "0x20F0AB0", Offset = "0x20EF6B0", VA = "0x1820F0AB0")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>.Layouter.LayoutElement ele, UICustomGridLayouter<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>.LayoutMeta meta, bool blasted, bool isInitList)
			{
			}

			// Token: 0x06025F2D RID: 155437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F2D")]
			[Address(RVA = "0x20F0DB0", Offset = "0x20EF9B0", VA = "0x1820F0DB0")]
			private void _TransitionRemoved(UICustomAdapterLayout<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>.Layouter.LayoutElement ele, bool blasted, bool isInitList)
			{
			}

			// Token: 0x040355DE RID: 218590
			[Token(Token = "0x40355DE")]
			[FieldOffset(Offset = "0x70")]
			private HalfIdleUIBattleEquipListView m_closure;

			// Token: 0x040355DF RID: 218591
			[Token(Token = "0x40355DF")]
			[FieldOffset(Offset = "0x78")]
			private int m_cachedEquipNum;

			// Token: 0x040355E0 RID: 218592
			[Token(Token = "0x40355E0")]
			[FieldOffset(Offset = "0x80")]
			private ListDict<string, UICustomAdapterLayout<HalfIdleUIBattleEquipItemViewModel, HalfIdleUIBattleEquipItemView>.Layouter.LayoutElement> m_cachedElements;

			// Token: 0x040355E1 RID: 218593
			[Token(Token = "0x40355E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040355E2 RID: 218594
			[Token(Token = "0x40355E2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x040355E3 RID: 218595
			[Token(Token = "0x40355E3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x040355E4 RID: 218596
			[Token(Token = "0x40355E4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x040355E5 RID: 218597
			[Token(Token = "0x40355E5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x040355E6 RID: 218598
			[Token(Token = "0x40355E6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;
		}
	}
}
