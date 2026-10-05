using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C99 RID: 27801
	[Token(Token = "0x2006C99")]
	public class TemplateActCommonFavorUpStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06027A91 RID: 162449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A91")]
		[Address(RVA = "0x22D5590", Offset = "0x22D4190", VA = "0x1822D5590")]
		public TemplateActCommonFavorUpStateBean()
		{
		}

		// Token: 0x04038419 RID: 230425
		[Token(Token = "0x4038419")]
		[FieldOffset(Offset = "0x10")]
		public TemplateActCommonFavorUpStateBean.Input input;

		// Token: 0x0403841A RID: 230426
		[Token(Token = "0x403841A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C9A RID: 27802
		[Token(Token = "0x2006C9A")]
		public class Input
		{
			// Token: 0x06027A92 RID: 162450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A92")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403841B RID: 230427
			[Token(Token = "0x403841B")]
			[FieldOffset(Offset = "0x10")]
			public List<string> charIdList;

			// Token: 0x0403841C RID: 230428
			[Token(Token = "0x403841C")]
			[FieldOffset(Offset = "0x18")]
			public string actId;
		}
	}
}
