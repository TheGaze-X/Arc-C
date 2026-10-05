using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	internal class CrossContextChannel : System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001DB4 RID: 7604 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x4B7C4A0", Offset = "0x4B7B0A0", VA = "0x184B7C4A0", Slot = "4")]
		public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x4B7C080", Offset = "0x4B7AC80", VA = "0x184B7C080", Slot = "5")]
		public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrossContextChannel()
		{
		}

		// Token: 0x0200038F RID: 911
		[Token(Token = "0x200038F")]
		private class ContextRestoreSink : System.Runtime.Remoting.Messaging.IMessageSink
		{
			// Token: 0x06001DB7 RID: 7607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
			public ContextRestoreSink(System.Runtime.Remoting.Messaging.IMessageSink next, Context context, System.Runtime.Remoting.Messaging.IMessage call)
			{
			}

			// Token: 0x06001DB8 RID: 7608 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0x4B78670", Offset = "0x4B77270", VA = "0x184B78670", Slot = "4")]
			public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
			{
				return null;
			}

			// Token: 0x06001DB9 RID: 7609 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001DB9")]
			[Address(RVA = "0x4B78620", Offset = "0x4B77220", VA = "0x184B78620", Slot = "5")]
			public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
			{
				return null;
			}

			// Token: 0x04000FD8 RID: 4056
			[Token(Token = "0x4000FD8")]
			[FieldOffset(Offset = "0x10")]
			private System.Runtime.Remoting.Messaging.IMessageSink _next;

			// Token: 0x04000FD9 RID: 4057
			[Token(Token = "0x4000FD9")]
			[FieldOffset(Offset = "0x18")]
			private Context _context;

			// Token: 0x04000FDA RID: 4058
			[Token(Token = "0x4000FDA")]
			[FieldOffset(Offset = "0x20")]
			private System.Runtime.Remoting.Messaging.IMessage _call;
		}
	}
}
