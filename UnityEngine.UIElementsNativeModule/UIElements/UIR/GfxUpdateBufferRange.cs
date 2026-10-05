using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal struct GfxUpdateBufferRange
	{
		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		public uint offsetFromWriteStart;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x4")]
		public uint size;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x8")]
		public UIntPtr source;
	}
}
