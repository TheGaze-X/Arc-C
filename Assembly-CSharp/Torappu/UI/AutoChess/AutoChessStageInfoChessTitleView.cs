using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200639B RID: 25499
	[Token(Token = "0x200639B")]
	public class AutoChessStageInfoChessTitleView : UISimpleRecycleLayoutItemView<AutoChessStageInfoChessTitleModel>, IHotfixable
	{
		// Token: 0x06024C59 RID: 150617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C59")]
		[Address(RVA = "0x1FA6B50", Offset = "0x1FA5750", VA = "0x181FA6B50", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C5A RID: 150618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C5A")]
		[Address(RVA = "0x1FA6BC0", Offset = "0x1FA57C0", VA = "0x181FA6BC0")]
		public AutoChessStageInfoChessTitleView()
		{
		}

		// Token: 0x04033626 RID: 210470
		[Token(Token = "0x4033626")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033627 RID: 210471
		[Token(Token = "0x4033627")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
