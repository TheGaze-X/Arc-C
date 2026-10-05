using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x02000380 RID: 896
	[Token(Token = "0x2000380")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public abstract class RealProxy
	{
		// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0xED4B00", Offset = "0xED3700", VA = "0x180ED4B00")]
		protected RealProxy()
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x4B87460", Offset = "0x4B86060", VA = "0x184B87460")]
		protected RealProxy(System.Type classToProxy)
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x4B87280", Offset = "0x4B85E80", VA = "0x184B87280")]
		internal RealProxy(System.Type classToProxy, ClientIdentity identity)
		{
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x4B87300", Offset = "0x4B85F00", VA = "0x184B87300")]
		protected RealProxy(System.Type classToProxy, System.IntPtr stub, object stubData)
		{
		}

		// Token: 0x06001D4A RID: 7498
		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x4B85D50", Offset = "0x4B84950", VA = "0x184B85D50")]
		[MethodImpl(4096)]
		private static extern System.Type InternalGetProxyType(object transparentProxy);

		// Token: 0x06001D4B RID: 7499 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x4B85B50", Offset = "0x4B84750", VA = "0x184B85B50")]
		public System.Type GetProxiedType()
		{
			return null;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x4B85AE0", Offset = "0x4B846E0", VA = "0x184B85AE0", Slot = "4")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		internal Identity ObjectIdentity
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x06001D4F RID: 7503
		[Token(Token = "0x6001D4F")]
		public abstract System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage msg);

		// Token: 0x06001D50 RID: 7504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x4B85D70", Offset = "0x4B84970", VA = "0x184B85D70")]
		internal static object PrivateInvoke(RealProxy rp, System.Runtime.Remoting.Messaging.IMessage msg, out System.Exception exc, out object[] out_args)
		{
			return null;
		}

		// Token: 0x06001D51 RID: 7505
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x4B85D60", Offset = "0x4B84960", VA = "0x184B85D60", Slot = "6")]
		[MethodImpl(4096)]
		internal virtual extern object InternalGetTransparentProxy(string className);

		// Token: 0x06001D52 RID: 7506 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x4B85BF0", Offset = "0x4B847F0", VA = "0x184B85BF0", Slot = "7")]
		public virtual object GetTransparentProxy()
		{
			return null;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		protected void AttachServer(System.MarshalByRefObject s)
		{
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
		internal void SetTargetDomain(int domainId)
		{
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x4B85980", Offset = "0x4B84580", VA = "0x184B85980")]
		internal object GetAppDomainTarget()
		{
			return null;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x4B86C80", Offset = "0x4B85880", VA = "0x184B86C80")]
		private static object[] ProcessResponse(System.Runtime.Remoting.Messaging.IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			return null;
		}

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Type class_to_proxy;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal System.Runtime.Remoting.Contexts.Context _targetContext;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal System.MarshalByRefObject _server;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _targetDomainId;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string _targetUri;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Identity _objectIdentity;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _objTP;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object _stubData;
	}
}
