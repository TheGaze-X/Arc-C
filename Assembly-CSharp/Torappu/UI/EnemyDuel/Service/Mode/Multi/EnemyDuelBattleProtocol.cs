using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050A7 RID: 20647
	[Token(Token = "0x20050A7")]
	public abstract class EnemyDuelBattleProtocol
	{
		// Token: 0x0601E93E RID: 125246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E93E")]
		[Address(RVA = "0x183CDB0", Offset = "0x183B9B0", VA = "0x18183CDB0")]
		public static void Register(EnemyDuelProtocolSuit suite)
		{
		}

		// Token: 0x0601E93F RID: 125247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E93F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EnemyDuelBattleProtocol()
		{
		}

		// Token: 0x020050A8 RID: 20648
		[Token(Token = "0x20050A8")]
		public class SceneReadyDn : Protocol
		{
			// Token: 0x0601E940 RID: 125248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E940")]
			[Address(RVA = "0x184DCC0", Offset = "0x184C8C0", VA = "0x18184DCC0")]
			public SceneReadyDn()
			{
			}

			// Token: 0x04028F63 RID: 167779
			[Token(Token = "0x4028F63")]
			public const int ID = 202;

			// Token: 0x04028F64 RID: 167780
			[Token(Token = "0x4028F64")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050A9 RID: 20649
		[Token(Token = "0x20050A9")]
		public class SceneQuitDn : Protocol
		{
			// Token: 0x0601E941 RID: 125249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E941")]
			[Address(RVA = "0x184DC50", Offset = "0x184C850", VA = "0x18184DC50")]
			public SceneQuitDn()
			{
			}

			// Token: 0x04028F65 RID: 167781
			[Token(Token = "0x4028F65")]
			public const int ID = 204;

			// Token: 0x04028F66 RID: 167782
			[Token(Token = "0x4028F66")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050AA RID: 20650
		[Token(Token = "0x20050AA")]
		public class SceneEndUp : Protocol
		{
			// Token: 0x0601E942 RID: 125250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E942")]
			[Address(RVA = "0x184D960", Offset = "0x184C560", VA = "0x18184D960")]
			public SceneEndUp()
			{
			}

			// Token: 0x04028F67 RID: 167783
			[Token(Token = "0x4028F67")]
			public const int ID = 205;

			// Token: 0x04028F68 RID: 167784
			[Token(Token = "0x4028F68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050AB RID: 20651
		[Token(Token = "0x20050AB")]
		public class SceneEndDn : Protocol
		{
			// Token: 0x0601E943 RID: 125251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E943")]
			[Address(RVA = "0x184D8F0", Offset = "0x184C4F0", VA = "0x18184D8F0")]
			public SceneEndDn()
			{
			}

			// Token: 0x0601E944 RID: 125252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E944")]
			[Address(RVA = "0x184D850", Offset = "0x184C450", VA = "0x18184D850", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E945 RID: 125253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E945")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F69 RID: 167785
			[Token(Token = "0x4028F69")]
			public const int ID = 206;

			// Token: 0x04028F6A RID: 167786
			[Token(Token = "0x4028F6A")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelBattleProtocol.SceneEndReason reason;

			// Token: 0x04028F6B RID: 167787
			[Token(Token = "0x4028F6B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F6C RID: 167788
			[Token(Token = "0x4028F6C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050AC RID: 20652
		[Token(Token = "0x20050AC")]
		public class SceneActionUp : Protocol
		{
			// Token: 0x0601E946 RID: 125254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E946")]
			[Address(RVA = "0x184D6F0", Offset = "0x184C2F0", VA = "0x18184D6F0")]
			public SceneActionUp()
			{
			}

			// Token: 0x0601E947 RID: 125255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E947")]
			[Address(RVA = "0x184D660", Offset = "0x184C260", VA = "0x18184D660", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x0601E948 RID: 125256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E948")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04028F6D RID: 167789
			[Token(Token = "0x4028F6D")]
			public const int ID = 207;

			// Token: 0x04028F6E RID: 167790
			[Token(Token = "0x4028F6E")]
			[FieldOffset(Offset = "0x18")]
			public List<EnemyDuelServiceAction> actions;

			// Token: 0x04028F6F RID: 167791
			[Token(Token = "0x4028F6F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F70 RID: 167792
			[Token(Token = "0x4028F70")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020050AD RID: 20653
		[Token(Token = "0x20050AD")]
		public class SceneActionDn : Protocol
		{
			// Token: 0x0601E949 RID: 125257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E949")]
			[Address(RVA = "0x184D5F0", Offset = "0x184C1F0", VA = "0x18184D5F0")]
			public SceneActionDn()
			{
			}

			// Token: 0x04028F71 RID: 167793
			[Token(Token = "0x4028F71")]
			public const int ID = 208;

			// Token: 0x04028F72 RID: 167794
			[Token(Token = "0x4028F72")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050AE RID: 20654
		[Token(Token = "0x20050AE")]
		public class SceneStepUp : Protocol
		{
			// Token: 0x0601E94A RID: 125258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94A")]
			[Address(RVA = "0x184DF90", Offset = "0x184CB90", VA = "0x18184DF90")]
			public SceneStepUp()
			{
			}

			// Token: 0x04028F73 RID: 167795
			[Token(Token = "0x4028F73")]
			public const int ID = 209;

			// Token: 0x04028F74 RID: 167796
			[Token(Token = "0x4028F74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050AF RID: 20655
		[Token(Token = "0x20050AF")]
		public class SceneStepDn : Protocol
		{
			// Token: 0x0601E94B RID: 125259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94B")]
			[Address(RVA = "0x184DF20", Offset = "0x184CB20", VA = "0x18184DF20")]
			public SceneStepDn()
			{
			}

			// Token: 0x0601E94C RID: 125260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94C")]
			[Address(RVA = "0x184DD30", Offset = "0x184C930", VA = "0x18184DD30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E94D RID: 125261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F75 RID: 167797
			[Token(Token = "0x4028F75")]
			public const int ID = 210;

			// Token: 0x04028F76 RID: 167798
			[Token(Token = "0x4028F76")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelServiceStepData step;

			// Token: 0x04028F77 RID: 167799
			[Token(Token = "0x4028F77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F78 RID: 167800
			[Token(Token = "0x4028F78")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050B0 RID: 20656
		[Token(Token = "0x20050B0")]
		public class SceneHistoryUp : Protocol
		{
			// Token: 0x0601E94E RID: 125262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94E")]
			[Address(RVA = "0x184DBE0", Offset = "0x184C7E0", VA = "0x18184DBE0")]
			public SceneHistoryUp()
			{
			}

			// Token: 0x0601E94F RID: 125263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E94F")]
			[Address(RVA = "0x184DB40", Offset = "0x184C740", VA = "0x18184DB40", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x0601E950 RID: 125264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E950")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04028F79 RID: 167801
			[Token(Token = "0x4028F79")]
			public const int ID = 211;

			// Token: 0x04028F7A RID: 167802
			[Token(Token = "0x4028F7A")]
			[FieldOffset(Offset = "0x18")]
			public int seq;

			// Token: 0x04028F7B RID: 167803
			[Token(Token = "0x4028F7B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F7C RID: 167804
			[Token(Token = "0x4028F7C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020050B1 RID: 20657
		[Token(Token = "0x20050B1")]
		public class SceneHistoryDn : Protocol
		{
			// Token: 0x0601E951 RID: 125265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E951")]
			[Address(RVA = "0x184DAD0", Offset = "0x184C6D0", VA = "0x18184DAD0")]
			public SceneHistoryDn()
			{
			}

			// Token: 0x0601E952 RID: 125266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E952")]
			[Address(RVA = "0x184D9D0", Offset = "0x184C5D0", VA = "0x18184D9D0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E953 RID: 125267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E953")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F7D RID: 167805
			[Token(Token = "0x4028F7D")]
			public const int ID = 212;

			// Token: 0x04028F7E RID: 167806
			[Token(Token = "0x4028F7E")]
			[FieldOffset(Offset = "0x18")]
			public List<EnemyDuelServiceStepData> steps;

			// Token: 0x04028F7F RID: 167807
			[Token(Token = "0x4028F7F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F80 RID: 167808
			[Token(Token = "0x4028F80")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050B2 RID: 20658
		[Token(Token = "0x20050B2")]
		public class SceneClientStateDn : ResponseProtocol<EnemyDuelBattleStatus>
		{
			// Token: 0x0601E954 RID: 125268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E954")]
			[Address(RVA = "0x184D7D0", Offset = "0x184C3D0", VA = "0x18184D7D0")]
			public SceneClientStateDn()
			{
			}

			// Token: 0x04028F81 RID: 167809
			[Token(Token = "0x4028F81")]
			public const int ID = 214;

			// Token: 0x04028F82 RID: 167810
			[Token(Token = "0x4028F82")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050B3 RID: 20659
		[Token(Token = "0x20050B3")]
		public class SceneBetDn : Protocol
		{
			// Token: 0x0601E955 RID: 125269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E955")]
			[Address(RVA = "0x184D760", Offset = "0x184C360", VA = "0x18184D760")]
			public SceneBetDn()
			{
			}

			// Token: 0x04028F83 RID: 167811
			[Token(Token = "0x4028F83")]
			public const int ID = 216;

			// Token: 0x04028F84 RID: 167812
			[Token(Token = "0x4028F84")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050B4 RID: 20660
		[Token(Token = "0x20050B4")]
		public class RoundSettleDn : Protocol
		{
			// Token: 0x0601E956 RID: 125270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E956")]
			[Address(RVA = "0x184CFF0", Offset = "0x184BBF0", VA = "0x18184CFF0")]
			public RoundSettleDn()
			{
			}

			// Token: 0x04028F85 RID: 167813
			[Token(Token = "0x4028F85")]
			public const int ID = 218;

			// Token: 0x04028F86 RID: 167814
			[Token(Token = "0x4028F86")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050B5 RID: 20661
		[Token(Token = "0x20050B5")]
		public class DuelSceneJoinUp : Protocol
		{
			// Token: 0x0601E957 RID: 125271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E957")]
			[Address(RVA = "0x1838FE0", Offset = "0x1837BE0", VA = "0x181838FE0")]
			public DuelSceneJoinUp()
			{
			}

			// Token: 0x0601E958 RID: 125272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E958")]
			[Address(RVA = "0x1838F00", Offset = "0x1837B00", VA = "0x181838F00", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x0601E959 RID: 125273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E959")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04028F87 RID: 167815
			[Token(Token = "0x4028F87")]
			public const int ID = 219;

			// Token: 0x04028F88 RID: 167816
			[Token(Token = "0x4028F88")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04028F89 RID: 167817
			[Token(Token = "0x4028F89")]
			[FieldOffset(Offset = "0x20")]
			public string sceneId;

			// Token: 0x04028F8A RID: 167818
			[Token(Token = "0x4028F8A")]
			[FieldOffset(Offset = "0x28")]
			public string token;

			// Token: 0x04028F8B RID: 167819
			[Token(Token = "0x4028F8B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F8C RID: 167820
			[Token(Token = "0x4028F8C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020050B6 RID: 20662
		[Token(Token = "0x20050B6")]
		public class DuelSceneJoinDn : Protocol
		{
			// Token: 0x0601E95A RID: 125274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95A")]
			[Address(RVA = "0x1838E90", Offset = "0x1837A90", VA = "0x181838E90")]
			public DuelSceneJoinDn()
			{
			}

			// Token: 0x0601E95B RID: 125275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95B")]
			[Address(RVA = "0x1838D50", Offset = "0x1837950", VA = "0x181838D50", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E95C RID: 125276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95C")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F8D RID: 167821
			[Token(Token = "0x4028F8D")]
			public const int ID = 220;

			// Token: 0x04028F8E RID: 167822
			[Token(Token = "0x4028F8E")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelProtocolRetCode retCode;

			// Token: 0x04028F8F RID: 167823
			[Token(Token = "0x4028F8F")]
			[FieldOffset(Offset = "0x20")]
			public EnemyDuelServiceSceneJoinData data;

			// Token: 0x04028F90 RID: 167824
			[Token(Token = "0x4028F90")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F91 RID: 167825
			[Token(Token = "0x4028F91")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050B7 RID: 20663
		[Token(Token = "0x20050B7")]
		public class FinalSettleDn : Protocol
		{
			// Token: 0x0601E95D RID: 125277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95D")]
			[Address(RVA = "0x184C6B0", Offset = "0x184B2B0", VA = "0x18184C6B0")]
			public FinalSettleDn()
			{
			}

			// Token: 0x04028F92 RID: 167826
			[Token(Token = "0x4028F92")]
			public const int ID = 222;

			// Token: 0x04028F93 RID: 167827
			[Token(Token = "0x4028F93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050B8 RID: 20664
		[Token(Token = "0x20050B8")]
		public class EnemyDuelEmojiDn : Protocol
		{
			// Token: 0x0601E95E RID: 125278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95E")]
			[Address(RVA = "0x183F620", Offset = "0x183E220", VA = "0x18183F620")]
			public EnemyDuelEmojiDn()
			{
			}

			// Token: 0x0601E95F RID: 125279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E95F")]
			[Address(RVA = "0x183F460", Offset = "0x183E060", VA = "0x18183F460", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E960 RID: 125280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E960")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F94 RID: 167828
			[Token(Token = "0x4028F94")]
			public const int ID = 224;

			// Token: 0x04028F95 RID: 167829
			[Token(Token = "0x4028F95")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelEmojiData emojiData;

			// Token: 0x04028F96 RID: 167830
			[Token(Token = "0x4028F96")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F97 RID: 167831
			[Token(Token = "0x4028F97")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050B9 RID: 20665
		[Token(Token = "0x20050B9")]
		public class EnemyDuelCheckSumDn : Protocol
		{
			// Token: 0x0601E961 RID: 125281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E961")]
			[Address(RVA = "0x183F2B0", Offset = "0x183DEB0", VA = "0x18183F2B0")]
			public EnemyDuelCheckSumDn()
			{
			}

			// Token: 0x0601E962 RID: 125282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E962")]
			[Address(RVA = "0x183F210", Offset = "0x183DE10", VA = "0x18183F210", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E963 RID: 125283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E963")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028F98 RID: 167832
			[Token(Token = "0x4028F98")]
			public const int ID = 226;

			// Token: 0x04028F99 RID: 167833
			[Token(Token = "0x4028F99")]
			[FieldOffset(Offset = "0x18")]
			public int failSeq;

			// Token: 0x04028F9A RID: 167834
			[Token(Token = "0x4028F9A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028F9B RID: 167835
			[Token(Token = "0x4028F9B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050BA RID: 20666
		[Token(Token = "0x20050BA")]
		public enum SceneEndReason
		{
			// Token: 0x04028F9D RID: 167837
			[Token(Token = "0x4028F9D")]
			NORMAL,
			// Token: 0x04028F9E RID: 167838
			[Token(Token = "0x4028F9E")]
			TIME_OUT_LOADING,
			// Token: 0x04028F9F RID: 167839
			[Token(Token = "0x4028F9F")]
			TIME_OUT_BATTLE,
			// Token: 0x04028FA0 RID: 167840
			[Token(Token = "0x4028FA0")]
			TIME_OUT_SETTLE,
			// Token: 0x04028FA1 RID: 167841
			[Token(Token = "0x4028FA1")]
			ALL_LEAVE,
			// Token: 0x04028FA2 RID: 167842
			[Token(Token = "0x4028FA2")]
			LARG_DISCORD,
			// Token: 0x04028FA3 RID: 167843
			[Token(Token = "0x4028FA3")]
			STOP_SERVICE = 9
		}
	}
}
