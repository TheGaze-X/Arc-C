using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002752 RID: 10066
	[Token(Token = "0x2002752")]
	public enum AutoChessDragOperationFlag
	{
		// Token: 0x04012594 RID: 75156
		[Token(Token = "0x4012594")]
		NONE,
		// Token: 0x04012595 RID: 75157
		[Token(Token = "0x4012595")]
		IS_START_BATTLE = 2,
		// Token: 0x04012596 RID: 75158
		[Token(Token = "0x4012596")]
		IS_END_BATTLE = 4,
		// Token: 0x04012597 RID: 75159
		[Token(Token = "0x4012597")]
		IS_START_VALID_HAND = 8,
		// Token: 0x04012598 RID: 75160
		[Token(Token = "0x4012598")]
		IS_END_VALID_HAND = 16,
		// Token: 0x04012599 RID: 75161
		[Token(Token = "0x4012599")]
		IS_START_HAND = 32,
		// Token: 0x0401259A RID: 75162
		[Token(Token = "0x401259A")]
		IS_END_HAND = 64,
		// Token: 0x0401259B RID: 75163
		[Token(Token = "0x401259B")]
		END_CONTAINS_TARGET = 128,
		// Token: 0x0401259C RID: 75164
		[Token(Token = "0x401259C")]
		START_CONTAINS_TOKEN_POS = 256,
		// Token: 0x0401259D RID: 75165
		[Token(Token = "0x401259D")]
		END_CONTAINS_TOKEN_POS = 512,
		// Token: 0x0401259E RID: 75166
		[Token(Token = "0x401259E")]
		ALL = 1022
	}
}
