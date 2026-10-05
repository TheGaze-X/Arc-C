using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007919 RID: 31001
	[Token(Token = "0x2007919")]
	public class ArcadeStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x0602B7E6 RID: 178150 RVA: 0x000DC380 File Offset: 0x000DA580
		[Token(Token = "0x602B7E6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0602B7E7 RID: 178151 RVA: 0x000DC398 File Offset: 0x000DA598
		[Token(Token = "0x602B7E7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0602B7E8 RID: 178152 RVA: 0x000DC3B0 File Offset: 0x000DA5B0
		[Token(Token = "0x602B7E8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0602B7E9 RID: 178153 RVA: 0x000DC3C8 File Offset: 0x000DA5C8
		[Token(Token = "0x602B7E9")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0602B7EA RID: 178154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7EA")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public ArcadeStartBattleResponse()
		{
		}
	}
}
