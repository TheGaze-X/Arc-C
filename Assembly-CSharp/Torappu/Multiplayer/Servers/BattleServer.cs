using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.Connections;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x0200156B RID: 5483
	[Token(Token = "0x200156B")]
	public class BattleServer : Server
	{
		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EEE")]
		public string sceneId
		{
			[Token(Token = "0x6007D58")]
			[Address(RVA = "0x28400E0", Offset = "0x283ECE0", VA = "0x1828400E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06007D59 RID: 32089 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007D5A RID: 32090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EEF")]
		public BattleInfo battleInfo
		{
			[Token(Token = "0x6007D59")]
			[Address(RVA = "0x2840080", Offset = "0x283EC80", VA = "0x182840080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007D5A")]
			[Address(RVA = "0x2840140", Offset = "0x283ED40", VA = "0x182840140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5B")]
		[Address(RVA = "0x283FBD0", Offset = "0x283E7D0", VA = "0x18283FBD0")]
		public BattleServer(IBattleClient cliet)
		{
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5C")]
		[Address(RVA = "0x283DE30", Offset = "0x283CA30", VA = "0x18283DE30", Slot = "4")]
		protected override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5D")]
		[Address(RVA = "0x283D980", Offset = "0x283C580", VA = "0x18283D980", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5E")]
		[Address(RVA = "0x283E150", Offset = "0x283CD50", VA = "0x18283E150")]
		public void Start(BattleEntry entry)
		{
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5F")]
		[Address(RVA = "0x283D760", Offset = "0x283C360", VA = "0x18283D760")]
		public void Close()
		{
		}

		// Token: 0x06007D60 RID: 32096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D60")]
		[Address(RVA = "0x283D7C0", Offset = "0x283C3C0", VA = "0x18283D7C0")]
		public void NotifySceneAlready()
		{
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D61")]
		[Address(RVA = "0x283DEB0", Offset = "0x283CAB0", VA = "0x18283DEB0")]
		public void Settle(GameSettleParam info)
		{
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D62")]
		[Address(RVA = "0x283E2F0", Offset = "0x283CEF0", VA = "0x18283E2F0")]
		private void _DoJoin()
		{
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x00037800 File Offset: 0x00035A00
		[Token(Token = "0x6007D63")]
		[Address(RVA = "0x283E950", Offset = "0x283D550", VA = "0x18283E950")]
		private bool _HandleJoinRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x00037818 File Offset: 0x00035A18
		[Token(Token = "0x6007D64")]
		[Address(RVA = "0x283F830", Offset = "0x283E430", VA = "0x18283F830")]
		private bool _HandleRevStep(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00037830 File Offset: 0x00035A30
		[Token(Token = "0x6007D65")]
		[Address(RVA = "0x283F1F0", Offset = "0x283DDF0", VA = "0x18283F1F0")]
		private bool _HandleRevHistoryStep(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D66")]
		[Address(RVA = "0x283E4F0", Offset = "0x283D0F0", VA = "0x18283E4F0")]
		private void _DoRev(StepData step)
		{
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x00037848 File Offset: 0x00035A48
		[Token(Token = "0x6007D67")]
		[Address(RVA = "0x283E7D0", Offset = "0x283D3D0", VA = "0x18283E7D0")]
		private bool _HandleCheckRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x00037860 File Offset: 0x00035A60
		[Token(Token = "0x6007D68")]
		[Address(RVA = "0x283F600", Offset = "0x283E200", VA = "0x18283F600")]
		private bool _HandleRevPause(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x00037878 File Offset: 0x00035A78
		[Token(Token = "0x6007D69")]
		[Address(RVA = "0x283F3B0", Offset = "0x283DFB0", VA = "0x18283F3B0")]
		private bool _HandleRevMark(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x00037890 File Offset: 0x00035A90
		[Token(Token = "0x6007D6A")]
		[Address(RVA = "0x283ED80", Offset = "0x283D980", VA = "0x18283ED80")]
		private bool _HandlePlayerStatusChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x000378A8 File Offset: 0x00035AA8
		[Token(Token = "0x6007D6B")]
		[Address(RVA = "0x283E840", Offset = "0x283D440", VA = "0x18283E840")]
		internal bool _HandleGameSettle(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x000378C0 File Offset: 0x00035AC0
		[Token(Token = "0x6007D6C")]
		[Address(RVA = "0x283F910", Offset = "0x283E510", VA = "0x18283F910")]
		private bool _HandleSceneEnd(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x000378D8 File Offset: 0x00035AD8
		[Token(Token = "0x6007D6D")]
		[Address(RVA = "0x283F130", Offset = "0x283DD30", VA = "0x18283F130")]
		private bool _HandleQuitGame(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6E")]
		[Address(RVA = "0x283FA60", Offset = "0x283E660", VA = "0x18283FA60")]
		private void _SetLogUpload()
		{
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D6F")]
		[Address(RVA = "0x183D880", Offset = "0x183C480", VA = "0x18183D880")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D70")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x04007E1B RID: 32283
		[Token(Token = "0x4007E1B")]
		[FieldOffset(Offset = "0x68")]
		private IBattleClient m_client;

		// Token: 0x04007E1C RID: 32284
		[Token(Token = "0x4007E1C")]
		[FieldOffset(Offset = "0x70")]
		private BattleEntry m_entry;

		// Token: 0x04007E1D RID: 32285
		[Token(Token = "0x4007E1D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_already;

		// Token: 0x04007E1E RID: 32286
		[Token(Token = "0x4007E1E")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_receivedStep;

		// Token: 0x04007E1F RID: 32287
		[Token(Token = "0x4007E1F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_indetical;

		// Token: 0x04007E20 RID: 32288
		[Token(Token = "0x4007E20")]
		[FieldOffset(Offset = "0x98")]
		private GameSettleParam m_settleReq;

		// Token: 0x04007E22 RID: 32290
		[Token(Token = "0x4007E22")]
		[FieldOffset(Offset = "0xA8")]
		private BattleProtocol.GameSettleInfo m_settle;

		// Token: 0x04007E23 RID: 32291
		[Token(Token = "0x4007E23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sceneId;

		// Token: 0x04007E24 RID: 32292
		[Token(Token = "0x4007E24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04007E25 RID: 32293
		[Token(Token = "0x4007E25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x04007E26 RID: 32294
		[Token(Token = "0x4007E26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007E27 RID: 32295
		[Token(Token = "0x4007E27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04007E28 RID: 32296
		[Token(Token = "0x4007E28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04007E29 RID: 32297
		[Token(Token = "0x4007E29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04007E2A RID: 32298
		[Token(Token = "0x4007E2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x04007E2B RID: 32299
		[Token(Token = "0x4007E2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NotifySceneAlready;

		// Token: 0x04007E2C RID: 32300
		[Token(Token = "0x4007E2C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Settle;

		// Token: 0x04007E2D RID: 32301
		[Token(Token = "0x4007E2D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoJoin;

		// Token: 0x04007E2E RID: 32302
		[Token(Token = "0x4007E2E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleJoinRet;

		// Token: 0x04007E2F RID: 32303
		[Token(Token = "0x4007E2F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleRevStep;

		// Token: 0x04007E30 RID: 32304
		[Token(Token = "0x4007E30")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleRevHistoryStep;

		// Token: 0x04007E31 RID: 32305
		[Token(Token = "0x4007E31")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoRev;

		// Token: 0x04007E32 RID: 32306
		[Token(Token = "0x4007E32")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleCheckRet;

		// Token: 0x04007E33 RID: 32307
		[Token(Token = "0x4007E33")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleRevPause;

		// Token: 0x04007E34 RID: 32308
		[Token(Token = "0x4007E34")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleRevMark;

		// Token: 0x04007E35 RID: 32309
		[Token(Token = "0x4007E35")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandlePlayerStatusChanged;

		// Token: 0x04007E36 RID: 32310
		[Token(Token = "0x4007E36")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleGameSettle;

		// Token: 0x04007E37 RID: 32311
		[Token(Token = "0x4007E37")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleSceneEnd;

		// Token: 0x04007E38 RID: 32312
		[Token(Token = "0x4007E38")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleQuitGame;

		// Token: 0x04007E39 RID: 32313
		[Token(Token = "0x4007E39")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SetLogUpload;
	}
}
