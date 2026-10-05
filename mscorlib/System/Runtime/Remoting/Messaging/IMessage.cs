using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IMessage
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001EBB RID: 7867
		[Token(Token = "0x170003C9")]
		System.Collections.IDictionary Properties { [Token(Token = "0x6001EBB")] get; }
	}
}
