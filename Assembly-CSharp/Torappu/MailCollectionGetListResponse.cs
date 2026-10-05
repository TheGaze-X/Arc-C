using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class MailCollectionGetListResponse
	{
		// Token: 0x0600643F RID: 25663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MailCollectionGetListResponse()
		{
		}

		// Token: 0x040030D1 RID: 12497
		[Token(Token = "0x40030D1")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "collections")]
		public List<string> unlockIdList;

		// Token: 0x040030D2 RID: 12498
		[Token(Token = "0x40030D2")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "extra")]
		public List<MailArchiveItemData> extraData;
	}
}
