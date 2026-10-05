using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006673 RID: 26227
	[Token(Token = "0x2006673")]
	public class HandBookMissionViewModel : IComparable<HandBookMissionViewModel>
	{
		// Token: 0x06025A85 RID: 154245 RVA: 0x000C8B08 File Offset: 0x000C6D08
		[Token(Token = "0x6025A85")]
		[Address(RVA = "0x209C490", Offset = "0x209B090", VA = "0x18209C490", Slot = "4")]
		public int CompareTo(HandBookMissionViewModel anotherTeam)
		{
			return 0;
		}

		// Token: 0x06025A86 RID: 154246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A86")]
		[Address(RVA = "0x209C4C0", Offset = "0x209B0C0", VA = "0x18209C4C0")]
		public void LoadData(HandbookTeamMission teamMission, HandBookCommonStateBean.HandBookTeamViewModel teamViewModel)
		{
		}

		// Token: 0x06025A87 RID: 154247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A87")]
		[Address(RVA = "0x209C5F0", Offset = "0x209B1F0", VA = "0x18209C5F0")]
		public HandBookMissionViewModel()
		{
		}

		// Token: 0x04034E66 RID: 216678
		[Token(Token = "0x4034E66")]
		[FieldOffset(Offset = "0x10")]
		public string powerId;

		// Token: 0x04034E67 RID: 216679
		[Token(Token = "0x4034E67")]
		[FieldOffset(Offset = "0x18")]
		public int teamFavorTotal;

		// Token: 0x04034E68 RID: 216680
		[Token(Token = "0x4034E68")]
		[FieldOffset(Offset = "0x1C")]
		public int teamSort;

		// Token: 0x04034E69 RID: 216681
		[Token(Token = "0x4034E69")]
		[FieldOffset(Offset = "0x20")]
		public float teamPer;

		// Token: 0x04034E6A RID: 216682
		[Token(Token = "0x4034E6A")]
		[FieldOffset(Offset = "0x28")]
		public List<HandBookCardViewModel> viewModelList;

		// Token: 0x04034E6B RID: 216683
		[Token(Token = "0x4034E6B")]
		[FieldOffset(Offset = "0x30")]
		public HandbookTeamMission teamMissionData;

		// Token: 0x04034E6C RID: 216684
		[Token(Token = "0x4034E6C")]
		[FieldOffset(Offset = "0x38")]
		public int isAvailable;
	}
}
