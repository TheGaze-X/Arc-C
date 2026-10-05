using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006598 RID: 26008
	[Token(Token = "0x2006598")]
	public interface IArtMagazineDiyItemViewModel
	{
		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0602564E RID: 153166
		[Token(Token = "0x1700586F")]
		string id { [Token(Token = "0x602564E")] get; }

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x0602564F RID: 153167
		[Token(Token = "0x17005870")]
		string itemId { [Token(Token = "0x602564F")] get; }

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x06025650 RID: 153168
		[Token(Token = "0x17005871")]
		ItemType itemType { [Token(Token = "0x6025650")] get; }

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x06025651 RID: 153169
		[Token(Token = "0x17005872")]
		int templateId { [Token(Token = "0x6025651")] get; }
	}
}
