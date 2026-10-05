using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.ServerBase;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063DB RID: 25563
	[Token(Token = "0x20063DB")]
	public class AutoChessServiceMode : IAutoChessServiceMode, IHotfixable, IAutoChessServerClient
	{
		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x06024DA4 RID: 150948 RVA: 0x000C5A78 File Offset: 0x000C3C78
		[Token(Token = "0x17005710")]
		public int ping
		{
			[Token(Token = "0x6024DA4")]
			[Address(RVA = "0x1FC04F0", Offset = "0x1FBF0F0", VA = "0x181FC04F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x06024DA5 RID: 150949 RVA: 0x000C5A90 File Offset: 0x000C3C90
		[Token(Token = "0x17005711")]
		public DateTime currentTime
		{
			[Token(Token = "0x6024DA5")]
			[Address(RVA = "0x1FC0480", Offset = "0x1FBF080", VA = "0x181FC0480", Slot = "5")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x06024DA6 RID: 150950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024DA7 RID: 150951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005712")]
		public AutoChessServiceTeamInfo teamInfo
		{
			[Token(Token = "0x6024DA6")]
			[Address(RVA = "0x1FC06E0", Offset = "0x1FBF2E0", VA = "0x181FC06E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024DA7")]
			[Address(RVA = "0x1FC0740", Offset = "0x1FBF340", VA = "0x181FC0740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x06024DA8 RID: 150952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005713")]
		public AutoChessServiceBattleInfo battleInfo
		{
			[Token(Token = "0x6024DA8")]
			[Address(RVA = "0x1FC0410", Offset = "0x1FBF010", VA = "0x181FC0410", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x06024DA9 RID: 150953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005714")]
		private Server activeSvr
		{
			[Token(Token = "0x6024DA9")]
			[Address(RVA = "0x1FC02E0", Offset = "0x1FBEEE0", VA = "0x181FC02E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024DAA RID: 150954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAA")]
		[Address(RVA = "0x1FBE980", Offset = "0x1FBD580", VA = "0x181FBE980", Slot = "8")]
		public void Init(IAutoChessServiceCore core)
		{
		}

		// Token: 0x06024DAB RID: 150955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAB")]
		[Address(RVA = "0x1FBF620", Offset = "0x1FBE220", VA = "0x181FBF620")]
		public void Start(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024DAC RID: 150956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAC")]
		[Address(RVA = "0x1FBFCB0", Offset = "0x1FBE8B0", VA = "0x181FBFCB0")]
		private void _StartTeam1(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024DAD RID: 150957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAD")]
		[Address(RVA = "0x1FBFEF0", Offset = "0x1FBEAF0", VA = "0x181FBFEF0")]
		private void _StartTeam2(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024DAE RID: 150958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAE")]
		[Address(RVA = "0x1FBFAE0", Offset = "0x1FBE6E0", VA = "0x181FBFAE0")]
		private void _HandleTeam2Lost()
		{
		}

		// Token: 0x06024DAF RID: 150959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DAF")]
		[Address(RVA = "0x1FBFC30", Offset = "0x1FBE830", VA = "0x181FBFC30")]
		private void _JoinTeam2Result(bool suc)
		{
		}

		// Token: 0x06024DB0 RID: 150960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DB0")]
		[Address(RVA = "0x1FBF770", Offset = "0x1FBE370", VA = "0x181FBF770", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x06024DB1 RID: 150961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DB1")]
		[Address(RVA = "0x1FBE840", Offset = "0x1FBD440", VA = "0x181FBE840", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06024DB2 RID: 150962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DB2")]
		[Address(RVA = "0x1FBF430", Offset = "0x1FBE030", VA = "0x181FBF430", Slot = "12")]
		public void SendRequest(AutoChessServiceRequest request)
		{
		}

		// Token: 0x06024DB3 RID: 150963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DB3")]
		public TRequest RentRequestForSend<TRequest>() where TRequest : AutoChessServiceRequest, new()
		{
			return null;
		}

		// Token: 0x06024DB4 RID: 150964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DB4")]
		[Address(RVA = "0x1FBF1E0", Offset = "0x1FBDDE0", VA = "0x181FBF1E0", Slot = "11")]
		public void SendRequest(RequestHandler request)
		{
		}

		// Token: 0x06024DB5 RID: 150965 RVA: 0x000C5AA8 File Offset: 0x000C3CA8
		[Token(Token = "0x6024DB5")]
		[Address(RVA = "0x1FBF9F0", Offset = "0x1FBE5F0", VA = "0x181FBF9F0")]
		private bool _HandleLeaveRequest(AutoChessTeamProtocol.LeaveUp leave)
		{
			return default(bool);
		}

		// Token: 0x06024DB6 RID: 150966 RVA: 0x000C5AC0 File Offset: 0x000C3CC0
		[Token(Token = "0x6024DB6")]
		[Address(RVA = "0x1FBF920", Offset = "0x1FBE520", VA = "0x181FBF920")]
		private bool _HandleBackTeam(AutoChessTeamProtocol.BackTeamUp back)
		{
			return default(bool);
		}

		// Token: 0x06024DB7 RID: 150967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DB7")]
		[Address(RVA = "0x1FC01A0", Offset = "0x1FBEDA0", VA = "0x181FC01A0")]
		private void _SwitchBackToTeam1()
		{
		}

		// Token: 0x06024DB8 RID: 150968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DB8")]
		[Address(RVA = "0x1FBF800", Offset = "0x1FBE400", VA = "0x181FBF800")]
		private Server _GetTargetServer(AutoChessServiceRequestTarget target)
		{
			return null;
		}

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x06024DB9 RID: 150969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005715")]
		public AutoChessProtocolSuit protocolSuite
		{
			[Token(Token = "0x6024DB9")]
			[Address(RVA = "0x1FC0560", Offset = "0x1FBF160", VA = "0x181FC0560", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024DBA RID: 150970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DBA")]
		[Address(RVA = "0x1FBF540", Offset = "0x1FBE140", VA = "0x181FBF540", Slot = "15")]
		public void StartBattle(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024DBB RID: 150971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DBB")]
		[Address(RVA = "0x1FBF6B0", Offset = "0x1FBE2B0", VA = "0x181FBF6B0", Slot = "16")]
		public void TriggerEvent(AutoChessServiceEvent evt, [Optional] object arg)
		{
		}

		// Token: 0x06024DBC RID: 150972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DBC")]
		[Address(RVA = "0x1FBF150", Offset = "0x1FBDD50", VA = "0x181FBF150", Slot = "17")]
		public void OnTeamStatusChanged()
		{
		}

		// Token: 0x06024DBD RID: 150973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DBD")]
		[Address(RVA = "0x1FBEF70", Offset = "0x1FBDB70", VA = "0x181FBEF70", Slot = "18")]
		public void OnTeamMatchResult(AutoChessServiceMatchResult result)
		{
		}

		// Token: 0x06024DBE RID: 150974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DBE")]
		[Address(RVA = "0x1FBEE40", Offset = "0x1FBDA40", VA = "0x181FBEE40", Slot = "19")]
		public void OnTeamLost(AutoChessTeamServer team, AutoChessTeamLostReason reason)
		{
		}

		// Token: 0x06024DBF RID: 150975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DBF")]
		[Address(RVA = "0x1FBE8F0", Offset = "0x1FBD4F0", VA = "0x181FBE8F0", Slot = "20")]
		public AutoChessServiceTeamInfo GetTeamStatus()
		{
			return null;
		}

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x06024DC0 RID: 150976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005716")]
		public IAutoChessServiceStepReceiver stepReceiver
		{
			[Token(Token = "0x6024DC0")]
			[Address(RVA = "0x1FC05C0", Offset = "0x1FBF1C0", VA = "0x181FC05C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024DC1 RID: 150977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DC1")]
		[Address(RVA = "0x1FBEDB0", Offset = "0x1FBD9B0", VA = "0x181FBEDB0", Slot = "22")]
		public void OnBattleStatusChanged()
		{
		}

		// Token: 0x06024DC2 RID: 150978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DC2")]
		[Address(RVA = "0x1FC0280", Offset = "0x1FBEE80", VA = "0x181FC0280")]
		public AutoChessServiceMode()
		{
		}

		// Token: 0x04033844 RID: 211012
		[Token(Token = "0x4033844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IAutoChessServiceCore m_serviceCore;

		// Token: 0x04033845 RID: 211013
		[Token(Token = "0x4033845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AutoChessProtocolSuit m_protocolSuite;

		// Token: 0x04033846 RID: 211014
		[Token(Token = "0x4033846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ServerLoadingMask m_mask;

		// Token: 0x04033847 RID: 211015
		[Token(Token = "0x4033847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AutoChessBattleServer m_battleSvr;

		// Token: 0x04033848 RID: 211016
		[Token(Token = "0x4033848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AutoChessTeamServer m_activeTeamSvr;

		// Token: 0x04033849 RID: 211017
		[Token(Token = "0x4033849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AutoChessTeamServer m_team1;

		// Token: 0x0403384A RID: 211018
		[Token(Token = "0x403384A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AutoChessTeamServer m_team2;

		// Token: 0x0403384B RID: 211019
		[Token(Token = "0x403384B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AutoChessServiceRequestHandler m_handlers;

		// Token: 0x0403384D RID: 211021
		[Token(Token = "0x403384D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x0403384E RID: 211022
		[Token(Token = "0x403384E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x0403384F RID: 211023
		[Token(Token = "0x403384F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04033850 RID: 211024
		[Token(Token = "0x4033850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x04033851 RID: 211025
		[Token(Token = "0x4033851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04033852 RID: 211026
		[Token(Token = "0x4033852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_activeSvr;

		// Token: 0x04033853 RID: 211027
		[Token(Token = "0x4033853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033854 RID: 211028
		[Token(Token = "0x4033854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04033855 RID: 211029
		[Token(Token = "0x4033855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StartTeam1;

		// Token: 0x04033856 RID: 211030
		[Token(Token = "0x4033856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StartTeam2;

		// Token: 0x04033857 RID: 211031
		[Token(Token = "0x4033857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleTeam2Lost;

		// Token: 0x04033858 RID: 211032
		[Token(Token = "0x4033858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__JoinTeam2Result;

		// Token: 0x04033859 RID: 211033
		[Token(Token = "0x4033859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403385A RID: 211034
		[Token(Token = "0x403385A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0403385B RID: 211035
		[Token(Token = "0x403385B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x0403385C RID: 211036
		[Token(Token = "0x403385C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RentRequestForSend;

		// Token: 0x0403385D RID: 211037
		[Token(Token = "0x403385D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_SendRequest;

		// Token: 0x0403385E RID: 211038
		[Token(Token = "0x403385E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleLeaveRequest;

		// Token: 0x0403385F RID: 211039
		[Token(Token = "0x403385F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleBackTeam;

		// Token: 0x04033860 RID: 211040
		[Token(Token = "0x4033860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SwitchBackToTeam1;

		// Token: 0x04033861 RID: 211041
		[Token(Token = "0x4033861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetTargetServer;

		// Token: 0x04033862 RID: 211042
		[Token(Token = "0x4033862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_protocolSuite;

		// Token: 0x04033863 RID: 211043
		[Token(Token = "0x4033863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04033864 RID: 211044
		[Token(Token = "0x4033864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TriggerEvent;

		// Token: 0x04033865 RID: 211045
		[Token(Token = "0x4033865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnTeamStatusChanged;

		// Token: 0x04033866 RID: 211046
		[Token(Token = "0x4033866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnTeamMatchResult;

		// Token: 0x04033867 RID: 211047
		[Token(Token = "0x4033867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnTeamLost;

		// Token: 0x04033868 RID: 211048
		[Token(Token = "0x4033868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetTeamStatus;

		// Token: 0x04033869 RID: 211049
		[Token(Token = "0x4033869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_stepReceiver;

		// Token: 0x0403386A RID: 211050
		[Token(Token = "0x403386A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnBattleStatusChanged;

		// Token: 0x0403386B RID: 211051
		[Token(Token = "0x403386B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063DC RID: 25564
		[Token(Token = "0x20063DC")]
		private class SvrLogRule : IServerLogRule
		{
			// Token: 0x06024DC3 RID: 150979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024DC3")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public SvrLogRule(string svrName)
			{
			}

			// Token: 0x17005717 RID: 22295
			// (get) Token: 0x06024DC4 RID: 150980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005717")]
			public string prefix
			{
				[Token(Token = "0x6024DC4")]
				[Address(RVA = "0x1FC3B40", Offset = "0x1FC2740", VA = "0x181FC3B40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005718 RID: 22296
			// (get) Token: 0x06024DC5 RID: 150981 RVA: 0x000C5AD8 File Offset: 0x000C3CD8
			[Token(Token = "0x17005718")]
			public bool logDetail
			{
				[Token(Token = "0x6024DC5")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06024DC6 RID: 150982 RVA: 0x000C5AF0 File Offset: 0x000C3CF0
			[Token(Token = "0x6024DC6")]
			[Address(RVA = "0x1FC3B10", Offset = "0x1FC2710", VA = "0x181FC3B10", Slot = "5")]
			public bool AllowedRevMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x06024DC7 RID: 150983 RVA: 0x000C5B08 File Offset: 0x000C3D08
			[Token(Token = "0x6024DC7")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			public bool AllowedSendMsg(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x0403386C RID: 211052
			[Token(Token = "0x403386C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_svrName;
		}
	}
}
