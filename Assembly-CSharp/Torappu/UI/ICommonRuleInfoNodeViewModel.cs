using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200374E RID: 14158
	[Token(Token = "0x200374E")]
	public interface ICommonRuleInfoNodeViewModel : IHotfixable
	{
		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x060167F1 RID: 92145
		[Token(Token = "0x170035E4")]
		ICommonRuleInfoNodeViewModel.NodeType nodeType { [Token(Token = "0x60167F1")] get; }

		// Token: 0x0200374F RID: 14159
		[Token(Token = "0x200374F")]
		public enum NodeType
		{
			// Token: 0x0401B195 RID: 110997
			[Token(Token = "0x401B195")]
			NONE,
			// Token: 0x0401B196 RID: 110998
			[Token(Token = "0x401B196")]
			SIMPLE_TITLE = 1000,
			// Token: 0x0401B197 RID: 110999
			[Token(Token = "0x401B197")]
			SIMPLE_LABEL = 2000
		}
	}
}
