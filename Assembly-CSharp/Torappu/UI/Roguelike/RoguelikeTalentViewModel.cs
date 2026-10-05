using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005526 RID: 21798
	[Token(Token = "0x2005526")]
	public struct RoguelikeTalentViewModel
	{
		// Token: 0x0402B4B6 RID: 177334
		[Token(Token = "0x402B4B6")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x0402B4B7 RID: 177335
		[Token(Token = "0x402B4B7")]
		[FieldOffset(Offset = "0x8")]
		public string content;

		// Token: 0x0402B4B8 RID: 177336
		[Token(Token = "0x402B4B8")]
		[FieldOffset(Offset = "0x10")]
		public string rawContent;

		// Token: 0x0402B4B9 RID: 177337
		[Token(Token = "0x402B4B9")]
		[FieldOffset(Offset = "0x18")]
		public CharacterData.UnlockCondition unlockPhase;

		// Token: 0x0402B4BA RID: 177338
		[Token(Token = "0x402B4BA")]
		[FieldOffset(Offset = "0x20")]
		public TalentUnlockType unlock;
	}
}
