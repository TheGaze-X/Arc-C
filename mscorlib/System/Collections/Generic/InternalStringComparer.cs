using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	[System.Serializable]
	internal sealed class InternalStringComparer : EqualityComparer<string>
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x00019EC0 File Offset: 0x000180C0
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x3E79600", Offset = "0x3E78200", VA = "0x183E79600", Slot = "9")]
		public override int GetHashCode(string obj)
		{
			return 0;
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00019ED8 File Offset: 0x000180D8
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x4C66F20", Offset = "0x4C65B20", VA = "0x184C66F20", Slot = "8")]
		public override bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00019EF0 File Offset: 0x000180F0
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x4C66F50", Offset = "0x4C65B50", VA = "0x184C66F50", Slot = "10")]
		internal override int IndexOf(string[] array, string value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x4C66FE0", Offset = "0x4C65BE0", VA = "0x184C66FE0")]
		public InternalStringComparer()
		{
		}
	}
}
