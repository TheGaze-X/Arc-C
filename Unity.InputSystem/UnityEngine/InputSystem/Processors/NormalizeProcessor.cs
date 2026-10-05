using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	public class NormalizeProcessor : InputProcessor<float>
	{
		// Token: 0x060011D9 RID: 4569 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x56F7390", Offset = "0x56F5F90", VA = "0x1856F7390", Slot = "7")]
		public override float Process(float value, InputControl control)
		{
			return 0f;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x56F72A0", Offset = "0x56F5EA0", VA = "0x1856F72A0")]
		public static float Normalize(float value, float min, float max, float zero)
		{
			return 0f;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x56F7250", Offset = "0x56F5E50", VA = "0x1856F7250")]
		internal static float Denormalize(float value, float min, float max, float zero)
		{
			return 0f;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x56F7480", Offset = "0x56F6080", VA = "0x1856F7480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x56F7540", Offset = "0x56F6140", VA = "0x1856F7540")]
		public NormalizeProcessor()
		{
		}

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x14")]
		public float max;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x18")]
		public float zero;
	}
}
