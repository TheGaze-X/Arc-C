using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public interface ITextInputReceiver
	{
		// Token: 0x06000F76 RID: 3958
		[Token(Token = "0x6000F76")]
		void OnTextInput(char character);

		// Token: 0x06000F77 RID: 3959
		[Token(Token = "0x6000F77")]
		void OnIMECompositionChanged(IMECompositionString compositionString);
	}
}
