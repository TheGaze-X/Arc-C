using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public interface IMouseEvent
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000BDA RID: 3034
		[Token(Token = "0x17000299")]
		EventModifiers modifiers { [Token(Token = "0x6000BDA")] get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000BDB RID: 3035
		[Token(Token = "0x1700029A")]
		Vector2 mousePosition { [Token(Token = "0x6000BDB")] get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000BDC RID: 3036
		[Token(Token = "0x1700029B")]
		Vector2 localMousePosition { [Token(Token = "0x6000BDC")] get; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000BDD RID: 3037
		[Token(Token = "0x1700029C")]
		Vector2 mouseDelta { [Token(Token = "0x6000BDD")] get; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BDE RID: 3038
		[Token(Token = "0x1700029D")]
		int clickCount { [Token(Token = "0x6000BDE")] get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000BDF RID: 3039
		[Token(Token = "0x1700029E")]
		int button { [Token(Token = "0x6000BDF")] get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000BE0 RID: 3040
		[Token(Token = "0x1700029F")]
		int pressedButtons { [Token(Token = "0x6000BE0")] get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000BE1 RID: 3041
		[Token(Token = "0x170002A0")]
		bool shiftKey { [Token(Token = "0x6000BE1")] get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BE2 RID: 3042
		[Token(Token = "0x170002A1")]
		bool ctrlKey { [Token(Token = "0x6000BE2")] get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BE3 RID: 3043
		[Token(Token = "0x170002A2")]
		bool commandKey { [Token(Token = "0x6000BE3")] get; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BE4 RID: 3044
		[Token(Token = "0x170002A3")]
		bool altKey { [Token(Token = "0x6000BE4")] get; }
	}
}
