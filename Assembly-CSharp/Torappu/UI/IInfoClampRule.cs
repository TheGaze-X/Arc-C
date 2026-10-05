using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200358B RID: 13707
	[Token(Token = "0x200358B")]
	public interface IInfoClampRule<TInfo, TBuilder> : IHotfixable where TInfo : ICharacterInfo where TBuilder : ICharInfoPatchBuilder<TInfo>
	{
		// Token: 0x06015CEF RID: 89327
		[Token(Token = "0x6015CEF")]
		TBuilder DoClamp(TBuilder detailInfoBuilder);
	}
}
