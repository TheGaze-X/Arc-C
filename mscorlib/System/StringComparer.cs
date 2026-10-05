using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[System.Serializable]
	public abstract class StringComparer : System.Collections.IComparer, System.Collections.IEqualityComparer, System.Collections.Generic.IComparer<string>, System.Collections.Generic.IEqualityComparer<string>
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000B1")]
		public static System.StringComparer InvariantCultureIgnoreCase
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x4CFD630", Offset = "0x4CFC230", VA = "0x184CFD630")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000B2")]
		public static System.StringComparer Ordinal
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x4CFD6D0", Offset = "0x4CFC2D0", VA = "0x184CFD6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000B3")]
		public static System.StringComparer OrdinalIgnoreCase
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x4CFD680", Offset = "0x4CFC280", VA = "0x184CFD680")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x4CFD050", Offset = "0x4CFBC50", VA = "0x184CFD050", Slot = "4")]
		public int Compare(object x, object y)
		{
			return 0;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x4CFD1E0", Offset = "0x4CFBDE0", VA = "0x184CFD1E0", Slot = "5")]
		public bool Equals(object x, object y)
		{
			return default(bool);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x4CFD2E0", Offset = "0x4CFBEE0", VA = "0x184CFD2E0", Slot = "6")]
		public int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x06000A50 RID: 2640
		[Token(Token = "0x6000A50")]
		public abstract int Compare(string x, string y);

		// Token: 0x06000A51 RID: 2641
		[Token(Token = "0x6000A51")]
		public abstract bool Equals(string x, string y);

		// Token: 0x06000A52 RID: 2642
		[Token(Token = "0x6000A52")]
		public abstract int GetHashCode(string obj);

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected StringComparer()
		{
		}

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.CultureAwareComparer s_invariantCulture;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x8")]
		private static readonly System.CultureAwareComparer s_invariantCultureIgnoreCase;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x10")]
		private static readonly OrdinalCaseSensitiveComparer s_ordinal;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x18")]
		private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase;
	}
}
