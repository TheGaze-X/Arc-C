using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	internal class LeaseSink : System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public LeaseSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x4B7E750", Offset = "0x4B7D350", VA = "0x184B7E750", Slot = "4")]
		public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x4B7E460", Offset = "0x4B7D060", VA = "0x184B7E460", Slot = "5")]
		public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x4B7E4E0", Offset = "0x4B7D0E0", VA = "0x184B7E4E0")]
		private void RenewLease(System.Runtime.Remoting.Messaging.IMessage msg)
		{
		}

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x10")]
		private System.Runtime.Remoting.Messaging.IMessageSink _nextSink;
	}
}
