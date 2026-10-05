using System;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	internal class ClientContextReplySink : IMessageSink
	{
		// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x4B6E740", Offset = "0x4B6D340", VA = "0x184B6E740")]
		public ClientContextReplySink(System.Runtime.Remoting.Contexts.Context ctx, IMessageSink replySink)
		{
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x4B76970", Offset = "0x4B75570", VA = "0x184B76970", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x4B76920", Offset = "0x4B75520", VA = "0x184B76920", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x10")]
		private IMessageSink _replySink;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x18")]
		private System.Runtime.Remoting.Contexts.Context _context;
	}
}
