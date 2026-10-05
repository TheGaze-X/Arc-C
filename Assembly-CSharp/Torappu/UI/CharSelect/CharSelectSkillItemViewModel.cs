using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E0B RID: 24075
	[Token(Token = "0x2005E0B")]
	public class CharSelectSkillItemViewModel : SkillItemViewModel
	{
		// Token: 0x06022E44 RID: 142916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E44")]
		[Address(RVA = "0x1A01080", Offset = "0x19FFC80", VA = "0x181A01080")]
		public CharSelectSkillItemViewModel()
		{
		}

		// Token: 0x040300B2 RID: 196786
		[Token(Token = "0x40300B2")]
		[FieldOffset(Offset = "0x88")]
		public bool isEnabled;

		// Token: 0x040300B3 RID: 196787
		[Token(Token = "0x40300B3")]
		[FieldOffset(Offset = "0x90")]
		public string disableText;

		// Token: 0x040300B4 RID: 196788
		[Token(Token = "0x40300B4")]
		[FieldOffset(Offset = "0x98")]
		public bool isShowSpecLevel;
	}
}
