using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200358C RID: 13708
	[Token(Token = "0x200358C")]
	public interface IInfoValidateRule<TInfo, TBuilder> : IHotfixable where TInfo : ICharacterInfo where TBuilder : ICharInfoPatchBuilder<TInfo>
	{
		// Token: 0x06015CF0 RID: 89328
		[Token(Token = "0x6015CF0")]
		TBuilder DoValidate(TBuilder equipInfoBuilder);
	}
}
