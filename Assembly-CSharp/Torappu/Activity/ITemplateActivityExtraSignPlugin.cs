using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006DBA RID: 28090
	[Token(Token = "0x2006DBA")]
	public interface ITemplateActivityExtraSignPlugin : IHotfixable
	{
		// Token: 0x06027FF5 RID: 163829
		[Token(Token = "0x6027FF5")]
		void InitPlugin(ExtraSignPluginOptions options);

		// Token: 0x06027FF6 RID: 163830
		[Token(Token = "0x6027FF6")]
		void RefreshPlugin();
	}
}
