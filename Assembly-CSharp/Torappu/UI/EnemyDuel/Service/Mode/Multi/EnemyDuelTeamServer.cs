using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.Connections;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050A4 RID: 20644
	[Token(Token = "0x20050A4")]
	public class EnemyDuelTeamServer : Server
	{
		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x0601E923 RID: 125219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E924 RID: 125220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004768")]
		public EnemyDuelServiceTeamInfo teamInfo
		{
			[Token(Token = "0x601E923")]
			[Address(RVA = "0x184C1E0", Offset = "0x184ADE0", VA = "0x18184C1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E924")]
			[Address(RVA = "0x184C240", Offset = "0x184AE40", VA = "0x18184C240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E925 RID: 125221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E925")]
		[Address(RVA = "0x184BD80", Offset = "0x184A980", VA = "0x18184BD80")]
		public EnemyDuelTeamServer(IEnemyDuelServerClient client)
		{
		}

		// Token: 0x0601E926 RID: 125222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E926")]
		[Address(RVA = "0x184A350", Offset = "0x1848F50", VA = "0x18184A350", Slot = "4")]
		protected override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x0601E927 RID: 125223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E927")]
		[Address(RVA = "0x184A130", Offset = "0x1848D30", VA = "0x18184A130", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x0601E928 RID: 125224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E928")]
		[Address(RVA = "0x184A2C0", Offset = "0x1848EC0", VA = "0x18184A2C0", Slot = "7")]
		protected override void OnHandleFailedParseMsg(NetMsgID msgId)
		{
		}

		// Token: 0x0601E929 RID: 125225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E929")]
		[Address(RVA = "0x184A4E0", Offset = "0x18490E0", VA = "0x18184A4E0")]
		public void Start(TeamJoinEntry entry)
		{
		}

		// Token: 0x0601E92A RID: 125226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E92A")]
		[Address(RVA = "0x184A5B0", Offset = "0x18491B0", VA = "0x18184A5B0")]
		public void Stop()
		{
		}

		// Token: 0x0601E92B RID: 125227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E92B")]
		[Address(RVA = "0x184A620", Offset = "0x1849220", VA = "0x18184A620")]
		private void _DoJoinTeam()
		{
		}

		// Token: 0x0601E92C RID: 125228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E92C")]
		[Address(RVA = "0x184BA30", Offset = "0x184A630", VA = "0x18184BA30")]
		private void _TryInvokeFollower(bool suc)
		{
		}

		// Token: 0x0601E92D RID: 125229 RVA: 0x000AEF60 File Offset: 0x000AD160
		[Token(Token = "0x601E92D")]
		[Address(RVA = "0x184B870", Offset = "0x184A470", VA = "0x18184B870")]
		private bool _JoinResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E92E RID: 125230 RVA: 0x000AEF78 File Offset: 0x000AD178
		[Token(Token = "0x601E92E")]
		[Address(RVA = "0x184B980", Offset = "0x184A580", VA = "0x18184B980")]
		private bool _LeaveResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E92F RID: 125231 RVA: 0x000AEF90 File Offset: 0x000AD190
		[Token(Token = "0x601E92F")]
		[Address(RVA = "0x184BAD0", Offset = "0x184A6D0", VA = "0x18184BAD0")]
		private bool _UpdateTeamStatus(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E930 RID: 125232 RVA: 0x000AEFA8 File Offset: 0x000AD1A8
		[Token(Token = "0x601E930")]
		[Address(RVA = "0x184A930", Offset = "0x1849530", VA = "0x18184A930")]
		private bool _HandleBattleStart(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E931 RID: 125233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E931")]
		[Address(RVA = "0x184A750", Offset = "0x1849350", VA = "0x18184A750")]
		private void _EnterBattle(STDuelSceneInfo scene)
		{
		}

		// Token: 0x0601E932 RID: 125234 RVA: 0x000AEFC0 File Offset: 0x000AD1C0
		[Token(Token = "0x601E932")]
		[Address(RVA = "0x184AB60", Offset = "0x1849760", VA = "0x18184AB60")]
		private bool _HandleKickRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E933 RID: 125235 RVA: 0x000AEFD8 File Offset: 0x000AD1D8
		[Token(Token = "0x601E933")]
		[Address(RVA = "0x184AA30", Offset = "0x1849630", VA = "0x18184AA30")]
		private bool _HandleGetNameCard(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E934 RID: 125236 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		[Token(Token = "0x601E934")]
		[Address(RVA = "0x184B4D0", Offset = "0x184A0D0", VA = "0x18184B4D0")]
		private bool _HandlePlayerStateChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E935 RID: 125237 RVA: 0x000AF008 File Offset: 0x000AD208
		[Token(Token = "0x601E935")]
		[Address(RVA = "0x184AD30", Offset = "0x1849930", VA = "0x18184AD30")]
		private bool _HandlePlayerConnStateChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E936 RID: 125238 RVA: 0x000AF020 File Offset: 0x000AD220
		[Token(Token = "0x601E936")]
		[Address(RVA = "0x184B110", Offset = "0x1849D10", VA = "0x18184B110")]
		private bool _HandlePlayerNew(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E937 RID: 125239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E937")]
		[Address(RVA = "0x183D880", Offset = "0x183C480", VA = "0x18183D880")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x0601E938 RID: 125240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E938")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x0601E939 RID: 125241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E939")]
		[Address(RVA = "0x184A610", Offset = "0x1849210", VA = "0x18184A610")]
		private void <>xLuaBaseProxy_OnHandleFailedParseMsg(NetMsgID P0)
		{
		}

		// Token: 0x04028F4A RID: 167754
		[Token(Token = "0x4028F4A")]
		[FieldOffset(Offset = "0x68")]
		private IEnemyDuelServerClient m_client;

		// Token: 0x04028F4B RID: 167755
		[Token(Token = "0x4028F4B")]
		[FieldOffset(Offset = "0x70")]
		private TeamJoinEntry m_entry;

		// Token: 0x04028F4D RID: 167757
		[Token(Token = "0x4028F4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04028F4E RID: 167758
		[Token(Token = "0x4028F4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x04028F4F RID: 167759
		[Token(Token = "0x4028F4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04028F50 RID: 167760
		[Token(Token = "0x4028F50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04028F51 RID: 167761
		[Token(Token = "0x4028F51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04028F52 RID: 167762
		[Token(Token = "0x4028F52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnHandleFailedParseMsg;

		// Token: 0x04028F53 RID: 167763
		[Token(Token = "0x4028F53")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04028F54 RID: 167764
		[Token(Token = "0x4028F54")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04028F55 RID: 167765
		[Token(Token = "0x4028F55")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoJoinTeam;

		// Token: 0x04028F56 RID: 167766
		[Token(Token = "0x4028F56")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryInvokeFollower;

		// Token: 0x04028F57 RID: 167767
		[Token(Token = "0x4028F57")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JoinResult;

		// Token: 0x04028F58 RID: 167768
		[Token(Token = "0x4028F58")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LeaveResult;

		// Token: 0x04028F59 RID: 167769
		[Token(Token = "0x4028F59")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateTeamStatus;

		// Token: 0x04028F5A RID: 167770
		[Token(Token = "0x4028F5A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleBattleStart;

		// Token: 0x04028F5B RID: 167771
		[Token(Token = "0x4028F5B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EnterBattle;

		// Token: 0x04028F5C RID: 167772
		[Token(Token = "0x4028F5C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleKickRet;

		// Token: 0x04028F5D RID: 167773
		[Token(Token = "0x4028F5D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleGetNameCard;

		// Token: 0x04028F5E RID: 167774
		[Token(Token = "0x4028F5E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandlePlayerStateChanged;

		// Token: 0x04028F5F RID: 167775
		[Token(Token = "0x4028F5F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandlePlayerConnStateChanged;

		// Token: 0x04028F60 RID: 167776
		[Token(Token = "0x4028F60")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandlePlayerNew;
	}
}
