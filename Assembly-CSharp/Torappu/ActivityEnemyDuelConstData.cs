using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E08 RID: 3592
	[Token(Token = "0x2000E08")]
	public class ActivityEnemyDuelConstData
	{
		// Token: 0x06006ADB RID: 27355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelConstData()
		{
		}

		// Token: 0x04004A91 RID: 19089
		[Token(Token = "0x4004A91")]
		[FieldOffset(Offset = "0x10")]
		public float maxLoadingTime;

		// Token: 0x04004A92 RID: 19090
		[Token(Token = "0x4004A92")]
		[FieldOffset(Offset = "0x14")]
		public float maxRetryTimeInBattle;

		// Token: 0x04004A93 RID: 19091
		[Token(Token = "0x4004A93")]
		[FieldOffset(Offset = "0x18")]
		public float maxMatchTime;

		// Token: 0x04004A94 RID: 19092
		[Token(Token = "0x4004A94")]
		[FieldOffset(Offset = "0x1C")]
		public float maxRoomTime;

		// Token: 0x04004A95 RID: 19093
		[Token(Token = "0x4004A95")]
		[FieldOffset(Offset = "0x20")]
		public float maxRetryTimeInTeamRoom;

		// Token: 0x04004A96 RID: 19094
		[Token(Token = "0x4004A96")]
		[FieldOffset(Offset = "0x24")]
		public float roomReserveTime;

		// Token: 0x04004A97 RID: 19095
		[Token(Token = "0x4004A97")]
		[FieldOffset(Offset = "0x28")]
		public int minRoomNum;

		// Token: 0x04004A98 RID: 19096
		[Token(Token = "0x4004A98")]
		[FieldOffset(Offset = "0x2C")]
		public int roomFinishWaitingTime;

		// Token: 0x04004A99 RID: 19097
		[Token(Token = "0x4004A99")]
		[FieldOffset(Offset = "0x30")]
		public int roomMasterRestartWaitingTime;

		// Token: 0x04004A9A RID: 19098
		[Token(Token = "0x4004A9A")]
		[FieldOffset(Offset = "0x38")]
		public List<ActivityEnemyDuelConstData.PingCond> pingConds;

		// Token: 0x04004A9B RID: 19099
		[Token(Token = "0x4004A9B")]
		[FieldOffset(Offset = "0x40")]
		public float chatCd;

		// Token: 0x04004A9C RID: 19100
		[Token(Token = "0x4004A9C")]
		[FieldOffset(Offset = "0x44")]
		public float chatTime;

		// Token: 0x04004A9D RID: 19101
		[Token(Token = "0x4004A9D")]
		[FieldOffset(Offset = "0x48")]
		public int dailyMissionParam;

		// Token: 0x04004A9E RID: 19102
		[Token(Token = "0x4004A9E")]
		[FieldOffset(Offset = "0x50")]
		public ItemBundle dailyMissionReward;

		// Token: 0x04004A9F RID: 19103
		[Token(Token = "0x4004A9F")]
		[FieldOffset(Offset = "0x58")]
		public string dailyMissionName;

		// Token: 0x04004AA0 RID: 19104
		[Token(Token = "0x4004AA0")]
		[FieldOffset(Offset = "0x60")]
		public string dailyMissionDesc;

		// Token: 0x04004AA1 RID: 19105
		[Token(Token = "0x4004AA1")]
		[FieldOffset(Offset = "0x68")]
		public float maxOperatorDelay;

		// Token: 0x04004AA2 RID: 19106
		[Token(Token = "0x4004AA2")]
		[FieldOffset(Offset = "0x6C")]
		public float maxPlaySpeed;

		// Token: 0x04004AA3 RID: 19107
		[Token(Token = "0x4004AA3")]
		[FieldOffset(Offset = "0x70")]
		public float delayTimeNeedTip;

		// Token: 0x04004AA4 RID: 19108
		[Token(Token = "0x4004AA4")]
		[FieldOffset(Offset = "0x74")]
		public float netBlockTimeNeedTip;

		// Token: 0x04004AA5 RID: 19109
		[Token(Token = "0x4004AA5")]
		[FieldOffset(Offset = "0x78")]
		public float stageTimeMax;

		// Token: 0x04004AA6 RID: 19110
		[Token(Token = "0x4004AA6")]
		[FieldOffset(Offset = "0x7C")]
		public float npcCorrectProb;

		// Token: 0x04004AA7 RID: 19111
		[Token(Token = "0x4004AA7")]
		[FieldOffset(Offset = "0x80")]
		public int winStreakRoundNum;

		// Token: 0x04004AA8 RID: 19112
		[Token(Token = "0x4004AA8")]
		[FieldOffset(Offset = "0x84")]
		public int settlementPicNum;

		// Token: 0x04004AA9 RID: 19113
		[Token(Token = "0x4004AA9")]
		[FieldOffset(Offset = "0x88")]
		public int timeBeforeSelectAfterRoundBegin;

		// Token: 0x04004AAA RID: 19114
		[Token(Token = "0x4004AAA")]
		[FieldOffset(Offset = "0x8C")]
		public int npcMaxCorrectCountInStand;

		// Token: 0x04004AAB RID: 19115
		[Token(Token = "0x4004AAB")]
		[FieldOffset(Offset = "0x90")]
		public int battlePhaseTimeMax;

		// Token: 0x04004AAC RID: 19116
		[Token(Token = "0x4004AAC")]
		[FieldOffset(Offset = "0x94")]
		public int battleFinishToSettleTimeMax;

		// Token: 0x04004AAD RID: 19117
		[Token(Token = "0x4004AAD")]
		[FieldOffset(Offset = "0x98")]
		public float minBetCd;

		// Token: 0x04004AAE RID: 19118
		[Token(Token = "0x4004AAE")]
		[FieldOffset(Offset = "0xA0")]
		public string defaultEmoticonItemId;

		// Token: 0x04004AAF RID: 19119
		[Token(Token = "0x4004AAF")]
		[FieldOffset(Offset = "0xA8")]
		public string defaultEmoticonPicId;

		// Token: 0x04004AB0 RID: 19120
		[Token(Token = "0x4004AB0")]
		[FieldOffset(Offset = "0xB0")]
		public string defaultEnemyTag;

		// Token: 0x04004AB1 RID: 19121
		[Token(Token = "0x4004AB1")]
		[FieldOffset(Offset = "0xB8")]
		public int modeOperationRoundNumber;

		// Token: 0x04004AB2 RID: 19122
		[Token(Token = "0x4004AB2")]
		[FieldOffset(Offset = "0xBC")]
		public int modeOperationInitialScore;

		// Token: 0x04004AB3 RID: 19123
		[Token(Token = "0x4004AB3")]
		[FieldOffset(Offset = "0xC0")]
		public int modeOperationMaxScore;

		// Token: 0x04004AB4 RID: 19124
		[Token(Token = "0x4004AB4")]
		[FieldOffset(Offset = "0xC4")]
		public int modeOperationSelectTime;

		// Token: 0x04004AB5 RID: 19125
		[Token(Token = "0x4004AB5")]
		[FieldOffset(Offset = "0xC8")]
		public int modeOperationSelectTimeLast;

		// Token: 0x04004AB6 RID: 19126
		[Token(Token = "0x4004AB6")]
		[FieldOffset(Offset = "0xCC")]
		public float modeOperationSkipParam;

		// Token: 0x04004AB7 RID: 19127
		[Token(Token = "0x4004AB7")]
		[FieldOffset(Offset = "0xD0")]
		public float modeOperationBetParam;

		// Token: 0x04004AB8 RID: 19128
		[Token(Token = "0x4004AB8")]
		[FieldOffset(Offset = "0xD4")]
		public float modeOperationAllinParam;

		// Token: 0x04004AB9 RID: 19129
		[Token(Token = "0x4004AB9")]
		[FieldOffset(Offset = "0xD8")]
		public int modeOperationTopRank;

		// Token: 0x04004ABA RID: 19130
		[Token(Token = "0x4004ABA")]
		[FieldOffset(Offset = "0xDC")]
		public int modeOperationRankTime;

		// Token: 0x04004ABB RID: 19131
		[Token(Token = "0x4004ABB")]
		[FieldOffset(Offset = "0xE0")]
		public int modeSoloOperationRankTime;

		// Token: 0x04004ABC RID: 19132
		[Token(Token = "0x4004ABC")]
		[FieldOffset(Offset = "0xE4")]
		public int modeOperationRewardMultiplier;

		// Token: 0x04004ABD RID: 19133
		[Token(Token = "0x4004ABD")]
		[FieldOffset(Offset = "0xE8")]
		public int modeOperationRewardMultiplierAllin;

		// Token: 0x04004ABE RID: 19134
		[Token(Token = "0x4004ABE")]
		[FieldOffset(Offset = "0xEC")]
		public int modeOperationHotRoundNumber;

		// Token: 0x04004ABF RID: 19135
		[Token(Token = "0x4004ABF")]
		[FieldOffset(Offset = "0xF0")]
		public int modeSoloOperationSelectTime;

		// Token: 0x04004AC0 RID: 19136
		[Token(Token = "0x4004AC0")]
		[FieldOffset(Offset = "0xF4")]
		public int modeStandRoundNumber;

		// Token: 0x04004AC1 RID: 19137
		[Token(Token = "0x4004AC1")]
		[FieldOffset(Offset = "0xF8")]
		public int modeStandShieldTurn;

		// Token: 0x04004AC2 RID: 19138
		[Token(Token = "0x4004AC2")]
		[FieldOffset(Offset = "0xFC")]
		public int modeStandSelectTime;

		// Token: 0x04004AC3 RID: 19139
		[Token(Token = "0x4004AC3")]
		[FieldOffset(Offset = "0x100")]
		public int modeStandSelectTimeLast;

		// Token: 0x04004AC4 RID: 19140
		[Token(Token = "0x4004AC4")]
		[FieldOffset(Offset = "0x104")]
		public float modeStandAllinParam;

		// Token: 0x04004AC5 RID: 19141
		[Token(Token = "0x4004AC5")]
		[FieldOffset(Offset = "0x108")]
		public int modeStandTopRank;

		// Token: 0x04004AC6 RID: 19142
		[Token(Token = "0x4004AC6")]
		[FieldOffset(Offset = "0x10C")]
		public int modeStandRankTime;

		// Token: 0x04004AC7 RID: 19143
		[Token(Token = "0x4004AC7")]
		[FieldOffset(Offset = "0x110")]
		public int modeStandHotRoundNumber;

		// Token: 0x04004AC8 RID: 19144
		[Token(Token = "0x4004AC8")]
		[FieldOffset(Offset = "0x118")]
		public string milestoneName;

		// Token: 0x04004AC9 RID: 19145
		[Token(Token = "0x4004AC9")]
		[FieldOffset(Offset = "0x120")]
		public string milestoneItemId;

		// Token: 0x04004ACA RID: 19146
		[Token(Token = "0x4004ACA")]
		[FieldOffset(Offset = "0x128")]
		public string milestoneItemName;

		// Token: 0x04004ACB RID: 19147
		[Token(Token = "0x4004ACB")]
		[FieldOffset(Offset = "0x130")]
		public string milestoneItemText;

		// Token: 0x04004ACC RID: 19148
		[Token(Token = "0x4004ACC")]
		[FieldOffset(Offset = "0x138")]
		public string milestoneTrackId;

		// Token: 0x04004ACD RID: 19149
		[Token(Token = "0x4004ACD")]
		[FieldOffset(Offset = "0x140")]
		public string entryVideoId;

		// Token: 0x04004ACE RID: 19150
		[Token(Token = "0x4004ACE")]
		[FieldOffset(Offset = "0x148")]
		public string entryTabText;

		// Token: 0x04004ACF RID: 19151
		[Token(Token = "0x4004ACF")]
		[FieldOffset(Offset = "0x150")]
		public string matchTabText;

		// Token: 0x04004AD0 RID: 19152
		[Token(Token = "0x4004AD0")]
		[FieldOffset(Offset = "0x158")]
		public string modeOperationId;

		// Token: 0x04004AD1 RID: 19153
		[Token(Token = "0x4004AD1")]
		[FieldOffset(Offset = "0x160")]
		public string modeStandId;

		// Token: 0x04004AD2 RID: 19154
		[Token(Token = "0x4004AD2")]
		[FieldOffset(Offset = "0x168")]
		public string multiPreposedModeId;

		// Token: 0x04004AD3 RID: 19155
		[Token(Token = "0x4004AD3")]
		[FieldOffset(Offset = "0x170")]
		public string entryMusicName;

		// Token: 0x04004AD4 RID: 19156
		[Token(Token = "0x4004AD4")]
		[FieldOffset(Offset = "0x178")]
		public string milestonePlanName;

		// Token: 0x04004AD5 RID: 19157
		[Token(Token = "0x4004AD5")]
		[FieldOffset(Offset = "0x180")]
		public string modeCondLockText;

		// Token: 0x04004AD6 RID: 19158
		[Token(Token = "0x4004AD6")]
		[FieldOffset(Offset = "0x188")]
		public string modeTimeLockText;

		// Token: 0x04004AD7 RID: 19159
		[Token(Token = "0x4004AD7")]
		[FieldOffset(Offset = "0x190")]
		public float titlePicRotateTime;

		// Token: 0x04004AD8 RID: 19160
		[Token(Token = "0x4004AD8")]
		[FieldOffset(Offset = "0x198")]
		public string titlePicId;

		// Token: 0x02000E09 RID: 3593
		[Token(Token = "0x2000E09")]
		public class PingCond
		{
			// Token: 0x06006ADC RID: 27356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ADC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PingCond()
			{
			}

			// Token: 0x04004AD9 RID: 19161
			[Token(Token = "0x4004AD9")]
			[FieldOffset(Offset = "0x10")]
			public int cond;

			// Token: 0x04004ADA RID: 19162
			[Token(Token = "0x4004ADA")]
			[FieldOffset(Offset = "0x18")]
			public string txt;
		}
	}
}
