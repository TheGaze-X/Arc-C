using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	internal struct IntervalTreeNode
	{
		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		public long center;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x8")]
		public int first;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xC")]
		public int last;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		public int left;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x14")]
		public int right;
	}
}
