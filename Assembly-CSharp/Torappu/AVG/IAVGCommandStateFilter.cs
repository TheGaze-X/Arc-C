using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E50 RID: 7760
	[Token(Token = "0x2001E50")]
	public interface IAVGCommandStateFilter : IHotfixable
	{
		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x0600BFEB RID: 49131
		[Token(Token = "0x17001731")]
		string CommandName { [Token(Token = "0x600BFEB")] get; }

		// Token: 0x0600BFEC RID: 49132
		[Token(Token = "0x600BFEC")]
		void Apply(Command cmd, AVGContextStateBuilder builder);
	}
}
