using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	internal sealed class RegexCode
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x50F9AD0", Offset = "0x50F86D0", VA = "0x1850F9AD0")]
		public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x50F9A70", Offset = "0x50F8670", VA = "0x1850F9A70")]
		public static bool OpcodeBacktracks(int Op)
		{
			return default(bool);
		}

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		public const int Onerep = 0;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		public const int Notonerep = 1;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		public const int Setrep = 2;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		public const int Oneloop = 3;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		public const int Notoneloop = 4;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		public const int Setloop = 5;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		public const int Onelazy = 6;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		public const int Notonelazy = 7;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		public const int Setlazy = 8;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		public const int One = 9;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		public const int Notone = 10;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		public const int Set = 11;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		public const int Multi = 12;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		public const int Ref = 13;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		public const int Bol = 14;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		public const int Eol = 15;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		public const int Boundary = 16;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		public const int Nonboundary = 17;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		public const int Beginning = 18;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		public const int Start = 19;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		public const int EndZ = 20;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		public const int End = 21;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		public const int Nothing = 22;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		public const int Lazybranch = 23;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		public const int Branchmark = 24;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		public const int Lazybranchmark = 25;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		public const int Nullcount = 26;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		public const int Setcount = 27;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		public const int Branchcount = 28;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		public const int Lazybranchcount = 29;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		public const int Nullmark = 30;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		public const int Setmark = 31;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		public const int Capturemark = 32;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		public const int Getmark = 33;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		public const int Setjump = 34;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		public const int Backjump = 35;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		public const int Forejump = 36;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		public const int Testref = 37;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		public const int Goto = 38;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		public const int Prune = 39;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		public const int Stop = 40;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		public const int ECMABoundary = 41;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		public const int NonECMABoundary = 42;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		public const int Mask = 63;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		public const int Rtl = 64;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		public const int Back = 128;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		public const int Back2 = 256;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		public const int Ci = 512;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x10")]
		public readonly int[] Codes;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x18")]
		public readonly string[] Strings;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x20")]
		public readonly int TrackCount;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x28")]
		public readonly Hashtable Caps;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x30")]
		public readonly int CapSize;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x38")]
		public readonly RegexPrefix? FCPrefix;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x50")]
		public readonly RegexBoyerMoore BMPrefix;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x58")]
		public readonly int Anchors;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x5C")]
		public readonly bool RightToLeft;
	}
}
