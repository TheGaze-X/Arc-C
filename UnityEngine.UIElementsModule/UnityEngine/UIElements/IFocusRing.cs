using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public interface IFocusRing
	{
		// Token: 0x060000E8 RID: 232
		[Token(Token = "0x60000E8")]
		FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);

		// Token: 0x060000E9 RID: 233
		[Token(Token = "0x60000E9")]
		Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);
	}
}
