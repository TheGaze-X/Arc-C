using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.EnemyDuel;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.DataCenter
{
	// Token: 0x02001E19 RID: 7705
	[Token(Token = "0x2001E19")]
	public class EnemyDuelDataCenter : SingletonWithMonoHost<EnemyDuelDataCenter, BattleController>, IDisposable
	{
		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x000465C0 File Offset: 0x000447C0
		[Token(Token = "0x170016F0")]
		public bool isCurAutoChoose
		{
			[Token(Token = "0x600BE54")]
			[Address(RVA = "0x33C49A0", Offset = "0x33C35A0", VA = "0x1833C49A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x000465D8 File Offset: 0x000447D8
		[Token(Token = "0x170016F1")]
		public bool isRoomOwner
		{
			[Token(Token = "0x600BE55")]
			[Address(RVA = "0x33C4A60", Offset = "0x33C3660", VA = "0x1833C4A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600BE56 RID: 48726 RVA: 0x000465F0 File Offset: 0x000447F0
		[Token(Token = "0x170016F2")]
		public int curRoundIndex
		{
			[Token(Token = "0x600BE56")]
			[Address(RVA = "0x33C48E0", Offset = "0x33C34E0", VA = "0x1833C48E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F3")]
		public ActivityEnemyDuelRoundData curRoundData
		{
			[Token(Token = "0x600BE57")]
			[Address(RVA = "0x33C4880", Offset = "0x33C3480", VA = "0x1833C4880")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x0600BE58 RID: 48728 RVA: 0x00046608 File Offset: 0x00044808
		[Token(Token = "0x170016F4")]
		public EnemyDuelModeType curModeType
		{
			[Token(Token = "0x600BE58")]
			[Address(RVA = "0x33C4810", Offset = "0x33C3410", VA = "0x1833C4810")]
			get
			{
				return EnemyDuelModeType.OPERATION;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x00046620 File Offset: 0x00044820
		[Token(Token = "0x170016F5")]
		public EnemyDuelServiceGameState curRoundState
		{
			[Token(Token = "0x600BE59")]
			[Address(RVA = "0x33C4940", Offset = "0x33C3540", VA = "0x1833C4940")]
			get
			{
				return EnemyDuelServiceGameState.NONE;
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x0600BE5A RID: 48730 RVA: 0x00046638 File Offset: 0x00044838
		[Token(Token = "0x170016F6")]
		public bool isGameOver
		{
			[Token(Token = "0x600BE5A")]
			[Address(RVA = "0x33C4A00", Offset = "0x33C3600", VA = "0x1833C4A00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600BE5B RID: 48731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F7")]
		public ActivityEnemyDuelConstData constData
		{
			[Token(Token = "0x600BE5B")]
			[Address(RVA = "0x33C47A0", Offset = "0x33C33A0", VA = "0x1833C47A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F8")]
		public string actId
		{
			[Token(Token = "0x600BE5C")]
			[Address(RVA = "0x33C4740", Offset = "0x33C3340", VA = "0x1833C4740")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F9")]
		public string sceneId
		{
			[Token(Token = "0x600BE5D")]
			[Address(RVA = "0x33C4AC0", Offset = "0x33C36C0", VA = "0x1833C4AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5E")]
		[Address(RVA = "0x33C4460", Offset = "0x33C3060", VA = "0x1833C4460")]
		private EnemyDuelDataCenter()
		{
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016FA")]
		public ActivityEnemyDuelData actData
		{
			[Token(Token = "0x600BE5F")]
			[Address(RVA = "0x33C46E0", Offset = "0x33C32E0", VA = "0x1833C46E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016FB")]
		public ActivityEnemyDuelModeData subModeData
		{
			[Token(Token = "0x600BE60")]
			[Address(RVA = "0x33C4B20", Offset = "0x33C3720", VA = "0x1833C4B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE61")]
		[Address(RVA = "0x33C3070", Offset = "0x33C1C70", VA = "0x1833C3070")]
		public void LoadAndInitData(ActivityEnemyDuelData actData, ActivityEnemyDuelModeData subModeData, string actId, EnemyDuelInput inputData)
		{
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE62")]
		[Address(RVA = "0x33C37B0", Offset = "0x33C23B0", VA = "0x1833C37B0")]
		public void PreparePlayerDataBeforeWaveStart(int roundIndex, ActivityEnemyDuelRoundData roundData)
		{
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE63")]
		[Address(RVA = "0x33C2B30", Offset = "0x33C1730", VA = "0x1833C2B30")]
		public void ForceUpdateRoundAllStateData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE64")]
		[Address(RVA = "0x33C32C0", Offset = "0x33C1EC0", VA = "0x1833C32C0")]
		public void OnRoundChanged(int roundIndex)
		{
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE65")]
		[Address(RVA = "0x33C38F0", Offset = "0x33C24F0", VA = "0x1833C38F0")]
		public void UpdateRoundStateData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE66")]
		[Address(RVA = "0x33C2810", Offset = "0x33C1410", VA = "0x1833C2810")]
		public void AssignPlayerDataDict(Dictionary<string, EnemyDuelPlayerData> playerDataDict)
		{
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE67")]
		[Address(RVA = "0x33C2890", Offset = "0x33C1490", VA = "0x1833C2890")]
		public void AssignSelfPlayerData(EnemyDuelPlayerData playerData)
		{
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE68")]
		[Address(RVA = "0x33C2770", Offset = "0x33C1370", VA = "0x1833C2770")]
		public void AddTeamData(EnemyDuelTeamData teamData)
		{
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE69")]
		[Address(RVA = "0x33C3850", Offset = "0x33C2450", VA = "0x1833C3850")]
		public void RefreshTeamList()
		{
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6A")]
		[Address(RVA = "0x33C3430", Offset = "0x33C2030", VA = "0x1833C3430")]
		public void OnSingleModeFinishRound(EnemyDuelRoundResult result, int remainingRoundCnt)
		{
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6B")]
		[Address(RVA = "0x33C31F0", Offset = "0x33C1DF0", VA = "0x1833C31F0")]
		public void OnFinishGame()
		{
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6C")]
		[Address(RVA = "0x33C3250", Offset = "0x33C1E50", VA = "0x1833C3250")]
		public void OnGameQuit()
		{
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE6D")]
		[Address(RVA = "0x33C2E00", Offset = "0x33C1A00", VA = "0x1833C2E00")]
		public Dictionary<string, EnemyDuelPlayerData> GetPlayerDataDict()
		{
			return null;
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE6E")]
		[Address(RVA = "0x33C2E60", Offset = "0x33C1A60", VA = "0x1833C2E60")]
		public EnemyDuelPlayerData GetSelfPlayerData()
		{
			return null;
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE6F")]
		[Address(RVA = "0x33C2F30", Offset = "0x33C1B30", VA = "0x1833C2F30")]
		public List<EnemyDuelEnemyGenerationData> GetTeamData(bool isLeft)
		{
			return null;
		}

		// Token: 0x0600BE70 RID: 48752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE70")]
		[Address(RVA = "0x33C2D90", Offset = "0x33C1990", VA = "0x1833C2D90")]
		public EnemyDuelBetData GetBetData()
		{
			return null;
		}

		// Token: 0x0600BE71 RID: 48753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE71")]
		[Address(RVA = "0x33C2EC0", Offset = "0x33C1AC0", VA = "0x1833C2EC0")]
		public EnemyDuelSettleData GetSettleData()
		{
			return null;
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE72")]
		[Address(RVA = "0x33C2A70", Offset = "0x33C1670", VA = "0x1833C2A70")]
		public EnemyDuelSingleFinishSettle FetchSingleFinishOutput()
		{
			return null;
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE73")]
		[Address(RVA = "0x33C3EC0", Offset = "0x33C2AC0", VA = "0x1833C3EC0")]
		private void _RefreshPlayerBetData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE74")]
		[Address(RVA = "0x33C41A0", Offset = "0x33C2DA0", VA = "0x1833C41A0")]
		private void _RefreshPlayerSettleData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x00046650 File Offset: 0x00044850
		[Token(Token = "0x600BE75")]
		[Address(RVA = "0x33C3A90", Offset = "0x33C2690", VA = "0x1833C3A90")]
		private bool _CheckGameOver()
		{
			return default(bool);
		}

		// Token: 0x0600BE76 RID: 48758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE76")]
		[Address(RVA = "0x33C3D40", Offset = "0x33C2940", VA = "0x1833C3D40")]
		private void _LogRoundPlayerResult()
		{
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE77")]
		[Address(RVA = "0x33C3B10", Offset = "0x33C2710", VA = "0x1833C3B10")]
		private void _LogGameResult()
		{
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE78")]
		[Address(RVA = "0x33C2910", Offset = "0x33C1510", VA = "0x1833C2910", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400BF18 RID: 48920
		[Token(Token = "0x400BF18")]
		[FieldOffset(Offset = "0x10")]
		private ActivityEnemyDuelData m_actData;

		// Token: 0x0400BF19 RID: 48921
		[Token(Token = "0x400BF19")]
		[FieldOffset(Offset = "0x18")]
		private ActivityEnemyDuelModeData m_subModeData;

		// Token: 0x0400BF1A RID: 48922
		[Token(Token = "0x400BF1A")]
		[FieldOffset(Offset = "0x20")]
		private int m_curRoundIndex;

		// Token: 0x0400BF1B RID: 48923
		[Token(Token = "0x400BF1B")]
		[FieldOffset(Offset = "0x28")]
		private ActivityEnemyDuelRoundData m_curRoundData;

		// Token: 0x0400BF1C RID: 48924
		[Token(Token = "0x400BF1C")]
		[FieldOffset(Offset = "0x30")]
		private EnemyDuelServiceGameState m_roundState;

		// Token: 0x0400BF1D RID: 48925
		[Token(Token = "0x400BF1D")]
		[FieldOffset(Offset = "0x38")]
		private EnemyDuelBattleStatus m_status;

		// Token: 0x0400BF1E RID: 48926
		[Token(Token = "0x400BF1E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isGameOver;

		// Token: 0x0400BF1F RID: 48927
		[Token(Token = "0x400BF1F")]
		[FieldOffset(Offset = "0x64")]
		private int m_maxRound;

		// Token: 0x0400BF20 RID: 48928
		[Token(Token = "0x400BF20")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<EnemyDuelTeamData> m_teamDataList;

		// Token: 0x0400BF21 RID: 48929
		[Token(Token = "0x400BF21")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, EnemyDuelPlayerData> m_playerDataDict;

		// Token: 0x0400BF22 RID: 48930
		[Token(Token = "0x400BF22")]
		[FieldOffset(Offset = "0x78")]
		private EnemyDuelEntryData m_entryData;

		// Token: 0x0400BF23 RID: 48931
		[Token(Token = "0x400BF23")]
		[FieldOffset(Offset = "0x80")]
		private EnemyDuelBetData m_betData;

		// Token: 0x0400BF24 RID: 48932
		[Token(Token = "0x400BF24")]
		[FieldOffset(Offset = "0x88")]
		private EnemyDuelSettleData m_settleData;

		// Token: 0x0400BF25 RID: 48933
		[Token(Token = "0x400BF25")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelPlayerData m_selfData;

		// Token: 0x0400BF26 RID: 48934
		[Token(Token = "0x400BF26")]
		[FieldOffset(Offset = "0x98")]
		private List<EnemyDuelRoundInfo> m_roundInfoList;

		// Token: 0x0400BF27 RID: 48935
		[Token(Token = "0x400BF27")]
		[FieldOffset(Offset = "0xA0")]
		private List<EnemyDuelRankInfo> m_rankInfoList;

		// Token: 0x0400BF28 RID: 48936
		[Token(Token = "0x400BF28")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x0400BF29 RID: 48937
		[Token(Token = "0x400BF29")]
		[FieldOffset(Offset = "0xB0")]
		private string m_sceneId;

		// Token: 0x0400BF2A RID: 48938
		[Token(Token = "0x400BF2A")]
		[FieldOffset(Offset = "0xB8")]
		private string m_currUid;

		// Token: 0x0400BF2B RID: 48939
		[Token(Token = "0x400BF2B")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isRoomOwner;

		// Token: 0x0400BF2C RID: 48940
		[Token(Token = "0x400BF2C")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_isCurAutoChoose;

		// Token: 0x0400BF2D RID: 48941
		[Token(Token = "0x400BF2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCurAutoChoose;

		// Token: 0x0400BF2E RID: 48942
		[Token(Token = "0x400BF2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRoomOwner;

		// Token: 0x0400BF2F RID: 48943
		[Token(Token = "0x400BF2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curRoundIndex;

		// Token: 0x0400BF30 RID: 48944
		[Token(Token = "0x400BF30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_curRoundData;

		// Token: 0x0400BF31 RID: 48945
		[Token(Token = "0x400BF31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curModeType;

		// Token: 0x0400BF32 RID: 48946
		[Token(Token = "0x400BF32")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_curRoundState;

		// Token: 0x0400BF33 RID: 48947
		[Token(Token = "0x400BF33")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isGameOver;

		// Token: 0x0400BF34 RID: 48948
		[Token(Token = "0x400BF34")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_constData;

		// Token: 0x0400BF35 RID: 48949
		[Token(Token = "0x400BF35")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0400BF36 RID: 48950
		[Token(Token = "0x400BF36")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_sceneId;

		// Token: 0x0400BF37 RID: 48951
		[Token(Token = "0x400BF37")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400BF38 RID: 48952
		[Token(Token = "0x400BF38")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_actData;

		// Token: 0x0400BF39 RID: 48953
		[Token(Token = "0x400BF39")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_subModeData;

		// Token: 0x0400BF3A RID: 48954
		[Token(Token = "0x400BF3A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadAndInitData;

		// Token: 0x0400BF3B RID: 48955
		[Token(Token = "0x400BF3B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PreparePlayerDataBeforeWaveStart;

		// Token: 0x0400BF3C RID: 48956
		[Token(Token = "0x400BF3C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForceUpdateRoundAllStateData;

		// Token: 0x0400BF3D RID: 48957
		[Token(Token = "0x400BF3D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnRoundChanged;

		// Token: 0x0400BF3E RID: 48958
		[Token(Token = "0x400BF3E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateRoundStateData;

		// Token: 0x0400BF3F RID: 48959
		[Token(Token = "0x400BF3F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_AssignPlayerDataDict;

		// Token: 0x0400BF40 RID: 48960
		[Token(Token = "0x400BF40")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AssignSelfPlayerData;

		// Token: 0x0400BF41 RID: 48961
		[Token(Token = "0x400BF41")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_AddTeamData;

		// Token: 0x0400BF42 RID: 48962
		[Token(Token = "0x400BF42")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshTeamList;

		// Token: 0x0400BF43 RID: 48963
		[Token(Token = "0x400BF43")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnSingleModeFinishRound;

		// Token: 0x0400BF44 RID: 48964
		[Token(Token = "0x400BF44")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnFinishGame;

		// Token: 0x0400BF45 RID: 48965
		[Token(Token = "0x400BF45")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnGameQuit;

		// Token: 0x0400BF46 RID: 48966
		[Token(Token = "0x400BF46")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetPlayerDataDict;

		// Token: 0x0400BF47 RID: 48967
		[Token(Token = "0x400BF47")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetSelfPlayerData;

		// Token: 0x0400BF48 RID: 48968
		[Token(Token = "0x400BF48")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetTeamData;

		// Token: 0x0400BF49 RID: 48969
		[Token(Token = "0x400BF49")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetBetData;

		// Token: 0x0400BF4A RID: 48970
		[Token(Token = "0x400BF4A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetSettleData;

		// Token: 0x0400BF4B RID: 48971
		[Token(Token = "0x400BF4B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_FetchSingleFinishOutput;

		// Token: 0x0400BF4C RID: 48972
		[Token(Token = "0x400BF4C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RefreshPlayerBetData;

		// Token: 0x0400BF4D RID: 48973
		[Token(Token = "0x400BF4D")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__RefreshPlayerSettleData;

		// Token: 0x0400BF4E RID: 48974
		[Token(Token = "0x400BF4E")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckGameOver;

		// Token: 0x0400BF4F RID: 48975
		[Token(Token = "0x400BF4F")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__LogRoundPlayerResult;

		// Token: 0x0400BF50 RID: 48976
		[Token(Token = "0x400BF50")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LogGameResult;

		// Token: 0x0400BF51 RID: 48977
		[Token(Token = "0x400BF51")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
