using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.ServerBase;
using Torappu.UI.EnemyDuel.Service.Mode.Multi;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode
{
	// Token: 0x0200509C RID: 20636
	[Token(Token = "0x200509C")]
	public class EnemyDuelServiceMultiMode : IEnemyDuelServiceMode, IHotfixable, IEnemyDuelServerClient
	{
		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x0601E8CB RID: 125131 RVA: 0x000AECD8 File Offset: 0x000ACED8
		[Token(Token = "0x17004757")]
		public int ping
		{
			[Token(Token = "0x601E8CB")]
			[Address(RVA = "0x18442B0", Offset = "0x1842EB0", VA = "0x1818442B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x0601E8CC RID: 125132 RVA: 0x000AECF0 File Offset: 0x000ACEF0
		[Token(Token = "0x17004758")]
		public DateTime currentTime
		{
			[Token(Token = "0x601E8CC")]
			[Address(RVA = "0x1844240", Offset = "0x1842E40", VA = "0x181844240", Slot = "5")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x0601E8CD RID: 125133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004759")]
		public EnemyDuelServiceTeamInfo teamInfo
		{
			[Token(Token = "0x601E8CD")]
			[Address(RVA = "0x1844380", Offset = "0x1842F80", VA = "0x181844380", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x0601E8CE RID: 125134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700475A")]
		public EnemyDuelServiceBattleInfo battleInfo
		{
			[Token(Token = "0x601E8CE")]
			[Address(RVA = "0x18441A0", Offset = "0x1842DA0", VA = "0x1818441A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E8CF RID: 125135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8CF")]
		[Address(RVA = "0x1843530", Offset = "0x1842130", VA = "0x181843530", Slot = "8")]
		public void Init(IEnemyDuelServiceCore core)
		{
		}

		// Token: 0x0601E8D0 RID: 125136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D0")]
		[Address(RVA = "0x1843E70", Offset = "0x1842A70", VA = "0x181843E70")]
		public void Start(TeamJoinEntry entry)
		{
		}

		// Token: 0x0601E8D1 RID: 125137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D1")]
		[Address(RVA = "0x18433F0", Offset = "0x1841FF0", VA = "0x1818433F0", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0601E8D2 RID: 125138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D2")]
		[Address(RVA = "0x1844040", Offset = "0x1842C40", VA = "0x181844040", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x0601E8D3 RID: 125139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D3")]
		[Address(RVA = "0x1843A10", Offset = "0x1842610", VA = "0x181843A10", Slot = "11")]
		public void SendRequest(EnemyDuelServiceRequest request)
		{
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x0601E8D4 RID: 125140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700475B")]
		public EnemyDuelProtocolSuit protocolSuite
		{
			[Token(Token = "0x601E8D4")]
			[Address(RVA = "0x1844320", Offset = "0x1842F20", VA = "0x181844320", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E8D5 RID: 125141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D5")]
		[Address(RVA = "0x1843810", Offset = "0x1842410", VA = "0x181843810", Slot = "13")]
		public void RefreshServiceStatus()
		{
		}

		// Token: 0x0601E8D6 RID: 125142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D6")]
		[Address(RVA = "0x1843C40", Offset = "0x1842840", VA = "0x181843C40", Slot = "14")]
		public void StartBattle(BattleJoinEntry entry)
		{
		}

		// Token: 0x0601E8D7 RID: 125143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D7")]
		[Address(RVA = "0x1843970", Offset = "0x1842570", VA = "0x181843970", Slot = "15")]
		public void RevStep(EnemyDuelServiceStepData step)
		{
		}

		// Token: 0x0601E8D8 RID: 125144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8D8")]
		[Address(RVA = "0x1843F90", Offset = "0x1842B90", VA = "0x181843F90", Slot = "16")]
		public void TriggerEvent(EnemyDuelServiceEvent evt, [Optional] object arg)
		{
		}

		// Token: 0x0601E8D9 RID: 125145 RVA: 0x000AED08 File Offset: 0x000ACF08
		[Token(Token = "0x601E8D9")]
		[Address(RVA = "0x18440C0", Offset = "0x1842CC0", VA = "0x1818440C0")]
		public bool _HandleGameReady(EnemyDuelServiceBattleReadyRequest req)
		{
			return default(bool);
		}

		// Token: 0x0601E8DA RID: 125146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8DA")]
		[Address(RVA = "0x1844140", Offset = "0x1842D40", VA = "0x181844140")]
		public EnemyDuelServiceMultiMode()
		{
		}

		// Token: 0x04028EF1 RID: 167665
		[Token(Token = "0x4028EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnemyDuelServiceCore m_serviceCore;

		// Token: 0x04028EF2 RID: 167666
		[Token(Token = "0x4028EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EnemyDuelTeamServer m_teamSvr;

		// Token: 0x04028EF3 RID: 167667
		[Token(Token = "0x4028EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EnemyDuelBattleServer m_battleSvr;

		// Token: 0x04028EF4 RID: 167668
		[Token(Token = "0x4028EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EnemyDuelProtocolSuit m_protocolSuite;

		// Token: 0x04028EF5 RID: 167669
		[Token(Token = "0x4028EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Server m_activeSvr;

		// Token: 0x04028EF6 RID: 167670
		[Token(Token = "0x4028EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EnemyDuelServiceRequestHandler m_handlers;

		// Token: 0x04028EF7 RID: 167671
		[Token(Token = "0x4028EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04028EF8 RID: 167672
		[Token(Token = "0x4028EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04028EF9 RID: 167673
		[Token(Token = "0x4028EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04028EFA RID: 167674
		[Token(Token = "0x4028EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04028EFB RID: 167675
		[Token(Token = "0x4028EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04028EFC RID: 167676
		[Token(Token = "0x4028EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04028EFD RID: 167677
		[Token(Token = "0x4028EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04028EFE RID: 167678
		[Token(Token = "0x4028EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028EFF RID: 167679
		[Token(Token = "0x4028EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04028F00 RID: 167680
		[Token(Token = "0x4028F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_protocolSuite;

		// Token: 0x04028F01 RID: 167681
		[Token(Token = "0x4028F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshServiceStatus;

		// Token: 0x04028F02 RID: 167682
		[Token(Token = "0x4028F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04028F03 RID: 167683
		[Token(Token = "0x4028F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RevStep;

		// Token: 0x04028F04 RID: 167684
		[Token(Token = "0x4028F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TriggerEvent;

		// Token: 0x04028F05 RID: 167685
		[Token(Token = "0x4028F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleGameReady;

		// Token: 0x04028F06 RID: 167686
		[Token(Token = "0x4028F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200509D RID: 20637
		[Token(Token = "0x200509D")]
		private class SvrLogRule : IServerLogRule
		{
			// Token: 0x1700475C RID: 18268
			// (get) Token: 0x0601E8DB RID: 125147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700475C")]
			public string prefix
			{
				[Token(Token = "0x601E8DB")]
				[Address(RVA = "0x184E0C0", Offset = "0x184CCC0", VA = "0x18184E0C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700475D RID: 18269
			// (get) Token: 0x0601E8DC RID: 125148 RVA: 0x000AED20 File Offset: 0x000ACF20
			[Token(Token = "0x1700475D")]
			public bool logDetail
			{
				[Token(Token = "0x601E8DC")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601E8DD RID: 125149 RVA: 0x000AED38 File Offset: 0x000ACF38
			[Token(Token = "0x601E8DD")]
			[Address(RVA = "0x184E090", Offset = "0x184CC90", VA = "0x18184E090", Slot = "5")]
			public bool AllowedRevMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x0601E8DE RID: 125150 RVA: 0x000AED50 File Offset: 0x000ACF50
			[Token(Token = "0x601E8DE")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			public bool AllowedSendMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x0601E8DF RID: 125151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8DF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SvrLogRule()
			{
			}
		}
	}
}
