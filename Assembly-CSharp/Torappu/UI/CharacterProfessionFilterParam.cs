using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003507 RID: 13575
	[Token(Token = "0x2003507")]
	public struct CharacterProfessionFilterParam
	{
		// Token: 0x04019F86 RID: 106374
		[Token(Token = "0x4019F86")]
		[FieldOffset(Offset = "0x0")]
		public bool isAll;

		// Token: 0x04019F87 RID: 106375
		[Token(Token = "0x4019F87")]
		[FieldOffset(Offset = "0x4")]
		public ProfessionCategory profession;

		// Token: 0x04019F88 RID: 106376
		[Token(Token = "0x4019F88")]
		[FieldOffset(Offset = "0x8")]
		public string subProfessionId;
	}
}
