using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public interface IPanel : IDisposable
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000178 RID: 376
		[Token(Token = "0x17000048")]
		VisualElement visualTree { [Token(Token = "0x6000178")] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000179 RID: 377
		[Token(Token = "0x17000049")]
		EventDispatcher dispatcher { [Token(Token = "0x6000179")] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600017A RID: 378
		[Token(Token = "0x1700004A")]
		ContextType contextType { [Token(Token = "0x600017A")] get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017B RID: 379
		[Token(Token = "0x1700004B")]
		FocusController focusController { [Token(Token = "0x600017B")] get; }

		// Token: 0x0600017C RID: 380
		[Token(Token = "0x600017C")]
		VisualElement Pick(Vector2 point);
	}
}
