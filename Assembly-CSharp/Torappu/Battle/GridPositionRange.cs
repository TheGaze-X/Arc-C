using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CF RID: 9423
	[Token(Token = "0x20024CF")]
	public class GridPositionRange : Range
	{
		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600F2A1 RID: 62113 RVA: 0x000595C8 File Offset: 0x000577C8
		// (set) Token: 0x0600F2A2 RID: 62114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F95")]
		public override bool extendable
		{
			[Token(Token = "0x600F2A1")]
			[Address(RVA = "0x6A4E50", Offset = "0x6A3A50", VA = "0x1806A4E50", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F2A2")]
			[Address(RVA = "0x6A4EB0", Offset = "0x6A3AB0", VA = "0x1806A4EB0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600F2A3 RID: 62115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F96")]
		protected List<GridPosition> gridPosition
		{
			[Token(Token = "0x600F2A3")]
			[Address(RVA = "0x6A8270", Offset = "0x6A6E70", VA = "0x1806A8270")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F2A4 RID: 62116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2A4")]
		[Address(RVA = "0x6A7940", Offset = "0x6A6540", VA = "0x1806A7940", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2A5 RID: 62117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2A5")]
		[Address(RVA = "0x6A7E50", Offset = "0x6A6A50", VA = "0x1806A7E50", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2A6 RID: 62118 RVA: 0x000595E0 File Offset: 0x000577E0
		[Token(Token = "0x600F2A6")]
		[Address(RVA = "0x6A75D0", Offset = "0x6A61D0", VA = "0x1806A75D0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F2A7 RID: 62119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2A7")]
		[Address(RVA = "0x6A4D50", Offset = "0x6A3950", VA = "0x1806A4D50", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F2A8 RID: 62120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2A8")]
		[Address(RVA = "0x6A8140", Offset = "0x6A6D40", VA = "0x1806A8140", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F2A9 RID: 62121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2A9")]
		[Address(RVA = "0x6A81C0", Offset = "0x6A6DC0", VA = "0x1806A81C0")]
		public GridPositionRange()
		{
		}

		// Token: 0x04010C90 RID: 68752
		[Token(Token = "0x4010C90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GridPosition> _gridPositions;

		// Token: 0x04010C91 RID: 68753
		[Token(Token = "0x4010C91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C92 RID: 68754
		[Token(Token = "0x4010C92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C93 RID: 68755
		[Token(Token = "0x4010C93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gridPosition;

		// Token: 0x04010C94 RID: 68756
		[Token(Token = "0x4010C94")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C95 RID: 68757
		[Token(Token = "0x4010C95")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C96 RID: 68758
		[Token(Token = "0x4010C96")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C97 RID: 68759
		[Token(Token = "0x4010C97")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C98 RID: 68760
		[Token(Token = "0x4010C98")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C99 RID: 68761
		[Token(Token = "0x4010C99")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
