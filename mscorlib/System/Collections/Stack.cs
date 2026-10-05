using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(Stack.StackDebugView))]
	[System.Serializable]
	public class Stack : ICollection, IEnumerable, System.ICloneable
	{
		// Token: 0x06002C80 RID: 11392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C80")]
		[Address(RVA = "0x4C70110", Offset = "0x4C6ED10", VA = "0x184C70110")]
		public Stack()
		{
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x4C70030", Offset = "0x4C6EC30", VA = "0x184C70030")]
		public Stack(int initialCapacity)
		{
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x00018630 File Offset: 0x00016830
		[Token(Token = "0x17000707")]
		public virtual int Count
		{
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x17000708")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000709")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x4C70170", Offset = "0x4C6ED70", VA = "0x184C70170", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C85")]
		[Address(RVA = "0x43FCA80", Offset = "0x43FB680", VA = "0x1843FCA80", Slot = "13")]
		public virtual void Clear()
		{
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C86")]
		[Address(RVA = "0x4C6F8D0", Offset = "0x4C6E4D0", VA = "0x184C6F8D0", Slot = "14")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x4C6FA20", Offset = "0x4C6E620", VA = "0x184C6FA20", Slot = "15")]
		public virtual void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x4C6FD20", Offset = "0x4C6E920", VA = "0x184C6FD20", Slot = "16")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x4C6FDC0", Offset = "0x4C6E9C0", VA = "0x184C6FDC0", Slot = "17")]
		public virtual object Peek()
		{
			return null;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x4C6FE50", Offset = "0x4C6EA50", VA = "0x184C6FE50", Slot = "18")]
		public virtual object Pop()
		{
			return null;
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x4C6FF10", Offset = "0x4C6EB10", VA = "0x184C6FF10", Slot = "19")]
		public virtual void Push(object obj)
		{
		}

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		[FieldOffset(Offset = "0x10")]
		private object[] _array;

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x18")]
		private int _size;

		// Token: 0x040019B3 RID: 6579
		[Token(Token = "0x40019B3")]
		[FieldOffset(Offset = "0x1C")]
		private int _version;

		// Token: 0x040019B4 RID: 6580
		[Token(Token = "0x40019B4")]
		[FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x040019B5 RID: 6581
		[Token(Token = "0x40019B5")]
		private const int _defaultCapacity = 10;

		// Token: 0x020005D7 RID: 1495
		[Token(Token = "0x20005D7")]
		[System.Serializable]
		private class StackEnumerator : IEnumerator, System.ICloneable
		{
			// Token: 0x06002C8C RID: 11404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C8C")]
			[Address(RVA = "0x4C6DBE0", Offset = "0x4C6C7E0", VA = "0x184C6DBE0")]
			internal StackEnumerator(Stack stack)
			{
			}

			// Token: 0x06002C8D RID: 11405 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C8D")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "7")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x00018660 File Offset: 0x00016860
			[Token(Token = "0x6002C8E")]
			[Address(RVA = "0x4C6DA30", Offset = "0x4C6C630", VA = "0x184C6DA30", Slot = "8")]
			public virtual bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700070A")]
			public virtual object Current
			{
				[Token(Token = "0x6002C8F")]
				[Address(RVA = "0x4C6DC50", Offset = "0x4C6C850", VA = "0x184C6DC50", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C90 RID: 11408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C90")]
			[Address(RVA = "0x4C6DB40", Offset = "0x4C6C740", VA = "0x184C6DB40", Slot = "10")]
			public virtual void Reset()
			{
			}

			// Token: 0x040019B6 RID: 6582
			[Token(Token = "0x40019B6")]
			[FieldOffset(Offset = "0x10")]
			private Stack _stack;

			// Token: 0x040019B7 RID: 6583
			[Token(Token = "0x40019B7")]
			[FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x040019B8 RID: 6584
			[Token(Token = "0x40019B8")]
			[FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x040019B9 RID: 6585
			[Token(Token = "0x40019B9")]
			[FieldOffset(Offset = "0x20")]
			private object _currentElement;
		}

		// Token: 0x020005D8 RID: 1496
		[Token(Token = "0x20005D8")]
		internal class StackDebugView
		{
		}
	}
}
