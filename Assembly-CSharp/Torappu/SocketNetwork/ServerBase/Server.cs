using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014C8 RID: 5320
	[Token(Token = "0x20014C8")]
	public abstract class Server : IHotfixable
	{
		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x00036D50 File Offset: 0x00034F50
		[Token(Token = "0x17000E9E")]
		public int ping
		{
			[Token(Token = "0x6007AA4")]
			[Address(RVA = "0x264B2C0", Offset = "0x2649EC0", VA = "0x18264B2C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06007AA5 RID: 31397 RVA: 0x00036D68 File Offset: 0x00034F68
		[Token(Token = "0x17000E9F")]
		public ServerConfig config
		{
			[Token(Token = "0x6007AA5")]
			[Address(RVA = "0x264B0B0", Offset = "0x2649CB0", VA = "0x18264B0B0")]
			get
			{
				return default(ServerConfig);
			}
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA6")]
		[Address(RVA = "0x264A060", Offset = "0x2648C60", VA = "0x18264A060")]
		public void SetConfig(ServerConfig config)
		{
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x00036D80 File Offset: 0x00034F80
		// (set) Token: 0x06007AA8 RID: 31400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EA0")]
		public float maxRetryTime
		{
			[Token(Token = "0x6007AA7")]
			[Address(RVA = "0x264B260", Offset = "0x2649E60", VA = "0x18264B260")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007AA8")]
			[Address(RVA = "0x264B430", Offset = "0x264A030", VA = "0x18264B430")]
			set
			{
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (set) Token: 0x06007AA9 RID: 31401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EA1")]
		public IServerLogRule logRule
		{
			[Token(Token = "0x6007AA9")]
			[Address(RVA = "0x264B370", Offset = "0x2649F70", VA = "0x18264B370")]
			set
			{
			}
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAA")]
		[Address(RVA = "0x264ADE0", Offset = "0x26499E0", VA = "0x18264ADE0")]
		public Server(INetProtocolSuite protocolSuite)
		{
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x00036D98 File Offset: 0x00034F98
		[Token(Token = "0x17000EA2")]
		public DateTime currentTime
		{
			[Token(Token = "0x6007AAB")]
			[Address(RVA = "0x264B1A0", Offset = "0x2649DA0", VA = "0x18264B1A0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAC")]
		[Address(RVA = "0x264A1A0", Offset = "0x2648DA0", VA = "0x18264A1A0")]
		protected void SyncTime(long serverTs)
		{
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAD")]
		[Address(RVA = "0x264A9F0", Offset = "0x26495F0", VA = "0x18264A9F0")]
		private void _NetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAE")]
		[Address(RVA = "0x264A250", Offset = "0x2648E50", VA = "0x18264A250")]
		public void Update()
		{
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAF")]
		[Address(RVA = "0x264A890", Offset = "0x2649490", VA = "0x18264A890")]
		private void _HandleReconnection()
		{
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB0")]
		[Address(RVA = "0x2649E90", Offset = "0x2648A90", VA = "0x182649E90")]
		public void SendMsg(Protocol protocol)
		{
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB1")]
		public void SendMsg<ProtocolType>() where ProtocolType : Protocol, new()
		{
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB2")]
		[Address(RVA = "0x2649D70", Offset = "0x2648970", VA = "0x182649D70")]
		public void SendMsg(RequestHandler req)
		{
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AB3")]
		[Address(RVA = "0x264A440", Offset = "0x2649040", VA = "0x18264A440")]
		private RRPairMsgProcessor _GetRRPMsgProcessor()
		{
			return null;
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AB4")]
		[Address(RVA = "0x264AB00", Offset = "0x2649700", VA = "0x18264AB00")]
		private NetMsg _SerializeToMsg(Protocol protocol)
		{
			return null;
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB5")]
		[Address(RVA = "0x2649FC0", Offset = "0x2648BC0", VA = "0x182649FC0")]
		public void SendToSelf(Protocol protocol)
		{
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00036DB0 File Offset: 0x00034FB0
		[Token(Token = "0x17000EA3")]
		public bool connected
		{
			[Token(Token = "0x6007AB6")]
			[Address(RVA = "0x264B130", Offset = "0x2649D30", VA = "0x18264B130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06007AB7 RID: 31415 RVA: 0x00036DC8 File Offset: 0x00034FC8
		[Token(Token = "0x17000EA4")]
		public bool alive
		{
			[Token(Token = "0x6007AB7")]
			[Address(RVA = "0x264B040", Offset = "0x2649C40", VA = "0x18264B040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x00036DE0 File Offset: 0x00034FE0
		[Token(Token = "0x6007AB8")]
		[Address(RVA = "0x26495F0", Offset = "0x26481F0", VA = "0x1826495F0")]
		protected bool ConnectTo(string address)
		{
			return default(bool);
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x00036DF8 File Offset: 0x00034FF8
		[Token(Token = "0x6007AB9")]
		[Address(RVA = "0x2649700", Offset = "0x2648300", VA = "0x182649700")]
		protected bool ConnectTo(string ip, int port)
		{
			return default(bool);
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ABA")]
		[Address(RVA = "0x2649590", Offset = "0x2648190", VA = "0x182649590")]
		[Obsolete("Will be removed")]
		protected void CompleteConnectProc()
		{
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ABB")]
		[Address(RVA = "0x2649A40", Offset = "0x2648640", VA = "0x182649A40")]
		protected void Disconnect()
		{
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ABC")]
		[Address(RVA = "0x264A360", Offset = "0x2648F60", VA = "0x18264A360")]
		private void _Disconnect(Server.NetLostType type)
		{
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ABD")]
		[Address(RVA = "0x264A800", Offset = "0x2649400", VA = "0x18264A800")]
		private void _HandleFailedParseMsg(NetMsgID id)
		{
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x00036E10 File Offset: 0x00035010
		[Token(Token = "0x6007ABE")]
		[Address(RVA = "0x264A300", Offset = "0x2648F00", VA = "0x18264A300")]
		private bool _CheckNetReachable()
		{
			return default(bool);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ABF")]
		[Address(RVA = "0x264AD40", Offset = "0x2649940", VA = "0x18264AD40")]
		private void _SetupReconnection()
		{
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC0")]
		[Address(RVA = "0x2649B60", Offset = "0x2648760", VA = "0x182649B60")]
		public void RegisterMsgHandler(NetMsgID id, ProtocolHandler handler)
		{
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC1")]
		public void RegisterMsgHandler<TProtocol>(Action<TProtocol> handler) where TProtocol : Protocol, IRRPProtocol
		{
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC2")]
		[Address(RVA = "0x2648DF0", Offset = "0x26479F0", VA = "0x182648DF0", Slot = "4")]
		protected virtual void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC3")]
		[Address(RVA = "0x2649B00", Offset = "0x2648700", VA = "0x182649B00", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC4")]
		[Address(RVA = "0x2649AA0", Offset = "0x26486A0", VA = "0x182649AA0", Slot = "6")]
		protected virtual void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC5")]
		[Address(RVA = "0x2648D90", Offset = "0x2647990", VA = "0x182648D90", Slot = "7")]
		protected virtual void OnHandleFailedParseMsg(NetMsgID msgId)
		{
		}

		// Token: 0x040078B4 RID: 30900
		[Token(Token = "0x40078B4")]
		[FieldOffset(Offset = "0x10")]
		private SocketNet m_net;

		// Token: 0x040078B5 RID: 30901
		[Token(Token = "0x40078B5")]
		[FieldOffset(Offset = "0x18")]
		private string m_ip;

		// Token: 0x040078B6 RID: 30902
		[Token(Token = "0x40078B6")]
		[FieldOffset(Offset = "0x20")]
		private int m_port;

		// Token: 0x040078B7 RID: 30903
		[Token(Token = "0x40078B7")]
		[FieldOffset(Offset = "0x28")]
		private long m_svrTimeBias;

		// Token: 0x040078B8 RID: 30904
		[Token(Token = "0x40078B8")]
		[FieldOffset(Offset = "0x30")]
		private readonly INetProtocolSuite m_protocolSuit;

		// Token: 0x040078B9 RID: 30905
		[Token(Token = "0x40078B9")]
		[FieldOffset(Offset = "0x38")]
		private readonly ServerMsgProcessor m_processor;

		// Token: 0x040078BA RID: 30906
		[Token(Token = "0x40078BA")]
		[FieldOffset(Offset = "0x40")]
		private RRPairMsgProcessor m_rrpProcessor;

		// Token: 0x040078BB RID: 30907
		[Token(Token = "0x40078BB")]
		[FieldOffset(Offset = "0x48")]
		private ServerConfig m_config;

		// Token: 0x040078BC RID: 30908
		[Token(Token = "0x40078BC")]
		[FieldOffset(Offset = "0x60")]
		private float m_nextTryConnTime;

		// Token: 0x040078BD RID: 30909
		[Token(Token = "0x40078BD")]
		[FieldOffset(Offset = "0x64")]
		private float m_retryEndTime;

		// Token: 0x040078BE RID: 30910
		[Token(Token = "0x40078BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x040078BF RID: 30911
		[Token(Token = "0x40078BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_config;

		// Token: 0x040078C0 RID: 30912
		[Token(Token = "0x40078C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x040078C1 RID: 30913
		[Token(Token = "0x40078C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxRetryTime;

		// Token: 0x040078C2 RID: 30914
		[Token(Token = "0x40078C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_maxRetryTime;

		// Token: 0x040078C3 RID: 30915
		[Token(Token = "0x40078C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_logRule;

		// Token: 0x040078C4 RID: 30916
		[Token(Token = "0x40078C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040078C5 RID: 30917
		[Token(Token = "0x40078C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x040078C6 RID: 30918
		[Token(Token = "0x40078C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SyncTime;

		// Token: 0x040078C7 RID: 30919
		[Token(Token = "0x40078C7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NetStateChanged;

		// Token: 0x040078C8 RID: 30920
		[Token(Token = "0x40078C8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040078C9 RID: 30921
		[Token(Token = "0x40078C9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleReconnection;

		// Token: 0x040078CA RID: 30922
		[Token(Token = "0x40078CA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SendMsg;

		// Token: 0x040078CB RID: 30923
		[Token(Token = "0x40078CB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1_SendMsg;

		// Token: 0x040078CC RID: 30924
		[Token(Token = "0x40078CC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix2_SendMsg;

		// Token: 0x040078CD RID: 30925
		[Token(Token = "0x40078CD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetRRPMsgProcessor;

		// Token: 0x040078CE RID: 30926
		[Token(Token = "0x40078CE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SerializeToMsg;

		// Token: 0x040078CF RID: 30927
		[Token(Token = "0x40078CF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SendToSelf;

		// Token: 0x040078D0 RID: 30928
		[Token(Token = "0x40078D0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_connected;

		// Token: 0x040078D1 RID: 30929
		[Token(Token = "0x40078D1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_alive;

		// Token: 0x040078D2 RID: 30930
		[Token(Token = "0x40078D2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ConnectTo;

		// Token: 0x040078D3 RID: 30931
		[Token(Token = "0x40078D3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1_ConnectTo;

		// Token: 0x040078D4 RID: 30932
		[Token(Token = "0x40078D4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CompleteConnectProc;

		// Token: 0x040078D5 RID: 30933
		[Token(Token = "0x40078D5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Disconnect;

		// Token: 0x040078D6 RID: 30934
		[Token(Token = "0x40078D6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Disconnect;

		// Token: 0x040078D7 RID: 30935
		[Token(Token = "0x40078D7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandleFailedParseMsg;

		// Token: 0x040078D8 RID: 30936
		[Token(Token = "0x40078D8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckNetReachable;

		// Token: 0x040078D9 RID: 30937
		[Token(Token = "0x40078D9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SetupReconnection;

		// Token: 0x040078DA RID: 30938
		[Token(Token = "0x40078DA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterMsgHandler;

		// Token: 0x040078DB RID: 30939
		[Token(Token = "0x40078DB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_RegisterMsgHandler;

		// Token: 0x040078DC RID: 30940
		[Token(Token = "0x40078DC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x040078DD RID: 30941
		[Token(Token = "0x40078DD")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040078DE RID: 30942
		[Token(Token = "0x40078DE")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x040078DF RID: 30943
		[Token(Token = "0x40078DF")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnHandleFailedParseMsg;

		// Token: 0x020014C9 RID: 5321
		[Token(Token = "0x20014C9")]
		public enum NetLostType
		{
			// Token: 0x040078E1 RID: 30945
			[Token(Token = "0x40078E1")]
			NORMAL,
			// Token: 0x040078E2 RID: 30946
			[Token(Token = "0x40078E2")]
			TIME_OUT
		}
	}
}
