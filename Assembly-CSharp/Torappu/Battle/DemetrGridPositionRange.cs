using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CB RID: 9419
	[Token(Token = "0x20024CB")]
	public class DemetrGridPositionRange : GridPositionRange
	{
		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600F270 RID: 62064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F8D")]
		private Character owner
		{
			[Token(Token = "0x600F270")]
			[Address(RVA = "0x6A5DD0", Offset = "0x6A49D0", VA = "0x1806A5DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x0600F271 RID: 62065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F8E")]
		private Character token
		{
			[Token(Token = "0x600F271")]
			[Address(RVA = "0x6A5FB0", Offset = "0x6A4BB0", VA = "0x1806A5FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x0600F272 RID: 62066 RVA: 0x00059478 File Offset: 0x00057678
		[Token(Token = "0x17001F8F")]
		private GridPosition center
		{
			[Token(Token = "0x600F272")]
			[Address(RVA = "0x6A5B60", Offset = "0x6A4760", VA = "0x1806A5B60")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600F273 RID: 62067 RVA: 0x00059490 File Offset: 0x00057690
		// (set) Token: 0x0600F274 RID: 62068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F90")]
		public override bool extendable
		{
			[Token(Token = "0x600F273")]
			[Address(RVA = "0x6A5D70", Offset = "0x6A4970", VA = "0x1806A5D70", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F274")]
			[Address(RVA = "0x6A6240", Offset = "0x6A4E40", VA = "0x1806A6240", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600F275 RID: 62069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F275")]
		[Address(RVA = "0x6A4BD0", Offset = "0x6A37D0", VA = "0x1806A4BD0", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F276")]
		[Address(RVA = "0x6A45A0", Offset = "0x6A31A0", VA = "0x1806A45A0", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F277 RID: 62071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F277")]
		[Address(RVA = "0x6A49D0", Offset = "0x6A35D0", VA = "0x1806A49D0", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F278 RID: 62072 RVA: 0x000594A8 File Offset: 0x000576A8
		[Token(Token = "0x600F278")]
		[Address(RVA = "0x6A44A0", Offset = "0x6A30A0", VA = "0x1806A44A0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F279 RID: 62073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F279")]
		[Address(RVA = "0x6A4F10", Offset = "0x6A3B10", VA = "0x1806A4F10", Slot = "16")]
		public override void UpdateRangeByOptions(Range.Options options)
		{
		}

		// Token: 0x0600F27A RID: 62074 RVA: 0x000594C0 File Offset: 0x000576C0
		[Token(Token = "0x600F27A")]
		[Address(RVA = "0x6A54E0", Offset = "0x6A40E0", VA = "0x1806A54E0")]
		private bool _TileFitOptions(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x000594D8 File Offset: 0x000576D8
		[Token(Token = "0x600F27B")]
		[Address(RVA = "0x6A5590", Offset = "0x6A4190", VA = "0x1806A5590")]
		private bool _TileFitReachability(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F27C RID: 62076 RVA: 0x000594F0 File Offset: 0x000576F0
		[Token(Token = "0x600F27C")]
		[Address(RVA = "0x6A56A0", Offset = "0x6A42A0", VA = "0x1806A56A0")]
		private bool _TileFitTileEmptyExceptOwnerAndToken(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F27D")]
		[Address(RVA = "0x6A5200", Offset = "0x6A3E00", VA = "0x1806A5200")]
		private void _InitAllTilesInRange()
		{
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F27E")]
		[Address(RVA = "0x6A5850", Offset = "0x6A4450", VA = "0x1806A5850")]
		private void _UpdateRangeByOptions()
		{
		}

		// Token: 0x0600F27F RID: 62079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F27F")]
		[Address(RVA = "0x6A5920", Offset = "0x6A4520", VA = "0x1806A5920")]
		public DemetrGridPositionRange()
		{
		}

		// Token: 0x0600F280 RID: 62080 RVA: 0x00059508 File Offset: 0x00057708
		[Token(Token = "0x600F280")]
		[Address(RVA = "0x6A4E50", Offset = "0x6A3A50", VA = "0x1806A4E50")]
		private bool <>xLuaBaseProxy_get_extendable()
		{
			return default(bool);
		}

		// Token: 0x0600F281 RID: 62081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F281")]
		[Address(RVA = "0x6A4EB0", Offset = "0x6A3AB0", VA = "0x1806A4EB0")]
		private void <>xLuaBaseProxy_set_extendable(bool P0)
		{
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F282")]
		[Address(RVA = "0x6A4D50", Offset = "0x6A3950", VA = "0x1806A4D50")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F283 RID: 62083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F283")]
		[Address(RVA = "0x6A4CE0", Offset = "0x6A38E0", VA = "0x1806A4CE0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0, TargetOptions P1, Func<Entity, bool> P2)
		{
			return null;
		}

		// Token: 0x0600F284 RID: 62084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F284")]
		[Address(RVA = "0x6A4D40", Offset = "0x6A3940", VA = "0x1806A4D40")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0, Func<Tile, bool> P1)
		{
			return null;
		}

		// Token: 0x0600F285 RID: 62085 RVA: 0x00059520 File Offset: 0x00057720
		[Token(Token = "0x600F285")]
		[Address(RVA = "0x6A4CD0", Offset = "0x6A38D0", VA = "0x1806A4CD0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x0600F286 RID: 62086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F286")]
		[Address(RVA = "0x6A4DD0", Offset = "0x6A39D0", VA = "0x1806A4DD0")]
		private void <>xLuaBaseProxy_UpdateRangeByOptions(Range.Options P0)
		{
		}

		// Token: 0x04010C5B RID: 68699
		[Token(Token = "0x4010C5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _checkOptions;

		// Token: 0x04010C5C RID: 68700
		[Token(Token = "0x4010C5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TileSelector.Options _options;

		// Token: 0x04010C5D RID: 68701
		[Token(Token = "0x4010C5D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _checkReachability;

		// Token: 0x04010C5E RID: 68702
		[Token(Token = "0x4010C5E")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _checkTileEmptyExceptOwnerAndToken;

		// Token: 0x04010C5F RID: 68703
		[Token(Token = "0x4010C5F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _locatedColBBKey;

		// Token: 0x04010C60 RID: 68704
		[Token(Token = "0x4010C60")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _locatedRowBBKey;

		// Token: 0x04010C61 RID: 68705
		[Token(Token = "0x4010C61")]
		[FieldOffset(Offset = "0x90")]
		private ObjectPtr<Character> m_owner;

		// Token: 0x04010C62 RID: 68706
		[Token(Token = "0x4010C62")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Range.Options m_options;

		// Token: 0x04010C63 RID: 68707
		[Token(Token = "0x4010C63")]
		[FieldOffset(Offset = "0xC8")]
		private List<Tile> m_allTilesInRange;

		// Token: 0x04010C64 RID: 68708
		[Token(Token = "0x4010C64")]
		[FieldOffset(Offset = "0xD0")]
		private List<Tile> m_fitTilesInRange;

		// Token: 0x04010C65 RID: 68709
		[Token(Token = "0x4010C65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04010C66 RID: 68710
		[Token(Token = "0x4010C66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_token;

		// Token: 0x04010C67 RID: 68711
		[Token(Token = "0x4010C67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_center;

		// Token: 0x04010C68 RID: 68712
		[Token(Token = "0x4010C68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C69 RID: 68713
		[Token(Token = "0x4010C69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C6A RID: 68714
		[Token(Token = "0x4010C6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C6B RID: 68715
		[Token(Token = "0x4010C6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C6C RID: 68716
		[Token(Token = "0x4010C6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C6D RID: 68717
		[Token(Token = "0x4010C6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C6E RID: 68718
		[Token(Token = "0x4010C6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateRangeByOptions;

		// Token: 0x04010C6F RID: 68719
		[Token(Token = "0x4010C6F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TileFitOptions;

		// Token: 0x04010C70 RID: 68720
		[Token(Token = "0x4010C70")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TileFitReachability;

		// Token: 0x04010C71 RID: 68721
		[Token(Token = "0x4010C71")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TileFitTileEmptyExceptOwnerAndToken;

		// Token: 0x04010C72 RID: 68722
		[Token(Token = "0x4010C72")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitAllTilesInRange;

		// Token: 0x04010C73 RID: 68723
		[Token(Token = "0x4010C73")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateRangeByOptions;

		// Token: 0x04010C74 RID: 68724
		[Token(Token = "0x4010C74")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
