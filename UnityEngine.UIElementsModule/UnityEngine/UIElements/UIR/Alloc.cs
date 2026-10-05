using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	internal struct Alloc
	{
		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x0")]
		public uint start;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x4")]
		public uint size;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x8")]
		internal object handle;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x10")]
		internal bool shortLived;
	}
}
