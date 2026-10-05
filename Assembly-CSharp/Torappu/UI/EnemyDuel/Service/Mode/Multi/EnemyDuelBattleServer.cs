using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.Connections;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050A2 RID: 20642
	[Token(Token = "0x20050A2")]
	public class EnemyDuelBattleServer : Server
	{
		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x0601E907 RID: 125191 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E908 RID: 125192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004766")]
		public EnemyDuelServiceBattleInfo battleInfo
		{
			[Token(Token = "0x601E907")]
			[Address(RVA = "0x183EF50", Offset = "0x183DB50", VA = "0x18183EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E908")]
			[Address(RVA = "0x183EFB0", Offset = "0x183DBB0", VA = "0x18183EFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E909 RID: 125193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E909")]
		[Address(RVA = "0x183EAA0", Offset = "0x183D6A0", VA = "0x18183EAA0")]
		public EnemyDuelBattleServer(IEnemyDuelServerClient client)
		{
		}

		// Token: 0x0601E90A RID: 125194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90A")]
		[Address(RVA = "0x183D500", Offset = "0x183C100", VA = "0x18183D500", Slot = "4")]
		protected override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x0601E90B RID: 125195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90B")]
		[Address(RVA = "0x183D2C0", Offset = "0x183BEC0", VA = "0x18183D2C0", Slot = "6")]
		protected override void OnConnectionLost(Server.NetLostType type)
		{
		}

		// Token: 0x0601E90C RID: 125196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90C")]
		[Address(RVA = "0x183D6A0", Offset = "0x183C2A0", VA = "0x18183D6A0")]
		public void Start(BattleJoinEntry entry)
		{
		}

		// Token: 0x0601E90D RID: 125197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90D")]
		[Address(RVA = "0x183D810", Offset = "0x183C410", VA = "0x18183D810")]
		public void Stop()
		{
		}

		// Token: 0x0601E90E RID: 125198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90E")]
		[Address(RVA = "0x183D080", Offset = "0x183BC80", VA = "0x18183D080")]
		public void NotifySceneAlready()
		{
		}

		// Token: 0x0601E90F RID: 125199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E90F")]
		[Address(RVA = "0x183D890", Offset = "0x183C490", VA = "0x18183D890")]
		private void _DoJoin()
		{
		}

		// Token: 0x0601E910 RID: 125200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E910")]
		[Address(RVA = "0x183EA00", Offset = "0x183D600", VA = "0x18183EA00")]
		private void _SetException(EnemyDuelServiceBattleException excpt, int excptParam)
		{
		}

		// Token: 0x0601E911 RID: 125201 RVA: 0x000AEE70 File Offset: 0x000AD070
		[Token(Token = "0x601E911")]
		[Address(RVA = "0x183E230", Offset = "0x183CE30", VA = "0x18183E230")]
		private bool _HandleJoinRet(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E912 RID: 125202 RVA: 0x000AEE88 File Offset: 0x000AD088
		[Token(Token = "0x601E912")]
		[Address(RVA = "0x183E760", Offset = "0x183D360", VA = "0x18183E760")]
		private bool _HandleRevStep(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E913 RID: 125203 RVA: 0x000AEEA0 File Offset: 0x000AD0A0
		[Token(Token = "0x601E913")]
		[Address(RVA = "0x183E590", Offset = "0x183D190", VA = "0x18183E590")]
		private bool _HandleRevHistoryStep(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E914 RID: 125204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E914")]
		[Address(RVA = "0x183D9D0", Offset = "0x183C5D0", VA = "0x18183D9D0")]
		private void _DoRev(EnemyDuelServiceStepData step)
		{
		}

		// Token: 0x0601E915 RID: 125205 RVA: 0x000AEEB8 File Offset: 0x000AD0B8
		[Token(Token = "0x601E915")]
		[Address(RVA = "0x183DC40", Offset = "0x183C840", VA = "0x18183DC40")]
		private bool _HandleBattleStatusChanged(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E916 RID: 125206 RVA: 0x000AEED0 File Offset: 0x000AD0D0
		[Token(Token = "0x601E916")]
		[Address(RVA = "0x183E990", Offset = "0x183D590", VA = "0x18183E990")]
		private bool _HandlerRoundSettle(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E917 RID: 125207 RVA: 0x000AEEE8 File Offset: 0x000AD0E8
		[Token(Token = "0x601E917")]
		[Address(RVA = "0x183E1C0", Offset = "0x183CDC0", VA = "0x18183E1C0")]
		private bool _HandleFinalSettle(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E918 RID: 125208 RVA: 0x000AEF00 File Offset: 0x000AD100
		[Token(Token = "0x601E918")]
		[Address(RVA = "0x183DFA0", Offset = "0x183CBA0", VA = "0x18183DFA0")]
		private bool _HandleEmojiRev(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E919 RID: 125209 RVA: 0x000AEF18 File Offset: 0x000AD118
		[Token(Token = "0x601E919")]
		[Address(RVA = "0x183DF30", Offset = "0x183CB30", VA = "0x18183DF30")]
		private bool _HandleCheckSumRev(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E91A RID: 125210 RVA: 0x000AEF30 File Offset: 0x000AD130
		[Token(Token = "0x601E91A")]
		[Address(RVA = "0x183E840", Offset = "0x183D440", VA = "0x18183E840")]
		private bool _HandleSceneEnd(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E91B RID: 125211 RVA: 0x000AEF48 File Offset: 0x000AD148
		[Token(Token = "0x601E91B")]
		[Address(RVA = "0x183E480", Offset = "0x183D080", VA = "0x18183E480")]
		private bool _HandleQuitGame(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x0601E91C RID: 125212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E91C")]
		[Address(RVA = "0x183D880", Offset = "0x183C480", VA = "0x18183D880")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x0601E91D RID: 125213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E91D")]
		[Address(RVA = "0x183D870", Offset = "0x183C470", VA = "0x18183D870")]
		private void <>xLuaBaseProxy_OnConnectionLost(Server.NetLostType P0)
		{
		}

		// Token: 0x04028F2E RID: 167726
		[Token(Token = "0x4028F2E")]
		[FieldOffset(Offset = "0x68")]
		private IEnemyDuelServerClient m_client;

		// Token: 0x04028F2F RID: 167727
		[Token(Token = "0x4028F2F")]
		[FieldOffset(Offset = "0x70")]
		private BattleJoinEntry m_entry;

		// Token: 0x04028F30 RID: 167728
		[Token(Token = "0x4028F30")]
		[FieldOffset(Offset = "0x88")]
		private bool m_sceneAlready;

		// Token: 0x04028F31 RID: 167729
		[Token(Token = "0x4028F31")]
		[FieldOffset(Offset = "0x89")]
		private bool m_firstAfterJoin;

		// Token: 0x04028F32 RID: 167730
		[Token(Token = "0x4028F32")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_receivedStep;

		// Token: 0x04028F33 RID: 167731
		[Token(Token = "0x4028F33")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelServiceBattleEndInfo m_endInfo;

		// Token: 0x04028F35 RID: 167733
		[Token(Token = "0x4028F35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04028F36 RID: 167734
		[Token(Token = "0x4028F36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x04028F37 RID: 167735
		[Token(Token = "0x4028F37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04028F38 RID: 167736
		[Token(Token = "0x4028F38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04028F39 RID: 167737
		[Token(Token = "0x4028F39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConnectionLost;

		// Token: 0x04028F3A RID: 167738
		[Token(Token = "0x4028F3A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04028F3B RID: 167739
		[Token(Token = "0x4028F3B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04028F3C RID: 167740
		[Token(Token = "0x4028F3C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifySceneAlready;

		// Token: 0x04028F3D RID: 167741
		[Token(Token = "0x4028F3D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoJoin;

		// Token: 0x04028F3E RID: 167742
		[Token(Token = "0x4028F3E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetException;

		// Token: 0x04028F3F RID: 167743
		[Token(Token = "0x4028F3F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleJoinRet;

		// Token: 0x04028F40 RID: 167744
		[Token(Token = "0x4028F40")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleRevStep;

		// Token: 0x04028F41 RID: 167745
		[Token(Token = "0x4028F41")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleRevHistoryStep;

		// Token: 0x04028F42 RID: 167746
		[Token(Token = "0x4028F42")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoRev;

		// Token: 0x04028F43 RID: 167747
		[Token(Token = "0x4028F43")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleBattleStatusChanged;

		// Token: 0x04028F44 RID: 167748
		[Token(Token = "0x4028F44")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandlerRoundSettle;

		// Token: 0x04028F45 RID: 167749
		[Token(Token = "0x4028F45")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleFinalSettle;

		// Token: 0x04028F46 RID: 167750
		[Token(Token = "0x4028F46")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleEmojiRev;

		// Token: 0x04028F47 RID: 167751
		[Token(Token = "0x4028F47")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleCheckSumRev;

		// Token: 0x04028F48 RID: 167752
		[Token(Token = "0x4028F48")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleSceneEnd;

		// Token: 0x04028F49 RID: 167753
		[Token(Token = "0x4028F49")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleQuitGame;
	}
}
