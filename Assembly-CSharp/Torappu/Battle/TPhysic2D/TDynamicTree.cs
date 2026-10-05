using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.TPhysic2D
{
	// Token: 0x0200269A RID: 9882
	[Token(Token = "0x200269A")]
	public class TDynamicTree<T>
	{
		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06010239 RID: 66105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002326")]
		public TDynamicTreeNode<T>[] nodes
		{
			[Token(Token = "0x6010239")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x0601023A RID: 66106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002327")]
		public Dictionary<T, int> userDataMap
		{
			[Token(Token = "0x601023A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601023B RID: 66107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601023B")]
		public void OnInit()
		{
		}

		// Token: 0x0601023C RID: 66108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601023C")]
		public void OnRelease()
		{
		}

		// Token: 0x0601023D RID: 66109 RVA: 0x00062688 File Offset: 0x00060888
		[Token(Token = "0x601023D")]
		public int CreateProxy(TAABB taabb, T userData)
		{
			return 0;
		}

		// Token: 0x0601023E RID: 66110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601023E")]
		public void DestroyProxy(int proxyId)
		{
		}

		// Token: 0x0601023F RID: 66111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601023F")]
		public void DestroyProxy(T data)
		{
		}

		// Token: 0x06010240 RID: 66112 RVA: 0x000626A0 File Offset: 0x000608A0
		[Token(Token = "0x6010240")]
		public bool MoveProxy(int proxyId, TAABB taabb, Vector2 displacement)
		{
			return default(bool);
		}

		// Token: 0x06010241 RID: 66113 RVA: 0x000626B8 File Offset: 0x000608B8
		[Token(Token = "0x6010241")]
		public bool MoveProxy(T data, TAABB taabb, Vector2 displacement)
		{
			return default(bool);
		}

		// Token: 0x06010242 RID: 66114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010242")]
		public T GetUserData(int proxyId)
		{
			return null;
		}

		// Token: 0x06010243 RID: 66115 RVA: 0x000626D0 File Offset: 0x000608D0
		[Token(Token = "0x6010243")]
		public bool WasMoved(int proxyId)
		{
			return default(bool);
		}

		// Token: 0x06010244 RID: 66116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010244")]
		public void ClearMoved(int proxyId)
		{
		}

		// Token: 0x06010245 RID: 66117 RVA: 0x000626E8 File Offset: 0x000608E8
		[Token(Token = "0x6010245")]
		public TAABB GetFatAABB(int proxyId)
		{
			return default(TAABB);
		}

		// Token: 0x06010246 RID: 66118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010246")]
		public void Query(TAABB aabb, List<T> result)
		{
		}

		// Token: 0x06010247 RID: 66119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010247")]
		public void Query(TCircle aabb, List<T> result)
		{
		}

		// Token: 0x06010248 RID: 66120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010248")]
		public void QueryEntity(TAABB aabb, List<Entity> result)
		{
		}

		// Token: 0x06010249 RID: 66121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010249")]
		public void QueryEntity(TCircle circle, List<Entity> result)
		{
		}

		// Token: 0x0601024A RID: 66122 RVA: 0x00062700 File Offset: 0x00060900
		[Token(Token = "0x601024A")]
		public int GetHeight()
		{
			return 0;
		}

		// Token: 0x0601024B RID: 66123 RVA: 0x00062718 File Offset: 0x00060918
		[Token(Token = "0x601024B")]
		public int GetMaxBalance()
		{
			return 0;
		}

		// Token: 0x0601024C RID: 66124 RVA: 0x00062730 File Offset: 0x00060930
		[Token(Token = "0x601024C")]
		public float GetAreaRatio()
		{
			return 0f;
		}

		// Token: 0x0601024D RID: 66125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601024D")]
		public void ShiftOrigin(Vector2 newOrigin)
		{
		}

		// Token: 0x0601024E RID: 66126 RVA: 0x00062748 File Offset: 0x00060948
		[Token(Token = "0x601024E")]
		private int _AllocateNode()
		{
			return 0;
		}

		// Token: 0x0601024F RID: 66127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601024F")]
		private void _FreeNode(int nodeId)
		{
		}

		// Token: 0x06010250 RID: 66128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010250")]
		private void _InsertLeaf(int leaf)
		{
		}

		// Token: 0x06010251 RID: 66129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010251")]
		private void _RemoveLeaf(int leaf)
		{
		}

		// Token: 0x06010252 RID: 66130 RVA: 0x00062760 File Offset: 0x00060960
		[Token(Token = "0x6010252")]
		private int _Balance(int iA)
		{
			return 0;
		}

		// Token: 0x06010253 RID: 66131 RVA: 0x00062778 File Offset: 0x00060978
		[Token(Token = "0x6010253")]
		public int ComputeHeight()
		{
			return 0;
		}

		// Token: 0x06010254 RID: 66132 RVA: 0x00062790 File Offset: 0x00060990
		[Token(Token = "0x6010254")]
		private int _ComputeHeight(int nodeId)
		{
			return 0;
		}

		// Token: 0x06010255 RID: 66133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010255")]
		public TDynamicTree()
		{
		}

		// Token: 0x04011FD7 RID: 73687
		[Token(Token = "0x4011FD7")]
		private const int NULL_NODE = -1;

		// Token: 0x04011FD8 RID: 73688
		[Token(Token = "0x4011FD8")]
		private const float TAABB_EXTENSION = 0.1f;

		// Token: 0x04011FD9 RID: 73689
		[Token(Token = "0x4011FD9")]
		private const float TAABB_MULTIPLIER = 4f;

		// Token: 0x04011FDA RID: 73690
		[Token(Token = "0x4011FDA")]
		[FieldOffset(Offset = "0x0")]
		private int m_root;

		// Token: 0x04011FDB RID: 73691
		[Token(Token = "0x4011FDB")]
		[FieldOffset(Offset = "0x0")]
		private int m_nodeCapacity;

		// Token: 0x04011FDC RID: 73692
		[Token(Token = "0x4011FDC")]
		[FieldOffset(Offset = "0x0")]
		private int m_nodeCount;

		// Token: 0x04011FDD RID: 73693
		[Token(Token = "0x4011FDD")]
		[FieldOffset(Offset = "0x0")]
		private TDynamicTreeNode<T>[] m_nodes;

		// Token: 0x04011FDE RID: 73694
		[Token(Token = "0x4011FDE")]
		[FieldOffset(Offset = "0x0")]
		private int m_freeList;

		// Token: 0x04011FDF RID: 73695
		[Token(Token = "0x4011FDF")]
		[FieldOffset(Offset = "0x0")]
		private int m_insertionCount;

		// Token: 0x04011FE0 RID: 73696
		[Token(Token = "0x4011FE0")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_userDataMap;

		// Token: 0x04011FE1 RID: 73697
		[Token(Token = "0x4011FE1")]
		[FieldOffset(Offset = "0x0")]
		private Stack<int> m_queryStack;
	}
}
