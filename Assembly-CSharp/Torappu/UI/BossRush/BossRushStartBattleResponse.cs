using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006178 RID: 24952
	[Token(Token = "0x2006178")]
	public class BossRushStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x06024007 RID: 147463 RVA: 0x000C2B68 File Offset: 0x000C0D68
		[Token(Token = "0x6024007")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06024008 RID: 147464 RVA: 0x000C2B80 File Offset: 0x000C0D80
		[Token(Token = "0x6024008")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x06024009 RID: 147465 RVA: 0x000C2B98 File Offset: 0x000C0D98
		[Token(Token = "0x6024009")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0602400A RID: 147466 RVA: 0x000C2BB0 File Offset: 0x000C0DB0
		[Token(Token = "0x602400A")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0602400B RID: 147467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602400B")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public BossRushStartBattleResponse()
		{
		}
	}
}
