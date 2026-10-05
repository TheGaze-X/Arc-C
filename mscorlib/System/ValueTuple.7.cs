using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	[System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, System.Collections.IStructuralEquatable, System.Collections.IStructuralComparable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, System.Runtime.CompilerServices.ITuple where TRest : struct
	{
		// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3F")]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x6000C40")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6000C41")]
		public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			return default(bool);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x6000C42")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x6000C43")]
		private int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x6000C44")]
		public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			return 0;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x6000C45")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x6000C46")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x6000C47")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x6000C48")]
		private int GetHashCodeCore(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x6000C49")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C4A")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C4B")]
		private string ToStringEnd()
		{
			return null;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x17000107")]
		private int Length
		{
			[Token(Token = "0x6000C4C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T4 Item4;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T5 Item5;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T6 Item6;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T7 Item7;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TRest Rest;
	}
}
