using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000371 RID: 881
	[Token(Token = "0x2000371")]
	internal class ClientActivatedIdentity : ServerIdentity
	{
		// Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x4B768D0", Offset = "0x4B754D0", VA = "0x184B768D0")]
		public ClientActivatedIdentity(string objectUri, System.Type objectType)
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
		public System.MarshalByRefObject GetServerObject()
		{
			return null;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
		public void SetClientProxy(System.MarshalByRefObject obj)
		{
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x4B767D0", Offset = "0x4B753D0", VA = "0x184B767D0", Slot = "5")]
		public override void OnLifetimeExpired()
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x4B76830", Offset = "0x4B75430", VA = "0x184B76830", Slot = "6")]
		public override System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x4B76710", Offset = "0x4B75310", VA = "0x184B76710", Slot = "7")]
		public override System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x70")]
		private System.MarshalByRefObject _targetThis;
	}
}
