using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200251D RID: 9501
	[Token(Token = "0x200251D")]
	public class ParallelGroupSelector : RangeSelector
	{
		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x0600F521 RID: 62753 RVA: 0x0005AF30 File Offset: 0x00059130
		[Token(Token = "0x17001FF6")]
		protected bool limitTargetNum
		{
			[Token(Token = "0x600F521")]
			[Address(RVA = "0x6CD280", Offset = "0x6CBE80", VA = "0x1806CD280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x0600F522 RID: 62754 RVA: 0x0005AF48 File Offset: 0x00059148
		[Token(Token = "0x17001FF7")]
		protected bool excludedIdAtLast
		{
			[Token(Token = "0x600F522")]
			[Address(RVA = "0x6CD1C0", Offset = "0x6CBDC0", VA = "0x1806CD1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600F523 RID: 62755 RVA: 0x0005AF60 File Offset: 0x00059160
		[Token(Token = "0x17001FF8")]
		public bool notSortAsSelectorOrder
		{
			[Token(Token = "0x600F523")]
			[Address(RVA = "0x6CD2E0", Offset = "0x6CBEE0", VA = "0x1806CD2E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x0600F524 RID: 62756 RVA: 0x0005AF78 File Offset: 0x00059178
		[Token(Token = "0x17001FF9")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F524")]
			[Address(RVA = "0x6CD400", Offset = "0x6CC000", VA = "0x1806CD400", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600F525 RID: 62757 RVA: 0x0005AF90 File Offset: 0x00059190
		[Token(Token = "0x17001FFA")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F525")]
			[Address(RVA = "0x6CD3A0", Offset = "0x6CBFA0", VA = "0x1806CD3A0", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x0600F526 RID: 62758 RVA: 0x0005AFA8 File Offset: 0x000591A8
		[Token(Token = "0x17001FFB")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F526")]
			[Address(RVA = "0x6CD340", Offset = "0x6CBF40", VA = "0x1806CD340", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600F527 RID: 62759 RVA: 0x0005AFC0 File Offset: 0x000591C0
		[Token(Token = "0x17001FFC")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F527")]
			[Address(RVA = "0x6CD220", Offset = "0x6CBE20", VA = "0x1806CD220", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F528 RID: 62760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F528")]
		[Address(RVA = "0x6CCD50", Offset = "0x6CB950", VA = "0x1806CCD50", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F529 RID: 62761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F529")]
		[Address(RVA = "0x6CCF10", Offset = "0x6CBB10", VA = "0x1806CCF10", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F52A RID: 62762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F52A")]
		[Address(RVA = "0x6CC3B0", Offset = "0x6CAFB0", VA = "0x1806CC3B0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F52B RID: 62763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F52B")]
		[Address(RVA = "0x6CC920", Offset = "0x6CB520", VA = "0x1806CC920", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F52C RID: 62764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F52C")]
		[Address(RVA = "0x6CC770", Offset = "0x6CB370", VA = "0x1806CC770", Slot = "24")]
		public override void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600F52D RID: 62765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F52D")]
		[Address(RVA = "0x6CC8C0", Offset = "0x6CB4C0", VA = "0x1806CC8C0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F52E RID: 62766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F52E")]
		[Address(RVA = "0x6CD0C0", Offset = "0x6CBCC0", VA = "0x1806CD0C0")]
		public ParallelGroupSelector()
		{
		}

		// Token: 0x0600F52F RID: 62767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F52F")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F530 RID: 62768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F530")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F531 RID: 62769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F531")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F532 RID: 62770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F532")]
		[Address(RVA = "0x6CD0B0", Offset = "0x6CBCB0", VA = "0x1806CD0B0")]
		private void <>xLuaBaseProxy_OnAbilityExtendUpdated(FP P0)
		{
		}

		// Token: 0x04010FB6 RID: 69558
		[Token(Token = "0x4010FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TargetSelector[] _selectorGroup;

		// Token: 0x04010FB7 RID: 69559
		[Token(Token = "0x4010FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _sortAsSelectorOrder;

		// Token: 0x04010FB8 RID: 69560
		[Token(Token = "0x4010FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Inspect("notSortAsSelectorOrder")]
		protected FilterUtil.FilterType _postFilter;

		// Token: 0x04010FB9 RID: 69561
		[Token(Token = "0x4010FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("notSortAsSelectorOrder")]
		protected bool _sortByTauntAtLast;

		// Token: 0x04010FBA RID: 69562
		[Token(Token = "0x4010FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04010FBB RID: 69563
		[Token(Token = "0x4010FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private int _maxNum;

		// Token: 0x04010FBC RID: 69564
		[Token(Token = "0x4010FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private string _maxNumBlackboardKey;

		// Token: 0x04010FBD RID: 69565
		[Token(Token = "0x4010FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _fixParentReset;

		// Token: 0x04010FBE RID: 69566
		[Token(Token = "0x4010FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[SerializeField]
		private bool _excludedIdAtLast;

		// Token: 0x04010FBF RID: 69567
		[Token(Token = "0x4010FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Inspect("excludedIdAtLast")]
		private List<string> _excludedIds;

		// Token: 0x04010FC0 RID: 69568
		[Token(Token = "0x4010FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _onlyResizeWhenFilter;

		// Token: 0x04010FC1 RID: 69569
		[Token(Token = "0x4010FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		[SerializeField]
		private bool _passOnlyIfSatisfyAll;

		// Token: 0x04010FC2 RID: 69570
		[Token(Token = "0x4010FC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int m_maxTargetNum;

		// Token: 0x04010FC3 RID: 69571
		[Token(Token = "0x4010FC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04010FC4 RID: 69572
		[Token(Token = "0x4010FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_excludedIdAtLast;

		// Token: 0x04010FC5 RID: 69573
		[Token(Token = "0x4010FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_notSortAsSelectorOrder;

		// Token: 0x04010FC6 RID: 69574
		[Token(Token = "0x4010FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010FC7 RID: 69575
		[Token(Token = "0x4010FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010FC8 RID: 69576
		[Token(Token = "0x4010FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010FC9 RID: 69577
		[Token(Token = "0x4010FC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010FCA RID: 69578
		[Token(Token = "0x4010FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010FCB RID: 69579
		[Token(Token = "0x4010FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010FCC RID: 69580
		[Token(Token = "0x4010FCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010FCD RID: 69581
		[Token(Token = "0x4010FCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010FCE RID: 69582
		[Token(Token = "0x4010FCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x04010FCF RID: 69583
		[Token(Token = "0x4010FCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010FD0 RID: 69584
		[Token(Token = "0x4010FD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
