using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034B8 RID: 13496
	[Token(Token = "0x20034B8")]
	public class BattleInfoCache : Singleton<BattleInfoCache>
	{
		// Token: 0x06015828 RID: 88104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015828")]
		[Address(RVA = "0xDF9F10", Offset = "0xDF8B10", VA = "0x180DF9F10")]
		private BattleInfoCache()
		{
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x06015829 RID: 88105 RVA: 0x0008C580 File Offset: 0x0008A780
		[Token(Token = "0x170032CC")]
		public static BattleInfoCache.Data data
		{
			[Token(Token = "0x6015829")]
			[Address(RVA = "0xDF9FE0", Offset = "0xDF8BE0", VA = "0x180DF9FE0")]
			get
			{
				return default(BattleInfoCache.Data);
			}
		}

		// Token: 0x0601582A RID: 88106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601582A")]
		[Address(RVA = "0xDF9B90", Offset = "0xDF8790", VA = "0x180DF9B90")]
		public static void CacheData(BattleInfoCache.Data paramData)
		{
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0601582B RID: 88107 RVA: 0x0008C598 File Offset: 0x0008A798
		// (set) Token: 0x0601582C RID: 88108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032CD")]
		public static BattleInfoCache.MultipleData multipleData
		{
			[Token(Token = "0x601582B")]
			[Address(RVA = "0xDFA1D0", Offset = "0xDF8DD0", VA = "0x180DFA1D0")]
			get
			{
				return default(BattleInfoCache.MultipleData);
			}
			[Token(Token = "0x601582C")]
			[Address(RVA = "0xDFA2D0", Offset = "0xDF8ED0", VA = "0x180DFA2D0")]
			private set
			{
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0601582D RID: 88109 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		[Token(Token = "0x170032CE")]
		public static bool isRestartGame
		{
			[Token(Token = "0x601582D")]
			[Address(RVA = "0xDFA160", Offset = "0xDF8D60", VA = "0x180DFA160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0601582E RID: 88110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032CF")]
		public static List<int> restartCompleteTimes
		{
			[Token(Token = "0x601582E")]
			[Address(RVA = "0xDFA260", Offset = "0xDF8E60", VA = "0x180DFA260")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601582F RID: 88111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601582F")]
		[Address(RVA = "0xDF9C50", Offset = "0xDF8850", VA = "0x180DF9C50")]
		public static void CacheMultipleData(BattleInfoCache.MultipleData contData)
		{
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x06015830 RID: 88112 RVA: 0x0008C5C8 File Offset: 0x0008A7C8
		[Token(Token = "0x170032D0")]
		public static bool hasMultipleData
		{
			[Token(Token = "0x6015830")]
			[Address(RVA = "0xDFA090", Offset = "0xDF8C90", VA = "0x180DFA090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015831")]
		[Address(RVA = "0xDF9D20", Offset = "0xDF8920", VA = "0x180DF9D20")]
		public static void ClearMultipleData()
		{
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015832")]
		[Address(RVA = "0xDF9E90", Offset = "0xDF8A90", VA = "0x180DF9E90")]
		public static void SetIsRestartGame(bool isRestartGame)
		{
		}

		// Token: 0x06015833 RID: 88115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015833")]
		[Address(RVA = "0xDF9AB0", Offset = "0xDF86B0", VA = "0x180DF9AB0")]
		public static void CacheCompleteTimeBeforeRestart(int completeTime)
		{
		}

		// Token: 0x06015834 RID: 88116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015834")]
		[Address(RVA = "0xDF9E00", Offset = "0xDF8A00", VA = "0x180DF9E00")]
		public static void ClearRestartData()
		{
		}

		// Token: 0x04019C61 RID: 105569
		[Token(Token = "0x4019C61")]
		[FieldOffset(Offset = "0x10")]
		private BattleInfoCache.Data m_data;

		// Token: 0x04019C62 RID: 105570
		[Token(Token = "0x4019C62")]
		[FieldOffset(Offset = "0x40")]
		private BattleInfoCache.MultipleData m_multipleData;

		// Token: 0x04019C63 RID: 105571
		[Token(Token = "0x4019C63")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isRestartGame;

		// Token: 0x04019C64 RID: 105572
		[Token(Token = "0x4019C64")]
		[FieldOffset(Offset = "0x58")]
		private List<int> m_restartCompleteTimes;

		// Token: 0x04019C65 RID: 105573
		[Token(Token = "0x4019C65")]
		[FieldOffset(Offset = "0x0")]
		public static uint cacheStartUniqueId;

		// Token: 0x04019C66 RID: 105574
		[Token(Token = "0x4019C66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019C67 RID: 105575
		[Token(Token = "0x4019C67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04019C68 RID: 105576
		[Token(Token = "0x4019C68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CacheData;

		// Token: 0x04019C69 RID: 105577
		[Token(Token = "0x4019C69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_multipleData;

		// Token: 0x04019C6A RID: 105578
		[Token(Token = "0x4019C6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_multipleData;

		// Token: 0x04019C6B RID: 105579
		[Token(Token = "0x4019C6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isRestartGame;

		// Token: 0x04019C6C RID: 105580
		[Token(Token = "0x4019C6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_restartCompleteTimes;

		// Token: 0x04019C6D RID: 105581
		[Token(Token = "0x4019C6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CacheMultipleData;

		// Token: 0x04019C6E RID: 105582
		[Token(Token = "0x4019C6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hasMultipleData;

		// Token: 0x04019C6F RID: 105583
		[Token(Token = "0x4019C6F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearMultipleData;

		// Token: 0x04019C70 RID: 105584
		[Token(Token = "0x4019C70")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetIsRestartGame;

		// Token: 0x04019C71 RID: 105585
		[Token(Token = "0x4019C71")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CacheCompleteTimeBeforeRestart;

		// Token: 0x04019C72 RID: 105586
		[Token(Token = "0x4019C72")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClearRestartData;

		// Token: 0x020034B9 RID: 13497
		[Token(Token = "0x20034B9")]
		public struct Data
		{
			// Token: 0x04019C73 RID: 105587
			[Token(Token = "0x4019C73")]
			[FieldOffset(Offset = "0x0")]
			public StageId stage;

			// Token: 0x04019C74 RID: 105588
			[Token(Token = "0x4019C74")]
			[FieldOffset(Offset = "0x18")]
			public ISceneParam stageSceneParam;

			// Token: 0x04019C75 RID: 105589
			[Token(Token = "0x4019C75")]
			[FieldOffset(Offset = "0x20")]
			public int playerLevel;

			// Token: 0x04019C76 RID: 105590
			[Token(Token = "0x4019C76")]
			[FieldOffset(Offset = "0x24")]
			public int playerExp;

			// Token: 0x04019C77 RID: 105591
			[Token(Token = "0x4019C77")]
			[FieldOffset(Offset = "0x28")]
			public int playerMaxAp;
		}

		// Token: 0x020034BA RID: 13498
		[Token(Token = "0x20034BA")]
		public struct MultipleData
		{
			// Token: 0x04019C78 RID: 105592
			[Token(Token = "0x4019C78")]
			[FieldOffset(Offset = "0x0")]
			public string battleId;

			// Token: 0x04019C79 RID: 105593
			[Token(Token = "0x4019C79")]
			[FieldOffset(Offset = "0x8")]
			public int apFailReturn;
		}
	}
}
