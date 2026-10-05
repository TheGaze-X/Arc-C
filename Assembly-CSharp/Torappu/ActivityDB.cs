using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ActivityDB")]
	[Serializable]
	public class ActivityDB : ConstTable<ActivityTable, ActivityDB>
	{
		// Token: 0x06006074 RID: 24692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006074")]
		[Address(RVA = "0x1CE31D0", Offset = "0x1CE1DD0", VA = "0x181CE31D0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006075")]
		[Address(RVA = "0x1CE37B0", Offset = "0x1CE23B0", VA = "0x181CE37B0")]
		private void _FlushAllActBasicInfoIfNecessary(Dictionary<string, ActivityTable.BasicData> basicInfo)
		{
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x0002F520 File Offset: 0x0002D720
		[Token(Token = "0x6006076")]
		[Address(RVA = "0x1CE2EE0", Offset = "0x1CE1AE0", VA = "0x181CE2EE0")]
		public bool HasEventDuringTime(long startTs, long endTs)
		{
			return default(bool);
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x0002F538 File Offset: 0x0002D738
		[Token(Token = "0x6006077")]
		[Address(RVA = "0x1CE2FE0", Offset = "0x1CE1BE0", VA = "0x181CE2FE0")]
		public bool HasFixedSyncActivity(long curTs)
		{
			return default(bool);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006078")]
		[Address(RVA = "0x1CE2BF0", Offset = "0x1CE17F0", VA = "0x181CE2BF0")]
		public IEnumerator<ActivityTable.BasicData> GetRecentActBasicDataIter(long curTs)
		{
			return null;
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006079")]
		[Address(RVA = "0x1CE2CB0", Offset = "0x1CE18B0", VA = "0x181CE2CB0")]
		public IEnumerator<ActivityThemeData> GetRecentActThemeIter(long curTs)
		{
			return null;
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607A")]
		[Address(RVA = "0x1CE2940", Offset = "0x1CE1540", VA = "0x181CE2940")]
		public List<long> GetActivityTimePoints()
		{
			return null;
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607B")]
		[Address(RVA = "0x1CE2770", Offset = "0x1CE1370", VA = "0x181CE2770")]
		public MissionData GetActMission(string missionId)
		{
			return null;
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x1CE2A90", Offset = "0x1CE1690", VA = "0x181CE2A90")]
		public IEnumerator<MissionData> GetMissionEnumerator(string actId)
		{
			return null;
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607D")]
		[Address(RVA = "0x1CE2B60", Offset = "0x1CE1760", VA = "0x181CE2B60")]
		public MissionGroup GetMissionGroupData(string actId)
		{
			return null;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607E")]
		[Address(RVA = "0x1CE29A0", Offset = "0x1CE15A0", VA = "0x181CE29A0")]
		public List<AprilFoolScoreData> GetAprilFoolScoreDatas(string stageId)
		{
			return null;
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607F")]
		[Address(RVA = "0x1CE2800", Offset = "0x1CE1400", VA = "0x181CE2800")]
		public ActivityTable.ActivityHiddenStageData GetActivityHiddenStageData(string stageId)
		{
			return null;
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006080")]
		[Address(RVA = "0x1CE2D70", Offset = "0x1CE1970", VA = "0x181CE2D70")]
		public string GetStringRes(string actId, string key)
		{
			return null;
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x0002F550 File Offset: 0x0002D750
		[Token(Token = "0x6006081")]
		[Address(RVA = "0x1CE26A0", Offset = "0x1CE12A0", VA = "0x181CE26A0")]
		public bool CheckIsHiddenStage(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006082")]
		[Address(RVA = "0x1CE3A80", Offset = "0x1CE2680", VA = "0x181CE3A80")]
		private void _InitMissionMap()
		{
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006083")]
		[Address(RVA = "0x1CE3F20", Offset = "0x1CE2B20", VA = "0x181CE3F20")]
		private void _InitTimeSortedActInfos()
		{
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006084")]
		[Address(RVA = "0x1CE3CA0", Offset = "0x1CE28A0", VA = "0x181CE3CA0")]
		private void _InitTimeSortActThemes()
		{
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006085")]
		[Address(RVA = "0x1CE3940", Offset = "0x1CE2540", VA = "0x181CE3940")]
		private void _InitHiddenStageMap()
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006086")]
		[Address(RVA = "0x1CE41B0", Offset = "0x1CE2DB0", VA = "0x181CE41B0")]
		public ActivityDB()
		{
		}

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private List<long> m_activityTimePoints;

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, MissionData> m_actMissionMap;

		// Token: 0x040029EC RID: 10732
		[Token(Token = "0x40029EC")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, MissionGroup> m_actMissionGroupMap;

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private List<ActivityTable.BasicData> m_timeSortedActInfos;

		// Token: 0x040029EE RID: 10734
		[Token(Token = "0x40029EE")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private List<ActivityThemeData> m_timeSortedActThemes;

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private Dictionary<string, ActivityTable.ActivityHiddenStageData> m_hiddenStageDict;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FlushAllActBasicInfoIfNecessary;

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HasEventDuringTime;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HasFixedSyncActivity;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRecentActBasicDataIter;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRecentActThemeIter;

		// Token: 0x040029F6 RID: 10742
		[Token(Token = "0x40029F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetActivityTimePoints;

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActMission;

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMissionEnumerator;

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetMissionGroupData;

		// Token: 0x040029FA RID: 10746
		[Token(Token = "0x40029FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAprilFoolScoreDatas;

		// Token: 0x040029FB RID: 10747
		[Token(Token = "0x40029FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetActivityHiddenStageData;

		// Token: 0x040029FC RID: 10748
		[Token(Token = "0x40029FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetStringRes;

		// Token: 0x040029FD RID: 10749
		[Token(Token = "0x40029FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIsHiddenStage;

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitMissionMap;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitTimeSortedActInfos;

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitTimeSortActThemes;

		// Token: 0x04002A01 RID: 10753
		[Token(Token = "0x4002A01")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitHiddenStageMap;

		// Token: 0x04002A02 RID: 10754
		[Token(Token = "0x4002A02")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
