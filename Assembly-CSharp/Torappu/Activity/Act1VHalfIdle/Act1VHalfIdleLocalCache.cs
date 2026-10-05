using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076B7 RID: 30391
	[Token(Token = "0x20076B7")]
	public class Act1VHalfIdleLocalCache : Singleton<Act1VHalfIdleLocalCache>
	{
		// Token: 0x0602ABDD RID: 175069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABDD")]
		[Address(RVA = "0x268A470", Offset = "0x2689070", VA = "0x18268A470")]
		private Act1VHalfIdleLocalCache()
		{
		}

		// Token: 0x0602ABDE RID: 175070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABDE")]
		[Address(RVA = "0x268A170", Offset = "0x2688D70", VA = "0x18268A170")]
		private Act1VHalfIdleLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0602ABDF RID: 175071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABDF")]
		[Address(RVA = "0x2689FB0", Offset = "0x2688BB0", VA = "0x182689FB0")]
		private Act1VHalfIdleLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x0602ABE0 RID: 175072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABE0")]
		[Address(RVA = "0x268A2B0", Offset = "0x2688EB0", VA = "0x18268A2B0")]
		private Act1VHalfIdleLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x0602ABE1 RID: 175073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABE1")]
		[Address(RVA = "0x268A3E0", Offset = "0x2688FE0", VA = "0x18268A3E0")]
		private void _SaveData(Act1VHalfIdleLocalCache.ActData data)
		{
		}

		// Token: 0x0602ABE2 RID: 175074 RVA: 0x000D9C08 File Offset: 0x000D7E08
		[Token(Token = "0x602ABE2")]
		[Address(RVA = "0x2688990", Offset = "0x2687590", VA = "0x182688990")]
		public int GetDepotBuffLevel(string actId, ProfessionCategory prof)
		{
			return 0;
		}

		// Token: 0x0602ABE3 RID: 175075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABE3")]
		[Address(RVA = "0x2689E50", Offset = "0x2688A50", VA = "0x182689E50")]
		public void SetDepotBuffLevel(string actId, ProfessionCategory prof, int level)
		{
		}

		// Token: 0x0602ABE4 RID: 175076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABE4")]
		[Address(RVA = "0x2688CA0", Offset = "0x26878A0", VA = "0x182688CA0")]
		public Dictionary<Act1VHalfIdlePlotType, List<string>> GetPassedStagePlotSquadDict(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0602ABE5 RID: 175077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABE5")]
		[Address(RVA = "0x2689920", Offset = "0x2688520", VA = "0x182689920")]
		public void SavePassedStagePlotSquadDict(string actId, string stageId, Dictionary<Act1VHalfIdlePlotType, List<string>> plotDict)
		{
		}

		// Token: 0x0602ABE6 RID: 175078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABE6")]
		[Address(RVA = "0x2688D80", Offset = "0x2687980", VA = "0x182688D80")]
		public Dictionary<Act1VHalfIdlePlotType, List<string>> GetPlotSquadDictByStageId(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0602ABE7 RID: 175079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABE7")]
		[Address(RVA = "0x2689CC0", Offset = "0x26888C0", VA = "0x182689CC0")]
		public void SavePlotSquadDictByStageId(string actId, string stageId, Dictionary<Act1VHalfIdlePlotType, List<string>> squadDict)
		{
		}

		// Token: 0x0602ABE8 RID: 175080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABE8")]
		[Address(RVA = "0x2689A90", Offset = "0x2688690", VA = "0x182689A90")]
		public void SavePlotSquadByStageId(string actId, string stageId, Act1VHalfIdlePlotType type, List<string> plotIds)
		{
		}

		// Token: 0x0602ABE9 RID: 175081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABE9")]
		[Address(RVA = "0x2688810", Offset = "0x2687410", VA = "0x182688810")]
		public List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache> GetCharSquadByStageId(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0602ABEA RID: 175082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABEA")]
		[Address(RVA = "0x26893C0", Offset = "0x2687FC0", VA = "0x1826893C0")]
		public void SaveCharSquadByStageId(string actId, string stageId, List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache> charSquadCache)
		{
		}

		// Token: 0x0602ABEB RID: 175083 RVA: 0x000D9C20 File Offset: 0x000D7E20
		[Token(Token = "0x602ABEB")]
		[Address(RVA = "0x2688590", Offset = "0x2687190", VA = "0x182688590")]
		public bool GetBattleEquipAutoUpgradeOn(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602ABEC RID: 175084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABEC")]
		[Address(RVA = "0x2688E50", Offset = "0x2687A50", VA = "0x182688E50")]
		public void SaveBattleEquipAutoUpgradeOn(string actId, bool battleEquipAutoUpgradeOn)
		{
		}

		// Token: 0x0602ABED RID: 175085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABED")]
		[Address(RVA = "0x2688BC0", Offset = "0x26877C0", VA = "0x182688BC0")]
		public List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache> GetPassStageSquadByStageId(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0602ABEE RID: 175086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABEE")]
		[Address(RVA = "0x26897B0", Offset = "0x26883B0", VA = "0x1826897B0")]
		public void SavePassStageSquadByStageId(string actId, string stageId, List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache> charSquadCache)
		{
		}

		// Token: 0x0602ABEF RID: 175087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABEF")]
		[Address(RVA = "0x2688720", Offset = "0x2687320", VA = "0x182688720")]
		public string GetCharDefaultSkill(string actId, string instId)
		{
			return null;
		}

		// Token: 0x0602ABF0 RID: 175088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF0")]
		[Address(RVA = "0x2689170", Offset = "0x2687D70", VA = "0x182689170")]
		public void SaveCharDefaultSkills(string actId, List<Act1VHalfIdleCharDepotCharSelectPlugin.CharDataCache> charSkills)
		{
		}

		// Token: 0x0602ABF1 RID: 175089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABF1")]
		[Address(RVA = "0x2688630", Offset = "0x2687230", VA = "0x182688630")]
		public string GetCharDefaultEquip(string actId, string instId)
		{
			return null;
		}

		// Token: 0x0602ABF2 RID: 175090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF2")]
		[Address(RVA = "0x2688F20", Offset = "0x2687B20", VA = "0x182688F20")]
		public void SaveCharDefaultEquips(string actId, List<Act1VHalfIdleCharDepotCharSelectPlugin.CharDataCache> charEqupis)
		{
		}

		// Token: 0x0602ABF3 RID: 175091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABF3")]
		[Address(RVA = "0x2688370", Offset = "0x2686F70", VA = "0x182688370")]
		public string EnsureCharSnapShotEquip(string actId, string charInstId, string charId)
		{
			return null;
		}

		// Token: 0x0602ABF4 RID: 175092 RVA: 0x000D9C38 File Offset: 0x000D7E38
		[Token(Token = "0x602ABF4")]
		[Address(RVA = "0x26888F0", Offset = "0x26874F0", VA = "0x1826888F0")]
		public ProfessionCategory GetDefaultAssistProf(string actId)
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x0602ABF5 RID: 175093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF5")]
		[Address(RVA = "0x2689530", Offset = "0x2688130", VA = "0x182689530")]
		public void SaveDefaultAssistProf(string actId, ProfessionCategory prof)
		{
		}

		// Token: 0x0602ABF6 RID: 175094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABF6")]
		[Address(RVA = "0x2688B30", Offset = "0x2687730", VA = "0x182688B30")]
		public string GetNewUnlockNormStageId(string actId)
		{
			return null;
		}

		// Token: 0x0602ABF7 RID: 175095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF7")]
		[Address(RVA = "0x26896D0", Offset = "0x26882D0", VA = "0x1826896D0")]
		public void SaveNewUnlockNormStageId(string actId, string stageId)
		{
		}

		// Token: 0x0602ABF8 RID: 175096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF8")]
		[Address(RVA = "0x26882B0", Offset = "0x2686EB0", VA = "0x1826882B0")]
		public void ClearSaveNewUnlockNormStageId(string actId)
		{
		}

		// Token: 0x0602ABF9 RID: 175097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABF9")]
		[Address(RVA = "0x26895F0", Offset = "0x26881F0", VA = "0x1826895F0")]
		public void SaveLastBattleStageId(string actId, string stageId)
		{
		}

		// Token: 0x0602ABFA RID: 175098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABFA")]
		[Address(RVA = "0x2688A60", Offset = "0x2687660", VA = "0x182688A60")]
		public string GetLastBattleStageId(string actId)
		{
			return null;
		}

		// Token: 0x0403D953 RID: 252243
		[Token(Token = "0x403D953")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<Act1VHalfIdleLocalCache.ActData> m_memData;

		// Token: 0x0403D954 RID: 252244
		[Token(Token = "0x403D954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403D955 RID: 252245
		[Token(Token = "0x403D955")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403D956 RID: 252246
		[Token(Token = "0x403D956")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0403D957 RID: 252247
		[Token(Token = "0x403D957")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0403D958 RID: 252248
		[Token(Token = "0x403D958")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0403D959 RID: 252249
		[Token(Token = "0x403D959")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDepotBuffLevel;

		// Token: 0x0403D95A RID: 252250
		[Token(Token = "0x403D95A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetDepotBuffLevel;

		// Token: 0x0403D95B RID: 252251
		[Token(Token = "0x403D95B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassedStagePlotSquadDict;

		// Token: 0x0403D95C RID: 252252
		[Token(Token = "0x403D95C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SavePassedStagePlotSquadDict;

		// Token: 0x0403D95D RID: 252253
		[Token(Token = "0x403D95D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPlotSquadDictByStageId;

		// Token: 0x0403D95E RID: 252254
		[Token(Token = "0x403D95E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SavePlotSquadDictByStageId;

		// Token: 0x0403D95F RID: 252255
		[Token(Token = "0x403D95F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SavePlotSquadByStageId;

		// Token: 0x0403D960 RID: 252256
		[Token(Token = "0x403D960")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCharSquadByStageId;

		// Token: 0x0403D961 RID: 252257
		[Token(Token = "0x403D961")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SaveCharSquadByStageId;

		// Token: 0x0403D962 RID: 252258
		[Token(Token = "0x403D962")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetBattleEquipAutoUpgradeOn;

		// Token: 0x0403D963 RID: 252259
		[Token(Token = "0x403D963")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SaveBattleEquipAutoUpgradeOn;

		// Token: 0x0403D964 RID: 252260
		[Token(Token = "0x403D964")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetPassStageSquadByStageId;

		// Token: 0x0403D965 RID: 252261
		[Token(Token = "0x403D965")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SavePassStageSquadByStageId;

		// Token: 0x0403D966 RID: 252262
		[Token(Token = "0x403D966")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCharDefaultSkill;

		// Token: 0x0403D967 RID: 252263
		[Token(Token = "0x403D967")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SaveCharDefaultSkills;

		// Token: 0x0403D968 RID: 252264
		[Token(Token = "0x403D968")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCharDefaultEquip;

		// Token: 0x0403D969 RID: 252265
		[Token(Token = "0x403D969")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SaveCharDefaultEquips;

		// Token: 0x0403D96A RID: 252266
		[Token(Token = "0x403D96A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EnsureCharSnapShotEquip;

		// Token: 0x0403D96B RID: 252267
		[Token(Token = "0x403D96B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetDefaultAssistProf;

		// Token: 0x0403D96C RID: 252268
		[Token(Token = "0x403D96C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SaveDefaultAssistProf;

		// Token: 0x0403D96D RID: 252269
		[Token(Token = "0x403D96D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetNewUnlockNormStageId;

		// Token: 0x0403D96E RID: 252270
		[Token(Token = "0x403D96E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SaveNewUnlockNormStageId;

		// Token: 0x0403D96F RID: 252271
		[Token(Token = "0x403D96F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ClearSaveNewUnlockNormStageId;

		// Token: 0x0403D970 RID: 252272
		[Token(Token = "0x403D970")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SaveLastBattleStageId;

		// Token: 0x0403D971 RID: 252273
		[Token(Token = "0x403D971")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetLastBattleStageId;

		// Token: 0x020076B8 RID: 30392
		[Token(Token = "0x20076B8")]
		private class ActData
		{
			// Token: 0x0602ABFB RID: 175099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ABFB")]
			[Address(RVA = "0x26947A0", Offset = "0x26933A0", VA = "0x1826947A0")]
			public ActData()
			{
			}

			// Token: 0x0403D972 RID: 252274
			[Token(Token = "0x403D972")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D973 RID: 252275
			[Token(Token = "0x403D973")]
			[FieldOffset(Offset = "0x18")]
			public Act1VHalfIdleLocalCache.DataInAct dataInAct;
		}

		// Token: 0x020076B9 RID: 30393
		[Token(Token = "0x20076B9")]
		private class DataInAct
		{
			// Token: 0x0602ABFC RID: 175100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ABFC")]
			[Address(RVA = "0x2694820", Offset = "0x2693420", VA = "0x182694820")]
			public DataInAct()
			{
			}

			// Token: 0x0403D974 RID: 252276
			[Token(Token = "0x403D974")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Dictionary<Act1VHalfIdlePlotType, List<string>>> plotSquadCaches;

			// Token: 0x0403D975 RID: 252277
			[Token(Token = "0x403D975")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, Dictionary<Act1VHalfIdlePlotType, List<string>>> passStagePlotSquadCaches;

			// Token: 0x0403D976 RID: 252278
			[Token(Token = "0x403D976")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache>> charSquadCaches;

			// Token: 0x0403D977 RID: 252279
			[Token(Token = "0x403D977")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, List<Act1VHalfIdleCharViewModel.Act1VHalfIdleCharCache>> passStageSquadCaches;

			// Token: 0x0403D978 RID: 252280
			[Token(Token = "0x403D978")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<int, int> depotBuffLevels;

			// Token: 0x0403D979 RID: 252281
			[Token(Token = "0x403D979")]
			[FieldOffset(Offset = "0x38")]
			public ProfessionCategory assistDefaultProf;

			// Token: 0x0403D97A RID: 252282
			[Token(Token = "0x403D97A")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, string> charDefaultSkillIds;

			// Token: 0x0403D97B RID: 252283
			[Token(Token = "0x403D97B")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, string> charDefaultEquipIds;

			// Token: 0x0403D97C RID: 252284
			[Token(Token = "0x403D97C")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, string> charSnapShotEquipIds;

			// Token: 0x0403D97D RID: 252285
			[Token(Token = "0x403D97D")]
			[FieldOffset(Offset = "0x58")]
			public string newUnlockNormStageId;

			// Token: 0x0403D97E RID: 252286
			[Token(Token = "0x403D97E")]
			[FieldOffset(Offset = "0x60")]
			public string lastBattleStageId;

			// Token: 0x0403D97F RID: 252287
			[Token(Token = "0x403D97F")]
			[FieldOffset(Offset = "0x68")]
			public bool battleEquipAutoUpgradeOn;
		}
	}
}
