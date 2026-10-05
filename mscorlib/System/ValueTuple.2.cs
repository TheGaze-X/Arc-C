using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[System.Serializable]
	public struct ValueTuple<T1> : System.IEquatable<System.ValueTuple<T1>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFA")]
		public ValueTuple(T1 item1)
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x6000BFB")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x6000BFC")]
		public bool Equals(System.ValueTuple<T1> other)
		{
			return default(bool);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x6000BFD")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6000BFE")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6000BFF")]
		public int CompareTo(System.ValueTuple<T1> other)
		{
			return 0;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6000C00")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6000C01")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6000C02")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6000C03")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C04")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C05")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x17000102")]
		private int Length
		{
			[Token(Token = "0x6000C06")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x0")]
		public T1 Item1;
	}
}
