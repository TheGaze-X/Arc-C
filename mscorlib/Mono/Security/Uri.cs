using System;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	internal class Uri
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4ABF190", Offset = "0x4ABDD90", VA = "0x184ABF190")]
		public Uri(string uriString)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4ABEF80", Offset = "0x4ABDB80", VA = "0x184ABEF80")]
		public Uri(string uriString, bool dontEscape)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000019")]
		public string AbsolutePath
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x1700001A")]
		public bool IsFile
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x4ABF1A0", Offset = "0x4ABDDA0", VA = "0x184ABF1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x1700001B")]
		public bool IsUnc
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700001C")]
		public string LocalPath
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4ABF210", Offset = "0x4ABDE10", VA = "0x184ABF210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4ABB4A0", Offset = "0x4ABA0A0", VA = "0x184ABB4A0", Slot = "0")]
		public override bool Equals(object comparant)
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4ABBD20", Offset = "0x4ABA920", VA = "0x184ABBD20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4ABBEA0", Offset = "0x4ABAAA0", VA = "0x184ABBEA0")]
		public string GetLeftPart(UriPartial part)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4ABBB50", Offset = "0x4ABA750", VA = "0x184ABBB50")]
		public static int FromHex(char digit)
		{
			return 0;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4ABC610", Offset = "0x4ABB210", VA = "0x184ABC610")]
		public static string HexEscape(char character)
		{
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4ABC780", Offset = "0x4ABB380", VA = "0x184ABC780")]
		public static char HexUnescape(string pattern, ref int index)
		{
			return '\0';
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4ABCA90", Offset = "0x4ABB690", VA = "0x184ABCA90")]
		public static bool IsHexDigit(char digit)
		{
			return default(bool);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4ABCAC0", Offset = "0x4ABB6C0", VA = "0x184ABCAC0")]
		public static bool IsHexEncoding(string pattern, int index)
		{
			return default(bool);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4ABE690", Offset = "0x4ABD290", VA = "0x184ABE690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4ABBAF0", Offset = "0x4ABA6F0", VA = "0x184ABBAF0")]
		protected static string EscapeString(string str)
		{
			return null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4ABB700", Offset = "0x4ABA300", VA = "0x184ABB700")]
		internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets)
		{
			return null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4ABD2A0", Offset = "0x4ABBEA0", VA = "0x184ABD2A0")]
		protected void Parse()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4ABE930", Offset = "0x4ABD530", VA = "0x184ABE930")]
		protected string Unescape(string str)
		{
			return null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4ABE7A0", Offset = "0x4ABD3A0", VA = "0x184ABE7A0")]
		internal string Unescape(string str, bool excludeSharp)
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4ABD090", Offset = "0x4ABBC90", VA = "0x184ABD090")]
		private void ParseAsWindowsUNC(string uriString)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4ABCEE0", Offset = "0x4ABBAE0", VA = "0x184ABCEE0")]
		private void ParseAsWindowsAbsoluteFilePath(string uriString)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4ABCD30", Offset = "0x4ABB930", VA = "0x184ABCD30")]
		private void ParseAsUnixAbsoluteFilePath(string uriString)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4ABD3A0", Offset = "0x4ABBFA0", VA = "0x184ABD3A0")]
		private void Parse(string uriString)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4ABE3B0", Offset = "0x4ABCFB0", VA = "0x184ABE3B0")]
		private static string Reduce(string path)
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4ABC4C0", Offset = "0x4ABB0C0", VA = "0x184ABC4C0")]
		internal static string GetSchemeDelimiter(string scheme)
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4ABBBF0", Offset = "0x4ABA7F0", VA = "0x184ABBBF0")]
		internal static int GetDefaultPort(string scheme)
		{
			return 0;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4ABC310", Offset = "0x4ABAF10", VA = "0x184ABC310")]
		private string GetOpaqueWiseSchemeDelimiter()
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4ABCBE0", Offset = "0x4ABB7E0", VA = "0x184ABCBE0")]
		private static bool IsPredefinedScheme(string scheme)
		{
			return default(bool);
		}

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x10")]
		private bool isUnixFilePath;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x18")]
		private string source;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x20")]
		private string scheme;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x28")]
		private string host;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x30")]
		private int port;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x38")]
		private string path;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x40")]
		private string query;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x48")]
		private string fragment;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x50")]
		private string userinfo;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x58")]
		private bool isUnc;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x59")]
		private bool isOpaquePart;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x5A")]
		private bool userEscaped;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x60")]
		private string cachedToString;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x68")]
		private string cachedLocalPath;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x70")]
		private int cachedHashCode;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x74")]
		private bool reduce;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string hexUpperChars;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string SchemeDelimiter;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string UriSchemeFile;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string UriSchemeFtp;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string UriSchemeGopher;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string UriSchemeHttp;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string UriSchemeHttps;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string UriSchemeMailto;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string UriSchemeNews;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string UriSchemeNntp;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x50")]
		private static Uri.UriScheme[] schemes;

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		private struct UriScheme
		{
			// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xB42DA0", Offset = "0xB419A0", VA = "0x180B42DA0")]
			public UriScheme(string s, string d, int p)
			{
			}

			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x0")]
			public string scheme;

			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			[FieldOffset(Offset = "0x8")]
			public string delimiter;

			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			[FieldOffset(Offset = "0x10")]
			public int defaultPort;
		}
	}
}
