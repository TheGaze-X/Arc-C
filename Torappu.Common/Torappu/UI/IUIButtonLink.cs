using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public interface IUIButtonLink
	{
		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x60007E9")]
		bool CheckClickFunc(UIButton button);

		// Token: 0x060007EA RID: 2026
		[Token(Token = "0x60007EA")]
		void PlayAudio(UIButton.AudioModule audioInfo);
	}
}
