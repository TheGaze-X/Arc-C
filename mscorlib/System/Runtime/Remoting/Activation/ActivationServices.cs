using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	internal class ActivationServices
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000388")]
		private static IActivator ConstructionActivator
		{
			[Token(Token = "0x6001DFB")]
			[Address(RVA = "0x4B6DF80", Offset = "0x4B6CB80", VA = "0x184B6DF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x4B6CF50", Offset = "0x4B6BB50", VA = "0x184B6CF50")]
		public static System.Runtime.Remoting.Messaging.IMessage Activate(RemotingProxy proxy, System.Runtime.Remoting.Messaging.ConstructionCall ctorCall)
		{
			return null;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x4B6DEC0", Offset = "0x4B6CAC0", VA = "0x184B6DEC0")]
		public static System.Runtime.Remoting.Messaging.IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			return null;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x4B6D120", Offset = "0x4B6BD20", VA = "0x184B6D120")]
		public static System.Runtime.Remoting.Messaging.ConstructionCall CreateConstructionCall(System.Type type, string activationUrl, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x4B6DA80", Offset = "0x4B6C680", VA = "0x184B6DA80")]
		public static System.Runtime.Remoting.Messaging.IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			return null;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x4B6DB80", Offset = "0x4B6C780", VA = "0x184B6DB80")]
		public static object CreateProxyForType(System.Type type)
		{
			return null;
		}

		// Token: 0x06001E01 RID: 7681
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x4B6D110", Offset = "0x4B6BD10", VA = "0x184B6D110")]
		[MethodImpl(4096)]
		public static extern object AllocateUninitializedClassInstance(System.Type type);

		// Token: 0x06001E02 RID: 7682
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x4B6DEB0", Offset = "0x4B6CAB0", VA = "0x184B6DEB0")]
		[MethodImpl(4096)]
		public static extern void EnableProxyActivation(System.Type type, bool enable);

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x0")]
		private static IActivator _constructionActivator;
	}
}
