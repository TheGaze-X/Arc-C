using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200639F RID: 25503
	[Token(Token = "0x200639F")]
	public class AutoChessStageInfoEnemyTitleView : UISimpleRecycleLayoutItemView<AutoChessStageInfoEnemyTitleModel>, IHotfixable
	{
		// Token: 0x06024C65 RID: 150629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C65")]
		[Address(RVA = "0x1FA7C00", Offset = "0x1FA6800", VA = "0x181FA7C00", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C66 RID: 150630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C66")]
		[Address(RVA = "0x1FA7C70", Offset = "0x1FA6870", VA = "0x181FA7C70")]
		public AutoChessStageInfoEnemyTitleView()
		{
		}

		// Token: 0x0403363F RID: 210495
		[Token(Token = "0x403363F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033640 RID: 210496
		[Token(Token = "0x4033640")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
