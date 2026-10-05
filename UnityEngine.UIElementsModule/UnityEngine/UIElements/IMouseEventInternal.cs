using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	internal interface IMouseEventInternal
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BE5 RID: 3045
		// (set) Token: 0x06000BE6 RID: 3046
		[Token(Token = "0x170002A4")]
		bool triggeredByOS { [Token(Token = "0x6000BE5")] get; [Token(Token = "0x6000BE6")] set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BE7 RID: 3047
		// (set) Token: 0x06000BE8 RID: 3048
		[Token(Token = "0x170002A5")]
		bool recomputeTopElementUnderMouse { [Token(Token = "0x6000BE7")] get; [Token(Token = "0x6000BE8")] set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BE9 RID: 3049
		// (set) Token: 0x06000BEA RID: 3050
		[Token(Token = "0x170002A6")]
		IPointerEvent sourcePointerEvent { [Token(Token = "0x6000BE9")] get; [Token(Token = "0x6000BEA")] set; }
	}
}
