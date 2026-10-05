using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x02003368 RID: 13160
	[Token(Token = "0x2003368")]
	public interface HudPlugin : IHotfixable
	{
		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x06015008 RID: 86024
		[Token(Token = "0x170031E6")]
		HudPluginMask hudMask { [Token(Token = "0x6015008")] get; }

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x06015009 RID: 86025
		[Token(Token = "0x170031E7")]
		bool needToShow { [Token(Token = "0x6015009")] get; }

		// Token: 0x0601500A RID: 86026
		[Token(Token = "0x601500A")]
		void OnAttach(Unit owner);

		// Token: 0x0601500B RID: 86027
		[Token(Token = "0x601500B")]
		void OnDetach();

		// Token: 0x0601500C RID: 86028
		[Token(Token = "0x601500C")]
		void UpdatePlugin();
	}
}
