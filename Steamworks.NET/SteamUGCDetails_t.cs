using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public struct SteamUGCDetails_t
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001A")]
		public string m_rgchTitle
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4EE1D30", Offset = "0x4EE0930", VA = "0x184EE1D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x4F0D1C0", Offset = "0x4F0BDC0", VA = "0x184F0D1C0")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001B")]
		public string m_rgchDescription
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x4F0CF80", Offset = "0x4F0BB80", VA = "0x184F0CF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x4F0D180", Offset = "0x4F0BD80", VA = "0x184F0D180")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001C")]
		public string m_rgchTags
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x4F10130", Offset = "0x4F0ED30", VA = "0x184F10130")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x4F101D0", Offset = "0x4F0EDD0", VA = "0x184F101D0")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001D")]
		public string m_pchFileName
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x4F0CEE0", Offset = "0x4F0BAE0", VA = "0x184F0CEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x4F0D160", Offset = "0x4F0BD60", VA = "0x184F0D160")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700001E")]
		public string m_rgchURL
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x4F0D0C0", Offset = "0x4F0BCC0", VA = "0x184F0D0C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x4F0D1E0", Offset = "0x4F0BDE0", VA = "0x184F0D1E0")]
			set
			{
			}
		}

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchTitle_;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x20")]
		private byte[] m_rgchDescription_;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x28")]
		public ulong m_ulSteamIDOwner;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0x30")]
		public uint m_rtimeCreated;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x34")]
		public uint m_rtimeUpdated;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x38")]
		public uint m_rtimeAddedToUserList;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x3C")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x40")]
		public bool m_bBanned;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x41")]
		public bool m_bAcceptedForUse;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x42")]
		public bool m_bTagsTruncated;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x48")]
		private byte[] m_rgchTags_;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x50")]
		public UGCHandle_t m_hFile;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x58")]
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_pchFileName_;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x70")]
		private byte[] m_rgchURL_;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x78")]
		public uint m_unVotesUp;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x7C")]
		public uint m_unVotesDown;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x80")]
		public float m_flScore;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x84")]
		public uint m_unNumChildren;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x88")]
		public ulong m_ulTotalFilesSize;
	}
}
