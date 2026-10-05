using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003593 RID: 13715
	[Token(Token = "0x2003593")]
	public interface ICharSkillInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x06015D07 RID: 89351
		[Token(Token = "0x1700340E")]
		string skillId { [Token(Token = "0x6015D07")] get; }

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x06015D08 RID: 89352
		[Token(Token = "0x1700340F")]
		string defaultSkillId { [Token(Token = "0x6015D08")] get; }

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x06015D09 RID: 89353
		[Token(Token = "0x17003410")]
		int mainSkillLvl { [Token(Token = "0x6015D09")] get; }

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x06015D0A RID: 89354
		[Token(Token = "0x17003411")]
		ListDict<string, PlayerCharSkill> skills { [Token(Token = "0x6015D0A")] get; }

		// Token: 0x06015D0B RID: 89355
		[Token(Token = "0x6015D0B")]
		void SetSkillId(string newSkillId);
	}
}
