using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal struct FontStyleStack
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x58C4610", Offset = "0x58C3210", VA = "0x1858C4610")]
		public void Clear()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x58C4570", Offset = "0x58C3170", VA = "0x1858C4570")]
		public byte Add(FontStyles style)
		{
			return 0;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x59FE560", Offset = "0x59FD160", VA = "0x1859FE560")]
		public byte Remove(FontStyles style)
		{
			return 0;
		}

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x0")]
		public byte bold;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x1")]
		public byte italic;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x2")]
		public byte underline;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x3")]
		public byte strikethrough;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x4")]
		public byte highlight;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x5")]
		public byte superscript;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x6")]
		public byte subscript;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x7")]
		public byte uppercase;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x8")]
		public byte lowercase;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x9")]
		public byte smallcaps;
	}
}
