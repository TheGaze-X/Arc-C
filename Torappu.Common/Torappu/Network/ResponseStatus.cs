using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	public enum ResponseStatus
	{
		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		OK,
		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		ERROR_IGNORE,
		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		ERROR_RETRY,
		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		ERROR_SYNC_DATA,
		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		ERROR_RELOGIN,
		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		ERROR_TIMEOUT,
		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		ERROR_CLIENT,
		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		CANCEL,
		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		ERROR_SECURE_SYS,
		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		ERROR_UNKNOW
	}
}
