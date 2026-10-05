using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F75 RID: 20341
	[Token(Token = "0x2004F75")]
	public class EnemyDuelSingleBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0601E40C RID: 123916 RVA: 0x000AE018 File Offset: 0x000AC218
		[Token(Token = "0x601E40C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601E40D RID: 123917 RVA: 0x000AE030 File Offset: 0x000AC230
		[Token(Token = "0x601E40D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0601E40E RID: 123918 RVA: 0x000AE048 File Offset: 0x000AC248
		[Token(Token = "0x601E40E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601E40F RID: 123919 RVA: 0x000AE060 File Offset: 0x000AC260
		[Token(Token = "0x601E40F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0601E410 RID: 123920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E410")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public EnemyDuelSingleBattleStartResponse()
		{
		}
	}
}
