using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200265C RID: 9820
	[Token(Token = "0x200265C")]
	public static class MapUtil
	{
		// Token: 0x060100D6 RID: 65750 RVA: 0x00061F50 File Offset: 0x00060150
		[Token(Token = "0x60100D6")]
		[Address(RVA = "0x7CA390", Offset = "0x7C8F90", VA = "0x1807CA390")]
		public static SharedConsts.Direction GetFourWayDirection(GridPosition dir)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x060100D7 RID: 65751 RVA: 0x00061F68 File Offset: 0x00060168
		[Token(Token = "0x60100D7")]
		[Address(RVA = "0x7CB080", Offset = "0x7C9C80", VA = "0x1807CB080")]
		public static SharedConsts.Direction InverseDirection(SharedConsts.Direction direction)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x060100D8 RID: 65752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D8")]
		[Address(RVA = "0x7CA4D0", Offset = "0x7C90D0", VA = "0x1807CA4D0")]
		public static List<GridPosition> GetGridPositionsAlongTheDirection(GridPosition pos, SharedConsts.Direction dir, bool includePos = false)
		{
			return null;
		}

		// Token: 0x060100D9 RID: 65753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100D9")]
		[Address(RVA = "0x7C9BE0", Offset = "0x7C87E0", VA = "0x1807C9BE0")]
		public static void FaceTo2d(this Transform transform, Vector2 direction)
		{
		}

		// Token: 0x060100DA RID: 65754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100DA")]
		[Address(RVA = "0x7C9DE0", Offset = "0x7C89E0", VA = "0x1807C9DE0")]
		public static void FaceTo3dUpwardMajor(this Transform transform, Vector3 yUpward, Vector3 zForward)
		{
		}

		// Token: 0x060100DB RID: 65755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100DB")]
		[Address(RVA = "0x7C9C70", Offset = "0x7C8870", VA = "0x1807C9C70")]
		public static void FaceTo3dForwardMajor(this Transform transform, Vector3 yUpward, Vector3 zForward)
		{
		}

		// Token: 0x060100DC RID: 65756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100DC")]
		[Address(RVA = "0x7C9F40", Offset = "0x7C8B40", VA = "0x1807C9F40")]
		public static void FaceToWithCameraForward(this Transform transform, Vector3 direction, bool exactMatchForward)
		{
		}

		// Token: 0x060100DD RID: 65757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100DD")]
		[Address(RVA = "0x7CA280", Offset = "0x7C8E80", VA = "0x1807CA280")]
		public static void Flip(this Transform transform)
		{
		}

		// Token: 0x060100DE RID: 65758 RVA: 0x00061F80 File Offset: 0x00060180
		[Token(Token = "0x60100DE")]
		[Address(RVA = "0x7CB7C0", Offset = "0x7CA3C0", VA = "0x1807CB7C0")]
		public static SharedConsts.Direction ParseDirection(Vector2 direction, float addonToLOrR = 0f)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x060100DF RID: 65759 RVA: 0x00061F98 File Offset: 0x00060198
		[Token(Token = "0x60100DF")]
		[Address(RVA = "0x7CB390", Offset = "0x7C9F90", VA = "0x1807CB390")]
		public static SharedConsts.EightWaysDirection ParseDirectionByEightWays(Vector2 direction)
		{
			return SharedConsts.EightWaysDirection.UP;
		}

		// Token: 0x060100E0 RID: 65760 RVA: 0x00061FB0 File Offset: 0x000601B0
		[Token(Token = "0x60100E0")]
		[Address(RVA = "0x7CB650", Offset = "0x7CA250", VA = "0x1807CB650")]
		public static SharedConsts.Direction ParseDirectionStrict(Vector2 direction)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x060100E1 RID: 65761 RVA: 0x00061FC8 File Offset: 0x000601C8
		[Token(Token = "0x60100E1")]
		[Address(RVA = "0x7CB2D0", Offset = "0x7C9ED0", VA = "0x1807CB2D0")]
		public static Vector2 NormalizeDirectionToFourWays(Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x060100E2 RID: 65762 RVA: 0x00061FE0 File Offset: 0x000601E0
		[Token(Token = "0x60100E2")]
		[Address(RVA = "0x7CA370", Offset = "0x7C8F70", VA = "0x1807CA370")]
		public static SharedConsts.Direction GetDeltaDirection(SharedConsts.Direction from, SharedConsts.Direction to)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x060100E3 RID: 65763 RVA: 0x00061FF8 File Offset: 0x000601F8
		[Token(Token = "0x60100E3")]
		[Address(RVA = "0x7CA2E0", Offset = "0x7C8EE0", VA = "0x1807CA2E0")]
		public static float GetDeltaAngle(SharedConsts.Direction from, float toAngle)
		{
			return 0f;
		}

		// Token: 0x060100E4 RID: 65764 RVA: 0x00062010 File Offset: 0x00060210
		[Token(Token = "0x60100E4")]
		[Address(RVA = "0x7CB180", Offset = "0x7C9D80", VA = "0x1807CB180")]
		public static bool IsAlmostZero(Vector3 pos, float tolerance)
		{
			return default(bool);
		}

		// Token: 0x060100E5 RID: 65765 RVA: 0x00062028 File Offset: 0x00060228
		[Token(Token = "0x60100E5")]
		[Address(RVA = "0x7CC5D0", Offset = "0x7CB1D0", VA = "0x1807CC5D0")]
		public static Vector2 WorldToMapPos(Vector3 worldPos)
		{
			return default(Vector2);
		}

		// Token: 0x060100E6 RID: 65766 RVA: 0x00062040 File Offset: 0x00060240
		[Token(Token = "0x60100E6")]
		[Address(RVA = "0x7CC540", Offset = "0x7CB140", VA = "0x1807CC540")]
		public static Vector3 WorldToMapPosV3(Vector3 worldPos)
		{
			return default(Vector3);
		}

		// Token: 0x060100E7 RID: 65767 RVA: 0x00062058 File Offset: 0x00060258
		[Token(Token = "0x60100E7")]
		[Address(RVA = "0x7CB250", Offset = "0x7C9E50", VA = "0x1807CB250")]
		public static Vector3 MapToWorldPos(Vector2 mapPos)
		{
			return default(Vector3);
		}

		// Token: 0x060100E8 RID: 65768 RVA: 0x00062070 File Offset: 0x00060270
		[Token(Token = "0x60100E8")]
		[Address(RVA = "0x7CB1C0", Offset = "0x7C9DC0", VA = "0x1807CB1C0")]
		public static Vector3 MapToWorldPosV3(Vector3 mapPos)
		{
			return default(Vector3);
		}

		// Token: 0x060100E9 RID: 65769 RVA: 0x00062088 File Offset: 0x00060288
		[Token(Token = "0x60100E9")]
		[Address(RVA = "0x7C9A30", Offset = "0x7C8630", VA = "0x1807C9A30")]
		public static bool CheckClockwise(SharedConsts.Direction lhs, SharedConsts.Direction rhs)
		{
			return default(bool);
		}

		// Token: 0x060100EA RID: 65770 RVA: 0x000620A0 File Offset: 0x000602A0
		[Token(Token = "0x60100EA")]
		[Address(RVA = "0x7C9B30", Offset = "0x7C8730", VA = "0x1807C9B30")]
		public static float CrossV2(Vector2 lhs, Vector2 rhs)
		{
			return 0f;
		}

		// Token: 0x060100EB RID: 65771 RVA: 0x000620B8 File Offset: 0x000602B8
		[Token(Token = "0x60100EB")]
		[Address(RVA = "0x7CAF70", Offset = "0x7C9B70", VA = "0x1807CAF70")]
		public static bool InArea(Vector2 p, Vector2 pointA, Vector2 pointB)
		{
			return default(bool);
		}

		// Token: 0x060100EC RID: 65772 RVA: 0x000620D0 File Offset: 0x000602D0
		[Token(Token = "0x60100EC")]
		[Address(RVA = "0x7CAFE0", Offset = "0x7C9BE0", VA = "0x1807CAFE0")]
		public static bool InBounds(Vector2 p, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x060100ED RID: 65773 RVA: 0x000620E8 File Offset: 0x000602E8
		[Token(Token = "0x60100ED")]
		[Address(RVA = "0x7CA9F0", Offset = "0x7C95F0", VA = "0x1807CA9F0")]
		public static Vector2 GetPerpendiculaV2(Vector2 p)
		{
			return default(Vector2);
		}

		// Token: 0x060100EE RID: 65774 RVA: 0x00062100 File Offset: 0x00060300
		[Token(Token = "0x60100EE")]
		[Address(RVA = "0x7C9B60", Offset = "0x7C8760", VA = "0x1807C9B60")]
		public static Vector2 ExtendToMinLength(Vector2 p, float minLength)
		{
			return default(Vector2);
		}

		// Token: 0x060100EF RID: 65775 RVA: 0x00062118 File Offset: 0x00060318
		[Token(Token = "0x60100EF")]
		[Address(RVA = "0x7C99C0", Offset = "0x7C85C0", VA = "0x1807C99C0")]
		public static bool CheckAlmostVertical(Vector2 normalizedDir)
		{
			return default(bool);
		}

		// Token: 0x060100F0 RID: 65776 RVA: 0x00062130 File Offset: 0x00060330
		[Token(Token = "0x60100F0")]
		[Address(RVA = "0x7CC2A0", Offset = "0x7CAEA0", VA = "0x1807CC2A0")]
		public static bool SimilarDirection(Vector2 normalizedA, Vector2 normalizedB)
		{
			return default(bool);
		}

		// Token: 0x060100F1 RID: 65777 RVA: 0x00062148 File Offset: 0x00060348
		[Token(Token = "0x60100F1")]
		[Address(RVA = "0x7CAE50", Offset = "0x7C9A50", VA = "0x1807CAE50")]
		public static bool GetTileHightByMapPosition(Vector3 mapPos, out float result)
		{
			return default(bool);
		}

		// Token: 0x060100F2 RID: 65778 RVA: 0x00062160 File Offset: 0x00060360
		[Token(Token = "0x60100F2")]
		[Address(RVA = "0x7CC2E0", Offset = "0x7CAEE0", VA = "0x1807CC2E0")]
		public static bool TryGetFarthestTilePositionAlongTheDirection(GridPosition startGridPos, SharedConsts.Direction direction, out GridPosition endGridPos, List<string> tileKeyList)
		{
			return default(bool);
		}

		// Token: 0x060100F3 RID: 65779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100F3")]
		[Address(RVA = "0x7CACD0", Offset = "0x7C98D0", VA = "0x1807CACD0")]
		public static List<Tile> GetSurroundTile(GridPosition anchorPos)
		{
			return null;
		}

		// Token: 0x060100F4 RID: 65780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100F4")]
		[Address(RVA = "0x7CB9C0", Offset = "0x7CA5C0", VA = "0x1807CB9C0")]
		public static Tile SearchNearestAccessibleTile(Enemy enemy, [Optional] Func<Tile, bool> conditionChecker)
		{
			return null;
		}

		// Token: 0x060100F5 RID: 65781 RVA: 0x00062178 File Offset: 0x00060378
		[Token(Token = "0x60100F5")]
		[Address(RVA = "0x7CC640", Offset = "0x7CB240", VA = "0x1807CC640")]
		private static bool _IsTilePassable(Tile tile, Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x060100F6 RID: 65782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100F6")]
		[Address(RVA = "0x7CAA20", Offset = "0x7C9620", VA = "0x1807CAA20")]
		public static List<Tile> GetSurroundEightTiles(GridPosition anchorPos)
		{
			return null;
		}

		// Token: 0x04011DB9 RID: 73145
		[Token(Token = "0x4011DB9")]
		private const float ALMOST_VERTICAL_THRESHOLD = 0.992f;

		// Token: 0x04011DBA RID: 73146
		[Token(Token = "0x4011DBA")]
		private const float SIMILAR_THRESHOLD = 0.9f;

		// Token: 0x04011DBB RID: 73147
		[Token(Token = "0x4011DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<GridPosition> s_sharedGridPositions;

		// Token: 0x04011DBC RID: 73148
		[Token(Token = "0x4011DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly HashSet<Tile> s_bfsVisited;

		// Token: 0x04011DBD RID: 73149
		[Token(Token = "0x4011DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Queue<Tile> s_bfsQueue;

		// Token: 0x04011DBE RID: 73150
		[Token(Token = "0x4011DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<Tile> s_bfsResult;
	}
}
