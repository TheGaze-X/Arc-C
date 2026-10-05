using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public interface IKeyboardEvent
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000BAE RID: 2990
		[Token(Token = "0x1700028B")]
		EventModifiers modifiers { [Token(Token = "0x6000BAE")] get; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000BAF RID: 2991
		[Token(Token = "0x1700028C")]
		char character { [Token(Token = "0x6000BAF")] get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000BB0 RID: 2992
		[Token(Token = "0x1700028D")]
		KeyCode keyCode { [Token(Token = "0x6000BB0")] get; }
	}
}
