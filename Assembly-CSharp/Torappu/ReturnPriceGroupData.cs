using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001144 RID: 4420
	[Token(Token = "0x2001144")]
	public class ReturnPriceGroupData
	{
		// Token: 0x06006F21 RID: 28449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F21")]
		[Address(RVA = "0x2110020", Offset = "0x210EC20", VA = "0x182110020")]
		public ReturnPriceGroupData()
		{
		}

		// Token: 0x04005EBD RID: 24253
		[Token(Token = "0x4005EBD")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EBE RID: 24254
		[Token(Token = "0x4005EBE")]
		[FieldOffset(Offset = "0x18")]
		public List<ReturnPriceItemData> content;
	}
}
