using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061EB RID: 25067
	[Token(Token = "0x20061EB")]
	public class BattleFinishHandBookStageStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060242D2 RID: 148178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242D2")]
		[Address(RVA = "0x1ED09D0", Offset = "0x1ECF5D0", VA = "0x181ED09D0")]
		public BattleFinishHandBookStageStateBean()
		{
		}

		// Token: 0x040324B5 RID: 206005
		[Token(Token = "0x40324B5")]
		[FieldOffset(Offset = "0x10")]
		public BattleFinishHandBookStageViewModel battleFinishModel;

		// Token: 0x040324B6 RID: 206006
		[Token(Token = "0x40324B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
