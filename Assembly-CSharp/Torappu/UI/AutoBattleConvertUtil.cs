using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036AA RID: 13994
	[Token(Token = "0x20036AA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class AutoBattleConvertUtil
	{
		// Token: 0x060163E5 RID: 91109 RVA: 0x00090120 File Offset: 0x0008E320
		[Token(Token = "0x60163E5")]
		[Address(RVA = "0xEAB940", Offset = "0xEAA540", VA = "0x180EAB940")]
		public static bool TryLoadBattleLogFromMem(string stageId, out AutoBattleConvertUtil.BattleLog battleLog)
		{
			return default(bool);
		}

		// Token: 0x060163E6 RID: 91110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163E6")]
		[Address(RVA = "0xEAAF30", Offset = "0xEA9B30", VA = "0x180EAAF30")]
		public static void SaveBattleLogToMem(string stageId, AutoBattleConvertUtil.BattleLog battleLog)
		{
		}

		// Token: 0x060163E7 RID: 91111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163E7")]
		[Address(RVA = "0xEAA0A0", Offset = "0xEA8CA0", VA = "0x180EAA0A0")]
		public static string CompressString(string str)
		{
			return null;
		}

		// Token: 0x060163E8 RID: 91112 RVA: 0x00090138 File Offset: 0x0008E338
		[Token(Token = "0x60163E8")]
		[Address(RVA = "0xEAB520", Offset = "0xEAA120", VA = "0x180EAB520")]
		public static bool TryDecompressString(string data, out string ret)
		{
			return default(bool);
		}

		// Token: 0x060163E9 RID: 91113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163E9")]
		[Address(RVA = "0xEA9EE0", Offset = "0xEA8AE0", VA = "0x180EA9EE0")]
		public static string CompressBattleLog(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163EA RID: 91114 RVA: 0x00090150 File Offset: 0x0008E350
		[Token(Token = "0x60163EA")]
		[Address(RVA = "0xEAB2A0", Offset = "0xEA9EA0", VA = "0x180EAB2A0")]
		public static bool TryDecompressBattleLog(string data, out AutoBattleConvertUtil.BattleLog battleLog)
		{
			return default(bool);
		}

		// Token: 0x060163EB RID: 91115 RVA: 0x00090168 File Offset: 0x0008E368
		[Token(Token = "0x60163EB")]
		[Address(RVA = "0xEABBB0", Offset = "0xEAA7B0", VA = "0x180EABBB0")]
		public static bool VerifyBattleLog(AutoBattleConvertUtil.BattleLog battleLog, [Optional] Predicate<AutoBattleConvertUtil.VerifyOption> excludePredicate)
		{
			return default(bool);
		}

		// Token: 0x060163EC RID: 91116 RVA: 0x00090180 File Offset: 0x0008E380
		[Token(Token = "0x60163EC")]
		[Address(RVA = "0xEA9CD0", Offset = "0xEA88D0", VA = "0x180EA9CD0")]
		public static bool CanStageAutoBattle(BattleStageInfo stage, PlayerBattleRank rank)
		{
			return default(bool);
		}

		// Token: 0x060163ED RID: 91117 RVA: 0x00090198 File Offset: 0x0008E398
		[Token(Token = "0x60163ED")]
		[Address(RVA = "0xEA9E70", Offset = "0xEA8A70", VA = "0x180EA9E70")]
		public static bool CheckStageTypeCanHaveIncompletedBattleLog(StageType stageType)
		{
			return default(bool);
		}

		// Token: 0x060163EE RID: 91118 RVA: 0x000901B0 File Offset: 0x0008E3B0
		[Token(Token = "0x60163EE")]
		[Address(RVA = "0xEAAE90", Offset = "0xEA9A90", VA = "0x180EAAE90")]
		public static bool HasStageBattleLog(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060163EF RID: 91119 RVA: 0x000901C8 File Offset: 0x0008E3C8
		[Token(Token = "0x60163EF")]
		[Address(RVA = "0xEAA300", Offset = "0xEA8F00", VA = "0x180EAA300")]
		public static AutoBattleConvertUtil.BattleLog CreateBattleLog(BattleLogger.Journal journal, out AutoBattleConvertUtil.BattleLog oldLog, [Optional] BattleLogMeta battleLogMeta)
		{
			return default(AutoBattleConvertUtil.BattleLog);
		}

		// Token: 0x060163F0 RID: 91120 RVA: 0x000901E0 File Offset: 0x0008E3E0
		[Token(Token = "0x60163F0")]
		[Address(RVA = "0xEAA6F0", Offset = "0xEA92F0", VA = "0x180EAA6F0")]
		public static AutoBattleConvertUtil.BattleLog CreateBattleLog(BattleLogger.Journal journal, [Optional] BattleLogMeta battleLogMeta)
		{
			return default(AutoBattleConvertUtil.BattleLog);
		}

		// Token: 0x060163F1 RID: 91121 RVA: 0x000901F8 File Offset: 0x0008E3F8
		[Token(Token = "0x60163F1")]
		[Address(RVA = "0xEABF00", Offset = "0xEAAB00", VA = "0x180EABF00")]
		private static AutoBattleConvertUtil.BattleLog _DoBattleLogMigration(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return default(AutoBattleConvertUtil.BattleLog);
		}

		// Token: 0x060163F2 RID: 91122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F2")]
		[Address(RVA = "0xEAA990", Offset = "0xEA9590", VA = "0x180EAA990")]
		public static List<string> GetBattleCharmsList(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163F3 RID: 91123 RVA: 0x00090210 File Offset: 0x0008E410
		[Token(Token = "0x60163F3")]
		[Address(RVA = "0xEAB7C0", Offset = "0xEAA3C0", VA = "0x180EAB7C0")]
		public static bool TryGetBattleFireworkInfo(AutoBattleConvertUtil.BattleLog battleLog, out string animalId, out List<FireworkData.PlateSlotData> slotList)
		{
			return default(bool);
		}

		// Token: 0x060163F4 RID: 91124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F4")]
		[Address(RVA = "0xEAAD90", Offset = "0xEA9990", VA = "0x180EAAD90")]
		public static List<string> GetTemplateTrapList(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163F5 RID: 91125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F5")]
		[Address(RVA = "0xEAAB90", Offset = "0xEA9790", VA = "0x180EAAB90")]
		public static List<string> GetBattleTechesList(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163F6 RID: 91126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F6")]
		[Address(RVA = "0xEAA890", Offset = "0xEA9490", VA = "0x180EAA890")]
		public static Dictionary<CartComponents.CartAccessoryPos, string> GetBattleCartDict(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163F7 RID: 91127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F7")]
		[Address(RVA = "0xEAAC90", Offset = "0xEA9890", VA = "0x180EAAC90")]
		public static List<string> GetBattleTrapToolsList(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x060163F8 RID: 91128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163F8")]
		[Address(RVA = "0xEAAA90", Offset = "0xEA9690", VA = "0x180EAAA90")]
		public static List<string> GetBattlePerformanceList(AutoBattleConvertUtil.BattleLog battleLog)
		{
			return null;
		}

		// Token: 0x0401ABF5 RID: 109557
		[Token(Token = "0x401ABF5")]
		private const int BATTLE_LOG_CACHE_SIZE = 5;

		// Token: 0x0401ABF6 RID: 109558
		[Token(Token = "0x401ABF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AutoBattleConvertUtil.BattleLogMemCache s_memCache;

		// Token: 0x0401ABF7 RID: 109559
		[Token(Token = "0x401ABF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryLoadBattleLogFromMem;

		// Token: 0x0401ABF8 RID: 109560
		[Token(Token = "0x401ABF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveBattleLogToMem;

		// Token: 0x0401ABF9 RID: 109561
		[Token(Token = "0x401ABF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompressString;

		// Token: 0x0401ABFA RID: 109562
		[Token(Token = "0x401ABFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryDecompressString;

		// Token: 0x0401ABFB RID: 109563
		[Token(Token = "0x401ABFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CompressBattleLog;

		// Token: 0x0401ABFC RID: 109564
		[Token(Token = "0x401ABFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryDecompressBattleLog;

		// Token: 0x0401ABFD RID: 109565
		[Token(Token = "0x401ABFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_VerifyBattleLog;

		// Token: 0x0401ABFE RID: 109566
		[Token(Token = "0x401ABFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CanStageAutoBattle;

		// Token: 0x0401ABFF RID: 109567
		[Token(Token = "0x401ABFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckStageTypeCanHaveIncompletedBattleLog;

		// Token: 0x0401AC00 RID: 109568
		[Token(Token = "0x401AC00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HasStageBattleLog;

		// Token: 0x0401AC01 RID: 109569
		[Token(Token = "0x401AC01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateBattleLog;

		// Token: 0x0401AC02 RID: 109570
		[Token(Token = "0x401AC02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_CreateBattleLog;

		// Token: 0x0401AC03 RID: 109571
		[Token(Token = "0x401AC03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoBattleLogMigration;

		// Token: 0x0401AC04 RID: 109572
		[Token(Token = "0x401AC04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetBattleCharmsList;

		// Token: 0x0401AC05 RID: 109573
		[Token(Token = "0x401AC05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetBattleFireworkInfo;

		// Token: 0x0401AC06 RID: 109574
		[Token(Token = "0x401AC06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetTemplateTrapList;

		// Token: 0x0401AC07 RID: 109575
		[Token(Token = "0x401AC07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetBattleTechesList;

		// Token: 0x0401AC08 RID: 109576
		[Token(Token = "0x401AC08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetBattleCartDict;

		// Token: 0x0401AC09 RID: 109577
		[Token(Token = "0x401AC09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetBattleTrapToolsList;

		// Token: 0x0401AC0A RID: 109578
		[Token(Token = "0x401AC0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetBattlePerformanceList;

		// Token: 0x020036AB RID: 13995
		[Token(Token = "0x20036AB")]
		public struct BattleLog
		{
			// Token: 0x060163FA RID: 91130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60163FA")]
			[Address(RVA = "0xEAD160", Offset = "0xEABD60", VA = "0x180EAD160")]
			public StringBuilder ToStringBuilder()
			{
				return null;
			}

			// Token: 0x060163FB RID: 91131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60163FB")]
			[Address(RVA = "0xEAD2E0", Offset = "0xEABEE0", VA = "0x180EAD2E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060163FC RID: 91132 RVA: 0x00090228 File Offset: 0x0008E428
			[Token(Token = "0x60163FC")]
			[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060163FD RID: 91133 RVA: 0x00090240 File Offset: 0x0008E440
			[Token(Token = "0x60163FD")]
			[Address(RVA = "0xEAD130", Offset = "0xEABD30", VA = "0x180EAD130")]
			public bool ShouldSerializebattleMeta()
			{
				return default(bool);
			}

			// Token: 0x0401AC0B RID: 109579
			[Token(Token = "0x401AC0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly AutoBattleConvertUtil.BattleLog EMPTY;

			// Token: 0x0401AC0C RID: 109580
			[Token(Token = "0x401AC0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint campaignOnlyVersion;

			// Token: 0x0401AC0D RID: 109581
			[Token(Token = "0x401AC0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string timestamp;

			// Token: 0x0401AC0E RID: 109582
			[Token(Token = "0x401AC0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BattleLogger.Journal journal;

			// Token: 0x0401AC0F RID: 109583
			[Token(Token = "0x401AC0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public BattleLogMeta battleMeta;
		}

		// Token: 0x020036AC RID: 13996
		[Token(Token = "0x20036AC")]
		public struct AIRLBattleLog
		{
			// Token: 0x0401AC10 RID: 109584
			[Token(Token = "0x401AC10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string result;

			// Token: 0x0401AC11 RID: 109585
			[Token(Token = "0x401AC11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string battleLog;

			// Token: 0x0401AC12 RID: 109586
			[Token(Token = "0x401AC12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string level;

			// Token: 0x0401AC13 RID: 109587
			[Token(Token = "0x401AC13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string rune;
		}

		// Token: 0x020036AD RID: 13997
		[Token(Token = "0x20036AD")]
		public class VerifyOption
		{
			// Token: 0x060163FF RID: 91135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60163FF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VerifyOption()
			{
			}

			// Token: 0x0401AC14 RID: 109588
			[Token(Token = "0x401AC14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BattleLogMeta battleLogMeta;

			// Token: 0x0401AC15 RID: 109589
			[Token(Token = "0x401AC15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleLogger.CharInfo charInfo;
		}

		// Token: 0x020036AE RID: 13998
		[Token(Token = "0x20036AE")]
		private class BattleLogMemCache : IHotfixable
		{
			// Token: 0x06016400 RID: 91136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016400")]
			[Address(RVA = "0xEAC380", Offset = "0xEAAF80", VA = "0x180EAC380")]
			public void Save(string key, AutoBattleConvertUtil.BattleLog value)
			{
			}

			// Token: 0x06016401 RID: 91137 RVA: 0x00090258 File Offset: 0x0008E458
			[Token(Token = "0x6016401")]
			[Address(RVA = "0xEAC600", Offset = "0xEAB200", VA = "0x180EAC600")]
			public bool TryGet(string key, out AutoBattleConvertUtil.BattleLog ret)
			{
				return default(bool);
			}

			// Token: 0x06016402 RID: 91138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016402")]
			[Address(RVA = "0xEAC7F0", Offset = "0xEAB3F0", VA = "0x180EAC7F0")]
			private void _UpdateLoginInfoAndAutoClear()
			{
			}

			// Token: 0x06016403 RID: 91139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016403")]
			[Address(RVA = "0xEAC8A0", Offset = "0xEAB4A0", VA = "0x180EAC8A0")]
			public BattleLogMemCache()
			{
			}

			// Token: 0x0401AC16 RID: 109590
			[Token(Token = "0x401AC16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private LRUCache<string, AutoBattleConvertUtil.BattleLogMemCache.Wrapper> m_cache;

			// Token: 0x0401AC17 RID: 109591
			[Token(Token = "0x401AC17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private uint m_loginHash;

			// Token: 0x0401AC18 RID: 109592
			[Token(Token = "0x401AC18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Save;

			// Token: 0x0401AC19 RID: 109593
			[Token(Token = "0x401AC19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TryGet;

			// Token: 0x0401AC1A RID: 109594
			[Token(Token = "0x401AC1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__UpdateLoginInfoAndAutoClear;

			// Token: 0x0401AC1B RID: 109595
			[Token(Token = "0x401AC1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020036AF RID: 13999
			[Token(Token = "0x20036AF")]
			private class Wrapper
			{
				// Token: 0x06016404 RID: 91140 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6016404")]
				[Address(RVA = "0xEBFE80", Offset = "0xEBEA80", VA = "0x180EBFE80")]
				public Wrapper(AutoBattleConvertUtil.BattleLog pVal)
				{
				}

				// Token: 0x0401AC1C RID: 109596
				[Token(Token = "0x401AC1C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public AutoBattleConvertUtil.BattleLog value;
			}
		}
	}
}
