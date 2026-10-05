using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x504A250", Offset = "0x5048E50", VA = "0x18504A250", Slot = "5")]
		public int GetHashCode(object myObject)
		{
			return 0;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x5049D00", Offset = "0x5048900", VA = "0x185049D00", Slot = "6")]
		public int Compare(object firstObject, object secondObject)
		{
			return 0;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x504A160", Offset = "0x5048D60", VA = "0x18504A160")]
		private int FastGetHashCode(string myString)
		{
			return 0;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x5049E70", Offset = "0x5048A70", VA = "0x185049E70", Slot = "4")]
		public bool Equals(object firstObject, object secondObject)
		{
			return default(bool);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CaseInsensitiveAscii()
		{
		}

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly CaseInsensitiveAscii StaticInstance;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly byte[] AsciiToLower;
	}
}
