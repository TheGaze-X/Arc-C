using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x02006063 RID: 24675
	[Token(Token = "0x2006063")]
	public struct CarvingCardSelectStatus
	{
		// Token: 0x040316F9 RID: 202489
		[Token(Token = "0x40316F9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CarvingCardSelectStatus NONE;

		// Token: 0x040316FA RID: 202490
		[Token(Token = "0x40316FA")]
		[FieldOffset(Offset = "0x0")]
		public string cardId;

		// Token: 0x040316FB RID: 202491
		[Token(Token = "0x40316FB")]
		[FieldOffset(Offset = "0x8")]
		public CarvingCardPosition cardPos;
	}
}
