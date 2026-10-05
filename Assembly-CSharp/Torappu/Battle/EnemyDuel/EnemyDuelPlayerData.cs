using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026CC RID: 9932
	[Token(Token = "0x20026CC")]
	public class EnemyDuelPlayerData : IHotfixable, IComparable<EnemyDuelPlayerData>
	{
		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x060102DD RID: 66269 RVA: 0x00062AC0 File Offset: 0x00060CC0
		// (set) Token: 0x060102DE RID: 66270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002340")]
		public bool isSelf
		{
			[Token(Token = "0x60102DD")]
			[Address(RVA = "0x7E8130", Offset = "0x7E6D30", VA = "0x1807E8130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60102DE")]
			[Address(RVA = "0x7E8370", Offset = "0x7E6F70", VA = "0x1807E8370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x060102DF RID: 66271 RVA: 0x00062AD8 File Offset: 0x00060CD8
		[Token(Token = "0x17002341")]
		public bool hasChosen
		{
			[Token(Token = "0x60102DF")]
			[Address(RVA = "0x7E8070", Offset = "0x7E6C70", VA = "0x1807E8070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x060102E0 RID: 66272 RVA: 0x00062AF0 File Offset: 0x00060CF0
		[Token(Token = "0x17002342")]
		public bool hasShield
		{
			[Token(Token = "0x60102E0")]
			[Address(RVA = "0x7E80D0", Offset = "0x7E6CD0", VA = "0x1807E80D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x060102E1 RID: 66273 RVA: 0x00062B08 File Offset: 0x00060D08
		[Token(Token = "0x17002343")]
		public bool justUsedShield
		{
			[Token(Token = "0x60102E1")]
			[Address(RVA = "0x7E81F0", Offset = "0x7E6DF0", VA = "0x1807E81F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x060102E2 RID: 66274 RVA: 0x00062B20 File Offset: 0x00060D20
		[Token(Token = "0x17002344")]
		public EnemyDuelChoiceSide curChoiceSide
		{
			[Token(Token = "0x60102E2")]
			[Address(RVA = "0x7E7FB0", Offset = "0x7E6BB0", VA = "0x1807E7FB0")]
			get
			{
				return EnemyDuelChoiceSide.ABSTAIN;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x060102E3 RID: 66275 RVA: 0x00062B38 File Offset: 0x00060D38
		[Token(Token = "0x17002345")]
		public EnemyDuelRoundResult curRoundResult
		{
			[Token(Token = "0x60102E3")]
			[Address(RVA = "0x7E8010", Offset = "0x7E6C10", VA = "0x1807E8010")]
			get
			{
				return EnemyDuelRoundResult.NONE;
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x060102E4 RID: 66276 RVA: 0x00062B50 File Offset: 0x00060D50
		[Token(Token = "0x17002346")]
		public bool lastChoiceCorrect
		{
			[Token(Token = "0x60102E4")]
			[Address(RVA = "0x7E8250", Offset = "0x7E6E50", VA = "0x1807E8250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x060102E5 RID: 66277 RVA: 0x00062B68 File Offset: 0x00060D68
		[Token(Token = "0x17002347")]
		public bool lastChoiceIsRight
		{
			[Token(Token = "0x60102E5")]
			[Address(RVA = "0x7E82B0", Offset = "0x7E6EB0", VA = "0x1807E82B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x060102E6 RID: 66278 RVA: 0x00062B80 File Offset: 0x00060D80
		[Token(Token = "0x17002348")]
		public bool isSurvive
		{
			[Token(Token = "0x60102E6")]
			[Address(RVA = "0x7E8190", Offset = "0x7E6D90", VA = "0x1807E8190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x060102E7 RID: 66279 RVA: 0x00062B98 File Offset: 0x00060D98
		[Token(Token = "0x17002349")]
		public EnemyDuelShieldState shieldState
		{
			[Token(Token = "0x60102E7")]
			[Address(RVA = "0x7E8310", Offset = "0x7E6F10", VA = "0x1807E8310")]
			get
			{
				return EnemyDuelShieldState.NO_SHIELD;
			}
		}

		// Token: 0x060102E8 RID: 66280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102E8")]
		[Address(RVA = "0x7E7F00", Offset = "0x7E6B00", VA = "0x1807E7F00")]
		public EnemyDuelPlayerData(EnemyDuelModeType subModeType, int initScore)
		{
		}

		// Token: 0x060102E9 RID: 66281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102E9")]
		[Address(RVA = "0x7E7A10", Offset = "0x7E6610", VA = "0x1807E7A10")]
		public void RefreshNpcChoice(float scoreLeft, float scoreRight, Random playerRandom)
		{
		}

		// Token: 0x060102EA RID: 66282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102EA")]
		[Address(RVA = "0x7E7920", Offset = "0x7E6520", VA = "0x1807E7920")]
		public void RefreshNpcChoiceType(ActivityEnemyDuelRoundData roundData, float allinProb, Random playerRandom)
		{
		}

		// Token: 0x060102EB RID: 66283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102EB")]
		[Address(RVA = "0x7E7B40", Offset = "0x7E6740", VA = "0x1807E7B40")]
		public void ResetChoice()
		{
		}

		// Token: 0x060102EC RID: 66284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102EC")]
		[Address(RVA = "0x7E7BB0", Offset = "0x7E67B0", VA = "0x1807E7BB0")]
		public void UpdateChoiceFromBetData(EnemyDuelBattleStatus.BetItem betData, int basicBetScore, ActivityEnemyDuelConstData constData)
		{
		}

		// Token: 0x060102ED RID: 66285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102ED")]
		[Address(RVA = "0x7E7DF0", Offset = "0x7E69F0", VA = "0x1807E7DF0")]
		public void UpdateSettleScore(int roundIndex, EnemyDuelBattleStatus.RoundLeaderBoard leaderBoard)
		{
		}

		// Token: 0x060102EE RID: 66286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102EE")]
		[Address(RVA = "0x7E7CE0", Offset = "0x7E68E0", VA = "0x1807E7CE0")]
		public void UpdateSettleScore(int roundIndex, EnemyDuelRoundResult result)
		{
		}

		// Token: 0x060102EF RID: 66287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102EF")]
		[Address(RVA = "0x7E77C0", Offset = "0x7E63C0", VA = "0x1807E77C0")]
		public void FastForwardNpcScore(int roundIndex, bool isCorrect, ActivityEnemyDuelConstData constData, ActivityEnemyDuelRoundData roundData)
		{
		}

		// Token: 0x060102F0 RID: 66288 RVA: 0x00062BB0 File Offset: 0x00060DB0
		[Token(Token = "0x60102F0")]
		[Address(RVA = "0x7E7580", Offset = "0x7E6180", VA = "0x1807E7580", Slot = "4")]
		public int CompareTo(EnemyDuelPlayerData other)
		{
			return 0;
		}

		// Token: 0x040120CA RID: 73930
		[Token(Token = "0x40120CA")]
		[FieldOffset(Offset = "0x10")]
		public string playerId;

		// Token: 0x040120CB RID: 73931
		[Token(Token = "0x40120CB")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x040120CC RID: 73932
		[Token(Token = "0x40120CC")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x040120CD RID: 73933
		[Token(Token = "0x40120CD")]
		[FieldOffset(Offset = "0x38")]
		public string npcAvatarId;

		// Token: 0x040120CE RID: 73934
		[Token(Token = "0x40120CE")]
		[FieldOffset(Offset = "0x40")]
		public int curScore;

		// Token: 0x040120CF RID: 73935
		[Token(Token = "0x40120CF")]
		[FieldOffset(Offset = "0x44")]
		public int betScore;

		// Token: 0x040120D0 RID: 73936
		[Token(Token = "0x40120D0")]
		[FieldOffset(Offset = "0x48")]
		public int rewardScore;

		// Token: 0x040120D1 RID: 73937
		[Token(Token = "0x40120D1")]
		[FieldOffset(Offset = "0x4C")]
		public int scoreBeforeSettle;

		// Token: 0x040120D2 RID: 73938
		[Token(Token = "0x40120D2")]
		[FieldOffset(Offset = "0x50")]
		public int winStreak;

		// Token: 0x040120D3 RID: 73939
		[Token(Token = "0x40120D3")]
		[FieldOffset(Offset = "0x54")]
		public int maxRound;

		// Token: 0x040120D4 RID: 73940
		[Token(Token = "0x40120D4")]
		[FieldOffset(Offset = "0x58")]
		public EnemyDuelChoiceType curChoiceType;

		// Token: 0x040120D5 RID: 73941
		[Token(Token = "0x40120D5")]
		[FieldOffset(Offset = "0x5C")]
		public bool isNpc;

		// Token: 0x040120D6 RID: 73942
		[Token(Token = "0x40120D6")]
		[FieldOffset(Offset = "0x60")]
		public long updateTs;

		// Token: 0x040120D7 RID: 73943
		[Token(Token = "0x40120D7")]
		[FieldOffset(Offset = "0x68")]
		private EnemyDuelRoundResult m_curRoundResult;

		// Token: 0x040120D8 RID: 73944
		[Token(Token = "0x40120D8")]
		[FieldOffset(Offset = "0x6C")]
		private EnemyDuelChoiceSide m_curChoiceSide;

		// Token: 0x040120D9 RID: 73945
		[Token(Token = "0x40120D9")]
		[FieldOffset(Offset = "0x70")]
		private bool m_lastChoiceCorrect;

		// Token: 0x040120DA RID: 73946
		[Token(Token = "0x40120DA")]
		[FieldOffset(Offset = "0x71")]
		private bool m_lastChoiceIsRight;

		// Token: 0x040120DB RID: 73947
		[Token(Token = "0x40120DB")]
		[FieldOffset(Offset = "0x72")]
		private bool m_choiceIsRight;

		// Token: 0x040120DC RID: 73948
		[Token(Token = "0x40120DC")]
		[FieldOffset(Offset = "0x73")]
		private bool m_hasChosen;

		// Token: 0x040120DD RID: 73949
		[Token(Token = "0x40120DD")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isSurvive;

		// Token: 0x040120DE RID: 73950
		[Token(Token = "0x40120DE")]
		[FieldOffset(Offset = "0x78")]
		private EnemyDuelShieldState m_shieldState;

		// Token: 0x040120E0 RID: 73952
		[Token(Token = "0x40120E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSelf;

		// Token: 0x040120E1 RID: 73953
		[Token(Token = "0x40120E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isSelf;

		// Token: 0x040120E2 RID: 73954
		[Token(Token = "0x40120E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasChosen;

		// Token: 0x040120E3 RID: 73955
		[Token(Token = "0x40120E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasShield;

		// Token: 0x040120E4 RID: 73956
		[Token(Token = "0x40120E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_justUsedShield;

		// Token: 0x040120E5 RID: 73957
		[Token(Token = "0x40120E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_curChoiceSide;

		// Token: 0x040120E6 RID: 73958
		[Token(Token = "0x40120E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_curRoundResult;

		// Token: 0x040120E7 RID: 73959
		[Token(Token = "0x40120E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_lastChoiceCorrect;

		// Token: 0x040120E8 RID: 73960
		[Token(Token = "0x40120E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_lastChoiceIsRight;

		// Token: 0x040120E9 RID: 73961
		[Token(Token = "0x40120E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isSurvive;

		// Token: 0x040120EA RID: 73962
		[Token(Token = "0x40120EA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_shieldState;

		// Token: 0x040120EB RID: 73963
		[Token(Token = "0x40120EB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040120EC RID: 73964
		[Token(Token = "0x40120EC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RefreshNpcChoice;

		// Token: 0x040120ED RID: 73965
		[Token(Token = "0x40120ED")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshNpcChoiceType;

		// Token: 0x040120EE RID: 73966
		[Token(Token = "0x40120EE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ResetChoice;

		// Token: 0x040120EF RID: 73967
		[Token(Token = "0x40120EF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateChoiceFromBetData;

		// Token: 0x040120F0 RID: 73968
		[Token(Token = "0x40120F0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateSettleScore;

		// Token: 0x040120F1 RID: 73969
		[Token(Token = "0x40120F1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_UpdateSettleScore;

		// Token: 0x040120F2 RID: 73970
		[Token(Token = "0x40120F2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FastForwardNpcScore;

		// Token: 0x040120F3 RID: 73971
		[Token(Token = "0x40120F3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
