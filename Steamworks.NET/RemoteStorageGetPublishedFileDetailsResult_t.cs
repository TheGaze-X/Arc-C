using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[CallbackIdentity(1318)]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000F")]
		public string m_rgchTitle
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x4EE1D30", Offset = "0x4EE0930", VA = "0x184EE1D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x4F0D1C0", Offset = "0x4F0BDC0", VA = "0x184F0D1C0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000010")]
		public string m_rgchDescription
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x4F0CF80", Offset = "0x4F0BB80", VA = "0x184F0CF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x4F0D180", Offset = "0x4F0BD80", VA = "0x184F0D180")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000011")]
		public string m_rgchTags
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x4F0D020", Offset = "0x4F0BC20", VA = "0x184F0D020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x4F0D1A0", Offset = "0x4F0BDA0", VA = "0x184F0D1A0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000012")]
		public string m_pchFileName
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x4F0CEE0", Offset = "0x4F0BAE0", VA = "0x184F0CEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x4F0D160", Offset = "0x4F0BD60", VA = "0x184F0D160")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000013")]
		public string m_rgchURL
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x4F0D0C0", Offset = "0x4F0BCC0", VA = "0x184F0D0C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x4F0D1E0", Offset = "0x4F0BDE0", VA = "0x184F0D1E0")]
			set
			{
			}
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		public const int k_iCallback = 1318;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchTitle_;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x20")]
		private byte[] m_rgchDescription_;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hFile;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x30")]
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x38")]
		public ulong m_ulSteamIDOwner;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x40")]
		public uint m_rtimeCreated;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x44")]
		public uint m_rtimeUpdated;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x48")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x4C")]
		public bool m_bBanned;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x50")]
		private byte[] m_rgchTags_;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x58")]
		public bool m_bTagsTruncated;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_pchFileName_;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x70")]
		private byte[] m_rgchURL_;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x78")]
		public EWorkshopFileType m_eFileType;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x7C")]
		public bool m_bAcceptedForUse;
	}
}
