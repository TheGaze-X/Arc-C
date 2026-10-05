using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public sealed class ZipConstants
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public static int DefaultCodePage
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x4A5AB00", Offset = "0x4A59700", VA = "0x184A5AB00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x4A5AB50", Offset = "0x4A59750", VA = "0x184A5AB50")]
			set
			{
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x4A5A8A0", Offset = "0x4A594A0", VA = "0x184A5A8A0")]
		public static string ConvertToString(byte[] data, int count)
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x4A5A9C0", Offset = "0x4A595C0", VA = "0x184A5A9C0")]
		public static string ConvertToString(byte[] data)
		{
			return null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x4A5A7C0", Offset = "0x4A593C0", VA = "0x184A5A7C0")]
		public static string ConvertToStringExt(int flags, byte[] data, int count)
		{
			return null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x4A5A6F0", Offset = "0x4A592F0", VA = "0x184A5A6F0")]
		public static string ConvertToStringExt(int flags, byte[] data)
		{
			return null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x4A5A5F0", Offset = "0x4A591F0", VA = "0x184A5A5F0")]
		public static byte[] ConvertToArray(string str)
		{
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x4A5A4A0", Offset = "0x4A590A0", VA = "0x184A5A4A0")]
		public static byte[] ConvertToArray(int flags, string str)
		{
			return null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private ZipConstants()
		{
		}

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		public const int VersionMadeBy = 51;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[Obsolete("Use VersionMadeBy instead")]
		public const int VERSION_MADE_BY = 51;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		public const int VersionStrongEncryption = 50;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[Obsolete("Use VersionStrongEncryption instead")]
		public const int VERSION_STRONG_ENCRYPTION = 50;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		public const int VERSION_AES = 51;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		public const int VersionZip64 = 45;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		public const int LocalHeaderBaseSize = 30;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[Obsolete("Use LocalHeaderBaseSize instead")]
		public const int LOCHDR = 30;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		public const int Zip64DataDescriptorSize = 24;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		public const int DataDescriptorSize = 16;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[Obsolete("Use DataDescriptorSize instead")]
		public const int EXTHDR = 16;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		public const int CentralHeaderBaseSize = 46;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[Obsolete("Use CentralHeaderBaseSize instead")]
		public const int CENHDR = 46;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		public const int EndOfCentralRecordBaseSize = 22;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[Obsolete("Use EndOfCentralRecordBaseSize instead")]
		public const int ENDHDR = 22;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		public const int CryptoHeaderSize = 12;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[Obsolete("Use CryptoHeaderSize instead")]
		public const int CRYPTO_HEADER_SIZE = 12;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		public const int LocalHeaderSignature = 67324752;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[Obsolete("Use LocalHeaderSignature instead")]
		public const int LOCSIG = 67324752;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		public const int SpanningSignature = 134695760;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[Obsolete("Use SpanningSignature instead")]
		public const int SPANNINGSIG = 134695760;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		public const int SpanningTempSignature = 808471376;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[Obsolete("Use SpanningTempSignature instead")]
		public const int SPANTEMPSIG = 808471376;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		public const int DataDescriptorSignature = 134695760;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[Obsolete("Use DataDescriptorSignature instead")]
		public const int EXTSIG = 134695760;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[Obsolete("Use CentralHeaderSignature instead")]
		public const int CENSIG = 33639248;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		public const int CentralHeaderSignature = 33639248;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		public const int Zip64CentralFileHeaderSignature = 101075792;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[Obsolete("Use Zip64CentralFileHeaderSignature instead")]
		public const int CENSIG64 = 101075792;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		public const int Zip64CentralDirLocatorSignature = 117853008;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		public const int ArchiveExtraDataSignature = 117853008;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		public const int CentralHeaderDigitalSignature = 84233040;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[Obsolete("Use CentralHeaderDigitalSignaure instead")]
		public const int CENDIGITALSIG = 84233040;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		public const int EndOfCentralDirectorySignature = 101010256;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[Obsolete("Use EndOfCentralDirectorySignature instead")]
		public const int ENDSIG = 101010256;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		private static int defaultCodePage;
	}
}
