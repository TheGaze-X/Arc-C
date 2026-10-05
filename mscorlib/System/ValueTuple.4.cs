using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	[System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3> : System.IEquatable<System.ValueTuple<T1, T2, T3>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C15")]
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x6000C16")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x6000C17")]
		public bool Equals(System.ValueTuple<T1, T2, T3> other)
		{
			return default(bool);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x6000C18")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x6000C19")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x6000C1A")]
		public int CompareTo(System.ValueTuple<T1, T2, T3> other)
		{
			return 0;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x6000C1B")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x6000C1C")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x6000C1D")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x6000C1E")]
		private int GetHashCodeCore(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x6000C1F")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C20")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C21")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x17000104")]
		private int Length
		{
			[Token(Token = "0x6000C22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T3 Item3;
	}
}
