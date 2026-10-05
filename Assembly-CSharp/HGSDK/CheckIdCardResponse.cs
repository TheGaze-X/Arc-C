using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class CheckIdCardResponse
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CheckIdCardResponse()
		{
		}

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x14")]
		public bool isMinor;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x18")]
		public string message;
	}
}
