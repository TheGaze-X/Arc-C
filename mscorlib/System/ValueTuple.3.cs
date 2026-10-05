using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	[System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2> : System.IEquatable<System.ValueTuple<T1, T2>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		public ValueTuple(T1 item1, T2 item2)
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6000C08")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x6000C09")]
		public bool Equals(System.ValueTuple<T1, T2> other)
		{
			return default(bool);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x6000C0A")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6000C0B")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6000C0C")]
		public int CompareTo(System.ValueTuple<T1, T2> other)
		{
			return 0;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x6000C0D")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x6000C0E")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x6000C0F")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x6000C10")]
		private int GetHashCodeCore(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x6000C11")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C12")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C13")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x17000103")]
		private int Length
		{
			[Token(Token = "0x6000C14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 Item2;
	}
}
