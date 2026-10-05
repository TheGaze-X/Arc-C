using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	[System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4> : System.IEquatable<System.ValueTuple<T1, T2, T3, T4>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C23")]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x6000C24")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x6000C25")]
		public bool Equals(System.ValueTuple<T1, T2, T3, T4> other)
		{
			return default(bool);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x6000C26")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x6000C27")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x6000C28")]
		public int CompareTo(System.ValueTuple<T1, T2, T3, T4> other)
		{
			return 0;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x6000C29")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x6000C2A")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x6000C2B")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6000C2C")]
		private int GetHashCodeCore(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x6000C2D")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C2E")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C2F")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x17000105")]
		private int Length
		{
			[Token(Token = "0x6000C30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T4 Item4;
	}
}
