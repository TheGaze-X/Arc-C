using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x0200156D RID: 5485
	[Token(Token = "0x200156D")]
	public static class BattleProtocol
	{
		// Token: 0x06007D74 RID: 32116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D74")]
		[Address(RVA = "0x283D370", Offset = "0x283BF70", VA = "0x18283D370")]
		public static void Register(ProtocolSuite suite)
		{
		}

		// Token: 0x0200156E RID: 5486
		[Token(Token = "0x200156E")]
		public class SceneJoin : Protocol
		{
			// Token: 0x06007D75 RID: 32117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D75")]
			[Address(RVA = "0x284CE00", Offset = "0x284BA00", VA = "0x18284CE00")]
			public SceneJoin()
			{
			}

			// Token: 0x06007D76 RID: 32118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D76")]
			[Address(RVA = "0x284CD30", Offset = "0x284B930", VA = "0x18284CD30", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007D77 RID: 32119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D77")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007E3A RID: 32314
			[Token(Token = "0x4007E3A")]
			public const uint ID = 101U;

			// Token: 0x04007E3B RID: 32315
			[Token(Token = "0x4007E3B")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007E3C RID: 32316
			[Token(Token = "0x4007E3C")]
			[FieldOffset(Offset = "0x20")]
			public string sceneID;

			// Token: 0x04007E3D RID: 32317
			[Token(Token = "0x4007E3D")]
			[FieldOffset(Offset = "0x28")]
			public string token;

			// Token: 0x04007E3E RID: 32318
			[Token(Token = "0x4007E3E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E3F RID: 32319
			[Token(Token = "0x4007E3F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200156F RID: 5487
		[Token(Token = "0x200156F")]
		public class SceneJoinRet : Protocol
		{
			// Token: 0x06007D78 RID: 32120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D78")]
			[Address(RVA = "0x284CC70", Offset = "0x284B870", VA = "0x18284CC70")]
			public SceneJoinRet()
			{
			}

			// Token: 0x06007D79 RID: 32121 RVA: 0x000378F0 File Offset: 0x00035AF0
			[Token(Token = "0x6007D79")]
			[Address(RVA = "0x284C830", Offset = "0x284B430", VA = "0x18284C830")]
			private BattleProtocol.SceneJoinRet.UserInfo _InitSinglePlayer(BattleProtocol.SceneJoinRet.NewPlayer player)
			{
				return default(BattleProtocol.SceneJoinRet.UserInfo);
			}

			// Token: 0x06007D7A RID: 32122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D7A")]
			[Address(RVA = "0x284C5B0", Offset = "0x284B1B0", VA = "0x18284C5B0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007D7B RID: 32123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D7B")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E40 RID: 32320
			[Token(Token = "0x4007E40")]
			public const uint ID = 102U;

			// Token: 0x04007E41 RID: 32321
			[Token(Token = "0x4007E41")]
			[FieldOffset(Offset = "0x18")]
			public GeneralProtocol.RetCode code;

			// Token: 0x04007E42 RID: 32322
			[Token(Token = "0x4007E42")]
			[FieldOffset(Offset = "0x20")]
			public long nowTs;

			// Token: 0x04007E43 RID: 32323
			[Token(Token = "0x4007E43")]
			[FieldOffset(Offset = "0x28")]
			public long createTs;

			// Token: 0x04007E44 RID: 32324
			[Token(Token = "0x4007E44")]
			[FieldOffset(Offset = "0x30")]
			public long forceEndTs;

			// Token: 0x04007E45 RID: 32325
			[Token(Token = "0x4007E45")]
			[FieldOffset(Offset = "0x38")]
			public string newToken;

			// Token: 0x04007E46 RID: 32326
			[Token(Token = "0x4007E46")]
			[FieldOffset(Offset = "0x40")]
			public string stageID;

			// Token: 0x04007E47 RID: 32327
			[Token(Token = "0x4007E47")]
			[FieldOffset(Offset = "0x48")]
			public int stageSeed;

			// Token: 0x04007E48 RID: 32328
			[Token(Token = "0x4007E48")]
			[FieldOffset(Offset = "0x4C")]
			public bool reverse;

			// Token: 0x04007E49 RID: 32329
			[Token(Token = "0x4007E49")]
			[FieldOffset(Offset = "0x50")]
			public readonly ListDict<string, BattleProtocol.SceneJoinRet.UserInfo> users;

			// Token: 0x04007E4A RID: 32330
			[Token(Token = "0x4007E4A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E4B RID: 32331
			[Token(Token = "0x4007E4B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__InitSinglePlayer;

			// Token: 0x04007E4C RID: 32332
			[Token(Token = "0x4007E4C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRead;

			// Token: 0x02001570 RID: 5488
			[Token(Token = "0x2001570")]
			public class NewPlayer : IStreamDeserialize
			{
				// Token: 0x06007D7C RID: 32124 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007D7C")]
				[Address(RVA = "0x284A2E0", Offset = "0x2848EE0", VA = "0x18284A2E0", Slot = "4")]
				public void Read(IStreamReader from)
				{
				}

				// Token: 0x06007D7D RID: 32125 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007D7D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NewPlayer()
				{
				}

				// Token: 0x04007E4D RID: 32333
				[Token(Token = "0x4007E4D")]
				[FieldOffset(Offset = "0x10")]
				public string uid;

				// Token: 0x04007E4E RID: 32334
				[Token(Token = "0x4007E4E")]
				[FieldOffset(Offset = "0x18")]
				public sbyte index;

				// Token: 0x04007E4F RID: 32335
				[Token(Token = "0x4007E4F")]
				[FieldOffset(Offset = "0x20")]
				public List<BattleProtocol.SceneJoinRet.Card> squad;

				// Token: 0x04007E50 RID: 32336
				[Token(Token = "0x4007E50")]
				[FieldOffset(Offset = "0x28")]
				public string buffId;

				// Token: 0x04007E51 RID: 32337
				[Token(Token = "0x4007E51")]
				[FieldOffset(Offset = "0x30")]
				public int fail;
			}

			// Token: 0x02001571 RID: 5489
			[Token(Token = "0x2001571")]
			public class Card : IStreamDeserialize
			{
				// Token: 0x06007D7E RID: 32126 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007D7E")]
				[Address(RVA = "0x28401C0", Offset = "0x283EDC0", VA = "0x1828401C0", Slot = "4")]
				public void Read(IStreamReader from)
				{
				}

				// Token: 0x06007D7F RID: 32127 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007D7F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Card()
				{
				}

				// Token: 0x04007E52 RID: 32338
				[Token(Token = "0x4007E52")]
				[FieldOffset(Offset = "0x10")]
				public int inst_id;

				// Token: 0x04007E53 RID: 32339
				[Token(Token = "0x4007E53")]
				[FieldOffset(Offset = "0x14")]
				public int char_inst_id;

				// Token: 0x04007E54 RID: 32340
				[Token(Token = "0x4007E54")]
				[FieldOffset(Offset = "0x18")]
				public string char_id;

				// Token: 0x04007E55 RID: 32341
				[Token(Token = "0x4007E55")]
				[FieldOffset(Offset = "0x20")]
				public int level;

				// Token: 0x04007E56 RID: 32342
				[Token(Token = "0x4007E56")]
				[FieldOffset(Offset = "0x24")]
				public int phase;

				// Token: 0x04007E57 RID: 32343
				[Token(Token = "0x4007E57")]
				[FieldOffset(Offset = "0x28")]
				public int favor_point;

				// Token: 0x04007E58 RID: 32344
				[Token(Token = "0x4007E58")]
				[FieldOffset(Offset = "0x2C")]
				public int potential_rank;

				// Token: 0x04007E59 RID: 32345
				[Token(Token = "0x4007E59")]
				[FieldOffset(Offset = "0x30")]
				public string tmpl_id;

				// Token: 0x04007E5A RID: 32346
				[Token(Token = "0x4007E5A")]
				[FieldOffset(Offset = "0x38")]
				public int skill_index;

				// Token: 0x04007E5B RID: 32347
				[Token(Token = "0x4007E5B")]
				[FieldOffset(Offset = "0x3C")]
				public int skill_level;

				// Token: 0x04007E5C RID: 32348
				[Token(Token = "0x4007E5C")]
				[FieldOffset(Offset = "0x40")]
				public int spec_skill_level;

				// Token: 0x04007E5D RID: 32349
				[Token(Token = "0x4007E5D")]
				[FieldOffset(Offset = "0x48")]
				public string skin_id;

				// Token: 0x04007E5E RID: 32350
				[Token(Token = "0x4007E5E")]
				[FieldOffset(Offset = "0x50")]
				public string equip_id;

				// Token: 0x04007E5F RID: 32351
				[Token(Token = "0x4007E5F")]
				[FieldOffset(Offset = "0x58")]
				public int equip_level;
			}

			// Token: 0x02001572 RID: 5490
			[Token(Token = "0x2001572")]
			public struct UserInfo
			{
				// Token: 0x04007E60 RID: 32352
				[Token(Token = "0x4007E60")]
				[FieldOffset(Offset = "0x0")]
				public string uid;

				// Token: 0x04007E61 RID: 32353
				[Token(Token = "0x4007E61")]
				[FieldOffset(Offset = "0x8")]
				public TeamProtocol.Squad squad;

				// Token: 0x04007E62 RID: 32354
				[Token(Token = "0x4007E62")]
				[FieldOffset(Offset = "0x10")]
				public MultiStageTargetPos pos;

				// Token: 0x04007E63 RID: 32355
				[Token(Token = "0x4007E63")]
				[FieldOffset(Offset = "0x18")]
				public string buffId;

				// Token: 0x04007E64 RID: 32356
				[Token(Token = "0x4007E64")]
				[FieldOffset(Offset = "0x20")]
				public int fail;
			}
		}

		// Token: 0x02001573 RID: 5491
		[Token(Token = "0x2001573")]
		public class SceneReady : Protocol
		{
			// Token: 0x06007D80 RID: 32128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D80")]
			[Address(RVA = "0x284CF80", Offset = "0x284BB80", VA = "0x18284CF80")]
			public SceneReady()
			{
			}

			// Token: 0x04007E65 RID: 32357
			[Token(Token = "0x4007E65")]
			public const uint ID = 103U;

			// Token: 0x04007E66 RID: 32358
			[Token(Token = "0x4007E66")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001574 RID: 5492
		[Token(Token = "0x2001574")]
		public class SceneReadyRet : Protocol
		{
			// Token: 0x06007D81 RID: 32129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D81")]
			[Address(RVA = "0x284CF20", Offset = "0x284BB20", VA = "0x18284CF20")]
			public SceneReadyRet()
			{
			}

			// Token: 0x04007E67 RID: 32359
			[Token(Token = "0x4007E67")]
			public const uint ID = 104U;

			// Token: 0x04007E68 RID: 32360
			[Token(Token = "0x4007E68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001575 RID: 5493
		[Token(Token = "0x2001575")]
		public class SceneQuitUp : Protocol
		{
			// Token: 0x06007D82 RID: 32130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D82")]
			[Address(RVA = "0x284CEC0", Offset = "0x284BAC0", VA = "0x18284CEC0")]
			public SceneQuitUp()
			{
			}

			// Token: 0x04007E69 RID: 32361
			[Token(Token = "0x4007E69")]
			public const uint ID = 105U;

			// Token: 0x04007E6A RID: 32362
			[Token(Token = "0x4007E6A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001576 RID: 5494
		[Token(Token = "0x2001576")]
		public class SceneQuitDn : Protocol
		{
			// Token: 0x06007D83 RID: 32131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D83")]
			[Address(RVA = "0x284CE60", Offset = "0x284BA60", VA = "0x18284CE60")]
			public SceneQuitDn()
			{
			}

			// Token: 0x04007E6B RID: 32363
			[Token(Token = "0x4007E6B")]
			public const uint ID = 106U;

			// Token: 0x04007E6C RID: 32364
			[Token(Token = "0x4007E6C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001577 RID: 5495
		[Token(Token = "0x2001577")]
		public class GameSettle : Protocol
		{
			// Token: 0x06007D84 RID: 32132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D84")]
			[Address(RVA = "0x2841D00", Offset = "0x2840900", VA = "0x182841D00")]
			public GameSettle()
			{
			}

			// Token: 0x06007D85 RID: 32133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D85")]
			[Address(RVA = "0x2841BE0", Offset = "0x28407E0", VA = "0x182841BE0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007D86 RID: 32134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D86")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007E6D RID: 32365
			[Token(Token = "0x4007E6D")]
			public const uint ID = 107U;

			// Token: 0x04007E6E RID: 32366
			[Token(Token = "0x4007E6E")]
			[FieldOffset(Offset = "0x18")]
			public int oprt;

			// Token: 0x04007E6F RID: 32367
			[Token(Token = "0x4007E6F")]
			[FieldOffset(Offset = "0x1C")]
			public uint checkSum;

			// Token: 0x04007E70 RID: 32368
			[Token(Token = "0x4007E70")]
			[FieldOffset(Offset = "0x20")]
			public int hp;

			// Token: 0x04007E71 RID: 32369
			[Token(Token = "0x4007E71")]
			[FieldOffset(Offset = "0x24")]
			public int killCnt;

			// Token: 0x04007E72 RID: 32370
			[Token(Token = "0x4007E72")]
			[FieldOffset(Offset = "0x28")]
			public string resultInfo;

			// Token: 0x04007E73 RID: 32371
			[Token(Token = "0x4007E73")]
			[FieldOffset(Offset = "0x30")]
			public string battleStats;

			// Token: 0x04007E74 RID: 32372
			[Token(Token = "0x4007E74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E75 RID: 32373
			[Token(Token = "0x4007E75")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001578 RID: 5496
		[Token(Token = "0x2001578")]
		public class GameSettleRet : Protocol
		{
			// Token: 0x06007D87 RID: 32135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D87")]
			[Address(RVA = "0x2841B80", Offset = "0x2840780", VA = "0x182841B80")]
			public GameSettleRet()
			{
			}

			// Token: 0x06007D88 RID: 32136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D88")]
			[Address(RVA = "0x2841AA0", Offset = "0x28406A0", VA = "0x182841AA0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007D89 RID: 32137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D89")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E76 RID: 32374
			[Token(Token = "0x4007E76")]
			public const uint ID = 108U;

			// Token: 0x04007E77 RID: 32375
			[Token(Token = "0x4007E77")]
			[FieldOffset(Offset = "0x18")]
			public BattleProtocol.GameSettleInfo info;

			// Token: 0x04007E78 RID: 32376
			[Token(Token = "0x4007E78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E79 RID: 32377
			[Token(Token = "0x4007E79")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001579 RID: 5497
		[Token(Token = "0x2001579")]
		public class SceneEnd : Protocol
		{
			// Token: 0x06007D8A RID: 32138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8A")]
			[Address(RVA = "0x284C550", Offset = "0x284B150", VA = "0x18284C550")]
			public SceneEnd()
			{
			}

			// Token: 0x04007E7A RID: 32378
			[Token(Token = "0x4007E7A")]
			public const uint ID = 109U;

			// Token: 0x04007E7B RID: 32379
			[Token(Token = "0x4007E7B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200157A RID: 5498
		[Token(Token = "0x200157A")]
		public class SceneEndRet : Protocol
		{
			// Token: 0x06007D8B RID: 32139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8B")]
			[Address(RVA = "0x284C4F0", Offset = "0x284B0F0", VA = "0x18284C4F0")]
			public SceneEndRet()
			{
			}

			// Token: 0x06007D8C RID: 32140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8C")]
			[Address(RVA = "0x284C450", Offset = "0x284B050", VA = "0x18284C450", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007D8D RID: 32141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E7C RID: 32380
			[Token(Token = "0x4007E7C")]
			public const uint ID = 110U;

			// Token: 0x04007E7D RID: 32381
			[Token(Token = "0x4007E7D")]
			[FieldOffset(Offset = "0x18")]
			public BattleProtocol.SceneEndReason reason;

			// Token: 0x04007E7E RID: 32382
			[Token(Token = "0x4007E7E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E7F RID: 32383
			[Token(Token = "0x4007E7F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200157B RID: 5499
		[Token(Token = "0x200157B")]
		public class GameAction : Protocol
		{
			// Token: 0x06007D8E RID: 32142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8E")]
			[Address(RVA = "0x2840AF0", Offset = "0x283F6F0", VA = "0x182840AF0")]
			public GameAction()
			{
			}

			// Token: 0x06007D8F RID: 32143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8F")]
			[Address(RVA = "0x2840850", Offset = "0x283F450", VA = "0x182840850", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007D90 RID: 32144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D90")]
			[Address(RVA = "0x28407B0", Offset = "0x283F3B0", VA = "0x1828407B0", Slot = "6")]
			protected override void OnRecycle()
			{
			}

			// Token: 0x06007D91 RID: 32145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D91")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x06007D92 RID: 32146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D92")]
			[Address(RVA = "0x2840AE0", Offset = "0x283F6E0", VA = "0x182840AE0")]
			private void <>xLuaBaseProxy_OnRecycle()
			{
			}

			// Token: 0x04007E80 RID: 32384
			[Token(Token = "0x4007E80")]
			public const uint ID = 111U;

			// Token: 0x04007E81 RID: 32385
			[Token(Token = "0x4007E81")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerOprtData> list;

			// Token: 0x04007E82 RID: 32386
			[Token(Token = "0x4007E82")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E83 RID: 32387
			[Token(Token = "0x4007E83")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;

			// Token: 0x04007E84 RID: 32388
			[Token(Token = "0x4007E84")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRecycle;
		}

		// Token: 0x0200157C RID: 5500
		[Token(Token = "0x200157C")]
		public class GameActionRet : Protocol
		{
			// Token: 0x06007D93 RID: 32147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D93")]
			[Address(RVA = "0x2840750", Offset = "0x283F350", VA = "0x182840750")]
			public GameActionRet()
			{
			}

			// Token: 0x04007E85 RID: 32389
			[Token(Token = "0x4007E85")]
			public const uint ID = 112U;

			// Token: 0x04007E86 RID: 32390
			[Token(Token = "0x4007E86")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200157D RID: 5501
		[Token(Token = "0x200157D")]
		public class GameStep : Protocol
		{
			// Token: 0x06007D94 RID: 32148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D94")]
			[Address(RVA = "0x2841EF0", Offset = "0x2840AF0", VA = "0x182841EF0")]
			public GameStep()
			{
			}

			// Token: 0x04007E87 RID: 32391
			[Token(Token = "0x4007E87")]
			public const uint ID = 113U;

			// Token: 0x04007E88 RID: 32392
			[Token(Token = "0x4007E88")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200157E RID: 5502
		[Token(Token = "0x200157E")]
		public class GameStepRet : Protocol
		{
			// Token: 0x06007D95 RID: 32149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D95")]
			[Address(RVA = "0x2841E90", Offset = "0x2840A90", VA = "0x182841E90")]
			public GameStepRet()
			{
			}

			// Token: 0x06007D96 RID: 32150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D96")]
			[Address(RVA = "0x2841DB0", Offset = "0x28409B0", VA = "0x182841DB0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007D97 RID: 32151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D97")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E89 RID: 32393
			[Token(Token = "0x4007E89")]
			public const uint ID = 114U;

			// Token: 0x04007E8A RID: 32394
			[Token(Token = "0x4007E8A")]
			[FieldOffset(Offset = "0x18")]
			public StepData step;

			// Token: 0x04007E8B RID: 32395
			[Token(Token = "0x4007E8B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E8C RID: 32396
			[Token(Token = "0x4007E8C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200157F RID: 5503
		[Token(Token = "0x200157F")]
		public class GameCheck : Protocol
		{
			// Token: 0x06007D98 RID: 32152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D98")]
			[Address(RVA = "0x2840D80", Offset = "0x283F980", VA = "0x182840D80")]
			public GameCheck()
			{
			}

			// Token: 0x06007D99 RID: 32153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D99")]
			[Address(RVA = "0x2840CB0", Offset = "0x283F8B0", VA = "0x182840CB0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007D9A RID: 32154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9A")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007E8D RID: 32397
			[Token(Token = "0x4007E8D")]
			public const uint ID = 115U;

			// Token: 0x04007E8E RID: 32398
			[Token(Token = "0x4007E8E")]
			[FieldOffset(Offset = "0x18")]
			public int seq;

			// Token: 0x04007E8F RID: 32399
			[Token(Token = "0x4007E8F")]
			[FieldOffset(Offset = "0x1C")]
			public uint checksum;

			// Token: 0x04007E90 RID: 32400
			[Token(Token = "0x4007E90")]
			[FieldOffset(Offset = "0x20")]
			public int hp;

			// Token: 0x04007E91 RID: 32401
			[Token(Token = "0x4007E91")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E92 RID: 32402
			[Token(Token = "0x4007E92")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001580 RID: 5504
		[Token(Token = "0x2001580")]
		public class GameCheckRet : Protocol
		{
			// Token: 0x06007D9B RID: 32155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9B")]
			[Address(RVA = "0x2840C50", Offset = "0x283F850", VA = "0x182840C50")]
			public GameCheckRet()
			{
			}

			// Token: 0x06007D9C RID: 32156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9C")]
			[Address(RVA = "0x2840BB0", Offset = "0x283F7B0", VA = "0x182840BB0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007D9D RID: 32157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E93 RID: 32403
			[Token(Token = "0x4007E93")]
			public const uint ID = 116U;

			// Token: 0x04007E94 RID: 32404
			[Token(Token = "0x4007E94")]
			[FieldOffset(Offset = "0x18")]
			public int failSeq;

			// Token: 0x04007E95 RID: 32405
			[Token(Token = "0x4007E95")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E96 RID: 32406
			[Token(Token = "0x4007E96")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001581 RID: 5505
		[Token(Token = "0x2001581")]
		public class GameActionHistory : Protocol
		{
			// Token: 0x06007D9E RID: 32158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9E")]
			[Address(RVA = "0x28406F0", Offset = "0x283F2F0", VA = "0x1828406F0")]
			public GameActionHistory()
			{
			}

			// Token: 0x06007D9F RID: 32159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D9F")]
			[Address(RVA = "0x28405C0", Offset = "0x283F1C0", VA = "0x1828405C0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DA0 RID: 32160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA0")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007E97 RID: 32407
			[Token(Token = "0x4007E97")]
			public const uint ID = 117U;

			// Token: 0x04007E98 RID: 32408
			[Token(Token = "0x4007E98")]
			[FieldOffset(Offset = "0x18")]
			public uint seq;

			// Token: 0x04007E99 RID: 32409
			[Token(Token = "0x4007E99")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E9A RID: 32410
			[Token(Token = "0x4007E9A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001582 RID: 5506
		[Token(Token = "0x2001582")]
		public class GameActionHistoryRet : Protocol
		{
			// Token: 0x06007DA1 RID: 32161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA1")]
			[Address(RVA = "0x2840560", Offset = "0x283F160", VA = "0x182840560")]
			public GameActionHistoryRet()
			{
			}

			// Token: 0x06007DA2 RID: 32162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA2")]
			[Address(RVA = "0x2840380", Offset = "0x283EF80", VA = "0x182840380", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DA3 RID: 32163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA3")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007E9B RID: 32411
			[Token(Token = "0x4007E9B")]
			public const uint ID = 118U;

			// Token: 0x04007E9C RID: 32412
			[Token(Token = "0x4007E9C")]
			[FieldOffset(Offset = "0x18")]
			public List<StepData> steps;

			// Token: 0x04007E9D RID: 32413
			[Token(Token = "0x4007E9D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007E9E RID: 32414
			[Token(Token = "0x4007E9E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001583 RID: 5507
		[Token(Token = "0x2001583")]
		public class GameMapMark : Protocol
		{
			// Token: 0x06007DA4 RID: 32164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA4")]
			[Address(RVA = "0x2841000", Offset = "0x283FC00", VA = "0x182841000")]
			public GameMapMark()
			{
			}

			// Token: 0x06007DA5 RID: 32165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA5")]
			[Address(RVA = "0x2840F80", Offset = "0x283FB80", VA = "0x182840F80", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DA6 RID: 32166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA6")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007E9F RID: 32415
			[Token(Token = "0x4007E9F")]
			public const uint ID = 119U;

			// Token: 0x04007EA0 RID: 32416
			[Token(Token = "0x4007EA0")]
			[FieldOffset(Offset = "0x18")]
			public GameMarkData param;

			// Token: 0x04007EA1 RID: 32417
			[Token(Token = "0x4007EA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EA2 RID: 32418
			[Token(Token = "0x4007EA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001584 RID: 5508
		[Token(Token = "0x2001584")]
		public class GameMapMarkRet : Protocol
		{
			// Token: 0x06007DA7 RID: 32167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA7")]
			[Address(RVA = "0x2840F20", Offset = "0x283FB20", VA = "0x182840F20")]
			public GameMapMarkRet()
			{
			}

			// Token: 0x06007DA8 RID: 32168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA8")]
			[Address(RVA = "0x2840DE0", Offset = "0x283F9E0", VA = "0x182840DE0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DA9 RID: 32169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA9")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EA3 RID: 32419
			[Token(Token = "0x4007EA3")]
			public const uint ID = 120U;

			// Token: 0x04007EA4 RID: 32420
			[Token(Token = "0x4007EA4")]
			[FieldOffset(Offset = "0x18")]
			public GameMarkData param;

			// Token: 0x04007EA5 RID: 32421
			[Token(Token = "0x4007EA5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EA6 RID: 32422
			[Token(Token = "0x4007EA6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001585 RID: 5509
		[Token(Token = "0x2001585")]
		public class GamePause : Protocol
		{
			// Token: 0x06007DAA RID: 32170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAA")]
			[Address(RVA = "0x28417E0", Offset = "0x28403E0", VA = "0x1828417E0")]
			public GamePause()
			{
			}

			// Token: 0x06007DAB RID: 32171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAB")]
			[Address(RVA = "0x2841740", Offset = "0x2840340", VA = "0x182841740", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DAC RID: 32172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAC")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007EA7 RID: 32423
			[Token(Token = "0x4007EA7")]
			public const uint ID = 211U;

			// Token: 0x04007EA8 RID: 32424
			[Token(Token = "0x4007EA8")]
			[FieldOffset(Offset = "0x18")]
			public GamePauseParam opr;

			// Token: 0x04007EA9 RID: 32425
			[Token(Token = "0x4007EA9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EAA RID: 32426
			[Token(Token = "0x4007EAA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001586 RID: 5510
		[Token(Token = "0x2001586")]
		public class GamePauseRet : Protocol
		{
			// Token: 0x06007DAD RID: 32173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAD")]
			[Address(RVA = "0x28416D0", Offset = "0x28402D0", VA = "0x1828416D0")]
			public GamePauseRet()
			{
			}

			// Token: 0x06007DAE RID: 32174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAE")]
			[Address(RVA = "0x2841610", Offset = "0x2840210", VA = "0x182841610", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DAF RID: 32175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAF")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EAB RID: 32427
			[Token(Token = "0x4007EAB")]
			public const uint ID = 212U;

			// Token: 0x04007EAC RID: 32428
			[Token(Token = "0x4007EAC")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007EAD RID: 32429
			[Token(Token = "0x4007EAD")]
			[FieldOffset(Offset = "0x20")]
			public GamePauseParam opr;

			// Token: 0x04007EAE RID: 32430
			[Token(Token = "0x4007EAE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EAF RID: 32431
			[Token(Token = "0x4007EAF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001587 RID: 5511
		[Token(Token = "0x2001587")]
		public class GamePlayerStatus : Protocol
		{
			// Token: 0x06007DB0 RID: 32176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB0")]
			[Address(RVA = "0x2841980", Offset = "0x2840580", VA = "0x182841980")]
			public GamePlayerStatus()
			{
			}

			// Token: 0x04007EB0 RID: 32432
			[Token(Token = "0x4007EB0")]
			public const uint ID = 215U;

			// Token: 0x04007EB1 RID: 32433
			[Token(Token = "0x4007EB1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001588 RID: 5512
		[Token(Token = "0x2001588")]
		public class GamePlayerStatusRet : Protocol
		{
			// Token: 0x06007DB1 RID: 32177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB1")]
			[Address(RVA = "0x2841910", Offset = "0x2840510", VA = "0x182841910")]
			public GamePlayerStatusRet()
			{
			}

			// Token: 0x06007DB2 RID: 32178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB2")]
			[Address(RVA = "0x2841850", Offset = "0x2840450", VA = "0x182841850", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DB3 RID: 32179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB3")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EB2 RID: 32434
			[Token(Token = "0x4007EB2")]
			public const uint ID = 216U;

			// Token: 0x04007EB3 RID: 32435
			[Token(Token = "0x4007EB3")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007EB4 RID: 32436
			[Token(Token = "0x4007EB4")]
			[FieldOffset(Offset = "0x20")]
			public BattlePlayerStatus status;

			// Token: 0x04007EB5 RID: 32437
			[Token(Token = "0x4007EB5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EB6 RID: 32438
			[Token(Token = "0x4007EB6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001589 RID: 5513
		[Token(Token = "0x2001589")]
		public enum SceneEndReason
		{
			// Token: 0x04007EB8 RID: 32440
			[Token(Token = "0x4007EB8")]
			EGameEndOK,
			// Token: 0x04007EB9 RID: 32441
			[Token(Token = "0x4007EB9")]
			EGameEndPrepareTimeout,
			// Token: 0x04007EBA RID: 32442
			[Token(Token = "0x4007EBA")]
			EGameEndSettleTimeout,
			// Token: 0x04007EBB RID: 32443
			[Token(Token = "0x4007EBB")]
			EGameEndAllPlayerLeave,
			// Token: 0x04007EBC RID: 32444
			[Token(Token = "0x4007EBC")]
			EGameEndTimeLimit,
			// Token: 0x04007EBD RID: 32445
			[Token(Token = "0x4007EBD")]
			EGameEndFatalInconsistent,
			// Token: 0x04007EBE RID: 32446
			[Token(Token = "0x4007EBE")]
			EGameEndAllLeaveTimeLimit,
			// Token: 0x04007EBF RID: 32447
			[Token(Token = "0x4007EBF")]
			EGameEndServerStop = 9
		}

		// Token: 0x0200158A RID: 5514
		[Token(Token = "0x200158A")]
		public class Step
		{
			// Token: 0x06007DB4 RID: 32180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB4")]
			[Address(RVA = "0x284D570", Offset = "0x284C170", VA = "0x18284D570")]
			public void Read(ByteArray from)
			{
			}

			// Token: 0x06007DB5 RID: 32181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Step()
			{
			}

			// Token: 0x04007EC0 RID: 32448
			[Token(Token = "0x4007EC0")]
			[FieldOffset(Offset = "0x10")]
			public uint seq;

			// Token: 0x04007EC1 RID: 32449
			[Token(Token = "0x4007EC1")]
			[FieldOffset(Offset = "0x14")]
			public uint spanMS;

			// Token: 0x04007EC2 RID: 32450
			[Token(Token = "0x4007EC2")]
			[FieldOffset(Offset = "0x18")]
			public int checkSeq;

			// Token: 0x04007EC3 RID: 32451
			[Token(Token = "0x4007EC3")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerOprtData[]> actions;
		}

		// Token: 0x0200158B RID: 5515
		[Token(Token = "0x200158B")]
		public struct GameSettleInfo
		{
			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x00037908 File Offset: 0x00035B08
			[Token(Token = "0x17000EF2")]
			public int excptCode
			{
				[Token(Token = "0x6007DB6")]
				[Address(RVA = "0x2841A20", Offset = "0x2840620", VA = "0x182841A20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06007DB7 RID: 32183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB7")]
			[Address(RVA = "0x28419F0", Offset = "0x28405F0", VA = "0x1828419F0")]
			public void Clear()
			{
			}

			// Token: 0x06007DB8 RID: 32184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB8")]
			[Address(RVA = "0x2841A10", Offset = "0x2840610", VA = "0x182841A10")]
			public void SetException(BattleProtocol.GameSettleException exception, int param)
			{
			}

			// Token: 0x04007EC4 RID: 32452
			[Token(Token = "0x4007EC4")]
			[FieldOffset(Offset = "0x0")]
			public byte result;

			// Token: 0x04007EC5 RID: 32453
			[Token(Token = "0x4007EC5")]
			[FieldOffset(Offset = "0x1")]
			public bool hasSettle;

			// Token: 0x04007EC6 RID: 32454
			[Token(Token = "0x4007EC6")]
			[FieldOffset(Offset = "0x8")]
			public long startTs;

			// Token: 0x04007EC7 RID: 32455
			[Token(Token = "0x4007EC7")]
			[FieldOffset(Offset = "0x10")]
			public long endTs;

			// Token: 0x04007EC8 RID: 32456
			[Token(Token = "0x4007EC8")]
			[FieldOffset(Offset = "0x18")]
			public BattleProtocol.GameSettleException excpt;

			// Token: 0x04007EC9 RID: 32457
			[Token(Token = "0x4007EC9")]
			[FieldOffset(Offset = "0x1C")]
			public int excptParam;
		}

		// Token: 0x0200158C RID: 5516
		[Token(Token = "0x200158C")]
		public enum GameSettleException
		{
			// Token: 0x04007ECB RID: 32459
			[Token(Token = "0x4007ECB")]
			NONE,
			// Token: 0x04007ECC RID: 32460
			[Token(Token = "0x4007ECC")]
			REPLAY,
			// Token: 0x04007ECD RID: 32461
			[Token(Token = "0x4007ECD")]
			PASSIVE_SETTLE,
			// Token: 0x04007ECE RID: 32462
			[Token(Token = "0x4007ECE")]
			END_BY_SERVER,
			// Token: 0x04007ECF RID: 32463
			[Token(Token = "0x4007ECF")]
			RECONNECT_FAILED
		}
	}
}
