using System;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	public interface IIdentity
	{
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001C01 RID: 7169
		[Token(Token = "0x17000323")]
		string Name { [Token(Token = "0x6001C01")] get; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001C02 RID: 7170
		[Token(Token = "0x17000324")]
		string AuthenticationType { [Token(Token = "0x6001C02")] get; }
	}
}
