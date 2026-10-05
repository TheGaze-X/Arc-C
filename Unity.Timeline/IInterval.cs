using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	internal interface IInterval
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600023E RID: 574
		[Token(Token = "0x1700009F")]
		long intervalStart { [Token(Token = "0x600023E")] get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600023F RID: 575
		[Token(Token = "0x170000A0")]
		long intervalEnd { [Token(Token = "0x600023F")] get; }
	}
}
