using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public struct BatchVisibility
	{
		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x0")]
		public readonly int offset;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x4")]
		public readonly int instancesCount;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x8")]
		public int visibleCount;
	}
}
