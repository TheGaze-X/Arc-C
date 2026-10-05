using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	internal struct LineInfo
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public LineInfo(int lineNo, int linePos)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public void Set(int lineNo, int linePos)
		{
		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x0")]
		internal int lineNo;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x4")]
		internal int linePos;
	}
}
