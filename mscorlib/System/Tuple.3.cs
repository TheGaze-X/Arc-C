using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	[System.Serializable]
	public class Tuple<T1, T2, T3> : System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, ITupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C4")]
		public T1 Item1
		{
			[Token(Token = "0x6000AC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C5")]
		public T2 Item2
		{
			[Token(Token = "0x6000AC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C6")]
		public T3 Item3
		{
			[Token(Token = "0x6000AC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		public Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x6000AC5")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6000AC6")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6000AC7")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x6000AC8")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x6000AC9")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x6000ACA")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ACB")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ACC")]
		private string ToString(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x170000C7")]
		private int Length
		{
			[Token(Token = "0x6000ACD")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x0")]
		private readonly T1 m_Item1;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x0")]
		private readonly T2 m_Item2;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x0")]
		private readonly T3 m_Item3;
	}
}
