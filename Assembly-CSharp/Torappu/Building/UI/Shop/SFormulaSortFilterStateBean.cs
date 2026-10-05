using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CDF RID: 7391
	[Token(Token = "0x2001CDF")]
	public class SFormulaSortFilterStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B6C9 RID: 46793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C9")]
		[Address(RVA = "0x334D810", Offset = "0x334C410", VA = "0x18334D810")]
		public SFormulaSortFilterStateBean()
		{
		}

		// Token: 0x0400B47A RID: 46202
		[Token(Token = "0x400B47A")]
		[FieldOffset(Offset = "0x10")]
		public FormulaOrderStruct orderStruct;

		// Token: 0x0400B47B RID: 46203
		[Token(Token = "0x400B47B")]
		[FieldOffset(Offset = "0x20")]
		public bool isConfirmed;

		// Token: 0x0400B47C RID: 46204
		[Token(Token = "0x400B47C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
