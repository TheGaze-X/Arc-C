using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IActivator
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001E0C RID: 7692
		[Token(Token = "0x1700038C")]
		IActivator NextActivator { [Token(Token = "0x6001E0C")] get; }

		// Token: 0x06001E0D RID: 7693
		[Token(Token = "0x6001E0D")]
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
