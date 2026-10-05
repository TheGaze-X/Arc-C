using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;

namespace Torappu
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	public class ReusableList<T> : List<T>, IReusable, IDisposable
	{
		// Token: 0x06005B27 RID: 23335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B27")]
		public ReusableList(int capacity, ListPool<T> pool)
		{
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B28")]
		private ReusableList()
		{
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B29")]
		public void Dispose()
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2A")]
		public void OnAllocate()
		{
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2B")]
		public void OnRecycle()
		{
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2C")]
		public static ReusableList<T> FlagOnly_CreateFakeReusableList()
		{
			return null;
		}

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x0")]
		private ListPool<T> m_parentPool;
	}
}
