using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	internal abstract class ServerIdentity : Identity
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x4B8E330", Offset = "0x4B8CF30", VA = "0x184B8E330")]
		public ServerIdentity(string objectUri, System.Runtime.Remoting.Contexts.Context context, System.Type objectType)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000350")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001CF6")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x4B8DF90", Offset = "0x4B8CB90", VA = "0x184B8DF90")]
		public void StartTrackingLifetime(System.Runtime.Remoting.Lifetime.ILease lease)
		{
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x4B8DF80", Offset = "0x4B8CB80", VA = "0x184B8DF80", Slot = "5")]
		public virtual void OnLifetimeExpired()
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x4B8DCA0", Offset = "0x4B8C8A0", VA = "0x184B8DCA0", Slot = "4")]
		public override ObjRef CreateObjRef(System.Type requestedType)
		{
			return null;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x4B8DC20", Offset = "0x4B8C820", VA = "0x184B8DC20")]
		public void AttachServerObject(System.MarshalByRefObject serverObject, System.Runtime.Remoting.Contexts.Context context)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000351")]
		public Lease Lease
		{
			[Token(Token = "0x6001CFB")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public System.Runtime.Remoting.Contexts.Context Context
		{
			[Token(Token = "0x6001CFC")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x06001CFE RID: 7422
		[Token(Token = "0x6001CFE")]
		public abstract System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg);

		// Token: 0x06001CFF RID: 7423
		[Token(Token = "0x6001CFF")]
		public abstract System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink);

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x4B8DEE0", Offset = "0x4B8CAE0", VA = "0x184B8DEE0")]
		protected void DisposeServerObject()
		{
		}

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x48")]
		protected System.Type _objectType;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x50")]
		protected System.MarshalByRefObject _serverObject;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x58")]
		protected System.Runtime.Remoting.Messaging.IMessageSink _serverSink;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x60")]
		protected System.Runtime.Remoting.Contexts.Context _context;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x68")]
		protected Lease _lease;
	}
}
