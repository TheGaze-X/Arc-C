using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	internal class DisposerReplySink : System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public DisposerReplySink(System.Runtime.Remoting.Messaging.IMessageSink next, System.IDisposable disposable)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x4B7C860", Offset = "0x4B7B460", VA = "0x184B7C860", Slot = "4")]
		public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x4B7C810", Offset = "0x4B7B410", VA = "0x184B7C810", Slot = "5")]
		public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x10")]
		private System.Runtime.Remoting.Messaging.IMessageSink _next;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x18")]
		private System.IDisposable _disposable;
	}
}
