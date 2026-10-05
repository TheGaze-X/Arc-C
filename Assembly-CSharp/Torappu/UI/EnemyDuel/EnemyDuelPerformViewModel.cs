using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005002 RID: 20482
	[Token(Token = "0x2005002")]
	public class EnemyDuelPerformViewModel : IHotfixable
	{
		// Token: 0x0601E668 RID: 124520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E668")]
		[Address(RVA = "0x181C1A0", Offset = "0x181ADA0", VA = "0x18181C1A0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E669 RID: 124521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E669")]
		[Address(RVA = "0x181C480", Offset = "0x181B080", VA = "0x18181C480")]
		private void _LoadPlayerModels(Dictionary<string, EnemyDuelPlayerData> playerDict)
		{
		}

		// Token: 0x0601E66A RID: 124522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E66A")]
		[Address(RVA = "0x181C400", Offset = "0x181B000", VA = "0x18181C400")]
		private void _LoadOperationData(ActivityEnemyDuelData actData)
		{
		}

		// Token: 0x0601E66B RID: 124523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E66B")]
		[Address(RVA = "0x181C380", Offset = "0x181AF80", VA = "0x18181C380")]
		public void SetEmoticonDisabledStatus(bool isEmoticonDisabled)
		{
		}

		// Token: 0x0601E66C RID: 124524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E66C")]
		[Address(RVA = "0x181C780", Offset = "0x181B380", VA = "0x18181C780")]
		public EnemyDuelPerformViewModel()
		{
		}

		// Token: 0x04028A6F RID: 166511
		[Token(Token = "0x4028A6F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028A70 RID: 166512
		[Token(Token = "0x4028A70")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelModeType gameMode;

		// Token: 0x04028A71 RID: 166513
		[Token(Token = "0x4028A71")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyDuelBattleCharItemViewModel> leftSide;

		// Token: 0x04028A72 RID: 166514
		[Token(Token = "0x4028A72")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyDuelBattleCharItemViewModel> rightSide;

		// Token: 0x04028A73 RID: 166515
		[Token(Token = "0x4028A73")]
		[FieldOffset(Offset = "0x30")]
		public EnemyDuelChoiceSide currChoiceSide;

		// Token: 0x04028A74 RID: 166516
		[Token(Token = "0x4028A74")]
		[FieldOffset(Offset = "0x34")]
		public EnemyDuelChoiceType currChoiceType;

		// Token: 0x04028A75 RID: 166517
		[Token(Token = "0x4028A75")]
		[FieldOffset(Offset = "0x38")]
		public bool isCurrSurvive;

		// Token: 0x04028A76 RID: 166518
		[Token(Token = "0x4028A76")]
		[FieldOffset(Offset = "0x39")]
		public bool isAutoChoose;

		// Token: 0x04028A77 RID: 166519
		[Token(Token = "0x4028A77")]
		[FieldOffset(Offset = "0x3A")]
		public bool showWaitForOthers;

		// Token: 0x04028A78 RID: 166520
		[Token(Token = "0x4028A78")]
		[FieldOffset(Offset = "0x40")]
		public EnemyDuelTopBarViewModel topBarViewModel;

		// Token: 0x04028A79 RID: 166521
		[Token(Token = "0x4028A79")]
		[FieldOffset(Offset = "0x48")]
		public int operationStreakNum;

		// Token: 0x04028A7A RID: 166522
		[Token(Token = "0x4028A7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028A7B RID: 166523
		[Token(Token = "0x4028A7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadPlayerModels;

		// Token: 0x04028A7C RID: 166524
		[Token(Token = "0x4028A7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadOperationData;

		// Token: 0x04028A7D RID: 166525
		[Token(Token = "0x4028A7D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetEmoticonDisabledStatus;

		// Token: 0x04028A7E RID: 166526
		[Token(Token = "0x4028A7E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
