using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E7 RID: 28903
	[Token(Token = "0x20070E7")]
	public class ActAutoChessDailyMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602916C RID: 168300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602916C")]
		[Address(RVA = "0x247D6E0", Offset = "0x247C2E0", VA = "0x18247D6E0")]
		public ActAutoChessDailyMissionStateBean()
		{
		}

		// Token: 0x0403AA32 RID: 240178
		[Token(Token = "0x403AA32")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessDailyMissionViewModel viewModel;

		// Token: 0x0403AA33 RID: 240179
		[Token(Token = "0x403AA33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
