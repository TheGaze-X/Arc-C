using System;
using Il2CppDummyDll;

namespace BestHTTP.Forms
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public sealed class HTTPMultiPartForm : HTTPFormBase
	{
		// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x53A5100", Offset = "0x53A3D00", VA = "0x1853A5100")]
		public HTTPMultiPartForm()
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x53A5070", Offset = "0x53A3C70", VA = "0x1853A5070", Slot = "5")]
		public override void PrepareRequest(HTTPRequest request)
		{
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x53A49E0", Offset = "0x53A35E0", VA = "0x1853A49E0", Slot = "6")]
		public override byte[] GetData()
		{
			return null;
		}

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x20")]
		private string Boundary;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x28")]
		private byte[] CachedData;
	}
}
