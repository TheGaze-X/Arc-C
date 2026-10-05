using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x0200782F RID: 30767
	[Token(Token = "0x200782F")]
	public class Act1VHalfIdleBattleFinishPlotCardViewModel : IHotfixable
	{
		// Token: 0x0602B26F RID: 176751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B26F")]
		[Address(RVA = "0x26F50D0", Offset = "0x26F3CD0", VA = "0x1826F50D0")]
		public Act1VHalfIdleBattleFinishPlotCardViewModel()
		{
		}

		// Token: 0x0403E618 RID: 255512
		[Token(Token = "0x403E618")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E619 RID: 255513
		[Token(Token = "0x403E619")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdlePlotData data;

		// Token: 0x0403E61A RID: 255514
		[Token(Token = "0x403E61A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
