using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006540 RID: 25920
	[Token(Token = "0x2006540")]
	public class ArtMagazineCoverOverviewGroupViewModel : IHotfixable
	{
		// Token: 0x0602541A RID: 152602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602541A")]
		[Address(RVA = "0x202F690", Offset = "0x202E290", VA = "0x18202F690")]
		public ArtMagazineCoverOverviewGroupViewModel()
		{
		}

		// Token: 0x0403446A RID: 214122
		[Token(Token = "0x403446A")]
		[FieldOffset(Offset = "0x10")]
		public List<ArtMagazineCoverOverviewItemViewModel> itemViewModels;

		// Token: 0x0403446B RID: 214123
		[Token(Token = "0x403446B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
