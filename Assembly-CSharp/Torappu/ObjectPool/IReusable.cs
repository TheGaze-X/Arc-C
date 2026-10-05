using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001473 RID: 5235
	[Token(Token = "0x2001473")]
	public interface IReusable
	{
		// Token: 0x06007911 RID: 30993
		[Token(Token = "0x6007911")]
		void OnAllocate();

		// Token: 0x06007912 RID: 30994
		[Token(Token = "0x6007912")]
		void OnRecycle();
	}
}
