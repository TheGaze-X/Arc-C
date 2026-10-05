using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal class ObjectPool<T> where T : new()
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public int maxSize
		{
			[Token(Token = "0x600016B")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600016C")]
			set
			{
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		public ObjectPool(int maxSize = 100)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600016E")]
		public int Size()
		{
			return 0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600016F")]
		public T Get()
		{
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		public void Release(T element)
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> m_Stack;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x0")]
		private int m_MaxSize;
	}
}
