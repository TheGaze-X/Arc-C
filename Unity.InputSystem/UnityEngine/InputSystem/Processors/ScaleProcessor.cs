using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	public class ScaleProcessor : InputProcessor<float>
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x56F9EC0", Offset = "0x56F8AC0", VA = "0x1856F9EC0", Slot = "7")]
		public override float Process(float value, InputControl control)
		{
			return 0f;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x56F9ED0", Offset = "0x56F8AD0", VA = "0x1856F9ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x56F9F40", Offset = "0x56F8B40", VA = "0x1856F9F40")]
		public ScaleProcessor()
		{
		}

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Scale factor to multiply incoming float values by.")]
		public float factor;
	}
}
