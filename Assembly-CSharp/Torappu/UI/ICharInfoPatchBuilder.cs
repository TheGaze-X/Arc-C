using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003596 RID: 13718
	[Token(Token = "0x2003596")]
	public interface ICharInfoPatchBuilder<TInfo> : IHotfixable where TInfo : ICharacterInfo
	{
		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x06015D14 RID: 89364
		[Token(Token = "0x17003419")]
		bool isEmpty { [Token(Token = "0x6015D14")] get; }

		// Token: 0x06015D15 RID: 89365
		[Token(Token = "0x6015D15")]
		TInfo BuildTo(TInfo characterInfo);
	}
}
