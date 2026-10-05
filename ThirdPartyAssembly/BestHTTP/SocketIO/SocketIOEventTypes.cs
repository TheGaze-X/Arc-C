using System;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	public enum SocketIOEventTypes
	{
		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4001870")]
		Unknown = -1,
		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4001871")]
		Connect,
		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x4001872")]
		Disconnect,
		// Token: 0x04001873 RID: 6259
		[Token(Token = "0x4001873")]
		Event,
		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		Ack,
		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		Error,
		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		BinaryEvent,
		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		BinaryAck
	}
}
