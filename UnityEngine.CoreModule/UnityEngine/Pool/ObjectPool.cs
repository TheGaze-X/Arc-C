using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Pool
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	public class ObjectPool<T> : IDisposable, IObjectPool<T> where T : class
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00006BD0 File Offset: 0x00004DD0
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A5")]
		public int CountAll
		{
			[Token(Token = "0x6000D39")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D3A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x170002A6")]
		public int CountInactive
		{
			[Token(Token = "0x6000D3B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3C")]
		public ObjectPool(Func<T> createFunc, [Optional] Action<T> actionOnGet, [Optional] Action<T> actionOnRelease, [Optional] Action<T> actionOnDestroy, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
		{
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D3D")]
		public T Get()
		{
			return null;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000D3E")]
		public PooledObject<T> Get(out T v)
		{
			return default(PooledObject<T>);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3F")]
		public void Release(T element)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D40")]
		public void Clear()
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D41")]
		public void Dispose()
		{
		}

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly List<T> m_List;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<T> m_CreateFunc;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnGet;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnRelease;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnDestroy;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_MaxSize;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal bool m_CollectionCheck;
	}
}
