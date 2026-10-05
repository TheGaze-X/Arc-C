using System;
using System.Runtime.Remoting.Proxies;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	internal class StackBuilderSink : IMessageSink
	{
		// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x4BB0870", Offset = "0x4BAF470", VA = "0x184BB0870")]
		public StackBuilderSink(System.MarshalByRefObject obj, bool forceInternalExecute)
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x4BB0740", Offset = "0x4BAF340", VA = "0x184BB0740", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x4BAFAD0", Offset = "0x4BAE6D0", VA = "0x184BAFAD0", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x4BB00C0", Offset = "0x4BAECC0", VA = "0x184BB00C0")]
		private void ExecuteAsyncMessage(object ob)
		{
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x4BAFC20", Offset = "0x4BAE820", VA = "0x184BAFC20")]
		private void CheckParameters(IMessage msg)
		{
		}

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x10")]
		private System.MarshalByRefObject _target;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x18")]
		private System.Runtime.Remoting.Proxies.RealProxy _rp;
	}
}
