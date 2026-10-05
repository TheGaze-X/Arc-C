using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	public abstract class CrisisStartBattleBaseResponse : CommonStartBattleResponse
	{
		// Token: 0x06006322 RID: 25378 RVA: 0x00030390 File Offset: 0x0002E590
		[Token(Token = "0x6006322")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x000303A8 File Offset: 0x0002E5A8
		[Token(Token = "0x6006323")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x000303C0 File Offset: 0x0002E5C0
		[Token(Token = "0x6006324")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x000303D8 File Offset: 0x0002E5D8
		[Token(Token = "0x6006325")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006326")]
		[Address(RVA = "0x1EE8270", Offset = "0x1EE6E70", VA = "0x181EE8270")]
		protected CrisisStartBattleBaseResponse()
		{
		}
	}
}
