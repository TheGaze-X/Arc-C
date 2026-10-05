using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3F RID: 3135
	[Token(Token = "0x2000C3F")]
	[Serializable]
	public class ActArchivePicData
	{
		// Token: 0x0600691F RID: 26911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691F")]
		[Address(RVA = "0x1FF8CC0", Offset = "0x1FF78C0", VA = "0x181FF8CC0")]
		public ActArchivePicData()
		{
		}

		// Token: 0x04004003 RID: 16387
		[Token(Token = "0x4004003")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchivePicItemData> pics;
	}
}
