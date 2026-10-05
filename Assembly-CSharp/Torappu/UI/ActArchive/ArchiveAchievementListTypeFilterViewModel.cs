using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE9 RID: 27369
	[Token(Token = "0x2006AE9")]
	public class ArchiveAchievementListTypeFilterViewModel : ArchiveAchievementListFilterViewModel
	{
		// Token: 0x06027238 RID: 160312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027238")]
		[Address(RVA = "0x22506D0", Offset = "0x224F2D0", VA = "0x1822506D0")]
		public ArchiveAchievementListTypeFilterViewModel(List<SandboxV2ArchiveAchievementTypeData> typeDataList)
		{
		}

		// Token: 0x06027239 RID: 160313 RVA: 0x000CD7B8 File Offset: 0x000CB9B8
		[Token(Token = "0x6027239")]
		[Address(RVA = "0x2250410", Offset = "0x224F010", VA = "0x182250410", Slot = "4")]
		public override bool CheckIfItemValid(AchievementItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x0602723A RID: 160314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602723A")]
		[Address(RVA = "0x2250540", Offset = "0x224F140", VA = "0x182250540", Slot = "5")]
		public override void SetSelection(string selection)
		{
		}

		// Token: 0x0602723B RID: 160315 RVA: 0x000CD7D0 File Offset: 0x000CB9D0
		[Token(Token = "0x602723B")]
		[Address(RVA = "0x22504C0", Offset = "0x224F0C0", VA = "0x1822504C0")]
		public bool IsTypeSelected(string type)
		{
			return default(bool);
		}

		// Token: 0x040375E0 RID: 226784
		[Token(Token = "0x40375E0")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2ArchiveAchievementTypeData> achievementTypeList;

		// Token: 0x040375E1 RID: 226785
		[Token(Token = "0x40375E1")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectedType;

		// Token: 0x040375E2 RID: 226786
		[Token(Token = "0x40375E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040375E3 RID: 226787
		[Token(Token = "0x40375E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfItemValid;

		// Token: 0x040375E4 RID: 226788
		[Token(Token = "0x40375E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelection;

		// Token: 0x040375E5 RID: 226789
		[Token(Token = "0x40375E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTypeSelected;
	}
}
