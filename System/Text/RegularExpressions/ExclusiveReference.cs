using System;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	internal sealed class ExclusiveReference
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x50E8E50", Offset = "0x50E7A50", VA = "0x1850E8E50")]
		public RegexRunner Get()
		{
			return null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x50E8EE0", Offset = "0x50E7AE0", VA = "0x1850E8EE0")]
		public void Release(RegexRunner obj)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExclusiveReference()
		{
		}

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x10")]
		private RegexRunner _ref;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x18")]
		private RegexRunner _obj;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x20")]
		private int _locked;
	}
}
