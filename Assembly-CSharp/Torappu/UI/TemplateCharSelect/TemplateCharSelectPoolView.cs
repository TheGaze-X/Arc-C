using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE2 RID: 23522
	[Token(Token = "0x2005BE2")]
	public abstract class TemplateCharSelectPoolView : TemplateCharSelectSubViewBase
	{
		// Token: 0x060221AE RID: 139694
		[Token(Token = "0x60221AE")]
		public abstract TemplateCharSelectPoolViewModelCreator GetModelCreator();

		// Token: 0x060221AF RID: 139695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221AF")]
		[Address(RVA = "0x1C9EA40", Offset = "0x1C9D640", VA = "0x181C9EA40")]
		protected TemplateCharSelectPoolView()
		{
		}

		// Token: 0x0402EC68 RID: 191592
		[Token(Token = "0x402EC68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
