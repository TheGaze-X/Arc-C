using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	internal class RemotingProxy : RealProxy, IRemotingTypeInfo
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x4B88A50", Offset = "0x4B87650", VA = "0x184B88A50")]
		internal RemotingProxy(System.Type type, ClientIdentity identity)
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x4B88B10", Offset = "0x4B87710", VA = "0x184B88B10")]
		internal RemotingProxy(System.Type type, string activationUrl, object[] activationAttributes)
		{
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x4B884F0", Offset = "0x4B870F0", VA = "0x184B884F0", Slot = "5")]
		public override System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage request)
		{
			return null;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x4B87C20", Offset = "0x4B86820", VA = "0x184B87C20")]
		internal void AttachIdentity(Identity identity)
		{
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x4B87B30", Offset = "0x4B86730", VA = "0x184B87B30")]
		internal System.Runtime.Remoting.Messaging.IMessage ActivateRemoteObject(System.Runtime.Remoting.Messaging.IMethodMessage request)
		{
			return null;
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000362")]
		public string TypeName
		{
			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0x4B88BB0", Offset = "0x4B877B0", VA = "0x184B88BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x4B88110", Offset = "0x4B86D10", VA = "0x184B88110", Slot = "9")]
		public bool CanCastTo(System.Type fromType, object o)
		{
			return default(bool);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x4B883F0", Offset = "0x4B86FF0", VA = "0x184B883F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x0")]
		private static System.Reflection.MethodInfo _cache_GetTypeMethod;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x8")]
		private static System.Reflection.MethodInfo _cache_GetHashCodeMethod;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x50")]
		private System.Runtime.Remoting.Messaging.IMessageSink _sink;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x58")]
		private bool _hasEnvoySink;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x60")]
		private System.Runtime.Remoting.Messaging.ConstructionCall _ctorCall;
	}
}
