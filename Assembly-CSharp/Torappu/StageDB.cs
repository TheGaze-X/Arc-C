using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005DA RID: 1498
	[Token(Token = "0x20005DA")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/StageDB")]
	[Serializable]
	public class StageDB : ConstTable<StageTable, StageDB>
	{
		// Token: 0x060061A0 RID: 24992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0x1DF7C80", Offset = "0x1DF6880", VA = "0x181DF7C80", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A1")]
		[Address(RVA = "0x1DF7B40", Offset = "0x1DF6740", VA = "0x181DF7B40")]
		public List<long> GetStageEventList()
		{
			return null;
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A2")]
		[Address(RVA = "0x1DF7920", Offset = "0x1DF6520", VA = "0x181DF7920")]
		public string GetNormalStageIdByHard(string hardStageId)
		{
			return null;
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A3")]
		[Address(RVA = "0x1DF7AB0", Offset = "0x1DF66B0", VA = "0x181DF7AB0")]
		public string GetNormalStageIdBySixStar(string sixStarStageId)
		{
			return null;
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A4")]
		[Address(RVA = "0x1DF8BF0", Offset = "0x1DF77F0", VA = "0x181DF8BF0")]
		private string _GetNormalStageId(string notNormalStageId, Dictionary<string, string> stageIdMap)
		{
			return null;
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A5")]
		[Address(RVA = "0x1DF79B0", Offset = "0x1DF65B0", VA = "0x181DF79B0")]
		public string GetNormalStageIdByRelatedStageId(string relatedStageId)
		{
			return null;
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x0002FD90 File Offset: 0x0002DF90
		[Token(Token = "0x60061A6")]
		[Address(RVA = "0x1DF8760", Offset = "0x1DF7360", VA = "0x181DF8760")]
		public bool TryGetTileAppendInfo(string tileKey, out TileAppendInfo tileInfo)
		{
			return default(bool);
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		[Token(Token = "0x60061A7")]
		[Address(RVA = "0x1DF8660", Offset = "0x1DF7260", VA = "0x181DF8660")]
		public bool TryGetStageFogInfoByStageId(string stageId, out StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		[Token(Token = "0x60061A8")]
		[Address(RVA = "0x1DF8540", Offset = "0x1DF7140", VA = "0x181DF8540")]
		public bool TryGetStageFogInfoByFogId(string fogId, out StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x1DF78B0", Offset = "0x1DF64B0", VA = "0x181DF78B0")]
		public List<StageData> GetCampaignStages()
		{
			return null;
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x1DF7BB0", Offset = "0x1DF67B0", VA = "0x181DF7BB0")]
		public IEnumerator<StageDB.FogWithZone> GetZoneVitalFogEnumerator()
		{
			return null;
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x1DF8A50", Offset = "0x1DF7650", VA = "0x181DF8A50")]
		private static void _FlushLevelsToDefault(StageTable stageTable)
		{
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x1DF8D00", Offset = "0x1DF7900", VA = "0x181DF8D00")]
		private void _InitFogSearchTables()
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0x1DF8890", Offset = "0x1DF7490", VA = "0x181DF8890")]
		private static bool _CheckIfStageFogVitalForZone(StageFogInfo fogInfo, string curZone, Dictionary<string, string> fogToZoneMap, Dictionary<string, StageData> stageMap)
		{
			return default(bool);
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AE")]
		[Address(RVA = "0x1DF9290", Offset = "0x1DF7E90", VA = "0x181DF9290")]
		public StageDB()
		{
		}

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HashSet<string> AUDIT_ZONE_WHITE_LIST;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		public const string AUDIT_DEFAULT_LEVEL = "Obt/Main/level_main_00-01";

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, string> m_hardToNormalMap;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, string> m_sixStarToNormalMap;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private List<long> m_stageEvents;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private List<StageData> m_campaignStages;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private List<StageDB.FogWithZone> m_zoneVitalFogs;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private Dictionary<string, StageFogInfo> m_stageToFogMap;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private Dictionary<string, string> m_diffGroupStageIdToNormalMap;

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x4002B54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStageEventList;

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNormalStageIdByHard;

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNormalStageIdBySixStar;

		// Token: 0x04002B58 RID: 11096
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetNormalStageId;

		// Token: 0x04002B59 RID: 11097
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetNormalStageIdByRelatedStageId;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetTileAppendInfo;

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetStageFogInfoByStageId;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetStageFogInfoByFogId;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCampaignStages;

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetZoneVitalFogEnumerator;

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FlushLevelsToDefault;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitFogSearchTables;

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfStageFogVitalForZone;

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020005DB RID: 1499
		[Token(Token = "0x20005DB")]
		public struct FogWithZone
		{
			// Token: 0x04002B63 RID: 11107
			[Token(Token = "0x4002B63")]
			[FieldOffset(Offset = "0x0")]
			public StageFogInfo fogInfo;

			// Token: 0x04002B64 RID: 11108
			[Token(Token = "0x4002B64")]
			[FieldOffset(Offset = "0x8")]
			public string zoneId;
		}
	}
}
