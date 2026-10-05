using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020AD RID: 8365
	[Token(Token = "0x20020AD")]
	public struct BattleFinishIllust
	{
		// Token: 0x0600CDA0 RID: 52640 RVA: 0x0004A2B0 File Offset: 0x000484B0
		[Token(Token = "0x600CDA0")]
		[Address(RVA = "0x34F8590", Offset = "0x34F7190", VA = "0x1834F8590")]
		public CharUISkinStruct GetValidSkin()
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0400D948 RID: 55624
		[Token(Token = "0x400D948")]
		[FieldOffset(Offset = "0x0")]
		public static BattleFinishIllust EMPTY;

		// Token: 0x0400D949 RID: 55625
		[Token(Token = "0x400D949")]
		[FieldOffset(Offset = "0x0")]
		public int instId;

		// Token: 0x0400D94A RID: 55626
		[Token(Token = "0x400D94A")]
		[FieldOffset(Offset = "0x8")]
		public CharUISkinStruct overrideSkin;

		// Token: 0x0400D94B RID: 55627
		[Token(Token = "0x400D94B")]
		[FieldOffset(Offset = "0x20")]
		public CharWordData overrideCharWord;
	}
}
