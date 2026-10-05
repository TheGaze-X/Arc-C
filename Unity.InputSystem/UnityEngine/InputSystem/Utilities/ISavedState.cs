using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	internal interface ISavedState
	{
		// Token: 0x060015CD RID: 5581
		[Token(Token = "0x60015CD")]
		void StaticDisposeCurrentState();

		// Token: 0x060015CE RID: 5582
		[Token(Token = "0x60015CE")]
		void RestoreSavedState();
	}
}
