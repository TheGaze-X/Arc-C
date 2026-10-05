using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007135 RID: 28981
	[Token(Token = "0x2007135")]
	public class ActAutoChessRewardInfoStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602925B RID: 168539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925B")]
		[Address(RVA = "0x248C860", Offset = "0x248B460", VA = "0x18248C860")]
		public ActAutoChessRewardInfoStateBean()
		{
		}

		// Token: 0x0403AC41 RID: 240705
		[Token(Token = "0x403AC41")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessRewardInfoProperty property;

		// Token: 0x0403AC42 RID: 240706
		[Token(Token = "0x403AC42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
