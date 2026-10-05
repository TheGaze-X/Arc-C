using System;
using Il2CppDummyDll;

namespace BestHTTP.Forms
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	public sealed class HTTPUrlEncodedForm : HTTPFormBase
	{
		// Token: 0x06002905 RID: 10501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x53AA830", Offset = "0x53A9430", VA = "0x1853AA830", Slot = "5")]
		public override void PrepareRequest(HTTPRequest request)
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x53AA5F0", Offset = "0x53A91F0", VA = "0x1853AA5F0", Slot = "6")]
		public override byte[] GetData()
		{
			return null;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x53AA480", Offset = "0x53A9080", VA = "0x1853AA480")]
		public static string EscapeString(string originalString)
		{
			return null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002908")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HTTPUrlEncodedForm()
		{
		}

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		private const int EscapeTreshold = 256;

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] CachedData;
	}
}
