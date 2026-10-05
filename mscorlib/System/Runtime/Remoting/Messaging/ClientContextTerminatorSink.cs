using System;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	internal class ClientContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001E87 RID: 7815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ClientContextTerminatorSink(System.Runtime.Remoting.Contexts.Context ctx)
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x4B76CE0", Offset = "0x4B758E0", VA = "0x184B76CE0", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x4B76A30", Offset = "0x4B75630", VA = "0x184B76A30", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x10")]
		private System.Runtime.Remoting.Contexts.Context _context;
	}
}
