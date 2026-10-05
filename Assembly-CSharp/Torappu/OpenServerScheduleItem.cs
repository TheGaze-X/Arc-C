using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001121 RID: 4385
	[Token(Token = "0x2001121")]
	public class OpenServerScheduleItem
	{
		// Token: 0x06006EE5 RID: 28389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerScheduleItem()
		{
		}

		// Token: 0x04005DF7 RID: 24055
		[Token(Token = "0x4005DF7")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005DF8 RID: 24056
		[Token(Token = "0x4005DF8")]
		[FieldOffset(Offset = "0x18")]
		public string versionId;

		// Token: 0x04005DF9 RID: 24057
		[Token(Token = "0x4005DF9")]
		[FieldOffset(Offset = "0x20")]
		public int startTs;

		// Token: 0x04005DFA RID: 24058
		[Token(Token = "0x4005DFA")]
		[FieldOffset(Offset = "0x24")]
		public int endTs;

		// Token: 0x04005DFB RID: 24059
		[Token(Token = "0x4005DFB")]
		[FieldOffset(Offset = "0x28")]
		public string totalCheckinDescption;

		// Token: 0x04005DFC RID: 24060
		[Token(Token = "0x4005DFC")]
		[FieldOffset(Offset = "0x30")]
		public string chainLoginDescription;

		// Token: 0x04005DFD RID: 24061
		[Token(Token = "0x4005DFD")]
		[FieldOffset(Offset = "0x38")]
		public string charImg;
	}
}
