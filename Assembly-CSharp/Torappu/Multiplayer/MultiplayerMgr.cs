using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Multiplayer.Mode;
using Torappu.Multiplayer.Servers;
using Torappu.Network;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x02001552 RID: 5458
	[Token(Token = "0x2001552")]
	public class MultiplayerMgr : IDisposable, IHotfixable
	{
		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06007CB8 RID: 31928 RVA: 0x00037608 File Offset: 0x00035808
		[Token(Token = "0x17000ED4")]
		public static bool hasInstance
		{
			[Token(Token = "0x6007CB8")]
			[Address(RVA = "0x28477D0", Offset = "0x28463D0", VA = "0x1828477D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED5")]
		public static MultiplayerMgr instance
		{
			[Token(Token = "0x6007CB9")]
			[Address(RVA = "0x2847820", Offset = "0x2846420", VA = "0x182847820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CBA")]
		[Address(RVA = "0x2846FE0", Offset = "0x2845BE0", VA = "0x182846FE0")]
		private static MultiplayerMgr _Setup()
		{
			return null;
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06007CBB RID: 31931 RVA: 0x00037620 File Offset: 0x00035820
		[Token(Token = "0x17000ED6")]
		public static bool started
		{
			[Token(Token = "0x6007CBB")]
			[Address(RVA = "0x2847CB0", Offset = "0x28468B0", VA = "0x182847CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBC")]
		[Address(RVA = "0x28468D0", Offset = "0x28454D0", VA = "0x1828468D0")]
		public static void Stop()
		{
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBD")]
		[Address(RVA = "0x2847100", Offset = "0x2845D00", VA = "0x182847100")]
		private static void _StartImpl(TeamInst team, MultiplayerActParam param, TeamJoinFollower follower)
		{
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBE")]
		[Address(RVA = "0x2846550", Offset = "0x2845150", VA = "0x182846550")]
		public static void StartWithLoadMask(TeamInst team, MultiplayerActParam param, TeamJoinFollower follower)
		{
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBF")]
		[Address(RVA = "0x2845EE0", Offset = "0x2844AE0", VA = "0x182845EE0")]
		public static void Replay(IMultiplayerBattleVideo video, string uid, string actId)
		{
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC0")]
		[Address(RVA = "0x2846040", Offset = "0x2844C40", VA = "0x182846040")]
		public static void Replay(string[] videoUrls)
		{
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED7")]
		public static IMultiplayerMode curMode
		{
			[Token(Token = "0x6007CC1")]
			[Address(RVA = "0x2847710", Offset = "0x2846310", VA = "0x182847710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED8")]
		public IMultiplayerMode mode
		{
			[Token(Token = "0x6007CC2")]
			[Address(RVA = "0x2847AB0", Offset = "0x28466B0", VA = "0x182847AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC3")]
		[Address(RVA = "0x2847280", Offset = "0x2845E80", VA = "0x182847280")]
		private MultiplayerMgr()
		{
		}

		// Token: 0x06007CC4 RID: 31940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC4")]
		[Address(RVA = "0x2845950", Offset = "0x2844550", VA = "0x182845950", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC5")]
		[Address(RVA = "0x2846EB0", Offset = "0x2845AB0", VA = "0x182846EB0")]
		private void _HandleSceneChanged(string from, string to)
		{
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007CC7 RID: 31943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ED9")]
		public EventPool<MultiplayerEvent> eventPool
		{
			[Token(Token = "0x6007CC6")]
			[Address(RVA = "0x2847770", Offset = "0x2846370", VA = "0x182847770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007CC7")]
			[Address(RVA = "0x2847F60", Offset = "0x2846B60", VA = "0x182847F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06007CC8 RID: 31944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDA")]
		public string playerID
		{
			[Token(Token = "0x6007CC8")]
			[Address(RVA = "0x2847B70", Offset = "0x2846770", VA = "0x182847B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007CCA RID: 31946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EDB")]
		public string partnerID
		{
			[Token(Token = "0x6007CC9")]
			[Address(RVA = "0x2847B10", Offset = "0x2846710", VA = "0x182847B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007CCA")]
			[Address(RVA = "0x2847FE0", Offset = "0x2846BE0", VA = "0x182847FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDC")]
		public TeamInfo teamInfo
		{
			[Token(Token = "0x6007CCB")]
			[Address(RVA = "0x2847D00", Offset = "0x2846900", VA = "0x182847D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDD")]
		public BattleInfo battleInfo
		{
			[Token(Token = "0x6007CCC")]
			[Address(RVA = "0x28475B0", Offset = "0x28461B0", VA = "0x1828475B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x00037638 File Offset: 0x00035838
		// (set) Token: 0x06007CCE RID: 31950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EDE")]
		public MultiplayerActParam actParam
		{
			[Token(Token = "0x6007CCD")]
			[Address(RVA = "0x2847470", Offset = "0x2846070", VA = "0x182847470")]
			[CompilerGenerated]
			get
			{
				return default(MultiplayerActParam);
			}
			[Token(Token = "0x6007CCE")]
			[Address(RVA = "0x2847D80", Offset = "0x2846980", VA = "0x182847D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06007CCF RID: 31951 RVA: 0x00037650 File Offset: 0x00035850
		[Token(Token = "0x17000EDF")]
		public MultiplayerActParam.MultiplayerSetting setting
		{
			[Token(Token = "0x6007CCF")]
			[Address(RVA = "0x2847BF0", Offset = "0x28467F0", VA = "0x182847BF0")]
			get
			{
				return default(MultiplayerActParam.MultiplayerSetting);
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x00037668 File Offset: 0x00035868
		// (set) Token: 0x06007CD1 RID: 31953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EE0")]
		public bool battlePausing
		{
			[Token(Token = "0x6007CD0")]
			[Address(RVA = "0x2847630", Offset = "0x2846230", VA = "0x182847630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007CD1")]
			[Address(RVA = "0x2847EF0", Offset = "0x2846AF0", VA = "0x182847EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06007CD2 RID: 31954 RVA: 0x00037680 File Offset: 0x00035880
		// (set) Token: 0x06007CD3 RID: 31955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EE1")]
		public bool battleFastMode
		{
			[Token(Token = "0x6007CD2")]
			[Address(RVA = "0x2847550", Offset = "0x2846150", VA = "0x182847550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007CD3")]
			[Address(RVA = "0x2847E80", Offset = "0x2846A80", VA = "0x182847E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06007CD4 RID: 31956 RVA: 0x00037698 File Offset: 0x00035898
		[Token(Token = "0x17000EE2")]
		public bool isReal
		{
			[Token(Token = "0x6007CD4")]
			[Address(RVA = "0x28478D0", Offset = "0x28464D0", VA = "0x1828478D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x000376B0 File Offset: 0x000358B0
		[Token(Token = "0x17000EE3")]
		public bool isReplay
		{
			[Token(Token = "0x6007CD5")]
			[Address(RVA = "0x28479C0", Offset = "0x28465C0", VA = "0x1828479C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06007CD6 RID: 31958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE4")]
		public object cachedPlayerInfoForBattle
		{
			[Token(Token = "0x6007CD6")]
			[Address(RVA = "0x2847690", Offset = "0x2846290", VA = "0x182847690")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD7")]
		[Address(RVA = "0x2846A40", Offset = "0x2845640", VA = "0x182846A40")]
		public void UpdateStatus()
		{
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x000376C8 File Offset: 0x000358C8
		[Token(Token = "0x6007CD8")]
		[Address(RVA = "0x2846400", Offset = "0x2845000", VA = "0x182846400")]
		public bool SendRequest(RequestType request, [Optional] object param)
		{
			return default(bool);
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD9")]
		[Address(RVA = "0x2846180", Offset = "0x2844D80", VA = "0x182846180")]
		public void RevStep(StepData step)
		{
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDA")]
		[Address(RVA = "0x2846BB0", Offset = "0x28457B0", VA = "0x182846BB0")]
		public void Update()
		{
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDB")]
		[Address(RVA = "0x2845AF0", Offset = "0x28446F0", VA = "0x182845AF0")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDC")]
		[Address(RVA = "0x2845D20", Offset = "0x2844920", VA = "0x182845D20")]
		public void OnGUI()
		{
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDD")]
		[Address(RVA = "0x28455D0", Offset = "0x28441D0", VA = "0x1828455D0")]
		public void Alert(string content, ShowCondition condition, ProcWhenForbid proc)
		{
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x000376E0 File Offset: 0x000358E0
		[Token(Token = "0x6007CDE")]
		[Address(RVA = "0x2845DB0", Offset = "0x28449B0", VA = "0x182845DB0")]
		public static bool ProcessDelayedAlert(Action<string, int> proc)
		{
			return default(bool);
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDF")]
		[Address(RVA = "0x2845890", Offset = "0x2844490", VA = "0x182845890")]
		public static void ClearDelayedAlert()
		{
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CE0")]
		[Address(RVA = "0x2845B80", Offset = "0x2844780", VA = "0x182845B80")]
		public TeamProtocol.STPlayerStatus GetPlayerStatusByPlayerId(string playerID)
		{
			return null;
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CE1")]
		private T _ChangeMode<T>() where T : class, IMultiplayerMode, new()
		{
			return null;
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CE2")]
		private T _ChangePhase<T>() where T : MultiBattlePhase, new()
		{
			return null;
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE3")]
		[Address(RVA = "0x2846C30", Offset = "0x2845830", VA = "0x182846C30")]
		private void _CheckMySideAndStatus()
		{
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE4")]
		public static void SendRequest<Req, Response>(string api, Req req, Action<Response> onProceed, bool showMask = true, [Optional] Func<ResponseError, bool> onError) where Response : class
		{
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x000376F8 File Offset: 0x000358F8
		[Token(Token = "0x6007CE5")]
		[Address(RVA = "0x2846E00", Offset = "0x2845A00", VA = "0x182846E00")]
		private static MultiplayerActParam _ConstructTempActParam(string id = "act1multi")
		{
			return default(MultiplayerActParam);
		}

		// Token: 0x04007D65 RID: 32101
		[Token(Token = "0x4007D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MultiplayerMgr s_instance;

		// Token: 0x04007D66 RID: 32102
		[Token(Token = "0x4007D66")]
		private const string REPLAY_ACT_ID = "act1multi";

		// Token: 0x04007D67 RID: 32103
		[Token(Token = "0x4007D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MultiBattlePhase m_curPhase;

		// Token: 0x04007D68 RID: 32104
		[Token(Token = "0x4007D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IMultiplayerMode m_mode;

		// Token: 0x04007D6E RID: 32110
		[Token(Token = "0x4007D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<string> s_alerts;

		// Token: 0x04007D6F RID: 32111
		[Token(Token = "0x4007D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasInstance;

		// Token: 0x04007D70 RID: 32112
		[Token(Token = "0x4007D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_instance;

		// Token: 0x04007D71 RID: 32113
		[Token(Token = "0x4007D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x04007D72 RID: 32114
		[Token(Token = "0x4007D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_started;

		// Token: 0x04007D73 RID: 32115
		[Token(Token = "0x4007D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04007D74 RID: 32116
		[Token(Token = "0x4007D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StartImpl;

		// Token: 0x04007D75 RID: 32117
		[Token(Token = "0x4007D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StartWithLoadMask;

		// Token: 0x04007D76 RID: 32118
		[Token(Token = "0x4007D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Replay;

		// Token: 0x04007D77 RID: 32119
		[Token(Token = "0x4007D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1_Replay;

		// Token: 0x04007D78 RID: 32120
		[Token(Token = "0x4007D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_curMode;

		// Token: 0x04007D79 RID: 32121
		[Token(Token = "0x4007D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x04007D7A RID: 32122
		[Token(Token = "0x4007D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007D7B RID: 32123
		[Token(Token = "0x4007D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04007D7C RID: 32124
		[Token(Token = "0x4007D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleSceneChanged;

		// Token: 0x04007D7D RID: 32125
		[Token(Token = "0x4007D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x04007D7E RID: 32126
		[Token(Token = "0x4007D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_eventPool;

		// Token: 0x04007D7F RID: 32127
		[Token(Token = "0x4007D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_playerID;

		// Token: 0x04007D80 RID: 32128
		[Token(Token = "0x4007D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_partnerID;

		// Token: 0x04007D81 RID: 32129
		[Token(Token = "0x4007D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_partnerID;

		// Token: 0x04007D82 RID: 32130
		[Token(Token = "0x4007D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04007D83 RID: 32131
		[Token(Token = "0x4007D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04007D84 RID: 32132
		[Token(Token = "0x4007D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_actParam;

		// Token: 0x04007D85 RID: 32133
		[Token(Token = "0x4007D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_actParam;

		// Token: 0x04007D86 RID: 32134
		[Token(Token = "0x4007D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_setting;

		// Token: 0x04007D87 RID: 32135
		[Token(Token = "0x4007D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_battlePausing;

		// Token: 0x04007D88 RID: 32136
		[Token(Token = "0x4007D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_battlePausing;

		// Token: 0x04007D89 RID: 32137
		[Token(Token = "0x4007D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_battleFastMode;

		// Token: 0x04007D8A RID: 32138
		[Token(Token = "0x4007D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_battleFastMode;

		// Token: 0x04007D8B RID: 32139
		[Token(Token = "0x4007D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_isReal;

		// Token: 0x04007D8C RID: 32140
		[Token(Token = "0x4007D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isReplay;

		// Token: 0x04007D8D RID: 32141
		[Token(Token = "0x4007D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_cachedPlayerInfoForBattle;

		// Token: 0x04007D8E RID: 32142
		[Token(Token = "0x4007D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04007D8F RID: 32143
		[Token(Token = "0x4007D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04007D90 RID: 32144
		[Token(Token = "0x4007D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_RevStep;

		// Token: 0x04007D91 RID: 32145
		[Token(Token = "0x4007D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04007D92 RID: 32146
		[Token(Token = "0x4007D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04007D93 RID: 32147
		[Token(Token = "0x4007D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04007D94 RID: 32148
		[Token(Token = "0x4007D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x04007D95 RID: 32149
		[Token(Token = "0x4007D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ProcessDelayedAlert;

		// Token: 0x04007D96 RID: 32150
		[Token(Token = "0x4007D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_ClearDelayedAlert;

		// Token: 0x04007D97 RID: 32151
		[Token(Token = "0x4007D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetPlayerStatusByPlayerId;

		// Token: 0x04007D98 RID: 32152
		[Token(Token = "0x4007D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ChangeMode;

		// Token: 0x04007D99 RID: 32153
		[Token(Token = "0x4007D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__ChangePhase;

		// Token: 0x04007D9A RID: 32154
		[Token(Token = "0x4007D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__CheckMySideAndStatus;

		// Token: 0x04007D9B RID: 32155
		[Token(Token = "0x4007D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix1_SendRequest;

		// Token: 0x04007D9C RID: 32156
		[Token(Token = "0x4007D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__ConstructTempActParam;
	}
}
