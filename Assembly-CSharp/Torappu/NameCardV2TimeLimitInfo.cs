using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FFF RID: 4095
	[Token(Token = "0x2000FFF")]
	[Serializable]
	public class NameCardV2TimeLimitInfo
	{
		// Token: 0x06006D58 RID: 27992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D58")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NameCardV2TimeLimitInfo()
		{
		}

		// Token: 0x040056D8 RID: 22232
		[Token(Token = "0x40056D8")]
		[FieldOffset(Offset = "0x10")]
		public string limitId;

		// Token: 0x040056D9 RID: 22233
		[Token(Token = "0x40056D9")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x040056DA RID: 22234
		[Token(Token = "0x40056DA")]
		[FieldOffset(Offset = "0x20")]
		public long availStartTime;

		// Token: 0x040056DB RID: 22235
		[Token(Token = "0x40056DB")]
		[FieldOffset(Offset = "0x28")]
		public long availEndTime;
	}
}
