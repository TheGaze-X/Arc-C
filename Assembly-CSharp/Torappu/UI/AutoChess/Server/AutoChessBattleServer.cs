using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.ServerBase;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200646B RID: 25707
	[Token(Token = "0x200646B")]
	public class AutoChessBattleServer : ServerWithinJoin
	{
		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x06024F33 RID: 151347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024F34 RID: 151348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005725")]
		public AutoChessServiceBattleInfo battleInfo
		{
			[Token(Token = "0x6024F33")]
			[Address(RVA = "0x1FC83F0", Offset = "0x1FC6FF0", VA = "0x181FC83F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024F34")]
			[Address(RVA = "0x1FC8450", Offset = "0x1FC7050", VA = "0x181FC8450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024F35 RID: 151349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F35")]
		[Address(RVA = "0x1FC7D70", Offset = "0x1FC6970", VA = "0x181FC7D70")]
		public AutoChessBattleServer(IAutoChessServerClient client)
		{
		}

		// Token: 0x06024F36 RID: 151350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F36")]
		[Address(RVA = "0x1FC5FC0", Offset = "0x1FC4BC0", VA = "0x181FC5FC0")]
		public void Start(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024F37 RID: 151351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F37")]
		[Address(RVA = "0x1FC5F20", Offset = "0x1FC4B20", VA = "0x181FC5F20", Slot = "8")]
		public override void OnJoinResult(CommonProtocolRetCode retCode, string reason)
		{
		}

		// Token: 0x06024F38 RID: 151352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F38")]
		[Address(RVA = "0x1FC5D40", Offset = "0x1FC4940", VA = "0x181FC5D40", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x06024F39 RID: 151353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F39")]
		[Address(RVA = "0x1FC6100", Offset = "0x1FC4D00", VA = "0x181FC6100")]
		public void Stop()
		{
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F3A")]
		[Address(RVA = "0x1FC7B20", Offset = "0x1FC6720", VA = "0x181FC7B20")]
		private void _SetException(AutoChessBattleServer.AutoChessBattleException excpt, int excptParam = 0)
		{
		}

		// Token: 0x06024F3B RID: 151355 RVA: 0x000C5C70 File Offset: 0x000C3E70
		[Token(Token = "0x6024F3B")]
		[Address(RVA = "0x1FC6300", Offset = "0x1FC4F00", VA = "0x181FC6300")]
		private bool _HandleAllStateSync(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F3C RID: 151356 RVA: 0x000C5C88 File Offset: 0x000C3E88
		[Token(Token = "0x6024F3C")]
		[Address(RVA = "0x1FC78B0", Offset = "0x1FC64B0", VA = "0x181FC78B0")]
		private bool _HandleStateChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F3D RID: 151357 RVA: 0x000C5CA0 File Offset: 0x000C3EA0
		[Token(Token = "0x6024F3D")]
		[Address(RVA = "0x1FC6E90", Offset = "0x1FC5A90", VA = "0x181FC6E90")]
		private bool _HandlePrepStatusChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F3E RID: 151358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F3E")]
		[Address(RVA = "0x1FC7010", Offset = "0x1FC5C10", VA = "0x181FC7010")]
		private void _HandlePrepStatusResp(AutoChessBattleProtocol.AutoChessScenePreparationStatusResp protocol)
		{
		}

		// Token: 0x06024F3F RID: 151359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F3F")]
		[Address(RVA = "0x1FC66B0", Offset = "0x1FC52B0", VA = "0x181FC66B0")]
		private void _HandleDeadAutoObDn(AutoChessBattleProtocol.AutoChessBattleSceneDeadAutoObDn protocol)
		{
		}

		// Token: 0x06024F40 RID: 151360 RVA: 0x000C5CB8 File Offset: 0x000C3EB8
		[Token(Token = "0x6024F40")]
		[Address(RVA = "0x1FC6B90", Offset = "0x1FC5790", VA = "0x181FC6B90")]
		private bool _HandlePlayerStatusChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F41 RID: 151361 RVA: 0x000C5CD0 File Offset: 0x000C3ED0
		[Token(Token = "0x6024F41")]
		[Address(RVA = "0x1FC6D10", Offset = "0x1FC5910", VA = "0x181FC6D10")]
		private bool _HandlePositionChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F42 RID: 151362 RVA: 0x000C5CE8 File Offset: 0x000C3EE8
		[Token(Token = "0x6024F42")]
		[Address(RVA = "0x1FC7740", Offset = "0x1FC6340", VA = "0x181FC7740")]
		private bool _HandleSpPrepStatusChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F43 RID: 151363 RVA: 0x000C5D00 File Offset: 0x000C3F00
		[Token(Token = "0x6024F43")]
		[Address(RVA = "0x1FC7570", Offset = "0x1FC6170", VA = "0x181FC7570")]
		private bool _HandleShopFrozen(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F44 RID: 151364 RVA: 0x000C5D18 File Offset: 0x000C3F18
		[Token(Token = "0x6024F44")]
		[Address(RVA = "0x1FC6A40", Offset = "0x1FC5640", VA = "0x181FC6A40")]
		private bool _HandlePlayerKicked(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F45 RID: 151365 RVA: 0x000C5D30 File Offset: 0x000C3F30
		[Token(Token = "0x6024F45")]
		[Address(RVA = "0x1FC7450", Offset = "0x1FC6050", VA = "0x181FC7450")]
		private bool _HandleSceneSettleLike(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F46 RID: 151366 RVA: 0x000C5D48 File Offset: 0x000C3F48
		[Token(Token = "0x6024F46")]
		[Address(RVA = "0x1FC7360", Offset = "0x1FC5F60", VA = "0x181FC7360")]
		private bool _HandleRevStep(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F47 RID: 151367 RVA: 0x000C5D60 File Offset: 0x000C3F60
		[Token(Token = "0x6024F47")]
		[Address(RVA = "0x1FC6840", Offset = "0x1FC5440", VA = "0x181FC6840")]
		private bool _HandleHistory(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F48 RID: 151368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F48")]
		[Address(RVA = "0x1FC6170", Offset = "0x1FC4D70", VA = "0x181FC6170")]
		private void _DoRev(AutoChessBattleStepData step)
		{
		}

		// Token: 0x06024F49 RID: 151369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F49")]
		[Address(RVA = "0x1FC7BC0", Offset = "0x1FC67C0", VA = "0x181FC7BC0")]
		private void _TryToFramePatching()
		{
		}

		// Token: 0x06024F4A RID: 151370 RVA: 0x000C5D78 File Offset: 0x000C3F78
		[Token(Token = "0x6024F4A")]
		[Address(RVA = "0x1FC7240", Offset = "0x1FC5E40", VA = "0x181FC7240")]
		private bool _HandleRevChat(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F4B RID: 151371 RVA: 0x000C5D90 File Offset: 0x000C3F90
		[Token(Token = "0x6024F4B")]
		[Address(RVA = "0x1FC7120", Offset = "0x1FC5D20", VA = "0x181FC7120")]
		private bool _HandleRevBroadcast(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F4C RID: 151372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F4C")]
		[Address(RVA = "0x1FC6160", Offset = "0x1FC4D60", VA = "0x181FC6160")]
		private void <>xLuaBaseProxy_OnJoinResult(CommonProtocolRetCode P0, string P1)
		{
		}

		// Token: 0x06024F4D RID: 151373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F4D")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x04033B5E RID: 211806
		[Token(Token = "0x4033B5E")]
		[FieldOffset(Offset = "0x90")]
		private IAutoChessServerClient m_client;

		// Token: 0x04033B5F RID: 211807
		[Token(Token = "0x4033B5F")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessBattleServer.AutoChessBattleEndInfo m_endInfo;

		// Token: 0x04033B60 RID: 211808
		[Token(Token = "0x4033B60")]
		[FieldOffset(Offset = "0xA0")]
		private CommonJoinEntry m_entry;

		// Token: 0x04033B61 RID: 211809
		[Token(Token = "0x4033B61")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_receivedStep;

		// Token: 0x04033B63 RID: 211811
		[Token(Token = "0x4033B63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04033B64 RID: 211812
		[Token(Token = "0x4033B64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x04033B65 RID: 211813
		[Token(Token = "0x4033B65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04033B66 RID: 211814
		[Token(Token = "0x4033B66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04033B67 RID: 211815
		[Token(Token = "0x4033B67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnJoinResult;

		// Token: 0x04033B68 RID: 211816
		[Token(Token = "0x4033B68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04033B69 RID: 211817
		[Token(Token = "0x4033B69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04033B6A RID: 211818
		[Token(Token = "0x4033B6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetException;

		// Token: 0x04033B6B RID: 211819
		[Token(Token = "0x4033B6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleAllStateSync;

		// Token: 0x04033B6C RID: 211820
		[Token(Token = "0x4033B6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleStateChanged;

		// Token: 0x04033B6D RID: 211821
		[Token(Token = "0x4033B6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandlePrepStatusChanged;

		// Token: 0x04033B6E RID: 211822
		[Token(Token = "0x4033B6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandlePrepStatusResp;

		// Token: 0x04033B6F RID: 211823
		[Token(Token = "0x4033B6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleDeadAutoObDn;

		// Token: 0x04033B70 RID: 211824
		[Token(Token = "0x4033B70")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandlePlayerStatusChanged;

		// Token: 0x04033B71 RID: 211825
		[Token(Token = "0x4033B71")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandlePositionChanged;

		// Token: 0x04033B72 RID: 211826
		[Token(Token = "0x4033B72")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleSpPrepStatusChanged;

		// Token: 0x04033B73 RID: 211827
		[Token(Token = "0x4033B73")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleShopFrozen;

		// Token: 0x04033B74 RID: 211828
		[Token(Token = "0x4033B74")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandlePlayerKicked;

		// Token: 0x04033B75 RID: 211829
		[Token(Token = "0x4033B75")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleSceneSettleLike;

		// Token: 0x04033B76 RID: 211830
		[Token(Token = "0x4033B76")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleRevStep;

		// Token: 0x04033B77 RID: 211831
		[Token(Token = "0x4033B77")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleHistory;

		// Token: 0x04033B78 RID: 211832
		[Token(Token = "0x4033B78")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DoRev;

		// Token: 0x04033B79 RID: 211833
		[Token(Token = "0x4033B79")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryToFramePatching;

		// Token: 0x04033B7A RID: 211834
		[Token(Token = "0x4033B7A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__HandleRevChat;

		// Token: 0x04033B7B RID: 211835
		[Token(Token = "0x4033B7B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__HandleRevBroadcast;

		// Token: 0x0200646C RID: 25708
		[Token(Token = "0x200646C")]
		public enum AutoChessBattleException
		{
			// Token: 0x04033B7D RID: 211837
			[Token(Token = "0x4033B7D")]
			NONE,
			// Token: 0x04033B7E RID: 211838
			[Token(Token = "0x4033B7E")]
			JOIN_FAILED,
			// Token: 0x04033B7F RID: 211839
			[Token(Token = "0x4033B7F")]
			NET_FAILED,
			// Token: 0x04033B80 RID: 211840
			[Token(Token = "0x4033B80")]
			SERVER_KICK
		}

		// Token: 0x0200646D RID: 25709
		[Token(Token = "0x200646D")]
		public struct AutoChessBattleEndInfo
		{
			// Token: 0x04033B81 RID: 211841
			[Token(Token = "0x4033B81")]
			[FieldOffset(Offset = "0x0")]
			public static AutoChessBattleServer.AutoChessBattleEndInfo EMPTY;

			// Token: 0x04033B82 RID: 211842
			[Token(Token = "0x4033B82")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessBattleServer.AutoChessBattleException exception;

			// Token: 0x04033B83 RID: 211843
			[Token(Token = "0x4033B83")]
			[FieldOffset(Offset = "0x4")]
			public int param;
		}
	}
}
