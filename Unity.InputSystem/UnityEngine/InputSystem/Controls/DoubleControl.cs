using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	public class DoubleControl : InputControl<double>
	{
		// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x55FBE20", Offset = "0x55FAA20", VA = "0x1855FBE20")]
		public DoubleControl()
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x55FBD50", Offset = "0x55FA950", VA = "0x1855FBD50", Slot = "17")]
		public unsafe override double ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0.0;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x55FBDB0", Offset = "0x55FA9B0", VA = "0x1855FBDB0", Slot = "18")]
		public unsafe override void WriteValueIntoState(double value, void* statePtr)
		{
		}
	}
}
