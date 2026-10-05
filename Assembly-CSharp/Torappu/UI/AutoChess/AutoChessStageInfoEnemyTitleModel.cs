using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A1 RID: 25505
	[Token(Token = "0x20063A1")]
	public class AutoChessStageInfoEnemyTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C6C RID: 150636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C6C")]
		[Address(RVA = "0x1FA7B30", Offset = "0x1FA6730", VA = "0x181FA7B30", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C6D RID: 150637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C6D")]
		[Address(RVA = "0x1FA7BA0", Offset = "0x1FA67A0", VA = "0x181FA7BA0")]
		public AutoChessStageInfoEnemyTitleModel()
		{
		}

		// Token: 0x04033650 RID: 210512
		[Token(Token = "0x4033650")]
		public const string VIEW_TYPE = "ENEMY_TITLE";

		// Token: 0x04033651 RID: 210513
		[Token(Token = "0x4033651")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033652 RID: 210514
		[Token(Token = "0x4033652")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
