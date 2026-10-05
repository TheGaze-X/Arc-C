using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006444 RID: 25668
	[Token(Token = "0x2006444")]
	public abstract class AutoChessTeamProtocol
	{
		// Token: 0x06024EE9 RID: 151273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AutoChessTeamProtocol()
		{
		}

		// Token: 0x02006445 RID: 25669
		[Token(Token = "0x2006445")]
		public class LeaveUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EEA RID: 151274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EEA")]
			[Address(RVA = "0x1FD9D50", Offset = "0x1FD8950", VA = "0x181FD9D50")]
			public LeaveUp()
			{
			}

			// Token: 0x04033AA0 RID: 211616
			[Token(Token = "0x4033AA0")]
			public const int ID = 603;

			// Token: 0x04033AA1 RID: 211617
			[Token(Token = "0x4033AA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006446 RID: 25670
		[Token(Token = "0x2006446")]
		public class LeaveDn : Protocol
		{
			// Token: 0x06024EEB RID: 151275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EEB")]
			[Address(RVA = "0x1FD9CE0", Offset = "0x1FD88E0", VA = "0x181FD9CE0")]
			public LeaveDn()
			{
			}

			// Token: 0x04033AA2 RID: 211618
			[Token(Token = "0x4033AA2")]
			public const int ID = 604;

			// Token: 0x04033AA3 RID: 211619
			[Token(Token = "0x4033AA3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006447 RID: 25671
		[Token(Token = "0x2006447")]
		public class MsgAutoChessTeamStatusDn : Protocol
		{
			// Token: 0x06024EEC RID: 151276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EEC")]
			[Address(RVA = "0x1FDA410", Offset = "0x1FD9010", VA = "0x181FDA410")]
			public MsgAutoChessTeamStatusDn()
			{
			}

			// Token: 0x06024EED RID: 151277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EED")]
			[Address(RVA = "0x1FDA390", Offset = "0x1FD8F90", VA = "0x181FDA390", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024EEE RID: 151278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EEE")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033AA4 RID: 211620
			[Token(Token = "0x4033AA4")]
			public const int ID = 802;

			// Token: 0x04033AA5 RID: 211621
			[Token(Token = "0x4033AA5")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessTeamStatus status;

			// Token: 0x04033AA6 RID: 211622
			[Token(Token = "0x4033AA6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AA7 RID: 211623
			[Token(Token = "0x4033AA7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006448 RID: 25672
		[Token(Token = "0x2006448")]
		public class AutoChessTeamPlayerStateDn : Protocol
		{
			// Token: 0x06024EEF RID: 151279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EEF")]
			[Address(RVA = "0x1FD6FC0", Offset = "0x1FD5BC0", VA = "0x181FD6FC0")]
			public AutoChessTeamPlayerStateDn()
			{
			}

			// Token: 0x06024EF0 RID: 151280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF0")]
			[Address(RVA = "0x1FD6EE0", Offset = "0x1FD5AE0", VA = "0x181FD6EE0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024EF1 RID: 151281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF1")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033AA8 RID: 211624
			[Token(Token = "0x4033AA8")]
			public const int ID = 804;

			// Token: 0x04033AA9 RID: 211625
			[Token(Token = "0x4033AA9")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04033AAA RID: 211626
			[Token(Token = "0x4033AAA")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessPlayerState state;

			// Token: 0x04033AAB RID: 211627
			[Token(Token = "0x4033AAB")]
			[FieldOffset(Offset = "0x24")]
			public AutoChessPlayerConnectState connState;

			// Token: 0x04033AAC RID: 211628
			[Token(Token = "0x4033AAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AAD RID: 211629
			[Token(Token = "0x4033AAD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006449 RID: 25673
		[Token(Token = "0x2006449")]
		public class AutoChessTeamReadyInRoomUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EF2 RID: 151282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF2")]
			[Address(RVA = "0x1FD70C0", Offset = "0x1FD5CC0", VA = "0x181FD70C0")]
			public AutoChessTeamReadyInRoomUp()
			{
			}

			// Token: 0x06024EF3 RID: 151283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF3")]
			[Address(RVA = "0x1FD7030", Offset = "0x1FD5C30", VA = "0x181FD7030", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024EF4 RID: 151284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF4")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AAE RID: 211630
			[Token(Token = "0x4033AAE")]
			public const int ID = 805;

			// Token: 0x04033AAF RID: 211631
			[Token(Token = "0x4033AAF")]
			[FieldOffset(Offset = "0x18")]
			public bool ready;

			// Token: 0x04033AB0 RID: 211632
			[Token(Token = "0x4033AB0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AB1 RID: 211633
			[Token(Token = "0x4033AB1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200644A RID: 25674
		[Token(Token = "0x200644A")]
		public class AutoChessTeamEnemyAssignReadyUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EF5 RID: 151285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF5")]
			[Address(RVA = "0x1FD6E70", Offset = "0x1FD5A70", VA = "0x181FD6E70")]
			public AutoChessTeamEnemyAssignReadyUp()
			{
			}

			// Token: 0x06024EF6 RID: 151286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF6")]
			[Address(RVA = "0x1FD6DE0", Offset = "0x1FD59E0", VA = "0x181FD6DE0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024EF7 RID: 151287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF7")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AB2 RID: 211634
			[Token(Token = "0x4033AB2")]
			public const int ID = 807;

			// Token: 0x04033AB3 RID: 211635
			[Token(Token = "0x4033AB3")]
			[FieldOffset(Offset = "0x18")]
			public bool ready;

			// Token: 0x04033AB4 RID: 211636
			[Token(Token = "0x4033AB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AB5 RID: 211637
			[Token(Token = "0x4033AB5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200644B RID: 25675
		[Token(Token = "0x200644B")]
		public class AutoChessTeamChooseStrategyUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EF8 RID: 151288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF8")]
			[Address(RVA = "0x1FD6D70", Offset = "0x1FD5970", VA = "0x181FD6D70")]
			public AutoChessTeamChooseStrategyUp()
			{
			}

			// Token: 0x06024EF9 RID: 151289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EF9")]
			[Address(RVA = "0x1FD6CC0", Offset = "0x1FD58C0", VA = "0x181FD6CC0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024EFA RID: 151290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFA")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AB6 RID: 211638
			[Token(Token = "0x4033AB6")]
			public const int ID = 809;

			// Token: 0x04033AB7 RID: 211639
			[Token(Token = "0x4033AB7")]
			[FieldOffset(Offset = "0x18")]
			public bool skip;

			// Token: 0x04033AB8 RID: 211640
			[Token(Token = "0x4033AB8")]
			[FieldOffset(Offset = "0x20")]
			public string strategy;

			// Token: 0x04033AB9 RID: 211641
			[Token(Token = "0x4033AB9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033ABA RID: 211642
			[Token(Token = "0x4033ABA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200644C RID: 25676
		[Token(Token = "0x200644C")]
		public class AutoChessTeamChooseStrategyDn : Protocol
		{
			// Token: 0x06024EFB RID: 151291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFB")]
			[Address(RVA = "0x1FD6C50", Offset = "0x1FD5850", VA = "0x181FD6C50")]
			public AutoChessTeamChooseStrategyDn()
			{
			}

			// Token: 0x06024EFC RID: 151292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFC")]
			[Address(RVA = "0x1FD6BD0", Offset = "0x1FD57D0", VA = "0x181FD6BD0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024EFD RID: 151293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFD")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033ABB RID: 211643
			[Token(Token = "0x4033ABB")]
			public const int ID = 810;

			// Token: 0x04033ABC RID: 211644
			[Token(Token = "0x4033ABC")]
			[FieldOffset(Offset = "0x18")]
			public StrategyDecisionBrief strategyDecisionBrief;

			// Token: 0x04033ABD RID: 211645
			[Token(Token = "0x4033ABD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033ABE RID: 211646
			[Token(Token = "0x4033ABE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200644D RID: 25677
		[Token(Token = "0x200644D")]
		public class AutoChessTeamStartMatchUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EFE RID: 151294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFE")]
			[Address(RVA = "0x1FD92C0", Offset = "0x1FD7EC0", VA = "0x181FD92C0")]
			public AutoChessTeamStartMatchUp()
			{
			}

			// Token: 0x04033ABF RID: 211647
			[Token(Token = "0x4033ABF")]
			public const int ID = 813;

			// Token: 0x04033AC0 RID: 211648
			[Token(Token = "0x4033AC0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200644E RID: 25678
		[Token(Token = "0x200644E")]
		public class ProtoIDAutoChessTeamChangeModeUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024EFF RID: 151295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024EFF")]
			[Address(RVA = "0x1FDBF90", Offset = "0x1FDAB90", VA = "0x181FDBF90")]
			public ProtoIDAutoChessTeamChangeModeUp()
			{
			}

			// Token: 0x06024F00 RID: 151296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F00")]
			[Address(RVA = "0x1FDBEF0", Offset = "0x1FDAAF0", VA = "0x181FDBEF0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F01 RID: 151297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F01")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AC1 RID: 211649
			[Token(Token = "0x4033AC1")]
			public const int ID = 817;

			// Token: 0x04033AC2 RID: 211650
			[Token(Token = "0x4033AC2")]
			[FieldOffset(Offset = "0x18")]
			public string modeId;

			// Token: 0x04033AC3 RID: 211651
			[Token(Token = "0x4033AC3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AC4 RID: 211652
			[Token(Token = "0x4033AC4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200644F RID: 25679
		[Token(Token = "0x200644F")]
		public class ProtoIDAutoChessTeamChangeModeDn : Protocol
		{
			// Token: 0x06024F02 RID: 151298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F02")]
			[Address(RVA = "0x1FDBE80", Offset = "0x1FDAA80", VA = "0x181FDBE80")]
			public ProtoIDAutoChessTeamChangeModeDn()
			{
			}

			// Token: 0x06024F03 RID: 151299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F03")]
			[Address(RVA = "0x1FDBDE0", Offset = "0x1FDA9E0", VA = "0x181FDBDE0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024F04 RID: 151300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F04")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033AC5 RID: 211653
			[Token(Token = "0x4033AC5")]
			public const int ID = 818;

			// Token: 0x04033AC6 RID: 211654
			[Token(Token = "0x4033AC6")]
			[FieldOffset(Offset = "0x18")]
			public string modeId;

			// Token: 0x04033AC7 RID: 211655
			[Token(Token = "0x4033AC7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AC8 RID: 211656
			[Token(Token = "0x4033AC8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006450 RID: 25680
		[Token(Token = "0x2006450")]
		public class ProtoIDAutoChessTeamChangeMatchOptionUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F05 RID: 151301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F05")]
			[Address(RVA = "0x1FDBD70", Offset = "0x1FDA970", VA = "0x181FDBD70")]
			public ProtoIDAutoChessTeamChangeMatchOptionUp()
			{
			}

			// Token: 0x06024F06 RID: 151302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F06")]
			[Address(RVA = "0x1FDBC40", Offset = "0x1FDA840", VA = "0x181FDBC40", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F07 RID: 151303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F07")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AC9 RID: 211657
			[Token(Token = "0x4033AC9")]
			public const int ID = 819;

			// Token: 0x04033ACA RID: 211658
			[Token(Token = "0x4033ACA")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessMatchModeRange opt;

			// Token: 0x04033ACB RID: 211659
			[Token(Token = "0x4033ACB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033ACC RID: 211660
			[Token(Token = "0x4033ACC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006451 RID: 25681
		[Token(Token = "0x2006451")]
		public class ProtoIDAutoChessTeamChangeMatchOptionDn : Protocol
		{
			// Token: 0x06024F08 RID: 151304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F08")]
			[Address(RVA = "0x1FDBBD0", Offset = "0x1FDA7D0", VA = "0x181FDBBD0")]
			public ProtoIDAutoChessTeamChangeMatchOptionDn()
			{
			}

			// Token: 0x06024F09 RID: 151305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F09")]
			[Address(RVA = "0x1FDBB30", Offset = "0x1FDA730", VA = "0x181FDBB30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024F0A RID: 151306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0A")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033ACD RID: 211661
			[Token(Token = "0x4033ACD")]
			public const int ID = 820;

			// Token: 0x04033ACE RID: 211662
			[Token(Token = "0x4033ACE")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessMatchModeRange opt;

			// Token: 0x04033ACF RID: 211663
			[Token(Token = "0x4033ACF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AD0 RID: 211664
			[Token(Token = "0x4033AD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x02006452 RID: 25682
		[Token(Token = "0x2006452")]
		public class ProtoIDAutoChessTeamMatchResultDn : ResponseProtocol<AutoChessServiceMatchResult>
		{
			// Token: 0x06024F0B RID: 151307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0B")]
			[Address(RVA = "0x1FDC000", Offset = "0x1FDAC00", VA = "0x181FDC000")]
			public ProtoIDAutoChessTeamMatchResultDn()
			{
			}

			// Token: 0x04033AD1 RID: 211665
			[Token(Token = "0x4033AD1")]
			public const int ID = 822;

			// Token: 0x04033AD2 RID: 211666
			[Token(Token = "0x4033AD2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006453 RID: 25683
		[Token(Token = "0x2006453")]
		public class ChatUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F0C RID: 151308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0C")]
			[Address(RVA = "0x1FD9710", Offset = "0x1FD8310", VA = "0x181FD9710")]
			public ChatUp()
			{
			}

			// Token: 0x06024F0D RID: 151309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0D")]
			[Address(RVA = "0x1FD9660", Offset = "0x1FD8260", VA = "0x181FD9660", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F0E RID: 151310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0E")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AD3 RID: 211667
			[Token(Token = "0x4033AD3")]
			public const uint ID = 615U;

			// Token: 0x04033AD4 RID: 211668
			[Token(Token = "0x4033AD4")]
			[FieldOffset(Offset = "0x18")]
			public string emojiGroup;

			// Token: 0x04033AD5 RID: 211669
			[Token(Token = "0x4033AD5")]
			[FieldOffset(Offset = "0x20")]
			public string emojiId;

			// Token: 0x04033AD6 RID: 211670
			[Token(Token = "0x4033AD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AD7 RID: 211671
			[Token(Token = "0x4033AD7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006454 RID: 25684
		[Token(Token = "0x2006454")]
		public class ChatDn : DnProtocol<AutoChessChatData>
		{
			// Token: 0x06024F0F RID: 151311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F0F")]
			[Address(RVA = "0x1FD95E0", Offset = "0x1FD81E0", VA = "0x181FD95E0")]
			public ChatDn()
			{
			}

			// Token: 0x04033AD8 RID: 211672
			[Token(Token = "0x4033AD8")]
			public const uint ID = 616U;

			// Token: 0x04033AD9 RID: 211673
			[Token(Token = "0x4033AD9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006455 RID: 25685
		[Token(Token = "0x2006455")]
		public class KickUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F10 RID: 151312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F10")]
			[Address(RVA = "0x1FD9C70", Offset = "0x1FD8870", VA = "0x181FD9C70")]
			public KickUp()
			{
			}

			// Token: 0x06024F11 RID: 151313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F11")]
			[Address(RVA = "0x1FD9BD0", Offset = "0x1FD87D0", VA = "0x181FD9BD0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F12 RID: 151314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F12")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033ADA RID: 211674
			[Token(Token = "0x4033ADA")]
			public const uint ID = 617U;

			// Token: 0x04033ADB RID: 211675
			[Token(Token = "0x4033ADB")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04033ADC RID: 211676
			[Token(Token = "0x4033ADC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033ADD RID: 211677
			[Token(Token = "0x4033ADD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006456 RID: 25686
		[Token(Token = "0x2006456")]
		public class KickDn : Protocol
		{
			// Token: 0x06024F13 RID: 151315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F13")]
			[Address(RVA = "0x1FD9B60", Offset = "0x1FD8760", VA = "0x181FD9B60")]
			public KickDn()
			{
			}

			// Token: 0x06024F14 RID: 151316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F14")]
			[Address(RVA = "0x1FD9AC0", Offset = "0x1FD86C0", VA = "0x181FD9AC0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024F15 RID: 151317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F15")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033ADE RID: 211678
			[Token(Token = "0x4033ADE")]
			public const uint ID = 618U;

			// Token: 0x04033ADF RID: 211679
			[Token(Token = "0x4033ADF")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessTeamProtocol.KickDn.ReasonType reason;

			// Token: 0x04033AE0 RID: 211680
			[Token(Token = "0x4033AE0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AE1 RID: 211681
			[Token(Token = "0x4033AE1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;

			// Token: 0x02006457 RID: 25687
			[Token(Token = "0x2006457")]
			public enum ReasonType
			{
				// Token: 0x04033AE3 RID: 211683
				[Token(Token = "0x4033AE3")]
				DISBAND,
				// Token: 0x04033AE4 RID: 211684
				[Token(Token = "0x4033AE4")]
				DISLIKE,
				// Token: 0x04033AE5 RID: 211685
				[Token(Token = "0x4033AE5")]
				TIMEOUT,
				// Token: 0x04033AE6 RID: 211686
				[Token(Token = "0x4033AE6")]
				MATE_FAIL,
				// Token: 0x04033AE7 RID: 211687
				[Token(Token = "0x4033AE7")]
				SCENE_START_FAIL
			}
		}

		// Token: 0x02006458 RID: 25688
		[Token(Token = "0x2006458")]
		public class GetNameCardUp : AutoChessServiceTeamRequest, IRRPProtocol
		{
			// Token: 0x06024F16 RID: 151318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F16")]
			[Address(RVA = "0x1FD9A50", Offset = "0x1FD8650", VA = "0x181FD9A50")]
			public GetNameCardUp()
			{
			}

			// Token: 0x06024F17 RID: 151319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F17")]
			[Address(RVA = "0x1FD99B0", Offset = "0x1FD85B0", VA = "0x181FD99B0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F18 RID: 151320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F18")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AE8 RID: 211688
			[Token(Token = "0x4033AE8")]
			public const int ID = 823;

			// Token: 0x04033AE9 RID: 211689
			[Token(Token = "0x4033AE9")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04033AEA RID: 211690
			[Token(Token = "0x4033AEA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AEB RID: 211691
			[Token(Token = "0x4033AEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x02006459 RID: 25689
		[Token(Token = "0x2006459")]
		public class GetNameCardDn : Protocol, IRRPProtocol
		{
			// Token: 0x06024F19 RID: 151321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F19")]
			[Address(RVA = "0x1FD9860", Offset = "0x1FD8460", VA = "0x181FD9860")]
			public GetNameCardDn()
			{
			}

			// Token: 0x17005724 RID: 22308
			// (get) Token: 0x06024F1A RID: 151322 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024F1B RID: 151323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005724")]
			public string nameCardJson
			{
				[Token(Token = "0x6024F1A")]
				[Address(RVA = "0x1FD98D0", Offset = "0x1FD84D0", VA = "0x181FD98D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6024F1B")]
				[Address(RVA = "0x1FD9930", Offset = "0x1FD8530", VA = "0x181FD9930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06024F1C RID: 151324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F1C")]
			[Address(RVA = "0x1FD9780", Offset = "0x1FD8380", VA = "0x181FD9780", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024F1D RID: 151325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F1D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033AEC RID: 211692
			[Token(Token = "0x4033AEC")]
			public const int ID = 824;

			// Token: 0x04033AEE RID: 211694
			[Token(Token = "0x4033AEE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AEF RID: 211695
			[Token(Token = "0x4033AEF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_nameCardJson;

			// Token: 0x04033AF0 RID: 211696
			[Token(Token = "0x4033AF0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_nameCardJson;

			// Token: 0x04033AF1 RID: 211697
			[Token(Token = "0x4033AF1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200645A RID: 25690
		[Token(Token = "0x200645A")]
		public class BackTeamUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F1E RID: 151326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F1E")]
			[Address(RVA = "0x1FD9570", Offset = "0x1FD8170", VA = "0x181FD9570")]
			public BackTeamUp()
			{
			}

			// Token: 0x04033AF2 RID: 211698
			[Token(Token = "0x4033AF2")]
			public const int ID = 815;

			// Token: 0x04033AF3 RID: 211699
			[Token(Token = "0x4033AF3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200645B RID: 25691
		[Token(Token = "0x200645B")]
		public class AutoChessTeamCancelMatchUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F1F RID: 151327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F1F")]
			[Address(RVA = "0x1FD6B60", Offset = "0x1FD5760", VA = "0x181FD6B60")]
			public AutoChessTeamCancelMatchUp()
			{
			}

			// Token: 0x04033AF4 RID: 211700
			[Token(Token = "0x4033AF4")]
			public const int ID = 825;

			// Token: 0x04033AF5 RID: 211701
			[Token(Token = "0x4033AF5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200645C RID: 25692
		[Token(Token = "0x200645C")]
		public class ProtoIDAutoChessTeamChangeMatchFlagUp : AutoChessServiceTeamRequest
		{
			// Token: 0x06024F20 RID: 151328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F20")]
			[Address(RVA = "0x1FDBAC0", Offset = "0x1FDA6C0", VA = "0x181FDBAC0")]
			public ProtoIDAutoChessTeamChangeMatchFlagUp()
			{
			}

			// Token: 0x06024F21 RID: 151329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F21")]
			[Address(RVA = "0x1FDBA30", Offset = "0x1FDA630", VA = "0x181FDBA30", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06024F22 RID: 151330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F22")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04033AF6 RID: 211702
			[Token(Token = "0x4033AF6")]
			public const int ID = 827;

			// Token: 0x04033AF7 RID: 211703
			[Token(Token = "0x4033AF7")]
			[FieldOffset(Offset = "0x18")]
			public bool matchFlag;

			// Token: 0x04033AF8 RID: 211704
			[Token(Token = "0x4033AF8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AF9 RID: 211705
			[Token(Token = "0x4033AF9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x0200645D RID: 25693
		[Token(Token = "0x200645D")]
		public class ProtoIDAutoChessTeamChangeMatchFlagDn : Protocol
		{
			// Token: 0x06024F23 RID: 151331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F23")]
			[Address(RVA = "0x1FDB9C0", Offset = "0x1FDA5C0", VA = "0x181FDB9C0")]
			public ProtoIDAutoChessTeamChangeMatchFlagDn()
			{
			}

			// Token: 0x06024F24 RID: 151332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F24")]
			[Address(RVA = "0x1FDB930", Offset = "0x1FDA530", VA = "0x181FDB930", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06024F25 RID: 151333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024F25")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04033AFA RID: 211706
			[Token(Token = "0x4033AFA")]
			public const int ID = 828;

			// Token: 0x04033AFB RID: 211707
			[Token(Token = "0x4033AFB")]
			[FieldOffset(Offset = "0x18")]
			public bool matchFlag;

			// Token: 0x04033AFC RID: 211708
			[Token(Token = "0x4033AFC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033AFD RID: 211709
			[Token(Token = "0x4033AFD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}
	}
}
