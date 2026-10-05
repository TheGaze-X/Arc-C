using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015CE RID: 5582
	[Token(Token = "0x20015CE")]
	public class MultiplayerRealMode : IMultiplayerMode, IHotfixable, ITeamClient, IServerSupport, IBattleClient
	{
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06007E7F RID: 32383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F01")]
		public string playerUID
		{
			[Token(Token = "0x6007E7F")]
			[Address(RVA = "0x28980D0", Offset = "0x2896CD0", VA = "0x1828980D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F02")]
		public TeamInfo teamInfo
		{
			[Token(Token = "0x6007E80")]
			[Address(RVA = "0x2898230", Offset = "0x2896E30", VA = "0x182898230", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F03")]
		public BattleInfo battleInfo
		{
			[Token(Token = "0x6007E81")]
			[Address(RVA = "0x2897EB0", Offset = "0x2896AB0", VA = "0x182897EB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F04")]
		public string sceneId
		{
			[Token(Token = "0x6007E82")]
			[Address(RVA = "0x28981C0", Offset = "0x2896DC0", VA = "0x1828981C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06007E83 RID: 32387 RVA: 0x00037B90 File Offset: 0x00035D90
		[Token(Token = "0x17000F05")]
		public int ping
		{
			[Token(Token = "0x6007E83")]
			[Address(RVA = "0x2898060", Offset = "0x2896C60", VA = "0x182898060", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x00037BA8 File Offset: 0x00035DA8
		[Token(Token = "0x17000F06")]
		public DateTime currentTime
		{
			[Token(Token = "0x6007E84")]
			[Address(RVA = "0x2897F80", Offset = "0x2896B80", VA = "0x182897F80", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06007E85 RID: 32389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F07")]
		public object cachedUserInfoForBattle
		{
			[Token(Token = "0x6007E85")]
			[Address(RVA = "0x2897F20", Offset = "0x2896B20", VA = "0x182897F20", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E86")]
		[Address(RVA = "0x2894370", Offset = "0x2892F70", VA = "0x182894370", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E87")]
		[Address(RVA = "0x2894410", Offset = "0x2893010", VA = "0x182894410", Slot = "4")]
		public void Init(MultiplayerMgr mgr)
		{
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E88")]
		[Address(RVA = "0x2895630", Offset = "0x2894230", VA = "0x182895630", Slot = "6")]
		public void Update()
		{
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E89")]
		[Address(RVA = "0x2895000", Offset = "0x2893C00", VA = "0x182895000")]
		public void JoinTeam(TeamInst team, TeamJoinFollower follower)
		{
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00037BC0 File Offset: 0x00035DC0
		[Token(Token = "0x6007E8A")]
		[Address(RVA = "0x2895180", Offset = "0x2893D80", VA = "0x182895180", Slot = "13")]
		public bool SendRequest(RequestType request, object param)
		{
			return default(bool);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x00037BD8 File Offset: 0x00035DD8
		[Token(Token = "0x6007E8B")]
		[Address(RVA = "0x2895F20", Offset = "0x2894B20", VA = "0x182895F20")]
		public bool _GameReady()
		{
			return default(bool);
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x00037BF0 File Offset: 0x00035DF0
		[Token(Token = "0x6007E8C")]
		[Address(RVA = "0x2896670", Offset = "0x2895270", VA = "0x182896670")]
		public bool _ReportSnapshot(GameCheckParam check)
		{
			return default(bool);
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x00037C08 File Offset: 0x00035E08
		[Token(Token = "0x6007E8D")]
		[Address(RVA = "0x2896290", Offset = "0x2894E90", VA = "0x182896290")]
		private bool _LeaveTeam()
		{
			return default(bool);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x00037C20 File Offset: 0x00035E20
		[Token(Token = "0x6007E8E")]
		[Address(RVA = "0x28975D0", Offset = "0x28961D0", VA = "0x1828975D0")]
		private bool _TeamChat(EmojiChatParam param)
		{
			return default(bool);
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x00037C38 File Offset: 0x00035E38
		[Token(Token = "0x6007E8F")]
		[Address(RVA = "0x28960C0", Offset = "0x2894CC0", VA = "0x1828960C0")]
		private bool _KickPartner(string uid)
		{
			return default(bool);
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x00037C50 File Offset: 0x00035E50
		[Token(Token = "0x6007E90")]
		[Address(RVA = "0x2895870", Offset = "0x2894470", VA = "0x182895870")]
		private bool _ChooseStage(ChooseStageParam chooseStageParam)
		{
			return default(bool);
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x00037C68 File Offset: 0x00035E68
		[Token(Token = "0x6007E91")]
		[Address(RVA = "0x28956B0", Offset = "0x28942B0", VA = "0x1828956B0")]
		private bool _ChoosePos(int pos)
		{
			return default(bool);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x00037C80 File Offset: 0x00035E80
		[Token(Token = "0x6007E92")]
		[Address(RVA = "0x28964B0", Offset = "0x28950B0", VA = "0x1828964B0")]
		private bool _ReadyInRoom(bool isReady)
		{
			return default(bool);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x00037C98 File Offset: 0x00035E98
		[Token(Token = "0x6007E93")]
		[Address(RVA = "0x2895A50", Offset = "0x2894650", VA = "0x182895A50")]
		private bool _EntranceReady(bool ready)
		{
			return default(bool);
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x00037CB0 File Offset: 0x00035EB0
		[Token(Token = "0x6007E94")]
		[Address(RVA = "0x2897C50", Offset = "0x2896850", VA = "0x182897C50")]
		private bool _TurnPick(int charInstId)
		{
			return default(bool);
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x00037CC8 File Offset: 0x00035EC8
		[Token(Token = "0x6007E95")]
		[Address(RVA = "0x2897D50", Offset = "0x2896950", VA = "0x182897D50")]
		private bool _TurnSkip(bool skip)
		{
			return default(bool);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x00037CE0 File Offset: 0x00035EE0
		[Token(Token = "0x6007E96")]
		[Address(RVA = "0x2896850", Offset = "0x2895450", VA = "0x182896850")]
		private bool _SaveSquad(SaveSquadParam param)
		{
			return default(bool);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x00037CF8 File Offset: 0x00035EF8
		[Token(Token = "0x6007E97")]
		[Address(RVA = "0x2897060", Offset = "0x2895C60", VA = "0x182897060")]
		private bool _SetCharSlot(SetCharSlotParam param)
		{
			return default(bool);
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x00037D10 File Offset: 0x00035F10
		[Token(Token = "0x6007E98")]
		[Address(RVA = "0x2897240", Offset = "0x2895E40", VA = "0x182897240")]
		private bool _SetSquadReady(bool isReady)
		{
			return default(bool);
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x00037D28 File Offset: 0x00035F28
		[Token(Token = "0x6007E99")]
		[Address(RVA = "0x2897990", Offset = "0x2896590", VA = "0x182897990")]
		private bool _TeamReady(bool ready)
		{
			return default(bool);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x00037D40 File Offset: 0x00035F40
		[Token(Token = "0x6007E9A")]
		[Address(RVA = "0x28977C0", Offset = "0x28963C0", VA = "0x1828977C0")]
		private bool _TeamGetNameCard(string uid)
		{
			return default(bool);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x00037D58 File Offset: 0x00035F58
		[Token(Token = "0x6007E9B")]
		[Address(RVA = "0x2897A90", Offset = "0x2896690", VA = "0x182897A90")]
		private bool _TeamSetFlipMode(bool flag)
		{
			return default(bool);
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x00037D70 File Offset: 0x00035F70
		[Token(Token = "0x6007E9C")]
		[Address(RVA = "0x2897400", Offset = "0x2896000", VA = "0x182897400")]
		private bool _SettleLike(string partnerUid)
		{
			return default(bool);
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x00037D88 File Offset: 0x00035F88
		[Token(Token = "0x6007E9D")]
		[Address(RVA = "0x2896310", Offset = "0x2894F10", VA = "0x182896310")]
		private bool _MatchContinueRoom()
		{
			return default(bool);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x00037DA0 File Offset: 0x00035FA0
		[Token(Token = "0x6007E9E")]
		[Address(RVA = "0x2896C40", Offset = "0x2895840", VA = "0x182896C40")]
		private bool _SendAction(PlayerOprtData oprt)
		{
			return default(bool);
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x00037DB8 File Offset: 0x00035FB8
		[Token(Token = "0x6007E9F")]
		[Address(RVA = "0x2896E30", Offset = "0x2895A30", VA = "0x182896E30")]
		private bool _SendMark(GameMarkData param)
		{
			return default(bool);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x00037DD0 File Offset: 0x00035FD0
		[Token(Token = "0x6007EA0")]
		[Address(RVA = "0x2895F90", Offset = "0x2894B90", VA = "0x182895F90")]
		private bool _GameSettle(GameSettleParam settleInfo)
		{
			return default(bool);
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x00037DE8 File Offset: 0x00035FE8
		[Token(Token = "0x6007EA1")]
		[Address(RVA = "0x2895D60", Offset = "0x2894960", VA = "0x182895D60")]
		private bool _GamePause(GamePauseParam param)
		{
			return default(bool);
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x00037E00 File Offset: 0x00036000
		[Token(Token = "0x6007EA2")]
		[Address(RVA = "0x2895B50", Offset = "0x2894750", VA = "0x182895B50")]
		private bool _GameGiveUp(bool giveUp)
		{
			return default(bool);
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA3")]
		[Address(RVA = "0x28954D0", Offset = "0x28940D0", VA = "0x1828954D0", Slot = "14")]
		public void UpdateTeamStatus()
		{
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA4")]
		[Address(RVA = "0x2895220", Offset = "0x2893E20", VA = "0x182895220", Slot = "15")]
		public void StartBattle(BattleEntry entry)
		{
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA5")]
		[Address(RVA = "0x2895430", Offset = "0x2894030", VA = "0x182895430", Slot = "19")]
		public void UpdateBattleStatus(bool inBattle)
		{
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA6")]
		[Address(RVA = "0x28950F0", Offset = "0x2893CF0", VA = "0x1828950F0", Slot = "20")]
		public void RevStep(StepData step)
		{
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EA7")]
		[Address(RVA = "0x28942C0", Offset = "0x2892EC0", VA = "0x1828942C0", Slot = "18")]
		public void Alert(string content, ShowCondition condition, ProcWhenForbid proc = ProcWhenForbid.AfterBattle)
		{
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F08")]
		public INetProtocolSuite protocolSuite
		{
			[Token(Token = "0x6007EA8")]
			[Address(RVA = "0x2898160", Offset = "0x2896D60", VA = "0x182898160", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06007EA9 RID: 32425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F09")]
		public EventPool<MultiplayerEvent> eventPool
		{
			[Token(Token = "0x6007EA9")]
			[Address(RVA = "0x2897FF0", Offset = "0x2896BF0", VA = "0x182897FF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EAA")]
		[Address(RVA = "0x2897E50", Offset = "0x2896A50", VA = "0x182897E50")]
		public MultiplayerRealMode()
		{
		}

		// Token: 0x04008023 RID: 32803
		[Token(Token = "0x4008023")]
		[FieldOffset(Offset = "0x10")]
		private MultiplayerMgr m_mgr;

		// Token: 0x04008024 RID: 32804
		[Token(Token = "0x4008024")]
		[FieldOffset(Offset = "0x18")]
		private ProtocolSuite m_suite;

		// Token: 0x04008025 RID: 32805
		[Token(Token = "0x4008025")]
		[FieldOffset(Offset = "0x20")]
		private TeamServer m_teamSvr;

		// Token: 0x04008026 RID: 32806
		[Token(Token = "0x4008026")]
		[FieldOffset(Offset = "0x28")]
		private BattleServer m_battleSvr;

		// Token: 0x04008027 RID: 32807
		[Token(Token = "0x4008027")]
		[FieldOffset(Offset = "0x30")]
		private Server m_statusSvr;

		// Token: 0x04008028 RID: 32808
		[Token(Token = "0x4008028")]
		[FieldOffset(Offset = "0x38")]
		private RequestHandlers m_reqHandlers;

		// Token: 0x04008029 RID: 32809
		[Token(Token = "0x4008029")]
		[FieldOffset(Offset = "0x40")]
		private MultiplayerRealMode.CachedUserInfoForBattle m_cachedUserInfoForBattle;

		// Token: 0x0400802A RID: 32810
		[Token(Token = "0x400802A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playerUID;

		// Token: 0x0400802B RID: 32811
		[Token(Token = "0x400802B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x0400802C RID: 32812
		[Token(Token = "0x400802C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x0400802D RID: 32813
		[Token(Token = "0x400802D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sceneId;

		// Token: 0x0400802E RID: 32814
		[Token(Token = "0x400802E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x0400802F RID: 32815
		[Token(Token = "0x400802F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04008030 RID: 32816
		[Token(Token = "0x4008030")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cachedUserInfoForBattle;

		// Token: 0x04008031 RID: 32817
		[Token(Token = "0x4008031")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04008032 RID: 32818
		[Token(Token = "0x4008032")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04008033 RID: 32819
		[Token(Token = "0x4008033")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008034 RID: 32820
		[Token(Token = "0x4008034")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_JoinTeam;

		// Token: 0x04008035 RID: 32821
		[Token(Token = "0x4008035")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04008036 RID: 32822
		[Token(Token = "0x4008036")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GameReady;

		// Token: 0x04008037 RID: 32823
		[Token(Token = "0x4008037")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReportSnapshot;

		// Token: 0x04008038 RID: 32824
		[Token(Token = "0x4008038")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LeaveTeam;

		// Token: 0x04008039 RID: 32825
		[Token(Token = "0x4008039")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TeamChat;

		// Token: 0x0400803A RID: 32826
		[Token(Token = "0x400803A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__KickPartner;

		// Token: 0x0400803B RID: 32827
		[Token(Token = "0x400803B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ChooseStage;

		// Token: 0x0400803C RID: 32828
		[Token(Token = "0x400803C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ChoosePos;

		// Token: 0x0400803D RID: 32829
		[Token(Token = "0x400803D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ReadyInRoom;

		// Token: 0x0400803E RID: 32830
		[Token(Token = "0x400803E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EntranceReady;

		// Token: 0x0400803F RID: 32831
		[Token(Token = "0x400803F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TurnPick;

		// Token: 0x04008040 RID: 32832
		[Token(Token = "0x4008040")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TurnSkip;

		// Token: 0x04008041 RID: 32833
		[Token(Token = "0x4008041")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SaveSquad;

		// Token: 0x04008042 RID: 32834
		[Token(Token = "0x4008042")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SetCharSlot;

		// Token: 0x04008043 RID: 32835
		[Token(Token = "0x4008043")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SetSquadReady;

		// Token: 0x04008044 RID: 32836
		[Token(Token = "0x4008044")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TeamReady;

		// Token: 0x04008045 RID: 32837
		[Token(Token = "0x4008045")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__TeamGetNameCard;

		// Token: 0x04008046 RID: 32838
		[Token(Token = "0x4008046")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TeamSetFlipMode;

		// Token: 0x04008047 RID: 32839
		[Token(Token = "0x4008047")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__SettleLike;

		// Token: 0x04008048 RID: 32840
		[Token(Token = "0x4008048")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__MatchContinueRoom;

		// Token: 0x04008049 RID: 32841
		[Token(Token = "0x4008049")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SendAction;

		// Token: 0x0400804A RID: 32842
		[Token(Token = "0x400804A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__SendMark;

		// Token: 0x0400804B RID: 32843
		[Token(Token = "0x400804B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GameSettle;

		// Token: 0x0400804C RID: 32844
		[Token(Token = "0x400804C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GamePause;

		// Token: 0x0400804D RID: 32845
		[Token(Token = "0x400804D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GameGiveUp;

		// Token: 0x0400804E RID: 32846
		[Token(Token = "0x400804E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_UpdateTeamStatus;

		// Token: 0x0400804F RID: 32847
		[Token(Token = "0x400804F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04008050 RID: 32848
		[Token(Token = "0x4008050")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_UpdateBattleStatus;

		// Token: 0x04008051 RID: 32849
		[Token(Token = "0x4008051")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RevStep;

		// Token: 0x04008052 RID: 32850
		[Token(Token = "0x4008052")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x04008053 RID: 32851
		[Token(Token = "0x4008053")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_protocolSuite;

		// Token: 0x04008054 RID: 32852
		[Token(Token = "0x4008054")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x04008055 RID: 32853
		[Token(Token = "0x4008055")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020015CF RID: 5583
		[Token(Token = "0x20015CF")]
		public class CachedUserInfoForBattle
		{
			// Token: 0x06007EAB RID: 32427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EAB")]
			[Address(RVA = "0x28868D0", Offset = "0x28854D0", VA = "0x1828868D0")]
			public void AddInputPlayerInfoByPlayerId(string playerId)
			{
			}

			// Token: 0x06007EAC RID: 32428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EAC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CachedUserInfoForBattle()
			{
			}

			// Token: 0x04008056 RID: 32854
			[Token(Token = "0x4008056")]
			[FieldOffset(Offset = "0x10")]
			public bool isMatch;

			// Token: 0x04008057 RID: 32855
			[Token(Token = "0x4008057")]
			[FieldOffset(Offset = "0x18")]
			public List<MultiplayerInputPlayerInfo> inputPlayerInfoList;
		}

		// Token: 0x020015D0 RID: 5584
		[Token(Token = "0x20015D0")]
		private class MultiplayerServerLogRule : IServerLogRule
		{
			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x06007EAD RID: 32429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F0A")]
			public string prefix
			{
				[Token(Token = "0x6007EAD")]
				[Address(RVA = "0x2899DE0", Offset = "0x28989E0", VA = "0x182899DE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06007EAE RID: 32430 RVA: 0x00037E18 File Offset: 0x00036018
			[Token(Token = "0x17000F0B")]
			public bool logDetail
			{
				[Token(Token = "0x6007EAE")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007EAF RID: 32431 RVA: 0x00037E30 File Offset: 0x00036030
			[Token(Token = "0x6007EAF")]
			[Address(RVA = "0x2899DB0", Offset = "0x28989B0", VA = "0x182899DB0", Slot = "5")]
			public bool AllowedRevMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x06007EB0 RID: 32432 RVA: 0x00037E48 File Offset: 0x00036048
			[Token(Token = "0x6007EB0")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			public bool AllowedSendMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x06007EB1 RID: 32433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MultiplayerServerLogRule()
			{
			}
		}
	}
}
