using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C8 RID: 9416
	[Token(Token = "0x20024C8")]
	public class ContinuousRangeWithConditions : PhysicsRange
	{
		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600F251 RID: 62033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F88")]
		private Character owner
		{
			[Token(Token = "0x600F251")]
			[Address(RVA = "0x68A5D0", Offset = "0x6891D0", VA = "0x18068A5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600F252 RID: 62034 RVA: 0x000593A0 File Offset: 0x000575A0
		[Token(Token = "0x17001F89")]
		private GridPosition root
		{
			[Token(Token = "0x600F252")]
			[Address(RVA = "0x68A7B0", Offset = "0x6893B0", VA = "0x18068A7B0")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x0600F253 RID: 62035 RVA: 0x000593B8 File Offset: 0x000575B8
		[Token(Token = "0x17001F8A")]
		public override bool extendable
		{
			[Token(Token = "0x600F253")]
			[Address(RVA = "0x68A570", Offset = "0x689170", VA = "0x18068A570", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F254 RID: 62036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F254")]
		[Address(RVA = "0x689230", Offset = "0x687E30", VA = "0x180689230", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F255")]
		[Address(RVA = "0x689530", Offset = "0x688130", VA = "0x180689530", Slot = "16")]
		public override void UpdateRangeByOptions(Range.Options options)
		{
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F256")]
		[Address(RVA = "0x689460", Offset = "0x688060", VA = "0x180689460")]
		public void UpdateRangeByOptions()
		{
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F257")]
		[Address(RVA = "0x6893E0", Offset = "0x687FE0", VA = "0x1806893E0", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F258")]
		[Address(RVA = "0x689110", Offset = "0x687D10", VA = "0x180689110")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F259")]
		[Address(RVA = "0x689E70", Offset = "0x688A70", VA = "0x180689E70")]
		private void _SearchAndMark(int i, int j, int depth)
		{
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F25A")]
		[Address(RVA = "0x6898C0", Offset = "0x6884C0", VA = "0x1806898C0")]
		private void _RebuildBoxCollider()
		{
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F25B")]
		[Address(RVA = "0x68A250", Offset = "0x688E50", VA = "0x18068A250")]
		private static void _SetBoxCollider(BoxCollider2D boxCollider, Vector2 offset, Vector2 size)
		{
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F25C")]
		[Address(RVA = "0x68A320", Offset = "0x688F20", VA = "0x18068A320")]
		public ContinuousRangeWithConditions()
		{
		}

		// Token: 0x0600F25D RID: 62045 RVA: 0x000593D0 File Offset: 0x000575D0
		[Token(Token = "0x600F25D")]
		[Address(RVA = "0x6886C0", Offset = "0x6872C0", VA = "0x1806886C0")]
		private bool <>xLuaBaseProxy_get_extendable()
		{
			return default(bool);
		}

		// Token: 0x0600F25E RID: 62046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F25E")]
		[Address(RVA = "0x681A60", Offset = "0x680660", VA = "0x180681A60")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F25F RID: 62047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F25F")]
		[Address(RVA = "0x6893A0", Offset = "0x687FA0", VA = "0x1806893A0")]
		private void <>xLuaBaseProxy_UpdateRangeByOptions(Range.Options P0)
		{
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F260")]
		[Address(RVA = "0x687210", Offset = "0x685E10", VA = "0x180687210")]
		private void <>xLuaBaseProxy_UpdateExtend(FP P0, bool P1)
		{
		}

		// Token: 0x04010C32 RID: 68658
		[Token(Token = "0x4010C32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _depth;

		// Token: 0x04010C33 RID: 68659
		[Token(Token = "0x4010C33")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TileSelector.Options _options;

		// Token: 0x04010C34 RID: 68660
		[Token(Token = "0x4010C34")]
		[FieldOffset(Offset = "0xA0")]
		private ObjectPtr<Character> m_owner;

		// Token: 0x04010C35 RID: 68661
		[Token(Token = "0x4010C35")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<ValueTuple<int, int>> m_searchedPosList;

		// Token: 0x04010C36 RID: 68662
		[Token(Token = "0x4010C36")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_offset;

		// Token: 0x04010C37 RID: 68663
		[Token(Token = "0x4010C37")]
		[FieldOffset(Offset = "0xC0")]
		private readonly HashSet<GridPosition> m_grids;

		// Token: 0x04010C38 RID: 68664
		[Token(Token = "0x4010C38")]
		[FieldOffset(Offset = "0xC8")]
		private RangeData m_rangeData;

		// Token: 0x04010C39 RID: 68665
		[Token(Token = "0x4010C39")]
		[FieldOffset(Offset = "0xD0")]
		private readonly HashSet<GridPosition> m_cachedGridSet;

		// Token: 0x04010C3A RID: 68666
		[Token(Token = "0x4010C3A")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<Collider2D> m_cachedColliders;

		// Token: 0x04010C3B RID: 68667
		[Token(Token = "0x4010C3B")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Range.Options m_options;

		// Token: 0x04010C3C RID: 68668
		[Token(Token = "0x4010C3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04010C3D RID: 68669
		[Token(Token = "0x4010C3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x04010C3E RID: 68670
		[Token(Token = "0x4010C3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C3F RID: 68671
		[Token(Token = "0x4010C3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C40 RID: 68672
		[Token(Token = "0x4010C40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateRangeByOptions;

		// Token: 0x04010C41 RID: 68673
		[Token(Token = "0x4010C41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_UpdateRangeByOptions;

		// Token: 0x04010C42 RID: 68674
		[Token(Token = "0x4010C42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C43 RID: 68675
		[Token(Token = "0x4010C43")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04010C44 RID: 68676
		[Token(Token = "0x4010C44")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SearchAndMark;

		// Token: 0x04010C45 RID: 68677
		[Token(Token = "0x4010C45")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RebuildBoxCollider;

		// Token: 0x04010C46 RID: 68678
		[Token(Token = "0x4010C46")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetBoxCollider;

		// Token: 0x04010C47 RID: 68679
		[Token(Token = "0x4010C47")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
