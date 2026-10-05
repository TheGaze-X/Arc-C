using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E52 RID: 7762
	[Token(Token = "0x2001E52")]
	public interface IAVGDataSubscriber<T> : IHotfixable
	{
		// Token: 0x0600BFEE RID: 49134
		[Token(Token = "0x600BFEE")]
		void OnValueChanged(T data);
	}
}
