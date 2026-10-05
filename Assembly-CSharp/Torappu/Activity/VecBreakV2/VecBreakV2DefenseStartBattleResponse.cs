using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA3 RID: 28323
	[Token(Token = "0x2006EA3")]
	public class VecBreakV2DefenseStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x060284C3 RID: 165059 RVA: 0x000D14A8 File Offset: 0x000CF6A8
		[Token(Token = "0x60284C3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060284C4 RID: 165060 RVA: 0x000D14C0 File Offset: 0x000CF6C0
		[Token(Token = "0x60284C4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060284C5 RID: 165061 RVA: 0x000D14D8 File Offset: 0x000CF6D8
		[Token(Token = "0x60284C5")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060284C6 RID: 165062 RVA: 0x000D14F0 File Offset: 0x000CF6F0
		[Token(Token = "0x60284C6")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060284C7 RID: 165063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284C7")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public VecBreakV2DefenseStartBattleResponse()
		{
		}
	}
}
