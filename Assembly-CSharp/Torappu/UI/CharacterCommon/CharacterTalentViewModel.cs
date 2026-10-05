using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FD1 RID: 24529
	[Token(Token = "0x2005FD1")]
	public struct CharacterTalentViewModel
	{
		// Token: 0x040310EC RID: 200940
		[Token(Token = "0x40310EC")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x040310ED RID: 200941
		[Token(Token = "0x40310ED")]
		[FieldOffset(Offset = "0x8")]
		public string content;

		// Token: 0x040310EE RID: 200942
		[Token(Token = "0x40310EE")]
		[FieldOffset(Offset = "0x10")]
		public string rawContent;

		// Token: 0x040310EF RID: 200943
		[Token(Token = "0x40310EF")]
		[FieldOffset(Offset = "0x18")]
		public CharacterData.UnlockCondition unlockPhase;

		// Token: 0x040310F0 RID: 200944
		[Token(Token = "0x40310F0")]
		[FieldOffset(Offset = "0x20")]
		public TalentUnlockType unlock;

		// Token: 0x040310F1 RID: 200945
		[Token(Token = "0x40310F1")]
		[FieldOffset(Offset = "0x28")]
		public string tokenKey;
	}
}
