using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BEA RID: 23530
	[Token(Token = "0x2005BEA")]
	public interface ITemplateCharSelectCtrl : IHotfixable
	{
		// Token: 0x060221CE RID: 139726
		[Token(Token = "0x60221CE")]
		void OnCharClick(int instId);

		// Token: 0x060221CF RID: 139727
		[Token(Token = "0x60221CF")]
		void OnEnsureClick();

		// Token: 0x060221D0 RID: 139728
		[Token(Token = "0x60221D0")]
		void OnCancelClick();

		// Token: 0x060221D1 RID: 139729
		[Token(Token = "0x60221D1")]
		void OnClearClick();

		// Token: 0x060221D2 RID: 139730
		[Token(Token = "0x60221D2")]
		void OnSetCharAttribute(TemplateCharSelectCardViewModel targetChar, int key, ValueBundle value);

		// Token: 0x060221D3 RID: 139731
		[Token(Token = "0x60221D3")]
		void NotifyUpdate();

		// Token: 0x060221D4 RID: 139732
		[Token(Token = "0x60221D4")]
		void NotifyShuffleUpdate();

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x060221D5 RID: 139733
		[Token(Token = "0x17004FD7")]
		TemplateCharSelectCardView charCardPrefab { [Token(Token = "0x60221D5")] get; }
	}
}
