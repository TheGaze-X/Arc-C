using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BFB RID: 23547
	[Token(Token = "0x2005BFB")]
	public struct TemplateCharSelectMainViewModelSetupData
	{
		// Token: 0x0402ECBF RID: 191679
		[Token(Token = "0x402ECBF")]
		[FieldOffset(Offset = "0x0")]
		public string pageName;

		// Token: 0x0402ECC0 RID: 191680
		[Token(Token = "0x402ECC0")]
		[FieldOffset(Offset = "0x8")]
		public TemplateCharSelectCardViewModelCreator charViewModelCreator;

		// Token: 0x0402ECC1 RID: 191681
		[Token(Token = "0x402ECC1")]
		[FieldOffset(Offset = "0x10")]
		public TemplateCharSelectPoolViewModelCreator poolViewModelCreator;

		// Token: 0x0402ECC2 RID: 191682
		[Token(Token = "0x402ECC2")]
		[FieldOffset(Offset = "0x18")]
		public TemplateCharSelectShuffleViewModelCreator shuffleViewModelCreator;

		// Token: 0x0402ECC3 RID: 191683
		[Token(Token = "0x402ECC3")]
		[FieldOffset(Offset = "0x20")]
		public TemplateCharSelectDetailViewModelCreator detailViewModelCreator;
	}
}
