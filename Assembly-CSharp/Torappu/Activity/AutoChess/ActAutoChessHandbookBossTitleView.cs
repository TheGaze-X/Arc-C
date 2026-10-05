using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200711F RID: 28959
	[Token(Token = "0x200711F")]
	public class ActAutoChessHandbookBossTitleView : UISimpleRecycleLayoutItemView<ActAutoChessHandbookBossTitleModel>, IHotfixable
	{
		// Token: 0x06029228 RID: 168488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029228")]
		[Address(RVA = "0x2483E20", Offset = "0x2482A20", VA = "0x182483E20", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06029229 RID: 168489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029229")]
		[Address(RVA = "0x2483E90", Offset = "0x2482A90", VA = "0x182483E90")]
		public ActAutoChessHandbookBossTitleView()
		{
		}

		// Token: 0x0403ABDE RID: 240606
		[Token(Token = "0x403ABDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403ABDF RID: 240607
		[Token(Token = "0x403ABDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
