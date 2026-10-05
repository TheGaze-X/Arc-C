using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	internal class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x4B8E330", Offset = "0x4B8CF30", VA = "0x184B8E330")]
		public SingleCallIdentity(string objectUri, System.Runtime.Remoting.Contexts.Context context, System.Type objectType)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x4B8E550", Offset = "0x4B8D150", VA = "0x184B8E550", Slot = "6")]
		public override System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x4B8E380", Offset = "0x4B8CF80", VA = "0x184B8E380", Slot = "7")]
		public override System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}
	}
}
