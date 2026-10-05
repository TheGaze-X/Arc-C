using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200237E RID: 9086
	[Token(Token = "0x200237E")]
	public class SPFA : IPathFinding, IHotfixable
	{
		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x0600E66B RID: 58987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CF2")]
		protected Map map
		{
			[Token(Token = "0x600E66B")]
			[Address(RVA = "0x5CAB10", Offset = "0x5C9710", VA = "0x1805CAB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E66C")]
		[Address(RVA = "0x5CA990", Offset = "0x5C9590", VA = "0x1805CA990")]
		public SPFA(Map map)
		{
		}

		// Token: 0x0600E66D RID: 58989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E66D")]
		[Address(RVA = "0x5C8C60", Offset = "0x5C7860", VA = "0x1805C8C60", Slot = "4")]
		public void GenerateNextMap(PathRequest request, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E66E")]
		[Address(RVA = "0x5C8BA0", Offset = "0x5C77A0", VA = "0x1805C8BA0")]
		public void GenerateNextMapWithoutCaching(PathRequest request, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E66F")]
		[Address(RVA = "0x5C9380", Offset = "0x5C7F80", VA = "0x1805C9380")]
		private void _GenerateNextMapImpl(PathRequest request, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600E670 RID: 58992 RVA: 0x00053D78 File Offset: 0x00051F78
		[Token(Token = "0x600E670")]
		[Address(RVA = "0x5C86F0", Offset = "0x5C72F0", VA = "0x1805C86F0", Slot = "9")]
		protected virtual bool CheckPassableGoto(Tile tile, MotionMode motionMode, SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600E671 RID: 58993 RVA: 0x00053D90 File Offset: 0x00051F90
		[Token(Token = "0x600E671")]
		[Address(RVA = "0x5C8E20", Offset = "0x5C7A20", VA = "0x1805C8E20", Slot = "8")]
		public bool TryCalculatePathFindingDistance(PathRequest request, GridPosition startPos, out int distance)
		{
			return default(bool);
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x00053DA8 File Offset: 0x00051FA8
		[Token(Token = "0x600E672")]
		[Address(RVA = "0x5C87B0", Offset = "0x5C73B0", VA = "0x1805C87B0", Slot = "7")]
		public bool CheckReachable(PathRequest request, GridPosition targetPos, bool avoidObstacleLike)
		{
			return default(bool);
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E673")]
		[Address(RVA = "0x5C8AE0", Offset = "0x5C76E0", VA = "0x1805C8AE0", Slot = "5")]
		public void ClearCache(MotionMode motionMode)
		{
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E674")]
		[Address(RVA = "0x5C89C0", Offset = "0x5C75C0", VA = "0x1805C89C0", Slot = "6")]
		public void ClearAllCaches()
		{
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x00053DC0 File Offset: 0x00051FC0
		[Token(Token = "0x600E675")]
		[Address(RVA = "0x5C90A0", Offset = "0x5C7CA0", VA = "0x1805C90A0")]
		private bool _CheckCachedMapReachable(Route.Node[,] cachedMap, GridPosition targetPos, bool avoidObstacleLike)
		{
			return default(bool);
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E676")]
		[Address(RVA = "0x5C99A0", Offset = "0x5C85A0", VA = "0x1805C99A0")]
		private void _LoadedCacheMap(Route.Node[,] cache, Route.Node[,] destination)
		{
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E677")]
		[Address(RVA = "0x5C9CE0", Offset = "0x5C88E0", VA = "0x1805C9CE0")]
		private void _PostprocessAndMakeNextMapSmoothly(PathRequest request, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x00053DD8 File Offset: 0x00051FD8
		[Token(Token = "0x600E678")]
		[Address(RVA = "0x5C9F40", Offset = "0x5C8B40", VA = "0x1805C9F40")]
		private bool _RaycastBresenhamLine(GridPosition a, GridPosition b, MotionMode motion, Route.Node[,] nextMap)
		{
			return default(bool);
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x00053DF0 File Offset: 0x00051FF0
		[Token(Token = "0x600E679")]
		[Address(RVA = "0x5CA830", Offset = "0x5C9430", VA = "0x1805CA830")]
		private bool _RaycastSegmentLine(GridPosition a, GridPosition b, MotionMode motion, Route.Node[,] nextMap)
		{
			return default(bool);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x00053E08 File Offset: 0x00052008
		[Token(Token = "0x600E67A")]
		[Address(RVA = "0x5C9200", Offset = "0x5C7E00", VA = "0x1805C9200")]
		private bool _CheckRectangeAllClear(GridPosition a, GridPosition b, MotionMode motion, Route.Node[,] nextMap)
		{
			return default(bool);
		}

		// Token: 0x0400FDE8 RID: 65000
		[Token(Token = "0x400FDE8")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<Route.Node> s_openList;

		// Token: 0x0400FDE9 RID: 65001
		[Token(Token = "0x400FDE9")]
		[FieldOffset(Offset = "0x10")]
		private Map m_map;

		// Token: 0x0400FDEA RID: 65002
		[Token(Token = "0x400FDEA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<PathRequest, Route.Node[,]>[] m_cacheMap;

		// Token: 0x0400FDEB RID: 65003
		[Token(Token = "0x400FDEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_map;

		// Token: 0x0400FDEC RID: 65004
		[Token(Token = "0x400FDEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDED RID: 65005
		[Token(Token = "0x400FDED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateNextMap;

		// Token: 0x0400FDEE RID: 65006
		[Token(Token = "0x400FDEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateNextMapWithoutCaching;

		// Token: 0x0400FDEF RID: 65007
		[Token(Token = "0x400FDEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateNextMapImpl;

		// Token: 0x0400FDF0 RID: 65008
		[Token(Token = "0x400FDF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckPassableGoto;

		// Token: 0x0400FDF1 RID: 65009
		[Token(Token = "0x400FDF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryCalculatePathFindingDistance;

		// Token: 0x0400FDF2 RID: 65010
		[Token(Token = "0x400FDF2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckReachable;

		// Token: 0x0400FDF3 RID: 65011
		[Token(Token = "0x400FDF3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x0400FDF4 RID: 65012
		[Token(Token = "0x400FDF4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearAllCaches;

		// Token: 0x0400FDF5 RID: 65013
		[Token(Token = "0x400FDF5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckCachedMapReachable;

		// Token: 0x0400FDF6 RID: 65014
		[Token(Token = "0x400FDF6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadedCacheMap;

		// Token: 0x0400FDF7 RID: 65015
		[Token(Token = "0x400FDF7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PostprocessAndMakeNextMapSmoothly;

		// Token: 0x0400FDF8 RID: 65016
		[Token(Token = "0x400FDF8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RaycastBresenhamLine;

		// Token: 0x0400FDF9 RID: 65017
		[Token(Token = "0x400FDF9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RaycastSegmentLine;

		// Token: 0x0400FDFA RID: 65018
		[Token(Token = "0x400FDFA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckRectangeAllClear;
	}
}
