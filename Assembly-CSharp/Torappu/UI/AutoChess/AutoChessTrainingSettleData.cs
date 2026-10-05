using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200630C RID: 25356
	[Token(Token = "0x200630C")]
	public class AutoChessTrainingSettleData : IHotfixable
	{
		// Token: 0x060248A3 RID: 149667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248A3")]
		[Address(RVA = "0x1F644B0", Offset = "0x1F630B0", VA = "0x181F644B0")]
		public void LoadData(string actId, TrainingModeSettleData trainingData, ActAutoChessData actAutoChessData)
		{
		}

		// Token: 0x060248A4 RID: 149668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248A4")]
		[Address(RVA = "0x1F64EA0", Offset = "0x1F63AA0", VA = "0x181F64EA0")]
		private List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBossInfo> _GetBossInfoListFromActData(bool isGameWin, ActAutoChessData.ActAutoChessConstData constData)
		{
			return null;
		}

		// Token: 0x060248A5 RID: 149669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248A5")]
		[Address(RVA = "0x1F65000", Offset = "0x1F63C00", VA = "0x181F65000")]
		private List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleSquadInfo> _GetSquadListFromTrainingData(TrainingModeSettleData trainingData)
		{
			return null;
		}

		// Token: 0x060248A6 RID: 149670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248A6")]
		[Address(RVA = "0x1F64CF0", Offset = "0x1F638F0", VA = "0x181F64CF0")]
		private List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBondInfo> _GetBondListFromTrainingData(TrainingModeSettleData trainingData)
		{
			return null;
		}

		// Token: 0x060248A7 RID: 149671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248A7")]
		[Address(RVA = "0x1F65200", Offset = "0x1F63E00", VA = "0x181F65200")]
		private List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> _GetTeamInfoListFromActData(string actId, TrainingModeSettleData trainingData, ActAutoChessData actAutoChessData)
		{
			return null;
		}

		// Token: 0x060248A8 RID: 149672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60248A8")]
		[Address(RVA = "0x1F64850", Offset = "0x1F63450", VA = "0x181F64850")]
		private AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo _GenSelfSeasonSettleTeamInfo(string actId, TrainingModeSettleData trainingData)
		{
			return null;
		}

		// Token: 0x060248A9 RID: 149673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248A9")]
		[Address(RVA = "0x1F655B0", Offset = "0x1F641B0", VA = "0x181F655B0")]
		public AutoChessTrainingSettleData()
		{
		}

		// Token: 0x04032FAC RID: 208812
		[Token(Token = "0x4032FAC")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBossInfo> bossInfo;

		// Token: 0x04032FAD RID: 208813
		[Token(Token = "0x4032FAD")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleSquadInfo> squadList;

		// Token: 0x04032FAE RID: 208814
		[Token(Token = "0x4032FAE")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBondInfo> bondList;

		// Token: 0x04032FAF RID: 208815
		[Token(Token = "0x4032FAF")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> teamInfoList;

		// Token: 0x04032FB0 RID: 208816
		[Token(Token = "0x4032FB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032FB1 RID: 208817
		[Token(Token = "0x4032FB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBossInfoListFromActData;

		// Token: 0x04032FB2 RID: 208818
		[Token(Token = "0x4032FB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSquadListFromTrainingData;

		// Token: 0x04032FB3 RID: 208819
		[Token(Token = "0x4032FB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetBondListFromTrainingData;

		// Token: 0x04032FB4 RID: 208820
		[Token(Token = "0x4032FB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTeamInfoListFromActData;

		// Token: 0x04032FB5 RID: 208821
		[Token(Token = "0x4032FB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenSelfSeasonSettleTeamInfo;

		// Token: 0x04032FB6 RID: 208822
		[Token(Token = "0x4032FB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
