using System;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D13 RID: 15635
	[Token(Token = "0x2003D13")]
	public class TuningProductMusicResponse : PlayerDeltaResponse
	{
		// Token: 0x060185F9 RID: 99833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F9")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TuningProductMusicResponse()
		{
		}

		// Token: 0x0401DCE8 RID: 122088
		[Token(Token = "0x401DCE8")]
		[FieldOffset(Offset = "0x28")]
		public string melodyId;
	}
}
