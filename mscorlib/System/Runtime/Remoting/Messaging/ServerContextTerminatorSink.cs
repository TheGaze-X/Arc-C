using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E3 RID: 995
	[Token(Token = "0x20003E3")]
	internal class ServerContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001F58 RID: 8024 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x4BAF440", Offset = "0x4BAE040", VA = "0x184BAF440", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x4BAF2B0", Offset = "0x4BADEB0", VA = "0x184BAF2B0", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ServerContextTerminatorSink()
		{
		}
	}
}
