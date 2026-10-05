using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	public class CrisisV2BattleFinishRequest : CommonFinishBattleRequest, IFinishBattleWithLog
	{
		// Token: 0x0600633B RID: 25403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633B")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "4")]
		public void SetBattleLog(string log)
		{
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BattleFinishRequest()
		{
		}

		// Token: 0x04002F02 RID: 12034
		[Token(Token = "0x4002F02")]
		[FieldOffset(Offset = "0x20")]
		public string battleLog;
	}
}
