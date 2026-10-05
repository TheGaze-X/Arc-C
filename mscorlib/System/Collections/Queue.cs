using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
	[System.Serializable]
	public class Queue : ICollection, IEnumerable, System.ICloneable
	{
		// Token: 0x06002C03 RID: 11267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x4C6A2E0", Offset = "0x4C68EE0", VA = "0x184C6A2E0")]
		public Queue()
		{
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x4C6A2D0", Offset = "0x4C68ED0", VA = "0x184C6A2D0")]
		public Queue(int capacity)
		{
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x4C69E70", Offset = "0x4C68A70", VA = "0x184C69E70")]
		public Queue(int capacity, float growFactor)
		{
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x4C6A040", Offset = "0x4C68C40", VA = "0x184C6A040")]
		public Queue(ICollection col)
		{
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000182B8 File Offset: 0x000164B8
		[Token(Token = "0x170006E0")]
		public virtual int Count
		{
			[Token(Token = "0x6002C07")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x4C695C0", Offset = "0x4C681C0", VA = "0x184C695C0", Slot = "11")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000182D0 File Offset: 0x000164D0
		[Token(Token = "0x170006E1")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x6002C09")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006E2")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x6002C0A")]
			[Address(RVA = "0x4C6A300", Offset = "0x4C68F00", VA = "0x184C6A300", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x4C696C0", Offset = "0x4C682C0", VA = "0x184C696C0", Slot = "14")]
		public virtual void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x4C69A20", Offset = "0x4C68620", VA = "0x184C69A20", Slot = "15")]
		public virtual void Enqueue(object obj)
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x4C69C20", Offset = "0x4C68820", VA = "0x184C69C20", Slot = "16")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x4C69920", Offset = "0x4C68520", VA = "0x184C69920", Slot = "17")]
		public virtual object Dequeue()
		{
			return null;
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x4C69CE0", Offset = "0x4C688E0", VA = "0x184C69CE0", Slot = "18")]
		public virtual object Peek()
		{
			return null;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x4C69BE0", Offset = "0x4C687E0", VA = "0x184C69BE0")]
		internal object GetElement(int i)
		{
			return null;
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x4C69D90", Offset = "0x4C68990", VA = "0x184C69D90")]
		private void SetCapacity(int capacity)
		{
		}

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x10")]
		private object[] _array;

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x18")]
		private int _head;

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x1C")]
		private int _tail;

		// Token: 0x04001993 RID: 6547
		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x20")]
		private int _size;

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x24")]
		private int _growFactor;

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x28")]
		private int _version;

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x020005CD RID: 1485
		[Token(Token = "0x20005CD")]
		[System.Serializable]
		private class QueueEnumerator : IEnumerator, System.ICloneable
		{
			// Token: 0x06002C12 RID: 11282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C12")]
			[Address(RVA = "0x4C69470", Offset = "0x4C68070", VA = "0x184C69470")]
			internal QueueEnumerator(Queue q)
			{
			}

			// Token: 0x06002C13 RID: 11283 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C13")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "7")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x06002C14 RID: 11284 RVA: 0x000182E8 File Offset: 0x000164E8
			[Token(Token = "0x6002C14")]
			[Address(RVA = "0x4C692D0", Offset = "0x4C67ED0", VA = "0x184C692D0", Slot = "8")]
			public virtual bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006E3")]
			public virtual object Current
			{
				[Token(Token = "0x6002C15")]
				[Address(RVA = "0x4C694F0", Offset = "0x4C680F0", VA = "0x184C694F0", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C16")]
			[Address(RVA = "0x4C693C0", Offset = "0x4C67FC0", VA = "0x184C693C0", Slot = "10")]
			public virtual void Reset()
			{
			}

			// Token: 0x04001997 RID: 6551
			[Token(Token = "0x4001997")]
			[FieldOffset(Offset = "0x10")]
			private Queue _q;

			// Token: 0x04001998 RID: 6552
			[Token(Token = "0x4001998")]
			[FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x04001999 RID: 6553
			[Token(Token = "0x4001999")]
			[FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x0400199A RID: 6554
			[Token(Token = "0x400199A")]
			[FieldOffset(Offset = "0x20")]
			private object _currentElement;
		}

		// Token: 0x020005CE RID: 1486
		[Token(Token = "0x20005CE")]
		internal class QueueDebugView
		{
		}
	}
}
