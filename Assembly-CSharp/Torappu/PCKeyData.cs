using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200101A RID: 4122
	[Token(Token = "0x200101A")]
	public class PCKeyData
	{
		// Token: 0x06006D6D RID: 28013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0x21090A0", Offset = "0x2107CA0", VA = "0x1821090A0")]
		public PCKeyData()
		{
		}

		// Token: 0x0400578D RID: 22413
		[Token(Token = "0x400578D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, KeyItem> keyList;

		// Token: 0x0400578E RID: 22414
		[Token(Token = "0x400578E")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, KeySettingGroupData> keySettingData;

		// Token: 0x0400578F RID: 22415
		[Token(Token = "0x400578F")]
		[FieldOffset(Offset = "0x20")]
		public PCKeyConstData constData;
	}
}
