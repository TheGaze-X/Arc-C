using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public class ScaleVector2Processor : InputProcessor<Vector2>
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x56F9F80", Offset = "0x56F8B80", VA = "0x1856F9F80", Slot = "7")]
		public override Vector2 Process(Vector2 value, InputControl control)
		{
			return default(Vector2);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x56F9FB0", Offset = "0x56F8BB0", VA = "0x1856F9FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x56FA040", Offset = "0x56F8C40", VA = "0x1856FA040")]
		public ScaleVector2Processor()
		{
		}

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Scale factor to multiply the incoming Vector2's X component by.")]
		public float x;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Scale factor to multiply the incoming Vector2's Y component by.")]
		public float y;
	}
}
