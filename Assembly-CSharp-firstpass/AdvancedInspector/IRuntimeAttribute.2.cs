using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public interface IRuntimeAttribute
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002AC RID: 684
		[Token(Token = "0x17000097")]
		string MethodName { [Token(Token = "0x60002AC")] get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002AD RID: 685
		[Token(Token = "0x17000098")]
		Type Template { [Token(Token = "0x60002AD")] get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002AE RID: 686
		[Token(Token = "0x17000099")]
		Type TemplateStatic { [Token(Token = "0x60002AE")] get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002AF RID: 687
		// (set) Token: 0x060002B0 RID: 688
		[Token(Token = "0x1700009A")]
		List<Delegate> Delegates { [Token(Token = "0x60002AF")] get; [Token(Token = "0x60002B0")] set; }
	}
}
