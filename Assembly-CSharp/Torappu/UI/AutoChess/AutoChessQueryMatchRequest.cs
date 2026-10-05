using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006281 RID: 25217
	[Token(Token = "0x2006281")]
	public class AutoChessQueryMatchRequest
	{
		// Token: 0x060245A4 RID: 148900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessQueryMatchRequest()
		{
		}

		// Token: 0x040328EF RID: 207087
		[Token(Token = "0x40328EF")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328F0 RID: 207088
		[Token(Token = "0x40328F0")]
		[FieldOffset(Offset = "0x18")]
		public int needLeave;
	}
}
