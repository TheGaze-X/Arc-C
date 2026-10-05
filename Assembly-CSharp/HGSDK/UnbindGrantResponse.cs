using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public class UnbindGrantResponse : APIV2ResponseBase
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnbindGrantResponse()
		{
		}

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		public const int STATUS_PHONE_ERROR = 5;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		public const int STATUS_IDNAME_ERROR = 103;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x18")]
		public long delete_request_ts;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x20")]
		public long delete_commit_ts;
	}
}
