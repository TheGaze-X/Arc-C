using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007865 RID: 30821
	[Token(Token = "0x2007865")]
	public class Act1LockInterlockBattleStartResponse : DefaultStartBattleResponse
	{
		// Token: 0x0602B330 RID: 176944 RVA: 0x000DB1B0 File Offset: 0x000D93B0
		[Token(Token = "0x602B330")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0602B331 RID: 176945 RVA: 0x000DB1C8 File Offset: 0x000D93C8
		[Token(Token = "0x602B331")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0602B332 RID: 176946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B332")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act1LockInterlockBattleStartResponse()
		{
		}
	}
}
