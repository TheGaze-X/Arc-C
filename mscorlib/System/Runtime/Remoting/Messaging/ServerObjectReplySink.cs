using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	internal class ServerObjectReplySink : IMessageSink
	{
		// Token: 0x06001F5E RID: 8030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x4B6E740", Offset = "0x4B6D340", VA = "0x184B6E740")]
		public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
		{
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x4BAF6A0", Offset = "0x4BAE2A0", VA = "0x184BAF6A0", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x4BAF650", Offset = "0x4BAE250", VA = "0x184BAF650", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x10")]
		private IMessageSink _replySink;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x18")]
		private ServerIdentity _identity;
	}
}
