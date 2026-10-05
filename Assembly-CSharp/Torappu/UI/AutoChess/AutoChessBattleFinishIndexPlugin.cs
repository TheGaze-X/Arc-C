using System;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200622C RID: 25132
	[Token(Token = "0x200622C")]
	public class AutoChessBattleFinishIndexPlugin : BattleFinishIndexState.Plugin
	{
		// Token: 0x0602442A RID: 148522 RVA: 0x000C39A8 File Offset: 0x000C1BA8
		[Token(Token = "0x602442A")]
		[Address(RVA = "0x1F04C70", Offset = "0x1F03870", VA = "0x181F04C70", Slot = "5")]
		public override bool HandleRedirection()
		{
			return default(bool);
		}

		// Token: 0x0602442B RID: 148523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602442B")]
		[Address(RVA = "0x1F04CD0", Offset = "0x1F038D0", VA = "0x181F04CD0")]
		public AutoChessBattleFinishIndexPlugin()
		{
		}

		// Token: 0x0602442C RID: 148524 RVA: 0x000C39C0 File Offset: 0x000C1BC0
		[Token(Token = "0x602442C")]
		[Address(RVA = "0x1A39960", Offset = "0x1A38560", VA = "0x181A39960")]
		private bool <>xLuaBaseProxy_HandleRedirection()
		{
			return default(bool);
		}

		// Token: 0x040326AA RID: 206506
		[Token(Token = "0x40326AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleRedirection;

		// Token: 0x040326AB RID: 206507
		[Token(Token = "0x40326AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
