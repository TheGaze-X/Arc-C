using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.ServerBase;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200646F RID: 25711
	[Token(Token = "0x200646F")]
	public class AutoChessTeamServer : ServerWithinJoin
	{
		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x06024F58 RID: 151384 RVA: 0x000C5DA8 File Offset: 0x000C3FA8
		// (set) Token: 0x06024F59 RID: 151385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005728")]
		public bool isSilent
		{
			[Token(Token = "0x6024F58")]
			[Address(RVA = "0x1FD9120", Offset = "0x1FD7D20", VA = "0x181FD9120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024F59")]
			[Address(RVA = "0x1FD91E0", Offset = "0x1FD7DE0", VA = "0x181FD91E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x06024F5A RID: 151386 RVA: 0x000C5DC0 File Offset: 0x000C3FC0
		// (set) Token: 0x06024F5B RID: 151387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005729")]
		public AutoChessTeamLostReason lostReason
		{
			[Token(Token = "0x6024F5A")]
			[Address(RVA = "0x1FD9180", Offset = "0x1FD7D80", VA = "0x181FD9180")]
			[CompilerGenerated]
			get
			{
				return AutoChessTeamLostReason.NET_EXCEPTION;
			}
			[Token(Token = "0x6024F5B")]
			[Address(RVA = "0x1FD9250", Offset = "0x1FD7E50", VA = "0x181FD9250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024F5C RID: 151388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F5C")]
		[Address(RVA = "0x1FD8C80", Offset = "0x1FD7880", VA = "0x181FD8C80")]
		public AutoChessTeamServer(IAutoChessServerClient client)
		{
		}

		// Token: 0x06024F5D RID: 151389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F5D")]
		[Address(RVA = "0x1FD7130", Offset = "0x1FD5D30", VA = "0x181FD7130", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x06024F5E RID: 151390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F5E")]
		[Address(RVA = "0x1FD73E0", Offset = "0x1FD5FE0", VA = "0x181FD73E0")]
		public void Start(CommonJoinEntry entry)
		{
		}

		// Token: 0x06024F5F RID: 151391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F5F")]
		[Address(RVA = "0x1FD74E0", Offset = "0x1FD60E0", VA = "0x181FD74E0")]
		public void Stop()
		{
		}

		// Token: 0x06024F60 RID: 151392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F60")]
		[Address(RVA = "0x1FD7360", Offset = "0x1FD5F60", VA = "0x181FD7360")]
		public void SetSilence(bool v)
		{
		}

		// Token: 0x06024F61 RID: 151393 RVA: 0x000C5DD8 File Offset: 0x000C3FD8
		[Token(Token = "0x6024F61")]
		[Address(RVA = "0x1FD8640", Offset = "0x1FD7240", VA = "0x181FD8640")]
		private bool _LeaveResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F62 RID: 151394 RVA: 0x000C5DF0 File Offset: 0x000C3FF0
		[Token(Token = "0x6024F62")]
		[Address(RVA = "0x1FD87B0", Offset = "0x1FD73B0", VA = "0x181FD87B0")]
		private bool _UpdateTeamStatus(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F63 RID: 151395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F63")]
		[Address(RVA = "0x1FD7540", Offset = "0x1FD6140", VA = "0x181FD7540")]
		private void _EnterBattle(STSceneInfo scene)
		{
		}

		// Token: 0x06024F64 RID: 151396 RVA: 0x000C5E08 File Offset: 0x000C4008
		[Token(Token = "0x6024F64")]
		[Address(RVA = "0x1FD7FC0", Offset = "0x1FD6BC0", VA = "0x181FD7FC0")]
		private bool _HandlePlayerStateChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F65 RID: 151397 RVA: 0x000C5E20 File Offset: 0x000C4020
		[Token(Token = "0x6024F65")]
		[Address(RVA = "0x1FD84A0", Offset = "0x1FD70A0", VA = "0x181FD84A0")]
		private bool _HandleTeamChangeMode(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F66 RID: 151398 RVA: 0x000C5E38 File Offset: 0x000C4038
		[Token(Token = "0x6024F66")]
		[Address(RVA = "0x1FD8310", Offset = "0x1FD6F10", VA = "0x181FD8310")]
		private bool _HandleTeamChangeMatchOption(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F67 RID: 151399 RVA: 0x000C5E50 File Offset: 0x000C4050
		[Token(Token = "0x6024F67")]
		[Address(RVA = "0x1FD8170", Offset = "0x1FD6D70", VA = "0x181FD8170")]
		private bool _HandleTeamChangeMatchFlag(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F68 RID: 151400 RVA: 0x000C5E68 File Offset: 0x000C4068
		[Token(Token = "0x6024F68")]
		[Address(RVA = "0x1FD7E10", Offset = "0x1FD6A10", VA = "0x181FD7E10")]
		private bool _HandlePlayerChooseStrategy(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F69 RID: 151401 RVA: 0x000C5E80 File Offset: 0x000C4080
		[Token(Token = "0x6024F69")]
		[Address(RVA = "0x1FD7C00", Offset = "0x1FD6800", VA = "0x181FD7C00")]
		private bool _HandleMatchResult(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F6A RID: 151402 RVA: 0x000C5E98 File Offset: 0x000C4098
		[Token(Token = "0x6024F6A")]
		[Address(RVA = "0x1FD78E0", Offset = "0x1FD64E0", VA = "0x181FD78E0")]
		private bool _HandleChatRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F6B RID: 151403 RVA: 0x000C5EB0 File Offset: 0x000C40B0
		[Token(Token = "0x6024F6B")]
		[Address(RVA = "0x1FD7AC0", Offset = "0x1FD66C0", VA = "0x181FD7AC0")]
		private bool _HandleKickRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06024F6C RID: 151404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F6C")]
		[Address(RVA = "0x1FD7A60", Offset = "0x1FD6660", VA = "0x181FD7A60")]
		private void _HandleGetNameCard(AutoChessTeamProtocol.GetNameCardDn protocol)
		{
		}

		// Token: 0x06024F6D RID: 151405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F6D")]
		[Address(RVA = "0x1FD7740", Offset = "0x1FD6340", VA = "0x181FD7740")]
		private MsgAutoChessPlayerStatus _GetPlayerStatus(AutoChessServiceTeamInfo teamInfo, string uid)
		{
			return null;
		}

		// Token: 0x06024F6E RID: 151406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F6E")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x04033B84 RID: 211844
		[Token(Token = "0x4033B84")]
		[FieldOffset(Offset = "0x90")]
		private IAutoChessServerClient m_client;

		// Token: 0x04033B87 RID: 211847
		[Token(Token = "0x4033B87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSilent;

		// Token: 0x04033B88 RID: 211848
		[Token(Token = "0x4033B88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isSilent;

		// Token: 0x04033B89 RID: 211849
		[Token(Token = "0x4033B89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lostReason;

		// Token: 0x04033B8A RID: 211850
		[Token(Token = "0x4033B8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_lostReason;

		// Token: 0x04033B8B RID: 211851
		[Token(Token = "0x4033B8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04033B8C RID: 211852
		[Token(Token = "0x4033B8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04033B8D RID: 211853
		[Token(Token = "0x4033B8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04033B8E RID: 211854
		[Token(Token = "0x4033B8E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04033B8F RID: 211855
		[Token(Token = "0x4033B8F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSilence;

		// Token: 0x04033B90 RID: 211856
		[Token(Token = "0x4033B90")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LeaveResult;

		// Token: 0x04033B91 RID: 211857
		[Token(Token = "0x4033B91")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTeamStatus;

		// Token: 0x04033B92 RID: 211858
		[Token(Token = "0x4033B92")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnterBattle;

		// Token: 0x04033B93 RID: 211859
		[Token(Token = "0x4033B93")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandlePlayerStateChanged;

		// Token: 0x04033B94 RID: 211860
		[Token(Token = "0x4033B94")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleTeamChangeMode;

		// Token: 0x04033B95 RID: 211861
		[Token(Token = "0x4033B95")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleTeamChangeMatchOption;

		// Token: 0x04033B96 RID: 211862
		[Token(Token = "0x4033B96")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleTeamChangeMatchFlag;

		// Token: 0x04033B97 RID: 211863
		[Token(Token = "0x4033B97")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandlePlayerChooseStrategy;

		// Token: 0x04033B98 RID: 211864
		[Token(Token = "0x4033B98")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleMatchResult;

		// Token: 0x04033B99 RID: 211865
		[Token(Token = "0x4033B99")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleChatRet;

		// Token: 0x04033B9A RID: 211866
		[Token(Token = "0x4033B9A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleKickRet;

		// Token: 0x04033B9B RID: 211867
		[Token(Token = "0x4033B9B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleGetNameCard;

		// Token: 0x04033B9C RID: 211868
		[Token(Token = "0x4033B9C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetPlayerStatus;
	}
}
