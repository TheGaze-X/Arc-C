using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BF0 RID: 23536
	[Token(Token = "0x2005BF0")]
	public interface ITemplateCharSelectPlugin : IHotfixable
	{
		// Token: 0x060221E5 RID: 139749
		[Token(Token = "0x60221E5")]
		void OnInitCharSelect(TemplateCharSelectController.InputParam inputParam, ITemplateCharSelectCtrlHost host);

		// Token: 0x060221E6 RID: 139750
		[Token(Token = "0x60221E6")]
		void OnCharClick(int instId, string charId);

		// Token: 0x060221E7 RID: 139751
		[Token(Token = "0x60221E7")]
		void OnSetCharAttribute(TemplateCharSelectCardViewModel targetChar, int key, ValueBundle value);

		// Token: 0x060221E8 RID: 139752
		[Token(Token = "0x60221E8")]
		void OnConfirm(Action done);

		// Token: 0x060221E9 RID: 139753
		[Token(Token = "0x60221E9")]
		void OnCancel(Action done);
	}
}
