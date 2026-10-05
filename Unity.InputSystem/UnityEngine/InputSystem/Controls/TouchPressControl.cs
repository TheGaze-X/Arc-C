using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	[InputControlLayout(hideInUI = true)]
	public class TouchPressControl : ButtonControl
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x560D5F0", Offset = "0x560C1F0", VA = "0x18560D5F0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x560D720", Offset = "0x560C320", VA = "0x18560D720", Slot = "17")]
		public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x560D7B0", Offset = "0x560C3B0", VA = "0x18560D7B0", Slot = "18")]
		public unsafe override void WriteValueIntoState(float value, void* statePtr)
		{
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x55FBD40", Offset = "0x55FA940", VA = "0x1855FBD40")]
		public TouchPressControl()
		{
		}
	}
}
