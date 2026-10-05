using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063AC RID: 25516
	[Token(Token = "0x20063AC")]
	public class AutoChessStageInfoGroupViewModel : IHotfixable
	{
		// Token: 0x06024C86 RID: 150662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C86")]
		[Address(RVA = "0x1FA7CE0", Offset = "0x1FA68E0", VA = "0x181FA7CE0")]
		public void LoadData(AutoChessStageInfoGroupViewModel.Input inputData)
		{
		}

		// Token: 0x06024C87 RID: 150663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C87")]
		[Address(RVA = "0x1FA87B0", Offset = "0x1FA73B0", VA = "0x181FA87B0")]
		private void _LoadEnemyData(string bossId, List<string> enemyTypes)
		{
		}

		// Token: 0x06024C88 RID: 150664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C88")]
		[Address(RVA = "0x1FA8670", Offset = "0x1FA7270", VA = "0x181FA8670")]
		private void _LoadBondData(AutoChessStageInfoGroupViewModel.Input input)
		{
		}

		// Token: 0x06024C89 RID: 150665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C89")]
		[Address(RVA = "0x1FA7ED0", Offset = "0x1FA6AD0", VA = "0x181FA7ED0")]
		private void _LoadBondDataFromIdRange(string modeId, IEnumerable<string> bondIds, List<string> bannedBondList)
		{
		}

		// Token: 0x06024C8A RID: 150666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C8A")]
		[Address(RVA = "0x1FA9400", Offset = "0x1FA8000", VA = "0x181FA9400")]
		private void _RefreshEnemy()
		{
		}

		// Token: 0x06024C8B RID: 150667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C8B")]
		[Address(RVA = "0x1FA8C50", Offset = "0x1FA7850", VA = "0x181FA8C50")]
		private void _RefreshBond()
		{
		}

		// Token: 0x06024C8C RID: 150668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C8C")]
		[Address(RVA = "0x1FA9100", Offset = "0x1FA7D00", VA = "0x181FA9100")]
		private void _RefreshChess()
		{
		}

		// Token: 0x06024C8D RID: 150669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C8D")]
		[Address(RVA = "0x1FA9660", Offset = "0x1FA8260", VA = "0x181FA9660")]
		public AutoChessStageInfoGroupViewModel()
		{
		}

		// Token: 0x04033688 RID: 210568
		[Token(Token = "0x4033688")]
		private const int ENEMY_COUNT_PER_ROW = 3;

		// Token: 0x04033689 RID: 210569
		[Token(Token = "0x4033689")]
		private const int BOND_COUNT_PER_ROW = 9;

		// Token: 0x0403368A RID: 210570
		[Token(Token = "0x403368A")]
		private const int CHESS_COUNT_PER_ROW = 6;

		// Token: 0x0403368B RID: 210571
		[Token(Token = "0x403368B")]
		[FieldOffset(Offset = "0x10")]
		public List<UISimpleRecycleLayoutItemViewModel> modelList;

		// Token: 0x0403368C RID: 210572
		[Token(Token = "0x403368C")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessStageInfoBossViewModel m_bossModel;

		// Token: 0x0403368D RID: 210573
		[Token(Token = "0x403368D")]
		[FieldOffset(Offset = "0x20")]
		private List<AutoChessStageInfoEnemyTypeViewModel> m_enemyModel;

		// Token: 0x0403368E RID: 210574
		[Token(Token = "0x403368E")]
		[FieldOffset(Offset = "0x28")]
		private List<AutoChessStageInfoBondViewModel> m_tempBondModel;

		// Token: 0x0403368F RID: 210575
		[Token(Token = "0x403368F")]
		[FieldOffset(Offset = "0x30")]
		private List<AutoChessStageInfoBondViewModel> m_permBondModel;

		// Token: 0x04033690 RID: 210576
		[Token(Token = "0x4033690")]
		[FieldOffset(Offset = "0x38")]
		private List<AutoChessStageInfoChessGroupModel> m_chessGroupModel;

		// Token: 0x04033691 RID: 210577
		[Token(Token = "0x4033691")]
		[FieldOffset(Offset = "0x40")]
		private string m_actId;

		// Token: 0x04033692 RID: 210578
		[Token(Token = "0x4033692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033693 RID: 210579
		[Token(Token = "0x4033693")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadEnemyData;

		// Token: 0x04033694 RID: 210580
		[Token(Token = "0x4033694")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadBondData;

		// Token: 0x04033695 RID: 210581
		[Token(Token = "0x4033695")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBondDataFromIdRange;

		// Token: 0x04033696 RID: 210582
		[Token(Token = "0x4033696")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshEnemy;

		// Token: 0x04033697 RID: 210583
		[Token(Token = "0x4033697")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshBond;

		// Token: 0x04033698 RID: 210584
		[Token(Token = "0x4033698")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshChess;

		// Token: 0x04033699 RID: 210585
		[Token(Token = "0x4033699")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063AD RID: 25517
		[Token(Token = "0x20063AD")]
		public class Input
		{
			// Token: 0x06024C8E RID: 150670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Input()
			{
			}

			// Token: 0x06024C8F RID: 150671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C8F")]
			[Address(RVA = "0x1FACAD0", Offset = "0x1FAB6D0", VA = "0x181FACAD0")]
			public Input(AutoChessPrepareModel prepareModel)
			{
			}

			// Token: 0x06024C90 RID: 150672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024C90")]
			[Address(RVA = "0x1FAC9A0", Offset = "0x1FAB5A0", VA = "0x181FAC9A0")]
			public static AutoChessStageInfoGroupViewModel.Input CreateTrainingInput(string actId)
			{
				return null;
			}

			// Token: 0x0403369A RID: 210586
			[Token(Token = "0x403369A")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403369B RID: 210587
			[Token(Token = "0x403369B")]
			[FieldOffset(Offset = "0x18")]
			public string bossId;

			// Token: 0x0403369C RID: 210588
			[Token(Token = "0x403369C")]
			[FieldOffset(Offset = "0x20")]
			public List<string> enemyTypes;

			// Token: 0x0403369D RID: 210589
			[Token(Token = "0x403369D")]
			[FieldOffset(Offset = "0x28")]
			public List<string> bannedBondList;

			// Token: 0x0403369E RID: 210590
			[Token(Token = "0x403369E")]
			[FieldOffset(Offset = "0x30")]
			public List<string> trainingBondList;

			// Token: 0x0403369F RID: 210591
			[Token(Token = "0x403369F")]
			[FieldOffset(Offset = "0x38")]
			public string modeId;
		}
	}
}
