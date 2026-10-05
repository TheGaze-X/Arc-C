using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public class UnbindGrantRequest : APIV2RequestBase
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnbindGrantRequest()
		{
		}

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x20")]
		public string phoneCode;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x28")]
		public string appCode;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x38")]
		public string idCardNum;
	}
}
