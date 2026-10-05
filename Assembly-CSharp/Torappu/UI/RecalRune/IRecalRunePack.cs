using System;
using Il2CppDummyDll;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200479B RID: 18331
	[Token(Token = "0x200479B")]
	public interface IRecalRunePack : IHotfixable, IComparable<IRecalRunePack>
	{
		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0601BC4B RID: 113739
		[Token(Token = "0x17004205")]
		RecalRuneStageRunePackType packType { [Token(Token = "0x601BC4B")] get; }

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0601BC4C RID: 113740
		[Token(Token = "0x17004206")]
		string packId { [Token(Token = "0x601BC4C")] get; }
	}
}
