using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public interface IBindable
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007A1 RID: 1953
		[Token(Token = "0x1700019C")]
		IBinding binding { [Token(Token = "0x60007A1")] get; }

		// Token: 0x1700019D RID: 413
		// (set) Token: 0x060007A2 RID: 1954
		[Token(Token = "0x1700019D")]
		string bindingPath { [Token(Token = "0x60007A2")] set; }
	}
}
