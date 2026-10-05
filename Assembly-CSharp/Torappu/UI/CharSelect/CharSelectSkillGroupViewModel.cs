using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E0C RID: 24076
	[Token(Token = "0x2005E0C")]
	public class CharSelectSkillGroupViewModel
	{
		// Token: 0x06022E45 RID: 142917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E45")]
		[Address(RVA = "0x1D66EB0", Offset = "0x1D65AB0", VA = "0x181D66EB0")]
		public CharSelectSkillItemViewModel AchieveSkillModelById(string skillId)
		{
			return null;
		}

		// Token: 0x06022E46 RID: 142918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E46")]
		[Address(RVA = "0x1D66F70", Offset = "0x1D65B70", VA = "0x181D66F70")]
		public CharSelectSkillGroupViewModel()
		{
		}

		// Token: 0x040300B5 RID: 196789
		[Token(Token = "0x40300B5")]
		[FieldOffset(Offset = "0x10")]
		public string selectedSkillId;

		// Token: 0x040300B6 RID: 196790
		[Token(Token = "0x40300B6")]
		[FieldOffset(Offset = "0x18")]
		public CharSelectSkillItemViewModel[] skills;

		// Token: 0x040300B7 RID: 196791
		[Token(Token = "0x40300B7")]
		[FieldOffset(Offset = "0x20")]
		public int skillAllLevel;

		// Token: 0x040300B8 RID: 196792
		[Token(Token = "0x40300B8")]
		[FieldOffset(Offset = "0x28")]
		public string charId;

		// Token: 0x040300B9 RID: 196793
		[Token(Token = "0x40300B9")]
		[FieldOffset(Offset = "0x30")]
		public bool isEnabled;

		// Token: 0x040300BA RID: 196794
		[Token(Token = "0x40300BA")]
		[FieldOffset(Offset = "0x38")]
		public string disableText;
	}
}
