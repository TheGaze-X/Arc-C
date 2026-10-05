using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006269 RID: 25193
	[Token(Token = "0x2006269")]
	public class AutoChessTrainingBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0602457C RID: 148860 RVA: 0x000C3E28 File Offset: 0x000C2028
		[Token(Token = "0x602457C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0602457D RID: 148861 RVA: 0x000C3E40 File Offset: 0x000C2040
		[Token(Token = "0x602457D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0602457E RID: 148862 RVA: 0x000C3E58 File Offset: 0x000C2058
		[Token(Token = "0x602457E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0602457F RID: 148863 RVA: 0x000C3E70 File Offset: 0x000C2070
		[Token(Token = "0x602457F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06024580 RID: 148864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024580")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public AutoChessTrainingBattleStartResponse()
		{
		}
	}
}
