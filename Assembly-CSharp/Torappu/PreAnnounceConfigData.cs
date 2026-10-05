using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E96 RID: 3734
	[Token(Token = "0x2000E96")]
	public class PreAnnounceConfigData
	{
		// Token: 0x06006B67 RID: 27495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B67")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PreAnnounceConfigData()
		{
		}

		// Token: 0x04004EDA RID: 20186
		[Token(Token = "0x4004EDA")]
		[FieldOffset(Offset = "0x10")]
		public string preAnnounceId;

		// Token: 0x04004EDB RID: 20187
		[Token(Token = "0x4004EDB")]
		[FieldOffset(Offset = "0x18")]
		public PreAnnounceConfigData.PreAnnounceType preAnnounceType;

		// Token: 0x04004EDC RID: 20188
		[Token(Token = "0x4004EDC")]
		[FieldOffset(Offset = "0x1C")]
		public bool actived;

		// Token: 0x02000E97 RID: 3735
		[Token(Token = "0x2000E97")]
		public enum PreAnnounceType
		{
			// Token: 0x04004EDE RID: 20190
			[Token(Token = "0x4004EDE")]
			ALWAYS_OPEN,
			// Token: 0x04004EDF RID: 20191
			[Token(Token = "0x4004EDF")]
			OPEN_ONCE,
			// Token: 0x04004EE0 RID: 20192
			[Token(Token = "0x4004EE0")]
			NEVER_AUTO_OPEN
		}
	}
}
