using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
	[DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
	public class Vector3Composite : InputBindingComposite<Vector3>
	{
		// Token: 0x06001646 RID: 5702 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x5619570", Offset = "0x5618170", VA = "0x185619570", Slot = "10")]
		public override Vector3 ReadValue(ref InputBindingCompositeContext context)
		{
			return default(Vector3);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x56198B0", Offset = "0x56184B0", VA = "0x1856198B0")]
		public Vector3Composite()
		{
		}

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Axis")]
		public int up;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Axis")]
		public int down;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Axis")]
		public int left;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x1C")]
		[InputControl(layout = "Axis")]
		public int right;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x20")]
		[InputControl(layout = "Axis")]
		public int forward;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x24")]
		[InputControl(layout = "Axis")]
		public int backward;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x28")]
		public Vector3Composite.Mode mode;

		// Token: 0x0200026E RID: 622
		[Token(Token = "0x200026E")]
		public enum Mode
		{
			// Token: 0x04000CAF RID: 3247
			[Token(Token = "0x4000CAF")]
			Analog,
			// Token: 0x04000CB0 RID: 3248
			[Token(Token = "0x4000CB0")]
			DigitalNormalized,
			// Token: 0x04000CB1 RID: 3249
			[Token(Token = "0x4000CB1")]
			Digital
		}
	}
}
