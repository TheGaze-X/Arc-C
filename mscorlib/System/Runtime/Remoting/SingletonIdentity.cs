using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	internal class SingletonIdentity : ServerIdentity
	{
		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x4B8E330", Offset = "0x4B8CF30", VA = "0x184B8E330")]
		public SingletonIdentity(string objectUri, System.Runtime.Remoting.Contexts.Context context, System.Type objectType)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x4B8E7C0", Offset = "0x4B8D3C0", VA = "0x184B8E7C0")]
		public System.MarshalByRefObject GetServerObject()
		{
			return null;
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x4B8E8E0", Offset = "0x4B8D4E0", VA = "0x184B8E8E0", Slot = "6")]
		public override System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x4B8E710", Offset = "0x4B8D310", VA = "0x184B8E710", Slot = "7")]
		public override System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}
	}
}
