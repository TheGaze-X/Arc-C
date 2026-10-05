using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	internal struct RenderChainTextEntry
	{
		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x0")]
		internal RenderChainCommand command;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x8")]
		internal int firstVertex;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0xC")]
		internal int vertexCount;
	}
}
