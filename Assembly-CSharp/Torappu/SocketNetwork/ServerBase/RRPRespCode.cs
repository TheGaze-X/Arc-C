using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014C0 RID: 5312
	[Token(Token = "0x20014C0")]
	public enum RRPRespCode
	{
		// Token: 0x04007888 RID: 30856
		[Token(Token = "0x4007888")]
		SUC,
		// Token: 0x04007889 RID: 30857
		[Token(Token = "0x4007889")]
		TIME_OUT,
		// Token: 0x0400788A RID: 30858
		[Token(Token = "0x400788A")]
		NET_ERROR,
		// Token: 0x0400788B RID: 30859
		[Token(Token = "0x400788B")]
		REQ_WRONG,
		// Token: 0x0400788C RID: 30860
		[Token(Token = "0x400788C")]
		RESP_TYPE_WRONG,
		// Token: 0x0400788D RID: 30861
		[Token(Token = "0x400788D")]
		RESP_PARSE_WRONG
	}
}
