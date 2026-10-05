using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public class HandBookAddonStageBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x060063D6 RID: 25558 RVA: 0x00030468 File Offset: 0x0002E668
		[Token(Token = "0x60063D6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00030480 File Offset: 0x0002E680
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00030498 File Offset: 0x0002E698
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x000304B0 File Offset: 0x0002E6B0
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0x1EE8270", Offset = "0x1EE6E70", VA = "0x181EE8270")]
		public HandBookAddonStageBattleStartResponse()
		{
		}
	}
}
