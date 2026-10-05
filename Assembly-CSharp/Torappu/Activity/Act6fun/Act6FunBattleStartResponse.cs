using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071AD RID: 29101
	[Token(Token = "0x20071AD")]
	public class Act6FunBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x060294C7 RID: 169159 RVA: 0x000D5390 File Offset: 0x000D3590
		[Token(Token = "0x60294C7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x060294C8 RID: 169160 RVA: 0x000D53A8 File Offset: 0x000D35A8
		[Token(Token = "0x60294C8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x060294C9 RID: 169161 RVA: 0x000D53C0 File Offset: 0x000D35C0
		[Token(Token = "0x60294C9")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x060294CA RID: 169162 RVA: 0x000D53D8 File Offset: 0x000D35D8
		[Token(Token = "0x60294CA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x060294CB RID: 169163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294CB")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act6FunBattleStartResponse()
		{
		}
	}
}
