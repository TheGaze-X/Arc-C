using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Haptics
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public interface IHaptics
	{
		// Token: 0x06000F1A RID: 3866
		[Token(Token = "0x6000F1A")]
		void PauseHaptics();

		// Token: 0x06000F1B RID: 3867
		[Token(Token = "0x6000F1B")]
		void ResumeHaptics();

		// Token: 0x06000F1C RID: 3868
		[Token(Token = "0x6000F1C")]
		void ResetHaptics();
	}
}
