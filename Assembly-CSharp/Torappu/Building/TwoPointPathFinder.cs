using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017E1 RID: 6113
	[Token(Token = "0x20017E1")]
	public class TwoPointPathFinder
	{
		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06009A88 RID: 39560 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009A89 RID: 39561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010D8")]
		private protected GridMap map
		{
			[Token(Token = "0x6009A88")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009A89")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A8A")]
		[Address(RVA = "0x314ABA0", Offset = "0x31497A0", VA = "0x18314ABA0")]
		public TwoPointPathFinder(GridMap map)
		{
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A8B")]
		[Address(RVA = "0x3149E00", Offset = "0x3148A00", VA = "0x183149E00")]
		public GridMap.Node[] FindPath(GridPosition from, GridPosition to, out int retDistance)
		{
			return null;
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A8C")]
		[Address(RVA = "0x314A3C0", Offset = "0x3148FC0", VA = "0x18314A3C0")]
		private TwoPointPathFinder.InternalNode _GetOrCreateNode(GridMap.Node rawNode)
		{
			return null;
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x0003C078 File Offset: 0x0003A278
		[Token(Token = "0x6009A8D")]
		[Address(RVA = "0x314A330", Offset = "0x3148F30", VA = "0x18314A330")]
		private static int _GetHeuristicEstimatedCost(GridMap.Node lhs, GridMap.Node rhs)
		{
			return 0;
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A8E")]
		[Address(RVA = "0x314A240", Offset = "0x3148E40", VA = "0x18314A240")]
		private GridMap.Node[] _ConstructPath(TwoPointPathFinder.InternalNode node)
		{
			return null;
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A8F")]
		[Address(RVA = "0x314A490", Offset = "0x3149090", VA = "0x18314A490")]
		private void _OptimizePath()
		{
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x0003C090 File Offset: 0x0003A290
		[Token(Token = "0x6009A90")]
		[Address(RVA = "0x314A860", Offset = "0x3149460", VA = "0x18314A860")]
		private bool _RaycastBresenhamLine(GridPosition a, GridPosition b)
		{
			return default(bool);
		}

		// Token: 0x040090DC RID: 37084
		[Token(Token = "0x40090DC")]
		[FieldOffset(Offset = "0x10")]
		private TwoPointPathFinder.Heap m_openList;

		// Token: 0x040090DD RID: 37085
		[Token(Token = "0x40090DD")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<TwoPointPathFinder.InternalNode> m_closedList;

		// Token: 0x040090DE RID: 37086
		[Token(Token = "0x40090DE")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<GridMap.Node, TwoPointPathFinder.InternalNode> m_nodeMap;

		// Token: 0x040090DF RID: 37087
		[Token(Token = "0x40090DF")]
		[FieldOffset(Offset = "0x28")]
		private List<GridMap.Node> m_path;

		// Token: 0x020017E2 RID: 6114
		[Token(Token = "0x20017E2")]
		private class Heap
		{
			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x06009A91 RID: 39569 RVA: 0x0003C0A8 File Offset: 0x0003A2A8
			[Token(Token = "0x170010D9")]
			public int count
			{
				[Token(Token = "0x6009A91")]
				[Address(RVA = "0x3160B00", Offset = "0x315F700", VA = "0x183160B00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x06009A92 RID: 39570 RVA: 0x0003C0C0 File Offset: 0x0003A2C0
			[Token(Token = "0x170010DA")]
			public bool isEmpty
			{
				[Token(Token = "0x6009A92")]
				[Address(RVA = "0x3160B40", Offset = "0x315F740", VA = "0x183160B40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009A93 RID: 39571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A93")]
			[Address(RVA = "0x31609E0", Offset = "0x315F5E0", VA = "0x1831609E0")]
			public Heap(int capacity)
			{
			}

			// Token: 0x06009A94 RID: 39572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A94")]
			[Address(RVA = "0x31605F0", Offset = "0x315F1F0", VA = "0x1831605F0")]
			public void Push(TwoPointPathFinder.InternalNode node)
			{
			}

			// Token: 0x06009A95 RID: 39573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009A95")]
			[Address(RVA = "0x3160340", Offset = "0x315EF40", VA = "0x183160340")]
			public TwoPointPathFinder.InternalNode Pop()
			{
				return null;
			}

			// Token: 0x06009A96 RID: 39574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009A96")]
			[Address(RVA = "0x3160290", Offset = "0x315EE90", VA = "0x183160290")]
			public TwoPointPathFinder.InternalNode Peek()
			{
				return null;
			}

			// Token: 0x06009A97 RID: 39575 RVA: 0x0003C0D8 File Offset: 0x0003A2D8
			[Token(Token = "0x6009A97")]
			[Address(RVA = "0x3160690", Offset = "0x315F290", VA = "0x183160690")]
			public bool Update(TwoPointPathFinder.InternalNode node)
			{
				return default(bool);
			}

			// Token: 0x06009A98 RID: 39576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A98")]
			[Address(RVA = "0x3160190", Offset = "0x315ED90", VA = "0x183160190")]
			public void Clear()
			{
			}

			// Token: 0x06009A99 RID: 39577 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
			[Token(Token = "0x6009A99")]
			[Address(RVA = "0x3160270", Offset = "0x315EE70", VA = "0x183160270")]
			public bool Contains(TwoPointPathFinder.InternalNode node)
			{
				return default(bool);
			}

			// Token: 0x06009A9A RID: 39578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A9A")]
			[Address(RVA = "0x3160520", Offset = "0x315F120", VA = "0x183160520")]
			public void PushOrUpdate(TwoPointPathFinder.InternalNode node)
			{
			}

			// Token: 0x06009A9B RID: 39579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A9B")]
			[Address(RVA = "0x31608C0", Offset = "0x315F4C0", VA = "0x1831608C0")]
			private void _Up(int index)
			{
			}

			// Token: 0x06009A9C RID: 39580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A9C")]
			[Address(RVA = "0x31606E0", Offset = "0x315F2E0", VA = "0x1831606E0")]
			private void _Down(int index)
			{
			}

			// Token: 0x040090E1 RID: 37089
			[Token(Token = "0x40090E1")]
			[FieldOffset(Offset = "0x10")]
			private List<TwoPointPathFinder.InternalNode> m_list;

			// Token: 0x040090E2 RID: 37090
			[Token(Token = "0x40090E2")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<TwoPointPathFinder.InternalNode> m_hashSet;
		}

		// Token: 0x020017E3 RID: 6115
		[Token(Token = "0x20017E3")]
		private class InternalNode : IComparable<TwoPointPathFinder.InternalNode>
		{
			// Token: 0x06009A9D RID: 39581 RVA: 0x0003C108 File Offset: 0x0003A308
			[Token(Token = "0x6009A9D")]
			[Address(RVA = "0x209C490", Offset = "0x209B090", VA = "0x18209C490", Slot = "4")]
			public int CompareTo(TwoPointPathFinder.InternalNode other)
			{
				return 0;
			}

			// Token: 0x06009A9E RID: 39582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A9E")]
			[Address(RVA = "0x3160B90", Offset = "0x315F790", VA = "0x183160B90")]
			public InternalNode(GridMap.Node node)
			{
			}

			// Token: 0x040090E3 RID: 37091
			[Token(Token = "0x40090E3")]
			[FieldOffset(Offset = "0x10")]
			public GridMap.Node node;

			// Token: 0x040090E4 RID: 37092
			[Token(Token = "0x40090E4")]
			[FieldOffset(Offset = "0x18")]
			public int distance;

			// Token: 0x040090E5 RID: 37093
			[Token(Token = "0x40090E5")]
			[FieldOffset(Offset = "0x1C")]
			public int fScore;

			// Token: 0x040090E6 RID: 37094
			[Token(Token = "0x40090E6")]
			[FieldOffset(Offset = "0x20")]
			public TwoPointPathFinder.InternalNode prevNode;

			// Token: 0x040090E7 RID: 37095
			[Token(Token = "0x40090E7")]
			[FieldOffset(Offset = "0x28")]
			public int heapIndex;
		}
	}
}
