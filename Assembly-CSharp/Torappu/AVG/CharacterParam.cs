using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F50 RID: 8016
	[Token(Token = "0x2001F50")]
	public struct CharacterParam
	{
		// Token: 0x0400CD29 RID: 52521
		[Token(Token = "0x400CD29")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x0400CD2A RID: 52522
		[Token(Token = "0x400CD2A")]
		[FieldOffset(Offset = "0x4")]
		public float blackStart;

		// Token: 0x0400CD2B RID: 52523
		[Token(Token = "0x400CD2B")]
		[FieldOffset(Offset = "0x8")]
		public float blackEnd;

		// Token: 0x0400CD2C RID: 52524
		[Token(Token = "0x400CD2C")]
		[FieldOffset(Offset = "0xC")]
		public bool blackMaskInverse;

		// Token: 0x0400CD2D RID: 52525
		[Token(Token = "0x400CD2D")]
		[FieldOffset(Offset = "0xD")]
		public bool enableGlitch;

		// Token: 0x0400CD2E RID: 52526
		[Token(Token = "0x400CD2E")]
		[FieldOffset(Offset = "0x10")]
		public string materialSettingName;
	}
}
