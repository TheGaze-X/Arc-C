using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public interface IInputStateChangeMonitor
	{
		// Token: 0x0600110F RID: 4367
		[Token(Token = "0x600110F")]
		void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);

		// Token: 0x06001110 RID: 4368
		[Token(Token = "0x6001110")]
		void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
	}
}
