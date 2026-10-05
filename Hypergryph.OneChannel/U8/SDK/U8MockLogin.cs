using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public struct U8MockLogin
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x0")]
		public static readonly U8MockLogin EMPTY;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x0")]
		public string uid;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x8")]
		public string token;
	}
}
