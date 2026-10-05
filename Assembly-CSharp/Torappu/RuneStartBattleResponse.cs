using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2000832")]
	public class RuneStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x060064C1 RID: 25793 RVA: 0x000305B8 File Offset: 0x0002E7B8
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x000305D0 File Offset: 0x0002E7D0
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x000305E8 File Offset: 0x0002E7E8
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00030600 File Offset: 0x0002E800
		[Token(Token = "0x60064C4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C5")]
		[Address(RVA = "0x1EE8270", Offset = "0x1EE6E70", VA = "0x181EE8270")]
		public RuneStartBattleResponse()
		{
		}
	}
}
