using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class Pool<T> where T : class, new()
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x17000056")]
		public int Count
		{
			[Token(Token = "0x6000135")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000057")]
		public int Peak
		{
			[Token(Token = "0x6000136")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000137")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000138")]
		public Pool(int initialCapacity = 16, int max = 2147483647)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000139")]
		public T Obtain()
		{
			return null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600013A")]
		public void Free(T obj)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600013B")]
		public void Clear()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600013C")]
		protected void Reset(T obj)
		{
		}

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x0")]
		public readonly int max;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> freeObjects;

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public interface IPoolable
		{
			// Token: 0x0600013D RID: 317
			[Token(Token = "0x600013D")]
			void Reset();
		}
	}
}
