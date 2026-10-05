using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010E0 RID: 4320
	[Token(Token = "0x20010E0")]
	[Flags]
	public enum CheckpointTypeMask
	{
		// Token: 0x04005C92 RID: 23698
		[Token(Token = "0x4005C92")]
		MOVE = 1,
		// Token: 0x04005C93 RID: 23699
		[Token(Token = "0x4005C93")]
		WAIT_FOR_SECONDS = 2,
		// Token: 0x04005C94 RID: 23700
		[Token(Token = "0x4005C94")]
		WAIT_FOR_PLAY_TIME = 4,
		// Token: 0x04005C95 RID: 23701
		[Token(Token = "0x4005C95")]
		WAIT_CURRENT_FRAGMENT_TIME = 8,
		// Token: 0x04005C96 RID: 23702
		[Token(Token = "0x4005C96")]
		WAIT_CURRENT_WAVE_TIME = 16,
		// Token: 0x04005C97 RID: 23703
		[Token(Token = "0x4005C97")]
		DISAPPEAR = 32,
		// Token: 0x04005C98 RID: 23704
		[Token(Token = "0x4005C98")]
		APPEAR_AT_POS = 64,
		// Token: 0x04005C99 RID: 23705
		[Token(Token = "0x4005C99")]
		ALERT = 128,
		// Token: 0x04005C9A RID: 23706
		[Token(Token = "0x4005C9A")]
		PATROL_MOVE = 256
	}
}
