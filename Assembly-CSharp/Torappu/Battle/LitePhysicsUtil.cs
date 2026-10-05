using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020024D2 RID: 9426
	[Token(Token = "0x20024D2")]
	public static class LitePhysicsUtil
	{
		// Token: 0x0600F2B7 RID: 62135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2B7")]
		[Address(RVA = "0x6A9BF0", Offset = "0x6A87F0", VA = "0x1806A9BF0")]
		public static void ClearStaticVariables()
		{
		}

		// Token: 0x0600F2B8 RID: 62136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B8")]
		[Address(RVA = "0x6AA560", Offset = "0x6A9160", VA = "0x1806AA560")]
		public static ReusableList<Entity> FindTargetsInBox_DISPOSE(string rangeId, GridPosition centerPos, SharedConsts.Direction direction, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2B9 RID: 62137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B9")]
		[Address(RVA = "0x6AA9A0", Offset = "0x6A95A0", VA = "0x1806AA9A0")]
		public static ReusableList<Entity> FindTargetsInCircle_DISPOSE(float radius, Vector2 mapPosition, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2BA RID: 62138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2BA")]
		[Address(RVA = "0x6AA3C0", Offset = "0x6A8FC0", VA = "0x1806AA3C0")]
		public static ReusableList<Entity> FindTargetsFromAllUnits_DISPOSE(TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2BB RID: 62139 RVA: 0x00059628 File Offset: 0x00057828
		[Token(Token = "0x600F2BB")]
		[Address(RVA = "0x6A9740", Offset = "0x6A8340", VA = "0x1806A9740")]
		public static bool CheckOverlapInBox(string rangeId, Entity target, Entity source, SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600F2BC RID: 62140 RVA: 0x00059640 File Offset: 0x00057840
		[Token(Token = "0x600F2BC")]
		[Address(RVA = "0x6A9490", Offset = "0x6A8090", VA = "0x1806A9490")]
		public static bool CheckOverlapInBox(string rangeId, Entity target, GridPosition gridPosition, SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600F2BD RID: 62141 RVA: 0x00059658 File Offset: 0x00057858
		[Token(Token = "0x600F2BD")]
		[Address(RVA = "0x6ABC70", Offset = "0x6AA870", VA = "0x1806ABC70")]
		public static Vector3 Rotate(FP angle, Vector3 direction, Vector3 up)
		{
			return default(Vector3);
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2BE")]
		[Address(RVA = "0x6AAE20", Offset = "0x6A9A20", VA = "0x1806AAE20")]
		public static List<Tile> FindTilesInBox(string rangeId, GridPosition centerPos, SharedConsts.Direction direction, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2BF RID: 62143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2BF")]
		[Address(RVA = "0x6AB4A0", Offset = "0x6AA0A0", VA = "0x1806AB4A0")]
		public static List<Tile> FindTilesInCircle(float rangeRadius, GridPosition centerPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2C0 RID: 62144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2C0")]
		[Address(RVA = "0x6A9F60", Offset = "0x6A8B60", VA = "0x1806A9F60")]
		public static List<Tile> FindOverlappedTilesInCircle(float rangeRadius, Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2C1 RID: 62145 RVA: 0x00059670 File Offset: 0x00057870
		[Token(Token = "0x600F2C1")]
		[Address(RVA = "0x6AC240", Offset = "0x6AAE40", VA = "0x1806AC240")]
		private static bool _IsMapPosIntersectCircle(int x, int y, Vector2 center, float radius)
		{
			return default(bool);
		}

		// Token: 0x0600F2C2 RID: 62146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2C2")]
		[Address(RVA = "0x6AB1B0", Offset = "0x6A9DB0", VA = "0x1806AB1B0")]
		public static List<Tile> FindTilesInCircleByMapPos(float rangeRadius, Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2C3 RID: 62147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2C3")]
		[Address(RVA = "0x6AABD0", Offset = "0x6A97D0", VA = "0x1806AABD0")]
		public static List<Tile> FindTilesBetweenColumns(int begin, int end, bool isExclude)
		{
			return null;
		}

		// Token: 0x0600F2C4 RID: 62148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2C4")]
		[Address(RVA = "0x6AB7E0", Offset = "0x6AA3E0", VA = "0x1806AB7E0")]
		public static List<Tile> FindTilesInGlobalRange([Optional] Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2C5 RID: 62149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2C5")]
		[Address(RVA = "0x6ABA20", Offset = "0x6AA620", VA = "0x1806ABA20")]
		public static List<Tile> FindTilesInLine(GridPosition centerPos, SharedConsts.Direction direction)
		{
			return null;
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x00059688 File Offset: 0x00057888
		[Token(Token = "0x600F2C6")]
		[Address(RVA = "0x6ABD50", Offset = "0x6AA950", VA = "0x1806ABD50")]
		public static bool TryGetFathestGridPosInBox(string rangeId, GridPosition centerPos, SharedConsts.Direction direction, out GridPosition result)
		{
			return default(bool);
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x000596A0 File Offset: 0x000578A0
		[Token(Token = "0x600F2C7")]
		[Address(RVA = "0x6AC030", Offset = "0x6AAC30", VA = "0x1806AC030")]
		private static bool _CheckContainsPosition(Entity candidate, HashSet<GridPosition> curSet)
		{
			return default(bool);
		}

		// Token: 0x0600F2C8 RID: 62152 RVA: 0x000596B8 File Offset: 0x000578B8
		[Token(Token = "0x600F2C8")]
		[Address(RVA = "0x6A9A20", Offset = "0x6A8620", VA = "0x1806A9A20")]
		public static bool CheckPositionInArcUnsigned(Vector2 targetPos, Vector2 center, Vector2 forward, FP maxDegree)
		{
			return default(bool);
		}

		// Token: 0x0600F2C9 RID: 62153 RVA: 0x000596D0 File Offset: 0x000578D0
		[Token(Token = "0x600F2C9")]
		[Address(RVA = "0x6A9AF0", Offset = "0x6A86F0", VA = "0x1806A9AF0")]
		public static bool CheckPositionInArc(Vector2 targetPos, Vector2 center, Vector2 right, Vector2 degreeRange)
		{
			return default(bool);
		}

		// Token: 0x0600F2CA RID: 62154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2CA")]
		[Address(RVA = "0x6A9CB0", Offset = "0x6A88B0", VA = "0x1806A9CB0")]
		public static Tile FindNearestPassableTile(Vector3 worldPos, MotionMask passableMask, bool trySummonOutsideWhenInObstacle)
		{
			return null;
		}

		// Token: 0x04010CA6 RID: 68774
		[Token(Token = "0x4010CA6")]
		public const float MIN_DEGREE = 0f;

		// Token: 0x04010CA7 RID: 68775
		[Token(Token = "0x4010CA7")]
		public const float MAX_DEGREE = 360f;

		// Token: 0x04010CA8 RID: 68776
		[Token(Token = "0x4010CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<GridPosition> s_sharedSet;

		// Token: 0x04010CA9 RID: 68777
		[Token(Token = "0x4010CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Tile> s_sharedTiles;
	}
}
