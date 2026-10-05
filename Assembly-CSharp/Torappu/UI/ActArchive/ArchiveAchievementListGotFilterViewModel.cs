using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE7 RID: 27367
	[Token(Token = "0x2006AE7")]
	public class ArchiveAchievementListGotFilterViewModel : IHotfixable
	{
		// Token: 0x06027234 RID: 160308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027234")]
		[Address(RVA = "0x22503A0", Offset = "0x224EFA0", VA = "0x1822503A0")]
		public ArchiveAchievementListGotFilterViewModel()
		{
		}

		// Token: 0x06027235 RID: 160309 RVA: 0x000CD788 File Offset: 0x000CB988
		[Token(Token = "0x6027235")]
		[Address(RVA = "0x2250220", Offset = "0x224EE20", VA = "0x182250220")]
		public bool CheckIfItemValid(AchievementItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x06027236 RID: 160310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027236")]
		[Address(RVA = "0x2250330", Offset = "0x224EF30", VA = "0x182250330")]
		public void SetSelection(ArchiveAchievementListGotFilterViewModel.GotType selection)
		{
		}

		// Token: 0x06027237 RID: 160311 RVA: 0x000CD7A0 File Offset: 0x000CB9A0
		[Token(Token = "0x6027237")]
		[Address(RVA = "0x22502D0", Offset = "0x224EED0", VA = "0x1822502D0")]
		public ArchiveAchievementListGotFilterViewModel.GotType GetGotType()
		{
			return ArchiveAchievementListGotFilterViewModel.GotType.NONE;
		}

		// Token: 0x040375D6 RID: 226774
		[Token(Token = "0x40375D6")]
		[FieldOffset(Offset = "0x10")]
		private ArchiveAchievementListGotFilterViewModel.GotType m_type;

		// Token: 0x040375D7 RID: 226775
		[Token(Token = "0x40375D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040375D8 RID: 226776
		[Token(Token = "0x40375D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfItemValid;

		// Token: 0x040375D9 RID: 226777
		[Token(Token = "0x40375D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelection;

		// Token: 0x040375DA RID: 226778
		[Token(Token = "0x40375DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGotType;

		// Token: 0x02006AE8 RID: 27368
		[Token(Token = "0x2006AE8")]
		public enum GotType
		{
			// Token: 0x040375DC RID: 226780
			[Token(Token = "0x40375DC")]
			NONE,
			// Token: 0x040375DD RID: 226781
			[Token(Token = "0x40375DD")]
			ALL,
			// Token: 0x040375DE RID: 226782
			[Token(Token = "0x40375DE")]
			GOT,
			// Token: 0x040375DF RID: 226783
			[Token(Token = "0x40375DF")]
			NOT_GOT
		}
	}
}
