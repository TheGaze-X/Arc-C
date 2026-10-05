using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	public enum PropagationPhase
	{
		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		None,
		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		TrickleDown,
		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		AtTarget,
		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		DefaultActionAtTarget = 5,
		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		BubbleUp = 3,
		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		DefaultAction
	}
}
