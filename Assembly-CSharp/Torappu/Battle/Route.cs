using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002380 RID: 9088
	[Token(Token = "0x2002380")]
	public class Route
	{
		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600E67F RID: 59007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CF3")]
		public Map map
		{
			[Token(Token = "0x600E67F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600E680 RID: 59008 RVA: 0x00053E50 File Offset: 0x00052050
		[Token(Token = "0x17001CF4")]
		public MotionMode motionMode
		{
			[Token(Token = "0x600E680")]
			[Address(RVA = "0x5C84B0", Offset = "0x5C70B0", VA = "0x1805C84B0")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x00053E68 File Offset: 0x00052068
		[Token(Token = "0x17001CF5")]
		public int checkpointCnt
		{
			[Token(Token = "0x600E681")]
			[Address(RVA = "0x5C8490", Offset = "0x5C7090", VA = "0x1805C8490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600E682 RID: 59010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CF6")]
		public RouteData data
		{
			[Token(Token = "0x600E682")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E683")]
		[Address(RVA = "0x5C82C0", Offset = "0x5C6EC0", VA = "0x1805C82C0")]
		public Route(RouteData data, Map map, IPathFinding pathFinder)
		{
		}

		// Token: 0x0600E684 RID: 59012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E684")]
		[Address(RVA = "0x5C7710", Offset = "0x5C6310", VA = "0x1805C7710")]
		public void ReconstructRoute(RouteData data)
		{
		}

		// Token: 0x0600E685 RID: 59013 RVA: 0x00053E80 File Offset: 0x00052080
		[Token(Token = "0x600E685")]
		[Address(RVA = "0x5C6DF0", Offset = "0x5C59F0", VA = "0x1805C6DF0")]
		public float GetDistToFinal()
		{
			return 0f;
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x00053E98 File Offset: 0x00052098
		[Token(Token = "0x600E686")]
		[Address(RVA = "0x5C6D10", Offset = "0x5C5910", VA = "0x1805C6D10")]
		public float GetDistToFinal(GridPosition position)
		{
			return 0f;
		}

		// Token: 0x0600E687 RID: 59015 RVA: 0x00053EB0 File Offset: 0x000520B0
		[Token(Token = "0x600E687")]
		[Address(RVA = "0x5C6F80", Offset = "0x5C5B80", VA = "0x1805C6F80")]
		public int GetIndexInMap(bool useExtraRoute = false)
		{
			return 0;
		}

		// Token: 0x0600E688 RID: 59016 RVA: 0x00053EC8 File Offset: 0x000520C8
		[Token(Token = "0x600E688")]
		[Address(RVA = "0x5C6F10", Offset = "0x5C5B10", VA = "0x1805C6F10")]
		public bool GetIndexInMap(out int routeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600E689 RID: 59017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E689")]
		[Address(RVA = "0x5C7400", Offset = "0x5C6000", VA = "0x1805C7400")]
		public void ReconstructNextMap()
		{
		}

		// Token: 0x0600E68A RID: 59018 RVA: 0x00053EE0 File Offset: 0x000520E0
		[Token(Token = "0x600E68A")]
		[Address(RVA = "0x5C6EE0", Offset = "0x5C5AE0", VA = "0x1805C6EE0")]
		public float GetEstimatedDistToFinalWithoutCheckpoints(Vector2 pos)
		{
			return 0f;
		}

		// Token: 0x0600E68B RID: 59019 RVA: 0x00053EF8 File Offset: 0x000520F8
		[Token(Token = "0x600E68B")]
		[Address(RVA = "0x5C6FC0", Offset = "0x5C5BC0", VA = "0x1805C6FC0")]
		public Vector2 GetPredictFuturePositionWithoutCheckpoints(Vector2 pos, float predictDist)
		{
			return default(Vector2);
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x00053F10 File Offset: 0x00052110
		[Token(Token = "0x600E68C")]
		[Address(RVA = "0x5C73A0", Offset = "0x5C5FA0", VA = "0x1805C73A0")]
		public Vector2 GetSpawnPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600E68D RID: 59021 RVA: 0x00053F28 File Offset: 0x00052128
		[Token(Token = "0x600E68D")]
		[Address(RVA = "0x5C72D0", Offset = "0x5C5ED0", VA = "0x1805C72D0")]
		public Vector2 GetSpawnOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0600E68E RID: 59022 RVA: 0x00053F40 File Offset: 0x00052140
		[Token(Token = "0x600E68E")]
		[Address(RVA = "0x5C6BA0", Offset = "0x5C57A0", VA = "0x1805C6BA0")]
		public Vector2 GetContDirectionAfterEnd()
		{
			return default(Vector2);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x00053F58 File Offset: 0x00052158
		[Token(Token = "0x600E68F")]
		[Address(RVA = "0x5C69D0", Offset = "0x5C55D0", VA = "0x1805C69D0")]
		public bool CheckReached(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x0600E690 RID: 59024 RVA: 0x00053F70 File Offset: 0x00052170
		[Token(Token = "0x600E690")]
		[Address(RVA = "0x5C6A50", Offset = "0x5C5650", VA = "0x1805C6A50")]
		public bool CheckReached(Vector2 pos, float dist)
		{
			return default(bool);
		}

		// Token: 0x0600E691 RID: 59025 RVA: 0x00053F88 File Offset: 0x00052188
		[Token(Token = "0x600E691")]
		[Address(RVA = "0x5C69E0", Offset = "0x5C55E0", VA = "0x1805C69E0")]
		public bool CheckReached(GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x00053FA0 File Offset: 0x000521A0
		[Token(Token = "0x600E692")]
		[Address(RVA = "0x5C6700", Offset = "0x5C5300", VA = "0x1805C6700")]
		public bool CheckReachable(bool avoidObstacleLike, bool ignoreStartTile = false)
		{
			return default(bool);
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x00053FB8 File Offset: 0x000521B8
		[Token(Token = "0x600E693")]
		[Address(RVA = "0x5C6860", Offset = "0x5C5460", VA = "0x1805C6860")]
		public bool CheckReachable(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x0600E694 RID: 59028 RVA: 0x00053FD0 File Offset: 0x000521D0
		[Token(Token = "0x600E694")]
		[Address(RVA = "0x5C6940", Offset = "0x5C5540", VA = "0x1805C6940")]
		public bool CheckReachable(GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E695")]
		[Address(RVA = "0x5C6410", Offset = "0x5C5010", VA = "0x1805C6410")]
		public void AddMapOffsetMoveCkReachOffset(Vector2 offset)
		{
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x00053FE8 File Offset: 0x000521E8
		[Token(Token = "0x600E696")]
		[Address(RVA = "0x5C6680", Offset = "0x5C5280", VA = "0x1805C6680")]
		public bool CheckContainsOffsetCheckpoint(float tolerance = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x0600E697 RID: 59031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E697")]
		[Address(RVA = "0x5C6B70", Offset = "0x5C5770", VA = "0x1805C6B70")]
		public Route.Node[,] GetCheckpointNextMap(int index)
		{
			return null;
		}

		// Token: 0x0600E698 RID: 59032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E698")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		public Route.Node[,] GetTargetNextMap()
		{
			return null;
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E699")]
		[Address(RVA = "0x5C79F0", Offset = "0x5C65F0", VA = "0x1805C79F0")]
		private Route.Node[,] _CreateNextMap()
		{
			return null;
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E69A")]
		[Address(RVA = "0x5C7A70", Offset = "0x5C6670", VA = "0x1805C7A70")]
		private void _GenerateNextMap(GridPosition target, Route.Node[,] nextMap)
		{
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E69B")]
		[Address(RVA = "0x5C78D0", Offset = "0x5C64D0", VA = "0x1805C78D0")]
		private void _ComplementFinalDistance(Route.Node[,] currentNextMap, Route.Node[,] nextNextMap, GridPosition targetPosInNext)
		{
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E69C")]
		[Address(RVA = "0x5C7B90", Offset = "0x5C6790", VA = "0x1805C7B90")]
		private void _GenerateNextTurn(GridPosition currentTarget, Route.Node[,] currentNextMap, Route.Node[,] nextNextMap)
		{
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x00054000 File Offset: 0x00052200
		[Token(Token = "0x600E69D")]
		[Address(RVA = "0x5C80B0", Offset = "0x5C6CB0", VA = "0x1805C80B0")]
		private Vector2 _GetNextTurn(Route.Node node, Route.Node targetNodeInNext)
		{
			return default(Vector2);
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x00054018 File Offset: 0x00052218
		[Token(Token = "0x600E69E")]
		[Address(RVA = "0x5C7DC0", Offset = "0x5C69C0", VA = "0x1805C7DC0")]
		private float _GetEstimatedDistToFinalWithoutCheckpoints(Vector2 pos, out GridPosition gridPos, out Route.Node curNode)
		{
			return 0f;
		}

		// Token: 0x0400FDFD RID: 65021
		[Token(Token = "0x400FDFD")]
		[FieldOffset(Offset = "0x0")]
		private static GridPosition[] s_sharedSingleNode;

		// Token: 0x0400FDFE RID: 65022
		[Token(Token = "0x400FDFE")]
		[FieldOffset(Offset = "0x10")]
		private Map m_map;

		// Token: 0x0400FDFF RID: 65023
		[Token(Token = "0x400FDFF")]
		[FieldOffset(Offset = "0x18")]
		private RouteData m_data;

		// Token: 0x0400FE00 RID: 65024
		[Token(Token = "0x400FE00")]
		[FieldOffset(Offset = "0x20")]
		private IPathFinding m_pathFinder;

		// Token: 0x0400FE01 RID: 65025
		[Token(Token = "0x400FE01")]
		[FieldOffset(Offset = "0x28")]
		private Route.Node[,] m_targetNextMap;

		// Token: 0x0400FE02 RID: 65026
		[Token(Token = "0x400FE02")]
		[FieldOffset(Offset = "0x30")]
		private Route.Node[][,] m_checkpointsNextMap;

		// Token: 0x02002381 RID: 9089
		[Token(Token = "0x2002381")]
		public class Node
		{
			// Token: 0x17001CF7 RID: 7415
			// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x00054030 File Offset: 0x00052230
			[Token(Token = "0x17001CF7")]
			public bool isValid
			{
				[Token(Token = "0x600E6A0")]
				[Address(RVA = "0x5C59C0", Offset = "0x5C45C0", VA = "0x1805C59C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001CF8 RID: 7416
			// (get) Token: 0x0600E6A1 RID: 59041 RVA: 0x00054048 File Offset: 0x00052248
			[Token(Token = "0x17001CF8")]
			public bool hasNext
			{
				[Token(Token = "0x600E6A1")]
				[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E6A2 RID: 59042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6A2")]
			[Address(RVA = "0x5C5960", Offset = "0x5C4560", VA = "0x1805C5960")]
			public void Reset(GridPosition pos, Tile tile)
			{
			}

			// Token: 0x0600E6A3 RID: 59043 RVA: 0x00054060 File Offset: 0x00052260
			[Token(Token = "0x600E6A3")]
			[Address(RVA = "0x5C5830", Offset = "0x5C4430", VA = "0x1805C5830")]
			public Vector2 GetSafeNextPosition()
			{
				return default(Vector2);
			}

			// Token: 0x0600E6A4 RID: 59044 RVA: 0x00054078 File Offset: 0x00052278
			[Token(Token = "0x600E6A4")]
			[Address(RVA = "0x5C5810", Offset = "0x5C4410", VA = "0x1805C5810")]
			public GridPosition GetSafeNextGrid()
			{
				return default(GridPosition);
			}

			// Token: 0x0600E6A5 RID: 59045 RVA: 0x00054090 File Offset: 0x00052290
			[Token(Token = "0x600E6A5")]
			[Address(RVA = "0x5C5720", Offset = "0x5C4320", VA = "0x1805C5720")]
			public Vector2 GetSafeNextDirection()
			{
				return default(Vector2);
			}

			// Token: 0x0600E6A6 RID: 59046 RVA: 0x000540A8 File Offset: 0x000522A8
			[Token(Token = "0x600E6A6")]
			[Address(RVA = "0x5C58C0", Offset = "0x5C44C0", VA = "0x1805C58C0")]
			public bool IsPassableGoTo(MotionMode mode, GridPosition direction)
			{
				return default(bool);
			}

			// Token: 0x0600E6A7 RID: 59047 RVA: 0x000540C0 File Offset: 0x000522C0
			[Token(Token = "0x600E6A7")]
			[Address(RVA = "0x5C5940", Offset = "0x5C4540", VA = "0x1805C5940")]
			public bool IsPassableGoTo(MotionMode mode, SharedConsts.Direction direction)
			{
				return default(bool);
			}

			// Token: 0x0600E6A8 RID: 59048 RVA: 0x000540D8 File Offset: 0x000522D8
			[Token(Token = "0x600E6A8")]
			[Address(RVA = "0x5C56B0", Offset = "0x5C42B0", VA = "0x1805C56B0")]
			public bool CheckObstacleLikeOrInvalid(MotionMode mode)
			{
				return default(bool);
			}

			// Token: 0x0600E6A9 RID: 59049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6A9")]
			[Address(RVA = "0x5C59A0", Offset = "0x5C45A0", VA = "0x1805C59A0")]
			public Node()
			{
			}

			// Token: 0x0400FE03 RID: 65027
			[Token(Token = "0x400FE03")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition pos;

			// Token: 0x0400FE04 RID: 65028
			[Token(Token = "0x400FE04")]
			[FieldOffset(Offset = "0x18")]
			public Tile tile;

			// Token: 0x0400FE05 RID: 65029
			[Token(Token = "0x400FE05")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 nextTurn;

			// Token: 0x0400FE06 RID: 65030
			[Token(Token = "0x400FE06")]
			[FieldOffset(Offset = "0x28")]
			public Route.Node nextNode;

			// Token: 0x0400FE07 RID: 65031
			[Token(Token = "0x400FE07")]
			[FieldOffset(Offset = "0x30")]
			public int distance;

			// Token: 0x0400FE08 RID: 65032
			[Token(Token = "0x400FE08")]
			[FieldOffset(Offset = "0x34")]
			public int distToFinal;

			// Token: 0x0400FE09 RID: 65033
			[Token(Token = "0x400FE09")]
			[FieldOffset(Offset = "0x38")]
			public bool isInOpenList;
		}
	}
}
