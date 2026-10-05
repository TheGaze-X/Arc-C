using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF0 RID: 20208
	[Token(Token = "0x2004EF0")]
	public class FifthAnnivExploreMapRouteViewModel : IHotfixable
	{
		// Token: 0x0601E23B RID: 123451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E23B")]
		[Address(RVA = "0x17CF7E0", Offset = "0x17CE3E0", VA = "0x1817CF7E0")]
		public FifthAnnivExploreMapRouteViewModel()
		{
		}

		// Token: 0x040281D8 RID: 164312
		[Token(Token = "0x40281D8")]
		[FieldOffset(Offset = "0x10")]
		public FifthAnnivRouteType routeType;

		// Token: 0x040281D9 RID: 164313
		[Token(Token = "0x40281D9")]
		[FieldOffset(Offset = "0x18")]
		public List<FifthAnnivExploreMapNodeViewModel> nodes;

		// Token: 0x040281DA RID: 164314
		[Token(Token = "0x40281DA")]
		[FieldOffset(Offset = "0x20")]
		public List<FifthAnnivExploreMapLineViewModel> lines;

		// Token: 0x040281DB RID: 164315
		[Token(Token = "0x40281DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
