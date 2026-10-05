using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	[System.Serializable]
	public class Tuple<T1, T2> : System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, ITupleInternal, System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C1")]
		public T1 Item1
		{
			[Token(Token = "0x6000AB5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C2")]
		public T2 Item2
		{
			[Token(Token = "0x6000AB6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB7")]
		public Tuple(T1 item1, T2 item2)
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x6000AB8")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x6000AB9")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x6000ABA")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x6000ABB")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x6000ABC")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x6000ABD")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ABE")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ABF")]
		private string ToString(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x170000C3")]
		private int Length
		{
			[Token(Token = "0x6000AC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x0")]
		private readonly T1 m_Item1;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x0")]
		private readonly T2 m_Item2;
	}
}
