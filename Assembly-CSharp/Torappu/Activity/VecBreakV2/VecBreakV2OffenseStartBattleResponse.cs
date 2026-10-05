using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E9D RID: 28317
	[Token(Token = "0x2006E9D")]
	public class VecBreakV2OffenseStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x060284B7 RID: 165047 RVA: 0x000D1448 File Offset: 0x000CF648
		[Token(Token = "0x60284B7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060284B8 RID: 165048 RVA: 0x000D1460 File Offset: 0x000CF660
		[Token(Token = "0x60284B8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060284B9 RID: 165049 RVA: 0x000D1478 File Offset: 0x000CF678
		[Token(Token = "0x60284B9")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060284BA RID: 165050 RVA: 0x000D1490 File Offset: 0x000CF690
		[Token(Token = "0x60284BA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060284BB RID: 165051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284BB")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public VecBreakV2OffenseStartBattleResponse()
		{
		}
	}
}
