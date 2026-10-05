using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200271E RID: 10014
	[Token(Token = "0x200271E")]
	public class SpPrepareStateData
	{
		// Token: 0x06010478 RID: 66680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010478")]
		[Address(RVA = "0x80B5D0", Offset = "0x80A1D0", VA = "0x18080B5D0")]
		public SpPrepareStateData()
		{
		}

		// Token: 0x0401231E RID: 74526
		[Token(Token = "0x401231E")]
		[FieldOffset(Offset = "0x10")]
		public NChooseOneStateData data;
	}
}
