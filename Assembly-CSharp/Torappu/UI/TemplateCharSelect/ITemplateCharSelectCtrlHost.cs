using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BF2 RID: 23538
	[Token(Token = "0x2005BF2")]
	public interface ITemplateCharSelectCtrlHost
	{
		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x060221F0 RID: 139760
		[Token(Token = "0x17004FE0")]
		TemplateCharSelectMainProperty prop { [Token(Token = "0x60221F0")] get; }

		// Token: 0x060221F1 RID: 139761
		[Token(Token = "0x60221F1")]
		void Ensure();

		// Token: 0x060221F2 RID: 139762
		[Token(Token = "0x60221F2")]
		void Cancel();
	}
}
