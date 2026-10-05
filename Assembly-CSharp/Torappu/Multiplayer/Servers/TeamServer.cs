using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.Connections;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x020015C8 RID: 5576
	[Token(Token = "0x20015C8")]
	public class TeamServer : Server
	{
		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EFA")]
		public TeamInfo teamInfo
		{
			[Token(Token = "0x6007E49")]
			[Address(RVA = "0x2852720", Offset = "0x2851320", VA = "0x182852720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007E4A")]
			[Address(RVA = "0x2852780", Offset = "0x2851380", VA = "0x182852780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4B")]
		[Address(RVA = "0x2852050", Offset = "0x2850C50", VA = "0x182852050")]
		public TeamServer(ITeamClient client)
		{
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4C")]
		[Address(RVA = "0x284F9F0", Offset = "0x284E5F0", VA = "0x18284F9F0", Slot = "4")]
		protected override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4D")]
		[Address(RVA = "0x284F7B0", Offset = "0x284E3B0", VA = "0x18284F7B0", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4E")]
		[Address(RVA = "0x284F950", Offset = "0x284E550", VA = "0x18284F950", Slot = "7")]
		protected override void OnHandleFailedParseMsg(NetMsgID msgId)
		{
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4F")]
		[Address(RVA = "0x284FA70", Offset = "0x284E670", VA = "0x18284FA70")]
		public void Start(TeamInst team, TeamJoinFollower follower)
		{
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E50")]
		[Address(RVA = "0x284F750", Offset = "0x284E350", VA = "0x18284F750")]
		public void Close()
		{
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E51")]
		[Address(RVA = "0x284FDD0", Offset = "0x284E9D0", VA = "0x18284FDD0")]
		private void _DoJoin()
		{
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E52")]
		[Address(RVA = "0x2851AF0", Offset = "0x28506F0", VA = "0x182851AF0")]
		private void _TryInvokeFollower(bool suc)
		{
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x000379E0 File Offset: 0x00035BE0
		[Token(Token = "0x6007E53")]
		[Address(RVA = "0x2851890", Offset = "0x2850490", VA = "0x182851890")]
		private bool _JoinResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E54")]
		[Address(RVA = "0x284FBC0", Offset = "0x284E7C0", VA = "0x18284FBC0")]
		private void _AlertConnectFailed()
		{
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x000379F8 File Offset: 0x00035BF8
		[Token(Token = "0x6007E55")]
		[Address(RVA = "0x28519B0", Offset = "0x28505B0", VA = "0x1828519B0")]
		private bool _LeaveResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00037A10 File Offset: 0x00035C10
		[Token(Token = "0x6007E56")]
		[Address(RVA = "0x2850540", Offset = "0x284F140", VA = "0x182850540")]
		private bool _HandleChatRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00037A28 File Offset: 0x00035C28
		[Token(Token = "0x6007E57")]
		[Address(RVA = "0x2850EF0", Offset = "0x284FAF0", VA = "0x182850EF0")]
		private bool _HandlePickRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x00037A40 File Offset: 0x00035C40
		[Token(Token = "0x6007E58")]
		[Address(RVA = "0x2851B90", Offset = "0x2850790", VA = "0x182851B90")]
		private bool _UpdateTeamStatus(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00037A58 File Offset: 0x00035C58
		[Token(Token = "0x6007E59")]
		[Address(RVA = "0x28503F0", Offset = "0x284EFF0", VA = "0x1828503F0")]
		private bool _HandleBattleStart(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5A")]
		[Address(RVA = "0x284FFE0", Offset = "0x284EBE0", VA = "0x18284FFE0")]
		private void _EnterBattle(TeamProtocol.STSceneInfo scene)
		{
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x00037A70 File Offset: 0x00035C70
		[Token(Token = "0x6007E5B")]
		[Address(RVA = "0x2850C30", Offset = "0x284F830", VA = "0x182850C30")]
		private bool _HandleKickRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x00037A88 File Offset: 0x00035C88
		[Token(Token = "0x6007E5C")]
		[Address(RVA = "0x2851490", Offset = "0x2850090", VA = "0x182851490")]
		private bool _HandleSetCharSlotRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x00037AA0 File Offset: 0x00035CA0
		[Token(Token = "0x6007E5D")]
		[Address(RVA = "0x28512E0", Offset = "0x284FEE0", VA = "0x1828512E0")]
		private bool _HandleSaveSquadRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x00037AB8 File Offset: 0x00035CB8
		[Token(Token = "0x6007E5E")]
		[Address(RVA = "0x2850720", Offset = "0x284F320", VA = "0x182850720")]
		private bool _HandleChooseStageRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x00037AD0 File Offset: 0x00035CD0
		[Token(Token = "0x6007E5F")]
		[Address(RVA = "0x2850930", Offset = "0x284F530", VA = "0x182850930")]
		private bool _HandleGetNameCard(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x00037AE8 File Offset: 0x00035CE8
		[Token(Token = "0x6007E60")]
		[Address(RVA = "0x2851600", Offset = "0x2850200", VA = "0x182851600")]
		private bool _HandleSetFlipModeRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x00037B00 File Offset: 0x00035D00
		[Token(Token = "0x6007E61")]
		[Address(RVA = "0x2851770", Offset = "0x2850370", VA = "0x182851770")]
		private bool _HandleSettleLikeRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x00037B18 File Offset: 0x00035D18
		[Token(Token = "0x6007E62")]
		[Address(RVA = "0x28511C0", Offset = "0x284FDC0", VA = "0x1828511C0")]
		private bool _HandlePlayerStateChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x00037B30 File Offset: 0x00035D30
		[Token(Token = "0x6007E63")]
		[Address(RVA = "0x2851090", Offset = "0x284FC90", VA = "0x182851090")]
		private bool _HandlePlayerConnChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007E64")]
		[Address(RVA = "0x28501D0", Offset = "0x284EDD0", VA = "0x1828501D0")]
		private TeamProtocol.STPlayerStatus _GetPlayerStatus(string uid)
		{
			return null;
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E65")]
		[Address(RVA = "0x183D880", Offset = "0x183C480", VA = "0x18183D880")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E66")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E67")]
		[Address(RVA = "0x184A610", Offset = "0x1849210", VA = "0x18184A610")]
		private void <>xLuaBaseProxy_OnHandleFailedParseMsg(NetMsgID P0)
		{
		}

		// Token: 0x04007FFF RID: 32767
		[Token(Token = "0x4007FFF")]
		[FieldOffset(Offset = "0x68")]
		private TeamInst m_team;

		// Token: 0x04008000 RID: 32768
		[Token(Token = "0x4008000")]
		[FieldOffset(Offset = "0x70")]
		private TeamJoinFollower m_joinFollower;

		// Token: 0x04008002 RID: 32770
		[Token(Token = "0x4008002")]
		[FieldOffset(Offset = "0x80")]
		private readonly ITeamClient m_client;

		// Token: 0x04008003 RID: 32771
		[Token(Token = "0x4008003")]
		[FieldOffset(Offset = "0x88")]
		private TeamChatParam m_chatParam;

		// Token: 0x04008004 RID: 32772
		[Token(Token = "0x4008004")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04008005 RID: 32773
		[Token(Token = "0x4008005")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x04008006 RID: 32774
		[Token(Token = "0x4008006")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008007 RID: 32775
		[Token(Token = "0x4008007")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04008008 RID: 32776
		[Token(Token = "0x4008008")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04008009 RID: 32777
		[Token(Token = "0x4008009")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnHandleFailedParseMsg;

		// Token: 0x0400800A RID: 32778
		[Token(Token = "0x400800A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400800B RID: 32779
		[Token(Token = "0x400800B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0400800C RID: 32780
		[Token(Token = "0x400800C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoJoin;

		// Token: 0x0400800D RID: 32781
		[Token(Token = "0x400800D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryInvokeFollower;

		// Token: 0x0400800E RID: 32782
		[Token(Token = "0x400800E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JoinResult;

		// Token: 0x0400800F RID: 32783
		[Token(Token = "0x400800F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AlertConnectFailed;

		// Token: 0x04008010 RID: 32784
		[Token(Token = "0x4008010")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LeaveResult;

		// Token: 0x04008011 RID: 32785
		[Token(Token = "0x4008011")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleChatRet;

		// Token: 0x04008012 RID: 32786
		[Token(Token = "0x4008012")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandlePickRet;

		// Token: 0x04008013 RID: 32787
		[Token(Token = "0x4008013")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateTeamStatus;

		// Token: 0x04008014 RID: 32788
		[Token(Token = "0x4008014")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleBattleStart;

		// Token: 0x04008015 RID: 32789
		[Token(Token = "0x4008015")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EnterBattle;

		// Token: 0x04008016 RID: 32790
		[Token(Token = "0x4008016")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleKickRet;

		// Token: 0x04008017 RID: 32791
		[Token(Token = "0x4008017")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleSetCharSlotRet;

		// Token: 0x04008018 RID: 32792
		[Token(Token = "0x4008018")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleSaveSquadRet;

		// Token: 0x04008019 RID: 32793
		[Token(Token = "0x4008019")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleChooseStageRet;

		// Token: 0x0400801A RID: 32794
		[Token(Token = "0x400801A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__HandleGetNameCard;

		// Token: 0x0400801B RID: 32795
		[Token(Token = "0x400801B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__HandleSetFlipModeRet;

		// Token: 0x0400801C RID: 32796
		[Token(Token = "0x400801C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__HandleSettleLikeRet;

		// Token: 0x0400801D RID: 32797
		[Token(Token = "0x400801D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandlePlayerStateChanged;

		// Token: 0x0400801E RID: 32798
		[Token(Token = "0x400801E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandlePlayerConnChanged;

		// Token: 0x0400801F RID: 32799
		[Token(Token = "0x400801F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetPlayerStatus;
	}
}
