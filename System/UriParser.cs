using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public abstract class UriParser
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		internal string SchemeName
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x170000B8")]
		internal int DefaultPort
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "4")]
		protected virtual UriParser OnNewUri()
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x50E2EB0", Offset = "0x50E1AB0", VA = "0x1850E2EB0", Slot = "5")]
		protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x50E3270", Offset = "0x50E1E70", VA = "0x1850E3270", Slot = "6")]
		protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x50E3170", Offset = "0x50E1D70", VA = "0x1850E3170", Slot = "7")]
		protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
		{
			return default(bool);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x50E2AD0", Offset = "0x50E16D0", VA = "0x1850E2AD0", Slot = "8")]
		protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
		{
			return null;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x170000B9")]
		internal static bool ShouldUseLegacyV2Quirks
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x50E4270", Offset = "0x50E2E70", VA = "0x1850E4270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x170000BA")]
		internal UriSyntaxFlags Flags
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return UriSyntaxFlags.None;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x50E3210", Offset = "0x50E1E10", VA = "0x1850E3210")]
		internal bool NotAny(UriSyntaxFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x50E2E50", Offset = "0x50E1A50", VA = "0x1850E2E50")]
		internal bool InFact(UriSyntaxFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x50E3110", Offset = "0x50E1D10", VA = "0x1850E3110")]
		internal bool IsAllSet(UriSyntaxFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x50E31A0", Offset = "0x50E1DA0", VA = "0x1850E31A0")]
		private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
		{
			return default(bool);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x50E4200", Offset = "0x50E2E00", VA = "0x1850E4200")]
		internal UriParser(UriSyntaxFlags flags)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x50E2770", Offset = "0x50E1370", VA = "0x1850E2770")]
		internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x50E2D70", Offset = "0x50E1970", VA = "0x1850E2D70")]
		internal static UriParser GetSyntax(string lwrCaseScheme)
		{
			return null;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x170000BB")]
		internal bool IsSimple
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x50E4260", Offset = "0x50E2E60", VA = "0x1850E4260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x50E2FC0", Offset = "0x50E1BC0", VA = "0x1850E2FC0")]
		internal UriParser InternalOnNewUri()
		{
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x50E30B0", Offset = "0x50E1CB0", VA = "0x1850E30B0")]
		internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x50E3040", Offset = "0x50E1C40", VA = "0x1850E3040")]
		internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
		{
			return null;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x50E2F60", Offset = "0x50E1B60", VA = "0x1850E2F60")]
		internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x50E2EF0", Offset = "0x50E1AF0", VA = "0x1850E2EF0")]
		internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
		{
			return null;
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		private const UriSyntaxFlags SchemeOnlyFlags = UriSyntaxFlags.MayHavePath;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, UriParser> m_Table;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, UriParser> m_TempTable;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x10")]
		private UriSyntaxFlags m_Flags;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x14")]
		private UriSyntaxFlags m_UpdatableFlags;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		private bool m_UpdatableFlagsUsed;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		private const UriSyntaxFlags c_UpdatableFlags = UriSyntaxFlags.UnEscapeDotsAndSlashes;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x1C")]
		private int m_Port;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x20")]
		private string m_Scheme;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		internal const int NoDefaultPort = -1;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		private const int c_InitialTableSize = 25;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x10")]
		internal static UriParser HttpUri;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x18")]
		internal static UriParser HttpsUri;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x20")]
		internal static UriParser WsUri;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x28")]
		internal static UriParser WssUri;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x30")]
		internal static UriParser FtpUri;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x38")]
		internal static UriParser FileUri;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x40")]
		internal static UriParser GopherUri;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x48")]
		internal static UriParser NntpUri;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x50")]
		internal static UriParser NewsUri;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x58")]
		internal static UriParser MailToUri;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x60")]
		internal static UriParser UuidUri;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x68")]
		internal static UriParser TelnetUri;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x70")]
		internal static UriParser LdapUri;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x78")]
		internal static UriParser NetTcpUri;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x80")]
		internal static UriParser NetPipeUri;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x88")]
		internal static UriParser VsMacrosUri;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x90")]
		private static readonly UriParser.UriQuirksVersion s_QuirksVersion;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		private const int c_MaxCapacity = 512;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		private const UriSyntaxFlags UnknownV1SyntaxFlags = UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x94")]
		private static readonly UriSyntaxFlags HttpSyntaxFlags;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		private const UriSyntaxFlags FtpSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x98")]
		private static readonly UriSyntaxFlags FileSyntaxFlags;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		private const UriSyntaxFlags VsmacrosSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		private const UriSyntaxFlags GopherSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		private const UriSyntaxFlags NewsSyntaxFlags = UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		private const UriSyntaxFlags NntpSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		private const UriSyntaxFlags TelnetSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		private const UriSyntaxFlags LdapSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		private const UriSyntaxFlags MailtoSyntaxFlags = UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		private const UriSyntaxFlags NetPipeSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		private const UriSyntaxFlags NetTcpSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x020000C9 RID: 201
		[Token(Token = "0x20000C9")]
		private enum UriQuirksVersion
		{
			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			V2 = 2,
			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			V3
		}

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		private class BuiltInUriParser : UriParser
		{
			// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x50E6670", Offset = "0x50E5270", VA = "0x1850E6670")]
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			{
			}
		}
	}
}
