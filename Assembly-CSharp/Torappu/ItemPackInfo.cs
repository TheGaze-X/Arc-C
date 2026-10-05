using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010B0 RID: 4272
	[Token(Token = "0x20010B0")]
	[Serializable]
	public class ItemPackInfo
	{
		// Token: 0x06006E3A RID: 28218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemPackInfo()
		{
		}

		// Token: 0x04005B7E RID: 23422
		[Token(Token = "0x4005B7E")]
		[FieldOffset(Offset = "0x10")]
		public string packId;

		// Token: 0x04005B7F RID: 23423
		[Token(Token = "0x4005B7F")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> content;
	}
}
