using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public struct TMP_FontStyleStack
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x58C4610", Offset = "0x58C3210", VA = "0x1858C4610")]
		public void Clear()
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x58C4570", Offset = "0x58C3170", VA = "0x1858C4570")]
		public byte Add(FontStyles style)
		{
			return 0;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x58C4620", Offset = "0x58C3220", VA = "0x1858C4620")]
		public byte Remove(FontStyles style)
		{
			return 0;
		}

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x0")]
		public byte bold;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x1")]
		public byte italic;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x2")]
		public byte underline;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x3")]
		public byte strikethrough;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x4")]
		public byte highlight;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x5")]
		public byte superscript;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x6")]
		public byte subscript;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x7")]
		public byte uppercase;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x8")]
		public byte lowercase;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x9")]
		public byte smallcaps;
	}
}
