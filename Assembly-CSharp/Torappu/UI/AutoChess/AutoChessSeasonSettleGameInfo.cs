using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006272 RID: 25202
	[Token(Token = "0x2006272")]
	public class AutoChessSeasonSettleGameInfo : IHotfixable
	{
		// Token: 0x06024592 RID: 148882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024592")]
		[Address(RVA = "0x1F2EB20", Offset = "0x1F2D720", VA = "0x181F2EB20")]
		public AutoChessSeasonSettleGameInfo()
		{
		}

		// Token: 0x040328B6 RID: 207030
		[Token(Token = "0x40328B6")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x040328B7 RID: 207031
		[Token(Token = "0x40328B7")]
		[FieldOffset(Offset = "0x18")]
		public string bandId;

		// Token: 0x040328B8 RID: 207032
		[Token(Token = "0x40328B8")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x040328B9 RID: 207033
		[Token(Token = "0x40328B9")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x040328BA RID: 207034
		[Token(Token = "0x40328BA")]
		[FieldOffset(Offset = "0x30")]
		public bool gameFinished;

		// Token: 0x040328BB RID: 207035
		[Token(Token = "0x40328BB")]
		[FieldOffset(Offset = "0x31")]
		public bool isViolation;

		// Token: 0x040328BC RID: 207036
		[Token(Token = "0x40328BC")]
		[FieldOffset(Offset = "0x38")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBossInfo> bossRecord;

		// Token: 0x040328BD RID: 207037
		[Token(Token = "0x40328BD")]
		[FieldOffset(Offset = "0x40")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleSquadInfo> onStageChars;

		// Token: 0x040328BE RID: 207038
		[Token(Token = "0x40328BE")]
		[FieldOffset(Offset = "0x48")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBondInfo> onStageBond;

		// Token: 0x040328BF RID: 207039
		[Token(Token = "0x40328BF")]
		[FieldOffset(Offset = "0x50")]
		public List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> teamInfo;

		// Token: 0x040328C0 RID: 207040
		[Token(Token = "0x40328C0")]
		[FieldOffset(Offset = "0x58")]
		public AutoChessSeasonSettleGameInfo.AutoChessRecordInfos recordInfos;

		// Token: 0x040328C1 RID: 207041
		[Token(Token = "0x40328C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006273 RID: 25203
		[Token(Token = "0x2006273")]
		public class AutoChessSeasonSettleSquadInfo
		{
			// Token: 0x06024593 RID: 148883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024593")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessSeasonSettleSquadInfo()
			{
			}

			// Token: 0x040328C2 RID: 207042
			[Token(Token = "0x40328C2")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x040328C3 RID: 207043
			[Token(Token = "0x40328C3")]
			[FieldOffset(Offset = "0x18")]
			public List<string> equipId;
		}

		// Token: 0x02006274 RID: 25204
		[Token(Token = "0x2006274")]
		public class AutoChessSeasonSettleBondInfo
		{
			// Token: 0x06024594 RID: 148884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024594")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessSeasonSettleBondInfo()
			{
			}

			// Token: 0x040328C4 RID: 207044
			[Token(Token = "0x40328C4")]
			[FieldOffset(Offset = "0x10")]
			public string bondId;

			// Token: 0x040328C5 RID: 207045
			[Token(Token = "0x40328C5")]
			[FieldOffset(Offset = "0x18")]
			public int layer;
		}

		// Token: 0x02006275 RID: 25205
		[Token(Token = "0x2006275")]
		public class AutoChessSeasonSettleBossInfo
		{
			// Token: 0x06024595 RID: 148885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024595")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessSeasonSettleBossInfo()
			{
			}

			// Token: 0x040328C6 RID: 207046
			[Token(Token = "0x40328C6")]
			[FieldOffset(Offset = "0x10")]
			public string bossId;

			// Token: 0x040328C7 RID: 207047
			[Token(Token = "0x40328C7")]
			[FieldOffset(Offset = "0x18")]
			public bool isHiddenBoss;
		}

		// Token: 0x02006276 RID: 25206
		[Token(Token = "0x2006276")]
		public class AutoChessSeasonPlayerCard : IPlayerStatus, IHotfixable
		{
			// Token: 0x06024596 RID: 148886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024596")]
			[Address(RVA = "0x1F2E930", Offset = "0x1F2D530", VA = "0x181F2E930", Slot = "4")]
			public AvatarInfo GetAvatarInfo()
			{
				return null;
			}

			// Token: 0x06024597 RID: 148887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024597")]
			[Address(RVA = "0x1F2EA00", Offset = "0x1F2D600", VA = "0x181F2EA00", Slot = "5")]
			public string GetSecretarySkinId()
			{
				return null;
			}

			// Token: 0x06024598 RID: 148888 RVA: 0x000C3E88 File Offset: 0x000C2088
			[Token(Token = "0x6024598")]
			[Address(RVA = "0x1F2EA60", Offset = "0x1F2D660", VA = "0x181F2EA60", Slot = "6")]
			public bool GetSecretarySkinSp()
			{
				return default(bool);
			}

			// Token: 0x06024599 RID: 148889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024599")]
			[Address(RVA = "0x1F2EAC0", Offset = "0x1F2D6C0", VA = "0x181F2EAC0")]
			public AutoChessSeasonPlayerCard()
			{
			}

			// Token: 0x040328C8 RID: 207048
			[Token(Token = "0x40328C8")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			// Token: 0x040328C9 RID: 207049
			[Token(Token = "0x40328C9")]
			[FieldOffset(Offset = "0x18")]
			public string nickname;

			// Token: 0x040328CA RID: 207050
			[Token(Token = "0x40328CA")]
			[FieldOffset(Offset = "0x20")]
			public string nicknameNumber;

			// Token: 0x040328CB RID: 207051
			[Token(Token = "0x40328CB")]
			[FieldOffset(Offset = "0x28")]
			public int level;

			// Token: 0x040328CC RID: 207052
			[Token(Token = "0x40328CC")]
			[FieldOffset(Offset = "0x2C")]
			public int trophyNum;

			// Token: 0x040328CD RID: 207053
			[Token(Token = "0x40328CD")]
			[FieldOffset(Offset = "0x30")]
			public string secretary;

			// Token: 0x040328CE RID: 207054
			[Token(Token = "0x40328CE")]
			[FieldOffset(Offset = "0x38")]
			public string secretarySkinId;

			// Token: 0x040328CF RID: 207055
			[Token(Token = "0x40328CF")]
			[FieldOffset(Offset = "0x40")]
			public bool secretarySkinSp;

			// Token: 0x040328D0 RID: 207056
			[Token(Token = "0x40328D0")]
			[FieldOffset(Offset = "0x48")]
			public string avatarType;

			// Token: 0x040328D1 RID: 207057
			[Token(Token = "0x40328D1")]
			[FieldOffset(Offset = "0x50")]
			public string avatarId;

			// Token: 0x040328D2 RID: 207058
			[Token(Token = "0x40328D2")]
			[FieldOffset(Offset = "0x58")]
			public string nameCardSkinId;

			// Token: 0x040328D3 RID: 207059
			[Token(Token = "0x40328D3")]
			[FieldOffset(Offset = "0x60")]
			public int nameCardSkinTmpl;

			// Token: 0x040328D4 RID: 207060
			[Token(Token = "0x40328D4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAvatarInfo;

			// Token: 0x040328D5 RID: 207061
			[Token(Token = "0x40328D5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinId;

			// Token: 0x040328D6 RID: 207062
			[Token(Token = "0x40328D6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

			// Token: 0x040328D7 RID: 207063
			[Token(Token = "0x40328D7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006277 RID: 25207
		[Token(Token = "0x2006277")]
		public class AutoChessSeasonSettleTeamInfo
		{
			// Token: 0x0602459A RID: 148890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602459A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessSeasonSettleTeamInfo()
			{
			}

			// Token: 0x040328D8 RID: 207064
			[Token(Token = "0x40328D8")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x040328D9 RID: 207065
			[Token(Token = "0x40328D9")]
			[FieldOffset(Offset = "0x18")]
			public int channel;

			// Token: 0x040328DA RID: 207066
			[Token(Token = "0x40328DA")]
			[FieldOffset(Offset = "0x1C")]
			public int passRound;

			// Token: 0x040328DB RID: 207067
			[Token(Token = "0x40328DB")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessSettleGamePlayerStatus gameCode;

			// Token: 0x040328DC RID: 207068
			[Token(Token = "0x40328DC")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessSeasonSettleGameInfo.AutoChessSeasonPlayerCard card;

			// Token: 0x040328DD RID: 207069
			[Token(Token = "0x40328DD")]
			[FieldOffset(Offset = "0x30")]
			public int uidIndex;
		}

		// Token: 0x02006278 RID: 25208
		[Token(Token = "0x2006278")]
		public class AutoChessRecordInfos
		{
			// Token: 0x0602459B RID: 148891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602459B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessRecordInfos()
			{
			}

			// Token: 0x040328DE RID: 207070
			[Token(Token = "0x40328DE")]
			[FieldOffset(Offset = "0x10")]
			public int trophyRecord;

			// Token: 0x040328DF RID: 207071
			[Token(Token = "0x40328DF")]
			[FieldOffset(Offset = "0x14")]
			public int normalMilestone;

			// Token: 0x040328E0 RID: 207072
			[Token(Token = "0x40328E0")]
			[FieldOffset(Offset = "0x18")]
			public int dailyMilestone;

			// Token: 0x040328E1 RID: 207073
			[Token(Token = "0x40328E1")]
			[FieldOffset(Offset = "0x1C")]
			public int dailyProcessAdd;
		}
	}
}
