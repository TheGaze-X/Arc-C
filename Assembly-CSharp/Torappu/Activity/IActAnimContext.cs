using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D49 RID: 27977
	[Token(Token = "0x2006D49")]
	public interface IActAnimContext
	{
		// Token: 0x06027E0D RID: 163341
		[Token(Token = "0x6027E0D")]
		bool CanSkipAnim();

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x06027E0E RID: 163342
		[Token(Token = "0x17005E56")]
		float animDuration { [Token(Token = "0x6027E0E")] get; }
	}
}
