using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED5 RID: 28373
	[Token(Token = "0x2006ED5")]
	public class ActMultiV3GuideBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0602854E RID: 165198 RVA: 0x000D1760 File Offset: 0x000CF960
		[Token(Token = "0x602854E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0602854F RID: 165199 RVA: 0x000D1778 File Offset: 0x000CF978
		[Token(Token = "0x602854F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x06028550 RID: 165200 RVA: 0x000D1790 File Offset: 0x000CF990
		[Token(Token = "0x6028550")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06028551 RID: 165201 RVA: 0x000D17A8 File Offset: 0x000CF9A8
		[Token(Token = "0x6028551")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06028552 RID: 165202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028552")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public ActMultiV3GuideBattleStartResponse()
		{
		}
	}
}
