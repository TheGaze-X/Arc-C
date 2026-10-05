using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	public interface IQCShopGetResponse : IShopGetResposne
	{
		// Token: 0x060064F6 RID: 25846
		[Token(Token = "0x60064F6")]
		List<string> GetNewFlag();
	}
}
