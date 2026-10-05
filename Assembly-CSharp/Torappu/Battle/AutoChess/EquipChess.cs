using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002724 RID: 10020
	[Token(Token = "0x2002724")]
	public class EquipChess
	{
		// Token: 0x0601047E RID: 66686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601047E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EquipChess()
		{
		}

		// Token: 0x0401232E RID: 74542
		[Token(Token = "0x401232E")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x0401232F RID: 74543
		[Token(Token = "0x401232F")]
		[FieldOffset(Offset = "0x18")]
		public string chessId;
	}
}
