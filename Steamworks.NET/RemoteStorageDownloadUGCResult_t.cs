using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[CallbackIdentity(1317)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000E")]
		public string m_pchFileName
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x4EE1D30", Offset = "0x4EE0930", VA = "0x184EE1D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x4F0CEA0", Offset = "0x4F0BAA0", VA = "0x184F0CEA0")]
			set
			{
			}
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		public const int k_iCallback = 1317;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_pchFileName_;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
}
