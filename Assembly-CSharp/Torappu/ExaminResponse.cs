using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	public abstract class ExaminResponse : PlayerDeltaResponse
	{
		// Token: 0x06006387 RID: 25479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006387")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		protected ExaminResponse()
		{
		}

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x28")]
		public ExaminResultType result;
	}
}
