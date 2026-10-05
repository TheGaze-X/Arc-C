using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/UniEquipDB")]
	[Serializable]
	public class UniEquipDB : ConstTable<UniEquipTable, UniEquipDB>
	{
		// Token: 0x060061CB RID: 25035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061CB")]
		[Address(RVA = "0x1DFC360", Offset = "0x1DFAF60", VA = "0x181DFC360")]
		public UniEquipTimeInfo GetNearestStageTimeData(long timeStamp)
		{
			return null;
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061CC")]
		[Address(RVA = "0x1DFCB40", Offset = "0x1DFB740", VA = "0x181DFCB40")]
		public List<UniEquipData> LoadCharEquipViewModelList(CharQuery query)
		{
			return null;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061CD")]
		[Address(RVA = "0x1DFC870", Offset = "0x1DFB470", VA = "0x181DFC870")]
		public Dictionary<string, UniEquipData> LoadCharEquipTypeDataDict(CharQuery query)
		{
			return null;
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061CE")]
		[Address(RVA = "0x1DFC130", Offset = "0x1DFAD30", VA = "0x181DFC130")]
		public List<string> GetCharEquipList(CharQuery query)
		{
			return null;
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x0002FE50 File Offset: 0x0002E050
		[Token(Token = "0x60061CF")]
		[Address(RVA = "0x1DFC750", Offset = "0x1DFB350", VA = "0x181DFC750")]
		public bool IsValidEquipForChar(string uniEquipId, string charId)
		{
			return default(bool);
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061D0")]
		[Address(RVA = "0x1DFC4A0", Offset = "0x1DFB0A0", VA = "0x181DFC4A0")]
		public SubProfessionData GetSubProfessionData(string id)
		{
			return null;
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061D1")]
		[Address(RVA = "0x1DFC280", Offset = "0x1DFAE80", VA = "0x181DFC280")]
		public UniEquipMissionData GetEquipMissionData(string missionId)
		{
			return null;
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x0002FE68 File Offset: 0x0002E068
		[Token(Token = "0x60061D2")]
		[Address(RVA = "0x1DFC580", Offset = "0x1DFB180", VA = "0x181DFC580")]
		public bool HasAnyEquipInTable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D3")]
		[Address(RVA = "0x1DFCE10", Offset = "0x1DFBA10", VA = "0x181DFCE10")]
		public UniEquipDB()
		{
		}

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetNearestStageTimeData;

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCharEquipViewModelList;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCharEquipTypeDataDict;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCharEquipList;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValidEquipForChar;

		// Token: 0x04002B8C RID: 11148
		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSubProfessionData;

		// Token: 0x04002B8D RID: 11149
		[Token(Token = "0x4002B8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEquipMissionData;

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasAnyEquipInTable;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
