using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002751 RID: 10065
	[Token(Token = "0x2002751")]
	public enum AutoChessOperationType
	{
		// Token: 0x0401258E RID: 75150
		[Token(Token = "0x401258E")]
		MOVE_ONLY,
		// Token: 0x0401258F RID: 75151
		[Token(Token = "0x401258F")]
		EQUIP_ITEM,
		// Token: 0x04012590 RID: 75152
		[Token(Token = "0x4012590")]
		USE_MAGIC,
		// Token: 0x04012591 RID: 75153
		[Token(Token = "0x4012591")]
		WITHDRAW,
		// Token: 0x04012592 RID: 75154
		[Token(Token = "0x4012592")]
		REPLACE_EQUIP
	}
}
