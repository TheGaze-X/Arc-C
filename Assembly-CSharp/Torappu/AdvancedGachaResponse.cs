using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	public class AdvancedGachaResponse : PlayerDeltaResponse, IGachaResultHolder
	{
		// Token: 0x060063C1 RID: 25537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C1")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AdvancedGachaResponse()
		{
		}

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x30")]
		public GachaResult charGet;
	}
}
