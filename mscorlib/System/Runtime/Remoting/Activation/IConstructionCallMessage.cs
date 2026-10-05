using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IConstructionCallMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
	{
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001E0E RID: 7694
		[Token(Token = "0x1700038D")]
		System.Type ActivationType { [Token(Token = "0x6001E0E")] get; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001E0F RID: 7695
		[Token(Token = "0x1700038E")]
		string ActivationTypeName { [Token(Token = "0x6001E0F")] get; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001E10 RID: 7696
		// (set) Token: 0x06001E11 RID: 7697
		[Token(Token = "0x1700038F")]
		IActivator Activator { [Token(Token = "0x6001E10")] get; [Token(Token = "0x6001E11")] set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001E12 RID: 7698
		[Token(Token = "0x17000390")]
		object[] CallSiteActivationAttributes { [Token(Token = "0x6001E12")] get; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001E13 RID: 7699
		[Token(Token = "0x17000391")]
		System.Collections.IList ContextProperties { [Token(Token = "0x6001E13")] get; }
	}
}
