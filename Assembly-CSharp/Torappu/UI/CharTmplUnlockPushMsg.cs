using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003509 RID: 13577
	[Token(Token = "0x2003509")]
	public struct CharTmplUnlockPushMsg
	{
		// Token: 0x06015A99 RID: 88729 RVA: 0x0008D588 File Offset: 0x0008B788
		[Token(Token = "0x6015A99")]
		[Address(RVA = "0xE304A0", Offset = "0xE2F0A0", VA = "0x180E304A0")]
		public bool IsOriginUnlock()
		{
			return default(bool);
		}

		// Token: 0x04019F92 RID: 106386
		[Token(Token = "0x4019F92")]
		private const string ORIGIN_CHAR = "char_002_amiya";

		// Token: 0x04019F93 RID: 106387
		[Token(Token = "0x4019F93")]
		private const string ORIGIN_TMPL = "char_1001_amiya2";

		// Token: 0x04019F94 RID: 106388
		[Token(Token = "0x4019F94")]
		[FieldOffset(Offset = "0x0")]
		public int instId;

		// Token: 0x04019F95 RID: 106389
		[Token(Token = "0x4019F95")]
		[FieldOffset(Offset = "0x8")]
		public string charId;

		// Token: 0x04019F96 RID: 106390
		[Token(Token = "0x4019F96")]
		[FieldOffset(Offset = "0x10")]
		public string templateId;

		// Token: 0x04019F97 RID: 106391
		[Token(Token = "0x4019F97")]
		[FieldOffset(Offset = "0x18")]
		public bool changed;
	}
}
