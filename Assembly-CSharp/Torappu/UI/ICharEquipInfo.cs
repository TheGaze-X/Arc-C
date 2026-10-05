using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003594 RID: 13716
	[Token(Token = "0x2003594")]
	public interface ICharEquipInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x06015D0C RID: 89356
		[Token(Token = "0x17003412")]
		string equipId { [Token(Token = "0x6015D0C")] get; }

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x06015D0D RID: 89357
		[Token(Token = "0x17003413")]
		int equipLvl { [Token(Token = "0x6015D0D")] get; }

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x06015D0E RID: 89358
		[Token(Token = "0x17003414")]
		ListDict<string, PlayerCharEquipInfo> equips { [Token(Token = "0x6015D0E")] get; }

		// Token: 0x06015D0F RID: 89359
		[Token(Token = "0x6015D0F")]
		void SetEquipId(string newEquipId);
	}
}
