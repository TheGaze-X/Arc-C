using System;
using Il2CppDummyDll;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED1 RID: 20177
	[Token(Token = "0x2004ED1")]
	public class FifthAnnivExploreOnStateChangedArgs
	{
		// Token: 0x0601E19E RID: 123294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E19E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreOnStateChangedArgs()
		{
		}

		// Token: 0x040280C9 RID: 164041
		[Token(Token = "0x40280C9")]
		[FieldOffset(Offset = "0x10")]
		public Type stateType;

		// Token: 0x040280CA RID: 164042
		[Token(Token = "0x40280CA")]
		[FieldOffset(Offset = "0x18")]
		public bool isBack;

		// Token: 0x040280CB RID: 164043
		[Token(Token = "0x40280CB")]
		[FieldOffset(Offset = "0x20")]
		public StateEngine.OnStateChangeListener.Additions additions;
	}
}
