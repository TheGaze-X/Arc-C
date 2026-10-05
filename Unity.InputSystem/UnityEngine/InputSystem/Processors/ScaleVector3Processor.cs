using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	public class ScaleVector3Processor : InputProcessor<Vector3>
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x56FA090", Offset = "0x56F8C90", VA = "0x1856FA090", Slot = "7")]
		public override Vector3 Process(Vector3 value, InputControl control)
		{
			return default(Vector3);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x56FA0D0", Offset = "0x56F8CD0", VA = "0x1856FA0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x56FA190", Offset = "0x56F8D90", VA = "0x1856FA190")]
		public ScaleVector3Processor()
		{
		}

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
		public float x;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
		public float y;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
		public float z;
	}
}
