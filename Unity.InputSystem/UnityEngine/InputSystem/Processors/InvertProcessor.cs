using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	public class InvertProcessor : InputProcessor<float>
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x56F53D0", Offset = "0x56F3FD0", VA = "0x1856F53D0", Slot = "7")]
		public override float Process(float value, InputControl control)
		{
			return 0f;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x56F53E0", Offset = "0x56F3FE0", VA = "0x1856F53E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x56F5410", Offset = "0x56F4010", VA = "0x1856F5410")]
		public InvertProcessor()
		{
		}
	}
}
