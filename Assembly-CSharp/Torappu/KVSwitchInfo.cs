using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E79 RID: 3705
	[Token(Token = "0x2000E79")]
	public class KVSwitchInfo
	{
		// Token: 0x06006B43 RID: 27459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B43")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KVSwitchInfo()
		{
		}

		// Token: 0x04004E0A RID: 19978
		[Token(Token = "0x4004E0A")]
		[FieldOffset(Offset = "0x10")]
		public bool isDefault;

		// Token: 0x04004E0B RID: 19979
		[Token(Token = "0x4004E0B")]
		[FieldOffset(Offset = "0x18")]
		public long displayTime;

		// Token: 0x04004E0C RID: 19980
		[Token(Token = "0x4004E0C")]
		[FieldOffset(Offset = "0x20")]
		public string zoneId;
	}
}
