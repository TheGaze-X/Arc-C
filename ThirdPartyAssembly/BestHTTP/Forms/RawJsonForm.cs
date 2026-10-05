using System;
using Il2CppDummyDll;

namespace BestHTTP.Forms
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	public sealed class RawJsonForm : HTTPFormBase
	{
		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x53AE3A0", Offset = "0x53ACFA0", VA = "0x1853AE3A0", Slot = "5")]
		public override void PrepareRequest(HTTPRequest request)
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x53AE0C0", Offset = "0x53ACCC0", VA = "0x1853AE0C0", Slot = "6")]
		public override byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RawJsonForm()
		{
		}

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x20")]
		private byte[] CachedData;
	}
}
