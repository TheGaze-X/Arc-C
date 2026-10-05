using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006266 RID: 25190
	[Token(Token = "0x2006266")]
	public class AutoChessMultiBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x06024573 RID: 148851 RVA: 0x000C3DC8 File Offset: 0x000C1FC8
		[Token(Token = "0x6024573")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x06024574 RID: 148852 RVA: 0x000C3DE0 File Offset: 0x000C1FE0
		[Token(Token = "0x6024574")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x06024575 RID: 148853 RVA: 0x000C3DF8 File Offset: 0x000C1FF8
		[Token(Token = "0x6024575")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06024576 RID: 148854 RVA: 0x000C3E10 File Offset: 0x000C2010
		[Token(Token = "0x6024576")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06024577 RID: 148855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024577")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public AutoChessMultiBattleStartResponse()
		{
		}
	}
}
