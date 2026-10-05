using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class ThreadSafeQueue<T>
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004FB")]
		public ThreadSafeQueue()
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004FC")]
		public ThreadSafeQueue(IEnumerable<T> collection)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004FD")]
		public ThreadSafeQueue(int count)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x17000063")]
		public int count
		{
			[Token(Token = "0x60004FE")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004FF")]
		public void Clear()
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x6000500")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000501")]
		public T Dequeue()
		{
			return null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000502")]
		public void Enqueue(T item)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000503")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x6000504")]
		public bool TryDequeue(out T item)
		{
			return default(bool);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x6000505")]
		public bool TryPeek(out T item)
		{
			return default(bool);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000506")]
		public T[] TakeAll()
		{
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000507")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x0")]
		private object m_syncObj;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> m_queue;
	}
}
