using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A2 RID: 25506
	[Token(Token = "0x20063A2")]
	public class AutoChessStageInfoEnemyGroupModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C6E RID: 150638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C6E")]
		[Address(RVA = "0x1FA7280", Offset = "0x1FA5E80", VA = "0x181FA7280", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C6F RID: 150639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C6F")]
		[Address(RVA = "0x1FA72F0", Offset = "0x1FA5EF0", VA = "0x181FA72F0")]
		public AutoChessStageInfoEnemyGroupModel()
		{
		}

		// Token: 0x04033653 RID: 210515
		[Token(Token = "0x4033653")]
		public const string VIEW_TYPE = "ENEMY";

		// Token: 0x04033654 RID: 210516
		[Token(Token = "0x4033654")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirst;

		// Token: 0x04033655 RID: 210517
		[Token(Token = "0x4033655")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessStageInfoBossViewModel bossModel;

		// Token: 0x04033656 RID: 210518
		[Token(Token = "0x4033656")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessStageInfoEnemyTypeViewModel> enemyList;

		// Token: 0x04033657 RID: 210519
		[Token(Token = "0x4033657")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033658 RID: 210520
		[Token(Token = "0x4033658")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
