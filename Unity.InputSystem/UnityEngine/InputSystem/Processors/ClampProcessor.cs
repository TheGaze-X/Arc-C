using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	public class ClampProcessor : InputProcessor<float>
	{
		// Token: 0x060011C5 RID: 4549 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x56E4D50", Offset = "0x56E3950", VA = "0x1856E4D50", Slot = "7")]
		public override float Process(float value, InputControl control)
		{
			return 0f;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x56E4D70", Offset = "0x56E3970", VA = "0x1856E4D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x56E4E00", Offset = "0x56E3A00", VA = "0x1856E4E00")]
		public ClampProcessor()
		{
		}

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x14")]
		public float max;
	}
}
