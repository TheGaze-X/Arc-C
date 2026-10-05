using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Haptics;

namespace UnityEngine.InputSystem.XInput
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public interface IXboxOneRumble : IDualMotorRumble, IHaptics
	{
		// Token: 0x06000C51 RID: 3153
		[Token(Token = "0x6000C51")]
		void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger);
	}
}
