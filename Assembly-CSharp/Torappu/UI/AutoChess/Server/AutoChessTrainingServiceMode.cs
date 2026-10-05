using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063DF RID: 25567
	[Token(Token = "0x20063DF")]
	public class AutoChessTrainingServiceMode : IAutoChessServiceMode, IHotfixable
	{
		// Token: 0x06024DD7 RID: 150999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DD7")]
		[Address(RVA = "0x1FC2BA0", Offset = "0x1FC17A0", VA = "0x181FC2BA0")]
		public void Start(string actId, Action<bool> onJoinDone)
		{
		}

		// Token: 0x06024DD8 RID: 151000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DD8")]
		[Address(RVA = "0x1FC2F80", Offset = "0x1FC1B80", VA = "0x181FC2F80")]
		private void _OnTeamStatusChanged()
		{
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x06024DD9 RID: 151001 RVA: 0x000C5B20 File Offset: 0x000C3D20
		[Token(Token = "0x17005719")]
		public int ping
		{
			[Token(Token = "0x6024DD9")]
			[Address(RVA = "0x1FC3480", Offset = "0x1FC2080", VA = "0x181FC3480", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x06024DDA RID: 151002 RVA: 0x000C5B38 File Offset: 0x000C3D38
		[Token(Token = "0x1700571A")]
		public DateTime currentTime
		{
			[Token(Token = "0x6024DDA")]
			[Address(RVA = "0x1FC3400", Offset = "0x1FC2000", VA = "0x181FC3400", Slot = "5")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x06024DDB RID: 151003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024DDC RID: 151004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700571B")]
		public AutoChessServiceTeamInfo teamInfo
		{
			[Token(Token = "0x6024DDB")]
			[Address(RVA = "0x1FC34E0", Offset = "0x1FC20E0", VA = "0x181FC34E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024DDC")]
			[Address(RVA = "0x1FC35C0", Offset = "0x1FC21C0", VA = "0x181FC35C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x06024DDD RID: 151005 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024DDE RID: 151006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700571C")]
		public AutoChessServiceBattleInfo battleInfo
		{
			[Token(Token = "0x6024DDD")]
			[Address(RVA = "0x1FC33A0", Offset = "0x1FC1FA0", VA = "0x181FC33A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024DDE")]
			[Address(RVA = "0x1FC3540", Offset = "0x1FC2140", VA = "0x181FC3540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024DDF RID: 151007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DDF")]
		[Address(RVA = "0x1FC26A0", Offset = "0x1FC12A0", VA = "0x181FC26A0", Slot = "8")]
		public void Init(IAutoChessServiceCore host)
		{
		}

		// Token: 0x06024DE0 RID: 151008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DE0")]
		[Address(RVA = "0x1FC25B0", Offset = "0x1FC11B0", VA = "0x181FC25B0", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06024DE1 RID: 151009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DE1")]
		[Address(RVA = "0x1FC2CD0", Offset = "0x1FC18D0", VA = "0x181FC2CD0", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x06024DE2 RID: 151010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DE2")]
		[Address(RVA = "0x1FC2610", Offset = "0x1FC1210", VA = "0x181FC2610")]
		public AutoChessServiceTeamInfo GetTeamStatus()
		{
			return null;
		}

		// Token: 0x06024DE3 RID: 151011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DE3")]
		[Address(RVA = "0x1FC2B40", Offset = "0x1FC1740", VA = "0x181FC2B40", Slot = "11")]
		public void SendRequest(RequestHandler request)
		{
		}

		// Token: 0x06024DE4 RID: 151012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DE4")]
		[Address(RVA = "0x1FC2A90", Offset = "0x1FC1690", VA = "0x181FC2A90", Slot = "12")]
		public void SendRequest(AutoChessServiceRequest request)
		{
		}

		// Token: 0x06024DE5 RID: 151013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DE5")]
		public TRequest RentRequestForSend<TRequest>() where TRequest : AutoChessServiceRequest, new()
		{
			return null;
		}

		// Token: 0x06024DE6 RID: 151014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DE6")]
		[Address(RVA = "0x1FC3180", Offset = "0x1FC1D80", VA = "0x181FC3180")]
		private void _RegisterHandlers(AutoChessServiceRequestHandler handlers)
		{
		}

		// Token: 0x06024DE7 RID: 151015 RVA: 0x000C5B50 File Offset: 0x000C3D50
		[Token(Token = "0x6024DE7")]
		[Address(RVA = "0x1FC2EF0", Offset = "0x1FC1AF0", VA = "0x181FC2EF0")]
		private bool _HandleStageInfoReadyRequest(AutoChessTeamProtocol.AutoChessTeamEnemyAssignReadyUp request)
		{
			return default(bool);
		}

		// Token: 0x06024DE8 RID: 151016 RVA: 0x000C5B68 File Offset: 0x000C3D68
		[Token(Token = "0x6024DE8")]
		[Address(RVA = "0x1FC2D30", Offset = "0x1FC1930", VA = "0x181FC2D30")]
		private bool _HandleChooseStrategyRequest(AutoChessTeamProtocol.AutoChessTeamChooseStrategyUp request)
		{
			return default(bool);
		}

		// Token: 0x06024DE9 RID: 151017 RVA: 0x000C5B80 File Offset: 0x000C3D80
		[Token(Token = "0x6024DE9")]
		[Address(RVA = "0x1FC2E30", Offset = "0x1FC1A30", VA = "0x181FC2E30")]
		private bool _HandleLeaveRequest(AutoChessTeamProtocol.LeaveUp request)
		{
			return default(bool);
		}

		// Token: 0x06024DEA RID: 151018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DEA")]
		[Address(RVA = "0x1FC3340", Offset = "0x1FC1F40", VA = "0x181FC3340")]
		public AutoChessTrainingServiceMode()
		{
		}

		// Token: 0x0403387E RID: 211070
		[Token(Token = "0x403387E")]
		[FieldOffset(Offset = "0x10")]
		private IAutoChessServiceCore m_serviceCore;

		// Token: 0x0403387F RID: 211071
		[Token(Token = "0x403387F")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessServiceRequestHandler m_handlers;

		// Token: 0x04033880 RID: 211072
		[Token(Token = "0x4033880")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessTrainingServiceMode.TrainingTeamData m_teamData;

		// Token: 0x04033881 RID: 211073
		[Token(Token = "0x4033881")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessProtocolSuit m_protocolSuite;

		// Token: 0x04033884 RID: 211076
		[Token(Token = "0x4033884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04033885 RID: 211077
		[Token(Token = "0x4033885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnTeamStatusChanged;

		// Token: 0x04033886 RID: 211078
		[Token(Token = "0x4033886")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04033887 RID: 211079
		[Token(Token = "0x4033887")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04033888 RID: 211080
		[Token(Token = "0x4033888")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04033889 RID: 211081
		[Token(Token = "0x4033889")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x0403388A RID: 211082
		[Token(Token = "0x403388A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x0403388B RID: 211083
		[Token(Token = "0x403388B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x0403388C RID: 211084
		[Token(Token = "0x403388C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403388D RID: 211085
		[Token(Token = "0x403388D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0403388E RID: 211086
		[Token(Token = "0x403388E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403388F RID: 211087
		[Token(Token = "0x403388F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTeamStatus;

		// Token: 0x04033890 RID: 211088
		[Token(Token = "0x4033890")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04033891 RID: 211089
		[Token(Token = "0x4033891")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1_SendRequest;

		// Token: 0x04033892 RID: 211090
		[Token(Token = "0x4033892")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RentRequestForSend;

		// Token: 0x04033893 RID: 211091
		[Token(Token = "0x4033893")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RegisterHandlers;

		// Token: 0x04033894 RID: 211092
		[Token(Token = "0x4033894")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleStageInfoReadyRequest;

		// Token: 0x04033895 RID: 211093
		[Token(Token = "0x4033895")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleChooseStrategyRequest;

		// Token: 0x04033896 RID: 211094
		[Token(Token = "0x4033896")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleLeaveRequest;

		// Token: 0x04033897 RID: 211095
		[Token(Token = "0x4033897")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063E0 RID: 25568
		[Token(Token = "0x20063E0")]
		private class TrainingTeamData
		{
			// Token: 0x1700571D RID: 22301
			// (get) Token: 0x06024DEB RID: 151019 RVA: 0x000C5B98 File Offset: 0x000C3D98
			[Token(Token = "0x1700571D")]
			public AutoChessTeamStatus teamStatus
			{
				[Token(Token = "0x6024DEB")]
				[Address(RVA = "0x1FC4A80", Offset = "0x1FC3680", VA = "0x181FC4A80")]
				get
				{
					return default(AutoChessTeamStatus);
				}
			}

			// Token: 0x06024DEC RID: 151020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024DEC")]
			[Address(RVA = "0x1FC45D0", Offset = "0x1FC31D0", VA = "0x181FC45D0")]
			public TrainingTeamData(string actId)
			{
			}

			// Token: 0x06024DED RID: 151021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024DED")]
			[Address(RVA = "0x1FC3EE0", Offset = "0x1FC2AE0", VA = "0x181FC3EE0")]
			private List<MsgAutoChessPlayerStatus> _GenPlayerStatusList(string actId, List<ActAutoChessData.ActAutoChessTrainingNpcData> npcDatas)
			{
				return null;
			}

			// Token: 0x06024DEE RID: 151022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024DEE")]
			[Address(RVA = "0x1FC3CE0", Offset = "0x1FC28E0", VA = "0x181FC3CE0")]
			private MsgAutoChessPlayerStatus _GenNpcPlayerStatus(ActAutoChessData.ActAutoChessTrainingNpcData npcData)
			{
				return null;
			}

			// Token: 0x06024DEF RID: 151023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024DEF")]
			[Address(RVA = "0x1FC4090", Offset = "0x1FC2C90", VA = "0x181FC4090")]
			private MsgAutoChessPlayerStatus _GenSelfPlayerStatus(string actId)
			{
				return null;
			}

			// Token: 0x06024DF0 RID: 151024 RVA: 0x000C5BB0 File Offset: 0x000C3DB0
			[Token(Token = "0x6024DF0")]
			[Address(RVA = "0x1FC43E0", Offset = "0x1FC2FE0", VA = "0x181FC43E0")]
			private StrategyDecisionBrief _GenStrategyDecisionBrief(List<ActAutoChessData.ActAutoChessTrainingNpcData> npcDatas)
			{
				return default(StrategyDecisionBrief);
			}

			// Token: 0x06024DF1 RID: 151025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024DF1")]
			[Address(RVA = "0x1FC3B80", Offset = "0x1FC2780", VA = "0x181FC3B80")]
			public void HandleEnemyAssignReady()
			{
			}

			// Token: 0x06024DF2 RID: 151026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024DF2")]
			[Address(RVA = "0x1FC3CB0", Offset = "0x1FC28B0", VA = "0x181FC3CB0")]
			public void HandleStrategyChosen()
			{
			}

			// Token: 0x06024DF3 RID: 151027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024DF3")]
			[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
			public void HandleLeave()
			{
			}

			// Token: 0x04033898 RID: 211096
			[Token(Token = "0x4033898")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessTeamStatus m_teamStatus;

			// Token: 0x04033899 RID: 211097
			[Token(Token = "0x4033899")]
			[FieldOffset(Offset = "0x90")]
			private MsgAutoChessPlayerStatus m_selfStatus;

			// Token: 0x0403389A RID: 211098
			[Token(Token = "0x403389A")]
			[FieldOffset(Offset = "0x98")]
			private List<MsgAutoChessPlayerStatus> m_npcStatusList;

			// Token: 0x0403389B RID: 211099
			[Token(Token = "0x403389B")]
			[FieldOffset(Offset = "0xA0")]
			private string m_selfUID;
		}
	}
}
