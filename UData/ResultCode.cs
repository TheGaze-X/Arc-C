using System;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public enum ResultCode
	{
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		Unknown = -1,
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		OK,
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		IP_BLOCKED = 100120,
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		UID_BLOCKED = 100130,
		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		HTTPERROR = 100404,
		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		ERROOR_PARAMS = 100600,
		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		INIT_FAILED = 100230
	}
}
