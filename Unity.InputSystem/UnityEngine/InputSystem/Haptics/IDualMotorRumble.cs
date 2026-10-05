using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Haptics
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public interface IDualMotorRumble : IHaptics
	{
		// Token: 0x06000F19 RID: 3865
		[Token(Token = "0x6000F19")]
		void SetMotorSpeeds(float lowFrequency, float highFrequency);
	}
}
