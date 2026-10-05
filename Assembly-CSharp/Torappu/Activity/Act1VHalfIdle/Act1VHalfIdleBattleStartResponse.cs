using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076BF RID: 30399
	[Token(Token = "0x20076BF")]
	public class Act1VHalfIdleBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0602AC05 RID: 175109 RVA: 0x000D9C98 File Offset: 0x000D7E98
		[Token(Token = "0x602AC05")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0602AC06 RID: 175110 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		[Token(Token = "0x602AC06")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0602AC07 RID: 175111 RVA: 0x000D9CC8 File Offset: 0x000D7EC8
		[Token(Token = "0x602AC07")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0602AC08 RID: 175112 RVA: 0x000D9CE0 File Offset: 0x000D7EE0
		[Token(Token = "0x602AC08")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0602AC09 RID: 175113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC09")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act1VHalfIdleBattleStartResponse()
		{
		}
	}
}
