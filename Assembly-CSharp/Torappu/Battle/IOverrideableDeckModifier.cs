using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021EA RID: 8682
	[Token(Token = "0x20021EA")]
	public interface IOverrideableDeckModifier
	{
		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600D941 RID: 55617
		// (set) Token: 0x0600D942 RID: 55618
		[Token(Token = "0x17001ACB")]
		bool overrideValid { [Token(Token = "0x600D941")] get; [Token(Token = "0x600D942")] set; }

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600D943 RID: 55619
		[Token(Token = "0x17001ACC")]
		string overrideKey { [Token(Token = "0x600D943")] get; }

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x0600D944 RID: 55620
		[Token(Token = "0x17001ACD")]
		FP overridePriority { [Token(Token = "0x600D944")] get; }
	}
}
