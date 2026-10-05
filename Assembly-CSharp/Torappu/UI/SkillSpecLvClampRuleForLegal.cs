using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A5 RID: 13733
	[Token(Token = "0x20035A5")]
	public struct SkillSpecLvClampRuleForLegal : ISingleInfoClampRule, IHotfixable
	{
		// Token: 0x06015D6E RID: 89454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D6E")]
		[Address(RVA = "0xE737A0", Offset = "0xE723A0", VA = "0x180E737A0")]
		public void DoClamp(PlayerCharSkill charSkill, CharacterData.MainSkill mainSkill)
		{
		}

		// Token: 0x0401A45B RID: 107611
		[Token(Token = "0x401A45B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
