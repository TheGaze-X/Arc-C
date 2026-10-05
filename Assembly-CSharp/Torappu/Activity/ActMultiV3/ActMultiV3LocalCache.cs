using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EB1 RID: 28337
	[Token(Token = "0x2006EB1")]
	public class ActMultiV3LocalCache : Singleton<ActMultiV3LocalCache>
	{
		// Token: 0x06028508 RID: 165128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028508")]
		[Address(RVA = "0x238C970", Offset = "0x238B570", VA = "0x18238C970")]
		private ActMultiV3LocalCache()
		{
		}

		// Token: 0x06028509 RID: 165129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028509")]
		[Address(RVA = "0x238C410", Offset = "0x238B010", VA = "0x18238C410")]
		private ActMultiV3LocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0602850A RID: 165130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602850A")]
		[Address(RVA = "0x238C250", Offset = "0x238AE50", VA = "0x18238C250")]
		private ActMultiV3LocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x0602850B RID: 165131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602850B")]
		[Address(RVA = "0x238C550", Offset = "0x238B150", VA = "0x18238C550")]
		private ActMultiV3LocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x0602850C RID: 165132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602850C")]
		[Address(RVA = "0x238C680", Offset = "0x238B280", VA = "0x18238C680")]
		private void _SaveData(ActMultiV3LocalCache.ActData data)
		{
		}

		// Token: 0x0602850D RID: 165133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602850D")]
		[Address(RVA = "0x238BD60", Offset = "0x238A960", VA = "0x18238BD60")]
		public string LoadSelectSquadId(string actId)
		{
			return null;
		}

		// Token: 0x0602850E RID: 165134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602850E")]
		[Address(RVA = "0x238C170", Offset = "0x238AD70", VA = "0x18238C170")]
		public void SaveSelectSquadId(string actId, string squadId)
		{
		}

		// Token: 0x0602850F RID: 165135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602850F")]
		[Address(RVA = "0x238BBC0", Offset = "0x238A7C0", VA = "0x18238BBC0")]
		public string GetLastUseEmoticonId(string actId, EmojiSceneType sceneType)
		{
			return null;
		}

		// Token: 0x06028510 RID: 165136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028510")]
		[Address(RVA = "0x238BEB0", Offset = "0x238AAB0", VA = "0x18238BEB0")]
		public void SaveLastUseEmoticonThemeId(string actId, string emoticonThemeId, EmojiSceneType sceneType)
		{
		}

		// Token: 0x06028511 RID: 165137 RVA: 0x000D16A0 File Offset: 0x000CF8A0
		[Token(Token = "0x6028511")]
		[Address(RVA = "0x238C710", Offset = "0x238B310", VA = "0x18238C710")]
		private bool _TryGetLastUseEmoticonThemeGroup(List<ActMultiV3LocalCache.EmoticonLastUseThemeIdGroup> themeIdGroups, EmojiSceneType sceneType, out ActMultiV3LocalCache.EmoticonLastUseThemeIdGroup themeGroup)
		{
			return default(bool);
		}

		// Token: 0x06028512 RID: 165138 RVA: 0x000D16B8 File Offset: 0x000CF8B8
		[Token(Token = "0x6028512")]
		[Address(RVA = "0x238BB30", Offset = "0x238A730", VA = "0x18238BB30")]
		public ManualTabType GetLastSelectedManualTab(string actId)
		{
			return ManualTabType.TITLE_TASK;
		}

		// Token: 0x06028513 RID: 165139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028513")]
		[Address(RVA = "0x238BDF0", Offset = "0x238A9F0", VA = "0x18238BDF0")]
		public void SaveLastSelectedManualTab(string actId, ManualTabType selectedManualTabType)
		{
		}

		// Token: 0x06028514 RID: 165140 RVA: 0x000D16D0 File Offset: 0x000CF8D0
		[Token(Token = "0x6028514")]
		[Address(RVA = "0x238BCD0", Offset = "0x238A8D0", VA = "0x18238BCD0")]
		public long GetLastVisitMilestoneTime(string actId)
		{
			return 0L;
		}

		// Token: 0x06028515 RID: 165141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028515")]
		[Address(RVA = "0x238C0B0", Offset = "0x238ACB0", VA = "0x18238C0B0")]
		public void SaveLastVisitMilestoneTime(string actId, long time)
		{
		}

		// Token: 0x040394B0 RID: 234672
		[Token(Token = "0x40394B0")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<ActMultiV3LocalCache.ActData> m_memData;

		// Token: 0x040394B1 RID: 234673
		[Token(Token = "0x40394B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040394B2 RID: 234674
		[Token(Token = "0x40394B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x040394B3 RID: 234675
		[Token(Token = "0x40394B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x040394B4 RID: 234676
		[Token(Token = "0x40394B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x040394B5 RID: 234677
		[Token(Token = "0x40394B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x040394B6 RID: 234678
		[Token(Token = "0x40394B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSelectSquadId;

		// Token: 0x040394B7 RID: 234679
		[Token(Token = "0x40394B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveSelectSquadId;

		// Token: 0x040394B8 RID: 234680
		[Token(Token = "0x40394B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLastUseEmoticonId;

		// Token: 0x040394B9 RID: 234681
		[Token(Token = "0x40394B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveLastUseEmoticonThemeId;

		// Token: 0x040394BA RID: 234682
		[Token(Token = "0x40394BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetLastUseEmoticonThemeGroup;

		// Token: 0x040394BB RID: 234683
		[Token(Token = "0x40394BB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetLastSelectedManualTab;

		// Token: 0x040394BC RID: 234684
		[Token(Token = "0x40394BC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SaveLastSelectedManualTab;

		// Token: 0x040394BD RID: 234685
		[Token(Token = "0x40394BD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetLastVisitMilestoneTime;

		// Token: 0x040394BE RID: 234686
		[Token(Token = "0x40394BE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SaveLastVisitMilestoneTime;

		// Token: 0x02006EB2 RID: 28338
		[Token(Token = "0x2006EB2")]
		private class DataInAct
		{
			// Token: 0x06028516 RID: 165142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028516")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x040394BF RID: 234687
			[Token(Token = "0x40394BF")]
			[FieldOffset(Offset = "0x10")]
			public ManualTabType lastSelectedManualTabType;

			// Token: 0x040394C0 RID: 234688
			[Token(Token = "0x40394C0")]
			[FieldOffset(Offset = "0x18")]
			public long lastVisitMilestoneTime;

			// Token: 0x040394C1 RID: 234689
			[Token(Token = "0x40394C1")]
			[FieldOffset(Offset = "0x20")]
			public string selectSquadId;

			// Token: 0x040394C2 RID: 234690
			[Token(Token = "0x40394C2")]
			[FieldOffset(Offset = "0x28")]
			public List<ActMultiV3LocalCache.EmoticonLastUseThemeIdGroup> lastUseEmoticonThemeIdList;
		}

		// Token: 0x02006EB3 RID: 28339
		[Token(Token = "0x2006EB3")]
		private class EmoticonLastUseThemeIdGroup
		{
			// Token: 0x06028517 RID: 165143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028517")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmoticonLastUseThemeIdGroup()
			{
			}

			// Token: 0x040394C3 RID: 234691
			[Token(Token = "0x40394C3")]
			[FieldOffset(Offset = "0x10")]
			public EmojiSceneType sceneType;

			// Token: 0x040394C4 RID: 234692
			[Token(Token = "0x40394C4")]
			[FieldOffset(Offset = "0x18")]
			public string emoticonThemeId;
		}

		// Token: 0x02006EB4 RID: 28340
		[Token(Token = "0x2006EB4")]
		private class ActData
		{
			// Token: 0x06028518 RID: 165144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028518")]
			[Address(RVA = "0x238B8D0", Offset = "0x238A4D0", VA = "0x18238B8D0")]
			public ActData()
			{
			}

			// Token: 0x040394C5 RID: 234693
			[Token(Token = "0x40394C5")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040394C6 RID: 234694
			[Token(Token = "0x40394C6")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3LocalCache.DataInAct dataInAct;
		}
	}
}
