using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BF1 RID: 23537
	[Token(Token = "0x2005BF1")]
	public interface ITemplateCharSelectCustomization : IHotfixable
	{
		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x060221EA RID: 139754
		[Token(Token = "0x17004FDA")]
		TemplateCharSelectCardView charCard { [Token(Token = "0x60221EA")] get; }

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x060221EB RID: 139755
		[Token(Token = "0x17004FDB")]
		TemplateCharSelectPoolView poolView { [Token(Token = "0x60221EB")] get; }

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x060221EC RID: 139756
		[Token(Token = "0x17004FDC")]
		TemplateCharSelectDetailView detailView { [Token(Token = "0x60221EC")] get; }

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x060221ED RID: 139757
		[Token(Token = "0x17004FDD")]
		TemplateCharSelectShuffleView shuffleView { [Token(Token = "0x60221ED")] get; }

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x060221EE RID: 139758
		[Token(Token = "0x17004FDE")]
		TemplateCharSelectEnsureView ensureView { [Token(Token = "0x60221EE")] get; }

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x060221EF RID: 139759
		[Token(Token = "0x17004FDF")]
		TemplateCharSelectTopMenuView topMenuView { [Token(Token = "0x60221EF")] get; }
	}
}
