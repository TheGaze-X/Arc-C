using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public interface IInspectorRunning
	{
		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		void OnHeaderGUI();

		// Token: 0x060002A2 RID: 674
		[Token(Token = "0x60002A2")]
		void OnFooterGUI();
	}
}
