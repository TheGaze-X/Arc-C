using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A70 RID: 10864
	[Token(Token = "0x2002A70")]
	public struct SandboxEntityStatusKey
	{
		// Token: 0x0601210A RID: 73994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601210A")]
		[Address(RVA = "0xA2BAB0", Offset = "0xA2A6B0", VA = "0x180A2BAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401468C RID: 83596
		[Token(Token = "0x401468C")]
		[FieldOffset(Offset = "0x0")]
		public string entityId;

		// Token: 0x0401468D RID: 83597
		[Token(Token = "0x401468D")]
		[FieldOffset(Offset = "0x8")]
		public GridPosition position;
	}
}
