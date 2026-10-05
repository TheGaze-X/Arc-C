using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006776 RID: 26486
	[Token(Token = "0x2006776")]
	public interface IActEntry
	{
		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x06025FE8 RID: 155624
		[Token(Token = "0x170059E5")]
		string actId { [Token(Token = "0x6025FE8")] get; }

		// Token: 0x06025FE9 RID: 155625
		[Token(Token = "0x6025FE9")]
		long GetInstID();
	}
}
