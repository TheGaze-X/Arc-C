using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063E4 RID: 25572
	[Token(Token = "0x20063E4")]
	public abstract class AutoChessBattleProtocol
	{
		// Token: 0x06024E0D RID: 151053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E0D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AutoChessBattleProtocol()
		{
		}

		// Token: 0x020063E5 RID: 25573
		[Token(Token = "0x20063E5")]
		public class AutoChessBattleSceneAllStateSyncDn : Protocol
		{
			// Token: 0x06024E0E RID: 151054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E0E")]
			[Address(RVA = "0x1FB0E60", Offset = "0x1FAFA60", VA = "0x181FB0E60")]
			public AutoChessBattleSceneAllStateSyncDn()
			{
			}

			// Token: 0x06024E0F RID: 151055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E0F")]
			[Address(RVA = "0x1FB0D60", Offset = "0x1FAF960", VA = "0x181FB0D60", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E10 RID: 151056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E10")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x040338B6 RID: 211126
			[Token(Token = "0x40338B6")]
			public const int ID = 300;

			// Token: 0x040338B7 RID: 211127
			[Token(Token = "0x40338B7")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleAllStateSyncData allStateSyncData;

			// Token: 0x040338B8 RID: 211128
			[Token(Token = "0x40338B8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338B9 RID: 211129
			[Token(Token = "0x40338B9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063E6 RID: 25574
		[Token(Token = "0x20063E6")]
		public class AutoChessBattleSceneChangeStatusDn : Protocol
		{
			// Token: 0x06024E11 RID: 151057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E11")]
			[Address(RVA = "0x1FB1420", Offset = "0x1FB0020", VA = "0x181FB1420")]
			public AutoChessBattleSceneChangeStatusDn()
			{
			}

			// Token: 0x06024E12 RID: 151058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E12")]
			[Address(RVA = "0x1FB1380", Offset = "0x1FAFF80", VA = "0x181FB1380", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E13 RID: 151059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E13")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x040338BA RID: 211130
			[Token(Token = "0x40338BA")]
			public const int ID = 302;

			// Token: 0x040338BB RID: 211131
			[Token(Token = "0x40338BB")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleSceneStatus sceneStatus;

			// Token: 0x040338BC RID: 211132
			[Token(Token = "0x40338BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338BD RID: 211133
			[Token(Token = "0x40338BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063E7 RID: 25575
		[Token(Token = "0x20063E7")]
		public class AutoChessBattleSceneLoadingReadyUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E14 RID: 151060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E14")]
			[Address(RVA = "0x1FB2040", Offset = "0x1FB0C40", VA = "0x181FB2040")]
			public AutoChessBattleSceneLoadingReadyUp()
			{
			}

			// Token: 0x06024E15 RID: 151061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E15")]
			[Address(RVA = "0x1FB1FB0", Offset = "0x1FB0BB0", VA = "0x181FB1FB0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E16 RID: 151062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E16")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338BE RID: 211134
			[Token(Token = "0x40338BE")]
			public const int ID = 303;

			// Token: 0x040338BF RID: 211135
			[Token(Token = "0x40338BF")]
			[FieldOffset(Offset = "0x18")]
			public List<AutoChessBattleRoundEnemyInfo> roundEnemies;

			// Token: 0x040338C0 RID: 211136
			[Token(Token = "0x40338C0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338C1 RID: 211137
			[Token(Token = "0x40338C1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063E8 RID: 25576
		[Token(Token = "0x20063E8")]
		public class AutoChessBattleScenePreparationStatusDn : Protocol
		{
			// Token: 0x06024E17 RID: 151063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E17")]
			[Address(RVA = "0x1FB25D0", Offset = "0x1FB11D0", VA = "0x181FB25D0")]
			public AutoChessBattleScenePreparationStatusDn()
			{
			}

			// Token: 0x06024E18 RID: 151064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E18")]
			[Address(RVA = "0x1FB2530", Offset = "0x1FB1130", VA = "0x181FB2530", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E19 RID: 151065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E19")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x040338C2 RID: 211138
			[Token(Token = "0x40338C2")]
			public const int ID = 306;

			// Token: 0x040338C3 RID: 211139
			[Token(Token = "0x40338C3")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattlePreparationStatus preparationStatus;

			// Token: 0x040338C4 RID: 211140
			[Token(Token = "0x40338C4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338C5 RID: 211141
			[Token(Token = "0x40338C5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063E9 RID: 25577
		[Token(Token = "0x20063E9")]
		public class AutoChessBattleScenePreparationReadyUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E1A RID: 151066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1A")]
			[Address(RVA = "0x1FB24C0", Offset = "0x1FB10C0", VA = "0x181FB24C0")]
			public AutoChessBattleScenePreparationReadyUp()
			{
			}

			// Token: 0x06024E1B RID: 151067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1B")]
			[Address(RVA = "0x1FB2430", Offset = "0x1FB1030", VA = "0x181FB2430", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E1C RID: 151068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1C")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338C6 RID: 211142
			[Token(Token = "0x40338C6")]
			public const int ID = 307;

			// Token: 0x040338C7 RID: 211143
			[Token(Token = "0x40338C7")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattlePreparationReadyType readyType;

			// Token: 0x040338C8 RID: 211144
			[Token(Token = "0x40338C8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338C9 RID: 211145
			[Token(Token = "0x40338C9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063EA RID: 25578
		[Token(Token = "0x20063EA")]
		public class AutoChessBattleScenePlayerStatusDn : Protocol
		{
			// Token: 0x06024E1D RID: 151069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1D")]
			[Address(RVA = "0x1FB23C0", Offset = "0x1FB0FC0", VA = "0x181FB23C0")]
			public AutoChessBattleScenePlayerStatusDn()
			{
			}

			// Token: 0x06024E1E RID: 151070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1E")]
			[Address(RVA = "0x1FB2320", Offset = "0x1FB0F20", VA = "0x181FB2320", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E1F RID: 151071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E1F")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x040338CA RID: 211146
			[Token(Token = "0x40338CA")]
			public const int ID = 310;

			// Token: 0x040338CB RID: 211147
			[Token(Token = "0x40338CB")]
			[FieldOffset(Offset = "0x18")]
			public List<AutoChessBattlePlayerRuntimeInfo> playerStatus;

			// Token: 0x040338CC RID: 211148
			[Token(Token = "0x40338CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338CD RID: 211149
			[Token(Token = "0x40338CD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063EB RID: 25579
		[Token(Token = "0x20063EB")]
		public class AutoChessBattleSceneSelfBattleFinishUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E20 RID: 151072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E20")]
			[Address(RVA = "0x1FB2A70", Offset = "0x1FB1670", VA = "0x181FB2A70")]
			public AutoChessBattleSceneSelfBattleFinishUp()
			{
			}

			// Token: 0x06024E21 RID: 151073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E21")]
			[Address(RVA = "0x1FB2960", Offset = "0x1FB1560", VA = "0x181FB2960", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E22 RID: 151074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E22")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338CE RID: 211150
			[Token(Token = "0x40338CE")]
			public const int ID = 311;

			// Token: 0x040338CF RID: 211151
			[Token(Token = "0x40338CF")]
			[FieldOffset(Offset = "0x18")]
			public int round;

			// Token: 0x040338D0 RID: 211152
			[Token(Token = "0x40338D0")]
			[FieldOffset(Offset = "0x1C")]
			public bool fromRejoin;

			// Token: 0x040338D1 RID: 211153
			[Token(Token = "0x40338D1")]
			[FieldOffset(Offset = "0x20")]
			public List<int> escapedInstIds;

			// Token: 0x040338D2 RID: 211154
			[Token(Token = "0x40338D2")]
			[FieldOffset(Offset = "0x28")]
			public List<int> escapedTokenInstIds;

			// Token: 0x040338D3 RID: 211155
			[Token(Token = "0x40338D3")]
			[FieldOffset(Offset = "0x30")]
			public List<AutoChessBattleProtocol.AutoChessSelfBattleKillRecord> killedInsts;

			// Token: 0x040338D4 RID: 211156
			[Token(Token = "0x40338D4")]
			[FieldOffset(Offset = "0x38")]
			public List<AutoChessBattleCharBattleStatus> charBattleStatusList;

			// Token: 0x040338D5 RID: 211157
			[Token(Token = "0x40338D5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338D6 RID: 211158
			[Token(Token = "0x40338D6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063EC RID: 25580
		[Token(Token = "0x20063EC")]
		public class AutoChessBattleSceneHelpBattleFinishUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E23 RID: 151075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E23")]
			[Address(RVA = "0x1FB1B40", Offset = "0x1FB0740", VA = "0x181FB1B40")]
			public AutoChessBattleSceneHelpBattleFinishUp()
			{
			}

			// Token: 0x06024E24 RID: 151076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E24")]
			[Address(RVA = "0x1FB1A50", Offset = "0x1FB0650", VA = "0x181FB1A50", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E25 RID: 151077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E25")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338D7 RID: 211159
			[Token(Token = "0x40338D7")]
			public const int ID = 313;

			// Token: 0x040338D8 RID: 211160
			[Token(Token = "0x40338D8")]
			[FieldOffset(Offset = "0x18")]
			public int round;

			// Token: 0x040338D9 RID: 211161
			[Token(Token = "0x40338D9")]
			[FieldOffset(Offset = "0x1C")]
			public bool fromRejoin;

			// Token: 0x040338DA RID: 211162
			[Token(Token = "0x40338DA")]
			[FieldOffset(Offset = "0x20")]
			public List<AutoChessBattleEscapedEnemyInfo> escapedEnemies;

			// Token: 0x040338DB RID: 211163
			[Token(Token = "0x40338DB")]
			[FieldOffset(Offset = "0x28")]
			public List<AutoChessHelpBattleKillInfo> killInfos;

			// Token: 0x040338DC RID: 211164
			[Token(Token = "0x40338DC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338DD RID: 211165
			[Token(Token = "0x40338DD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063ED RID: 25581
		[Token(Token = "0x20063ED")]
		public class AutoChessBattleSceneShopRefreshUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E26 RID: 151078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E26")]
			[Address(RVA = "0x1FB33A0", Offset = "0x1FB1FA0", VA = "0x181FB33A0")]
			public AutoChessBattleSceneShopRefreshUp()
			{
			}

			// Token: 0x040338DE RID: 211166
			[Token(Token = "0x40338DE")]
			public const int ID = 315;

			// Token: 0x040338DF RID: 211167
			[Token(Token = "0x40338DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020063EE RID: 25582
		[Token(Token = "0x20063EE")]
		public class AutoChessBattleSceneShopBuyChessUp : AutoChessServiceBattleRequest, IRRPProtocol
		{
			// Token: 0x06024E27 RID: 151079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E27")]
			[Address(RVA = "0x1FB3110", Offset = "0x1FB1D10", VA = "0x181FB3110")]
			public AutoChessBattleSceneShopBuyChessUp()
			{
			}

			// Token: 0x06024E28 RID: 151080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E28")]
			[Address(RVA = "0x1FB3060", Offset = "0x1FB1C60", VA = "0x181FB3060", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E29 RID: 151081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E29")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338E0 RID: 211168
			[Token(Token = "0x40338E0")]
			public const int ID = 317;

			// Token: 0x040338E1 RID: 211169
			[Token(Token = "0x40338E1")]
			[FieldOffset(Offset = "0x18")]
			public int slotId;

			// Token: 0x040338E2 RID: 211170
			[Token(Token = "0x40338E2")]
			[FieldOffset(Offset = "0x1C")]
			public bool isSpecial;

			// Token: 0x040338E3 RID: 211171
			[Token(Token = "0x40338E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338E4 RID: 211172
			[Token(Token = "0x40338E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063EF RID: 25583
		[Token(Token = "0x20063EF")]
		public class AutoChessBattleSceneShopFrozeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E2A RID: 151082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2A")]
			[Address(RVA = "0x1FB3330", Offset = "0x1FB1F30", VA = "0x181FB3330")]
			public AutoChessBattleSceneShopFrozeUp()
			{
			}

			// Token: 0x06024E2B RID: 151083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2B")]
			[Address(RVA = "0x1FB32A0", Offset = "0x1FB1EA0", VA = "0x181FB32A0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E2C RID: 151084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2C")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338E5 RID: 211173
			[Token(Token = "0x40338E5")]
			public const int ID = 319;

			// Token: 0x040338E6 RID: 211174
			[Token(Token = "0x40338E6")]
			[FieldOffset(Offset = "0x18")]
			public bool isFrozen;

			// Token: 0x040338E7 RID: 211175
			[Token(Token = "0x40338E7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338E8 RID: 211176
			[Token(Token = "0x40338E8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F0 RID: 25584
		[Token(Token = "0x20063F0")]
		public class AutoChessBattleSceneShopFrozeDn : Protocol
		{
			// Token: 0x06024E2D RID: 151085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2D")]
			[Address(RVA = "0x1FB3230", Offset = "0x1FB1E30", VA = "0x181FB3230")]
			public AutoChessBattleSceneShopFrozeDn()
			{
			}

			// Token: 0x06024E2E RID: 151086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2E")]
			[Address(RVA = "0x1FB3180", Offset = "0x1FB1D80", VA = "0x181FB3180", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E2F RID: 151087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E2F")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x040338E9 RID: 211177
			[Token(Token = "0x40338E9")]
			public const int ID = 320;

			// Token: 0x040338EA RID: 211178
			[Token(Token = "0x40338EA")]
			[FieldOffset(Offset = "0x18")]
			public int uidIdx;

			// Token: 0x040338EB RID: 211179
			[Token(Token = "0x40338EB")]
			[FieldOffset(Offset = "0x1C")]
			public bool isFrozen;

			// Token: 0x040338EC RID: 211180
			[Token(Token = "0x40338EC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338ED RID: 211181
			[Token(Token = "0x40338ED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063F1 RID: 25585
		[Token(Token = "0x20063F1")]
		public class AutoChessBattleSceneShopUpgradeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E30 RID: 151088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E30")]
			[Address(RVA = "0x1FB3410", Offset = "0x1FB2010", VA = "0x181FB3410")]
			public AutoChessBattleSceneShopUpgradeUp()
			{
			}

			// Token: 0x040338EE RID: 211182
			[Token(Token = "0x40338EE")]
			public const int ID = 321;

			// Token: 0x040338EF RID: 211183
			[Token(Token = "0x40338EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020063F2 RID: 25586
		[Token(Token = "0x20063F2")]
		public class AutoChessBattleSceneUseEquipUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E31 RID: 151089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E31")]
			[Address(RVA = "0x1FB3C40", Offset = "0x1FB2840", VA = "0x181FB3C40")]
			public AutoChessBattleSceneUseEquipUp()
			{
			}

			// Token: 0x06024E32 RID: 151090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E32")]
			[Address(RVA = "0x1FB3B60", Offset = "0x1FB2760", VA = "0x181FB3B60", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E33 RID: 151091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E33")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338F0 RID: 211184
			[Token(Token = "0x40338F0")]
			public const int ID = 323;

			// Token: 0x040338F1 RID: 211185
			[Token(Token = "0x40338F1")]
			[FieldOffset(Offset = "0x18")]
			public int charChessInstId;

			// Token: 0x040338F2 RID: 211186
			[Token(Token = "0x40338F2")]
			[FieldOffset(Offset = "0x1C")]
			public int equipChessInstId;

			// Token: 0x040338F3 RID: 211187
			[Token(Token = "0x40338F3")]
			[FieldOffset(Offset = "0x20")]
			public bool isChangeEquip;

			// Token: 0x040338F4 RID: 211188
			[Token(Token = "0x40338F4")]
			[FieldOffset(Offset = "0x24")]
			public int unloadInstId;

			// Token: 0x040338F5 RID: 211189
			[Token(Token = "0x40338F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338F6 RID: 211190
			[Token(Token = "0x40338F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F3 RID: 25587
		[Token(Token = "0x20063F3")]
		public class AutoChessBattleSceneDestroyChessUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E34 RID: 151092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E34")]
			[Address(RVA = "0x1FB18C0", Offset = "0x1FB04C0", VA = "0x181FB18C0")]
			public AutoChessBattleSceneDestroyChessUp()
			{
			}

			// Token: 0x06024E35 RID: 151093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E35")]
			[Address(RVA = "0x1FB1800", Offset = "0x1FB0400", VA = "0x181FB1800", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E36 RID: 151094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E36")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338F7 RID: 211191
			[Token(Token = "0x40338F7")]
			public const int ID = 325;

			// Token: 0x040338F8 RID: 211192
			[Token(Token = "0x40338F8")]
			[FieldOffset(Offset = "0x18")]
			public int chessInstId;

			// Token: 0x040338F9 RID: 211193
			[Token(Token = "0x40338F9")]
			[FieldOffset(Offset = "0x1C")]
			public AutoChessItemType chessType;

			// Token: 0x040338FA RID: 211194
			[Token(Token = "0x40338FA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040338FB RID: 211195
			[Token(Token = "0x40338FB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F4 RID: 25588
		[Token(Token = "0x20063F4")]
		public class AutoChessBattleSceneChangePositionUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E37 RID: 151095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E37")]
			[Address(RVA = "0x1FB1310", Offset = "0x1FAFF10", VA = "0x181FB1310")]
			public AutoChessBattleSceneChangePositionUp()
			{
			}

			// Token: 0x06024E38 RID: 151096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E38")]
			[Address(RVA = "0x1FB1250", Offset = "0x1FAFE50", VA = "0x181FB1250", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E39 RID: 151097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E39")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040338FC RID: 211196
			[Token(Token = "0x40338FC")]
			public const int ID = 327;

			// Token: 0x040338FD RID: 211197
			[Token(Token = "0x40338FD")]
			[FieldOffset(Offset = "0x18")]
			public int deployCount;

			// Token: 0x040338FE RID: 211198
			[Token(Token = "0x40338FE")]
			[FieldOffset(Offset = "0x20")]
			public List<AutoChessBattleChessPosUnitInfo> unitPositionInfo;

			// Token: 0x040338FF RID: 211199
			[Token(Token = "0x40338FF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033900 RID: 211200
			[Token(Token = "0x4033900")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F5 RID: 25589
		[Token(Token = "0x20063F5")]
		public class AutoChessBattleSceneChangePositionDn : Protocol
		{
			// Token: 0x06024E3A RID: 151098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3A")]
			[Address(RVA = "0x1FB11E0", Offset = "0x1FAFDE0", VA = "0x181FB11E0")]
			public AutoChessBattleSceneChangePositionDn()
			{
			}

			// Token: 0x06024E3B RID: 151099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3B")]
			[Address(RVA = "0x1FB1140", Offset = "0x1FAFD40", VA = "0x181FB1140", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E3C RID: 151100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3C")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033901 RID: 211201
			[Token(Token = "0x4033901")]
			public const int ID = 328;

			// Token: 0x04033902 RID: 211202
			[Token(Token = "0x4033902")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleBoardStatus boardStatus;

			// Token: 0x04033903 RID: 211203
			[Token(Token = "0x4033903")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033904 RID: 211204
			[Token(Token = "0x4033904")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063F6 RID: 25590
		[Token(Token = "0x20063F6")]
		public class AutoChessBattleSceneSpPreparationPickUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E3D RID: 151101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3D")]
			[Address(RVA = "0x1FB3630", Offset = "0x1FB2230", VA = "0x181FB3630")]
			public AutoChessBattleSceneSpPreparationPickUp()
			{
			}

			// Token: 0x06024E3E RID: 151102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3E")]
			[Address(RVA = "0x1FB3590", Offset = "0x1FB2190", VA = "0x181FB3590", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E3F RID: 151103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E3F")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033905 RID: 211205
			[Token(Token = "0x4033905")]
			public const int ID = 331;

			// Token: 0x04033906 RID: 211206
			[Token(Token = "0x4033906")]
			[FieldOffset(Offset = "0x18")]
			public int slotId;

			// Token: 0x04033907 RID: 211207
			[Token(Token = "0x4033907")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033908 RID: 211208
			[Token(Token = "0x4033908")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F7 RID: 25591
		[Token(Token = "0x20063F7")]
		public class AutoChessBattleSceneSpPreparationPickDn : Protocol
		{
			// Token: 0x06024E40 RID: 151104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E40")]
			[Address(RVA = "0x1FB3520", Offset = "0x1FB2120", VA = "0x181FB3520")]
			public AutoChessBattleSceneSpPreparationPickDn()
			{
			}

			// Token: 0x06024E41 RID: 151105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E41")]
			[Address(RVA = "0x1FB3480", Offset = "0x1FB2080", VA = "0x181FB3480", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E42 RID: 151106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E42")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033909 RID: 211209
			[Token(Token = "0x4033909")]
			public const int ID = 332;

			// Token: 0x0403390A RID: 211210
			[Token(Token = "0x403390A")]
			[FieldOffset(Offset = "0x18")]
			public AutoAutoChessBattleSpPreparationUpdateInfo updateInfo;

			// Token: 0x0403390B RID: 211211
			[Token(Token = "0x403390B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403390C RID: 211212
			[Token(Token = "0x403390C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020063F8 RID: 25592
		[Token(Token = "0x20063F8")]
		public class AutoChessBattleSceneSelfChoicePickUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E43 RID: 151107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E43")]
			[Address(RVA = "0x1FB2DD0", Offset = "0x1FB19D0", VA = "0x181FB2DD0")]
			public AutoChessBattleSceneSelfChoicePickUp()
			{
			}

			// Token: 0x06024E44 RID: 151108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E44")]
			[Address(RVA = "0x1FB2D30", Offset = "0x1FB1930", VA = "0x181FB2D30", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E45 RID: 151109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E45")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x0403390D RID: 211213
			[Token(Token = "0x403390D")]
			public const int ID = 333;

			// Token: 0x0403390E RID: 211214
			[Token(Token = "0x403390E")]
			[FieldOffset(Offset = "0x18")]
			public int slotId;

			// Token: 0x0403390F RID: 211215
			[Token(Token = "0x403390F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033910 RID: 211216
			[Token(Token = "0x4033910")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063F9 RID: 25593
		[Token(Token = "0x20063F9")]
		public class AutoChessSelfBattleKillRecord : IStreamSerialize, IHotfixable
		{
			// Token: 0x06024E46 RID: 151110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E46")]
			[Address(RVA = "0x1FBD660", Offset = "0x1FBC260", VA = "0x181FBD660", Slot = "4")]
			public void Write(IStreamWriter to)
			{
			}

			// Token: 0x06024E47 RID: 151111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E47")]
			[Address(RVA = "0x1FBD730", Offset = "0x1FBC330", VA = "0x181FBD730")]
			public AutoChessSelfBattleKillRecord()
			{
			}

			// Token: 0x04033911 RID: 211217
			[Token(Token = "0x4033911")]
			[FieldOffset(Offset = "0x10")]
			public int enemyInstId;

			// Token: 0x04033912 RID: 211218
			[Token(Token = "0x4033912")]
			[FieldOffset(Offset = "0x14")]
			public int attackerInstId;

			// Token: 0x04033913 RID: 211219
			[Token(Token = "0x4033913")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleDamageSrcType damageSrc;

			// Token: 0x04033914 RID: 211220
			[Token(Token = "0x4033914")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Write;

			// Token: 0x04033915 RID: 211221
			[Token(Token = "0x4033915")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020063FA RID: 25594
		[Token(Token = "0x20063FA")]
		public class AutoChessBattleSceneSelfBattleKillEnemyUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E48 RID: 151112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E48")]
			[Address(RVA = "0x1FB2CC0", Offset = "0x1FB18C0", VA = "0x181FB2CC0")]
			public AutoChessBattleSceneSelfBattleKillEnemyUp()
			{
			}

			// Token: 0x06024E49 RID: 151113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E49")]
			[Address(RVA = "0x1FB2C30", Offset = "0x1FB1830", VA = "0x181FB2C30", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E4A RID: 151114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4A")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033916 RID: 211222
			[Token(Token = "0x4033916")]
			public const int ID = 335;

			// Token: 0x04033917 RID: 211223
			[Token(Token = "0x4033917")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleProtocol.AutoChessSelfBattleKillRecord record;

			// Token: 0x04033918 RID: 211224
			[Token(Token = "0x4033918")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033919 RID: 211225
			[Token(Token = "0x4033919")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063FB RID: 25595
		[Token(Token = "0x20063FB")]
		public class AutoChessBattleSceneHelpBattleKillEnemyUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E4B RID: 151115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4B")]
			[Address(RVA = "0x1FB1CC0", Offset = "0x1FB08C0", VA = "0x181FB1CC0")]
			public AutoChessBattleSceneHelpBattleKillEnemyUp()
			{
			}

			// Token: 0x06024E4C RID: 151116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4C")]
			[Address(RVA = "0x1FB1BB0", Offset = "0x1FB07B0", VA = "0x181FB1BB0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E4D RID: 151117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4D")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x0403391A RID: 211226
			[Token(Token = "0x403391A")]
			public const int ID = 367;

			// Token: 0x0403391B RID: 211227
			[Token(Token = "0x403391B")]
			[FieldOffset(Offset = "0x18")]
			public int enemyInstId;

			// Token: 0x0403391C RID: 211228
			[Token(Token = "0x403391C")]
			[FieldOffset(Offset = "0x1C")]
			public bool isToken;

			// Token: 0x0403391D RID: 211229
			[Token(Token = "0x403391D")]
			[FieldOffset(Offset = "0x20")]
			public int killedByPlayer;

			// Token: 0x0403391E RID: 211230
			[Token(Token = "0x403391E")]
			[FieldOffset(Offset = "0x24")]
			public int attackerInstId;

			// Token: 0x0403391F RID: 211231
			[Token(Token = "0x403391F")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessBattleDamageSrcType damageSrc;

			// Token: 0x04033920 RID: 211232
			[Token(Token = "0x4033920")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033921 RID: 211233
			[Token(Token = "0x4033921")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063FC RID: 25596
		[Token(Token = "0x20063FC")]
		public class AutoChessBattleSceneSelfBattleEnemyEscapeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E4E RID: 151118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4E")]
			[Address(RVA = "0x1FB28F0", Offset = "0x1FB14F0", VA = "0x181FB28F0")]
			public AutoChessBattleSceneSelfBattleEnemyEscapeUp()
			{
			}

			// Token: 0x06024E4F RID: 151119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E4F")]
			[Address(RVA = "0x1FB2840", Offset = "0x1FB1440", VA = "0x181FB2840", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E50 RID: 151120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E50")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033922 RID: 211234
			[Token(Token = "0x4033922")]
			public const int ID = 337;

			// Token: 0x04033923 RID: 211235
			[Token(Token = "0x4033923")]
			[FieldOffset(Offset = "0x18")]
			public int enemyInstId;

			// Token: 0x04033924 RID: 211236
			[Token(Token = "0x4033924")]
			[FieldOffset(Offset = "0x1C")]
			public bool isToken;

			// Token: 0x04033925 RID: 211237
			[Token(Token = "0x4033925")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033926 RID: 211238
			[Token(Token = "0x4033926")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063FD RID: 25597
		[Token(Token = "0x20063FD")]
		public class AutoChessBattleSceneSelfBattleInfoUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E51 RID: 151121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E51")]
			[Address(RVA = "0x1FB2BC0", Offset = "0x1FB17C0", VA = "0x181FB2BC0")]
			public AutoChessBattleSceneSelfBattleInfoUp()
			{
			}

			// Token: 0x06024E52 RID: 151122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E52")]
			[Address(RVA = "0x1FB2AE0", Offset = "0x1FB16E0", VA = "0x181FB2AE0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E53 RID: 151123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E53")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033927 RID: 211239
			[Token(Token = "0x4033927")]
			public const int ID = 371;

			// Token: 0x04033928 RID: 211240
			[Token(Token = "0x4033928")]
			[FieldOffset(Offset = "0x18")]
			public int round;

			// Token: 0x04033929 RID: 211241
			[Token(Token = "0x4033929")]
			[FieldOffset(Offset = "0x20")]
			public List<AutoChessBattleCharBattleStatus> charBattleStatusList;

			// Token: 0x0403392A RID: 211242
			[Token(Token = "0x403392A")]
			[FieldOffset(Offset = "0x28")]
			public List<AutoChessBattleProtocol.AutoChessBattleInfoCheckMeta> charBattleInfoList;

			// Token: 0x0403392B RID: 211243
			[Token(Token = "0x403392B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403392C RID: 211244
			[Token(Token = "0x403392C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020063FE RID: 25598
		[Token(Token = "0x20063FE")]
		public class AutoChessBattleInfoCheckMeta : IStreamSerialize, IHotfixable
		{
			// Token: 0x06024E54 RID: 151124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E54")]
			[Address(RVA = "0x1FAFD00", Offset = "0x1FAE900", VA = "0x181FAFD00", Slot = "4")]
			public void Write(IStreamWriter to)
			{
			}

			// Token: 0x06024E55 RID: 151125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E55")]
			[Address(RVA = "0x1FAFDD0", Offset = "0x1FAE9D0", VA = "0x181FAFDD0")]
			public AutoChessBattleInfoCheckMeta()
			{
			}

			// Token: 0x0403392D RID: 211245
			[Token(Token = "0x403392D")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x0403392E RID: 211246
			[Token(Token = "0x403392E")]
			[FieldOffset(Offset = "0x14")]
			public int atk;

			// Token: 0x0403392F RID: 211247
			[Token(Token = "0x403392F")]
			[FieldOffset(Offset = "0x18")]
			public int atkSpeed;

			// Token: 0x04033930 RID: 211248
			[Token(Token = "0x4033930")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Write;

			// Token: 0x04033931 RID: 211249
			[Token(Token = "0x4033931")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020063FF RID: 25599
		[Token(Token = "0x20063FF")]
		public class AutoChessBattleSceneHelpBattleEnemyEscapeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E56 RID: 151126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E56")]
			[Address(RVA = "0x1FB19E0", Offset = "0x1FB05E0", VA = "0x181FB19E0")]
			public AutoChessBattleSceneHelpBattleEnemyEscapeUp()
			{
			}

			// Token: 0x06024E57 RID: 151127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E57")]
			[Address(RVA = "0x1FB1930", Offset = "0x1FB0530", VA = "0x181FB1930", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E58 RID: 151128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E58")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033932 RID: 211250
			[Token(Token = "0x4033932")]
			public const int ID = 369;

			// Token: 0x04033933 RID: 211251
			[Token(Token = "0x4033933")]
			[FieldOffset(Offset = "0x18")]
			public int enemyInstId;

			// Token: 0x04033934 RID: 211252
			[Token(Token = "0x4033934")]
			[FieldOffset(Offset = "0x1C")]
			public bool isToken;

			// Token: 0x04033935 RID: 211253
			[Token(Token = "0x4033935")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033936 RID: 211254
			[Token(Token = "0x4033936")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006400 RID: 25600
		[Token(Token = "0x2006400")]
		public class AutoChessBattleSceneSelfBattleAddBondUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E59 RID: 151129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E59")]
			[Address(RVA = "0x1FB27D0", Offset = "0x1FB13D0", VA = "0x181FB27D0")]
			public AutoChessBattleSceneSelfBattleAddBondUp()
			{
			}

			// Token: 0x06024E5A RID: 151130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5A")]
			[Address(RVA = "0x1FB2710", Offset = "0x1FB1310", VA = "0x181FB2710", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E5B RID: 151131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5B")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033937 RID: 211255
			[Token(Token = "0x4033937")]
			public const int ID = 339;

			// Token: 0x04033938 RID: 211256
			[Token(Token = "0x4033938")]
			[FieldOffset(Offset = "0x18")]
			public int charInstId;

			// Token: 0x04033939 RID: 211257
			[Token(Token = "0x4033939")]
			[FieldOffset(Offset = "0x1C")]
			public int layerDelta;

			// Token: 0x0403393A RID: 211258
			[Token(Token = "0x403393A")]
			[FieldOffset(Offset = "0x20")]
			public List<byte> bondIndexList;

			// Token: 0x0403393B RID: 211259
			[Token(Token = "0x403393B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403393C RID: 211260
			[Token(Token = "0x403393C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006401 RID: 25601
		[Token(Token = "0x2006401")]
		public class AutoChessBattleSceneUseMagicUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E5C RID: 151132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5C")]
			[Address(RVA = "0x1FB3D80", Offset = "0x1FB2980", VA = "0x181FB3D80")]
			public AutoChessBattleSceneUseMagicUp()
			{
			}

			// Token: 0x06024E5D RID: 151133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5D")]
			[Address(RVA = "0x1FB3CB0", Offset = "0x1FB28B0", VA = "0x181FB3CB0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E5E RID: 151134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5E")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x0403393D RID: 211261
			[Token(Token = "0x403393D")]
			public const int ID = 351;

			// Token: 0x0403393E RID: 211262
			[Token(Token = "0x403393E")]
			[FieldOffset(Offset = "0x18")]
			public int instId;

			// Token: 0x0403393F RID: 211263
			[Token(Token = "0x403393F")]
			[FieldOffset(Offset = "0x1C")]
			public int deployCount;

			// Token: 0x04033940 RID: 211264
			[Token(Token = "0x4033940")]
			[FieldOffset(Offset = "0x20")]
			public List<AutoChessBattleChessPosUnitInfo> unitPositionInfo;

			// Token: 0x04033941 RID: 211265
			[Token(Token = "0x4033941")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033942 RID: 211266
			[Token(Token = "0x4033942")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006402 RID: 25602
		[Token(Token = "0x2006402")]
		public class AutoChessScenePreparationStatusResp : Protocol, IRRPProtocol
		{
			// Token: 0x06024E5F RID: 151135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E5F")]
			[Address(RVA = "0x1FBD5F0", Offset = "0x1FBC1F0", VA = "0x181FBD5F0")]
			public AutoChessScenePreparationStatusResp()
			{
			}

			// Token: 0x06024E60 RID: 151136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E60")]
			[Address(RVA = "0x1FBD530", Offset = "0x1FBC130", VA = "0x181FBD530", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E61 RID: 151137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E61")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033943 RID: 211267
			[Token(Token = "0x4033943")]
			public const int ID = 354;

			// Token: 0x04033944 RID: 211268
			[Token(Token = "0x4033944")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleProtocol.AutoChessScenePreparationStatusResp.RetCode code;

			// Token: 0x04033945 RID: 211269
			[Token(Token = "0x4033945")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessBattlePreparationStatus preparationStatus;

			// Token: 0x04033946 RID: 211270
			[Token(Token = "0x4033946")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033947 RID: 211271
			[Token(Token = "0x4033947")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;

			// Token: 0x02006403 RID: 25603
			[Token(Token = "0x2006403")]
			public enum RetCode
			{
				// Token: 0x04033949 RID: 211273
				[Token(Token = "0x4033949")]
				SUC,
				// Token: 0x0403394A RID: 211274
				[Token(Token = "0x403394A")]
				FAIL
			}
		}

		// Token: 0x02006404 RID: 25604
		[Token(Token = "0x2006404")]
		public class AutoChessBattleSceneObserveUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E62 RID: 151138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E62")]
			[Address(RVA = "0x1FB2150", Offset = "0x1FB0D50", VA = "0x181FB2150")]
			public AutoChessBattleSceneObserveUp()
			{
			}

			// Token: 0x06024E63 RID: 151139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E63")]
			[Address(RVA = "0x1FB20B0", Offset = "0x1FB0CB0", VA = "0x181FB20B0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E64 RID: 151140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E64")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x0403394B RID: 211275
			[Token(Token = "0x403394B")]
			public const int ID = 355;

			// Token: 0x0403394C RID: 211276
			[Token(Token = "0x403394C")]
			[FieldOffset(Offset = "0x18")]
			public int obIndex;

			// Token: 0x0403394D RID: 211277
			[Token(Token = "0x403394D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403394E RID: 211278
			[Token(Token = "0x403394E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006405 RID: 25605
		[Token(Token = "0x2006405")]
		public class AutoChessBattleSceneCancelObserveUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E65 RID: 151141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E65")]
			[Address(RVA = "0x1FB10D0", Offset = "0x1FAFCD0", VA = "0x181FB10D0")]
			public AutoChessBattleSceneCancelObserveUp()
			{
			}

			// Token: 0x0403394F RID: 211279
			[Token(Token = "0x403394F")]
			public const int ID = 357;

			// Token: 0x04033950 RID: 211280
			[Token(Token = "0x4033950")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006406 RID: 25606
		[Token(Token = "0x2006406")]
		public class AutoChessBattleSceneDeadAutoObUp : AutoChessServiceBattleRequest, IRRPProtocol
		{
			// Token: 0x06024E66 RID: 151142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E66")]
			[Address(RVA = "0x1FB1790", Offset = "0x1FB0390", VA = "0x181FB1790")]
			public AutoChessBattleSceneDeadAutoObUp()
			{
			}

			// Token: 0x04033951 RID: 211281
			[Token(Token = "0x4033951")]
			public const int ID = 359;

			// Token: 0x04033952 RID: 211282
			[Token(Token = "0x4033952")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006407 RID: 25607
		[Token(Token = "0x2006407")]
		public class AutoChessBattleSceneDeadAutoObDn : Protocol, IRRPProtocol
		{
			// Token: 0x06024E67 RID: 151143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E67")]
			[Address(RVA = "0x1FB1720", Offset = "0x1FB0320", VA = "0x181FB1720")]
			public AutoChessBattleSceneDeadAutoObDn()
			{
			}

			// Token: 0x06024E68 RID: 151144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E68")]
			[Address(RVA = "0x1FB1630", Offset = "0x1FB0230", VA = "0x181FB1630", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E69 RID: 151145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E69")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033953 RID: 211283
			[Token(Token = "0x4033953")]
			public const int ID = 360;

			// Token: 0x04033954 RID: 211284
			[Token(Token = "0x4033954")]
			[FieldOffset(Offset = "0x18")]
			public int obIndex;

			// Token: 0x04033955 RID: 211285
			[Token(Token = "0x4033955")]
			[FieldOffset(Offset = "0x1C")]
			public AutoChessGameStateType state;

			// Token: 0x04033956 RID: 211286
			[Token(Token = "0x4033956")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessBattlePreparationStatus preparation;

			// Token: 0x04033957 RID: 211287
			[Token(Token = "0x4033957")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033958 RID: 211288
			[Token(Token = "0x4033958")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006408 RID: 25608
		[Token(Token = "0x2006408")]
		public class AutoChessBattleSceneSettleLikeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E6A RID: 151146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6A")]
			[Address(RVA = "0x1FB2FF0", Offset = "0x1FB1BF0", VA = "0x181FB2FF0")]
			public AutoChessBattleSceneSettleLikeUp()
			{
			}

			// Token: 0x06024E6B RID: 151147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6B")]
			[Address(RVA = "0x1FB2F50", Offset = "0x1FB1B50", VA = "0x181FB2F50", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E6C RID: 151148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6C")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033959 RID: 211289
			[Token(Token = "0x4033959")]
			public const int ID = 361;

			// Token: 0x0403395A RID: 211290
			[Token(Token = "0x403395A")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x0403395B RID: 211291
			[Token(Token = "0x403395B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403395C RID: 211292
			[Token(Token = "0x403395C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006409 RID: 25609
		[Token(Token = "0x2006409")]
		public class AutoChessBattleSceneSettleLikeDn : Protocol
		{
			// Token: 0x06024E6D RID: 151149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6D")]
			[Address(RVA = "0x1FB2EE0", Offset = "0x1FB1AE0", VA = "0x181FB2EE0")]
			public AutoChessBattleSceneSettleLikeDn()
			{
			}

			// Token: 0x06024E6E RID: 151150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6E")]
			[Address(RVA = "0x1FB2E40", Offset = "0x1FB1A40", VA = "0x181FB2E40", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E6F RID: 151151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E6F")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x0403395D RID: 211293
			[Token(Token = "0x403395D")]
			public const int ID = 362;

			// Token: 0x0403395E RID: 211294
			[Token(Token = "0x403395E")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x0403395F RID: 211295
			[Token(Token = "0x403395F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033960 RID: 211296
			[Token(Token = "0x4033960")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200640A RID: 25610
		[Token(Token = "0x200640A")]
		public class AutoChessBattleSceneActionUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E70 RID: 151152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E70")]
			[Address(RVA = "0x1FB0CA0", Offset = "0x1FAF8A0", VA = "0x181FB0CA0")]
			public AutoChessBattleSceneActionUp()
			{
			}

			// Token: 0x06024E71 RID: 151153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E71")]
			[Address(RVA = "0x1FB0BE0", Offset = "0x1FAF7E0", VA = "0x181FB0BE0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E72 RID: 151154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E72")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033961 RID: 211297
			[Token(Token = "0x4033961")]
			public const int ID = 341;

			// Token: 0x04033962 RID: 211298
			[Token(Token = "0x4033962")]
			[FieldOffset(Offset = "0x18")]
			public int seq;

			// Token: 0x04033963 RID: 211299
			[Token(Token = "0x4033963")]
			[FieldOffset(Offset = "0x20")]
			public List<AutoChessBattleStepActionData> actions;

			// Token: 0x04033964 RID: 211300
			[Token(Token = "0x4033964")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033965 RID: 211301
			[Token(Token = "0x4033965")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200640B RID: 25611
		[Token(Token = "0x200640B")]
		public class AutoChessBattleSceneHistoryUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E73 RID: 151155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E73")]
			[Address(RVA = "0x1FB1F40", Offset = "0x1FB0B40", VA = "0x181FB1F40")]
			public AutoChessBattleSceneHistoryUp()
			{
			}

			// Token: 0x06024E74 RID: 151156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E74")]
			[Address(RVA = "0x1FB1EA0", Offset = "0x1FB0AA0", VA = "0x181FB1EA0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E75 RID: 151157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E75")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033966 RID: 211302
			[Token(Token = "0x4033966")]
			public const int ID = 343;

			// Token: 0x04033967 RID: 211303
			[Token(Token = "0x4033967")]
			[FieldOffset(Offset = "0x18")]
			public int seq;

			// Token: 0x04033968 RID: 211304
			[Token(Token = "0x4033968")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033969 RID: 211305
			[Token(Token = "0x4033969")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200640C RID: 25612
		[Token(Token = "0x200640C")]
		public class AutoChessBattleSceneHistoryDn : Protocol
		{
			// Token: 0x06024E76 RID: 151158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E76")]
			[Address(RVA = "0x1FB1E30", Offset = "0x1FB0A30", VA = "0x181FB1E30")]
			public AutoChessBattleSceneHistoryDn()
			{
			}

			// Token: 0x06024E77 RID: 151159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E77")]
			[Address(RVA = "0x1FB1D30", Offset = "0x1FB0930", VA = "0x181FB1D30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E78 RID: 151160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E78")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x0403396A RID: 211306
			[Token(Token = "0x403396A")]
			public const int ID = 344;

			// Token: 0x0403396B RID: 211307
			[Token(Token = "0x403396B")]
			[FieldOffset(Offset = "0x18")]
			public List<AutoChessBattleStepData> steps;

			// Token: 0x0403396C RID: 211308
			[Token(Token = "0x403396C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403396D RID: 211309
			[Token(Token = "0x403396D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200640D RID: 25613
		[Token(Token = "0x200640D")]
		public class AutoChessBattleSceneStepDn : Protocol
		{
			// Token: 0x06024E79 RID: 151161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E79")]
			[Address(RVA = "0x1FB3AF0", Offset = "0x1FB26F0", VA = "0x181FB3AF0")]
			public AutoChessBattleSceneStepDn()
			{
			}

			// Token: 0x06024E7A RID: 151162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7A")]
			[Address(RVA = "0x1FB3A00", Offset = "0x1FB2600", VA = "0x181FB3A00", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E7B RID: 151163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7B")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x0403396E RID: 211310
			[Token(Token = "0x403396E")]
			public const int ID = 348;

			// Token: 0x0403396F RID: 211311
			[Token(Token = "0x403396F")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleStepData stepData;

			// Token: 0x04033970 RID: 211312
			[Token(Token = "0x4033970")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033971 RID: 211313
			[Token(Token = "0x4033971")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200640E RID: 25614
		[Token(Token = "0x200640E")]
		public class AutoChessBattleSceneChatReq : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E7C RID: 151164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7C")]
			[Address(RVA = "0x1FB15C0", Offset = "0x1FB01C0", VA = "0x181FB15C0")]
			public AutoChessBattleSceneChatReq()
			{
			}

			// Token: 0x06024E7D RID: 151165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7D")]
			[Address(RVA = "0x1FB1510", Offset = "0x1FB0110", VA = "0x181FB1510", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E7E RID: 151166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7E")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033972 RID: 211314
			[Token(Token = "0x4033972")]
			public const int ID = 363;

			// Token: 0x04033973 RID: 211315
			[Token(Token = "0x4033973")]
			[FieldOffset(Offset = "0x18")]
			public string emojiGroup;

			// Token: 0x04033974 RID: 211316
			[Token(Token = "0x4033974")]
			[FieldOffset(Offset = "0x20")]
			public string emojiId;

			// Token: 0x04033975 RID: 211317
			[Token(Token = "0x4033975")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033976 RID: 211318
			[Token(Token = "0x4033976")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200640F RID: 25615
		[Token(Token = "0x200640F")]
		public class AutoChessBattleSceneChatDn : DnProtocol<AutoChessChatData>
		{
			// Token: 0x06024E7F RID: 151167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E7F")]
			[Address(RVA = "0x1FB1490", Offset = "0x1FB0090", VA = "0x181FB1490")]
			public AutoChessBattleSceneChatDn()
			{
			}

			// Token: 0x04033977 RID: 211319
			[Token(Token = "0x4033977")]
			public const int ID = 364;

			// Token: 0x04033978 RID: 211320
			[Token(Token = "0x4033978")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006410 RID: 25616
		[Token(Token = "0x2006410")]
		public class AutoChessBattleSceneBroadcastUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E80 RID: 151168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E80")]
			[Address(RVA = "0x1FB1010", Offset = "0x1FAFC10", VA = "0x181FB1010")]
			public AutoChessBattleSceneBroadcastUp()
			{
			}

			// Token: 0x06024E81 RID: 151169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E81")]
			[Address(RVA = "0x1FB0F50", Offset = "0x1FAFB50", VA = "0x181FB0F50", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024E82 RID: 151170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E82")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033979 RID: 211321
			[Token(Token = "0x4033979")]
			public const int ID = 365;

			// Token: 0x0403397A RID: 211322
			[Token(Token = "0x403397A")]
			[FieldOffset(Offset = "0x18")]
			public int uIdx;

			// Token: 0x0403397B RID: 211323
			[Token(Token = "0x403397B")]
			[FieldOffset(Offset = "0x20")]
			public string broadcastId;

			// Token: 0x0403397C RID: 211324
			[Token(Token = "0x403397C")]
			[FieldOffset(Offset = "0x28")]
			public List<string> strParams;

			// Token: 0x0403397D RID: 211325
			[Token(Token = "0x403397D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403397E RID: 211326
			[Token(Token = "0x403397E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006411 RID: 25617
		[Token(Token = "0x2006411")]
		public class AutoChessBattleSceneBroadcastDn : DnProtocol<AutoChessBroadcast>
		{
			// Token: 0x06024E83 RID: 151171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E83")]
			[Address(RVA = "0x1FB0ED0", Offset = "0x1FAFAD0", VA = "0x181FB0ED0")]
			public AutoChessBattleSceneBroadcastDn()
			{
			}

			// Token: 0x0403397F RID: 211327
			[Token(Token = "0x403397F")]
			public const int ID = 366;

			// Token: 0x04033980 RID: 211328
			[Token(Token = "0x4033980")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006412 RID: 25618
		[Token(Token = "0x2006412")]
		public class AutoChessBattleScenePlayerKickDn : Protocol
		{
			// Token: 0x06024E84 RID: 151172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E84")]
			[Address(RVA = "0x1FB22C0", Offset = "0x1FB0EC0", VA = "0x181FB22C0")]
			public AutoChessBattleScenePlayerKickDn()
			{
			}

			// Token: 0x06024E85 RID: 151173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E85")]
			[Address(RVA = "0x1FB2230", Offset = "0x1FB0E30", VA = "0x181FB2230", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024E86 RID: 151174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E86")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033981 RID: 211329
			[Token(Token = "0x4033981")]
			public const int ID = 110;

			// Token: 0x04033982 RID: 211330
			[Token(Token = "0x4033982")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBattleSceneEndReasonType reason;

			// Token: 0x04033983 RID: 211331
			[Token(Token = "0x4033983")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033984 RID: 211332
			[Token(Token = "0x4033984")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006413 RID: 25619
		[Token(Token = "0x2006413")]
		public class AutoChessBattleSceneQuitUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E87 RID: 151175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E87")]
			[Address(RVA = "0x1FB2640", Offset = "0x1FB1240", VA = "0x181FB2640")]
			public AutoChessBattleSceneQuitUp()
			{
			}

			// Token: 0x04033985 RID: 211333
			[Token(Token = "0x4033985")]
			public const int ID = 105;

			// Token: 0x04033986 RID: 211334
			[Token(Token = "0x4033986")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006414 RID: 25620
		[Token(Token = "0x2006414")]
		public class AutoChessBattleScenePauseUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E88 RID: 151176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E88")]
			[Address(RVA = "0x1FB21C0", Offset = "0x1FB0DC0", VA = "0x181FB21C0")]
			public AutoChessBattleScenePauseUp()
			{
			}

			// Token: 0x04033987 RID: 211335
			[Token(Token = "0x4033987")]
			public const int ID = 372;

			// Token: 0x04033988 RID: 211336
			[Token(Token = "0x4033988")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006415 RID: 25621
		[Token(Token = "0x2006415")]
		public class AutoChessBattleSceneResumeUp : AutoChessServiceBattleRequest
		{
			// Token: 0x06024E89 RID: 151177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024E89")]
			[Address(RVA = "0x1FB26A0", Offset = "0x1FB12A0", VA = "0x181FB26A0")]
			public AutoChessBattleSceneResumeUp()
			{
			}

			// Token: 0x04033989 RID: 211337
			[Token(Token = "0x4033989")]
			public const int ID = 374;

			// Token: 0x0403398A RID: 211338
			[Token(Token = "0x403398A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
