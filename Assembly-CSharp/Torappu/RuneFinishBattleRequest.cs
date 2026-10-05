using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	public class RuneFinishBattleRequest : CommonFinishBattleRequest, IFinishBattleWithLog
	{
		// Token: 0x060064C6 RID: 25798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "4")]
		public void SetBattleLog(string log)
		{
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuneFinishBattleRequest()
		{
		}

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0x20")]
		public string battleLog;
	}
}
