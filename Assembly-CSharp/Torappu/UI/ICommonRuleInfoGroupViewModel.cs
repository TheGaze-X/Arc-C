using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003750 RID: 14160
	[Token(Token = "0x2003750")]
	public interface ICommonRuleInfoGroupViewModel : ICommonRuleInfoNodeViewModel, IHotfixable
	{
		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x060167F2 RID: 92146
		// (set) Token: 0x060167F3 RID: 92147
		[Token(Token = "0x170035E5")]
		List<ICommonRuleInfoNodeViewModel> childNodes { [Token(Token = "0x60167F2")] get; [Token(Token = "0x60167F3")] set; }
	}
}
