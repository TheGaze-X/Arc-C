using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200730D RID: 29453
	[Token(Token = "0x200730D")]
	public class Act42sideGunTaskLocalCache : Singleton<Act42sideGunTaskLocalCache>
	{
		// Token: 0x06029A80 RID: 170624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A80")]
		[Address(RVA = "0x2518D30", Offset = "0x2517930", VA = "0x182518D30")]
		private Act42sideGunTaskLocalCache()
		{
		}

		// Token: 0x06029A81 RID: 170625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A81")]
		[Address(RVA = "0x2518A30", Offset = "0x2517630", VA = "0x182518A30")]
		private Act42sideGunTaskLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06029A82 RID: 170626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A82")]
		[Address(RVA = "0x2518870", Offset = "0x2517470", VA = "0x182518870")]
		private Act42sideGunTaskLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x06029A83 RID: 170627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A83")]
		[Address(RVA = "0x2518B70", Offset = "0x2517770", VA = "0x182518B70")]
		private Act42sideGunTaskLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x06029A84 RID: 170628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A84")]
		[Address(RVA = "0x2518CA0", Offset = "0x25178A0", VA = "0x182518CA0")]
		private void _SaveData(Act42sideGunTaskLocalCache.ActData data)
		{
		}

		// Token: 0x06029A85 RID: 170629 RVA: 0x000D62A8 File Offset: 0x000D44A8
		[Token(Token = "0x6029A85")]
		[Address(RVA = "0x2517FC0", Offset = "0x2516BC0", VA = "0x182517FC0")]
		public bool CheckGunTaskEntryTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x06029A86 RID: 170630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A86")]
		[Address(RVA = "0x2518430", Offset = "0x2517030", VA = "0x182518430")]
		public void TrackGunTaskEntry(string actId, bool haveTrack)
		{
		}

		// Token: 0x06029A87 RID: 170631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A87")]
		[Address(RVA = "0x2518270", Offset = "0x2516E70", VA = "0x182518270")]
		public void ConsumeGunTaskEntryTrack(string actId)
		{
		}

		// Token: 0x06029A88 RID: 170632 RVA: 0x000D62C0 File Offset: 0x000D44C0
		[Token(Token = "0x6029A88")]
		[Address(RVA = "0x2517C90", Offset = "0x2516890", VA = "0x182517C90")]
		public bool CheckEntryNewTaskTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x06029A89 RID: 170633 RVA: 0x000D62D8 File Offset: 0x000D44D8
		[Token(Token = "0x6029A89")]
		[Address(RVA = "0x2518150", Offset = "0x2516D50", VA = "0x182518150")]
		public bool CheckGunTaskTrustorTrack(string actId, string trustorId)
		{
			return default(bool);
		}

		// Token: 0x06029A8A RID: 170634 RVA: 0x000D62F0 File Offset: 0x000D44F0
		[Token(Token = "0x6029A8A")]
		[Address(RVA = "0x2518050", Offset = "0x2516C50", VA = "0x182518050")]
		public bool CheckGunTaskItemTrack(string actId, string id)
		{
			return default(bool);
		}

		// Token: 0x06029A8B RID: 170635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A8B")]
		[Address(RVA = "0x25184F0", Offset = "0x25170F0", VA = "0x1825184F0")]
		public void TrackGunTaskItem(string actId, string id, bool haveTrack)
		{
		}

		// Token: 0x06029A8C RID: 170636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A8C")]
		[Address(RVA = "0x2518310", Offset = "0x2516F10", VA = "0x182518310")]
		public void ConsumeGunTaskItemTrack(string actId, string id)
		{
		}

		// Token: 0x06029A8D RID: 170637 RVA: 0x000D6308 File Offset: 0x000D4508
		[Token(Token = "0x6029A8D")]
		[Address(RVA = "0x2518660", Offset = "0x2517260", VA = "0x182518660")]
		private bool _CheckGunTaskTrustorTrack(Act42sideGunTaskLocalCache.DataInAct dataInAct, Act42SideData actData, string trustorId)
		{
			return default(bool);
		}

		// Token: 0x0403B96F RID: 244079
		[Token(Token = "0x403B96F")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<Act42sideGunTaskLocalCache.ActData> m_memData;

		// Token: 0x0403B970 RID: 244080
		[Token(Token = "0x403B970")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B971 RID: 244081
		[Token(Token = "0x403B971")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403B972 RID: 244082
		[Token(Token = "0x403B972")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0403B973 RID: 244083
		[Token(Token = "0x403B973")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0403B974 RID: 244084
		[Token(Token = "0x403B974")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0403B975 RID: 244085
		[Token(Token = "0x403B975")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckGunTaskEntryTrack;

		// Token: 0x0403B976 RID: 244086
		[Token(Token = "0x403B976")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TrackGunTaskEntry;

		// Token: 0x0403B977 RID: 244087
		[Token(Token = "0x403B977")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ConsumeGunTaskEntryTrack;

		// Token: 0x0403B978 RID: 244088
		[Token(Token = "0x403B978")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckEntryNewTaskTrack;

		// Token: 0x0403B979 RID: 244089
		[Token(Token = "0x403B979")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckGunTaskTrustorTrack;

		// Token: 0x0403B97A RID: 244090
		[Token(Token = "0x403B97A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckGunTaskItemTrack;

		// Token: 0x0403B97B RID: 244091
		[Token(Token = "0x403B97B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrackGunTaskItem;

		// Token: 0x0403B97C RID: 244092
		[Token(Token = "0x403B97C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ConsumeGunTaskItemTrack;

		// Token: 0x0403B97D RID: 244093
		[Token(Token = "0x403B97D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckGunTaskTrustorTrack;

		// Token: 0x0200730E RID: 29454
		[Token(Token = "0x200730E")]
		private class DataInAct
		{
			// Token: 0x06029A8E RID: 170638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0403B97E RID: 244094
			[Token(Token = "0x403B97E")]
			[FieldOffset(Offset = "0x10")]
			public int entryTrack;

			// Token: 0x0403B97F RID: 244095
			[Token(Token = "0x403B97F")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> itemGroups;
		}

		// Token: 0x0200730F RID: 29455
		[Token(Token = "0x200730F")]
		private class ActData
		{
			// Token: 0x06029A8F RID: 170639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A8F")]
			[Address(RVA = "0x251B320", Offset = "0x2519F20", VA = "0x18251B320")]
			public ActData()
			{
			}

			// Token: 0x0403B980 RID: 244096
			[Token(Token = "0x403B980")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403B981 RID: 244097
			[Token(Token = "0x403B981")]
			[FieldOffset(Offset = "0x18")]
			public Act42sideGunTaskLocalCache.DataInAct dataInAct;
		}
	}
}
