using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002673 RID: 9843
	[Token(Token = "0x2002673")]
	[CreateAssetMenu(fileName = "extra_battlelog_db", menuName = "Torappu/DB/Table/ExtraBattleLogTable")]
	[Serializable]
	public class ExtraBattleLogDB : SimpleKVTable<ExtraBattleLogData, ExtraBattleLogDB>
	{
		// Token: 0x06010182 RID: 65922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010182")]
		[Address(RVA = "0x7C43F0", Offset = "0x7C2FF0", VA = "0x1807C43F0", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x06010183 RID: 65923 RVA: 0x000623E8 File Offset: 0x000605E8
		[Token(Token = "0x6010183")]
		[Address(RVA = "0x7C4310", Offset = "0x7C2F10", VA = "0x1807C4310")]
		public int GetTypeTaskCount(int type)
		{
			return 0;
		}

		// Token: 0x06010184 RID: 65924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010184")]
		[Address(RVA = "0x7C3F30", Offset = "0x7C2B30", VA = "0x1807C3F30")]
		public string GetTaskLogStr(ExtraLogType logType, int index)
		{
			return null;
		}

		// Token: 0x06010185 RID: 65925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010185")]
		[Address(RVA = "0x7C3420", Offset = "0x7C2020", VA = "0x1807C3420")]
		public void FetchLoggerIds(List<int> ids, ExtraLogType logType, string sourceId)
		{
		}

		// Token: 0x06010186 RID: 65926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010186")]
		[Address(RVA = "0x7C35C0", Offset = "0x7C21C0", VA = "0x1807C35C0")]
		public void FetchLoggerIds(List<int> ids, ExtraLogType logType, string sourceId, string sourceMode, string abilityName)
		{
		}

		// Token: 0x06010187 RID: 65927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010187")]
		[Address(RVA = "0x7C3CC0", Offset = "0x7C28C0", VA = "0x1807C3CC0")]
		public void FetchLoggerIds(List<int> ids, ExtraLogType logType, string sourceId, string sourceMode, string projectileName, string abilityName)
		{
		}

		// Token: 0x06010188 RID: 65928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010188")]
		[Address(RVA = "0x7C37E0", Offset = "0x7C23E0", VA = "0x1807C37E0")]
		public void FetchLoggerIds(List<int> ids, ExtraLogType logType, string sourceId, string sourceMode, string enemyId, List<string> enemyTag, string enemyApplyWay, string projectileName, string abilityName, string enemyLevelType)
		{
		}

		// Token: 0x06010189 RID: 65929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010189")]
		[Address(RVA = "0x7C47B0", Offset = "0x7C33B0", VA = "0x1807C47B0")]
		public ExtraBattleLogDB()
		{
		}

		// Token: 0x04011E6D RID: 73325
		[Token(Token = "0x4011E6D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private List<ExtraBattleLogData> m_allTaskLoggers;

		// Token: 0x04011E6E RID: 73326
		[Token(Token = "0x4011E6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011E6F RID: 73327
		[Token(Token = "0x4011E6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTypeTaskCount;

		// Token: 0x04011E70 RID: 73328
		[Token(Token = "0x4011E70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTaskLogStr;

		// Token: 0x04011E71 RID: 73329
		[Token(Token = "0x4011E71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FetchLoggerIds;

		// Token: 0x04011E72 RID: 73330
		[Token(Token = "0x4011E72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_FetchLoggerIds;

		// Token: 0x04011E73 RID: 73331
		[Token(Token = "0x4011E73")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix2_FetchLoggerIds;

		// Token: 0x04011E74 RID: 73332
		[Token(Token = "0x4011E74")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix3_FetchLoggerIds;

		// Token: 0x04011E75 RID: 73333
		[Token(Token = "0x4011E75")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
