using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F72 RID: 20338
	[Token(Token = "0x2004F72")]
	public class EnemyDuelMultiBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0601E403 RID: 123907 RVA: 0x000ADFB8 File Offset: 0x000AC1B8
		[Token(Token = "0x601E403")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601E404 RID: 123908 RVA: 0x000ADFD0 File Offset: 0x000AC1D0
		[Token(Token = "0x601E404")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0601E405 RID: 123909 RVA: 0x000ADFE8 File Offset: 0x000AC1E8
		[Token(Token = "0x601E405")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601E406 RID: 123910 RVA: 0x000AE000 File Offset: 0x000AC200
		[Token(Token = "0x601E406")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0601E407 RID: 123911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E407")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public EnemyDuelMultiBattleStartResponse()
		{
		}
	}
}
