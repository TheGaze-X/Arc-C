using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013BD RID: 5053
	[Token(Token = "0x20013BD")]
	[Serializable]
	public class NewVoiceTimeData
	{
		// Token: 0x060073A9 RID: 29609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NewVoiceTimeData()
		{
		}

		// Token: 0x04007055 RID: 28757
		[Token(Token = "0x4007055")]
		[FieldOffset(Offset = "0x10")]
		public long timestamp;

		// Token: 0x04007056 RID: 28758
		[Token(Token = "0x4007056")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<string> charSet;
	}
}
