using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AF RID: 4271
	[Token(Token = "0x20010AF")]
	[Serializable]
	public class UniCollectionInfo
	{
		// Token: 0x06006E39 RID: 28217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E39")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniCollectionInfo()
		{
		}

		// Token: 0x04005B7C RID: 23420
		[Token(Token = "0x4005B7C")]
		[FieldOffset(Offset = "0x10")]
		public string uniCollectionItemId;

		// Token: 0x04005B7D RID: 23421
		[Token(Token = "0x4005B7D")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> uniqueItem;
	}
}
