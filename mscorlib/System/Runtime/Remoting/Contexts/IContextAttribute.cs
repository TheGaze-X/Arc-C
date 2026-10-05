using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContextAttribute
	{
		// Token: 0x06001DBC RID: 7612
		[Token(Token = "0x6001DBC")]
		void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);

		// Token: 0x06001DBD RID: 7613
		[Token(Token = "0x6001DBD")]
		bool IsContextOK(Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
	}
}
