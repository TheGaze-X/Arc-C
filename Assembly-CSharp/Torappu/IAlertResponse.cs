using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	public interface IAlertResponse
	{
		// Token: 0x06006242 RID: 25154
		[Token(Token = "0x6006242")]
		List<ServiceAlertStruct> GetAlert();
	}
}
