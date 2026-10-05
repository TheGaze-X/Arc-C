using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.TPhysic2D
{
	// Token: 0x0200269C RID: 9884
	[Token(Token = "0x200269C")]
	public class TPhysicManager
	{
		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06010258 RID: 66136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002328")]
		public TDynamicTree<BObject> enemyTree
		{
			[Token(Token = "0x6010258")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06010259 RID: 66137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010259")]
		[Address(RVA = "0x7EFBD0", Offset = "0x7EE7D0", VA = "0x1807EFBD0")]
		public void CreateProxy(TAABB aabb, BObject obj)
		{
		}

		// Token: 0x0601025A RID: 66138 RVA: 0x000627D8 File Offset: 0x000609D8
		[Token(Token = "0x601025A")]
		[Address(RVA = "0x7EFA80", Offset = "0x7EE680", VA = "0x1807EFA80")]
		public bool ContainsProxy(BObject obj)
		{
			return default(bool);
		}

		// Token: 0x0601025B RID: 66139 RVA: 0x000627F0 File Offset: 0x000609F0
		[Token(Token = "0x601025B")]
		[Address(RVA = "0x7EFF00", Offset = "0x7EEB00", VA = "0x1807EFF00")]
		public bool MoveProxy(BObject data, TAABB taabb, Vector2 displacement)
		{
			return default(bool);
		}

		// Token: 0x0601025C RID: 66140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601025C")]
		[Address(RVA = "0x7EFD70", Offset = "0x7EE970", VA = "0x1807EFD70")]
		public void DestroyProxy(BObject data)
		{
		}

		// Token: 0x0601025D RID: 66141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601025D")]
		[Address(RVA = "0x7F00C0", Offset = "0x7EECC0", VA = "0x1807F00C0")]
		public void OnInit()
		{
		}

		// Token: 0x0601025E RID: 66142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601025E")]
		[Address(RVA = "0x7F0120", Offset = "0x7EED20", VA = "0x1807F0120")]
		public void OnRelease()
		{
		}

		// Token: 0x0601025F RID: 66143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601025F")]
		[Address(RVA = "0x7F0410", Offset = "0x7EF010", VA = "0x1807F0410")]
		public void QueryEntity(TAABB aabb, List<Entity> retList)
		{
		}

		// Token: 0x06010260 RID: 66144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010260")]
		[Address(RVA = "0x7F0180", Offset = "0x7EED80", VA = "0x1807F0180")]
		public void QueryCharacter(TAABB aabb, List<Entity> retList)
		{
		}

		// Token: 0x06010261 RID: 66145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010261")]
		[Address(RVA = "0x7F02F0", Offset = "0x7EEEF0", VA = "0x1807F02F0")]
		public void QueryEnemy(TAABB aabb, List<Entity> retList)
		{
		}

		// Token: 0x06010262 RID: 66146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010262")]
		[Address(RVA = "0x7F0360", Offset = "0x7EEF60", VA = "0x1807F0360")]
		public void QueryEntity(TCircle circle, List<Entity> retList)
		{
		}

		// Token: 0x06010263 RID: 66147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010263")]
		[Address(RVA = "0x7F01F0", Offset = "0x7EEDF0", VA = "0x1807F01F0")]
		public void QueryCharacter(TCircle circle, List<Entity> retList)
		{
		}

		// Token: 0x06010264 RID: 66148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010264")]
		[Address(RVA = "0x7F0270", Offset = "0x7EEE70", VA = "0x1807F0270")]
		public void QueryEnemy(TCircle circle, List<Entity> retList)
		{
		}

		// Token: 0x06010265 RID: 66149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010265")]
		[Address(RVA = "0x7F04B0", Offset = "0x7EF0B0", VA = "0x1807F04B0")]
		public TPhysicManager()
		{
		}

		// Token: 0x04011FE2 RID: 73698
		[Token(Token = "0x4011FE2")]
		[FieldOffset(Offset = "0x10")]
		private TDynamicTree<BObject> m_enemyTree;

		// Token: 0x04011FE3 RID: 73699
		[Token(Token = "0x4011FE3")]
		[FieldOffset(Offset = "0x18")]
		private TDynamicTree<BObject> m_characterTree;
	}
}
