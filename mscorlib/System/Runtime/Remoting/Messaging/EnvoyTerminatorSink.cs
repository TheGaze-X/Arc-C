using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003CB RID: 971
	[Token(Token = "0x20003CB")]
	[System.Serializable]
	internal class EnvoyTerminatorSink : IMessageSink
	{
		// Token: 0x06001EA6 RID: 7846 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x4B7D510", Offset = "0x4B7C110", VA = "0x184B7D510", Slot = "4")]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			return null;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x4B7D490", Offset = "0x4B7C090", VA = "0x184B7D490", Slot = "5")]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnvoyTerminatorSink()
		{
		}

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x0")]
		public static EnvoyTerminatorSink Instance;
	}
}
