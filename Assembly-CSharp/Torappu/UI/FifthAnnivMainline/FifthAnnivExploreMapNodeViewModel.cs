using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF1 RID: 20209
	[Token(Token = "0x2004EF1")]
	public class FifthAnnivExploreMapNodeViewModel : IHotfixable
	{
		// Token: 0x0601E23C RID: 123452 RVA: 0x000ADA18 File Offset: 0x000ABC18
		[Token(Token = "0x601E23C")]
		[Address(RVA = "0x17CF700", Offset = "0x17CE300", VA = "0x1817CF700")]
		public bool IsCurrentNode(int currentIndex)
		{
			return default(bool);
		}

		// Token: 0x0601E23D RID: 123453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E23D")]
		[Address(RVA = "0x17CF780", Offset = "0x17CE380", VA = "0x1817CF780")]
		public FifthAnnivExploreMapNodeViewModel()
		{
		}

		// Token: 0x040281DC RID: 164316
		[Token(Token = "0x40281DC")]
		[FieldOffset(Offset = "0x10")]
		public int indexInRoute;

		// Token: 0x040281DD RID: 164317
		[Token(Token = "0x40281DD")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 pos;

		// Token: 0x040281DE RID: 164318
		[Token(Token = "0x40281DE")]
		[FieldOffset(Offset = "0x1C")]
		public FifthAnnivNodeType nodeType;

		// Token: 0x040281DF RID: 164319
		[Token(Token = "0x40281DF")]
		[FieldOffset(Offset = "0x20")]
		public FifthAnnivRouteType routeType;

		// Token: 0x040281E0 RID: 164320
		[Token(Token = "0x40281E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCurrentNode;

		// Token: 0x040281E1 RID: 164321
		[Token(Token = "0x40281E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
