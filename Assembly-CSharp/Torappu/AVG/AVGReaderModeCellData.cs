using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F37 RID: 7991
	[Token(Token = "0x2001F37")]
	public class AVGReaderModeCellData : IHotfixable
	{
		// Token: 0x0600C6B2 RID: 50866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6B2")]
		[Address(RVA = "0x347F000", Offset = "0x347DC00", VA = "0x18347F000")]
		public AVGReaderModeCellData()
		{
		}

		// Token: 0x0400CC1C RID: 52252
		[Token(Token = "0x400CC1C")]
		[FieldOffset(Offset = "0x10")]
		public string dialogName;

		// Token: 0x0400CC1D RID: 52253
		[Token(Token = "0x400CC1D")]
		[FieldOffset(Offset = "0x18")]
		public string dialogContent;

		// Token: 0x0400CC1E RID: 52254
		[Token(Token = "0x400CC1E")]
		[FieldOffset(Offset = "0x20")]
		public bool isCurrent;

		// Token: 0x0400CC1F RID: 52255
		[Token(Token = "0x400CC1F")]
		[FieldOffset(Offset = "0x21")]
		public bool isDecision;

		// Token: 0x0400CC20 RID: 52256
		[Token(Token = "0x400CC20")]
		[FieldOffset(Offset = "0x24")]
		public int decisionIndex;

		// Token: 0x0400CC21 RID: 52257
		[Token(Token = "0x400CC21")]
		[FieldOffset(Offset = "0x28")]
		public int decisionLineNumber;

		// Token: 0x0400CC22 RID: 52258
		[Token(Token = "0x400CC22")]
		[FieldOffset(Offset = "0x2C")]
		public bool isEndtip;

		// Token: 0x0400CC23 RID: 52259
		[Token(Token = "0x400CC23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
