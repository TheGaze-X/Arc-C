using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	public class InvertVector2Processor : InputProcessor<Vector2>
	{
		// Token: 0x060011D3 RID: 4563 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x56F5450", Offset = "0x56F4050", VA = "0x1856F5450", Slot = "7")]
		public override Vector2 Process(Vector2 value, InputControl control)
		{
			return default(Vector2);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x56F54B0", Offset = "0x56F40B0", VA = "0x1856F54B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x56F5540", Offset = "0x56F4140", VA = "0x1856F5540")]
		public InvertVector2Processor()
		{
		}

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x10")]
		public bool invertX;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x11")]
		public bool invertY;
	}
}
