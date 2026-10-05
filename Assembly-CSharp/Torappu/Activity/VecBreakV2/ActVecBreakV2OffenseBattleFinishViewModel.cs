using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF8 RID: 28152
	[Token(Token = "0x2006DF8")]
	public class ActVecBreakV2OffenseBattleFinishViewModel : IHotfixable
	{
		// Token: 0x0602813D RID: 164157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813D")]
		[Address(RVA = "0x23525D0", Offset = "0x23511D0", VA = "0x1823525D0")]
		public void LoadData()
		{
		}

		// Token: 0x0602813E RID: 164158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813E")]
		[Address(RVA = "0x2353CE0", Offset = "0x23528E0", VA = "0x182353CE0")]
		private void _LoadStageInfo(BattleInOut.InParams battleInput, ActVecBreakV2Data actData)
		{
		}

		// Token: 0x0602813F RID: 164159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813F")]
		[Address(RVA = "0x23539B0", Offset = "0x23525B0", VA = "0x1823539B0")]
		private void _LoadNormalStageInfo(ActVecBreakV2Data actData)
		{
		}

		// Token: 0x06028140 RID: 164160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028140")]
		[Address(RVA = "0x2353850", Offset = "0x2352450", VA = "0x182353850")]
		private void _LoadHardStageInfo(ActVecBreakV2Data actData)
		{
		}

		// Token: 0x06028141 RID: 164161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028141")]
		[Address(RVA = "0x2352C20", Offset = "0x2351820", VA = "0x182352C20")]
		private void _LoadBattleInfo(ActVecBreakV2Data actData, PlayerActivity.PlayerVecBreakV2 playerData, BattleInOut.InParams battleInput, VecBreakV2OffenseFinishBattleResponse battleFinishResponse)
		{
		}

		// Token: 0x06028142 RID: 164162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028142")]
		[Address(RVA = "0x2353000", Offset = "0x2351C00", VA = "0x182353000")]
		private void _LoadBuffInfo(ActVecBreakV2Data actData, PlayerActivity.PlayerVecBreakV2 playerData, VecBreakV2OffenseFinishBattleResponse finishResponse)
		{
		}

		// Token: 0x06028143 RID: 164163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028143")]
		[Address(RVA = "0x23533C0", Offset = "0x2351FC0", VA = "0x1823533C0")]
		private void _LoadCharInfo(BattleInOut.InParams battleInput)
		{
		}

		// Token: 0x06028144 RID: 164164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028144")]
		[Address(RVA = "0x2353BF0", Offset = "0x23527F0", VA = "0x182353BF0")]
		private void _LoadPlayerInfo()
		{
		}

		// Token: 0x06028145 RID: 164165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028145")]
		[Address(RVA = "0x2354070", Offset = "0x2352C70", VA = "0x182354070")]
		private void _LoadUnlockInfo(ActVecBreakV2Data actData, VecBreakV2OffenseFinishBattleResponse finishResponse)
		{
		}

		// Token: 0x06028146 RID: 164166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028146")]
		[Address(RVA = "0x23541B0", Offset = "0x2352DB0", VA = "0x1823541B0")]
		public ActVecBreakV2OffenseBattleFinishViewModel()
		{
		}

		// Token: 0x04038DB1 RID: 232881
		[Token(Token = "0x4038DB1")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04038DB2 RID: 232882
		[Token(Token = "0x4038DB2")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04038DB3 RID: 232883
		[Token(Token = "0x4038DB3")]
		[FieldOffset(Offset = "0x20")]
		public OffenseStateType offenseStateType;

		// Token: 0x04038DB4 RID: 232884
		[Token(Token = "0x4038DB4")]
		[FieldOffset(Offset = "0x28")]
		public ActVecBreakV2OffenseStageModel normalStageModel;

		// Token: 0x04038DB5 RID: 232885
		[Token(Token = "0x4038DB5")]
		[FieldOffset(Offset = "0x30")]
		public ActVecBreakV2HardStageModel hardStageModel;

		// Token: 0x04038DB6 RID: 232886
		[Token(Token = "0x4038DB6")]
		[FieldOffset(Offset = "0x38")]
		public bool canUseBuff;

		// Token: 0x04038DB7 RID: 232887
		[Token(Token = "0x4038DB7")]
		[FieldOffset(Offset = "0x40")]
		public List<ActVecBreakV2OffenseBattleFinishBuffItemModel> buffItemList;

		// Token: 0x04038DB8 RID: 232888
		[Token(Token = "0x4038DB8")]
		[FieldOffset(Offset = "0x48")]
		public List<ActVecBreakV2OffenseBattleFinishCharModel> charModelList;

		// Token: 0x04038DB9 RID: 232889
		[Token(Token = "0x4038DB9")]
		[FieldOffset(Offset = "0x50")]
		public ActVecBreakV2OffenseBattleFinishCharModel assistCharModel;

		// Token: 0x04038DBA RID: 232890
		[Token(Token = "0x4038DBA")]
		[FieldOffset(Offset = "0x58")]
		public string playerNameWithNumber;

		// Token: 0x04038DBB RID: 232891
		[Token(Token = "0x4038DBB")]
		[FieldOffset(Offset = "0x60")]
		public long stageCompleteTimeStamp;

		// Token: 0x04038DBC RID: 232892
		[Token(Token = "0x4038DBC")]
		[FieldOffset(Offset = "0x68")]
		public string stageCode;

		// Token: 0x04038DBD RID: 232893
		[Token(Token = "0x4038DBD")]
		[FieldOffset(Offset = "0x70")]
		public string stageName;

		// Token: 0x04038DBE RID: 232894
		[Token(Token = "0x4038DBE")]
		[FieldOffset(Offset = "0x78")]
		public int milestoneBefore;

		// Token: 0x04038DBF RID: 232895
		[Token(Token = "0x4038DBF")]
		[FieldOffset(Offset = "0x7C")]
		public int milestoneAfter;

		// Token: 0x04038DC0 RID: 232896
		[Token(Token = "0x4038DC0")]
		[FieldOffset(Offset = "0x80")]
		public string milestoneItemId;

		// Token: 0x04038DC1 RID: 232897
		[Token(Token = "0x4038DC1")]
		[FieldOffset(Offset = "0x88")]
		public string milestoneItemIconId;

		// Token: 0x04038DC2 RID: 232898
		[Token(Token = "0x4038DC2")]
		[FieldOffset(Offset = "0x90")]
		public bool unlockHardZone;

		// Token: 0x04038DC3 RID: 232899
		[Token(Token = "0x4038DC3")]
		[FieldOffset(Offset = "0x98")]
		public string offenseHardUnlockToast;

		// Token: 0x04038DC4 RID: 232900
		[Token(Token = "0x4038DC4")]
		[FieldOffset(Offset = "0xA0")]
		public CharWordData charWord;

		// Token: 0x04038DC5 RID: 232901
		[Token(Token = "0x4038DC5")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_useBuff;

		// Token: 0x04038DC6 RID: 232902
		[Token(Token = "0x4038DC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038DC7 RID: 232903
		[Token(Token = "0x4038DC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadStageInfo;

		// Token: 0x04038DC8 RID: 232904
		[Token(Token = "0x4038DC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadNormalStageInfo;

		// Token: 0x04038DC9 RID: 232905
		[Token(Token = "0x4038DC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadHardStageInfo;

		// Token: 0x04038DCA RID: 232906
		[Token(Token = "0x4038DCA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadBattleInfo;

		// Token: 0x04038DCB RID: 232907
		[Token(Token = "0x4038DCB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadBuffInfo;

		// Token: 0x04038DCC RID: 232908
		[Token(Token = "0x4038DCC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadCharInfo;

		// Token: 0x04038DCD RID: 232909
		[Token(Token = "0x4038DCD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadPlayerInfo;

		// Token: 0x04038DCE RID: 232910
		[Token(Token = "0x4038DCE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadUnlockInfo;

		// Token: 0x04038DCF RID: 232911
		[Token(Token = "0x4038DCF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
