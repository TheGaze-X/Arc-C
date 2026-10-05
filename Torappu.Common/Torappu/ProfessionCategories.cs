using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public static class ProfessionCategories
	{
		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		public const ProfessionCategory ALL = ProfessionCategory.WARRIOR | ProfessionCategory.SNIPER | ProfessionCategory.TANK | ProfessionCategory.MEDIC | ProfessionCategory.SUPPORT | ProfessionCategory.CASTER | ProfessionCategory.SPECIAL | ProfessionCategory.TOKEN | ProfessionCategory.TRAP | ProfessionCategory.PIONEER;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		public const ProfessionCategory CHARACTER = ProfessionCategory.WARRIOR | ProfessionCategory.SNIPER | ProfessionCategory.TANK | ProfessionCategory.MEDIC | ProfessionCategory.SUPPORT | ProfessionCategory.CASTER | ProfessionCategory.SPECIAL | ProfessionCategory.PIONEER;
	}
}
