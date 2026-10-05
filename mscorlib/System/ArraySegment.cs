using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[System.Reflection.DefaultMember("Item")]
	[System.Serializable]
	public readonly struct ArraySegment<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x1700005F")]
		public static System.ArraySegment<T> Empty
		{
			[Token(Token = "0x600043A")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(System.ArraySegment<T>);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		public ArraySegment(T[] array)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		public ArraySegment(T[] array, int offset, int count)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000060")]
		public T[] Array
		{
			[Token(Token = "0x600043D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x17000061")]
		public int Offset
		{
			[Token(Token = "0x600043E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x17000062")]
		public int Count
		{
			[Token(Token = "0x600043F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x6000440")]
		public System.ArraySegment<T>.Enumerator GetEnumerator()
		{
			return default(System.ArraySegment<T>.Enumerator);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x6000441")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000442")]
		public void CopyTo(T[] destination, int destinationIndex)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000443")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000444")]
		public bool Equals(System.ArraySegment<T> obj)
		{
			return default(bool);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000445")]
		public static bool operator ==(System.ArraySegment<T> a, System.ArraySegment<T> b)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000446")]
		public static implicit operator System.ArraySegment<T>(T[] array)
		{
			return default(System.ArraySegment<T>);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		private T Item
		{
			[Token(Token = "0x6000447")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000448")]
			set
			{
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000449")]
		private int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044A")]
		private void Insert(int index, T item)
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000064")]
		private T Item
		{
			[Token(Token = "0x600044C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x17000065")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600044D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044E")]
		private void Add(T item)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044F")]
		private void Clear()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000450")]
		private bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x6000451")]
		private bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000452")]
		private System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000453")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		private void ThrowInvalidOperationIfDefault()
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x0")]
		private readonly T[] _array;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _offset;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _count;

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		public struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
		{
			// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000456")]
			internal Enumerator(System.ArraySegment<T> arraySegment)
			{
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00004368 File Offset: 0x00002568
			[Token(Token = "0x6000457")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000066")]
			public T Current
			{
				[Token(Token = "0x6000458")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000067")]
			private object Current
			{
				[Token(Token = "0x6000459")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045A")]
			private void Reset()
			{
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045B")]
			public void Dispose()
			{
			}

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x0")]
			private readonly T[] _array;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _start;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _end;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x0")]
			private int _current;
		}
	}
}
