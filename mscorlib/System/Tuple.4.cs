using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	[System.Serializable]
	public class Tuple<T1, T2, T3, T4> : System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, ITupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x6000ACF")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6000AD0")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6000AD1")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x6000AD2")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x6000AD3")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x6000AD4")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000AD5")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000AD6")]
		private string ToString(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x170000C8")]
		private int Length
		{
			[Token(Token = "0x6000AD7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x0")]
		private readonly T1 m_Item1;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x0")]
		private readonly T2 m_Item2;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x0")]
		private readonly T3 m_Item3;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x0")]
		private readonly T4 m_Item4;
	}
}
