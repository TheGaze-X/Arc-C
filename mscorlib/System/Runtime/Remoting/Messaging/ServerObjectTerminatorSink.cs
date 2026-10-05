using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	internal class ServerObjectTerminatorSink : IMessageSink
	{
		// Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ServerObjectTerminatorSink(IMessageSink nextSink)
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x4BAF970", Offset = "0x4BAE570", VA = "0x184BAF970", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x4BAF720", Offset = "0x4BAE320", VA = "0x184BAF720", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x10")]
		private IMessageSink _nextSink;
	}
}
