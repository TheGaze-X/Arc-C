using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	internal class AsyncRequest
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0x4B6E740", Offset = "0x4B6D340", VA = "0x184B6E740")]
		public AsyncRequest(System.Runtime.Remoting.Messaging.IMessage msgRequest, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
		}

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x10")]
		internal System.Runtime.Remoting.Messaging.IMessageSink ReplySink;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x18")]
		internal System.Runtime.Remoting.Messaging.IMessage MsgRequest;
	}
}
