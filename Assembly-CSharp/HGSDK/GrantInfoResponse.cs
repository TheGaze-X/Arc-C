using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public class GrantInfoResponse : APIV2ResponseBase
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1028600", Offset = "0x1027200", VA = "0x181028600")]
		public GrantInfoResponse()
		{
		}

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		public const int STATUS_ALREADY_UNBIND = 102;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x20")]
		public long delete_request_ts;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x28")]
		public long delete_commit_ts;
	}
}
