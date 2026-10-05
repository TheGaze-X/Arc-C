using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440C RID: 17420
	[Token(Token = "0x200440C")]
	public class SandboxV2MonthBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0601A9C8 RID: 109000 RVA: 0x000A2840 File Offset: 0x000A0A40
		[Token(Token = "0x601A9C8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601A9C9 RID: 109001 RVA: 0x000A2858 File Offset: 0x000A0A58
		[Token(Token = "0x601A9C9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601A9CA RID: 109002 RVA: 0x000A2870 File Offset: 0x000A0A70
		[Token(Token = "0x601A9CA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0601A9CB RID: 109003 RVA: 0x000A2888 File Offset: 0x000A0A88
		[Token(Token = "0x601A9CB")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0601A9CC RID: 109004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9CC")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public SandboxV2MonthBattleStartResponse()
		{
		}

		// Token: 0x04021ECA RID: 138954
		[Token(Token = "0x4021ECA")]
		[FieldOffset(Offset = "0x38")]
		public List<string> extraRunes;
	}
}
