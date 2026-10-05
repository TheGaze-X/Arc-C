using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	[InputControlLayout(hideInUI = true)]
	public class TouchPhaseControl : InputControl<TouchPhase>
	{
		// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x560D570", Offset = "0x560C170", VA = "0x18560D570")]
		public TouchPhaseControl()
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x560D4A0", Offset = "0x560C0A0", VA = "0x18560D4A0", Slot = "17")]
		public unsafe override TouchPhase ReadUnprocessedValueFromState(void* statePtr)
		{
			return TouchPhase.None;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x560D510", Offset = "0x560C110", VA = "0x18560D510", Slot = "18")]
		public unsafe override void WriteValueIntoState(TouchPhase value, void* statePtr)
		{
		}
	}
}
