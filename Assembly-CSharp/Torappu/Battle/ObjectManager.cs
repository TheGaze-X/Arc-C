using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023C6 RID: 9158
	[Token(Token = "0x20023C6")]
	public class ObjectManager
	{
		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E8F4 RID: 59636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D7A")]
		public UnorderedArray<Projectile> projectiles
		{
			[Token(Token = "0x600E8F3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600E8F4")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F5")]
		[Address(RVA = "0x5F8860", Offset = "0x5F7460", VA = "0x1805F8860")]
		public ObjectManager(int capacity)
		{
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F6")]
		[Address(RVA = "0x5F8620", Offset = "0x5F7220", VA = "0x1805F8620")]
		public void Register(BObject obj)
		{
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F7")]
		[Address(RVA = "0x5F8740", Offset = "0x5F7340", VA = "0x1805F8740")]
		public void Unregister(BObject obj)
		{
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F8")]
		[Address(RVA = "0x5F8190", Offset = "0x5F6D90", VA = "0x1805F8190")]
		public void Clear()
		{
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F9")]
		[Address(RVA = "0x5F8280", Offset = "0x5F6E80", VA = "0x1805F8280")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8FA")]
		[Address(RVA = "0x5F8450", Offset = "0x5F7050", VA = "0x1805F8450")]
		public void OnLateFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x040100EA RID: 65770
		[Token(Token = "0x40100EA")]
		[FieldOffset(Offset = "0x10")]
		private PriorityQueue<BObject> m_objects;

		// Token: 0x040100EB RID: 65771
		[Token(Token = "0x40100EB")]
		[FieldOffset(Offset = "0x18")]
		private List<BObject> m_cachedList;
	}
}
