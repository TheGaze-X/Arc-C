using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006B3 RID: 1715
	[Token(Token = "0x20006B3")]
	public class CampaignStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x060062F4 RID: 25332 RVA: 0x00030318 File Offset: 0x0002E518
		[Token(Token = "0x60062F4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x00030330 File Offset: 0x0002E530
		[Token(Token = "0x60062F5")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x00030348 File Offset: 0x0002E548
		[Token(Token = "0x60062F6")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x00030360 File Offset: 0x0002E560
		[Token(Token = "0x60062F7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F8")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public CampaignStartBattleResponse()
		{
		}
	}
}
