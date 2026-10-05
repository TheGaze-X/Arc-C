using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EDB RID: 28379
	[Token(Token = "0x2006EDB")]
	public class ActMultiV3BattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0602855F RID: 165215 RVA: 0x000D17C0 File Offset: 0x000CF9C0
		[Token(Token = "0x602855F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x06028560 RID: 165216 RVA: 0x000D17D8 File Offset: 0x000CF9D8
		[Token(Token = "0x6028560")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x06028561 RID: 165217 RVA: 0x000D17F0 File Offset: 0x000CF9F0
		[Token(Token = "0x6028561")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06028562 RID: 165218 RVA: 0x000D1808 File Offset: 0x000CFA08
		[Token(Token = "0x6028562")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06028563 RID: 165219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028563")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public ActMultiV3BattleStartResponse()
		{
		}
	}
}
