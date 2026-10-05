using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Class)]
	public class ProxyAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute
	{
		// Token: 0x06001D3B RID: 7483 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x4B856D0", Offset = "0x4B842D0", VA = "0x184B856D0", Slot = "9")]
		public virtual System.MarshalByRefObject CreateInstance(System.Type serverType)
		{
			return null;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x4B85820", Offset = "0x4B84420", VA = "0x184B85820", Slot = "10")]
		public virtual RealProxy CreateProxy(ObjRef objRef, System.Type serverType, object serverObject, System.Runtime.Remoting.Contexts.Context serverContext)
		{
			return null;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
			return default(bool);
		}
	}
}
