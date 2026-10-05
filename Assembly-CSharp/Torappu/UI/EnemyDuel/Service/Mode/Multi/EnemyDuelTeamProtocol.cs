using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050BD RID: 20669
	[Token(Token = "0x20050BD")]
	public abstract class EnemyDuelTeamProtocol
	{
		// Token: 0x0601E966 RID: 125286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E966")]
		[Address(RVA = "0x1849F60", Offset = "0x1848B60", VA = "0x181849F60")]
		public static void Register(EnemyDuelProtocolSuit suite)
		{
		}

		// Token: 0x0601E967 RID: 125287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E967")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EnemyDuelTeamProtocol()
		{
		}

		// Token: 0x020050BE RID: 20670
		[Token(Token = "0x20050BE")]
		public class TeamJoinUp : Protocol
		{
			// Token: 0x0601E968 RID: 125288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E968")]
			[Address(RVA = "0x184E300", Offset = "0x184CF00", VA = "0x18184E300")]
			public TeamJoinUp()
			{
			}

			// Token: 0x0601E969 RID: 125289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E969")]
			[Address(RVA = "0x184E230", Offset = "0x184CE30", VA = "0x18184E230", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x0601E96A RID: 125290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96A")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04028FB0 RID: 167856
			[Token(Token = "0x4028FB0")]
			public const int ID = 601;

			// Token: 0x04028FB1 RID: 167857
			[Token(Token = "0x4028FB1")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04028FB2 RID: 167858
			[Token(Token = "0x4028FB2")]
			[FieldOffset(Offset = "0x20")]
			public string teamID;

			// Token: 0x04028FB3 RID: 167859
			[Token(Token = "0x4028FB3")]
			[FieldOffset(Offset = "0x28")]
			public string teamToken;

			// Token: 0x04028FB4 RID: 167860
			[Token(Token = "0x4028FB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FB5 RID: 167861
			[Token(Token = "0x4028FB5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020050BF RID: 20671
		[Token(Token = "0x20050BF")]
		public class TeamJoinDn : Protocol
		{
			// Token: 0x0601E96B RID: 125291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96B")]
			[Address(RVA = "0x184E1C0", Offset = "0x184CDC0", VA = "0x18184E1C0")]
			public TeamJoinDn()
			{
			}

			// Token: 0x0601E96C RID: 125292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96C")]
			[Address(RVA = "0x184E0F0", Offset = "0x184CCF0", VA = "0x18184E0F0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E96D RID: 125293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96D")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FB6 RID: 167862
			[Token(Token = "0x4028FB6")]
			public const int ID = 602;

			// Token: 0x04028FB7 RID: 167863
			[Token(Token = "0x4028FB7")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelProtocolRetCode retCode;

			// Token: 0x04028FB8 RID: 167864
			[Token(Token = "0x4028FB8")]
			[FieldOffset(Offset = "0x20")]
			public string reason;

			// Token: 0x04028FB9 RID: 167865
			[Token(Token = "0x4028FB9")]
			[FieldOffset(Offset = "0x28")]
			public long svrTime;

			// Token: 0x04028FBA RID: 167866
			[Token(Token = "0x4028FBA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FBB RID: 167867
			[Token(Token = "0x4028FBB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050C0 RID: 20672
		[Token(Token = "0x20050C0")]
		public class LeaveDn : Protocol
		{
			// Token: 0x0601E96E RID: 125294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96E")]
			[Address(RVA = "0x184CA20", Offset = "0x184B620", VA = "0x18184CA20")]
			public LeaveDn()
			{
			}

			// Token: 0x04028FBC RID: 167868
			[Token(Token = "0x4028FBC")]
			public const int ID = 710;

			// Token: 0x04028FBD RID: 167869
			[Token(Token = "0x4028FBD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050C1 RID: 20673
		[Token(Token = "0x20050C1")]
		public class TeamSceneStartDn : Protocol
		{
			// Token: 0x0601E96F RID: 125295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E96F")]
			[Address(RVA = "0x184E460", Offset = "0x184D060", VA = "0x18184E460")]
			public TeamSceneStartDn()
			{
			}

			// Token: 0x0601E970 RID: 125296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E970")]
			[Address(RVA = "0x184E370", Offset = "0x184CF70", VA = "0x18184E370", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E971 RID: 125297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E971")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FBE RID: 167870
			[Token(Token = "0x4028FBE")]
			public const int ID = 712;

			// Token: 0x04028FBF RID: 167871
			[Token(Token = "0x4028FBF")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelProtocolRetCode retCode;

			// Token: 0x04028FC0 RID: 167872
			[Token(Token = "0x4028FC0")]
			[FieldOffset(Offset = "0x20")]
			public STDuelSceneInfo sceneInfo;

			// Token: 0x04028FC1 RID: 167873
			[Token(Token = "0x4028FC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FC2 RID: 167874
			[Token(Token = "0x4028FC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050C2 RID: 20674
		[Token(Token = "0x20050C2")]
		public class KickDn : Protocol
		{
			// Token: 0x0601E972 RID: 125298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E972")]
			[Address(RVA = "0x184C9B0", Offset = "0x184B5B0", VA = "0x18184C9B0")]
			public KickDn()
			{
			}

			// Token: 0x0601E973 RID: 125299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E973")]
			[Address(RVA = "0x184C910", Offset = "0x184B510", VA = "0x18184C910", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E974 RID: 125300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E974")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FC3 RID: 167875
			[Token(Token = "0x4028FC3")]
			public const int ID = 714;

			// Token: 0x04028FC4 RID: 167876
			[Token(Token = "0x4028FC4")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelTeamProtocol.KickDn.ReasonType reason;

			// Token: 0x04028FC5 RID: 167877
			[Token(Token = "0x4028FC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FC6 RID: 167878
			[Token(Token = "0x4028FC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;

			// Token: 0x020050C3 RID: 20675
			[Token(Token = "0x20050C3")]
			public enum ReasonType
			{
				// Token: 0x04028FC8 RID: 167880
				[Token(Token = "0x4028FC8")]
				DISBAND,
				// Token: 0x04028FC9 RID: 167881
				[Token(Token = "0x4028FC9")]
				DISLIKE,
				// Token: 0x04028FCA RID: 167882
				[Token(Token = "0x4028FCA")]
				TIMEOUT,
				// Token: 0x04028FCB RID: 167883
				[Token(Token = "0x4028FCB")]
				BATTLE_FINISH_TIMEOUT
			}
		}

		// Token: 0x020050C4 RID: 20676
		[Token(Token = "0x20050C4")]
		public class GetNameCardDn : ResponseProtocol<GetNameCardResponse>
		{
			// Token: 0x0601E975 RID: 125301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E975")]
			[Address(RVA = "0x184C820", Offset = "0x184B420", VA = "0x18184C820")]
			public GetNameCardDn()
			{
			}

			// Token: 0x04028FCC RID: 167884
			[Token(Token = "0x4028FCC")]
			public const int ID = 716;

			// Token: 0x04028FCD RID: 167885
			[Token(Token = "0x4028FCD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050C5 RID: 20677
		[Token(Token = "0x20050C5")]
		public class EnemyDuelTeamStatusDn : ResponseProtocol<EnemyDuelTeamStatus>
		{
			// Token: 0x0601E976 RID: 125302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E976")]
			[Address(RVA = "0x184C2C0", Offset = "0x184AEC0", VA = "0x18184C2C0")]
			public EnemyDuelTeamStatusDn()
			{
			}

			// Token: 0x04028FCE RID: 167886
			[Token(Token = "0x4028FCE")]
			public const int ID = 702;

			// Token: 0x04028FCF RID: 167887
			[Token(Token = "0x4028FCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020050C6 RID: 20678
		[Token(Token = "0x20050C6")]
		public class PlayerDuelStateDn : Protocol
		{
			// Token: 0x0601E977 RID: 125303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E977")]
			[Address(RVA = "0x184CE00", Offset = "0x184BA00", VA = "0x18184CE00")]
			public PlayerDuelStateDn()
			{
			}

			// Token: 0x0601E978 RID: 125304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E978")]
			[Address(RVA = "0x184CD30", Offset = "0x184B930", VA = "0x18184CD30", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E979 RID: 125305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E979")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FD0 RID: 167888
			[Token(Token = "0x4028FD0")]
			public const int ID = 718;

			// Token: 0x04028FD1 RID: 167889
			[Token(Token = "0x4028FD1")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04028FD2 RID: 167890
			[Token(Token = "0x4028FD2")]
			[FieldOffset(Offset = "0x20")]
			public STDuelPlayerStatus.State state;

			// Token: 0x04028FD3 RID: 167891
			[Token(Token = "0x4028FD3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FD4 RID: 167892
			[Token(Token = "0x4028FD4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050C7 RID: 20679
		[Token(Token = "0x20050C7")]
		public class PlayerDuelConnStateDn : Protocol
		{
			// Token: 0x0601E97A RID: 125306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97A")]
			[Address(RVA = "0x184CB60", Offset = "0x184B760", VA = "0x18184CB60")]
			public PlayerDuelConnStateDn()
			{
			}

			// Token: 0x0601E97B RID: 125307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97B")]
			[Address(RVA = "0x184CA90", Offset = "0x184B690", VA = "0x18184CA90", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E97C RID: 125308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97C")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FD5 RID: 167893
			[Token(Token = "0x4028FD5")]
			public const int ID = 720;

			// Token: 0x04028FD6 RID: 167894
			[Token(Token = "0x4028FD6")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04028FD7 RID: 167895
			[Token(Token = "0x4028FD7")]
			[FieldOffset(Offset = "0x20")]
			public bool shouldDelete;

			// Token: 0x04028FD8 RID: 167896
			[Token(Token = "0x4028FD8")]
			[FieldOffset(Offset = "0x21")]
			public bool connLeave;

			// Token: 0x04028FD9 RID: 167897
			[Token(Token = "0x4028FD9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FDA RID: 167898
			[Token(Token = "0x4028FDA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x020050C8 RID: 20680
		[Token(Token = "0x20050C8")]
		public class PlayerDuelNewDn : Protocol
		{
			// Token: 0x0601E97D RID: 125309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97D")]
			[Address(RVA = "0x184CCC0", Offset = "0x184B8C0", VA = "0x18184CCC0")]
			public PlayerDuelNewDn()
			{
			}

			// Token: 0x0601E97E RID: 125310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97E")]
			[Address(RVA = "0x184CBD0", Offset = "0x184B7D0", VA = "0x18184CBD0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x0601E97F RID: 125311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E97F")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04028FDB RID: 167899
			[Token(Token = "0x4028FDB")]
			public const int ID = 722;

			// Token: 0x04028FDC RID: 167900
			[Token(Token = "0x4028FDC")]
			[FieldOffset(Offset = "0x18")]
			public STDuelPlayerStatus player;

			// Token: 0x04028FDD RID: 167901
			[Token(Token = "0x4028FDD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028FDE RID: 167902
			[Token(Token = "0x4028FDE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}
	}
}
