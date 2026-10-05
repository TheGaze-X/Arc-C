using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF2 RID: 20210
	[Token(Token = "0x2004EF2")]
	public class FifthAnnivExploreMapLineViewModel : IHotfixable
	{
		// Token: 0x0601E23E RID: 123454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E23E")]
		[Address(RVA = "0x17CF6A0", Offset = "0x17CE2A0", VA = "0x1817CF6A0")]
		public FifthAnnivExploreMapLineViewModel()
		{
		}

		// Token: 0x040281E2 RID: 164322
		[Token(Token = "0x40281E2")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 srcPos;

		// Token: 0x040281E3 RID: 164323
		[Token(Token = "0x40281E3")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 dstPos;

		// Token: 0x040281E4 RID: 164324
		[Token(Token = "0x40281E4")]
		[FieldOffset(Offset = "0x20")]
		public int dstNodeIndex;

		// Token: 0x040281E5 RID: 164325
		[Token(Token = "0x40281E5")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector2> lineCornerPosList;

		// Token: 0x040281E6 RID: 164326
		[Token(Token = "0x40281E6")]
		[FieldOffset(Offset = "0x30")]
		public FifthAnnivRouteType routeType;

		// Token: 0x040281E7 RID: 164327
		[Token(Token = "0x40281E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
