using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	internal interface IPointerEventInternal
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C9B RID: 3227
		// (set) Token: 0x06000C9C RID: 3228
		[Token(Token = "0x170002D8")]
		bool triggeredByOS { [Token(Token = "0x6000C9B")] get; [Token(Token = "0x6000C9C")] set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C9D RID: 3229
		// (set) Token: 0x06000C9E RID: 3230
		[Token(Token = "0x170002D9")]
		bool recomputeTopElementUnderPointer { [Token(Token = "0x6000C9D")] get; [Token(Token = "0x6000C9E")] set; }
	}
}
