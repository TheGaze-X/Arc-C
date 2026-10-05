using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017D8 RID: 6104
	[Token(Token = "0x20017D8")]
	[Serializable]
	public class GridMap
	{
		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		// (set) Token: 0x06009A3A RID: 39482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010C1")]
		public int width
		{
			[Token(Token = "0x6009A39")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009A3A")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06009A3B RID: 39483 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		// (set) Token: 0x06009A3C RID: 39484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010C2")]
		public int height
		{
			[Token(Token = "0x6009A3B")]
			[Address(RVA = "0x150B0C0", Offset = "0x1509CC0", VA = "0x18150B0C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009A3C")]
			[Address(RVA = "0x150B100", Offset = "0x1509D00", VA = "0x18150B100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x0003BCE8 File Offset: 0x00039EE8
		[Token(Token = "0x170010C3")]
		public GridPosition size
		{
			[Token(Token = "0x6009A3D")]
			[Address(RVA = "0x31465D0", Offset = "0x31451D0", VA = "0x1831465D0")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06009A3E RID: 39486 RVA: 0x0003BD00 File Offset: 0x00039F00
		[Token(Token = "0x170010C4")]
		public int nodeCnt
		{
			[Token(Token = "0x6009A3E")]
			[Address(RVA = "0x31465A0", Offset = "0x31451A0", VA = "0x1831465A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010C5 RID: 4293
		[Token(Token = "0x170010C5")]
		public GridMap.GridNode this[int r, int c]
		{
			[Token(Token = "0x6009A3F")]
			[Address(RVA = "0x3146500", Offset = "0x3145100", VA = "0x183146500")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010C6 RID: 4294
		[Token(Token = "0x170010C6")]
		public GridMap.GridNode this[GridPosition pos]
		{
			[Token(Token = "0x6009A40")]
			[Address(RVA = "0x3146550", Offset = "0x3145150", VA = "0x183146550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A41")]
		[Address(RVA = "0x3145BB0", Offset = "0x31447B0", VA = "0x183145BB0")]
		public GridMap(int width, int height, GridMap.Options options)
		{
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x0003BD18 File Offset: 0x00039F18
		[Token(Token = "0x6009A42")]
		[Address(RVA = "0x3143310", Offset = "0x3141F10", VA = "0x183143310")]
		public Path FindPath(GridPosition source, GridPosition destination)
		{
			return default(Path);
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x0003BD30 File Offset: 0x00039F30
		[Token(Token = "0x6009A43")]
		[Address(RVA = "0x3143500", Offset = "0x3142100", VA = "0x183143500")]
		public Path FindShortestPath(GridPosition source, GridPosition[] destinations, Func<GridPosition, GridPosition, bool> validator)
		{
			return default(Path);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x0003BD48 File Offset: 0x00039F48
		[Token(Token = "0x6009A44")]
		[Address(RVA = "0x3143150", Offset = "0x3141D50", VA = "0x183143150")]
		public Path FindFirstPath(GridPosition source, GridPosition[] destinations)
		{
			return default(Path);
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x0003BD60 File Offset: 0x00039F60
		[Token(Token = "0x6009A45")]
		[Address(RVA = "0x3143100", Offset = "0x3141D00", VA = "0x183143100")]
		public bool CheckGridValid(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x0003BD78 File Offset: 0x00039F78
		[Token(Token = "0x6009A46")]
		[Address(RVA = "0x3143070", Offset = "0x3141C70", VA = "0x183143070")]
		public bool CheckEmptyGrid(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x0003BD90 File Offset: 0x00039F90
		[Token(Token = "0x6009A47")]
		[Address(RVA = "0x31442E0", Offset = "0x3142EE0", VA = "0x1831442E0")]
		public bool TryGetGrid(GridPosition pos, out GridMap.GridNode node)
		{
			return default(bool);
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		[Token(Token = "0x6009A48")]
		[Address(RVA = "0x3143120", Offset = "0x3141D20", VA = "0x183143120")]
		public bool CheckOnBoundary(GridPosition pos, bool exceptFirstRow)
		{
			return default(bool);
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x0003BDC0 File Offset: 0x00039FC0
		[Token(Token = "0x6009A49")]
		[Address(RVA = "0x3143920", Offset = "0x3142520", VA = "0x183143920")]
		public bool PickRandomEmptyGrid(out GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x0003BDD8 File Offset: 0x00039FD8
		[Token(Token = "0x6009A4A")]
		[Address(RVA = "0x3143D60", Offset = "0x3142960", VA = "0x183143D60")]
		public bool PickRandomGrid(out GridPosition pos, Func<GridMap, GridMap.Node, bool> validator, bool onlyEmpty = true)
		{
			return default(bool);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x0003BDF0 File Offset: 0x00039FF0
		[Token(Token = "0x6009A4B")]
		[Address(RVA = "0x31439F0", Offset = "0x31425F0", VA = "0x1831439F0")]
		public bool PickRandomGridWithWeight(out GridPosition pos, Func<GridMap, GridMap.Node, float> weightGetter, bool onlyEmpty = true)
		{
			return default(bool);
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x0003BE08 File Offset: 0x0003A008
		[Token(Token = "0x6009A4C")]
		[Address(RVA = "0x3143790", Offset = "0x3142390", VA = "0x183143790")]
		public bool PickFirstGrid(out GridPosition pos, Func<GridMap, GridMap.Node, bool> validator, bool onlyEmpty = true)
		{
			return default(bool);
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x0003BE20 File Offset: 0x0003A020
		[Token(Token = "0x6009A4D")]
		[Address(RVA = "0x3142FF0", Offset = "0x3141BF0", VA = "0x183142FF0")]
		public bool AddObstacle(BuildingData.ObstaclePoint pos)
		{
			return default(bool);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4E")]
		[Address(RVA = "0x3142F80", Offset = "0x3141B80", VA = "0x183142F80")]
		public void AddObstacle(BuildingData.ObstacleRect rect)
		{
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x0003BE38 File Offset: 0x0003A038
		[Token(Token = "0x6009A4F")]
		[Address(RVA = "0x31442D0", Offset = "0x3142ED0", VA = "0x1831442D0")]
		public bool RemoveObstacle(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A50")]
		[Address(RVA = "0x3144200", Offset = "0x3142E00", VA = "0x183144200")]
		public void RemoveObstacle(GridPosition pos, GridPosition size)
		{
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x0003BE50 File Offset: 0x0003A050
		[Token(Token = "0x6009A51")]
		[Address(RVA = "0x3142F20", Offset = "0x3141B20", VA = "0x183142F20")]
		public bool AddObject(GridPosition pos, GridMap.IGridObject obj)
		{
			return default(bool);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x0003BE68 File Offset: 0x0003A068
		[Token(Token = "0x6009A52")]
		[Address(RVA = "0x31441A0", Offset = "0x3142DA0", VA = "0x1831441A0")]
		public bool RemoveObject(GridMap.IGridObject obj)
		{
			return default(bool);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A53")]
		[Address(RVA = "0x3144050", Offset = "0x3142C50", VA = "0x183144050")]
		public void PopulateObstacles(List<BuildingData.ObstaclePoint> obstacles)
		{
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A54")]
		[Address(RVA = "0x3144AF0", Offset = "0x31436F0", VA = "0x183144AF0")]
		private void _BuildGraph(int width, int height)
		{
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A55")]
		[Address(RVA = "0x3145510", Offset = "0x3144110", VA = "0x183145510")]
		private GridMap.EdgeNode _GetEdge(GridPosition pos, SharedConsts.Direction dir)
		{
			return null;
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x0003BE80 File Offset: 0x0003A080
		[Token(Token = "0x6009A56")]
		[Address(RVA = "0x31454C0", Offset = "0x31440C0", VA = "0x1831454C0")]
		private int _GetEdgeIndex(GridPosition pos, SharedConsts.Direction dir)
		{
			return 0;
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x0003BE98 File Offset: 0x0003A098
		[Token(Token = "0x6009A57")]
		[Address(RVA = "0x31459F0", Offset = "0x31445F0", VA = "0x1831459F0")]
		private bool _TryParseEdgeIndex(int index, out GridPosition pos, out SharedConsts.Direction dir)
		{
			return default(bool);
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		[Token(Token = "0x6009A58")]
		[Address(RVA = "0x3144960", Offset = "0x3143560", VA = "0x183144960")]
		private bool _AddObstacle(BuildingData.ObstaclePoint pos)
		{
			return default(bool);
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A59")]
		[Address(RVA = "0x3144740", Offset = "0x3143340", VA = "0x183144740")]
		private void _AddObstacle(BuildingData.ObstacleRect rect)
		{
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x0003BEC8 File Offset: 0x0003A0C8
		[Token(Token = "0x6009A5A")]
		[Address(RVA = "0x3145920", Offset = "0x3144520", VA = "0x183145920")]
		private bool _RemoveObstacle(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5B")]
		[Address(RVA = "0x3144200", Offset = "0x3142E00", VA = "0x183144200")]
		private void _RemoveObstacle(GridPosition pos, GridPosition size)
		{
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		[Token(Token = "0x6009A5C")]
		[Address(RVA = "0x3144360", Offset = "0x3142F60", VA = "0x183144360")]
		private bool _AddObject(GridPosition pos, GridMap.IGridObject obj)
		{
			return default(bool);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x0003BEF8 File Offset: 0x0003A0F8
		[Token(Token = "0x6009A5D")]
		[Address(RVA = "0x31455E0", Offset = "0x31441E0", VA = "0x1831455E0")]
		private bool _RemoveObject(GridMap.IGridObject obj)
		{
			return default(bool);
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5E")]
		[Address(RVA = "0x3145470", Offset = "0x3144070", VA = "0x183145470")]
		private void _ClearCachedPath()
		{
		}

		// Token: 0x040090BB RID: 37051
		[Token(Token = "0x40090BB")]
		private const int HORIZONTAL_EDGE_NODE_COST = 5;

		// Token: 0x040090BC RID: 37052
		[Token(Token = "0x40090BC")]
		private const int VERTICAL_EDGE_NODE_COST = 1000;

		// Token: 0x040090BD RID: 37053
		[Token(Token = "0x40090BD")]
		[FieldOffset(Offset = "0x0")]
		private static List<GridMap.Node> s_sharedNodeList;

		// Token: 0x040090BE RID: 37054
		[Token(Token = "0x40090BE")]
		[FieldOffset(Offset = "0x10")]
		private int m_verticalEdgeIndexOffset;

		// Token: 0x040090BF RID: 37055
		[Token(Token = "0x40090BF")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<GridMap.IGridObject, GridPosition> m_objToPosMap;

		// Token: 0x040090C0 RID: 37056
		[Token(Token = "0x40090C0")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<GridMap.PathKey, Path> m_cachedMapPath;

		// Token: 0x040090C1 RID: 37057
		[Token(Token = "0x40090C1")]
		[FieldOffset(Offset = "0x28")]
		private GridMap.GridNode[,] m_map;

		// Token: 0x040090C2 RID: 37058
		[Token(Token = "0x40090C2")]
		[FieldOffset(Offset = "0x30")]
		private GridMap.EdgeNode[] m_edges;

		// Token: 0x040090C3 RID: 37059
		[Token(Token = "0x40090C3")]
		[FieldOffset(Offset = "0x38")]
		private TwoPointPathFinder m_pathFinder;

		// Token: 0x040090C4 RID: 37060
		[Token(Token = "0x40090C4")]
		[FieldOffset(Offset = "0x40")]
		private Heap<GridMap.GridNode> m_emptyGrids;

		// Token: 0x020017D9 RID: 6105
		[Token(Token = "0x20017D9")]
		public struct Options
		{
			// Token: 0x040090C7 RID: 37063
			[Token(Token = "0x40090C7")]
			[FieldOffset(Offset = "0x0")]
			public IList<BuildingData.ObstaclePoint> obstaclePoints;

			// Token: 0x040090C8 RID: 37064
			[Token(Token = "0x40090C8")]
			[FieldOffset(Offset = "0x8")]
			public IList<BuildingData.ObstacleRect> obstacleRects;

			// Token: 0x040090C9 RID: 37065
			[Token(Token = "0x40090C9")]
			[FieldOffset(Offset = "0x10")]
			public IList<KeyValuePair<GridPosition, GridMap.IGridObject>> objPairs;
		}

		// Token: 0x020017DA RID: 6106
		[Token(Token = "0x20017DA")]
		private struct PathKey
		{
			// Token: 0x040090CA RID: 37066
			[Token(Token = "0x40090CA")]
			[FieldOffset(Offset = "0x0")]
			public GridPosition from;

			// Token: 0x040090CB RID: 37067
			[Token(Token = "0x40090CB")]
			[FieldOffset(Offset = "0x8")]
			public GridPosition to;
		}

		// Token: 0x020017DB RID: 6107
		[Token(Token = "0x20017DB")]
		public abstract class Node : IItemWithWeight
		{
			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x06009A60 RID: 39520
			[Token(Token = "0x170010C7")]
			public abstract bool isWalkable { [Token(Token = "0x6009A60")] get; }

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x06009A61 RID: 39521
			[Token(Token = "0x170010C8")]
			public abstract int enterCost { [Token(Token = "0x6009A61")] get; }

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x06009A62 RID: 39522 RVA: 0x0003BF10 File Offset: 0x0003A110
			// (set) Token: 0x06009A63 RID: 39523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170010C9")]
			public GridPosition gridPos
			{
				[Token(Token = "0x6009A62")]
				[Address(RVA = "0x3147630", Offset = "0x3146230", VA = "0x183147630")]
				[CompilerGenerated]
				get
				{
					return default(GridPosition);
				}
				[Token(Token = "0x6009A63")]
				[Address(RVA = "0x20BDE40", Offset = "0x20BCA40", VA = "0x1820BDE40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x06009A64 RID: 39524 RVA: 0x0003BF28 File Offset: 0x0003A128
			[Token(Token = "0x170010CA")]
			public float weightValue
			{
				[Token(Token = "0x6009A64")]
				[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06009A65 RID: 39525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A65")]
			[Address(RVA = "0x3147530", Offset = "0x3146130", VA = "0x183147530")]
			public void ConnectTo(GridMap.Node node)
			{
			}

			// Token: 0x06009A66 RID: 39526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A66")]
			[Address(RVA = "0x3147490", Offset = "0x3146090", VA = "0x183147490")]
			public static void Connect2Ways(GridMap.Node lhs, GridMap.Node rhs)
			{
			}

			// Token: 0x06009A67 RID: 39527
			[Token(Token = "0x6009A67")]
			public abstract Vector2 GetMovePos();

			// Token: 0x06009A68 RID: 39528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A68")]
			[Address(RVA = "0x3147590", Offset = "0x3146190", VA = "0x183147590")]
			public Node(GridPosition pos)
			{
			}

			// Token: 0x040090CC RID: 37068
			[Token(Token = "0x40090CC")]
			[FieldOffset(Offset = "0x10")]
			public List<GridMap.Node> nextNodes;

			// Token: 0x040090CD RID: 37069
			[Token(Token = "0x40090CD")]
			[FieldOffset(Offset = "0x18")]
			public float weight;
		}

		// Token: 0x020017DC RID: 6108
		[Token(Token = "0x20017DC")]
		public class GridNode : GridMap.Node, IComparable<GridMap.GridNode>
		{
			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x06009A69 RID: 39529 RVA: 0x0003BF40 File Offset: 0x0003A140
			// (set) Token: 0x06009A6A RID: 39530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170010CB")]
			public GridMap.GridNode.State state
			{
				[Token(Token = "0x6009A69")]
				[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
				[CompilerGenerated]
				get
				{
					return GridMap.GridNode.State.EMPTY;
				}
				[Token(Token = "0x6009A6A")]
				[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x06009A6B RID: 39531 RVA: 0x0003BF58 File Offset: 0x0003A158
			[Token(Token = "0x170010CC")]
			public override bool isWalkable
			{
				[Token(Token = "0x6009A6B")]
				[Address(RVA = "0x3146BB0", Offset = "0x31457B0", VA = "0x183146BB0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x06009A6C RID: 39532 RVA: 0x0003BF70 File Offset: 0x0003A170
			[Token(Token = "0x170010CD")]
			public override int enterCost
			{
				[Token(Token = "0x6009A6C")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06009A6D RID: 39533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A6D")]
			[Address(RVA = "0x3146B40", Offset = "0x3145740", VA = "0x183146B40")]
			public GridNode(GridPosition pos)
			{
			}

			// Token: 0x06009A6E RID: 39534 RVA: 0x0003BF88 File Offset: 0x0003A188
			[Token(Token = "0x6009A6E")]
			[Address(RVA = "0x3146810", Offset = "0x3145410", VA = "0x183146810", Slot = "7")]
			public override Vector2 GetMovePos()
			{
				return default(Vector2);
			}

			// Token: 0x06009A6F RID: 39535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A6F")]
			[Address(RVA = "0x3146870", Offset = "0x3145470", VA = "0x183146870")]
			public void MakeEmpty()
			{
			}

			// Token: 0x06009A70 RID: 39536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A70")]
			[Address(RVA = "0x3146600", Offset = "0x3145200", VA = "0x183146600")]
			public void Abandon(byte edgeWalkableMask)
			{
			}

			// Token: 0x06009A71 RID: 39537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A71")]
			[Address(RVA = "0x3146930", Offset = "0x3145530", VA = "0x183146930")]
			public void Occupy(GridMap.IGridObject obj, byte edgeWalkableMask)
			{
			}

			// Token: 0x06009A72 RID: 39538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009A72")]
			[Address(RVA = "0x3146AD0", Offset = "0x31456D0", VA = "0x183146AD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06009A73 RID: 39539 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
			[Token(Token = "0x6009A73")]
			[Address(RVA = "0x31466D0", Offset = "0x31452D0", VA = "0x1831466D0", Slot = "8")]
			public int CompareTo(GridMap.GridNode other)
			{
				return 0;
			}

			// Token: 0x06009A74 RID: 39540 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
			[Token(Token = "0x6009A74")]
			[Address(RVA = "0x3146750", Offset = "0x3145350", VA = "0x183146750")]
			public byte GetEdgeWalkableMask()
			{
				return 0;
			}

			// Token: 0x040090D0 RID: 37072
			[Token(Token = "0x40090D0")]
			[FieldOffset(Offset = "0x30")]
			public GridMap.EdgeNode[] edges;

			// Token: 0x040090D1 RID: 37073
			[Token(Token = "0x40090D1")]
			[FieldOffset(Offset = "0x38")]
			public uint objectId;

			// Token: 0x040090D2 RID: 37074
			[Token(Token = "0x40090D2")]
			[FieldOffset(Offset = "0x40")]
			public object objectRef;

			// Token: 0x020017DD RID: 6109
			[Token(Token = "0x20017DD")]
			public enum State : byte
			{
				// Token: 0x040090D4 RID: 37076
				[Token(Token = "0x40090D4")]
				EMPTY,
				// Token: 0x040090D5 RID: 37077
				[Token(Token = "0x40090D5")]
				OCCUPIED,
				// Token: 0x040090D6 RID: 37078
				[Token(Token = "0x40090D6")]
				ABANDONED
			}
		}

		// Token: 0x020017DE RID: 6110
		[Token(Token = "0x20017DE")]
		public class EdgeNode : GridMap.Node
		{
			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x06009A75 RID: 39541 RVA: 0x0003BFD0 File Offset: 0x0003A1D0
			// (set) Token: 0x06009A76 RID: 39542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170010CE")]
			public SharedConsts.Direction dir
			{
				[Token(Token = "0x6009A75")]
				[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
				[CompilerGenerated]
				get
				{
					return SharedConsts.Direction.UP;
				}
				[Token(Token = "0x6009A76")]
				[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x06009A77 RID: 39543 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
			[Token(Token = "0x170010CF")]
			public override bool isWalkable
			{
				[Token(Token = "0x6009A77")]
				[Address(RVA = "0x3142B70", Offset = "0x3141770", VA = "0x183142B70", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x06009A78 RID: 39544 RVA: 0x0003C000 File Offset: 0x0003A200
			[Token(Token = "0x170010D0")]
			public override int enterCost
			{
				[Token(Token = "0x6009A78")]
				[Address(RVA = "0x3142B10", Offset = "0x3141710", VA = "0x183142B10", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x06009A79 RID: 39545 RVA: 0x0003C018 File Offset: 0x0003A218
			[Token(Token = "0x170010D1")]
			public bool isHorizontal
			{
				[Token(Token = "0x6009A79")]
				[Address(RVA = "0x3142B30", Offset = "0x3141730", VA = "0x183142B30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x06009A7A RID: 39546 RVA: 0x0003C030 File Offset: 0x0003A230
			[Token(Token = "0x170010D2")]
			public bool isVertical
			{
				[Token(Token = "0x6009A7A")]
				[Address(RVA = "0x3142B50", Offset = "0x3141750", VA = "0x183142B50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009A7B RID: 39547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A7B")]
			[Address(RVA = "0x3142A60", Offset = "0x3141660", VA = "0x183142A60")]
			public EdgeNode(GridPosition pos, SharedConsts.Direction dir)
			{
			}

			// Token: 0x06009A7C RID: 39548 RVA: 0x0003C048 File Offset: 0x0003A248
			[Token(Token = "0x6009A7C")]
			[Address(RVA = "0x31427E0", Offset = "0x31413E0", VA = "0x1831427E0", Slot = "7")]
			public override Vector2 GetMovePos()
			{
				return default(Vector2);
			}

			// Token: 0x06009A7D RID: 39549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A7D")]
			[Address(RVA = "0x31428C0", Offset = "0x31414C0", VA = "0x1831428C0")]
			public void MakeEmpty(GridMap.GridNode node)
			{
			}

			// Token: 0x06009A7E RID: 39550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A7E")]
			[Address(RVA = "0x3142920", Offset = "0x3141520", VA = "0x183142920")]
			public void Occupy(GridMap.GridNode node)
			{
			}

			// Token: 0x06009A7F RID: 39551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009A7F")]
			[Address(RVA = "0x31429A0", Offset = "0x31415A0", VA = "0x1831429A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040090D7 RID: 37079
			[Token(Token = "0x40090D7")]
			[FieldOffset(Offset = "0x28")]
			public List<GridMap.GridNode> occupyGrids;
		}

		// Token: 0x020017DF RID: 6111
		[Token(Token = "0x20017DF")]
		public interface IGridObject
		{
			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x06009A80 RID: 39552
			[Token(Token = "0x170010D3")]
			uint uid { [Token(Token = "0x6009A80")] get; }

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x06009A81 RID: 39553
			[Token(Token = "0x170010D4")]
			string name { [Token(Token = "0x6009A81")] get; }

			// Token: 0x06009A82 RID: 39554
			[Token(Token = "0x6009A82")]
			IList<BuildingData.ObstaclePoint> GetObstaclePoints();
		}
	}
}
