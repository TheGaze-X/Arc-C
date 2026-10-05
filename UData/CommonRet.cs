using System;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class CommonRet
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonRet()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public ResultCode R_CODE;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
