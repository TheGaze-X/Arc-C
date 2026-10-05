using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Haptics;

namespace UnityEngine.InputSystem.DualShock
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public interface IDualShockHaptics : IDualMotorRumble, IHaptics
	{
		// Token: 0x06000EFF RID: 3839
		[Token(Token = "0x6000EFF")]
		void SetLightBarColor(Color color);
	}
}
