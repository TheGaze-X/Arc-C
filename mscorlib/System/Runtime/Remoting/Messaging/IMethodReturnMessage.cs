using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D5 RID: 981
	[Token(Token = "0x20003D5")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IMethodReturnMessage : IMethodMessage, IMessage
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001EC7 RID: 7879
		[Token(Token = "0x170003D2")]
		System.Exception Exception { [Token(Token = "0x6001EC7")] get; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001EC8 RID: 7880
		[Token(Token = "0x170003D3")]
		object[] OutArgs { [Token(Token = "0x6001EC8")] get; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001EC9 RID: 7881
		[Token(Token = "0x170003D4")]
		object ReturnValue { [Token(Token = "0x6001EC9")] get; }
	}
}
