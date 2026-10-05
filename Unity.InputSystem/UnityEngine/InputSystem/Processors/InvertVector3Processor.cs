using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	public class InvertVector3Processor : InputProcessor<Vector3>
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x56F5580", Offset = "0x56F4180", VA = "0x1856F5580", Slot = "7")]
		public override Vector3 Process(Vector3 value, InputControl control)
		{
			return default(Vector3);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x56F55E0", Offset = "0x56F41E0", VA = "0x1856F55E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x56F5690", Offset = "0x56F4290", VA = "0x1856F5690")]
		public InvertVector3Processor()
		{
		}

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x10")]
		public bool invertX;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x11")]
		public bool invertY;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x12")]
		public bool invertZ;
	}
}
