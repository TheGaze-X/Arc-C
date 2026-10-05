using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[CallbackIdentity(1307)]
	public struct RemoteStorageFileShareResult_t
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000D")]
		public string m_rgchFilename
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x4ED76A0", Offset = "0x4ED62A0", VA = "0x184ED76A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x4F0CEC0", Offset = "0x4F0BAC0", VA = "0x184F0CEC0")]
			set
			{
			}
		}

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		public const int k_iCallback = 1307;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchFilename_;
	}
}
