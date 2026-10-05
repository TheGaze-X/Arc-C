using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.Connections
{
	// Token: 0x020014CF RID: 5327
	[Token(Token = "0x20014CF")]
	public enum ConnectionState
	{
		// Token: 0x04007916 RID: 30998
		[Token(Token = "0x4007916")]
		NOT_EXIST_STATE = -1,
		// Token: 0x04007917 RID: 30999
		[Token(Token = "0x4007917")]
		NULL,
		// Token: 0x04007918 RID: 31000
		[Token(Token = "0x4007918")]
		CONNECTING,
		// Token: 0x04007919 RID: 31001
		[Token(Token = "0x4007919")]
		CONNECTED,
		// Token: 0x0400791A RID: 31002
		[Token(Token = "0x400791A")]
		CONNECT_FAILED,
		// Token: 0x0400791B RID: 31003
		[Token(Token = "0x400791B")]
		FAILED,
		// Token: 0x0400791C RID: 31004
		[Token(Token = "0x400791C")]
		ERROR
	}
}
