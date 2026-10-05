using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002561 RID: 9569
	[Token(Token = "0x2002561")]
	public class EntityOnRouteTrigger : SelectorTrigger
	{
		// Token: 0x0600F6F5 RID: 63221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6F5")]
		[Address(RVA = "0x709460", Offset = "0x708060", VA = "0x180709460")]
		private void GetMyCursorIfNot()
		{
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x0005C1C0 File Offset: 0x0005A3C0
		[Token(Token = "0x600F6F6")]
		[Address(RVA = "0x7096F0", Offset = "0x7082F0", VA = "0x1807096F0", Slot = "13")]
		public override bool Search(bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
		[Token(Token = "0x600F6F7")]
		[Address(RVA = "0x70A3F0", Offset = "0x708FF0", VA = "0x18070A3F0")]
		private GridPosition _GetNextGridPosExactly(GridPosition from, GridPosition to)
		{
			return default(GridPosition);
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6F8")]
		[Address(RVA = "0x70B1C0", Offset = "0x709DC0", VA = "0x18070B1C0")]
		private void _UpdateTilesOnRoute(GridPosition currGridPos, GridPosition targetGridPos)
		{
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6F9")]
		[Address(RVA = "0x70A6B0", Offset = "0x7092B0", VA = "0x18070A6B0")]
		private void _GetTilesOnSegmentToNextGrid(GridPosition a, GridPosition b, MotionMode motion, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6FA")]
		[Address(RVA = "0x709D80", Offset = "0x708980", VA = "0x180709D80")]
		private void _AddNearbyTiles(int x, int y, Route.Node[,] nextMap, int yDir, bool swapXY)
		{
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6FB")]
		[Address(RVA = "0x70A060", Offset = "0x708C60", VA = "0x18070A060")]
		private void _AddTilesOnRouteIfNot(Tile tile, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600F6FC RID: 63228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6FC")]
		[Address(RVA = "0x70A1A0", Offset = "0x708DA0", VA = "0x18070A1A0")]
		private void _FilterNearbyRouteTiles(Vector2 currMapPos, Vector2 targetMapPos)
		{
		}

		// Token: 0x0600F6FD RID: 63229 RVA: 0x0005C1F0 File Offset: 0x0005A3F0
		[Token(Token = "0x600F6FD")]
		[Address(RVA = "0x70AA60", Offset = "0x709660", VA = "0x18070AA60")]
		private bool _IsSegmentIntersectWithTile(Vector3 currMapPos, Vector3 targetMapPos, Vector3 tilePosition)
		{
			return default(bool);
		}

		// Token: 0x0600F6FE RID: 63230 RVA: 0x0005C208 File Offset: 0x0005A408
		[Token(Token = "0x600F6FE")]
		[Address(RVA = "0x70AFA0", Offset = "0x709BA0", VA = "0x18070AFA0")]
		private bool _SameSide(Vector3 line, Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x0005C220 File Offset: 0x0005A420
		[Token(Token = "0x600F6FF")]
		[Address(RVA = "0x709CA0", Offset = "0x7088A0", VA = "0x180709CA0", Slot = "16")]
		protected override bool Validator(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F700 RID: 63232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F700")]
		[Address(RVA = "0x70B330", Offset = "0x709F30", VA = "0x18070B330")]
		public EntityOnRouteTrigger()
		{
		}

		// Token: 0x0600F701 RID: 63233 RVA: 0x0005C238 File Offset: 0x0005A438
		[Token(Token = "0x600F701")]
		[Address(RVA = "0x709C90", Offset = "0x708890", VA = "0x180709C90")]
		private bool <>xLuaBaseProxy_Validator(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011250 RID: 70224
		[Token(Token = "0x4011250")]
		[FieldOffset(Offset = "0x50")]
		private DirectionCursor m_cursor;

		// Token: 0x04011251 RID: 70225
		[Token(Token = "0x4011251")]
		[FieldOffset(Offset = "0x58")]
		private Enemy m_owner;

		// Token: 0x04011252 RID: 70226
		[Token(Token = "0x4011252")]
		[FieldOffset(Offset = "0x60")]
		private Tile m_currTargetTile;

		// Token: 0x04011253 RID: 70227
		[Token(Token = "0x4011253")]
		[FieldOffset(Offset = "0x68")]
		private GridPosition m_currTargetGridPos;

		// Token: 0x04011254 RID: 70228
		[Token(Token = "0x4011254")]
		[FieldOffset(Offset = "0x70")]
		private ListSet<Tile> m_tilesOnRoute;

		// Token: 0x04011255 RID: 70229
		[Token(Token = "0x4011255")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMyCursorIfNot;

		// Token: 0x04011256 RID: 70230
		[Token(Token = "0x4011256")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011257 RID: 70231
		[Token(Token = "0x4011257")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetNextGridPosExactly;

		// Token: 0x04011258 RID: 70232
		[Token(Token = "0x4011258")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTilesOnRoute;

		// Token: 0x04011259 RID: 70233
		[Token(Token = "0x4011259")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTilesOnSegmentToNextGrid;

		// Token: 0x0401125A RID: 70234
		[Token(Token = "0x401125A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddNearbyTiles;

		// Token: 0x0401125B RID: 70235
		[Token(Token = "0x401125B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddTilesOnRouteIfNot;

		// Token: 0x0401125C RID: 70236
		[Token(Token = "0x401125C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FilterNearbyRouteTiles;

		// Token: 0x0401125D RID: 70237
		[Token(Token = "0x401125D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__IsSegmentIntersectWithTile;

		// Token: 0x0401125E RID: 70238
		[Token(Token = "0x401125E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SameSide;

		// Token: 0x0401125F RID: 70239
		[Token(Token = "0x401125F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Validator;

		// Token: 0x04011260 RID: 70240
		[Token(Token = "0x4011260")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
