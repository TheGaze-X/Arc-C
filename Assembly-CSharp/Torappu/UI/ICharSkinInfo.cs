using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003595 RID: 13717
	[Token(Token = "0x2003595")]
	public interface ICharSkinInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x06015D10 RID: 89360
		[Token(Token = "0x17003415")]
		string skinId { [Token(Token = "0x6015D10")] get; }

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x06015D11 RID: 89361
		[Token(Token = "0x17003416")]
		string portraitId { [Token(Token = "0x6015D11")] get; }

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x06015D12 RID: 89362
		[Token(Token = "0x17003417")]
		bool allowSpSkin { [Token(Token = "0x6015D12")] get; }

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x06015D13 RID: 89363
		[Token(Token = "0x17003418")]
		CharUISkinStruct skinStruct { [Token(Token = "0x6015D13")] get; }
	}
}
