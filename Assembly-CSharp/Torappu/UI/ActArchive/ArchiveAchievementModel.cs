using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AEC RID: 27372
	[Token(Token = "0x2006AEC")]
	public class ArchiveAchievementModel : IHotfixable
	{
		// Token: 0x0602723F RID: 160319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602723F")]
		[Address(RVA = "0x22508A0", Offset = "0x224F4A0", VA = "0x1822508A0")]
		public void LoadData(string archiveId, Dictionary<string, SandboxV2ArchiveAchievementData> achievementData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027240 RID: 160320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027240")]
		[Address(RVA = "0x2251440", Offset = "0x2250040", VA = "0x182251440")]
		private void _LoadAchievementFilterModels(string archiveId, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027241 RID: 160321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027241")]
		[Address(RVA = "0x2251240", Offset = "0x224FE40", VA = "0x182251240")]
		private void _CollectRarityCount()
		{
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027242")]
		[Address(RVA = "0x2250F50", Offset = "0x224FB50", VA = "0x182250F50")]
		public void RefreshDisplayItemList()
		{
		}

		// Token: 0x06027243 RID: 160323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027243")]
		[Address(RVA = "0x2251610", Offset = "0x2250210", VA = "0x182251610")]
		public ArchiveAchievementModel()
		{
		}

		// Token: 0x040375EB RID: 226795
		[Token(Token = "0x40375EB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, AchievementRarityCountProgress> achievementRarityCountDict;

		// Token: 0x040375EC RID: 226796
		[Token(Token = "0x40375EC")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ArchiveAchievementListFilterViewModel> filters;

		// Token: 0x040375ED RID: 226797
		[Token(Token = "0x40375ED")]
		[FieldOffset(Offset = "0x20")]
		public List<AchievementItemModel> achievementItemDisplayList;

		// Token: 0x040375EE RID: 226798
		[Token(Token = "0x40375EE")]
		[FieldOffset(Offset = "0x28")]
		public ArchiveAchievementListGotFilterViewModel gotFilterViewModel;

		// Token: 0x040375EF RID: 226799
		[Token(Token = "0x40375EF")]
		[FieldOffset(Offset = "0x30")]
		private List<AchievementItemModel> m_achievementItems;

		// Token: 0x040375F0 RID: 226800
		[Token(Token = "0x40375F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040375F1 RID: 226801
		[Token(Token = "0x40375F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadAchievementFilterModels;

		// Token: 0x040375F2 RID: 226802
		[Token(Token = "0x40375F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CollectRarityCount;

		// Token: 0x040375F3 RID: 226803
		[Token(Token = "0x40375F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshDisplayItemList;

		// Token: 0x040375F4 RID: 226804
		[Token(Token = "0x40375F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
