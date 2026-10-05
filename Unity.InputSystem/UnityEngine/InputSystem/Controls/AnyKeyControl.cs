using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	[InputControlLayout(hideInUI = true)]
	public class AnyKeyControl : ButtonControl
	{
		// Token: 0x0600135D RID: 4957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x55FA200", Offset = "0x55F8E00", VA = "0x1855FA200")]
		public AnyKeyControl()
		{
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x55FA1D0", Offset = "0x55F8DD0", VA = "0x1855FA1D0", Slot = "17")]
		public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0f;
		}
	}
}
