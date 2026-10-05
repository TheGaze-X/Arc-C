using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	internal interface IInternalMessage
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001EB7 RID: 7863
		// (set) Token: 0x06001EB8 RID: 7864
		[Token(Token = "0x170003C7")]
		Identity TargetIdentity { [Token(Token = "0x6001EB7")] get; [Token(Token = "0x6001EB8")] set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001EB9 RID: 7865
		// (set) Token: 0x06001EBA RID: 7866
		[Token(Token = "0x170003C8")]
		string Uri { [Token(Token = "0x6001EB9")] get; [Token(Token = "0x6001EBA")] set; }
	}
}
