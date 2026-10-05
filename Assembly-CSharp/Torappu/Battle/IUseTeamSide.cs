using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200260F RID: 9743
	[Token(Token = "0x200260F")]
	public interface IUseTeamSide : IPtrObject
	{
		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600FDF8 RID: 65016
		[Token(Token = "0x17002235")]
		SideTypeIndex teamSide { [Token(Token = "0x600FDF8")] get; }

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600FDF9 RID: 65017
		[Token(Token = "0x17002236")]
		bool hasSummoneeAfterDeath { [Token(Token = "0x600FDF9")] get; }
	}
}
