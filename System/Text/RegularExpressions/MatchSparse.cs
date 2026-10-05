using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal class MatchSparse : Match
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x50EBC60", Offset = "0x50EA860", VA = "0x1850EBC60")]
		internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E6")]
		public override GroupCollection Groups
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x50EBD10", Offset = "0x50EA910", VA = "0x1850EBD10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x78")]
		internal new readonly Hashtable _caps;
	}
}
