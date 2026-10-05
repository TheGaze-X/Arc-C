using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x20008B6")]
	public abstract class CommonStartBattleResponse : PlayerDeltaResponse
	{
		// Token: 0x06006560 RID: 25952
		[Token(Token = "0x6006560")]
		public abstract bool GetIsApProtect();

		// Token: 0x06006561 RID: 25953
		[Token(Token = "0x6006561")]
		public abstract int GetApFailReturn();

		// Token: 0x06006562 RID: 25954
		[Token(Token = "0x6006562")]
		public abstract bool GetNotifyPowerScoreNotEnoughIfFailed();

		// Token: 0x06006563 RID: 25955
		[Token(Token = "0x6006563")]
		public abstract bool GetInApProtectPeriod();

		// Token: 0x06006564 RID: 25956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006564")]
		[Address(RVA = "0x1EE8270", Offset = "0x1EE6E70", VA = "0x181EE8270")]
		protected CommonStartBattleResponse()
		{
		}

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x30")]
		public string battleId;
	}
}
