using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	public interface IInputStateCallbackReceiver
	{
		// Token: 0x0600110C RID: 4364
		[Token(Token = "0x600110C")]
		void OnNextUpdate();

		// Token: 0x0600110D RID: 4365
		[Token(Token = "0x600110D")]
		void OnStateEvent(InputEventPtr eventPtr);

		// Token: 0x0600110E RID: 4366
		[Token(Token = "0x600110E")]
		bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
	}
}
