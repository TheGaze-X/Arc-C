using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using Torappu.UI;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x02001591 RID: 5521
	[Token(Token = "0x2001591")]
	public static class TeamProtocol
	{
		// Token: 0x06007DBF RID: 32191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBF")]
		[Address(RVA = "0x284EEF0", Offset = "0x284DAF0", VA = "0x18284EEF0")]
		public static void Register(ProtocolSuite suite)
		{
		}

		// Token: 0x02001592 RID: 5522
		[Token(Token = "0x2001592")]
		public class TeamJoin : Protocol
		{
			// Token: 0x06007DC0 RID: 32192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC0")]
			[Address(RVA = "0x284EB80", Offset = "0x284D780", VA = "0x18284EB80")]
			public TeamJoin()
			{
			}

			// Token: 0x06007DC1 RID: 32193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC1")]
			[Address(RVA = "0x284EAB0", Offset = "0x284D6B0", VA = "0x18284EAB0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DC2 RID: 32194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC2")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007EE1 RID: 32481
			[Token(Token = "0x4007EE1")]
			public const uint ID = 601U;

			// Token: 0x04007EE2 RID: 32482
			[Token(Token = "0x4007EE2")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007EE3 RID: 32483
			[Token(Token = "0x4007EE3")]
			[FieldOffset(Offset = "0x20")]
			public string teamID;

			// Token: 0x04007EE4 RID: 32484
			[Token(Token = "0x4007EE4")]
			[FieldOffset(Offset = "0x28")]
			public string token;

			// Token: 0x04007EE5 RID: 32485
			[Token(Token = "0x4007EE5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EE6 RID: 32486
			[Token(Token = "0x4007EE6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001593 RID: 5523
		[Token(Token = "0x2001593")]
		public class TeamJoinRet : Protocol
		{
			// Token: 0x06007DC3 RID: 32195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC3")]
			[Address(RVA = "0x284EA40", Offset = "0x284D640", VA = "0x18284EA40")]
			public TeamJoinRet()
			{
			}

			// Token: 0x06007DC4 RID: 32196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC4")]
			[Address(RVA = "0x284E970", Offset = "0x284D570", VA = "0x18284E970", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DC5 RID: 32197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC5")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EE7 RID: 32487
			[Token(Token = "0x4007EE7")]
			public const uint ID = 602U;

			// Token: 0x04007EE8 RID: 32488
			[Token(Token = "0x4007EE8")]
			[FieldOffset(Offset = "0x18")]
			public GeneralProtocol.RetCode retCode;

			// Token: 0x04007EE9 RID: 32489
			[Token(Token = "0x4007EE9")]
			[FieldOffset(Offset = "0x20")]
			public string reason;

			// Token: 0x04007EEA RID: 32490
			[Token(Token = "0x4007EEA")]
			[FieldOffset(Offset = "0x28")]
			public long svrTime;

			// Token: 0x04007EEB RID: 32491
			[Token(Token = "0x4007EEB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EEC RID: 32492
			[Token(Token = "0x4007EEC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001594 RID: 5524
		[Token(Token = "0x2001594")]
		public class TeamLeave : Protocol
		{
			// Token: 0x06007DC6 RID: 32198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC6")]
			[Address(RVA = "0x284EE80", Offset = "0x284DA80", VA = "0x18284EE80")]
			public TeamLeave()
			{
			}

			// Token: 0x04007EED RID: 32493
			[Token(Token = "0x4007EED")]
			public const uint ID = 603U;

			// Token: 0x04007EEE RID: 32494
			[Token(Token = "0x4007EEE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001595 RID: 5525
		[Token(Token = "0x2001595")]
		public class TeamLeaveRet : Protocol
		{
			// Token: 0x06007DC7 RID: 32199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC7")]
			[Address(RVA = "0x284EE10", Offset = "0x284DA10", VA = "0x18284EE10")]
			public TeamLeaveRet()
			{
			}

			// Token: 0x04007EEF RID: 32495
			[Token(Token = "0x4007EEF")]
			public const uint ID = 604U;

			// Token: 0x04007EF0 RID: 32496
			[Token(Token = "0x4007EF0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001596 RID: 5526
		[Token(Token = "0x2001596")]
		public class TeamReady : Protocol
		{
			// Token: 0x06007DC8 RID: 32200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC8")]
			[Address(RVA = "0x284F5C0", Offset = "0x284E1C0", VA = "0x18284F5C0")]
			public TeamReady()
			{
			}

			// Token: 0x06007DC9 RID: 32201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC9")]
			[Address(RVA = "0x284F520", Offset = "0x284E120", VA = "0x18284F520", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DCA RID: 32202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCA")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007EF1 RID: 32497
			[Token(Token = "0x4007EF1")]
			public const uint ID = 605U;

			// Token: 0x04007EF2 RID: 32498
			[Token(Token = "0x4007EF2")]
			[FieldOffset(Offset = "0x18")]
			public bool ready;

			// Token: 0x04007EF3 RID: 32499
			[Token(Token = "0x4007EF3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EF4 RID: 32500
			[Token(Token = "0x4007EF4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02001597 RID: 5527
		[Token(Token = "0x2001597")]
		public class TeamSceneStartRet : Protocol
		{
			// Token: 0x06007DCB RID: 32203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCB")]
			[Address(RVA = "0x284F6E0", Offset = "0x284E2E0", VA = "0x18284F6E0")]
			public TeamSceneStartRet()
			{
			}

			// Token: 0x06007DCC RID: 32204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCC")]
			[Address(RVA = "0x284F630", Offset = "0x284E230", VA = "0x18284F630", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DCD RID: 32205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCD")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EF5 RID: 32501
			[Token(Token = "0x4007EF5")]
			public const uint ID = 610U;

			// Token: 0x04007EF6 RID: 32502
			[Token(Token = "0x4007EF6")]
			[FieldOffset(Offset = "0x18")]
			public GeneralProtocol.RetCode retCode;

			// Token: 0x04007EF7 RID: 32503
			[Token(Token = "0x4007EF7")]
			[FieldOffset(Offset = "0x20")]
			public TeamProtocol.STSceneInfo sceneInfo;

			// Token: 0x04007EF8 RID: 32504
			[Token(Token = "0x4007EF8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EF9 RID: 32505
			[Token(Token = "0x4007EF9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001598 RID: 5528
		[Token(Token = "0x2001598")]
		public class TeamStatusRet : Protocol
		{
			// Token: 0x06007DCE RID: 32206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCE")]
			[Address(RVA = "0x2852BC0", Offset = "0x28517C0", VA = "0x182852BC0")]
			public TeamStatusRet()
			{
			}

			// Token: 0x06007DCF RID: 32207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCF")]
			[Address(RVA = "0x2852B40", Offset = "0x2851740", VA = "0x182852B40", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DD0 RID: 32208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD0")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007EFA RID: 32506
			[Token(Token = "0x4007EFA")]
			public const uint ID = 612U;

			// Token: 0x04007EFB RID: 32507
			[Token(Token = "0x4007EFB")]
			[FieldOffset(Offset = "0x18")]
			public TeamProtocol.STTeamStatus status;

			// Token: 0x04007EFC RID: 32508
			[Token(Token = "0x4007EFC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007EFD RID: 32509
			[Token(Token = "0x4007EFD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02001599 RID: 5529
		[Token(Token = "0x2001599")]
		public class TeamChat : Protocol
		{
			// Token: 0x06007DD1 RID: 32209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD1")]
			[Address(RVA = "0x284DBB0", Offset = "0x284C7B0", VA = "0x18284DBB0")]
			public TeamChat()
			{
			}

			// Token: 0x06007DD2 RID: 32210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD2")]
			[Address(RVA = "0x284DB00", Offset = "0x284C700", VA = "0x18284DB00", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DD3 RID: 32211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD3")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007EFE RID: 32510
			[Token(Token = "0x4007EFE")]
			public const uint ID = 615U;

			// Token: 0x04007EFF RID: 32511
			[Token(Token = "0x4007EFF")]
			[FieldOffset(Offset = "0x18")]
			public string emoticonThemeId;

			// Token: 0x04007F00 RID: 32512
			[Token(Token = "0x4007F00")]
			[FieldOffset(Offset = "0x20")]
			public string emojiChatId;

			// Token: 0x04007F01 RID: 32513
			[Token(Token = "0x4007F01")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F02 RID: 32514
			[Token(Token = "0x4007F02")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200159A RID: 5530
		[Token(Token = "0x200159A")]
		public class TeamChatRet : Protocol
		{
			// Token: 0x06007DD4 RID: 32212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD4")]
			[Address(RVA = "0x284DA90", Offset = "0x284C690", VA = "0x18284DA90")]
			public TeamChatRet()
			{
			}

			// Token: 0x06007DD5 RID: 32213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD5")]
			[Address(RVA = "0x284D9A0", Offset = "0x284C5A0", VA = "0x18284D9A0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DD6 RID: 32214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD6")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F03 RID: 32515
			[Token(Token = "0x4007F03")]
			public const uint ID = 616U;

			// Token: 0x04007F04 RID: 32516
			[Token(Token = "0x4007F04")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F05 RID: 32517
			[Token(Token = "0x4007F05")]
			[FieldOffset(Offset = "0x20")]
			public string emoticonThemeId;

			// Token: 0x04007F06 RID: 32518
			[Token(Token = "0x4007F06")]
			[FieldOffset(Offset = "0x28")]
			public string emojiChatId;

			// Token: 0x04007F07 RID: 32519
			[Token(Token = "0x4007F07")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F08 RID: 32520
			[Token(Token = "0x4007F08")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200159B RID: 5531
		[Token(Token = "0x200159B")]
		public class TeamKick : Protocol
		{
			// Token: 0x06007DD7 RID: 32215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD7")]
			[Address(RVA = "0x284EDA0", Offset = "0x284D9A0", VA = "0x18284EDA0")]
			public TeamKick()
			{
			}

			// Token: 0x06007DD8 RID: 32216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD8")]
			[Address(RVA = "0x284ED00", Offset = "0x284D900", VA = "0x18284ED00", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DD9 RID: 32217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD9")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F09 RID: 32521
			[Token(Token = "0x4007F09")]
			public const uint ID = 617U;

			// Token: 0x04007F0A RID: 32522
			[Token(Token = "0x4007F0A")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F0B RID: 32523
			[Token(Token = "0x4007F0B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F0C RID: 32524
			[Token(Token = "0x4007F0C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200159C RID: 5532
		[Token(Token = "0x200159C")]
		public class TeamKickRet : Protocol
		{
			// Token: 0x06007DDA RID: 32218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDA")]
			[Address(RVA = "0x284EC90", Offset = "0x284D890", VA = "0x18284EC90")]
			public TeamKickRet()
			{
			}

			// Token: 0x06007DDB RID: 32219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDB")]
			[Address(RVA = "0x284EBF0", Offset = "0x284D7F0", VA = "0x18284EBF0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DDC RID: 32220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDC")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F0D RID: 32525
			[Token(Token = "0x4007F0D")]
			public const uint ID = 618U;

			// Token: 0x04007F0E RID: 32526
			[Token(Token = "0x4007F0E")]
			[FieldOffset(Offset = "0x18")]
			public TeamProtocol.TeamKickRet.Oprt opr;

			// Token: 0x04007F0F RID: 32527
			[Token(Token = "0x4007F0F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F10 RID: 32528
			[Token(Token = "0x4007F10")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;

			// Token: 0x0200159D RID: 5533
			[Token(Token = "0x200159D")]
			public enum Oprt
			{
				// Token: 0x04007F12 RID: 32530
				[Token(Token = "0x4007F12")]
				DISBAND,
				// Token: 0x04007F13 RID: 32531
				[Token(Token = "0x4007F13")]
				DISLIKE,
				// Token: 0x04007F14 RID: 32532
				[Token(Token = "0x4007F14")]
				TIMEOUT
			}
		}

		// Token: 0x0200159E RID: 5534
		[Token(Token = "0x200159E")]
		public class TeamTurnPick : Protocol
		{
			// Token: 0x06007DDD RID: 32221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDD")]
			[Address(RVA = "0x2852F10", Offset = "0x2851B10", VA = "0x182852F10")]
			public TeamTurnPick()
			{
			}

			// Token: 0x06007DDE RID: 32222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDE")]
			[Address(RVA = "0x2852E60", Offset = "0x2851A60", VA = "0x182852E60", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DDF RID: 32223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDF")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F15 RID: 32533
			[Token(Token = "0x4007F15")]
			public const uint ID = 619U;

			// Token: 0x04007F16 RID: 32534
			[Token(Token = "0x4007F16")]
			[FieldOffset(Offset = "0x18")]
			public int charInstId;

			// Token: 0x04007F17 RID: 32535
			[Token(Token = "0x4007F17")]
			[FieldOffset(Offset = "0x1C")]
			public bool skip;

			// Token: 0x04007F18 RID: 32536
			[Token(Token = "0x4007F18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F19 RID: 32537
			[Token(Token = "0x4007F19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200159F RID: 5535
		[Token(Token = "0x200159F")]
		public class TeamTurnPickRet : Protocol
		{
			// Token: 0x06007DE0 RID: 32224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE0")]
			[Address(RVA = "0x2852D20", Offset = "0x2851920", VA = "0x182852D20")]
			public TeamTurnPickRet()
			{
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x00037920 File Offset: 0x00035B20
			// (set) Token: 0x06007DE2 RID: 32226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF3")]
			public int charInstId
			{
				[Token(Token = "0x6007DE1")]
				[Address(RVA = "0x2852D90", Offset = "0x2851990", VA = "0x182852D90")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007DE2")]
				[Address(RVA = "0x2852DF0", Offset = "0x28519F0", VA = "0x182852DF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007DE3 RID: 32227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE3")]
			[Address(RVA = "0x2852C30", Offset = "0x2851830", VA = "0x182852C30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DE4 RID: 32228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE4")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F1A RID: 32538
			[Token(Token = "0x4007F1A")]
			public const uint ID = 620U;

			// Token: 0x04007F1C RID: 32540
			[Token(Token = "0x4007F1C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F1D RID: 32541
			[Token(Token = "0x4007F1D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_charInstId;

			// Token: 0x04007F1E RID: 32542
			[Token(Token = "0x4007F1E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_charInstId;

			// Token: 0x04007F1F RID: 32543
			[Token(Token = "0x4007F1F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015A0 RID: 5536
		[Token(Token = "0x20015A0")]
		public class TeamConfirmSquad : Protocol
		{
			// Token: 0x06007DE5 RID: 32229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE5")]
			[Address(RVA = "0x284E140", Offset = "0x284CD40", VA = "0x18284E140")]
			public TeamConfirmSquad()
			{
			}

			// Token: 0x06007DE6 RID: 32230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE6")]
			[Address(RVA = "0x284E080", Offset = "0x284CC80", VA = "0x18284E080", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DE7 RID: 32231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE7")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F20 RID: 32544
			[Token(Token = "0x4007F20")]
			public const uint ID = 621U;

			// Token: 0x04007F21 RID: 32545
			[Token(Token = "0x4007F21")]
			[FieldOffset(Offset = "0x18")]
			public List<TeamProtocol.STConfirmSquadParam> squad;

			// Token: 0x04007F22 RID: 32546
			[Token(Token = "0x4007F22")]
			[FieldOffset(Offset = "0x20")]
			public bool isEmergency;

			// Token: 0x04007F23 RID: 32547
			[Token(Token = "0x4007F23")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F24 RID: 32548
			[Token(Token = "0x4007F24")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A1 RID: 5537
		[Token(Token = "0x20015A1")]
		public class TeamConfirmSquadRet : Protocol
		{
			// Token: 0x06007DE8 RID: 32232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE8")]
			[Address(RVA = "0x284E010", Offset = "0x284CC10", VA = "0x18284E010")]
			public TeamConfirmSquadRet()
			{
			}

			// Token: 0x06007DE9 RID: 32233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE9")]
			[Address(RVA = "0x284DF80", Offset = "0x284CB80", VA = "0x18284DF80", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DEA RID: 32234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DEA")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F25 RID: 32549
			[Token(Token = "0x4007F25")]
			public const uint ID = 622U;

			// Token: 0x04007F26 RID: 32550
			[Token(Token = "0x4007F26")]
			[FieldOffset(Offset = "0x18")]
			public bool isEmergency;

			// Token: 0x04007F27 RID: 32551
			[Token(Token = "0x4007F27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F28 RID: 32552
			[Token(Token = "0x4007F28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015A2 RID: 5538
		[Token(Token = "0x20015A2")]
		public class TeamSquadReady : Protocol
		{
			// Token: 0x06007DEB RID: 32235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DEB")]
			[Address(RVA = "0x2852AD0", Offset = "0x28516D0", VA = "0x182852AD0")]
			public TeamSquadReady()
			{
			}

			// Token: 0x06007DEC RID: 32236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DEC")]
			[Address(RVA = "0x2852A40", Offset = "0x2851640", VA = "0x182852A40", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DED RID: 32237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DED")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F29 RID: 32553
			[Token(Token = "0x4007F29")]
			public const uint ID = 623U;

			// Token: 0x04007F2A RID: 32554
			[Token(Token = "0x4007F2A")]
			[FieldOffset(Offset = "0x18")]
			public bool isReady;

			// Token: 0x04007F2B RID: 32555
			[Token(Token = "0x4007F2B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F2C RID: 32556
			[Token(Token = "0x4007F2C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A3 RID: 5539
		[Token(Token = "0x20015A3")]
		public class TeamChooseStage : Protocol
		{
			// Token: 0x06007DEE RID: 32238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DEE")]
			[Address(RVA = "0x284DF10", Offset = "0x284CB10", VA = "0x18284DF10")]
			public TeamChooseStage()
			{
			}

			// Token: 0x06007DEF RID: 32239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DEF")]
			[Address(RVA = "0x284DE60", Offset = "0x284CA60", VA = "0x18284DE60", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DF0 RID: 32240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF0")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F2D RID: 32557
			[Token(Token = "0x4007F2D")]
			public const uint ID = 625U;

			// Token: 0x04007F2E RID: 32558
			[Token(Token = "0x4007F2E")]
			[FieldOffset(Offset = "0x18")]
			public sbyte isStageRandom;

			// Token: 0x04007F2F RID: 32559
			[Token(Token = "0x4007F2F")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x04007F30 RID: 32560
			[Token(Token = "0x4007F30")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F31 RID: 32561
			[Token(Token = "0x4007F31")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A4 RID: 5540
		[Token(Token = "0x20015A4")]
		public class TeamChooseStageDn : Protocol
		{
			// Token: 0x06007DF1 RID: 32241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF1")]
			[Address(RVA = "0x284DDF0", Offset = "0x284C9F0", VA = "0x18284DDF0")]
			public TeamChooseStageDn()
			{
			}

			// Token: 0x06007DF2 RID: 32242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF2")]
			[Address(RVA = "0x284DD30", Offset = "0x284C930", VA = "0x18284DD30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DF3 RID: 32243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF3")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F32 RID: 32562
			[Token(Token = "0x4007F32")]
			public const int ID = 626;

			// Token: 0x04007F33 RID: 32563
			[Token(Token = "0x4007F33")]
			[FieldOffset(Offset = "0x18")]
			public sbyte isStageRandom;

			// Token: 0x04007F34 RID: 32564
			[Token(Token = "0x4007F34")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x04007F35 RID: 32565
			[Token(Token = "0x4007F35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F36 RID: 32566
			[Token(Token = "0x4007F36")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015A5 RID: 5541
		[Token(Token = "0x20015A5")]
		public class TeamChoosePos : Protocol
		{
			// Token: 0x06007DF4 RID: 32244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF4")]
			[Address(RVA = "0x284DCC0", Offset = "0x284C8C0", VA = "0x18284DCC0")]
			public TeamChoosePos()
			{
			}

			// Token: 0x06007DF5 RID: 32245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF5")]
			[Address(RVA = "0x284DC20", Offset = "0x284C820", VA = "0x18284DC20", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DF6 RID: 32246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF6")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F37 RID: 32567
			[Token(Token = "0x4007F37")]
			public const int ID = 627;

			// Token: 0x04007F38 RID: 32568
			[Token(Token = "0x4007F38")]
			[FieldOffset(Offset = "0x18")]
			public sbyte pos;

			// Token: 0x04007F39 RID: 32569
			[Token(Token = "0x4007F39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F3A RID: 32570
			[Token(Token = "0x4007F3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A6 RID: 5542
		[Token(Token = "0x20015A6")]
		public class TeamReadyInRoom : Protocol
		{
			// Token: 0x06007DF7 RID: 32247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF7")]
			[Address(RVA = "0x284F4B0", Offset = "0x284E0B0", VA = "0x18284F4B0")]
			public TeamReadyInRoom()
			{
			}

			// Token: 0x06007DF8 RID: 32248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF8")]
			[Address(RVA = "0x284F420", Offset = "0x284E020", VA = "0x18284F420", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DF9 RID: 32249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF9")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F3B RID: 32571
			[Token(Token = "0x4007F3B")]
			public const int ID = 629;

			// Token: 0x04007F3C RID: 32572
			[Token(Token = "0x4007F3C")]
			[FieldOffset(Offset = "0x18")]
			public bool isReady;

			// Token: 0x04007F3D RID: 32573
			[Token(Token = "0x4007F3D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F3E RID: 32574
			[Token(Token = "0x4007F3E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A7 RID: 5543
		[Token(Token = "0x20015A7")]
		public class TeamGetNameCard : Protocol
		{
			// Token: 0x06007DFA RID: 32250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFA")]
			[Address(RVA = "0x284E480", Offset = "0x284D080", VA = "0x18284E480")]
			public TeamGetNameCard()
			{
			}

			// Token: 0x06007DFB RID: 32251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFB")]
			[Address(RVA = "0x284E3E0", Offset = "0x284CFE0", VA = "0x18284E3E0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007DFC RID: 32252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFC")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F3F RID: 32575
			[Token(Token = "0x4007F3F")]
			public const int ID = 631;

			// Token: 0x04007F40 RID: 32576
			[Token(Token = "0x4007F40")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F41 RID: 32577
			[Token(Token = "0x4007F41")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F42 RID: 32578
			[Token(Token = "0x4007F42")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015A8 RID: 5544
		[Token(Token = "0x20015A8")]
		public class TeamGetNameCardRet : Protocol
		{
			// Token: 0x06007DFD RID: 32253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFD")]
			[Address(RVA = "0x284E290", Offset = "0x284CE90", VA = "0x18284E290")]
			public TeamGetNameCardRet()
			{
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x06007DFE RID: 32254 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007DFF RID: 32255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF4")]
			public string nameCardJson
			{
				[Token(Token = "0x6007DFE")]
				[Address(RVA = "0x284E300", Offset = "0x284CF00", VA = "0x18284E300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007DFF")]
				[Address(RVA = "0x284E360", Offset = "0x284CF60", VA = "0x18284E360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007E00 RID: 32256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E00")]
			[Address(RVA = "0x284E1B0", Offset = "0x284CDB0", VA = "0x18284E1B0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E01 RID: 32257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E01")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F43 RID: 32579
			[Token(Token = "0x4007F43")]
			public const int ID = 632;

			// Token: 0x04007F45 RID: 32581
			[Token(Token = "0x4007F45")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F46 RID: 32582
			[Token(Token = "0x4007F46")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_nameCardJson;

			// Token: 0x04007F47 RID: 32583
			[Token(Token = "0x4007F47")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_nameCardJson;

			// Token: 0x04007F48 RID: 32584
			[Token(Token = "0x4007F48")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015A9 RID: 5545
		[Token(Token = "0x20015A9")]
		public class TeamSetCharSlotUp : Protocol
		{
			// Token: 0x06007E02 RID: 32258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E02")]
			[Address(RVA = "0x28529D0", Offset = "0x28515D0", VA = "0x1828529D0")]
			public TeamSetCharSlotUp()
			{
			}

			// Token: 0x06007E03 RID: 32259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E03")]
			[Address(RVA = "0x2852920", Offset = "0x2851520", VA = "0x182852920", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007E04 RID: 32260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E04")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F49 RID: 32585
			[Token(Token = "0x4007F49")]
			public const uint ID = 635U;

			// Token: 0x04007F4A RID: 32586
			[Token(Token = "0x4007F4A")]
			[FieldOffset(Offset = "0x18")]
			public int instId;

			// Token: 0x04007F4B RID: 32587
			[Token(Token = "0x4007F4B")]
			[FieldOffset(Offset = "0x1C")]
			public bool inSquad;

			// Token: 0x04007F4C RID: 32588
			[Token(Token = "0x4007F4C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F4D RID: 32589
			[Token(Token = "0x4007F4D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015AA RID: 5546
		[Token(Token = "0x20015AA")]
		public class TeamSetCharSlotRet : Protocol
		{
			// Token: 0x06007E05 RID: 32261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E05")]
			[Address(RVA = "0x28528B0", Offset = "0x28514B0", VA = "0x1828528B0")]
			public TeamSetCharSlotRet()
			{
			}

			// Token: 0x06007E06 RID: 32262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E06")]
			[Address(RVA = "0x2852800", Offset = "0x2851400", VA = "0x182852800", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E07 RID: 32263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E07")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F4E RID: 32590
			[Token(Token = "0x4007F4E")]
			public const int ID = 636;

			// Token: 0x04007F4F RID: 32591
			[Token(Token = "0x4007F4F")]
			[FieldOffset(Offset = "0x18")]
			public int instId;

			// Token: 0x04007F50 RID: 32592
			[Token(Token = "0x4007F50")]
			[FieldOffset(Offset = "0x1C")]
			public bool inSquad;

			// Token: 0x04007F51 RID: 32593
			[Token(Token = "0x4007F51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F52 RID: 32594
			[Token(Token = "0x4007F52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015AB RID: 5547
		[Token(Token = "0x20015AB")]
		public class SwitchReverseUp : Protocol
		{
			// Token: 0x06007E08 RID: 32264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E08")]
			[Address(RVA = "0x284D930", Offset = "0x284C530", VA = "0x18284D930")]
			public SwitchReverseUp()
			{
			}

			// Token: 0x06007E09 RID: 32265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E09")]
			[Address(RVA = "0x284D8A0", Offset = "0x284C4A0", VA = "0x18284D8A0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007E0A RID: 32266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0A")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F53 RID: 32595
			[Token(Token = "0x4007F53")]
			public const uint ID = 637U;

			// Token: 0x04007F54 RID: 32596
			[Token(Token = "0x4007F54")]
			[FieldOffset(Offset = "0x18")]
			public bool reverse;

			// Token: 0x04007F55 RID: 32597
			[Token(Token = "0x4007F55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F56 RID: 32598
			[Token(Token = "0x4007F56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015AC RID: 5548
		[Token(Token = "0x20015AC")]
		public class SwitchReverseDn : Protocol
		{
			// Token: 0x06007E0B RID: 32267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0B")]
			[Address(RVA = "0x284D830", Offset = "0x284C430", VA = "0x18284D830")]
			public SwitchReverseDn()
			{
			}

			// Token: 0x06007E0C RID: 32268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0C")]
			[Address(RVA = "0x284D7A0", Offset = "0x284C3A0", VA = "0x18284D7A0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E0D RID: 32269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F57 RID: 32599
			[Token(Token = "0x4007F57")]
			public const int ID = 638;

			// Token: 0x04007F58 RID: 32600
			[Token(Token = "0x4007F58")]
			[FieldOffset(Offset = "0x18")]
			public bool reverse;

			// Token: 0x04007F59 RID: 32601
			[Token(Token = "0x4007F59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F5A RID: 32602
			[Token(Token = "0x4007F5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015AD RID: 5549
		[Token(Token = "0x20015AD")]
		public class SettleLikeUp : Protocol
		{
			// Token: 0x06007E0E RID: 32270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0E")]
			[Address(RVA = "0x284D190", Offset = "0x284BD90", VA = "0x18284D190")]
			public SettleLikeUp()
			{
			}

			// Token: 0x06007E0F RID: 32271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E0F")]
			[Address(RVA = "0x284D0F0", Offset = "0x284BCF0", VA = "0x18284D0F0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007E10 RID: 32272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E10")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F5B RID: 32603
			[Token(Token = "0x4007F5B")]
			public const uint ID = 639U;

			// Token: 0x04007F5C RID: 32604
			[Token(Token = "0x4007F5C")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F5D RID: 32605
			[Token(Token = "0x4007F5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F5E RID: 32606
			[Token(Token = "0x4007F5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015AE RID: 5550
		[Token(Token = "0x20015AE")]
		public class SettleLikeDn : Protocol
		{
			// Token: 0x06007E11 RID: 32273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E11")]
			[Address(RVA = "0x284D080", Offset = "0x284BC80", VA = "0x18284D080")]
			public SettleLikeDn()
			{
			}

			// Token: 0x06007E12 RID: 32274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E12")]
			[Address(RVA = "0x284CFE0", Offset = "0x284BBE0", VA = "0x18284CFE0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E13 RID: 32275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E13")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F5F RID: 32607
			[Token(Token = "0x4007F5F")]
			public const int ID = 640;

			// Token: 0x04007F60 RID: 32608
			[Token(Token = "0x4007F60")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F61 RID: 32609
			[Token(Token = "0x4007F61")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F62 RID: 32610
			[Token(Token = "0x4007F62")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015AF RID: 5551
		[Token(Token = "0x20015AF")]
		public class BattleContinueUp : Protocol
		{
			// Token: 0x06007E14 RID: 32276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E14")]
			[Address(RVA = "0x283CE90", Offset = "0x283BA90", VA = "0x18283CE90")]
			public BattleContinueUp()
			{
			}

			// Token: 0x06007E15 RID: 32277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E15")]
			[Address(RVA = "0x283CE30", Offset = "0x283BA30", VA = "0x18283CE30", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007E16 RID: 32278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E16")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007F63 RID: 32611
			[Token(Token = "0x4007F63")]
			public const uint ID = 641U;

			// Token: 0x04007F64 RID: 32612
			[Token(Token = "0x4007F64")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F65 RID: 32613
			[Token(Token = "0x4007F65")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020015B0 RID: 5552
		[Token(Token = "0x20015B0")]
		public class PlayerStateDn : Protocol
		{
			// Token: 0x06007E17 RID: 32279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E17")]
			[Address(RVA = "0x284A990", Offset = "0x2849590", VA = "0x18284A990")]
			public PlayerStateDn()
			{
			}

			// Token: 0x06007E18 RID: 32280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E18")]
			[Address(RVA = "0x284A8D0", Offset = "0x28494D0", VA = "0x18284A8D0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E19 RID: 32281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E19")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F66 RID: 32614
			[Token(Token = "0x4007F66")]
			public const int ID = 644;

			// Token: 0x04007F67 RID: 32615
			[Token(Token = "0x4007F67")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F68 RID: 32616
			[Token(Token = "0x4007F68")]
			[FieldOffset(Offset = "0x20")]
			public TeamProtocol.TeamMemberState state;

			// Token: 0x04007F69 RID: 32617
			[Token(Token = "0x4007F69")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F6A RID: 32618
			[Token(Token = "0x4007F6A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015B1 RID: 5553
		[Token(Token = "0x20015B1")]
		public class PlayerConnStateDn : Protocol
		{
			// Token: 0x06007E1A RID: 32282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1A")]
			[Address(RVA = "0x284A4A0", Offset = "0x28490A0", VA = "0x18284A4A0")]
			public PlayerConnStateDn()
			{
			}

			// Token: 0x06007E1B RID: 32283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1B")]
			[Address(RVA = "0x284A3E0", Offset = "0x2848FE0", VA = "0x18284A3E0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007E1C RID: 32284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1C")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007F6B RID: 32619
			[Token(Token = "0x4007F6B")]
			public const int ID = 646;

			// Token: 0x04007F6C RID: 32620
			[Token(Token = "0x4007F6C")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04007F6D RID: 32621
			[Token(Token = "0x4007F6D")]
			[FieldOffset(Offset = "0x20")]
			public bool offline;

			// Token: 0x04007F6E RID: 32622
			[Token(Token = "0x4007F6E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007F6F RID: 32623
			[Token(Token = "0x4007F6F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020015B2 RID: 5554
		[Token(Token = "0x20015B2")]
		public enum TeamMemberRole
		{
			// Token: 0x04007F71 RID: 32625
			[Token(Token = "0x4007F71")]
			LEADER,
			// Token: 0x04007F72 RID: 32626
			[Token(Token = "0x4007F72")]
			MEMBER
		}

		// Token: 0x020015B3 RID: 5555
		[Token(Token = "0x20015B3")]
		public enum TeamMemberState
		{
			// Token: 0x04007F74 RID: 32628
			[Token(Token = "0x4007F74")]
			STAGE_NOTREADY,
			// Token: 0x04007F75 RID: 32629
			[Token(Token = "0x4007F75")]
			STAGE_READY,
			// Token: 0x04007F76 RID: 32630
			[Token(Token = "0x4007F76")]
			SHOW_NOTREADY,
			// Token: 0x04007F77 RID: 32631
			[Token(Token = "0x4007F77")]
			SHOW_READY,
			// Token: 0x04007F78 RID: 32632
			[Token(Token = "0x4007F78")]
			CHAR_ASSIGN,
			// Token: 0x04007F79 RID: 32633
			[Token(Token = "0x4007F79")]
			SQUAD_UP_ONCE,
			// Token: 0x04007F7A RID: 32634
			[Token(Token = "0x4007F7A")]
			SQUAD_READY,
			// Token: 0x04007F7B RID: 32635
			[Token(Token = "0x4007F7B")]
			IN_BATTLE,
			// Token: 0x04007F7C RID: 32636
			[Token(Token = "0x4007F7C")]
			IN_SETTLE
		}

		// Token: 0x020015B4 RID: 5556
		[Token(Token = "0x20015B4")]
		public enum TeamState
		{
			// Token: 0x04007F7E RID: 32638
			[Token(Token = "0x4007F7E")]
			INIT,
			// Token: 0x04007F7F RID: 32639
			[Token(Token = "0x4007F7F")]
			NONE = 0,
			// Token: 0x04007F80 RID: 32640
			[Token(Token = "0x4007F80")]
			[Obsolete("REMOVED")]
			IDLE,
			// Token: 0x04007F81 RID: 32641
			[Token(Token = "0x4007F81")]
			STAGE_PREPARE = 1,
			// Token: 0x04007F82 RID: 32642
			[Token(Token = "0x4007F82")]
			ENTRANCE_SHOW,
			// Token: 0x04007F83 RID: 32643
			[Token(Token = "0x4007F83")]
			CHAR_ASSIGN,
			// Token: 0x04007F84 RID: 32644
			[Token(Token = "0x4007F84")]
			SQUAD,
			// Token: 0x04007F85 RID: 32645
			[Token(Token = "0x4007F85")]
			COUNT_DOWN,
			// Token: 0x04007F86 RID: 32646
			[Token(Token = "0x4007F86")]
			IN_BATTLE,
			// Token: 0x04007F87 RID: 32647
			[Token(Token = "0x4007F87")]
			END
		}

		// Token: 0x020015B5 RID: 5557
		[Token(Token = "0x20015B5")]
		public enum PickFlag
		{
			// Token: 0x04007F89 RID: 32649
			[Token(Token = "0x4007F89")]
			NONE,
			// Token: 0x04007F8A RID: 32650
			[Token(Token = "0x4007F8A")]
			DUP,
			// Token: 0x04007F8B RID: 32651
			[Token(Token = "0x4007F8B")]
			NO_DUP
		}

		// Token: 0x020015B6 RID: 5558
		[Token(Token = "0x20015B6")]
		public enum StageRandomType
		{
			// Token: 0x04007F8D RID: 32653
			[Token(Token = "0x4007F8D")]
			NOT_RANDOM,
			// Token: 0x04007F8E RID: 32654
			[Token(Token = "0x4007F8E")]
			RANDOM,
			// Token: 0x04007F8F RID: 32655
			[Token(Token = "0x4007F8F")]
			HARD_RANDOM,
			// Token: 0x04007F90 RID: 32656
			[Token(Token = "0x4007F90")]
			EXTREMLY_HARD_RANDOM
		}

		// Token: 0x020015B7 RID: 5559
		[Token(Token = "0x20015B7")]
		public struct STTeamStatus
		{
			// Token: 0x06007E1D RID: 32285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1D")]
			[Address(RVA = "0x284C190", Offset = "0x284AD90", VA = "0x18284C190")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x04007F91 RID: 32657
			[Token(Token = "0x4007F91")]
			[FieldOffset(Offset = "0x0")]
			public TeamProtocol.TeamState state;

			// Token: 0x04007F92 RID: 32658
			[Token(Token = "0x4007F92")]
			[FieldOffset(Offset = "0x8")]
			public TeamProtocol.STOwnerStatus owner;

			// Token: 0x04007F93 RID: 32659
			[Token(Token = "0x4007F93")]
			[FieldOffset(Offset = "0x20")]
			public long endTs;

			// Token: 0x04007F94 RID: 32660
			[Token(Token = "0x4007F94")]
			[FieldOffset(Offset = "0x28")]
			public string stageID;

			// Token: 0x04007F95 RID: 32661
			[Token(Token = "0x4007F95")]
			[FieldOffset(Offset = "0x30")]
			public bool reverse;

			// Token: 0x04007F96 RID: 32662
			[Token(Token = "0x4007F96")]
			[FieldOffset(Offset = "0x38")]
			public List<TeamProtocol.STPlayerStatus> players;

			// Token: 0x04007F97 RID: 32663
			[Token(Token = "0x4007F97")]
			[FieldOffset(Offset = "0x40")]
			public TeamProtocol.STSceneInfo sceneInfo;

			// Token: 0x04007F98 RID: 32664
			[Token(Token = "0x4007F98")]
			[FieldOffset(Offset = "0x58")]
			public TeamProtocol.STTurnPickStatus turnPick;
		}

		// Token: 0x020015B8 RID: 5560
		[Token(Token = "0x20015B8")]
		public struct STOwnerStatus
		{
			// Token: 0x06007E1E RID: 32286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1E")]
			[Address(RVA = "0x284B6C0", Offset = "0x284A2C0", VA = "0x18284B6C0")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x04007F99 RID: 32665
			[Token(Token = "0x4007F99")]
			[FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04007F9A RID: 32666
			[Token(Token = "0x4007F9A")]
			[FieldOffset(Offset = "0x8")]
			public sbyte pos;

			// Token: 0x04007F9B RID: 32667
			[Token(Token = "0x4007F9B")]
			[FieldOffset(Offset = "0x9")]
			public sbyte isStageRandom;

			// Token: 0x04007F9C RID: 32668
			[Token(Token = "0x4007F9C")]
			[FieldOffset(Offset = "0x10")]
			public List<string> validStages;
		}

		// Token: 0x020015B9 RID: 5561
		[Token(Token = "0x20015B9")]
		public struct STSceneInfo
		{
			// Token: 0x06007E1F RID: 32287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1F")]
			[Address(RVA = "0x284C0E0", Offset = "0x284ACE0", VA = "0x18284C0E0")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x04007F9D RID: 32669
			[Token(Token = "0x4007F9D")]
			[FieldOffset(Offset = "0x0")]
			public string sceneID;

			// Token: 0x04007F9E RID: 32670
			[Token(Token = "0x4007F9E")]
			[FieldOffset(Offset = "0x8")]
			public string address;

			// Token: 0x04007F9F RID: 32671
			[Token(Token = "0x4007F9F")]
			[FieldOffset(Offset = "0x10")]
			public string token;
		}

		// Token: 0x020015BA RID: 5562
		[Token(Token = "0x20015BA")]
		public struct STTurnPickStatus
		{
			// Token: 0x06007E20 RID: 32288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E20")]
			[Address(RVA = "0x284C2B0", Offset = "0x284AEB0", VA = "0x18284C2B0")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x04007FA0 RID: 32672
			[Token(Token = "0x4007FA0")]
			[FieldOffset(Offset = "0x0")]
			public string currPickUser;

			// Token: 0x04007FA1 RID: 32673
			[Token(Token = "0x4007FA1")]
			[FieldOffset(Offset = "0x8")]
			public sbyte pickCnt;

			// Token: 0x04007FA2 RID: 32674
			[Token(Token = "0x4007FA2")]
			[FieldOffset(Offset = "0x9")]
			public sbyte pickMax;

			// Token: 0x04007FA3 RID: 32675
			[Token(Token = "0x4007FA3")]
			[FieldOffset(Offset = "0xA")]
			public bool mustPick;

			// Token: 0x04007FA4 RID: 32676
			[Token(Token = "0x4007FA4")]
			[FieldOffset(Offset = "0x10")]
			public List<string> overlapSquads;

			// Token: 0x04007FA5 RID: 32677
			[Token(Token = "0x4007FA5")]
			[FieldOffset(Offset = "0x18")]
			public long finishTs;

			// Token: 0x04007FA6 RID: 32678
			[Token(Token = "0x4007FA6")]
			[FieldOffset(Offset = "0x20")]
			public short cdTotalSec;

			// Token: 0x04007FA7 RID: 32679
			[Token(Token = "0x4007FA7")]
			[FieldOffset(Offset = "0x24")]
			public TeamProtocol.PickFlag pickFlag;
		}

		// Token: 0x020015BB RID: 5563
		[Token(Token = "0x20015BB")]
		public class STCharSkill : IStreamDeserialize
		{
			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x06007E21 RID: 32289 RVA: 0x00037938 File Offset: 0x00035B38
			// (set) Token: 0x06007E22 RID: 32290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF5")]
			public int unlock
			{
				[Token(Token = "0x6007E21")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007E22")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x06007E23 RID: 32291 RVA: 0x00037950 File Offset: 0x00035B50
			// (set) Token: 0x06007E24 RID: 32292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF6")]
			public int specializeLevel
			{
				[Token(Token = "0x6007E23")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007E24")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007E25 RID: 32293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E25")]
			[Address(RVA = "0x284B500", Offset = "0x284A100", VA = "0x18284B500", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E26 RID: 32294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E26")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STCharSkill()
			{
			}
		}

		// Token: 0x020015BC RID: 5564
		[Token(Token = "0x20015BC")]
		public class STCharEquip : IStreamDeserialize
		{
			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x06007E27 RID: 32295 RVA: 0x00037968 File Offset: 0x00035B68
			// (set) Token: 0x06007E28 RID: 32296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF7")]
			public int hide
			{
				[Token(Token = "0x6007E27")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007E28")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x06007E29 RID: 32297 RVA: 0x00037980 File Offset: 0x00035B80
			// (set) Token: 0x06007E2A RID: 32298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF8")]
			public int locked
			{
				[Token(Token = "0x6007E29")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007E2A")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x06007E2B RID: 32299 RVA: 0x00037998 File Offset: 0x00035B98
			// (set) Token: 0x06007E2C RID: 32300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF9")]
			public int level
			{
				[Token(Token = "0x6007E2B")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007E2C")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007E2D RID: 32301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E2D")]
			[Address(RVA = "0x284B470", Offset = "0x284A070", VA = "0x18284B470", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E2E RID: 32302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E2E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STCharEquip()
			{
			}
		}

		// Token: 0x020015BD RID: 5565
		[Token(Token = "0x20015BD")]
		public class STBasicChar : IStreamDeserialize
		{
			// Token: 0x06007E2F RID: 32303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E2F")]
			[Address(RVA = "0x284B040", Offset = "0x2849C40", VA = "0x18284B040", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E30 RID: 32304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E30")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STBasicChar()
			{
			}

			// Token: 0x04007FAD RID: 32685
			[Token(Token = "0x4007FAD")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04007FAE RID: 32686
			[Token(Token = "0x4007FAE")]
			[FieldOffset(Offset = "0x14")]
			public int charInstID;

			// Token: 0x04007FAF RID: 32687
			[Token(Token = "0x4007FAF")]
			[FieldOffset(Offset = "0x18")]
			public string charID;

			// Token: 0x04007FB0 RID: 32688
			[Token(Token = "0x4007FB0")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x04007FB1 RID: 32689
			[Token(Token = "0x4007FB1")]
			[FieldOffset(Offset = "0x24")]
			public EvolvePhase evolvePhase;

			// Token: 0x04007FB2 RID: 32690
			[Token(Token = "0x4007FB2")]
			[FieldOffset(Offset = "0x28")]
			public int favorPoint;

			// Token: 0x04007FB3 RID: 32691
			[Token(Token = "0x4007FB3")]
			[FieldOffset(Offset = "0x2C")]
			public int potentialRank;

			// Token: 0x04007FB4 RID: 32692
			[Token(Token = "0x4007FB4")]
			[FieldOffset(Offset = "0x30")]
			public string currentTmpl;

			// Token: 0x04007FB5 RID: 32693
			[Token(Token = "0x4007FB5")]
			[FieldOffset(Offset = "0x38")]
			public int mainSkillLvl;

			// Token: 0x04007FB6 RID: 32694
			[Token(Token = "0x4007FB6")]
			[FieldOffset(Offset = "0x40")]
			public List<TeamProtocol.STCharSkill> skills;

			// Token: 0x04007FB7 RID: 32695
			[Token(Token = "0x4007FB7")]
			[FieldOffset(Offset = "0x48")]
			public int defaultSkillIndex;

			// Token: 0x04007FB8 RID: 32696
			[Token(Token = "0x4007FB8")]
			[FieldOffset(Offset = "0x50")]
			public string currentEquip;

			// Token: 0x04007FB9 RID: 32697
			[Token(Token = "0x4007FB9")]
			[FieldOffset(Offset = "0x58")]
			public ListDict<string, TeamProtocol.STCharEquip> equip;

			// Token: 0x04007FBA RID: 32698
			[Token(Token = "0x4007FBA")]
			[FieldOffset(Offset = "0x60")]
			public string skin;
		}

		// Token: 0x020015BE RID: 5566
		[Token(Token = "0x20015BE")]
		public class STBasicSquad : IStreamDeserialize
		{
			// Token: 0x06007E31 RID: 32305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E31")]
			[Address(RVA = "0x284B3A0", Offset = "0x2849FA0", VA = "0x18284B3A0", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E32 RID: 32306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E32")]
			[Address(RVA = "0x284B240", Offset = "0x2849E40", VA = "0x18284B240")]
			public void DeepCopy(TeamProtocol.STBasicSquad from)
			{
			}

			// Token: 0x06007E33 RID: 32307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E33")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STBasicSquad()
			{
			}

			// Token: 0x04007FBB RID: 32699
			[Token(Token = "0x4007FBB")]
			[FieldOffset(Offset = "0x10")]
			public List<TeamProtocol.STBasicChar> prefer;

			// Token: 0x04007FBC RID: 32700
			[Token(Token = "0x4007FBC")]
			[FieldOffset(Offset = "0x18")]
			public List<TeamProtocol.STBasicChar> backup;

			// Token: 0x04007FBD RID: 32701
			[Token(Token = "0x4007FBD")]
			[FieldOffset(Offset = "0x20")]
			public string buffId;
		}

		// Token: 0x020015BF RID: 5567
		[Token(Token = "0x20015BF")]
		public class STPlayerStatus : IStreamDeserialize, IPlayerStatus, IHotfixable
		{
			// Token: 0x06007E34 RID: 32308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E34")]
			[Address(RVA = "0x284BC20", Offset = "0x284A820", VA = "0x18284BC20", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E35 RID: 32309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E35")]
			[Address(RVA = "0x284BA80", Offset = "0x284A680", VA = "0x18284BA80", Slot = "5")]
			public AvatarInfo GetAvatarInfo()
			{
				return null;
			}

			// Token: 0x06007E36 RID: 32310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E36")]
			[Address(RVA = "0x284BB60", Offset = "0x284A760", VA = "0x18284BB60", Slot = "6")]
			public string GetSecretarySkinId()
			{
				return null;
			}

			// Token: 0x06007E37 RID: 32311 RVA: 0x000379B0 File Offset: 0x00035BB0
			[Token(Token = "0x6007E37")]
			[Address(RVA = "0x284BBC0", Offset = "0x284A7C0", VA = "0x18284BBC0", Slot = "7")]
			public bool GetSecretarySkinSp()
			{
				return default(bool);
			}

			// Token: 0x06007E38 RID: 32312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E38")]
			[Address(RVA = "0x284C030", Offset = "0x284AC30", VA = "0x18284C030")]
			public STPlayerStatus()
			{
			}

			// Token: 0x04007FBE RID: 32702
			[Token(Token = "0x4007FBE")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04007FBF RID: 32703
			[Token(Token = "0x4007FBF")]
			[FieldOffset(Offset = "0x18")]
			public sbyte pos;

			// Token: 0x04007FC0 RID: 32704
			[Token(Token = "0x4007FC0")]
			[FieldOffset(Offset = "0x20")]
			public string nickName;

			// Token: 0x04007FC1 RID: 32705
			[Token(Token = "0x4007FC1")]
			[FieldOffset(Offset = "0x28")]
			public string avatarType;

			// Token: 0x04007FC2 RID: 32706
			[Token(Token = "0x4007FC2")]
			[FieldOffset(Offset = "0x30")]
			public string avatarId;

			// Token: 0x04007FC3 RID: 32707
			[Token(Token = "0x4007FC3")]
			[FieldOffset(Offset = "0x38")]
			public string secretary;

			// Token: 0x04007FC4 RID: 32708
			[Token(Token = "0x4007FC4")]
			[FieldOffset(Offset = "0x40")]
			public string secretarySkinId;

			// Token: 0x04007FC5 RID: 32709
			[Token(Token = "0x4007FC5")]
			[FieldOffset(Offset = "0x48")]
			public bool secretarySkinSp;

			// Token: 0x04007FC6 RID: 32710
			[Token(Token = "0x4007FC6")]
			[FieldOffset(Offset = "0x50")]
			public string nameCardSkinId;

			// Token: 0x04007FC7 RID: 32711
			[Token(Token = "0x4007FC7")]
			[FieldOffset(Offset = "0x58")]
			public int nameCardSkinTmpl;

			// Token: 0x04007FC8 RID: 32712
			[Token(Token = "0x4007FC8")]
			[FieldOffset(Offset = "0x60")]
			public List<string> title;

			// Token: 0x04007FC9 RID: 32713
			[Token(Token = "0x4007FC9")]
			[FieldOffset(Offset = "0x68")]
			public bool isMentor;

			// Token: 0x04007FCA RID: 32714
			[Token(Token = "0x4007FCA")]
			[FieldOffset(Offset = "0x6C")]
			public int level;

			// Token: 0x04007FCB RID: 32715
			[Token(Token = "0x4007FCB")]
			[FieldOffset(Offset = "0x70")]
			public bool settleLike;

			// Token: 0x04007FCC RID: 32716
			[Token(Token = "0x4007FCC")]
			[FieldOffset(Offset = "0x74")]
			public TeamProtocol.TeamMemberState state;

			// Token: 0x04007FCD RID: 32717
			[Token(Token = "0x4007FCD")]
			[FieldOffset(Offset = "0x78")]
			public bool offline;

			// Token: 0x04007FCE RID: 32718
			[Token(Token = "0x4007FCE")]
			[FieldOffset(Offset = "0x79")]
			public bool sentBasicSquad;

			// Token: 0x04007FCF RID: 32719
			[Token(Token = "0x4007FCF")]
			[FieldOffset(Offset = "0x80")]
			public TeamProtocol.STBasicSquad basicSquad;

			// Token: 0x04007FD0 RID: 32720
			[Token(Token = "0x4007FD0")]
			[FieldOffset(Offset = "0x88")]
			public List<int> prefer;

			// Token: 0x04007FD1 RID: 32721
			[Token(Token = "0x4007FD1")]
			[FieldOffset(Offset = "0x90")]
			public List<int> backup;

			// Token: 0x04007FD2 RID: 32722
			[Token(Token = "0x4007FD2")]
			[FieldOffset(Offset = "0x98")]
			public List<int> backupOverlap;

			// Token: 0x04007FD3 RID: 32723
			[Token(Token = "0x4007FD3")]
			[FieldOffset(Offset = "0xA0")]
			public List<TeamProtocol.STNPCChar> allocTemp;

			// Token: 0x04007FD4 RID: 32724
			[Token(Token = "0x4007FD4")]
			[FieldOffset(Offset = "0xA8")]
			public List<TeamProtocol.STPlayerSlot> squad;

			// Token: 0x04007FD5 RID: 32725
			[Token(Token = "0x4007FD5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Read;

			// Token: 0x04007FD6 RID: 32726
			[Token(Token = "0x4007FD6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetAvatarInfo;

			// Token: 0x04007FD7 RID: 32727
			[Token(Token = "0x4007FD7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinId;

			// Token: 0x04007FD8 RID: 32728
			[Token(Token = "0x4007FD8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

			// Token: 0x04007FD9 RID: 32729
			[Token(Token = "0x4007FD9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020015C0 RID: 5568
		[Token(Token = "0x20015C0")]
		public class STNPCChar : IStreamDeserialize
		{
			// Token: 0x06007E39 RID: 32313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E39")]
			[Address(RVA = "0x284B640", Offset = "0x284A240", VA = "0x18284B640", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E3A RID: 32314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STNPCChar()
			{
			}

			// Token: 0x04007FDA RID: 32730
			[Token(Token = "0x4007FDA")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04007FDB RID: 32731
			[Token(Token = "0x4007FDB")]
			[FieldOffset(Offset = "0x18")]
			public string charId;
		}

		// Token: 0x020015C1 RID: 5569
		[Token(Token = "0x20015C1")]
		public class STPlayerSlot : IStreamDeserialize, IStreamSerialize
		{
			// Token: 0x06007E3B RID: 32315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3B")]
			[Address(RVA = "0x284B770", Offset = "0x284A370", VA = "0x18284B770", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x06007E3C RID: 32316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3C")]
			[Address(RVA = "0x284B930", Offset = "0x284A530", VA = "0x18284B930", Slot = "5")]
			public void Write(IStreamWriter to)
			{
			}

			// Token: 0x06007E3D RID: 32317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STPlayerSlot()
			{
			}

			// Token: 0x04007FDC RID: 32732
			[Token(Token = "0x4007FDC")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04007FDD RID: 32733
			[Token(Token = "0x4007FDD")]
			[FieldOffset(Offset = "0x14")]
			public int charInstId;

			// Token: 0x04007FDE RID: 32734
			[Token(Token = "0x4007FDE")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x04007FDF RID: 32735
			[Token(Token = "0x4007FDF")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x04007FE0 RID: 32736
			[Token(Token = "0x4007FE0")]
			[FieldOffset(Offset = "0x24")]
			public int phase;

			// Token: 0x04007FE1 RID: 32737
			[Token(Token = "0x4007FE1")]
			[FieldOffset(Offset = "0x28")]
			public int favorPoint;

			// Token: 0x04007FE2 RID: 32738
			[Token(Token = "0x4007FE2")]
			[FieldOffset(Offset = "0x2C")]
			public int potentialRank;

			// Token: 0x04007FE3 RID: 32739
			[Token(Token = "0x4007FE3")]
			[FieldOffset(Offset = "0x30")]
			public int skillIndex;

			// Token: 0x04007FE4 RID: 32740
			[Token(Token = "0x4007FE4")]
			[FieldOffset(Offset = "0x34")]
			public int skillLevel;

			// Token: 0x04007FE5 RID: 32741
			[Token(Token = "0x4007FE5")]
			[FieldOffset(Offset = "0x38")]
			public int specSkillLevel;

			// Token: 0x04007FE6 RID: 32742
			[Token(Token = "0x4007FE6")]
			[FieldOffset(Offset = "0x40")]
			public string skinID;

			// Token: 0x04007FE7 RID: 32743
			[Token(Token = "0x4007FE7")]
			[FieldOffset(Offset = "0x48")]
			public string equipID;

			// Token: 0x04007FE8 RID: 32744
			[Token(Token = "0x4007FE8")]
			[FieldOffset(Offset = "0x50")]
			public int equipLevel;

			// Token: 0x04007FE9 RID: 32745
			[Token(Token = "0x4007FE9")]
			[FieldOffset(Offset = "0x58")]
			public string implId;
		}

		// Token: 0x020015C2 RID: 5570
		[Token(Token = "0x20015C2")]
		public class STConfirmSquadParam : IStreamSerialize
		{
			// Token: 0x06007E3E RID: 32318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3E")]
			[Address(RVA = "0x284B570", Offset = "0x284A170", VA = "0x18284B570", Slot = "4")]
			public void Write(IStreamWriter to)
			{
			}

			// Token: 0x06007E3F RID: 32319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public STConfirmSquadParam()
			{
			}

			// Token: 0x04007FEA RID: 32746
			[Token(Token = "0x4007FEA")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04007FEB RID: 32747
			[Token(Token = "0x4007FEB")]
			[FieldOffset(Offset = "0x14")]
			public int skillIndex;

			// Token: 0x04007FEC RID: 32748
			[Token(Token = "0x4007FEC")]
			[FieldOffset(Offset = "0x18")]
			public string equipId;
		}

		// Token: 0x020015C3 RID: 5571
		[Token(Token = "0x20015C3")]
		public class Squad
		{
			// Token: 0x06007E40 RID: 32320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E40")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Squad()
			{
			}

			// Token: 0x04007FED RID: 32749
			[Token(Token = "0x4007FED")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04007FEE RID: 32750
			[Token(Token = "0x4007FEE")]
			[FieldOffset(Offset = "0x18")]
			public TeamProtocol.SquadItem[] squad;
		}

		// Token: 0x020015C4 RID: 5572
		[Token(Token = "0x20015C4")]
		public class SquadItem
		{
			// Token: 0x06007E41 RID: 32321 RVA: 0x000379C8 File Offset: 0x00035BC8
			[Token(Token = "0x6007E41")]
			[Address(RVA = "0x284D200", Offset = "0x284BE00", VA = "0x18284D200")]
			public CharQuery GetCharQuery()
			{
				return default(CharQuery);
			}

			// Token: 0x06007E42 RID: 32322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E42")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SquadItem()
			{
			}

			// Token: 0x04007FEF RID: 32751
			[Token(Token = "0x4007FEF")]
			[FieldOffset(Offset = "0x10")]
			public int inst_id;

			// Token: 0x04007FF0 RID: 32752
			[Token(Token = "0x4007FF0")]
			[FieldOffset(Offset = "0x18")]
			public string char_id;

			// Token: 0x04007FF1 RID: 32753
			[Token(Token = "0x4007FF1")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x04007FF2 RID: 32754
			[Token(Token = "0x4007FF2")]
			[FieldOffset(Offset = "0x24")]
			public int phase;

			// Token: 0x04007FF3 RID: 32755
			[Token(Token = "0x4007FF3")]
			[FieldOffset(Offset = "0x28")]
			public int favor_point;

			// Token: 0x04007FF4 RID: 32756
			[Token(Token = "0x4007FF4")]
			[FieldOffset(Offset = "0x2C")]
			public int potential_rank;

			// Token: 0x04007FF5 RID: 32757
			[Token(Token = "0x4007FF5")]
			[FieldOffset(Offset = "0x30")]
			public int skill_index;

			// Token: 0x04007FF6 RID: 32758
			[Token(Token = "0x4007FF6")]
			[FieldOffset(Offset = "0x34")]
			public int spec_skill_level;

			// Token: 0x04007FF7 RID: 32759
			[Token(Token = "0x4007FF7")]
			[FieldOffset(Offset = "0x38")]
			public int skill_level;

			// Token: 0x04007FF8 RID: 32760
			[Token(Token = "0x4007FF8")]
			[FieldOffset(Offset = "0x40")]
			public string skin_id;

			// Token: 0x04007FF9 RID: 32761
			[Token(Token = "0x4007FF9")]
			[FieldOffset(Offset = "0x48")]
			public string tmpl_id;

			// Token: 0x04007FFA RID: 32762
			[Token(Token = "0x4007FFA")]
			[FieldOffset(Offset = "0x50")]
			public string equip_id;

			// Token: 0x04007FFB RID: 32763
			[Token(Token = "0x4007FFB")]
			[FieldOffset(Offset = "0x58")]
			public int equip_level;
		}
	}
}
