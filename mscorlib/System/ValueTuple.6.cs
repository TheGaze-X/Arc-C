using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x6000C32")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x6000C33")]
		public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5> other)
		{
			return default(bool);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x6000C34")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x6000C35")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x6000C36")]
		public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5> other)
		{
			return 0;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x6000C37")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x6000C38")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x6000C39")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x6000C3A")]
		private int GetHashCodeCore(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x6000C3B")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C3C")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C3D")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x17000106")]
		private int Length
		{
			[Token(Token = "0x6000C3E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T4 Item4;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T5 Item5;
	}
}
