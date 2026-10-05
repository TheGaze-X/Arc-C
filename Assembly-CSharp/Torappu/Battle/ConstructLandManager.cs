using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Sandbox;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002315 RID: 8981
	[Token(Token = "0x2002315")]
	public class ConstructLandManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C74")]
		private SandboxV2Data dataTable
		{
			[Token(Token = "0x600E2C7")]
			[Address(RVA = "0x567960", Offset = "0x566560", VA = "0x180567960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x0600E2C8 RID: 58056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C75")]
		private PlayerSandboxV2 playerSandboxV2
		{
			[Token(Token = "0x600E2C8")]
			[Address(RVA = "0x567C10", Offset = "0x566810", VA = "0x180567C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600E2C9 RID: 58057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C76")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E2C9")]
			[Address(RVA = "0x5679F0", Offset = "0x5665F0", VA = "0x1805679F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E2CA RID: 58058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CA")]
		[Address(RVA = "0x566840", Offset = "0x565440", VA = "0x180566840", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E2CB RID: 58059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CB")]
		[Address(RVA = "0x567730", Offset = "0x566330", VA = "0x180567730")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CC")]
		[Address(RVA = "0x567240", Offset = "0x565E40", VA = "0x180567240")]
		private void _OnGameReady(object arg)
		{
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CD")]
		[Address(RVA = "0x566E20", Offset = "0x565A20", VA = "0x180566E20")]
		private void _OnDeckCreated(object arg)
		{
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CE")]
		[Address(RVA = "0x5669F0", Offset = "0x5655F0", VA = "0x1805669F0")]
		private void _BindDefaultDeckEvent(Deck deck)
		{
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2CF")]
		[Address(RVA = "0x566CB0", Offset = "0x5658B0", VA = "0x180566CB0")]
		private void _OnCardSpawn(GridPosition pos, SharedConsts.Direction dir, Deck.Card card)
		{
		}

		// Token: 0x0600E2D0 RID: 58064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D0")]
		[Address(RVA = "0x5677D0", Offset = "0x5663D0", VA = "0x1805677D0")]
		private void _OnPageResume(object arg)
		{
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D1")]
		[Address(RVA = "0x566FD0", Offset = "0x565BD0", VA = "0x180566FD0")]
		private void _OnDoResetMap(object arg)
		{
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D2")]
		[Address(RVA = "0x566BF0", Offset = "0x5657F0", VA = "0x180566BF0")]
		private void _DoSaveMap(object arg)
		{
		}

		// Token: 0x0600E2D3 RID: 58067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D3")]
		[Address(RVA = "0x566700", Offset = "0x565300", VA = "0x180566700")]
		public void DoOperation(IConstructOp op)
		{
		}

		// Token: 0x0600E2D4 RID: 58068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D4")]
		[Address(RVA = "0x567860", Offset = "0x566460", VA = "0x180567860")]
		public ConstructLandManager()
		{
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2D5")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2D6")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0400F8B8 RID: 63672
		[Token(Token = "0x400F8B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_gameStarted;

		// Token: 0x0400F8B9 RID: 63673
		[Token(Token = "0x400F8B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<IConstructOp> m_opQueue;

		// Token: 0x0400F8BA RID: 63674
		[Token(Token = "0x400F8BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ListDict<string, Deck.TokenCard> m_cards;

		// Token: 0x0400F8BB RID: 63675
		[Token(Token = "0x400F8BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ConstructLandManager.SyncHelper m_syncHelper;

		// Token: 0x0400F8BC RID: 63676
		[Token(Token = "0x400F8BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataTable;

		// Token: 0x0400F8BD RID: 63677
		[Token(Token = "0x400F8BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playerSandboxV2;

		// Token: 0x0400F8BE RID: 63678
		[Token(Token = "0x400F8BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F8BF RID: 63679
		[Token(Token = "0x400F8BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F8C0 RID: 63680
		[Token(Token = "0x400F8C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F8C1 RID: 63681
		[Token(Token = "0x400F8C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnGameReady;

		// Token: 0x0400F8C2 RID: 63682
		[Token(Token = "0x400F8C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDeckCreated;

		// Token: 0x0400F8C3 RID: 63683
		[Token(Token = "0x400F8C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BindDefaultDeckEvent;

		// Token: 0x0400F8C4 RID: 63684
		[Token(Token = "0x400F8C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCardSpawn;

		// Token: 0x0400F8C5 RID: 63685
		[Token(Token = "0x400F8C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnPageResume;

		// Token: 0x0400F8C6 RID: 63686
		[Token(Token = "0x400F8C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDoResetMap;

		// Token: 0x0400F8C7 RID: 63687
		[Token(Token = "0x400F8C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoSaveMap;

		// Token: 0x0400F8C8 RID: 63688
		[Token(Token = "0x400F8C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoOperation;

		// Token: 0x0400F8C9 RID: 63689
		[Token(Token = "0x400F8C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002316 RID: 8982
		[Token(Token = "0x2002316")]
		private class SyncHelper : IHotfixable
		{
			// Token: 0x0600E2D7 RID: 58071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2D7")]
			[Address(RVA = "0x57E7C0", Offset = "0x57D3C0", VA = "0x18057E7C0")]
			public SyncHelper(ConstructLandManager manager)
			{
			}

			// Token: 0x0600E2D8 RID: 58072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2D8")]
			[Address(RVA = "0x57CA70", Offset = "0x57B670", VA = "0x18057CA70")]
			public void DoSync(bool isMapNeedCheck, bool isDeckAndResNeedCheck)
			{
			}

			// Token: 0x0600E2D9 RID: 58073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2D9")]
			[Address(RVA = "0x57D190", Offset = "0x57BD90", VA = "0x18057D190")]
			private void _RefreshMap(PlayerSandboxV2.Dungeon.NodeStage nodeStage, bool needCheck = false)
			{
			}

			// Token: 0x0600E2DA RID: 58074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2DA")]
			[Address(RVA = "0x57E440", Offset = "0x57D040", VA = "0x18057E440")]
			private void _RefreshTile(PlayerSandboxV2.Dungeon.Building building, GridPosition gridPosition, [Optional] Character character, bool needCheck = false)
			{
			}

			// Token: 0x0600E2DB RID: 58075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2DB")]
			[Address(RVA = "0x57CF90", Offset = "0x57BB90", VA = "0x18057CF90")]
			private static void _RefreshHp(float targetHpRatio, GridPosition gridPosition, Character character, bool needCheck)
			{
			}

			// Token: 0x0600E2DC RID: 58076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2DC")]
			[Address(RVA = "0x57CCB0", Offset = "0x57B8B0", VA = "0x18057CCB0")]
			private void _RefreshDeck(bool needCheck = false)
			{
			}

			// Token: 0x0600E2DD RID: 58077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2DD")]
			[Address(RVA = "0x57E090", Offset = "0x57CC90", VA = "0x18057E090")]
			private void _RefreshRes(bool needCheck = false)
			{
			}

			// Token: 0x0400F8CA RID: 63690
			[Token(Token = "0x400F8CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<GridPosition, PlayerSandboxV2.Dungeon.Building> m_buildingCache;

			// Token: 0x0400F8CB RID: 63691
			[Token(Token = "0x400F8CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<GridPosition, PlayerSandboxV2.Dungeon.EntityStatus> m_statusCache;

			// Token: 0x0400F8CC RID: 63692
			[Token(Token = "0x400F8CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ConstructLandManager m_manager;

			// Token: 0x0400F8CD RID: 63693
			[Token(Token = "0x400F8CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400F8CE RID: 63694
			[Token(Token = "0x400F8CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DoSync;

			// Token: 0x0400F8CF RID: 63695
			[Token(Token = "0x400F8CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__RefreshMap;

			// Token: 0x0400F8D0 RID: 63696
			[Token(Token = "0x400F8D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__RefreshTile;

			// Token: 0x0400F8D1 RID: 63697
			[Token(Token = "0x400F8D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RefreshHp;

			// Token: 0x0400F8D2 RID: 63698
			[Token(Token = "0x400F8D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__RefreshDeck;

			// Token: 0x0400F8D3 RID: 63699
			[Token(Token = "0x400F8D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__RefreshRes;
		}
	}
}
