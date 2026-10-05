using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	internal sealed class FastResourceComparer : System.Collections.IComparer, System.Collections.IEqualityComparer, System.Collections.Generic.IComparer<string>, System.Collections.Generic.IEqualityComparer<string>
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x4BD3C00", Offset = "0x4BD2800", VA = "0x184BD3C00", Slot = "6")]
		public int GetHashCode(object key)
		{
			return 0;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x4BD3CC0", Offset = "0x4BD28C0", VA = "0x184BD3CC0", Slot = "9")]
		public int GetHashCode(string key)
		{
			return 0;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x4BD3D50", Offset = "0x4BD2950", VA = "0x184BD3D50")]
		internal static int HashFunction(string key)
		{
			return 0;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x4BD3AA0", Offset = "0x4BD26A0", VA = "0x184BD3AA0", Slot = "4")]
		public int Compare(object a, object b)
		{
			return 0;
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x100ED90", Offset = "0x100D990", VA = "0x18100ED90", Slot = "7")]
		public int Compare(string a, string b)
		{
			return 0;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x4BD3BE0", Offset = "0x4BD27E0", VA = "0x184BD3BE0", Slot = "8")]
		public bool Equals(string a, string b)
		{
			return default(bool);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x4BD3B40", Offset = "0x4BD2740", VA = "0x184BD3B40", Slot = "5")]
		public bool Equals(object a, object b)
		{
			return default(bool);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x4BD39C0", Offset = "0x4BD25C0", VA = "0x184BD39C0")]
		public static int CompareOrdinal(string a, byte[] bytes, int bCharLength)
		{
			return 0;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x4BD3810", Offset = "0x4BD2410", VA = "0x184BD3810")]
		public static int CompareOrdinal(byte[] bytes, int aCharLength, string b)
		{
			return 0;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x4BD3910", Offset = "0x4BD2510", VA = "0x184BD3910")]
		internal unsafe static int CompareOrdinal(byte* a, int byteLen, string b)
		{
			return 0;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FastResourceComparer()
		{
		}

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly FastResourceComparer Default;
	}
}
