using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE5 RID: 27365
	[Token(Token = "0x2006AE5")]
	public abstract class ArchiveAchievementListFilterViewModel : IHotfixable
	{
		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x06027230 RID: 160304 RVA: 0x000CD770 File Offset: 0x000CB970
		[Token(Token = "0x17005C84")]
		public ArchiveAchievementListFilterViewModel.FilterType filterType
		{
			[Token(Token = "0x6027230")]
			[Address(RVA = "0x22501C0", Offset = "0x224EDC0", VA = "0x1822501C0")]
			get
			{
				return ArchiveAchievementListFilterViewModel.FilterType.NONE;
			}
		}

		// Token: 0x06027231 RID: 160305
		[Token(Token = "0x6027231")]
		public abstract bool CheckIfItemValid(AchievementItemModel itemModel);

		// Token: 0x06027232 RID: 160306
		[Token(Token = "0x6027232")]
		public abstract void SetSelection(string selection);

		// Token: 0x06027233 RID: 160307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027233")]
		[Address(RVA = "0x2250160", Offset = "0x224ED60", VA = "0x182250160")]
		protected ArchiveAchievementListFilterViewModel()
		{
		}

		// Token: 0x040375CF RID: 226767
		[Token(Token = "0x40375CF")]
		[FieldOffset(Offset = "0x10")]
		protected ArchiveAchievementListFilterViewModel.FilterType m_filterType;

		// Token: 0x040375D0 RID: 226768
		[Token(Token = "0x40375D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x040375D1 RID: 226769
		[Token(Token = "0x40375D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006AE6 RID: 27366
		[Token(Token = "0x2006AE6")]
		public enum FilterType
		{
			// Token: 0x040375D3 RID: 226771
			[Token(Token = "0x40375D3")]
			NONE,
			// Token: 0x040375D4 RID: 226772
			[Token(Token = "0x40375D4")]
			TYPE,
			// Token: 0x040375D5 RID: 226773
			[Token(Token = "0x40375D5")]
			GOT
		}
	}
}
