using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000257 RID: 599
	[Token(Token = "0x2000257")]
	public sealed class LinkedListNode<T>
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001070")]
		public LinkedListNode(T value)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001071")]
		internal LinkedListNode(LinkedList<T> list, T value)
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		public LinkedListNode<T> Next
		{
			[Token(Token = "0x6001072")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public T Value
		{
			[Token(Token = "0x6001073")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001074")]
		internal void Invalidate()
		{
		}

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x0")]
		internal LinkedList<T> list;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> next;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> prev;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x0")]
		internal T item;
	}
}
